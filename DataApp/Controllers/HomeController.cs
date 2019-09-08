using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataApp.Models;

namespace DataApp.Controllers
{
    public class HomeController : Controller
    {

        DataContext dataContext = new DataContext();
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddRequest()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddRequest(Request model)
        {
            dataContext.Requests.Add(model);
            dataContext.SaveChanges();
            return View("Thanks", model);
        }

        public IActionResult List()
        {
            return View(dataContext.Requests);
        }





        
        



        
    }
}
