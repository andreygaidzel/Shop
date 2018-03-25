using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Category
{
    public class SubCategoryDomain : DomainBase
    {
        public SubCategoryDomain()
        {
            SubSubCategories = new List<SubSubCategoryDomain>();
        }
        public string Name { get; set; }
        public List<SubSubCategoryDomain> SubSubCategories { get; set; }
    }
}
