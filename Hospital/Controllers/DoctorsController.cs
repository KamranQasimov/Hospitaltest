using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class DoctorsController : Controller
    {
        // GET: Doctors
        public ActionResult Doctors()
        {
            return View();
        }
    }
}