using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02Dziedziczenie
{
    internal class Czlowiek
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string PrzedstawSie()
        {
            return "Nazywam sie" + Imie + " " + Nazwisko;
        }
    }
}
