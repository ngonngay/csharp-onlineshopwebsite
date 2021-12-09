using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Ward
    {

        public string CityId { get; set; }
        public string DistrictId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public City City { get; set; }
        public District district { get; set; }

    }
}
