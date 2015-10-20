﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace storage.Models {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string URLlink { get; set; }
    }
}