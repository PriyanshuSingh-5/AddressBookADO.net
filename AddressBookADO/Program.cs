using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook System program using ADO.NET");
            ///Creating Instance object of AddressBookRepository class.
            AddressBookRepository repository = new AddressBookRepository();
            ///UC1 Creating a method for checking for the validity of the connection.
            //repository.EnsureDataBaseConnection();
            /// UC 3: Adds the new contact into DB table.
            Console.WriteLine(repository.EditContactUsingName("Richa", "Sharma", "Speaker") ? "Update done successfully\n" : "Update failed");
        }
        public static void AddNewContactDetails()
        {
            AddressBookRepository repository = new AddressBookRepository();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Richa";
            model.LastName = "Sharma";
            model.Address = "Karauli";
            model.City = "Karauli";
            model.State = "Rajasthan";
            model.Zip = 555666;
            model.PhoneNumber = 8411563241;
            model.EmailId = "Richas@gmail.com";
            model.AddressBookName = "Ritika";
            model.AddressBookType = "Friend";
            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Failed");
        }
    }
}
        
    

        
