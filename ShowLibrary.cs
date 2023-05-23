using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class ShowLibrary
    {
        // ######################################### LIST DATASTRUCT #################################
        static List<object> ShowList = new List<object>();
        public static void ListShow(object obj)
        {
            ShowList.Add(obj);
        }
        public static void DisplayShowList()
        {
            foreach (Show show in ShowList)
            {
                Console.WriteLine($"Name: {show.GetName()} Release date: {show.GetRelease()}");
            }
        }


        // ######################################### QUEUE DATASTRUCT #################################
        static Queue<object> ShowQueue = new Queue<object>();
        public static void QueueShow(object obj)
        {
            ShowQueue.Enqueue(obj);
        }
        public static void DisplayShowQueue()
        {
            foreach (Show show in ShowQueue)
            {
                Console.WriteLine($"Name: {show.GetName()} Release date: {show.GetRelease()}");
            }
        }

    }
}
