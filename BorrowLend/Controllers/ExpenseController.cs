using BorrowLend.Data;
using BorrowLend.Models;
using BorrowLend.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BorrowLend.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> obj = _db.Expenses;
            return View(obj);
        }
        public IActionResult Create()
        {
            ExpenseVM expenseVM = new ExpenseVM
            {
                Expense = new Expense(),
                TypeDropDown = _db.ExpensesType.Select(i => new SelectListItem
                {
                    Text = i.ExpenseTypeName,
                    Value = i.Id.ToString()
                })
            };
            return View(expenseVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseVM expenseVM)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Add(expenseVM.Expense);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expenseVM);
        }
        public IActionResult Update(int? id)
        {
            var obj = _db.Items.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Item obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            _db.Items.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            var obj = _db.Items.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Item obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            _db.Items.Remove(_db.Items.Find(obj.Id));
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}