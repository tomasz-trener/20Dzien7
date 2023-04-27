using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IUmiejsacyJezdzic[] tablicaPojazdowUmiejacychJezdzic = new IUmiejsacyJezdzic[]
            {
                new Samochod(),
                new Amfibia()
            };

            //IUmiejacyPlywac iup = new IUmiejacyPlywac();

            foreach (var p in tablicaPojazdowUmiejacychJezdzic)
            {
                p.Jedz();
            }


        }
    }
}
