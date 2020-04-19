using Microsoft.EntityFrameworkCore;
using Model;

namespace Persistence.DataBase
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
