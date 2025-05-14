using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using Model;
using Newtonsoft.Json;

namespace Services
{
    /// <summary>
    /// Хранит методы сериализатора контактов.
    /// </summary>
    internal class ContactSerializer
    {
        /// <summary>
        /// Путь до "Мои документы".
        /// </summary>
        private static string _documentDirection = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        /// <summary>
        /// Путь до "Contacts".
        /// </summary>
        private static string _contactsDirection = Path.Combine(_documentDirection, "Contacts");

        /// <summary>
        /// Путь до файла.
        /// </summary>
        private string _filePath = Path.Combine(_contactsDirection, "contacts.json");

        /// <summary>
        /// Записывает данные в файл.
        /// </summary>
        /// <param name="contacts">Коллекция контактных данных человека.</param>
        public void SaveFile(ObservableCollection<Contact> contacts)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contacts can not be saved");
            }
        }

        /// <summary>
        /// Выгружает коллекцию контактных данных людей в программу.
        /// </summary>
        /// <returns>Коллекция контактов</returns>
        public ObservableCollection<Contact> LoadFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    return new ObservableCollection<Contact>();
                }
                string json = File.ReadAllText(_filePath);
                var contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json);
                return contacts ?? new ObservableCollection<Contact>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contacts could not be loaded");
                return new ObservableCollection<Contact>(); 
            }
        }
    }
}
