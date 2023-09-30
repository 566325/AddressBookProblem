using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddNewCantact
    {
        public static List<person> contactsList = new List<person>();

        public void ContactMethod()
        {
            person Person1 = new person
            {
                FirstName = "Madhu",
                LastName = "Danyasi",
                Address = "Tettu",
                City = "Kavali",
                State = "Andhra Pradhesh",
                ZIPCode = 564328,
                PhoneNumber = 1234567890,
                Email = "madhu@mail.com"
            };
            person Person2 = new person
            {
                FirstName = "Havila",
                LastName = "Sai",
                Address = "Gudivada",
                City = "Vijayavada",
                State = "Andhra Pradesh",
                ZIPCode = 523006,
                PhoneNumber = 1234567890,
                Email = "bc@mail.com"
            };
            Person1.ValidateContactDetails();
            Person2.ValidateContactDetails();

            //storing contact details to List
            contactsList.Add(Person1);
            contactsList.Add(Person2);

        }
        public List<person> GetLIst()
        {
            return contactsList;
        }

        public void Listview()
        {
            try
            {
                if (contactsList.Count == 0)
                    Console.WriteLine("No Contacts to Display");
                else
                {
                    foreach (person i in contactsList)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Contacts");
                        Console.WriteLine($"Full Name: {i.FirstName} {i.LastName}");
                        Console.WriteLine($"Phone Number: {i.PhoneNumber}");
                        Console.WriteLine($"Email: {i.Email}");
                        Console.WriteLine($"Address: {i.Address}, \n \t{i.City}, {i.State}, {i.ZIPCode}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        /// <summary>
        /// New contact method - ask user to enter all details. using console
        /// </summary>
        public void NewContact()
        {
            try
            {
                person Person3 = new person();
                Console.WriteLine("Add a new contact.");
                Console.WriteLine("Enter First Name: ");
                Person3.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                Person3.LastName = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                Person3.Address = Console.ReadLine();
                Console.WriteLine("Enter City: ");
                Person3.City = Console.ReadLine();
                Console.WriteLine("Enter State: ");
                Person3.State = Console.ReadLine();
                Console.WriteLine("Enter ZipCode: ");
                Person3.ZIPCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone Number: ");
                Person3.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Email: ");
                Person3.Email = Console.ReadLine();
                //validating contact details
                Person3.ValidateContactDetails();
                //adding contact to list
                contactsList.Add(Person3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("New contact entry aborted.");

            }
        }
    }
}
