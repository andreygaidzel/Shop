using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using Shop.DAL.Absctract.Repositories;
using Shop.DAL.Models;
using Shop.DAL.Repositories.Base;
using Shop.Domain.Category;

namespace Shop.DAL.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(ShopContext context) : base(context)
        {
        }

        public List<CategoryDomain> List()
        {
            var list = Context.Categories.ToList();

            return Mapper.Map<List<CategoryDomain>>(list);
        }
    }
}
