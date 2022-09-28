using Microsoft.EntityFrameworkCore;
using BorrowLend.Models;

namespace BorrowLend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
}
