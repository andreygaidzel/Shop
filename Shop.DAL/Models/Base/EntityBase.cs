using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Models.Base
{
    public class EntityBase
    {
        public EntityBase()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
