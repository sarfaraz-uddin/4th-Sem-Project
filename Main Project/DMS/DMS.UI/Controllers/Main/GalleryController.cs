﻿using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers.Main
{
    public class GalleryController : Controller
    {
        MainEntities db = new MainEntities(); 
        // GET: Gallery
        public ActionResult Index()
        {
            List<gallery> data = db.galleries.tolist();
            return View(data);
        }

        public ActionResult AddNew()
        {
            return View();
        }

        public ActionResult SaveImage(HttpPostedFileBase SelectedFile)
        {
            string path = Server.MapPath("~/Uploads");
            string filename = SelectedFile.FileName;
            string new_path = path + "/" + filename;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            SelectedFile.SaveAs(new_path);
            gallery gallery = new gallery();
            gallery.photo_path = "~/ Uploads"; 
            gallery.destination_name = filename;
            db.galleries.Add(gallery);
            db.SaveChanges();

            
            return RedirectToAction("Index");
        }
    }
}