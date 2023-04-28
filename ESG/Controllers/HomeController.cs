using ESG.ESGDbContext.ESGaction;
using ESG.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ESG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IESGaction _dbcontext;
        public HomeController(ILogger<HomeController> logger, IESGaction dbcontext)
        {
            _logger = logger;
            _dbcontext = dbcontext;

        }

        public IActionResult Index()
        {                        
            return View();
        }

        public IActionResult searchItem(string? search) {
            var data = _dbcontext.GetAll();
            var searchRes = data.Where(u => u.CompanyNumber.Contains(search) || u.CompanyName.Contains(search));
            if (searchRes !=null || searchRes.Any())
                return PartialView("_searchPartial", searchRes);
            return View();
        }
                

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}