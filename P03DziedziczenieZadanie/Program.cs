using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03DziedziczenieZadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raport[] raporty = new Raport[] 
            {
                new PlikCSV() { Nazwa="Jeden", Zawartosc= "ala ma kota", Sciezka=@"C:\dane\pliki"},
                new PlikHTML() { Nazwa="Dwa", Zawartosc= "ala ma kota", Sciezka=@"C:\dane\pliki"},
                new PlikSQL() { Nazwa="Trzy", Zawartosc= "ala ma kota", Sciezka=@"C:\dane\pliki"},
            };

            //foreach (var p in raporty)
            //{
            //    if(p is PlikCSV)
            //        ((PlikCSV)p).Zapisz();

            //    if (p is PlikHTML)
            //        ((PlikHTML)p).Zapisz();

            //    if (p is PlikSQL)
            //        ((PlikSQL)p).Zapisz();
            //}

            foreach (var p in raporty)
            {
                p.Zapisz();
            }

            // abstract - zabraniam programistom tworzenia nowej instacji klasy 
            //Raport raport = new Raport();
            // po co: bo np nie wspieram takie funkcji w naszej aplikacji 
            // tylko raport traktuję jako szablon dla innych klas 


            Raport r = new PlikHTML() { Nazwa = "Mój pliczek"};
          //  r.Zapisz();
            // mamy klasę A i B. Klasa A: B 
            // override - zawsze użyj metody z klasy A 
            // new - zawsze użyj metody z klasy B 


            Object o = new object();

            Console.WriteLine(r);

            Console.ReadKey();

        }
    }
}
