using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    class Klient:IKoszyk
    {
        private List<Gra> koszyk;


        public Klient()
        {
            koszyk = new List<Gra>();
        }

        public void DodajGreWideoKoszyk(string nazwa, double cena, string gatunek, int ograniczenieWiekowe, string platforma)
        {
            koszyk.Add(new GraWideo(nazwa, cena, gatunek,ograniczenieWiekowe, platforma));
        }

        public void DodajGrePlanszowaKoszyk(string nazwa, double cena, string gatunek,  int ograniczenieWiekowe, int minimumOsob, int maximumOsob)
        {
            koszyk.Add(new GraPlanszowa(nazwa, cena, gatunek, ograniczenieWiekowe, minimumOsob, maximumOsob));
        }

        public void UsunOstatniKoszyk()
        {
            koszyk.Remove(koszyk.Last());
        }

        public void WyczyscKoszyk()
        {
            koszyk.Clear();
        }
    }
}
