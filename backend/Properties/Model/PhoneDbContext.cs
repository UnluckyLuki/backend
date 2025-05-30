using Microsoft.EntityFrameworkCore;

namespace backend.Properties.Model;

public class PhoneDbContext: DbContext
{
    public PhoneDbContext(DbContextOptions<PhoneDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Phone> Phones { get; set; }
}