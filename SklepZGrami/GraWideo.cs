using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    class GraWideo: Gra
    {
        private string platforma;
        
        public GraWideo() { }

        public GraWideo(string nazwa, double cena, string gatunek, string dataPremiery, int ograniczenieWiekowe, string platforma) 
            :base(nazwa,cena,gatunek,dataPremiery, ograniczenieWiekowe)
        {
            this.platforma = platforma;
        }

        public override string ToString()
        {
            return "nazwa: " + nazwa + ", cena: " + cena + ", gatunek: " + gatunek + ", dataPremiery: " + dataPremiery + "ograniczenie wiekowe: " + ograniczenieWiekowe
                + "+, platforma: " + platforma;
        }
    }
}
