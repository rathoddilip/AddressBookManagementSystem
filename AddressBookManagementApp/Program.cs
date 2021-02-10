using System;
using System.Collections.Generic;

namespace AddressBookManagementApp
{

    class Person
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNumber;
        public string emailId;

    }

    public class PersonDetail
    {

        List<Person> listgetDetail;//Ability to add multiple person to address book
        public PersonDetail()
        {
            listgetDetail = new List<Person>();
        }
        public void PersonAddress()
        {
            Person person = new Person();
            Console.WriteLine("Enter first name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter city");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter state");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter zipCode");
            person.zipCode = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            person.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter emaiId");
            person.emailId = Console.ReadLine();

            listgetDetail.Add(person);

        }
        public void DispalyAddressBook()
        {
            foreach (Person person in listgetDetail)
            {
                Console.WriteLine("first Name: " + person.firstName);
                Console.WriteLine("last Name: " + person.lastName);
                Console.WriteLine("Address: " + person.address);
                Console.WriteLine("City: " + person.city);
                Console.WriteLine("State: " + person.state);
                Console.WriteLine("Zip code: " + person.zipCode);
                Console.WriteLine("PhoneNumber: " + person.phoneNumber);
                Console.WriteLine("EmailId: " + person.emailId);
            }
        }

        public void EditAddressBook(string firstname, string lastname)
        {
            int count = 0;
            bool exits = false;
            foreach (Person person in listgetDetail)
            {
                if (firstname == person.firstName && lastname == person.lastName)
                {
                    Console.WriteLine("Edit contacts detail as per your choice!! ");
                    exits = true;
                    break;
                }
                count++;
            }
            if (exits)
            {
                Console.WriteLine("Enter first name");
                listgetDetail[count].firstName = Console.ReadLine();
                Console.WriteLine("Enter Last name");
                listgetDetail[count].lastName = Console.ReadLine();
                Console.WriteLine("Enter address");
                listgetDetail[count].address = Console.ReadLine();
                Console.WriteLine("Enter city");
                listgetDetail[count].city = Console.ReadLine();
                Console.WriteLine("Enter state");
                listgetDetail[count].state = Console.ReadLine();
                Console.WriteLine("Enter zipCode");
                listgetDetail[count].zipCode = Console.ReadLine();
                Console.WriteLine("Enter phone number");
                listgetDetail[count].phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter emaiId");
                listgetDetail[count].emailId = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Contact not found!!");
            }
        }
        internal void DeleteAddressBook(string firstname, string lastname)
        {
            int count = 0;
            bool exits = false;
            foreach (Person person in listgetDetail)
            {
                if (firstname == person.firstName && lastname == person.lastName)
                {
                    exits = true;
                    break;
                }
                count++;
            }
            if (exits)
            {
                listgetDetail.Remove(listgetDetail[count]);
                Console.WriteLine("Contact deleted successfully");
            }
            else
            {
                Console.WriteLine("Contact not found!!");
            }
        }
        public class AddressBookCollection
        {
            public Dictionary<string, PersonDetail> addressBookDictionary;
            public AddressBookCollection()
            {
                addressBookDictionary = new Dictionary<string, PersonDetail>();
            }
            public void PrintAllAddressBookNames()
            {
                foreach (var AddressBookItem in addressBookDictionary)
                {
                    Console.WriteLine(AddressBookItem.Key);
                }
            }
        }

        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Address book management system!");
                Console.WriteLine("Enter Default Address Book Name");
                string addressBookName = Console.ReadLine();
                AddressBookCollection addressBookCollection = new AddressBookCollection();
                PersonDetail persongetDetail = new PersonDetail();
                addressBookCollection.addressBookDictionary.Add(addressBookName, persongetDetail);
                int choice;
                do
                {
                    Console.WriteLine("Enter your choice");

                    Console.WriteLine("1) Add a new contact to address book");
                    Console.WriteLine("2) Edit existing contace person using person's name ");
                    Console.WriteLine("3) Delete a person using person's name ");
                    Console.WriteLine("4) Display All contacts");
                    Console.WriteLine("5) Add new Address book");
                    Console.WriteLine("6) Choose the address book");
                    Console.WriteLine("7) Exit");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {

                        case 1:
                            addressBookCollection.addressBookDictionary[addressBookName].PersonAddress();//add new record

                            break;
                        case 2:
                            Console.WriteLine("Enter first name");//edit();
                            string firstname = Console.ReadLine();
                            Console.WriteLine("Enter Last name");
                            string lastname = Console.ReadLine();
                            addressBookCollection.addressBookDictionary[addressBookName].EditAddressBook(firstname, lastname);
                            break;
                        case 3:
                            Console.WriteLine("Enter first name");//edit();
                            firstname = Console.ReadLine();
                            Console.WriteLine("Enter Last name");
                            lastname = Console.ReadLine();
                            addressBookCollection.addressBookDictionary[addressBookName].DeleteAddressBook(firstname, lastname);
                            break;
                        case 4:
                            Console.WriteLine("List of  all contact !! ");//Display Addressbook
                            addressBookCollection.addressBookDictionary[addressBookName].DispalyAddressBook();
                            break;
                        case 5:
                            Console.WriteLine("Enter New Address Book Name");//add new address book name
                            addressBookName = Console.ReadLine();
                            addressBookCollection.addressBookDictionary.Add(addressBookName, new PersonDetail());
                            Console.WriteLine($"Address Book {addressBookName} selected!");
                            break;
                        case 6:
                            Console.WriteLine("Listing all Address Books");//listout all available address book
                            foreach (var addressBookEntry in addressBookCollection.addressBookDictionary)
                            {
                                Console.WriteLine(addressBookEntry.Key);
                            }
                        Console.WriteLine("Select an Address Book");
                        addressBookName = Console.ReadLine();
                        break;
                        case 7:
                            Console.WriteLine("Thank you!!! ");
                            break;
                    }
                } while (choice != 7);

            }
        }
    }
}