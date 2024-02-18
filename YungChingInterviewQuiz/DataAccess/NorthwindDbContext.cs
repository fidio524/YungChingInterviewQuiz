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
    }
}
