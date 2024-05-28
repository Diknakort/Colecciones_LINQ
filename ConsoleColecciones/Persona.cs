using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Type;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleColecciones
{
    internal class Persona
    {
        public DateTime fechaNacimiento { get; set; }
        public string nombre { get; set; }

        public double sueldo { get; set; }

    }
    //public override string? ToString()
    //{
    //    return Console.WriteLine($"{item.nombre} nacido el {item.fechaNacimiento.ToShortDateString()} con sueldo: {item.sueldo}");
    //}
}
