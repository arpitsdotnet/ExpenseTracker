using ExpenseTracker.WebUI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.WebUI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {
    }

    public DbSet<Category> Categories { get; set; }  
    public DbSet<Transaction> Transactions { get; set; }
}
