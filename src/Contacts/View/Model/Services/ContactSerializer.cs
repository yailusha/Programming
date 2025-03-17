using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    class ContactSerializer
    {
        private string filePath = Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)),
            "Contacts", "contacts.json");

        public void SaveFile(Contact contact)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(contact);
            System.IO.File.WriteAllText(filePath, json);
        }

        public Contact LoadFile()
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File was not found.");
            }
            string json = File.ReadAllText(filePath);
            Contact contact = Newtonsoft.Json.JsonConvert.DeserializeObject<Contact>(json);
            return contact;
        }
    }
}
