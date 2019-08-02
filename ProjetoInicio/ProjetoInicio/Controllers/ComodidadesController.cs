using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoInicio.Models;

namespace ProjetoInicio.Controllers
{
    public class ComodidadesController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Comodidades
        public ActionResult Index()
        {
            return View(db.Comodidades.ToList());
        }

        // GET: Comodidades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comodidade comodidade = db.Comodidades.Find(id);
            if (comodidade == null)
            {
                return HttpNotFound();
            }
            return View(comodidade);
        }

        // GET: Comodidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comodidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,quantidade")] Comodidade comodidade)
        {
            if (ModelState.IsValid)
            {
                db.Comodidades.Add(comodidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comodidade);
        }

        // GET: Comodidades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comodidade comodidade = db.Comodidades.Find(id);
            if (comodidade == null)
            {
                return HttpNotFound();
            }
            return View(comodidade);
        }

        // POST: Comodidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,quantidade")] Comodidade comodidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comodidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comodidade);
        }

        // GET: Comodidades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comodidade comodidade = db.Comodidades.Find(id);
            if (comodidade == null)
            {
                return HttpNotFound();
            }
            return View(comodidade);
        }

        // POST: Comodidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comodidade comodidade = db.Comodidades.Find(id);
            db.Comodidades.Remove(comodidade);
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
