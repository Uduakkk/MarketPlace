using MarketPlace.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Entities
{
    public class Order : Entity<string>
    {
        public string? BuyerId { get; set; }
        public string? SellerId { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public string? PaymentMethod { get; set; }
        public string? DeliveryAddress { get; set; }

    }
}
