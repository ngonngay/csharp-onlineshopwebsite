using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class City
    {
        public string CityId { get; set; }
        public string Name { get; set; }
        public List<District> Districts { get; set; }
        public List<Ward> Wards { get; set; }
    }
}
