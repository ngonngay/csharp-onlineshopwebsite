using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.Sales
{
    public class GetOrderPagingRequest
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int OrderId { get; set; }
        public string username { get; set; }
        public string productName { get; set; }
        public int status { get; set; }
    }
}
