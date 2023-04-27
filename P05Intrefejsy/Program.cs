using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Intrefejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kalkulator kalkulator = new Kalkulator();

            double wyn1 = kalkulator.WykonajOperacji(2, 3, new MechanizmDodawania());

            double wyn2 = kalkulator.WykonajOperacji(2, 3, new MechanizmOdejmowania());


        }
    }
}
