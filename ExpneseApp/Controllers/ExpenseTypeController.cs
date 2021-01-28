using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpneseApp.Data;
using ExpneseApp.Models;

namespace ExpneseApp.Controllers
{
    public class ExpenseTypeController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ExpenseTypeController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index() => View(_db.ExpenseTypes);

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseType expenseType)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseTypes.Add(expenseType); // this adds data 
                _db.SaveChanges();//saves it in database 
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var expenseTypeObject = _db.ExpenseTypes.Find(id); // find the id 
            if (expenseTypeObject == null)
            {
                NotFound();
            }

            _db.ExpenseTypes.Remove(expenseTypeObject);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound(); // if null or 0 no id found 
            }


            var expenseTypeObject = _db.ExpenseTypes.Find(id); // find id in the database
            if (expenseTypeObject == null)
            {
                return NotFound();
            }

            return View(expenseTypeObject);
        }


        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound(); // if null or 0 no id found 
            }


            var expenseTypeObject = _db.ExpenseTypes.Find(id); // find id in the database
            if (expenseTypeObject == null)
            {
                return NotFound();
            }

            return View(expenseTypeObject);
        }

        public IActionResult Update(ExpenseType expenseType) // no issue here cause both method are the same 
        {
            if (ModelState.IsValid) // this checks for if the input is correct or not. 
            {
                _db.ExpenseTypes.Update(expenseType);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }


    }

