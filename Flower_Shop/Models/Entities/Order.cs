using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flower_Shop.Models.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public int Price { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
