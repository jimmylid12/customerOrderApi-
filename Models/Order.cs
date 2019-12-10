
using System;
namespace CustomersOrderService.Models
{
    public class Order
    {
        public long Id { get; set; }
        public string ProductName{ get; set; }
        public string price{ get; set; }
        public string quantity { get; set; }
    }
}
