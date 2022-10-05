using Microsoft.EntityFrameworkCore;
using BorrowLend.Models;

namespace BorrowLend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpensesType { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Items = this.Set<Item>();
            Expenses = this.Set<Expense>();
            ExpensesType = this.Set<ExpenseType>();
        }
        public DbSet<Item> Items { get; set; }
    }
}
