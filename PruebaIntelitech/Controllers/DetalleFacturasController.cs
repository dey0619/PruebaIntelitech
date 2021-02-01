using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PruebaIntelitech.Models;

namespace PruebaIntelitech.Controllers
{
    public class DetalleFacturasController : Controller
    {
        private DataBase db = new DataBase();

        // GET: DetalleFacturas
        public ActionResult Index()
        {
            var detalleFacturas = db.DetalleFacturas.Include(d => d.Facturas).Include(d => d.Productos);
            return View(detalleFacturas.ToList());
        }

        // GET: DetalleFacturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleFacturas detalleFacturas = db.DetalleFacturas.Find(id);
            if (detalleFacturas == null)
            {
                return HttpNotFound();
            }
            return View(detalleFacturas);
        }

        // GET: DetalleFacturas/Create
        public ActionResult Create()
        {
            ViewBag.IdFactura_FK = new SelectList(db.Facturas, "IdFactura", "CodigoFactura");
            ViewBag.IdProducto_FK = new SelectList(db.Productos, "IdProducto", "Codigo");
            return View();
        }

        // POST: DetalleFacturas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDetalleFactura,IdProducto_FK,IdFactura_FK")] DetalleFacturas detalleFacturas)
        {
            if (ModelState.IsValid)
            {
                db.DetalleFacturas.Add(detalleFacturas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdFactura_FK = new SelectList(db.Facturas, "IdFactura", "CodigoFactura", detalleFacturas.IdFactura_FK);
            ViewBag.IdProducto_FK = new SelectList(db.Productos, "IdProducto", "Codigo", detalleFacturas.IdProducto_FK);
            return View(detalleFacturas);
        }

        // GET: DetalleFacturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleFacturas detalleFacturas = db.DetalleFacturas.Find(id);
            if (detalleFacturas == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdFactura_FK = new SelectList(db.Facturas, "IdFactura", "CodigoFactura", detalleFacturas.IdFactura_FK);
            ViewBag.IdProducto_FK = new SelectList(db.Productos, "IdProducto", "Codigo", detalleFacturas.IdProducto_FK);
            return View(detalleFacturas);
        }

        // POST: DetalleFacturas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDetalleFactura,IdProducto_FK,IdFactura_FK")] DetalleFacturas detalleFacturas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalleFacturas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdFactura_FK = new SelectList(db.Facturas, "IdFactura", "CodigoFactura", detalleFacturas.IdFactura_FK);
            ViewBag.IdProducto_FK = new SelectList(db.Productos, "IdProducto", "Codigo", detalleFacturas.IdProducto_FK);
            return View(detalleFacturas);
        }

        // GET: DetalleFacturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleFacturas detalleFacturas = db.DetalleFacturas.Find(id);
            if (detalleFacturas == null)
            {
                return HttpNotFound();
            }
            return View(detalleFacturas);
        }

        // POST: DetalleFacturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalleFacturas detalleFacturas = db.DetalleFacturas.Find(id);
            db.DetalleFacturas.Remove(detalleFacturas);
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
