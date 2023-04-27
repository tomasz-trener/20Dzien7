using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class Samochod : IUmiejsacyJezdzic
    {
        public string Nazwa => throw new NotImplementedException();

        public void Jedz()
        {
            Console.WriteLine("Jedz");
        }
    }
}
