using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    interface IDodajGre
    {
        void DodajGreWideo(string nazwa, double cena, string gatunek, string dataPremiery, int ograniczenieWiekowe, string platforma);
        void DodajGrePlanszowa(string nazwa, double cena, string gatunek, string dataPremiery, int ograniczenieWiekowe, int minimumOsob, int maximumOsob, double waga);
    }
}
