using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Core.Dtos
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public decimal Amount { get; set; }
        public string? TransactionRef { get; set; }
        public string? PaymentMethod { get; set; }
        public bool IsSuccessful { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
    }
}
