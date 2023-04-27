using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programista p = new Programista();
            p.Imie = "Jan";
            p.Nazwisko = "Kowalski";
            Console.WriteLine(p.PrzedstawSie());

            p.Programuj(); 


            Czlowiek c = new Czlowiek();

            Czlowiek c1 = new Programista();

            ((Programista)c1).Programuj();

            Programista p2 = (Programista)c1;


            List<Czlowiek> osoby = new List<Czlowiek>()
            {
                p,
                new Programista() { Imie= "Jan", Nazwisko="Nowak"},
                new Lekarz() { Imie="Adam", Nazwisko="Nowakowski"}
            };

            foreach (var o in osoby)
            {
                Console.WriteLine(o.PrzedstawSie());
            }

            Console.ReadKey();


        }
    }
}
