using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Application.Catalog.Categories;
using Project.Application.Catalog.Products;
using Project.Application.Catalog.Users;
using Project.Application.Common;
using Project.Application.Mail;
using Project.Application.Sales;
using Project.Data.EF;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Threading.Tasks;

namespace Project.AdminApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            /*ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) =>
            {
                return (sslPolicyErrors & SslPolicyErrors.RemoteCertificateNotAvailable) != SslPolicyErrors.RemoteCertificateNotAvailable;
            };*/
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            services.AddControllersWithViews();
            var connectionString = Configuration.GetConnectionString("ProjectOnlineShopDb3");
            services.AddDbContext<ProjectDbContext>(options =>
                    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("Project.AdminApp")));

            services.AddRazorPages();
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<ProjectDbContext>()
                .AddDefaultTokenProviders();
            services.AddTransient<IUserService, UserService>();
            services.ConfigureApplicationCookie(options => {
                /*options.Cookie.HttpOnly = true;
                options.Cookie.SameSite = SameSiteMode.Lax;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;*/
                // options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = $"/User/Login";
                options.LogoutPath = $"/User/Logout";
                options.AccessDeniedPath = $"/User/Login";
            });
            // truy cap IdentityOptions
            services.Configure<IdentityOptions>(options => {
                // thiet lap ve  Password
                options.Password.RequireDigit = false; // khong bat phai co so
                options.Password.RequireLowercase = false; // khong bat phai co chu thuong
                options.Password.RequireNonAlphanumeric = false; // khong bat co ki tu dac biet
                options.Password.RequireUppercase = false; // khong bat buoc chu in
                options.Password.RequiredLength = 3; // so ki tu toi thieu cua password
                options.Password.RequiredUniqueChars = 1; // so ki tu rieng biet

                //Cau hinh lockout -khoa user
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1); // khoa 5 phut
                options.Lockout.MaxFailedAccessAttempts = 5; // that bai 5 lan thi khoa
                options.Lockout.AllowedForNewUsers = true;

                // cau hinh ve User.
                options.User.AllowedUserNameCharacters = // cac ki tu dat ten cho user
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;  // Email la duy nhat

                // cau hinh dang nhap
                options.SignIn.RequireConfirmedEmail = true;            // cau hinh xac thuc dia chi email (email phai ton tai)
                options.SignIn.RequireConfirmedPhoneNumber = false;     // xac thuc so dien thoai

            });
            services.AddOptions();                                        // kich hoat Options
            var mailsettings = Configuration.GetSection("MailSettings");  // doc config
            services.Configure<MailSettings>(mailsettings);               // dang ki de  Inject

            services.AddTransient<IEmailSender, SendMailService>();        // dang ki dich vu Mail
            
           
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICartService, CartService>();
            services.AddTransient<IOrderService, OrderService>();
            
            services.AddTransient<IStorageService, FileStorageService>();
            //sadhbashjdbasbhdasbj
            services.AddSession(options =>
            {
                options.IdleTimeout = new TimeSpan(0, 60, 0);
                options.Cookie.Name = "yandere";
            });
            services.AddAuthentication().AddGoogle(googleOptions => {
                //doc thong tin Authentication:Google tu appsettings.json
                IConfigurationSection googleAuthNSection = Configuration.GetSection("Authentication:Google");

                // thiet lap ClientID và ClientSecret de truy cap API google
                googleOptions.ClientId = googleAuthNSection["ClientId"];
                googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];

            });
            
            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                // tren 30 s truy cap lai se nap lai thong tin  User (Role)
                // SecurityStamp trong bang User doi -> nap lai thong tin  Security
                options.ValidationInterval = TimeSpan.FromSeconds(30);
            });
            services.AddAuthorization(options =>
            {

                //  Tao ra Policy co ten MyPolicy1 - nhung User co Role la Vip thi thoa man policy nay
                //options.AddPolicy("MyPolicy1", policy => {
                //    // policy kieu AuthorizationPolicyBuilder, co cac phuong thuc de them yeu cau nhu:
                //    // RequireClaim - User phai co Claim nao do
                //    // RequireRole  - User phai co Role nao do
                //    // RequireUserName - User phai co ten chi ra
                //    // AddRequirements ...
                //    policy.RequireRole("Vip");
                //});

                options.AddPolicy("MyPolicy1", policy => {
                    policy.RequireRole("Vip");
                });

                options.AddPolicy("CanViewTest", policy => {
                    policy.RequireRole("VipMember", "Editor");
                });
                options.AddPolicy("AdminDropdown", policy => {
                    policy.RequireClaim("permission", "manage.user");
                });
            });
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
                options.ForwardLimit = 2;
                options.ForwardedForHeaderName = "Header_Name_Used_By_Proxy_For_X-Forwarded-For_Header";
                options.ForwardedProtoHeaderName = "Header_Name_Used_By_Proxy_For_X-Forwarded-Proto_Header";
                //options.KnownProxies.Add(IPAddress.Parse("103.137.184.108"));
            });
            //services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(@"\\server\share\directory\"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           /* app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });*/
            app.UseForwardedHeaders();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            //app.UseCookiePolicy();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=HomePage}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "{controller=AdminHome}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
