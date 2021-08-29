using LabraDog.DAL;
using LabradogApp.Areas.Manage.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabradogApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            dashboardViewModel.ProductCount = _context.Orders.Count();
            dashboardViewModel.PendingCount = _context.Orders.Where(x => x.Status == Enums.OrderStatus.Pending).Count();
            dashboardViewModel.PendingCount = _context.Orders.Where(x => x.Status == Enums.OrderStatus.Accepted).Count();
            dashboardViewModel.PendingCount = _context.Orders.Where(x => x.Status == Enums.OrderStatus.AdminRejected).Count();
            return View(dashboardViewModel);
        }
    }
}
