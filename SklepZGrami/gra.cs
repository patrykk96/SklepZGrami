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
        protected string producent;
        protected string wydawca;
        protected string gatunek;
        protected string dataPremiery;
        protected int ograniczenieWiekowe;

        public Gra() { }

        public Gra(string nazwa, double cena, string producent, string wydawca, string gatunek, string dataPremiery, int ograniczenieWiekowe)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.producent = producent;
            this.wydawca = wydawca;
            this.gatunek = gatunek;
            this.dataPremiery = dataPremiery;
            this.ograniczenieWiekowe = ograniczenieWiekowe;
        }

    }
}
