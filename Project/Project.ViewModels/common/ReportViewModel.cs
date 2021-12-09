using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.common
{
    public class ReportViewModel
    {
        public int NewOrder { get; set; }
        public int ProcessingOrder { get; set; }
        public int SuccessOrder { get; set; }
        public int CancleOrder { get; set; }
    }
}
