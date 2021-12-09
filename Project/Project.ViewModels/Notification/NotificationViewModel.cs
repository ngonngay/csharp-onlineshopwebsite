using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.Notification
{
    public class NotificationViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public DateTime date { get; set; }

        public NotificationType Type { get; set; }

        public string Targetstr { get; set; }
        public int Targetint { get; set; }

        public string content { get; set; }

        public NotificationStatus Status { get; set; }
    }
}
