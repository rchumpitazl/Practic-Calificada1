

using Microsoft.AspNetCore.Mvc;
using Practica1.Models;
using Practica1.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unit;

        public CustomerController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            var Customers = _unit.Customers.GetAll();
            Customers = Customers.Take(5);
            return View(Customers);
        }

      

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {
            try
            {
                int CustomerID = _unit.Customers.Insert(customer);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            Customer customer = null;
            try
            {
                customer = _unit.Customers.GetEntityById(id);
            }
            catch (Exception)
            {

                throw;
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer customer)
        {
            try
            {
                bool actualizo = _unit.Customers.Update(customer);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            Customer customer = null;
            try
            {
                customer = _unit.Customers.GetEntityById(id);
            }
            catch (Exception)
            {

                throw;
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer customer)
        {
            try
            {
                bool elimino = _unit.Customers.Delete(customer);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return View();
            }
        }
    }
}