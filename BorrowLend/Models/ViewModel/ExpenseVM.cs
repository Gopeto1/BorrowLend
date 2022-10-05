using Microsoft.AspNetCore.Mvc.Rendering;

namespace BorrowLend.Models.ViewModel
{
    public class ExpenseVM
    {
        public Expense Expense { get; set; }
        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
