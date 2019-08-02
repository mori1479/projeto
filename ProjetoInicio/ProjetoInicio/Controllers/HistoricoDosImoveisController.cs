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
    public class HistoricoDosImoveisController : Controller
    {
        private Contexto db = new Contexto();

        // GET: HistoricoDosImoveis
        public ActionResult Index()
        {
            return View(db.HistoricoDoImovels.ToList());
        }

        // GET: HistoricoDosImoveis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoricoDoImovel historicoDoImovel = db.HistoricoDoImovels.Find(id);
            if (historicoDoImovel == null)
            {
                return HttpNotFound();
            }
            return View(historicoDoImovel);
        }

        // GET: HistoricoDosImoveis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoricoDosImoveis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Data")] HistoricoDoImovel historicoDoImovel)
        {
            if (ModelState.IsValid)
            {
                db.HistoricoDoImovels.Add(historicoDoImovel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(historicoDoImovel);
        }

        // GET: HistoricoDosImoveis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoricoDoImovel historicoDoImovel = db.HistoricoDoImovels.Find(id);
            if (historicoDoImovel == null)
            {
                return HttpNotFound();
            }
            return View(historicoDoImovel);
        }

        // POST: HistoricoDosImoveis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Data")] HistoricoDoImovel historicoDoImovel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historicoDoImovel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(historicoDoImovel);
        }

        // GET: HistoricoDosImoveis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoricoDoImovel historicoDoImovel = db.HistoricoDoImovels.Find(id);
            if (historicoDoImovel == null)
            {
                return HttpNotFound();
            }
            return View(historicoDoImovel);
        }

        // POST: HistoricoDosImoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HistoricoDoImovel historicoDoImovel = db.HistoricoDoImovels.Find(id);
            db.HistoricoDoImovels.Remove(historicoDoImovel);
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
