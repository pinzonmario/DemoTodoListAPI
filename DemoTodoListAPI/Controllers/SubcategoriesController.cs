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
    [Route("api/{categoryId}/subcategories")]
    public class SubcategoriesController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public SubcategoriesController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubcategoryDTO>>> Get(Guid categoryId)
        {
            var categoryExists = await context.Categories.AnyAsync(x => x.Id == categoryId);

            if (!categoryExists)
            {
                return Problem(
                    statusCode: StatusCodes.Status404NotFound,
                    title: "Category not found",
                    detail: $"Category with id {categoryId} was not found");
            }

            var subcategories = await context.Subcategories.Where(x => x.CategoryId == categoryId)
                                                           .OrderBy(x => x.Order)
                                                           .ToListAsync();

            var subcategoriesDTO = mapper.Map<IEnumerable<SubcategoryDTO>>(subcategories);

            return Ok(subcategoriesDTO);
        }

        [HttpGet("{id:guid}", Name = "GetSubcategoryById")]
        public async Task<ActionResult<SubcategoryDTO>> Get(Guid categoryId, Guid id)
        {
            var categoryExists = await context.Categories.AnyAsync(x => x.Id == categoryId);

            if (!categoryExists)
            {
                return Problem(
                    statusCode: StatusCodes.Status404NotFound,
                    title: "Category was not found",
                    detail: $"Category with id {categoryId} was not found");
            }

            var subcategory = await context.Subcategories.FirstOrDefaultAsync(x => x.Id == id && x.CategoryId == categoryId);

            if (subcategory is null)
            {
                return Problem(
                    statusCode: StatusCodes.Status404NotFound,
                    title: "Subcategory not found",
                    detail: $"Subcategory with id {id} was not found");
            }

            var subcategoryDTO = mapper.Map<SubcategoryDTO>(subcategory);

            return Ok(subcategoryDTO);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Guid categoryId, [FromBody] SubcategoryCreateDTO model)
        {
            var categoryExists = await context.Categories.AnyAsync(x => x.Id == categoryId);

            if (!categoryExists)
            {
                return Problem(
                    statusCode: StatusCodes.Status404NotFound,
                    title: "Category not found",
                    detail: $"Category with id {categoryId} was not found");
            }

            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            var subcategoryExists = await context.Subcategories.AnyAsync(x => x.Name == model.Name && x.CategoryId == categoryId);

            if (subcategoryExists)
            {
                return Problem(
                    statusCode: StatusCodes.Status409Conflict,
                    title: "Subcategory Conflict",
                    detail: $"Subcategory {model.Name} already exists");
            }

            var subcategory = mapper.Map<Subcategory>(model);
            subcategory.CategoryId = categoryId;
            subcategory.Order = await GetOrder(categoryId);

            context.Add(subcategory);
            await context.SaveChangesAsync();

            return CreatedAtRoute("GetSubcategoryById", new { subcategory.CategoryId, subcategory.Id }, subcategory);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult> Put(Guid categoryId, Guid id, [FromBody] SubcategoryUpdateDTO model)
        {
            var subcategoryDb = await context.Subcategories.AsTracking()
                                                           .FirstOrDefaultAsync(x => x.Id == id && x.CategoryId == categoryId);

            if (subcategoryDb is null)
            {
                return Problem(
                    statusCode: StatusCodes.Status404NotFound,
                    title: "Subcategory not found",
                    detail: $"Subcategory with id {id} was not found");
            }

            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            mapper.Map(model, subcategoryDb);

            if (subcategoryDb.CategoryId != categoryId)
            {
                var categoryExists = await context.Categories.AnyAsync(x => x.Id == subcategoryDb.CategoryId);

                if (!categoryExists)
                {
                    return Problem(
                        statusCode: StatusCodes.Status404NotFound,
                        title: "Category not found",
                        detail: $"Category with id {subcategoryDb.CategoryId} was not found");
                }

                subcategoryDb.Order = await GetOrder(subcategoryDb.CategoryId);
            }

            var subcategoryExists = await context.Subcategories.AnyAsync(x => x.Id != subcategoryDb.Id &&
                                                                              x.Name == subcategoryDb.Name &&
                                                                              x.CategoryId == subcategoryDb.CategoryId);

            if (subcategoryExists)
            {
                return Problem(
                    statusCode: StatusCodes.Status409Conflict,
                    title: "Duplicate subcategory",
                    detail: $"Subcategory {subcategoryDb.Name} already exists"
                    );
            }

            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:guid}")]
        public async Task<ActionResult> Patch(Guid categoryId, Guid id, [FromBody] JsonPatchDocument<SubcategoryPatchDTO> patchDoc)
        {
            if (patchDoc is null)
            {
                return BadRequest();
            }

            var subcategoryDb = await context.Subcategories.AsTracking()
                                                           .FirstOrDefaultAsync(x => x.Id == id && x.CategoryId == categoryId);

            if (subcategoryDb is null)
            {
                return NotFound(new ProblemDetails()
                {
                    Status = StatusCodes.Status404NotFound,
                    Title = "Subcategory not found",
                    Detail = $"Subcategory with id {id} was not found"
                });
            }

            var subcategoryPatchDTO = mapper.Map<SubcategoryPatchDTO>(subcategoryDb);

            patchDoc.ApplyTo(subcategoryPatchDTO, ModelState);

            if (!ModelState.IsValid || !TryValidateModel(subcategoryPatchDTO))
            {
                return ValidationProblem(ModelState);
            }

            var categoryExists = await context.Categories.AnyAsync(x => x.Id == subcategoryPatchDTO.CategoryId);

            if (!categoryExists)
            {
                return NotFound(new ProblemDetails()
                {
                    Status = StatusCodes.Status404NotFound,
                    Title = "Subcategory not found",
                    Detail = $"Subcategory with id {subcategoryPatchDTO.CategoryId} was not found"
                });
            }

            bool subcategoryExists = await context.Subcategories.AnyAsync(x => x.Id != id &&
                                                                               x.Name == subcategoryPatchDTO.Name &&
                                                                               x.CategoryId == subcategoryPatchDTO.CategoryId);

            if (subcategoryExists)
            {
                return Conflict(new ProblemDetails
                {
                    Status = StatusCodes.Status409Conflict,
                    Title = "Duplicate subcategory",
                    Detail = $"Subcategory {subcategoryPatchDTO.Name} already exists"
                });
            }

            mapper.Map(subcategoryPatchDTO, subcategoryDb);

            // await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid categoryId, Guid id)
        {
            var subcategory = await context.Subcategories.FirstOrDefaultAsync(x => x.Id == id && x.CategoryId == categoryId);

            if (subcategory is null)
            {
                return NotFound(new ProblemDetails()
                {
                    Status = StatusCodes.Status404NotFound,
                    Title = "Subcategory not found",
                    Detail = $"Subcategory with id {id} was not found"
                });
            }

            context.Remove(subcategory);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private async Task<int> GetOrder(Guid categoryId)
        {
            var hasData = await context.Subcategories.AnyAsync(x => x.CategoryId == categoryId);

            if (hasData)
            {
                var order = await context.Subcategories.Where(x => x.CategoryId == categoryId)
                                                       .MaxAsync(x => x.Order);

                return order + 1;
            }

            return 1;
        }

    }
}
