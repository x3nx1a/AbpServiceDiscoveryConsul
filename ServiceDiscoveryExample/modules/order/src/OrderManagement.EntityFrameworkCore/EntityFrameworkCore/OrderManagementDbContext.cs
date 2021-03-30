using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OrderManagement.EntityFrameworkCore
{
    [ConnectionStringName(OrderManagementDbProperties.ConnectionStringName)]
    public class OrderManagementDbContext : AbpDbContext<OrderManagementDbContext>, IOrderManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public OrderManagementDbContext(DbContextOptions<OrderManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureOrderManagement();
        }
    }
}