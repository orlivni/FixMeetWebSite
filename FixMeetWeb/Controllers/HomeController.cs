using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FixMeetWeb.Models;
using Microsoft.EntityFrameworkCore;
using FixMeetWeb.Data;
using FixMeetWeb.Models.WebSiteViewModels;


namespace FixMeetWeb.Controllers
{
    public class HomeController : Controller
    {
       /* private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }*/

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*public async Task<ActionResult> About()
        {
            IQueryable<SuppliersGroup> data =
                from supplier in _context.Suppliers
                group supplier by supplier.JoinDate into dateGroup
                select new SuppliersGroup()
                {
                    JoinDate = dateGroup.Key,
                    SupplierCount = dateGroup.Count()
                };
            return View(await data.AsNoTracking().ToListAsync());
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
