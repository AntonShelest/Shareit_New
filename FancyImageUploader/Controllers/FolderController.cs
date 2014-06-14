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
    public class FolderController : Controller
    {
        private FancyImageUploaderContext db = new FancyImageUploaderContext();

        //
        // GET: /Folder/

        public ViewResult Index()
        {
            return View(db.FolderModel.ToList());
        }

        //
        // GET: /Folder/Details/5

        public ViewResult Details(int id)
        {
            FolderModel foldermodel = db.FolderModel.Find(id);
            return View(foldermodel);
        }

        //
        // GET: /Folder/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Folder/Create

        [HttpPost]
        public ActionResult Create(FolderModel foldermodel)
        {
            if (ModelState.IsValid)
            {
                db.FolderModel.Add(foldermodel);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(foldermodel);
        }
        
        //
        // GET: /Folder/Edit/5
 
        public ActionResult Edit(int id)
        {
            FolderModel foldermodel = db.FolderModel.Find(id);
            return View(foldermodel);
        }

        //
        // POST: /Folder/Edit/5

        [HttpPost]
        public ActionResult Edit(FolderModel foldermodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foldermodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foldermodel);
        }

        //
        // GET: /Folder/Delete/5
 
        public ActionResult Delete(int id)
        {
            FolderModel foldermodel = db.FolderModel.Find(id);
            return View(foldermodel);
        }

        //
        // POST: /Folder/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            FolderModel foldermodel = db.FolderModel.Find(id);
            db.FolderModel.Remove(foldermodel);
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