using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using FizzleBizzleTest.Models;

namespace FizzleBizzleTest.Controllers
{
    public class HomeController : Controller
    {    
        public ActionResult Index(FizzleBizzle fb)
        {
            if (fb.Start != 0)
            {
                if (fb.Bazz == 0)
	            {
                    string[] outputArray = fb.FizzBuzz(fb.Start, fb.End);
	                ViewBag.Output = GetStringOutput(outputArray);
	            }
	            else
	            {
	                string[] outputArray = fb.FizzBuzzBazz(fb.Start, fb.End, fb.GreaterThan);
	                ViewBag.Output = GetStringOutput(outputArray);
	            }
            }
            return View(fb);
        }
        
        private string GetStringOutput(string[] output)
        {
            string str = null;
            str += "[\"";
            str += string.Join("\", \"", output);
            str += "\"]";
            return str;
        }
    }
}
