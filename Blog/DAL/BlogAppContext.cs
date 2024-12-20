using Blog.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.DAL
{
    public class BlogAppContext : DbContext
    {
            public BlogAppContext(DbContextOptions<BlogAppContext> options) : base(options)
            {

            }
            
            public DbSet<Category> Categories { get; set; }  
    }
}
