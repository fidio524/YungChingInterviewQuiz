using Microsoft.AspNetCore.Mvc;
using YungChingInterviewQuiz.Models;
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

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var models = _service.GetAllModels();
            return Ok(models);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(string id)
        {
            var model = _service.GetModelById(id);

            if (model == null)
                return NotFound();

            return Ok(model);
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] CustomersModel model)
        {
            _service.AddModel(model);
            return CreatedAtAction(nameof(GetById), new { id = model.CustomerID }, model);
        }

        [HttpPut("Update")]
        public IActionResult Update(string id, [FromBody] CustomersModel model)
        {
            if (id != model.CustomerID)
                return BadRequest();

            _service.UpdateModel(model);
            return NoContent();
        }
    }
}
