using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03DziedziczenieZadanie
{
    abstract internal class Raport //: Object
    {
        public string Zawartosc { get; set; }
        public int Rozmiar { get; set; }
        public string Autor { get; set; }
        public string Sciezka { get; set; }

        public string Nazwa { get; set; }

        private protected string rozszerzenie; 

        public virtual void Zapisz()
        {
            File.WriteAllText(Sciezka + "\\" + Nazwa + rozszerzenie,Zawartosc);
        }

        public override string ToString()
        {
            return "To jest plik, którego nazwa to: " + Nazwa;
        }
    }
}
