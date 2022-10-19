namespace ProjektOOD_Grupp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pre-Created Objects for DEMO purpose
                // Customers
            Customer kund0001 = new Customer(0001, "Vic", "vic@du.se", "070-123 45 67");
            Customer kund0002 = new Customer(0002, "Sam", "sam@du.se", "070-765 43 21");
            Customer kund0003 = new Customer(0003, "Baks", "bak@du.se", "070-111 222 33");
            Customer kund0004 = new Customer(0003, "Nik", "nik@du.se", "070-777 88 99");
                // Admins
            Admin admin01 = new Admin(9999, "Admin", "admin@event.nu", "010-111 22 33");
                // Events
            Concert concert01 = new Concert(10000, "The Baks", 60, "2022-10-30");
                // Scheduled Events

        }
    }
}