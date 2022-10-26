using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal interface IShowLibrary
    {
        internal void ViewAvailibleShows()
        {
            Console.WriteLine("Current available shows: ");
            ShowLibrary.DisplayShowList();

            //ShowLibrary.DisplayShowQueue();
        }
    }
}
