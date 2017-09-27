using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        
        public ActionResult Index()
        {
            return View();
        }
        

        /*
        public string Index()
        {
            //return View();
            return "This is my <b>default</b> action...";
        }
        */

        ////
        // 
        // GET: /Calc/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method.";
        }
        ////


    }
}