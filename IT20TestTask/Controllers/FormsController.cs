using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IT20TestTask.Models;

namespace IT20TestTask.Controllers
{
    public class FormsController : Controller
    {
        FormManagerContext db = new FormManagerContext();
        // GET: Forms
        public ActionResult Index()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}