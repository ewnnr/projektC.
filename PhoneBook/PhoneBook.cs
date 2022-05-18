using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        
        //Metod för att visa kontakter
        private void DisplayContacts(Contact contact)
        {
            Console.WriteLine($"Kontakt: {contact.Name}, {contact.Number}");
        }
        //Metod för att visa loopa igenom alla kontakter som finns i listan, och sedan visa dem med hjälp av tidigare metod. 
        private void ContactList(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContacts(contact);
            }
        }

        //Metod för att lägga till kontakt i kontaktboken
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        //Metod för att visa en kontakt med nummer
        public void DisplayContact (string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Kontakten hittades inte");
            }
            else
            //Här används tidigare skapad metod
            {
                DisplayContacts(contact); 
            }
        }
        //Metod för att visa alla kontakter
        public void DisplayAll()
        {
            ContactList(_contacts);
        }

        //Metod för att söka efter kontakt med namn
        public void SearchContact(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            ContactList(matchingContacts);
        }
    }
}
