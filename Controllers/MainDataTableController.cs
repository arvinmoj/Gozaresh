using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using My_Application.Database;
using System.Threading.Tasks;
using My_Application.Models;
using System.Linq;
using System;

namespace My_Application.Controllers
{
    public class MainDataTableController : Controller
    {

 private readonly GozareshContext _databaseContext;

        public MainDataTableController(GozareshContext DatabaseContext)
        {
            _databaseContext = DatabaseContext;
        }

        public IActionResult Index()
        {
            var displaydata = _databaseContext.Datas.ToList();

            return View(displaydata);
        }
    }
}