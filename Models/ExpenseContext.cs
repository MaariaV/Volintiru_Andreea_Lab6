using Microsoft.EntityFrameworkCore;
namespace Volintiru_Andreea_Lab6.Models
{
    public class ExpenseContext : DbContext

    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options): base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
