using Microsoft.EntityFrameworkCore;
using Chat_1_to_1.Models;
namespace Chat_1_to_1.Dbcontext
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
       
    }
}
