using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    class Pracownik:IDodajGre
    {
        private List<Gra> listaGier;

        public Pracownik()
        {
            listaGier = new List<Gra>();
        }

        public void DodajGreWideo(string nazwa, double cena, string gatunek, int ograniczenieWiekowe, string platforma)
        {
            listaGier.Add(new GraWideo(nazwa, cena, gatunek, ograniczenieWiekowe, platforma));
        }

        public void DodajGrePlanszowa(string nazwa, double cena, string gatunek, int ograniczenieWiekowe, int minimumOsob, int maximumOsob)
        {
            listaGier.Add(new GraPlanszowa(nazwa, cena, gatunek, ograniczenieWiekowe, minimumOsob, maximumOsob));
        }

        public void UsunOstatniDodany()
        {
            listaGier.Remove(listaGier.Last());
        }

        public IEnumerable<string> PobierzNazwy()
        {
            string[] nazwyGier = new string[listaGier.Count];
            for (int i = 0; i < listaGier.Count; i++)
                nazwyGier[i] = listaGier[i].nazwa;
            return nazwyGier;
        }
    }
}
