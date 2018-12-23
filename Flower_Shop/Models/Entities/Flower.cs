using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flower_Shop.Models.Entities
{
    public class Flower
    {
        public int FlowerId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime Date => DateTime.Now;
    }
}
