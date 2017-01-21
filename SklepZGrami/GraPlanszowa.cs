using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    class GraPlanszowa: Gra
    {
        private int minimumOsob;
        private int maximumOsob;
       
        public GraPlanszowa() { }

        public GraPlanszowa(string nazwa, double cena, string gatunek, int ograniczenieWiekowe, int minimumOsob, int maximumOsob)
            :base(nazwa, cena, gatunek, ograniczenieWiekowe)
        {
            this.minimumOsob = minimumOsob;
            this.maximumOsob = maximumOsob;
            
        }
        public override string ToString()
        {
            return "nazwa: " + nazwa + ", cena: " + cena + ", gatunek: " + gatunek + "ograniczenie wiekowe: " + ograniczenieWiekowe
                + "+, liczba osob: " + minimumOsob + "-" + maximumOsob;
        }
    }
}
