using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Medicare.BLL;
using Medicare.Models;

namespace Medicare.Controllers
{
    public class ManufacturarsController : Controller
    {
        private MedicareDbContext db = new MedicareDbContext();

        // GET: Manufacturars
        public ActionResult Index()
        {
            return View(db.Manufacturars.ToList());
        }

        // GET: Manufacturars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturar manufacturar = db.Manufacturars.Find(id);
            if (manufacturar == null)
            {
                return HttpNotFound();
            }
            return View(manufacturar);
        }

        // GET: Manufacturars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manufacturars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ManufacturerId,ManufacturarName,CompanyDetails")] Manufacturar manufacturar)
        {
            ManufaturarManager manager=new ManufaturarManager();
            if (ModelState.IsValid)
            {
                if (manager.IsNameExist(manufacturar))
                {
                    ViewBag.errorMessage= "Name already exist";
                }
                else
                {
                    db.Manufacturars.Add(manufacturar);
                    db.SaveChanges();
                    return RedirectToAction("Index");  
                }
                
            }

            return View(manufacturar);
        }

        // GET: Manufacturars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturar manufacturar = db.Manufacturars.Find(id);
            if (manufacturar == null)
            {
                return HttpNotFound();
            }
            return View(manufacturar);
        }

        // POST: Manufacturars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ManufacturerId,ManufacturarName,CompanyDetails")] Manufacturar manufacturar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manufacturar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufacturar);
        }

        // GET: Manufacturars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturar manufacturar = db.Manufacturars.Find(id);
            if (manufacturar == null)
            {
                return HttpNotFound();
            }
            return View(manufacturar);
        }

        // POST: Manufacturars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Manufacturar manufacturar = db.Manufacturars.Find(id);
            db.Manufacturars.Remove(manufacturar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
