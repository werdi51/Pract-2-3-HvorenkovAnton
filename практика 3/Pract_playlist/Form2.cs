using Pract_playlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract_Shop
{
    public partial class Form2 : Form
    {
        private Shop shop = new Shop();

        public Form2()
        {
            InitializeComponent();
            UpdateProductList(); // показ товаров при запуске
        }

        // добавить товар
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = NameTovar.Text.Trim();
            decimal price = TovarPrice.Value;
            int count = (int)TovarCount.Value;

            // Проверка
            if (string.IsNullOrWhiteSpace(name) || price <= 0 || count <= 0)
            {
                MessageBox.Show("Введите корректные данные.");
                return;
            }

            // Добавление товара в магазин
            shop.CreateProduct(name, price, count);
            UpdateProductList();
        }

        //Продать товар
        private void btnSell_Click(object sender, EventArgs e)
        {
            string name = NameForSell.Text.Trim();
            int count = (int)CountForSell.Value;

            shop.Sell(name, count); // продажа
            UpdateProductList();
        }

        // Обновление списка товаров
        private void UpdateProductList()
        {
            Tovars.Items.Clear();
            Tovars.Items.AddRange(shop.GetAllProductsInfo().ToArray());
            Rez.Text = $"Прибыль: {shop.GetProfit()} руб.";
            label6.Text = $"Общая стоимость на складе: {shop.PriceAll()} ";
        }

        private void Zad3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Close();
            form1.Show();
            
        }


    }
}
