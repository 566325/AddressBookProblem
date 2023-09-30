using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class person
    {
        public string FirstName {get;set;}
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZIPCode { get; set; }
        public int PhoneNumber { get; set; }
        public string Email{ get; set; }



        private bool ValidateFullName(string firstName, string lastName)
        {
            try
            {
                if (firstName != " " && lastName != " ")
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Error in Full Name");
            }
            return false;
        }

        private bool ValidateAddress(string address, string city, string state, int zipCode)
        {
            try
            {
                if (address != " " && city != " " && state != " " && zipCode != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Error in Address");
            }
            return false;
        }
        private bool ValidateContactNumbers(long phoneNumber, string email)
        {
            try
            {
                if (phoneNumber != 0 && email != " ")
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Error in Contact Numbers");
            }
            return false;
        }
        public void ValidateContactDetails()
        {
            try
            {
                bool full_Name = ValidateFullName(FirstName, LastName);
                bool addr = ValidateAddress(Address, City, State, ZIPCode);
                bool contact = ValidateContactNumbers(PhoneNumber, Email);
                if (full_Name == true && addr == true && contact == true)
                    Console.WriteLine("Contact Details Saved Successfully");
                else
                    Console.WriteLine("Contact Save Failed!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error in Saving Details");
            }

        }

    }
    
}
