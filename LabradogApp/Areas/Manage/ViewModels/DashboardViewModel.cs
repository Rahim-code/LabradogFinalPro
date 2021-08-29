using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabradogApp.Areas.Manage.ViewModels
{
    public class DashboardViewModel
    {
        public int ProductCount {get; set; }
        public int PendingCount { get; set; }
        public int AcceptCount { get; set; }
        public int AdminRejectedCount { get; set; }
    }
}
