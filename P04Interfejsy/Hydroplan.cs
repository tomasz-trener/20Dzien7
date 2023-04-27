using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class Hydroplan : IUmiejacyPlywac, IUmiejacyLatac
    {
        public void Lec()
        {
            Console.WriteLine("Hydroplan Leci");
        }

        public void Plyn()
        {
            Console.WriteLine("hydroplan plynie ");
        }
    }
}
