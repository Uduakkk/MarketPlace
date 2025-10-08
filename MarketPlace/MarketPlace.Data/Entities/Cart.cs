using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Entities
{
    public class Cart : Entity<string>
    {
        public string? UserId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PricePer { get; set; }
        public bool IsPurchased { get; set; } = false;
    }
}
