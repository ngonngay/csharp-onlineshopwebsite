using Project.ViewModels.Common;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.common
{
    public class PageResult<T> :PagedResultBase
    {
        public List<T> Items { set; get; }
        
    }
}
