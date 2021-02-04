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
        public int zipCode;
        public string phoneNumber;
        public string emailId;

    }

    public class PersonDetail
    {
        List<Person> getDetail;
        public PersonDetail()
        {
            getDetail = new List<Person>();
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
                person.zipCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter phone number");
                person.phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter emaiId");
                person.emailId = Console.ReadLine();

                getDetail.Add(person);
            }
        }
   class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book management system!");
            PersonDetail getDetail = new PersonDetail();
            getDetail.PersonAddress();
            int choice;
            do
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1) Display address book");
                Console.WriteLine("2) Add a new contact to address book");
                Console.WriteLine("3) Edit existing contace person using person's name ");
                Console.WriteLine("4) Delete a person using person's name ");
                Console.WriteLine("5) Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add address book details");
                        //Display
                        break;
                    case 2:
                        
                        //add();
                        break;
                    case 3:
                        //edit();
                        break;
                    case 4:
                        //delete();
                        break;
                    case 5:
                        Console.WriteLine("Thank you!!! ");
                        break;
                }
            }while (choice != 5) ;

        }
    }
}
