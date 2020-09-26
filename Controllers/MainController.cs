using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_Application.Database;
using My_Application.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace My_Application.Controllers
{
    public class MainController : Controller
    {

        private readonly GozareshContext _databaseContext;

        public MainController(GozareshContext DatabaseContext)
        {
            _databaseContext = DatabaseContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var displaydata = _databaseContext.Datas.ToList();

            return View(displaydata);
        }

        [HttpPost]
        public async Task<IActionResult> Index(DataGet data)
        {

            if (ModelState.IsValid)
            {
                _databaseContext.Add(data);
                await _databaseContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
