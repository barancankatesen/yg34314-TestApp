using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike.DataLayer.Models
{
   public class Supplier : BaseEntity
    {
        public string CompanyName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
