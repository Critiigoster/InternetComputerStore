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
            var trying = new Customer() { UserName = "DeveloperTryer" }; 
            return View(trying);
        }
        public ActionResult Index(int? pageindex, string sortBy)
        {
            if (!pageindex.HasValue)
            {
                pageindex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("Page index is equal {0} \n Sort By {1}", pageindex, sortBy));
        }

        [Route("test/mapping/{year}/{month:regex(\\d{2})}/{day}")] // Attribute + Regular expresion (regex)
        public ActionResult Mapping(int year, int month, int day)
        {
            return Content(year + "/" + month + "/" + day);
            
        }
        
    }
}