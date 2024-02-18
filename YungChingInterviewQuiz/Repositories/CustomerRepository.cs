using Microsoft.EntityFrameworkCore;
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
        public void Add(CustomersModel model)
        {
            _dbContext.CustomersModel.Add(model);
            _dbContext.SaveChanges();
        }

        public void Update(CustomersModel model)
        {
            _dbContext.Entry(model).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
