using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    class Pracownik:IDodajGre, IPobierzNazwy
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
            string[] nazwaGry = new string[listaGier.Count];
            for (int i = 0; i < listaGier.Count; i++)
                nazwaGry[i] = listaGier[i].nazwa;
            return nazwaGry;
        }

        public List<Gra> ZwrocListe()
        {
            return listaGier;
        }

        public void DomyslneProdukty()
        {
            listaGier.Add(new GraWideo("Wiedźmin 3: Dziki Gon", 99.99, "RPG", 18, "PC"));
            listaGier.Add(new GraWideo("Battlefield 1", 229.99, "FPS", 18, "PS4"));
            listaGier.Add(new GraWideo("Batman: Arkham Knight", 59.99, "Akcja", 18, "PC"));
        }
    }
}
