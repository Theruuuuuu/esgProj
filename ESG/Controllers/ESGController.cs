using ESG.ESGDbContext;
using ESG.ESGDbContext.ESGaction;
using ESG.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESG.Controllers
{
    public class ESGController : Controller
    {
        private readonly IESGaction _dbcontext;
        public ESGController(IESGaction dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult Company(int id)
        {
            var data = _dbcontext.GetFirstOrDefault(u=>u.Id == id);
            return View(data);
        }

        public IActionResult AllContent()
        {
            return View();
        }

        #region API CALLS
        public IActionResult GetAll()
        {
            var list = _dbcontext.GetAll();
            //把資料回傳成Json格式
            return Json(new { data = list });
        }
        public IActionResult GetAllData()
        {
            var list = _dbcontext.GetAll();
            //把資料回傳成Json格式
            return Json(list);
        }
        #endregion
    }


}
