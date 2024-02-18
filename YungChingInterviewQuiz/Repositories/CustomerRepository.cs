using YungChingInterviewQuiz.DataAccess;
using YungChingInterviewQuiz.Models;

namespace YungChingInterviewQuiz.Repositories
{
    public class CustomerRepository
    {
        private readonly NorthwindDbContext _dbContext;
        public CustomerRepository(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            return _dbContext.CustomersModel.ToList();
        }

        public CustomersModel GetById(string id)
        {
            return _dbContext.CustomersModel.Find(id);
        }
    }
}
