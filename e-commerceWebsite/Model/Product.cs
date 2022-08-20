﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_website.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
        public decimal Price { get; set; }
        public string ProductImage { get; set; }
        public string ProductImageAlt{ get; set; }
       
    }
}
