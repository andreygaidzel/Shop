using System.Collections.Generic;
using Shop.BLL.Abstract.Services;
using Shop.DAL.Absctract.Repositories;
using Shop.Domain.Category;

namespace Shop.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository CategoryRepository { get; }

        public CategoryService(ICategoryRepository categoryRepository)
        {
            CategoryRepository = categoryRepository;
        }

        public List<CategoryDomain> List()
        {
            return CategoryRepository.List();
        }
    }
}
