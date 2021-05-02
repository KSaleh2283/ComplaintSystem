using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplaintSystem.Controllers
{
    public class ComplaintController : Controller
    {       
        public ActionResult AdminComplaint()
        {
            return View();
        }

        public ActionResult CustomerComplaint()
        {
            return View();
        }
    }
}