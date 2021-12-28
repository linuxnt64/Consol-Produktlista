using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Models
{
    public class ProductModel
    {
        public string Name { get; set; } = "";
        public string Id { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; } = 0;
        public decimal Quantity { get; set; } = 0;
        public string Category { get; set; } = "";
        
    }
}
