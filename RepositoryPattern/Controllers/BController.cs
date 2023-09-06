using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Core.Interfaces;
using RepositoryPattern.Core.Models;

namespace RepositoryPattern.Controllers
{
    [ApiController]
    public class BController : ControllerBase
    {
        private readonly IBaseRepository<Empolyee> _repository;
        public BController(IBaseRepository<Empolyee> repository)
        {
            _repository = repository;
        }

        [Route("fff")]
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_repository.FindId(1));
        }
    }
}
