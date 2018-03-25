using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Shop.DAL.Models.Base;

namespace Shop.DAL.Models
{
    public class SubCategory : EntityBase
    {
        public SubCategory()
        {
            SubSubCategories = new List<SubSubCategory>();
        }

        public string Name { get; set; }

        [ForeignKey(nameof(Category))] public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<SubSubCategory> SubSubCategories { get; set; }
    }
}