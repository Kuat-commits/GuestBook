using Microsoft.EntityFrameworkCore;
namespace Guestbook.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<GuestbookEntry> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();  
        }
    }
}

 
