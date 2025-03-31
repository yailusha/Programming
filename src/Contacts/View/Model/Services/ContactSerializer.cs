using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Хранит методы сериализатора контактов.
    /// </summary>
    internal class ContactSerializer
    {
        /// <summary>
        /// Путь до файла.
        /// </summary>
        public string FilePath { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "Contacts", "contacts.json");

        /// <summary>
        /// Записывает данные в файл.
        /// </summary>
        /// <param name="contact">Контактные данные человека.</param>
        /// <exception cref="Exception">Выдает ошибку, что файл не был сохранен.</exception>
        public void SaveFile(Contact contact)
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    File.Create(FilePath);
                }
                string json = JsonConvert.SerializeObject(contact);
                File.WriteAllText(FilePath, json);
            }
            catch (FileNotFoundException ex) 
            {
                throw new Exception("File could not be saved.");
            }
        }

        /// <summary>
        /// Выгружает контактные данные человека в программу.
        /// </summary>
        /// <returns>Контактные данные человека.</returns>
        /// <exception cref="FileNotFoundException">Выдает ошибку, если файл не был найден.</exception>
        public Contact LoadFile()
        {
            try
            {
                string json = File.ReadAllText(FilePath);
                Contact contact = Newtonsoft.Json.JsonConvert.DeserializeObject<Contact>(json);
                return contact;
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException("File was not found.");
            }

        }
    }
}
