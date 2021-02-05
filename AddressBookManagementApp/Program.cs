﻿using System;
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

    }
   class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book management system!");
            PersonDetail persongetDetail = new PersonDetail();
            //persongetDetail.PersonAddress();
            int choice;
            do
            {
                Console.WriteLine("Enter your choice");
                
                Console.WriteLine("1) Add a new contact to address book");
                Console.WriteLine("2) Edit existing contace person using person's name ");
                Console.WriteLine("3) Delete a person using person's name ");
                Console.WriteLine("4) Display address book");
                Console.WriteLine("5) Exit");
               
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                   
                    case 1:
                        persongetDetail.PersonAddress();//add new record
                        
                        break;
                    case 2:
                        Console.WriteLine("Enter first name");//edit();
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Enter Last name");
                        string lastname = Console.ReadLine();
                        persongetDetail.EditAddressBook(firstname, lastname);
                        break;
                    case 3:
                        Console.WriteLine("Enter first name");//edit();
                        firstname = Console.ReadLine();
                        Console.WriteLine("Enter Last name");
                         lastname = Console.ReadLine();
                        persongetDetail.DeleteAddressBook(firstname, lastname);
                        break;
                    case 4:
                        Console.WriteLine("Address book!! ");//Display Addressbook
                        persongetDetail.DispalyAddressBook();
                        break;
                    case 5:
                        Console.WriteLine("Thank you!!! ");
                        break;
                }
            }while (choice != 5) ;

        }
    }
}
