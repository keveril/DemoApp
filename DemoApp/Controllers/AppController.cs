using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.ViewModels;

namespace DemoApp.Controllers.Web
{
    public class AppController : Controller
    {
      

        public AppController()
        {
          
        }
        public IActionResult Index()
        {
            return View();
        }
       

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
