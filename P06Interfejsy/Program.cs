using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 2, 5, 6, 3, 1 };

            Array.Sort(liczby);

            Console.WriteLine(string.Join(" ", liczby));


            Krzeslo[] krzesla = new Krzeslo[]
            {
                new Krzeslo() { Firma="xxxx",Waga =3},
                new Krzeslo() { Firma="abc",Waga =2},
                new Krzeslo() { Firma="Dluga Nazwa",Waga =1},
            };

            Array.Sort(krzesla);

            foreach (var k in krzesla)
            {
                Console.WriteLine(k.Firma + " " + k.Waga);
            }


            Krzeslo k1 = new Krzeslo() { Firma = "xyz",Waga=10 };
            // Krzeslo k2 = k1;
            //Krzeslo k2 = new Krzeslo()
            //{
            //    Firma = k1.Firma,
            //    Waga = k1.Waga
            //};

            Krzeslo k2 = (Krzeslo)k1.Clone();


            Console.ReadKey();

        }
    }
}
