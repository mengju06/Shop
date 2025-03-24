using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Models.ViewModels
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ShoppingCartList { get; set; }
        //public double OrderTotal { get; set; }
        public OrderHeader OrderHeader { get; set; }
        //public double OrderTotal { get; set; }
    }
}
