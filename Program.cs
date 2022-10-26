using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace ProjektOOD_Grupp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pre-Created Objects for DEMO purpose
                // Demo Customer
            Customer DemoCustomer = new Customer(1, "DemoCustomer", "customer@mail.se", "070-123 45 67");

                // Demo Admin
            Admin DemoAdmin = new Admin(1, "DemoAdmin", "admin@mail.se", "010-111 22 33");

                // Customer Methods Demo
            DemoCustomer.GetCustomerInfo();
            DemoCustomer.ViewAvailableShows();
            Console.WriteLine(""); // Empty Line

                // Admin Methods Demo
            DemoAdmin.GetAdminInfo();
            DemoAdmin.AddShow();
            Console.WriteLine(""); // Empty Line
            
            // ShowLibrary Method to display shows
                //List
            Console.WriteLine("Shows in list: ");
            ShowLibrary.DisplayShowList();
            Console.WriteLine(""); // Empty Line

                //Queue
            Console.WriteLine("Shows in queue: ");
            ShowLibrary.DisplayShowQueue();
            Console.WriteLine(""); // Empty Line
        }
    }
}