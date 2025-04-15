using System.IO;
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
        /// <param name="contact">Контактные данные человека.</param>
        public void SaveFile(Contact contact)
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }
            string json = JsonConvert.SerializeObject(contact);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Выгружает контактные данные человека в программу.
        /// </summary>
        /// <returns>Контактные данные человека.</returns>
        public Contact LoadFile()
        {
            string json = File.ReadAllText(_filePath);
            Contact contact = Newtonsoft.Json.JsonConvert.DeserializeObject<Contact>(json);
            return contact;
        }
    }
}
