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
    public class SituacaoDosContratosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: SituacaoDosContratos
        public ActionResult Index()
        {
            return View(db.SituacaoDosContratos.ToList());
        }

        // GET: SituacaoDosContratos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SituacaoDoContrato situacaoDoContrato = db.SituacaoDosContratos.Find(id);
            if (situacaoDoContrato == null)
            {
                return HttpNotFound();
            }
            return View(situacaoDoContrato);
        }

        // GET: SituacaoDosContratos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SituacaoDosContratos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao")] SituacaoDoContrato situacaoDoContrato)
        {
            if (ModelState.IsValid)
            {
                db.SituacaoDosContratos.Add(situacaoDoContrato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(situacaoDoContrato);
        }

        // GET: SituacaoDosContratos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SituacaoDoContrato situacaoDoContrato = db.SituacaoDosContratos.Find(id);
            if (situacaoDoContrato == null)
            {
                return HttpNotFound();
            }
            return View(situacaoDoContrato);
        }

        // POST: SituacaoDosContratos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao")] SituacaoDoContrato situacaoDoContrato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(situacaoDoContrato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(situacaoDoContrato);
        }

        // GET: SituacaoDosContratos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SituacaoDoContrato situacaoDoContrato = db.SituacaoDosContratos.Find(id);
            if (situacaoDoContrato == null)
            {
                return HttpNotFound();
            }
            return View(situacaoDoContrato);
        }

        // POST: SituacaoDosContratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SituacaoDoContrato situacaoDoContrato = db.SituacaoDosContratos.Find(id);
            db.SituacaoDosContratos.Remove(situacaoDoContrato);
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
