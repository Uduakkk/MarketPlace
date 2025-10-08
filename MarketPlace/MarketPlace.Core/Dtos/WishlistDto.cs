using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Core.Dtos
{
    public class WishlistDto
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductImagePath { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
}
