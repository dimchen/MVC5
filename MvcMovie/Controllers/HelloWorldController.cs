using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }



        //public string Index()
        //{
        //    return "This is my Action";
        //    //reut
        //}

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            //return HttpUtility.HtmlEncode("hello " + name + " "+ numTimes );
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public string Action1()
        {
            return "Our Welcome message";
        }

        public string action2()
        {
            return "Action 2 message";
        }
	}
}