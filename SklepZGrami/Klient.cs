using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    class Klient: IPobierzNazwy
    {
        private List<Gra> koszyk;
        private List<Gra> listaProduktów;

        public Klient()
        {
            koszyk = new List<Gra>();
            listaProduktów = new List<Gra>();
        }

      

        public IEnumerable<string> PobierzNazwy()
        {
            string[] nazwaGry = new string[listaProduktów.Count];
            for (int i = 0; i < listaProduktów.Count; i++)
                nazwaGry[i] = listaProduktów[i].nazwa;
            return nazwaGry;
        }

        public IEnumerable<string> PobierzNazwyDoKoszyka()
        {
            string[] nazwaGry = new string[koszyk.Count];
            for (int i = 0; i < koszyk.Count; i++)
                nazwaGry[i] = koszyk[i].nazwa;
            return nazwaGry;
        }

        public IEnumerable<double> PobierzCenyDoKoszyka()
        {
            double[] cenaGry = new double[koszyk.Count];
            for (int i = 0; i < koszyk.Count; i++)
                cenaGry[i] = koszyk[i].cena;
            return cenaGry;
        }

        public Gra GraDoPrzeniesienia(int indeks)
        {
            Gra GraDoZamiany = listaProduktów[indeks];
            return GraDoZamiany;
        }

        public Gra GraDoUsuniecia(int indeks)
        {
            Gra GraDoUsuniecia = koszyk[indeks];
            return GraDoUsuniecia;
        }

        public void KopiowanieListyGier(List<Gra> lista)
        {
            listaProduktów = lista;
        }

        public int PoliczProdukty()
        {
            return listaProduktów.Count;
        }

        public int PoliczIloscWKoszyku()
        {
            return koszyk.Count();
        }

        public void DodajDoKoszyka(Gra GraDoKoszyka)
        {
            koszyk.Add(GraDoKoszyka);
        }

        public void UsunZKoszyka(Gra GraZKoszyka)
        {
            koszyk.Remove(GraZKoszyka);
        }

        public string Informacje(int indeks)
        {
            return listaProduktów[indeks].ToString();
        }

        public void WyczyscListeKoszyk()
        {
            koszyk.Clear();
        }
       
    }
}
