using Moq;
using YungChingInterviewQuiz.Models;
using YungChingInterviewQuiz.Repositories;
using YungChingInterviewQuiz.Services;

namespace YungChingInterviewQuiz.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetAllModels_ShouldReturnModels()
        {
            // Arrange
            var mockRepository = new Mock<ICustomerRepository>(); 
            mockRepository.Setup(repo => repo.GetAll()).Returns(new List<CustomersModel>
            {
                //new CustomersModel { CustomerID = "1", CompanyName = "ABC Inc." },
                new CustomersModel { CustomerID = "ASSB", CompanyName = "string" }
            });

            var service = new CustomerService(mockRepository.Object);

            // Act
            var result = service.GetAllModels();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Count());
            Assert.Contains(result, model => model.CompanyName == "string");
            //Assert.Contains(result, model => model.CompanyName == "XYZ Ltd.");
        }
    }
}