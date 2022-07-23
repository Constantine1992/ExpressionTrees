using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionLection.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
        public DateTime ProductDate { get; set; }

        public static List<Product> GetProduct()
        {
            List<Product> products = new List<Product>
            {
                new Product{ID = 1, Name = "Печеньки", Company = "ОсОО Темная сторона", Price = 150, ProductDate = new DateTime(2018, 01, 1)},
                new Product{ID = 2, Name = "Световые мечи", Company = "Джедай Production", Price = 200, ProductDate = new DateTime(2017, 02, 1)},
                new Product{ID = 3, Name = "Чаек Элитный", Company = "Самопал", Price = 1000, ProductDate = new DateTime(2018, 03, 7)},
                new Product{ID = 3, Name = "Ананас", Company = "Рябчик", Price = 1000, ProductDate = new DateTime(2018, 10, 8)},

                 new Product{ID = 1, Name = "Печеньки", Company = "ОсОО Темная сторона", Price = 150, ProductDate = new DateTime(2018, 01, 1)},
                new Product{ID = 2, Name = "Световые мечи", Company = "Джедай Production", Price = 200, ProductDate = new DateTime(2017, 02, 1)},
                new Product{ID = 3, Name = "Чаек Элитный", Company = "Самопал", Price = 1000, ProductDate = new DateTime(2018, 03, 7)},
                new Product{ID = 3, Name = "Ананас", Company = "Рябчик", Price = 1000, ProductDate = new DateTime(2018, 10, 8)},

                 new Product{ID = 1, Name = "Печеньки", Company = "ОсОО Темная сторона", Price = 150, ProductDate = new DateTime(2018, 01, 1)},
                new Product{ID = 2, Name = "Световые мечи", Company = "Джедай Production", Price = 200, ProductDate = new DateTime(2017, 02, 1)},
                new Product{ID = 3, Name = "Чаек Элитный", Company = "Самопал", Price = 1000, ProductDate = new DateTime(2018, 03, 7)},
                new Product{ID = 3, Name = "Ананас", Company = "Рябчик", Price = 1000, ProductDate = new DateTime(2018, 10, 8)},

                 new Product{ID = 1, Name = "Печеньки", Company = "ОсОО Темная сторона", Price = 150, ProductDate = new DateTime(2018, 01, 1)},
                new Product{ID = 2, Name = "Световые мечи", Company = "Джедай Production", Price = 200, ProductDate = new DateTime(2017, 02, 1)},
                new Product{ID = 3, Name = "Чаек Элитный", Company = "Самопал", Price = 1000, ProductDate = new DateTime(2018, 03, 7)},
                new Product{ID = 3, Name = "Ананас", Company = "Рябчик", Price = 1000, ProductDate = new DateTime(2018, 10, 8)},

            };
            return products;
        }
    }
}
