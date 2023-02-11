using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.PokemonLists
{
    internal class Charmander :Pokemon
    {
        public Charmander()
        {
            Random random = new Random();
            this.name = "Charmander";
            this.hp = random.Next(188, 282);
            this.attack = random.Next(98, 223);
            this.image = Properties.Resources.charmander;
        }
    }
}
