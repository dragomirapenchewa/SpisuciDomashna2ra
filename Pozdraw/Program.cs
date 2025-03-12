using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozdraw
{
    internal class Program
    {
        static void Pozdraw(string name)
        {
            
            Console.WriteLine("Zdraweite, " + name );
        }
        static void Main(string[] args)
        {
            Pozdraw("Tonq Belezirewa");
            Pozdraw("Uchenici");
        }
    }
}
