using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Reviews
    {
        public int id { get; set; }
        public int ProductId { get; set; }

        public string email { get; set; }

        public int rating { get; set; }

        public string review { get; set; }

        public Product product { get; set; }
         
    }
}
