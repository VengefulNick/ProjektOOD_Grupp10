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
            Customer DemoCustomer = new Customer("DemoCustomer");

            // Demo Admin
            Admin DemoAdmin = new Admin("DemoAdmin");

            // Admin Methods Demo
            DemoAdmin.GetAdminInfo();
            DemoAdmin.AddShow();
            Console.WriteLine(""); // Empty Line

            // Customer Methods Demo
            DemoCustomer.GetCustomerInfo();

            DemoCustomer.ViewAvailableShows();
            Console.WriteLine(""); // Empty Line
        }
    }
}