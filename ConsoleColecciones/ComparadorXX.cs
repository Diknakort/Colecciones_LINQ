using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColecciones
{
    internal class ComparadorXX : IComparer<Persona>
    {
        public int Compare(Persona? x, Persona? y)
        {
            return (int)x.sueldo - (int)y.sueldo;
        }
    }
}
