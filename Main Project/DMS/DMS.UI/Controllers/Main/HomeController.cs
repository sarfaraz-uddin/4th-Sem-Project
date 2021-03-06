using AutoMapper;
using DMS.DAL.DatabaseContext;
using DMS.DAL.Interfaces;
using DMS.DAL.Repositories.MainRepo;
using DMS.DAL.StaticHelper;
using DMS.Services.General.Interface;
using DMS.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public MainEntities db;
        private SystemInfoForSession _ActiveSession;
        private IBranchesRepo _BranchesRepo;
        public HomeController(MainEntities _db, IBranchesRepo BranchesRepo)
        {
            _ActiveSession = SessionHelper.GetSession();
            db = _db;
            _BranchesRepo = BranchesRepo;
        }
        SystemInfoForSession systemSession = SessionHelper.GetSession();

        public ActionResult AccessDeniedPage()
        {
            return View();
        }


        public ActionResult Index()
        {
            List<destination> data = db.destinations.ToList();
<<<<<<< HEAD
=======
       
           
>>>>>>> 2b7fd43834cccf23d657d26e74ac4d0b63d8a4d5
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult gallery()
        {
            ViewBag.Message = "Your gallery page.";
            return View();
        }
        public ActionResult icons()
        {
            ViewBag.Message = "Your icons page.";
            return View();
        }
        public ActionResult typography()
        {
            ViewBag.Message = "Your typography page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult beautifultours()
        {
            ViewBag.Message = "Your tours page.";
            return View();
        }

        public async Task<ActionResult>Dashboard()
        {
            return RedirectToAction("Index","admin");
        }

    }
}