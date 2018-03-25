using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
   public class DomainBase
    {
        public DomainBase()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
