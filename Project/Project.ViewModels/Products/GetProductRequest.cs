using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.Products
{
    public class GetProductRequest
    {
        public string Keyword { get; set; }

        public int? CategoryId { get; set; }
    }
}
