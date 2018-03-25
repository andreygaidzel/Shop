using System.Collections.Generic;

namespace Shop.Domain.Category
{
    public class CategoryDomain : DomainBase
    {
        public CategoryDomain()
        {
            SubCategories = new List<SubCategoryDomain>();
        }
        public string Name { get; set; }
        public List<SubCategoryDomain> SubCategories { get; set; }
    }
}
