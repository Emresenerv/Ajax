using Microsoft.EntityFrameworkCore;

namespace Ajax.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6JTJ49H; initial Catalog=AjaxDb; integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
