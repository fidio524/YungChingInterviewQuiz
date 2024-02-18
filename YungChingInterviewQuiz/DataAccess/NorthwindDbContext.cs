using Microsoft.EntityFrameworkCore;
using YungChingInterviewQuiz.Models;

namespace YungChingInterviewQuiz.DataAccess
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) : base(options)
        {
        }

        public DbSet<CustomersModel> CustomersModel { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 在這裡定義主鍵
            modelBuilder.Entity<CustomersModel>().HasKey(c => c.CustomerID);

            // 其他配置...
        }
    }
}
