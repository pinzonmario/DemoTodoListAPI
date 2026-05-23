using AutoMapper;
using DemoTodoListAPI.Data;
using DemoTodoListAPI.DTOs;
using DemoTodoListAPI.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoTodoListAPI.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public CategoriesController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            var categories = await context.Categories.OrderBy(x => x.Order).ToListAsync();
            var categoriesDTO = mapper.Map<IEnumerable<CategoryDTO>>(categories);
            return Ok(categoriesDTO);
        }

        [HttpGet("{id:guid}", Name = "GetById")]
        public async Task<ActionResult<CategoryDTO>> Get(Guid id)
        {
            var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);

            if (category is null)
            {
                return NotFound();
            }

            var categoryDTO = mapper.Map<CategoryDTO>(category);

            return Ok(categoryDTO);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoryCreateDTO model)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            var exists = await context.Categories.AnyAsync(x => x.Name == model.Name);

            if (exists)
            {
                return Conflict(new ProblemDetails
                {
                    Title = "Duplicate category",
                    Detail = $"Category {model.Name} already exists",
                    Status = StatusCodes.Status409Conflict
                });
            }

            var category = mapper.Map<Category>(model);
            category.Order = await GetOrder();

            context.Add(category);
            await context.SaveChangesAsync();

            return CreatedAtRoute("GetById", new { category.Id }, category);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] CategoryCreateDTO model)
        {
            var category = await context.Categories.AsTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (category is null)
            {
                return NotFound();
            }

            var exists = await context.Categories.AnyAsync(x => x.Id != id && x.Name == model.Name);

            if (exists)
            {
                return Conflict(new ProblemDetails
                {
                    Title = "Duplicate category",
                    Detail = $"Category {model.Name} already exists",
                    Status = StatusCodes.Status409Conflict
                });
            }

            mapper.Map(model, category);

            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:guid}")]
        public async Task<ActionResult> Patch(Guid id, [FromBody] JsonPatchDocument<CategoryPatchDTO> patchDoc)
        {
            if (patchDoc is null)
            {
                return BadRequest();
            }

            var category = await context.Categories.AsTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (category is null)
            {
                return NotFound();
            }

            var categoryPatchDTO = mapper.Map<CategoryPatchDTO>(category);

            patchDoc.ApplyTo(categoryPatchDTO, ModelState);

            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            if (!TryValidateModel(categoryPatchDTO))
            {
                return ValidationProblem(ModelState);
            }

            var updatesName = patchDoc.Operations.Any(x => x.path.Equals("/name", StringComparison.OrdinalIgnoreCase));

            if (updatesName)
            {
                var exists = await context.Categories.AnyAsync(x => x.Id != id && x.Name == categoryPatchDTO.Name);

                if (exists)
                {
                    return Conflict(new ProblemDetails
                    {
                        Title = "Duplicate category",
                        Detail = $"Category {categoryPatchDTO.Name} already exists",
                        Status = StatusCodes.Status409Conflict
                    });
                }
            }

            mapper.Map(categoryPatchDTO, category);

            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);

            if (category is null)
            {
                return NotFound();
            }

            context.Remove(category);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private async Task<int> GetOrder()
        {
            var hasData = await context.Categories.AnyAsync();

            if (hasData)
            {
                var order = await context.Categories.MaxAsync(x => x.Order);
                return ++order;
            }

            return 1;
        }
    }
}
