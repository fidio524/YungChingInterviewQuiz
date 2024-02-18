using YungChingInterviewQuiz.Models;
using YungChingInterviewQuiz.Repositories;

namespace YungChingInterviewQuiz.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _repository;
        public CustomerService(CustomerRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<CustomersModel> GetAllModels()
        {
            return _repository.GetAll();
        }

        public CustomersModel GetModelById(string id)
        {
            return _repository.GetById(id);
        }
        public void AddModel(CustomersModel model)
        {
            _repository.Add(model);
        }
    }
}
