using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class Statek : IUmiejacyPlywac
    {
        public void Plyn()
        {
            Console.WriteLine("Plyne");
        }
    }
}
