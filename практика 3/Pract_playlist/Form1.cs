using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Pract_Shop;

namespace Pract_playlist
{
    public partial class Form1 : Form
    {
        Playlist PL1 = new Playlist(); // плейлист
        private string FILENAME = "Songs.txt"; // Имя файла для хранения песен

        public Form1()
        {
            InitializeComponent();
            LoadSongsFromFile(); // Загружаем песни из файла при запуске
            UpdatePlaylist();     // Обновляем список песен
            UpdateSongPlayed();   // Обновление текущей песни
        }

        // добавление новой песни
        private void SongAdd(object sender, EventArgs e)
        {
            string Title = textBox1.Text;  
            string author = textBox2.Text;  
            string Way = textBox3.Text;     

            // Проверяем, что заполнены обязательные поля
            if (!string.IsNullOrEmpty(Title) || !string.IsNullOrEmpty(Way))
            {
                PL1.AddSong(author, Title, Way); // Добавляем песню в плейлист
                UpdatePlaylist();                // Обновляем отображение плейлиста
                UpdateSongPlayed();              // Обновляем текущую песню
                SaveSongsToFile();               // Сохраняем изменения в файл
            }
            else
            {
                MessageBox.Show("поля названия и пути должны быть заполнены!!");
            }
        }

        // Обновление списка песен
        void UpdatePlaylist()
        {
            ListSongs.Items.Clear(); // Очищаем текущий список

            // Добавляем все песни из плейлиста в ListBox
            foreach (var song in PL1.AllSongs())
            {
                ListSongs.Items.Add(song.ToString());
            }

            if (PL1.CurrInd >= 0 && PL1.CurrInd < ListSongs.Items.Count)
            {
                ListSongs.SelectedIndex = PL1.CurrInd;
            }
        }

        //Удаление песни
        private void DeleteSong_Click(object sender, EventArgs e)
        {
            if (ListSongs.SelectedIndex != -1) // Проверяем, что песня выбрана
            {
                PL1.RemoveSong(ListSongs.SelectedIndex); // Удаляем песню из плейлиста
                UpdatePlaylist();                       // Обновляем отображение
                UpdateSongPlayed();                     // Обновляем текущую песню
                SaveSongsToFile();                      // Сохраняем изменения в файл
            }
        }

        //Убрать все песни
        private void RemoveAllSong(object sender, EventArgs e)
        {
            PL1.Clear();         // Очищаем плейлист
            UpdatePlaylist();    // Обновляем отображение
            SaveSongsToFile();   // Сохраняем изменения в файл
        }

        // Поменять песню
        void UpdateSongPlayed()
        {
            if (PL1.Count > 0) // Если ли в плейлисте есть песни
            {
                // Отображаем информацию о текущей песне
                label8.Text = PL1.CurrentSong().Author;    // Автор
                label9.Text = PL1.CurrentSong().Title;     // Название
                label7.Text = PL1.CurrentSong().Filename;  // Путь к файлу
            }
            else // Если плейлист пуст
            {
                label8.Text = "";
                label9.Text = "";
                label7.Text = "";
            }
        }

        // След песня
        private void Next(object sender, EventArgs e)
        {
            bool rez = PL1.Next(); 
            if (rez) UpdateSongPlayed(); // Если успешно, обновляем отображение
        }

        // Обработчик перехода к предыдущей песне
        private void Previous(object sender, EventArgs e)
        {
            bool rez = PL1.Previous();
            if (rez) UpdateSongPlayed(); // Если успешно, обновляем отображение
        }

        // Включение песни по двойному нажатию
        private void ListSongs_DoubleClick(object sender, EventArgs e)
        {
            if (ListSongs.SelectedIndex != -1) // Если песня выбрана
            {
                PL1.SwitchTo(ListSongs.SelectedIndex); // Переключаемся на выбранную песню
                UpdateSongPlayed();                    // Обновляем отображение
            }
        }

        //Загрузка из файла
        private void LoadSongsFromFile()
        {
            if (File.Exists(FILENAME)) // Проверяем существование файла
            {
                try
                {
                    string[] lines = File.ReadAllLines(FILENAME); // Читаем все строки из файла
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|'); // Разделяем строку по разделителю
                        if (parts.Length == 3) 
                        {
                            PL1.AddSong(parts[0], parts[1], parts[2]); // Добавляем песню в плейлист
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке из файла: {ex.Message}");
                }
            }
        }

        // Созранение в файл песни
        private void SaveSongsToFile()
        {
            try
            {
                List<string> lines = new List<string>();

                foreach (Song song in PL1.AllSongs())
                {
                    lines.Add($"{song.Author}|{song.Title}|{song.Filename}");
                }
                File.WriteAllLines(FILENAME, lines); // Записываем все строки в файл
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении в файл: {ex.Message}");
            }
        }

        // Обработчик перехода ко второй форме
        private void Zad2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Создаем вторую форму
            this.Close();              // Закрываем текущую форму
            form2.Show();              // Показываем вторую форму
        }

        private void FirstSong(object sender, EventArgs e)
        {
            PL1.FirstSong(); // Переключаемся на первую песню
            UpdateSongPlayed();
        }

        //удалить текущую песню
        private void RemoveCurrentSong(object sender, EventArgs e)
        {
            if (PL1.Count > 0)
            {
                PL1.RemoveSong(PL1.CurrentSong()); // Используем перегрузку
                UpdatePlaylist();
                UpdateSongPlayed();
                SaveSongsToFile();
            }
        }
        // Создание ремикса
        private void CreateRemix(object sender, EventArgs e)
        {
            if (ListSongs.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите песню для создания ремикса!");
                return;
            }

            Song? remixSong = PL1.CreateRemix(ListSongs.SelectedIndex);

            if (remixSong == null)
            {
                MessageBox.Show("Нельзя создать ремикс из ремикса или песня не выбрана!");
                return;
            }

            PL1.AddSong(remixSong.Value); 
            UpdatePlaylist();
            SaveSongsToFile();
        }
    }
}