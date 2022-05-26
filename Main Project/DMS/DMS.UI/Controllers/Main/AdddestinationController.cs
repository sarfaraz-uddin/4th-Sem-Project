using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers.Main
{
    public class AdddestinationController : Controller
    {
        MainEntities db = new MainEntities();
        // GET: Adddestination
        public ActionResult index()
        {
            List<destination> all_data = db.destinations.ToList();
            return View(all_data);

        }


        public ActionResult items()
        {
             List<destination> all_data = db.destinations.ToList();
            return View(all_data);
        }

        public ActionResult create()
        {

            return View();
        }
        public ActionResult Savedata(destination destination)
        {
            db.destinations.Add(destination);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}