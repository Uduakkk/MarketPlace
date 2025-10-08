using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Entities
{
    public class Wishlist
    {
       public int Id { get; set; }

        [Required]
        public string? UserId { get; set; }
        public string? ProductId { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
}
