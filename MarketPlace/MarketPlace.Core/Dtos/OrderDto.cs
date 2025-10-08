using MarketPlace.Core.Enums;
using MarketPlace.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Core.Dtos
{
    public class OrderDto : BaseModel<string>
    {
        public string? BuyerId { get; set; }
        public string? BuyerName { get; set; }
        public string? SellerId { get; set; }
        public string? SellerName { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public string? PaymentMethod { get; set; }
        public string? DeliveryAddress { get; set; }
        public ICollection<OrderItemDto>? Items { get; set; }
    }
}
