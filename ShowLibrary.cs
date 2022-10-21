using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class ShowLibrary
    {
        static List<object> ShowList = new List<object>();

        static Queue<object> ShowQueue = new Queue<object>();

        public static void ListShow(object obj)
        {
            ShowList.Add(obj);
        }

        public static void QueueShow(object obj)
        {
            ShowQueue.Enqueue(obj);
        }

        public static void DisplayShowList()
        {
            foreach (Show show in ShowList)
            {
                Console.WriteLine($"Name: {show.GetName()} Duration: {show.GetDuration()}min Release date: {show.GetRelease()}");
            }
        }

        public static void DisplayShowQueue()
        {
            foreach (Show show in ShowQueue)
            {
                Console.WriteLine($"Name: {show.GetName()} Duration: {show.GetDuration()}min Release date: {show.GetRelease()}");
            }
        }
    }
}
