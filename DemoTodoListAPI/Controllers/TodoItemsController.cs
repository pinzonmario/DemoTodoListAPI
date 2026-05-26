using AutoMapper;
using DemoTodoListAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DemoTodoListAPI.Controllers
{
    [ApiController]
    [Route("api/todo-items")]
    public class TodoItemsController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public TodoItemsController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }

        [HttpGet("{id:guid}", Name = "GetTodoById")]
        public async Task<ActionResult> Get(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Post()
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put()
        {
            return Ok();
        }

        [HttpPatch]
        public async Task<ActionResult> Patch()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete()
        {
            return Ok();
        }

    }
}
