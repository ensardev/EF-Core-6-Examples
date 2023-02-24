using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore6Examples.CodeFirst.DAL
{
    public class ProductFeature
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public bool WithCase { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }

    }
}
