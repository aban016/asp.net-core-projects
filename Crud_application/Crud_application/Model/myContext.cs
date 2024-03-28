using Microsoft.EntityFrameworkCore;

namespace Crud_application.Model
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext>options) : base(options)
        {
                
        }

        public DbSet<Students> tbl_students { get; set; }
    }
}
