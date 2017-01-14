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
        private double waga;

        public GraPlanszowa() { }

        public GraPlanszowa(string nazwa, double cena, string gatunek, string dataPremiery, int ograniczenieWiekowe, int minimumOsob, int maximumOsob, double waga)
            :base(nazwa, cena, gatunek, dataPremiery, ograniczenieWiekowe)
        {
            this.minimumOsob = minimumOsob;
            this.maximumOsob = maximumOsob;
            this.waga = waga;
        }
        public override string ToString()
        {
            return "nazwa: " + nazwa + ", cena: " + cena + ", gatunek: " + gatunek + ", dataPremiery: " + dataPremiery + "ograniczenie wiekowe: " + ograniczenieWiekowe
                + "+, liczba osob: " + minimumOsob + "-" + maximumOsob + ", waga: " + waga; 
        }
    }
}
