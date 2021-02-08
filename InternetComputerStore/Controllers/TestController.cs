using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternetComputerStore.Models;

namespace InternetComputerStore.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Random()
        {
            var trying = new Test() { Name = "DeveloperTryer" }; 
            return View(trying);
        }
    }
}