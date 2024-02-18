using Microsoft.AspNetCore.Mvc;
using YungChingInterviewQuiz.Services;

namespace YungChingInterviewQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _service;

        public CustomerController(CustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var models = _service.GetAllModels();
            return Ok(models);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var model = _service.GetModelById(id);

            if (model == null)
                return NotFound();

            return Ok(model);
        }
    }
}
