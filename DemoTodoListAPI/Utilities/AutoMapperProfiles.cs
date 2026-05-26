using AutoMapper;
using DemoTodoListAPI.DTOs;
using DemoTodoListAPI.Entities;

namespace DemoTodoListAPI.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryCreateDTO, Category>();
            CreateMap<Category, CategoryPatchDTO>().ReverseMap();

            CreateMap<Subcategory, SubcategoryDTO>();
            CreateMap<SubcategoryCreateDTO, Subcategory>();
            CreateMap<SubcategoryUpdateDTO, Subcategory>();
            CreateMap<SubcategoryPatchDTO, Subcategory>().ReverseMap();
        }
    }
}
