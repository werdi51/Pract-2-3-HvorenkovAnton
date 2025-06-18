using Pract_Text.Pract_Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract_Text
{
    public partial class Form1 : Form
    {
        // Экземпляр телефонной книги
        PhoneBook Book = new PhoneBook();
        // Имя файла для сохранения контактов
        public string Filename = "contacts.csv";

        public Form1()
        {
            InitializeComponent();
        }

        // загрузка контактов из файла
        void LoadContacts()
        {
            PhoneBookLoader.Load(Book, Filename);
            GridUpdate();
        }

        // Обновление DataGridView
        void GridUpdate()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Book.AllContacts();
        }

        // метод для отображения отфильтрованных контактов
        void GridUpdate(List<Contact> man)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Book.AllContacts(man);
        }

        // Подготовка к добавлению контакта
        private void AddCont(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        //  добавление нового контакта
        private void AddContact(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                Book.AddCont(textBox1.Text, textBox2.Text);
                GridUpdate();
            }
        }

        // Загрузка контактов
        private void LoadCont(object sender, EventArgs e)
        {
            LoadContacts();
        }

        // Сохранение в файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneBookLoader.Save(Book, Filename);
            MessageBox.Show("успешно сохранено");
        }

        // Поиск контакта по имени
        private void FindByName(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox4.Text))
            {
                List<Contact> search = Book.SearchName(textBox4.Text);
                if (search.Count > 0)
                {
                    GridUpdate(search);
                }
            }
        }

        // Подготовка к поиску по имени
        private void SearchCont(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        // Подготовка к удалению контакта
        private void DeleteContButt(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        // Удаление по имени
        private void DeleteButton(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                bool rez = Book.RemoveCont(textBox3.Text);
                if (!rez)
                {
                    MessageBox.Show("Удалить не получилось");
                }
                else
                {
                    GridUpdate();
                    MessageBox.Show("удалено");
                }
            }
        }

        // Удаление по клику
        private void DeleteClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Получаем выбранный контакт
                Contact selectedContact = (Contact)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // Подтверждение удаления
                DialogResult result = MessageBox.Show(
                    $"Вы точно хотите удалить контакт: {selectedContact.Name}?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Удаляем через перегрузку
                    bool isRemoved = Book.RemoveCont(selectedContact);

                    if (isRemoved)
                    {
                        GridUpdate();
                    }
                }
            }
        }

        // Показывает панель переименования контакта
        private void RenameButt(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        // Переименование
        private void Rename(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите контакт для изменения");
                return;
            }
            //получаем данные о текущем контакте
            Contact selectedContact = (Contact)dataGridView1.SelectedRows[0].DataBoundItem;

            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите новое имя");
                return;
            }

            // Создаем новый контакт
            Contact modifiedContact = new Contact
            {
                Name = textBox5.Text,
                Phone = selectedContact.Phone
            };
            //удаляем старый
            Book.RemoveCont(selectedContact.Name);
            //добавляем новый
            Book.AddCont(modifiedContact);

            GridUpdate();
        }

        // Выход из приложения
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Смена номера телефона
        private void Renumber(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите контакт для изменения");
                return;
            }
            //получение текущего пользователя
            Contact selectedContact = (Contact)dataGridView1.SelectedRows[0].DataBoundItem;

            if (String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Введите новый номер");
                return;
            }

            // Создаем контакт с новым номером
            Contact modifiedContact = new Contact
            {
                Name = selectedContact.Name,
                Phone = textBox6.Text
            }; 
            // удаление старого
            Book.RemoveCont(selectedContact.Name);
            //добавление нво
            Book.AddCont(modifiedContact);

            GridUpdate();
        }

        // Показывает панель изменения номера телефона
        private void Renumberbutt(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }
    }
}
