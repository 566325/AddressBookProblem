namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddNewCantact AddContact = new AddNewCantact();

            AddContact.ContactMethod();
            
            Display display = new Display();
            display.DisplayChoice();
            display.Selection();


        }
    }
}