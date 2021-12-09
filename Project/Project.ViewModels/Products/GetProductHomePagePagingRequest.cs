using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.Products
{
    public class GetProductHomePagePagingRequest
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public string keyword { get; set; }

        public int? id { get; set; }
        public int? categoryId { get; set; }
    }
}
