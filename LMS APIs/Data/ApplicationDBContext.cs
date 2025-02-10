using System.Data;
using LMS_APIs.Models;
using Microsoft.EntityFrameworkCore;
using YourNamespace.Models;

namespace LMS_APIs.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books  { get; set; }
    }
}
