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
        protected int cena;
        protected string producent;
        protected string wydawca;
        protected string gatunek;
        protected string dataPremiery;

        public Gra() { }

        public Gra(string nazwa, int cena, string producent, string wydawca, string gatunek, string dataPremiery)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.producent = producent;
            this.wydawca = wydawca;
            this.gatunek = gatunek;
            this.dataPremiery = dataPremiery;
        }

    }
}
