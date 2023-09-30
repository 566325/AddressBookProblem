namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to The Address Book");
            person contacts = new person
            {
                FirstName = "Sireesha",
                LastName = "Nethi",
                Address = "Ameerpet",
                City = "Hyd",
                State = "Telangana",
                ZIPCode = 500016,
                PhoneNumber = 1234567890,
                Email = "Sireesha@gmail.com"
            };
            contacts.ValidateContactDetails();
            Console.WriteLine("Contact Details: ");
            Console.WriteLine($"Full Name: {contacts.FirstName + contacts.LastName} ");
            Console.WriteLine($"Phone Number: {contacts.PhoneNumber} ");
            Console.WriteLine($"Address: {contacts.Address} \n \t{contacts.City} {contacts.State} \n \t{contacts.ZIPCode} ");
            Console.WriteLine($"Email: {contacts.Email} ");

        }
    }
}