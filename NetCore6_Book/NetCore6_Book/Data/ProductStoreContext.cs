using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NetCore6_Book.Data
{
    public class ProductStoreContext : IdentityDbContext<ApplicationUser> // quan ly class tuong ung voi database
    {
        public ProductStoreContext(DbContextOptions<ProductStoreContext> options) : base(options)
        {

        }

        #region DbSet
        public DbSet<Product>? Products { get; set;}
        #endregion
    }
}
