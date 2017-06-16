using System;
using Microsoft.AspNetCore.Mvc;
using Practica1.Models;
using Practica1.UnitOfWork;
using Practica1.Filters;

namespace Practica1.Controllers
{
    [ExceptionLoggerFilter]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unit;

        public ProductController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            return View(_unit.Products.GetAll());
        }

        

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            try
            {
                int ProductID = _unit.Products.Insert(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            Product product = null;
            try
            {
                product = _unit.Products.GetEntityById(id);
            }
            catch (Exception)
            {

                throw;
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            try
            {
                bool actualizo = _unit.Products.Update(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            Product product = null;
            try
            {
                product = _unit.Products.GetEntityById(id);
            }
            catch (Exception)
            {

                throw;
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Product product)
        {
            try
            {
                bool elimino = _unit.Products.Delete(product);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                
                return View();
            }
        }

        [Route("product/issue")]
        public IActionResult CreateIssue()
        {
            throw new Exception("New error");
        }
    }
}