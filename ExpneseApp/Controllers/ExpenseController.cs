using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpneseApp.Data;
using ExpneseApp.Models;

namespace ExpneseApp.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ExpenseController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expense> expenseObject = _db.Expenses;
            //IEnumerable is a interface that supports collection 
            return View(expenseObject);
        }

        public IActionResult Create()
        {

            return View();
        }
        //post create
        [HttpPost] // says this is post 
        [ValidateAntiForgeryToken] //this makes it secure
        public IActionResult Create(Expense expense)
        {
            if (ModelState.IsValid) // this checks for if the input is correct or not. 
            {
                _db.Expenses.Add(expense);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
