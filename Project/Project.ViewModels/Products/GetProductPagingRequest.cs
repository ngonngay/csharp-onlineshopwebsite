using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.Products
{
    public class GetProductPagingRequest
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public string keyword { get; set; }
        public string order { get; set; }
        public string listType { get; set; }
        public bool searchByPrice { get; set; }
        public int? id { get; set; }
        public decimal? StartPrice { get; set; }
        public decimal? EndPrice { get; set; }
        public int? categoryId { get; set; }
    }
}
