using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Category { get; set; } = "Watersports";
        public Product Related { get; set; }


        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };

            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.5M
            };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };

        }
    }
}
