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

        public GraWideo(string nazwa, double cena, string producent, string wydawca, string gatunek, string dataPremiery, int ograniczenieWiekowe, string platforma) 
            :base(nazwa,cena,producent,wydawca,gatunek,dataPremiery, ograniczenieWiekowe)
        {
            this.platforma = platforma;
        }
    }
}
