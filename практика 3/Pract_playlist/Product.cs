using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_Shop
{
     class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Конструктор товара
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // Возвращает строку с описанием товара
        public string GetInfo() => $"Наименование: {Name}; Цена: {Price} руб.";
    }
}
