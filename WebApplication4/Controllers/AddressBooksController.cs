using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Models
{
    public class AddressBooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AddressBooks
        public ActionResult Index()
        {
            return View(db.AddressBooks.ToList());
        }

        // GET: AddressBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressBooks addressBook = db.AddressBooks.Find(id);
            if (addressBook == null)
            {
                return HttpNotFound();
            }
            return View(addressBook);
        }

        // GET: AddressBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,PhoneNumber,Address,City,State,Country,PostalCode,Email,CreatedDate")] AddressBooks addressBook)
        {
            addressBook.CreatedDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.AddressBooks.Add(addressBook);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addressBook);
        }

        // GET: AddressBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressBooks addressBook = db.AddressBooks.Find(id);
            if (addressBook == null)
            {
                return HttpNotFound();
            }
            return View(addressBook);
        }

        // POST: AddressBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,PhoneNumber,Address,City,State,Country,PostalCode,Email,CreatedDate")] AddressBooks addressBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addressBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addressBook);
        }

        // GET: AddressBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressBooks addressBook = db.AddressBooks.Find(id);
            if (addressBook == null)
            {
                return HttpNotFound();
            }
            return View(addressBook);
        }

        // POST: AddressBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddressBooks addressBook = db.AddressBooks.Find(id);
            db.AddressBooks.Remove(addressBook);
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
