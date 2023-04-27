using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03DziedziczenieZadanie
{
    internal class PlikSQL : Raport
    {
        public PlikSQL()
        {
            rozszerzenie = ".sql";
        }

        public override void Zapisz()
        {
            Zawartosc = $"SELECT {Zawartosc} FROM Dane";

            //File.WriteAllText(Sciezka + "\\" + Nazwa + rozszerzenie, Zawartosc);
           
            // odowłaj się do klasy bazowej (czyli po tej po której dziedziczysz) 
            base.Zapisz();
        }
    }
}
