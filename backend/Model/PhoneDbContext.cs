using Microsoft.EntityFrameworkCore;

namespace backend.Model;

public class PhoneDbContext: DbContext
{
    public PhoneDbContext(DbContextOptions<PhoneDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Phone> phones { get; set; }
}