﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreUserInterface
{
    public class Cart
    {
        public Cart(string id,string name, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Id { get; set; }  

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

    }
}
