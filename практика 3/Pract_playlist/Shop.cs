using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract_Shop
{
    class Shop
    {
        // Коллекция хранящая продукты магазина
        private Dictionary<Product, int> products = new Dictionary<Product, int>();

        // Прибыль
        public decimal Profit { get; private set; } = 0;

        // Добавляет продукт с указанным количеством
        public void AddProduct(Product product, int count)
        {
            if (products.ContainsKey(product))
                products[product] += count; // если товар уже есть, увеличиваем количество
            else
                products.Add(product, count);
        }

        // Создаёт новый товар
        public void CreateProduct(string name, decimal price, int count)
        {
            AddProduct(new Product(name, price), count);
        }

        // Возвращает список с информацией о продуктах
        public List<string> GetAllProductsInfo()
        {
            return products.Select(p =>
                $"{p.Key.GetInfo()}; Количество: {p.Value}"
            ).ToList();
        }

        // Поиск товара по имени
        public Product FindByName(string name)
        {
            return products.Keys.FirstOrDefault(p => p.Name == name);
        }

        // Продажа товара с проверками
        public void Sell(Product product, int amount = 1)
        {
            if (!products.ContainsKey(product))
            {
                MessageBox.Show("Товар не найден!");
                return;
            }

            if (products[product] < amount)
            {
                MessageBox.Show("Недостаточно товара на складе!");
                return;
            }

            products[product] -= amount;
            Profit += product.Price * amount;
        }

        // Продажа по имени товара
        public void Sell(string productName, int amount = 1)
        {
            Product product = FindByName(productName);
            if (product != null)
                Sell(product, amount);
            else
                MessageBox.Show("Товар не найден!");
        }

        // Возвращает текущую прибыль магазина
        public decimal GetProfit() => Profit;

        public decimal PriceAll()
        {
            return products.Sum(p => p.Key.Price * p.Value);
        }
    }
}
