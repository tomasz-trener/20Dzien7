using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class Amfibia : IUmiejacyPlywac, IUmiejsacyJezdzic
    {
        public string Nazwa => throw new NotImplementedException();

        public void Jedz()
        {
            Console.WriteLine("Amfibia Jedzie");
        }

        public void Plyn()
        {
            Console.WriteLine("Amfibia Plynie");
        }
    }
}
