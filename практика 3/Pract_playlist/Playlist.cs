using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_playlist
{
    public class Playlist
    {
        private List<Song> list; //Лист песен


        private int currentIndex; //Текущая песня

        public int Count => list.Count; //Вывод Длинны коллекции песен
        public int CurrInd => currentIndex; //Вывод текущего индекса песни


        // Конструктор плейлиста
        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        // Метод получения текущей песни
        public Song CurrentSong()
        {
            if (list.Count > 0) // Если есть песни в плейлисте
            {
                return list[currentIndex];
            }
            else
                throw new IndexOutOfRangeException(
                    "Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }

        // Добавление песни 
        public void AddSong(Song song)
        {
            list.Add(song);
        }

        // Добавление песни 
        public void AddSong(string author, string title, string filename)
        {
            list.Add(new Song { Author = author, Title = title, Filename = filename });
        }

        // Переход к следующей песне
        public bool Next()
        {
            if (list.Count == 0) return false;

            if (currentIndex < list.Count - 1)
            {
                currentIndex++;
                return true;
            }
            return false;
        }
        //Метод переключающий на предыдущую песню
        public bool Previous()
        {
            if (list.Count == 0) return false;

            if (currentIndex > 0) 
            {
                currentIndex--;
                return true;
            }
            return false;
        }

        // Переключение на песню по указанной позиции
        public void SwitchTo(int Poz)
        {
            if (Poz >= 0 && Poz < list.Count) 
            {
                currentIndex = Poz; // Устанавливаем новый индекс
            }
        }

        // Получение всех песен плейлиста
        public List<Song> AllSongs()
        {
            return new List<Song>(list); 
        }

        // Очистка плейлиста
        public void Clear()
        {
            list.Clear();       // Очищаем список
            currentIndex = 0;   // Сбрасываем индекс
        }

        // Удаление песни по объекту 
        public void RemoveSong(Song sng)
        {
            int index = list.IndexOf(sng); // Находим индекс песни
            if (index >= 0)
            {
                RemoveSong(index); // Удаляем по индексу
            }
        }

        // Удаление песни по индексу 
        public void RemoveSong(int number)
        {
            if (number >= 0 && number < list.Count)
            {
                list.RemoveAt(number); 

                if (currentIndex >= list.Count && list.Count > 0)
                {
                    currentIndex = list.Count - 1;
                }
                else if (list.Count == 0)
                {
                    currentIndex = 0;
                }
            }
        }

        // Переход к первой песне в плейлисте
        public void FirstSong()
        {
            if (list.Count > 0) // Если есть песни
            {
                currentIndex = 0;
            }
        }
        public Song? CreateRemix(int songIndex)
        {
            if (songIndex < 0 || songIndex >= list.Count)
                return null;

            Song originalSong = list[songIndex];

            // Проверяем, не является ли песня уже ремиксом
            if (originalSong.Title.Contains("(Remix)"))
            {
                return null; // Не даём создать ремикс из ремикса
            }

            // Создаём ремикс-версию
            Song remixSong = new Song
            {
                Author = originalSong.Author,
                Title = $"{originalSong.Title} (Remix)", // Добавляем пометку
                Filename = originalSong.Filename // Можно изменить путь, если ремикс — отдельный файл
            };

            return remixSong;
        }
    }
}
