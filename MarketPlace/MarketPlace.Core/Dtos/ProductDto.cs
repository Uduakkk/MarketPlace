using MarketPlace.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Core.Dtos
{
    public class ProductDto : BaseModel<string>
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
