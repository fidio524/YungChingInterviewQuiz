using YungChingInterviewQuiz.Models;
using YungChingInterviewQuiz.Repositories;

namespace YungChingInterviewQuiz.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
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

        public void UpdateModel(CustomersModel model)
        {
            _repository.Update(model);
        }

        public void DeleteModel(string id)
        {
            _repository.Delete(id);
        }
    }
}
