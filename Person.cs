using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjektOOD_Grupp10
{
    // EXAMPLE OF ABSTRACTION
    abstract class Person
    {
        protected int Id { get; set; }
        protected string? Name { get; set; }
    }
}