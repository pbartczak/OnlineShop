﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entites
{
    public class CartLine
    {
        public Product Products { get; set; }

        public int Quantity { get; set; }

    }
}
