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
    public class TipoImoveisController : Controller
    {
        private Contexto db = new Contexto();

        // GET: TipoImoveis
        public ActionResult Index()
        {
            return View(db.TiposDeImoveis.ToList());
        }

        // GET: TipoImoveis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoImovel tipoImovel = db.TiposDeImoveis.Find(id);
            if (tipoImovel == null)
            {
                return HttpNotFound();
            }
            return View(tipoImovel);
        }

        // GET: TipoImoveis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoImoveis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao")] TipoImovel tipoImovel)
        {
            if (ModelState.IsValid)
            {
                db.TiposDeImoveis.Add(tipoImovel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoImovel);
        }

        // GET: TipoImoveis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoImovel tipoImovel = db.TiposDeImoveis.Find(id);
            if (tipoImovel == null)
            {
                return HttpNotFound();
            }
            return View(tipoImovel);
        }

        // POST: TipoImoveis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao")] TipoImovel tipoImovel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoImovel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoImovel);
        }

        // GET: TipoImoveis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoImovel tipoImovel = db.TiposDeImoveis.Find(id);
            if (tipoImovel == null)
            {
                return HttpNotFound();
            }
            return View(tipoImovel);
        }

        // POST: TipoImoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoImovel tipoImovel = db.TiposDeImoveis.Find(id);
            db.TiposDeImoveis.Remove(tipoImovel);
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
