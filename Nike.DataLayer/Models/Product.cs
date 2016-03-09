using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike.DataLayer.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int CategoryID { get; set; }

        [NotMapped]
        public string deneme2 { get; set; }

        public string deneme { get; set; }

        public int SupplierID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
    }
}
