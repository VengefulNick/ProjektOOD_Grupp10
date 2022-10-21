﻿using System.ComponentModel.Design;
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
            Customer DemoCustomer = new Customer("DemoCustomer", "customer@mail.se", "070-123 45 67");
                // Demo Admin
            Admin DemoAdmin = new Admin("DemoAdmin", "admin@mail.se", "010-111 22 33");

                // Add 100 Demo Shows
            for (int i = 1; i < 101; i++)
            {
                //string name = "Number" + i.ToString();
                Show DemoShow = new Show("Number" + i.ToString(), 60, "2022-12-24");
                ShowLibrary.ListShow(DemoShow);
            }

                // Admin Methods Demo
            //DemoAdmin.AddShow();

            // Customer Methods Demo
            DemoCustomer.ViewAvailibleShows();

                // ShowLibrary Method to display shows
            //Console.WriteLine("Shows in list: ");
            //ShowLibrary.DisplayShowList();

            //Console.WriteLine("Shows in queue: ");
            //ShowLibrary.DisplayShowQueue();
        }
    }
}