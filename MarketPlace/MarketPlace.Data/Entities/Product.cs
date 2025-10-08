using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Entities
{
    public class Product : Entity<String>
    {
        public string? UserId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
