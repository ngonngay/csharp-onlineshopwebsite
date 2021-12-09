using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class District
    {
        public string CityId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public City city { get; set; }

        public List<Ward> Wards { get; set; }
    }
}
