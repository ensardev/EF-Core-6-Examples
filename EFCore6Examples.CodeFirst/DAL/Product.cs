using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore6Examples.CodeFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Barcode { get; set; }
        public int CategoryId { get; set; }

        //Navigation property
        public virtual Category Category { get; set; }
        public virtual ProductFeature Feature { get; set; } = new ProductFeature();

    }
}
