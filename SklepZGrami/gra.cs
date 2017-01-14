using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    class Gra
    {
        protected string nazwa;
        protected double cena;
        protected string gatunek;
        protected string dataPremiery;
        protected int ograniczenieWiekowe;

        public Gra() { }

        public Gra(string nazwa, double cena, string gatunek, string dataPremiery, int ograniczenieWiekowe)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.gatunek = gatunek;
            this.dataPremiery = dataPremiery;
            this.ograniczenieWiekowe = ograniczenieWiekowe;
        }

    }
}
