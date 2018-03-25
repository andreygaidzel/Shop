using System.Collections.Generic;
using Shop.Domain.Category;

namespace Shop.BLL.Abstract.Services
{
    public interface ICategoryService
    {
        List<CategoryDomain> List();
    }
}
