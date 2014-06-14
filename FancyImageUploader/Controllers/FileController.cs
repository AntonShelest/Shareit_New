using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FancyImageUploader.Models;

namespace FancyImageUploader.Controllers
{ 
    public class FileController : Controller
    {
        private FancyImageUploaderContext db = new FancyImageUploaderContext();

        //
        // GET: /File/

        public ViewResult Index()
        {
            return View(db.FileModels.ToList());
        }

        //
        // GET: /File/Details/5

        public ViewResult Details(int id)
        {
            FileModel filemodel = db.FileModels.Find(id);
            return View(filemodel);
        }

        //
        // GET: /File/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /File/Create

        [HttpPost]
        public ActionResult Create(FileModel filemodel)
        {
            if (ModelState.IsValid)
            {          
                db.FileModels.Add(filemodel);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(filemodel);
        }
        
        //
        // GET: /File/Edit/5
 
        public ActionResult Edit(int id)
        {
            FileModel filemodel = db.FileModels.Find(id);
            return View(filemodel);
        }

        //
        // POST: /File/Edit/5

        [HttpPost]
        public ActionResult Edit(FileModel filemodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filemodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filemodel);
        }

        //
        // GET: /File/Delete/5
 
        public ActionResult Delete(int id)
        {
            FileModel filemodel = db.FileModels.Find(id);
            return View(filemodel);
        }

        //
        // POST: /File/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            FileModel filemodel = db.FileModels.Find(id);
            db.FileModels.Remove(filemodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}