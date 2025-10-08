using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? ProductId { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        [MaxLength(500)]
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
