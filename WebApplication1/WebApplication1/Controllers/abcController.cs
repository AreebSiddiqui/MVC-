using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class abcController : Controller
    {
        //
        // GET: /abc/
        public ActionResult Index()
        {
            Class1 c  = new Class1();
            c.employeeId = 1234;
            return View("Index",c);
        }
	}
}