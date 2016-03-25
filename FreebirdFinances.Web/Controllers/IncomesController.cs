using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FreebirdFinances.DataLayer;
using FreebirdFinances.Model;
using FreebirdFinances.Web.ViewModels;

namespace FreebirdFinances.Web.Controllers
{
    public class IncomesController : Controller
    {
        private FreebirdContext _freebirdContext;

        public IncomesController()
        {
            _freebirdContext = new FreebirdContext();
        }
        
        public ActionResult Index()
        {
            return View(_freebirdContext.Incomes.ToList());
        }
        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Income income = _freebirdContext.Incomes.Find(id);
            if (income == null)
            {
                return HttpNotFound();
            }

            var incomeViewModel = new IncomeViewModel();
            incomeViewModel.Period = income.Period;
            incomeViewModel.TotalIncome = income.TotalIncome;
            incomeViewModel.TaxPercent = income.TaxPercent;
            incomeViewModel.MessageToClient = "This originated from the View Model, rather than the model.";

            return View(incomeViewModel);
        }
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: Incomes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Period,TotalIncome,TaxPercent")] Income income)
        {
            if (ModelState.IsValid)
            {
                _freebirdContext.Incomes.Add(income);
                _freebirdContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(income);
        }

        // GET: Incomes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Income income = _freebirdContext.Incomes.Find(id);
            if (income == null)
            {
                return HttpNotFound();
            }
            return View(income);
        }

        // POST: Incomes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Period,TotalIncome,TaxPercent")] Income income)
        {
            if (ModelState.IsValid)
            {
                _freebirdContext.Entry(income).State = EntityState.Modified;
                _freebirdContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(income);
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Income income = _freebirdContext.Incomes.Find(id);
            if (income == null)
            {
                return HttpNotFound();
            }
            return View(income);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Income income = _freebirdContext.Incomes.Find(id);
            _freebirdContext.Incomes.Remove(income);
            _freebirdContext.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _freebirdContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
