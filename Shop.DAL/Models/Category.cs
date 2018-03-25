using System.Collections.Generic;
using Shop.DAL.Migrations;
using Shop.DAL.Models.Base;

namespace Shop.DAL.Models
{
    public class Category : EntityBase
    {
        public Category()
        {
            SubCategories = new List<SubCategory>();
        }

        public string Name { get; set; }
        public virtual List<SubCategory> SubCategories { get; set; }
    }
}
