using System.Collections.Generic;
using Shop.Domain.Category;

namespace Shop.DAL.Absctract.Repositories
{
    public interface ICategoryRepository
    {
        List<CategoryDomain> List();
    }
}
