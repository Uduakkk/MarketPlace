using MarketPlace.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Core.Dtos
{
    public class CartDto : BaseModel<string>
    {
        public string? UserId { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal? PricePer { get; set; }
        public bool IsPurchased { get; set; } = false;
    }
}
