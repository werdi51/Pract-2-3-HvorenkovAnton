using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_Text
{
    namespace Pract_Text
    {
        class PhoneBook
        {
            // Список контактов
            public List<Contact> list = new List<Contact>();

            // Добавление контакта по имени и номеру
            public void AddCont(string name, string number)
            {
                list.Add(new Contact { Name = name, Phone = number });
            }

            // Добавление готового номера
            public void AddCont(Contact contact)
            {
                list.Add(contact);
            }

            // Удаление контакта по имени
            public bool RemoveCont(string Name)
            {
                var contact = list.Find(c => c.Name.Equals(Name, StringComparison.OrdinalIgnoreCase));
                if (contact != null)
                {
                    return list.Remove(contact);
                }
                return false;
            }

            // Удаление контакта по Contact
            public bool RemoveCont(Contact contactToRemove)
            {
                if (contactToRemove == null) return false;
                return list.Remove(contactToRemove);
            }

            // Поиск контактов
            public List<Contact> SearchName(string name)
            {
                return list.FindAll(c => c.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Список всех контактов
            public List<Contact> AllContacts()
            {
                return new List<Contact>(list);
            }

            // Возвращает особенный список контактов
            public List<Contact> AllContacts(List<Contact> man)
            {
                return new List<Contact>(man);
            }
        }
    }
}
