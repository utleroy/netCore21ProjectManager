using Microsoft.EntityFrameworkCore;
using ProjectDashboard.Models;

namespace ProjectDashboard.Data
{
    public class OrderContext : DbContext
    {
         public OrderContext(DbContextOptions<OrderContext> options)
                : base(options)
                {
                }

                public DbSet<Order> Order { get;set; }
    }
}