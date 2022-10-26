using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjektOOD_Grupp10
{
    internal abstract class Person : IShowLibrary
    {
        protected int? Id { get; set; }
        protected string? Name { get; set; }
        protected string? Email { get; set; }
        protected string? Phone { get; set; }
    }
}