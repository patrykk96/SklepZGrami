using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    interface IKoszyk
    {
        void DodajGreWideoKoszyk(string nazwa, double cena, string gatunek, int ograniczenieWiekowe, string platforma);
        void DodajGrePlanszowaKoszyk(string nazwa, double cena, string gatunek, int ograniczenieWiekowe, int minimumOsob, int maximumOsob);
        void UsunOstatniKoszyk();
        void WyczyscKoszyk();
    }
}
