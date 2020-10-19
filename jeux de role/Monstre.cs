using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux_de_role
{
    public class Monstre : Entite
    {
        public Monstre(string nom) : base(nom)
        {
            pointsDeVie = 60;
            degatsMin = 5;
            degatsMax = 10;
        }
    }
}
