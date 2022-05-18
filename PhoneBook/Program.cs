using System;

namespace PhoneBook
{
    internal class Program
    {
        //Menyn med de olika valen för telefonboken. 
        static void Main(string[] args)
        {
            Console.WriteLine("TELEFONBOK");
            Console.WriteLine("Välj alternativ nedan");
            Console.WriteLine("1. Lägg till kontakt");
            Console.WriteLine("2. Sök kontakt med telefonnummer");
            Console.WriteLine("3. Visa alla kontakter");
            Console.WriteLine("4. Sök kontakt med namn");
            Console.WriteLine("Tryck x för att stänga telefonboken");
            //Sparar användarens val i en variabel
            var userInput = Console.ReadLine();
            //Telefonbokens klass sparad i en variabel
            var phoneBook = new PhoneBook();
            //Whileloop med true för att köra loopen medans alternativ finns
            while (true)
            {//Switch-sats för de olika alternativen, här används användarens tidigare inmatade val, för att komma på rätt alternativ. 
                switch (userInput)
                {
                    //Lägger till ny kontakt med hjälp av metoden AddContact som skapades i klassen PhoneBook
                    case "1":
                        Console.WriteLine("Namn på kontakten:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Kontaktens nummer:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;

                        //Sök efter nummer i kontaktboken, med hjälp av metoden DisplayContact från klassen PhoneBook
                    case "2":
                        Console.WriteLine("Nummer att söka efter:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);

                        break;

                        //Visa alla kontakter, med metden DisplayAll från klassen PhoneBook
                    case "3":
                        phoneBook.DisplayAll();

                        break;

                        //Sök efter kontakt med namn, metoden SearchContact från klassen Phonebook
                    case "4":
                        Console.WriteLine("Skriv namn att söka efter:");
                        var searchName = Console.ReadLine();
                        phoneBook.SearchContact(searchName);

                        break;

                        //Alternativ för att stänga programmet. 
                    case "x":
                        return;

                        //Default om användaren anger felaktigt alternativ i menyn. 
                    default:
                        Console.WriteLine("Ange giltigt alternativ!");
                        break;
                }
                //Whileloopen gör så att användaren kan välja nytt alternativ från menyn när tidigare valt alternativ har utförts. 
                Console.WriteLine("Välj nytt alternativ:");
                userInput = Console.ReadLine();
            }

        }

            
    }
}
