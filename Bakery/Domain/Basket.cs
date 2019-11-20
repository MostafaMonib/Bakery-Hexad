using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Domain
{
    public class Basket
    {
        public int IdBasket { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
        public decimal Total { get; set; }
    }
}
