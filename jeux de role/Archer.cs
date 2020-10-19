using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace jeux_de_role
{
   public class Archer : Personnage
    {
        public Archer(string nom) : base(nom)
        {
            pointsDeVie = 105;
            degatsMin = 15;
            degatsMax = 20;

        }
    }
}
