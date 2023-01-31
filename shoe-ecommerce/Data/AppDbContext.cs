using Microsoft.EntityFrameworkCore;
using shoe_ecommerce.Models;

namespace shoe_ecommerce.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }


    public DbSet<User> Users { set; get; }
}