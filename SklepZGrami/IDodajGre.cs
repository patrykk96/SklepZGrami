using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGrami
{
    interface IDodajGre
    {
        void DodajGreWideo(string nazwa, double cena, string gatunek, int ograniczenieWiekowe, string platforma);
        void DodajGrePlanszowa(string nazwa, double cena, string gatunek, int ograniczenieWiekowe, int minimumOsob, int maximumOsob);
    }
}
