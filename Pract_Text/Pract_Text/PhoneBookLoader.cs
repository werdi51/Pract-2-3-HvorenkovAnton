using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Pract_Text.Pract_Text;

namespace Pract_Text
{
    namespace Pract_Text
    {
        class PhoneBookLoader
        {
            // Загрузка контактов из файла
            public static void Load(PhoneBook phoneBook, string fileName)
            {
                if (File.Exists(fileName))
                {
                    // Чтение всех строк из файла
                    string[] arr = File.ReadAllLines(fileName);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        // Разделение строки 
                        string[] info = arr[i].Split(';');
                        Contact contact = new Contact();
                        contact.Name = info[0];
                        contact.Phone = info[1];
                        phoneBook.list.Add(contact);
                    }
                }
            }

            // Сохранение контактов в файл
            public static void Save(PhoneBook phoneBook, string fileName)
            {
                List<string> lines = new List<string>();

                // Формирование строк для сохранения
                foreach (Contact contact in phoneBook.list)
                {
                    lines.Add($"{contact.Name};{contact.Phone}");
                }
                File.WriteAllLines(fileName, lines);
            }
        }
    }
}
