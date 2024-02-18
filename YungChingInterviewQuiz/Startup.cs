using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YungChingInterviewQuiz.DataAccess;
using YungChingInterviewQuiz.Services;

namespace YungChingInterviewQuiz
{
    public class Startup
    {
        //public IConfiguration Configuration { get; }
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    var connectionString = Configuration.GetConnectionString("NorthwindDb");

        //    services.AddDbContext<NorthwindDbContext>(options =>
        //        options.UseSqlServer(connectionString));
        //    services.AddControllers();
        //}
    }
}
