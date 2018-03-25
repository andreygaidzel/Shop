using AutoMapper;
using Shop.DAL.Models;
using Shop.Domain.Category;

namespace Shop.DAL.Mapping
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDomain>();
            CreateMap<CategoryDomain, Category>();

            CreateMap<SubCategory, SubCategoryDomain>();
            CreateMap<SubCategoryDomain, SubCategory>();
        }
    }
}
