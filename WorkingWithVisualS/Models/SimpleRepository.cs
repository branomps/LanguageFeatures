﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVisualS.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> product = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name ="Kayak", Price = 275M},
                new Product {Name ="Lifejacket", Price = 48.50M},
                new Product {Name ="Soccer ball", Price = 19.50M},
                new Product {Name ="Corner flag" , Price = 34.95M},
                new Product {Name ="Soccer Web", Price = 20M}
            };
            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
            product.Add("Error", null);
        }
        public IEnumerable<Product> Products => product.Values;

        public void AddProduct(Product p) => product.Add(p.Name, p);
    }
}
