using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal abstract class Person
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected string Email { get; set; }
        protected string Phone { get; set; }

        public string GetName()
        {
            return Name;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetPhone()
        {
            return Phone;
        }
    }

}
