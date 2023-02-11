using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.PokemonLists
{
    internal class Pikachu :Pokemon
    {
        public Pikachu()
        {
            Random random = new Random();
            this.name = "Pikachu";
            this.hp = random.Next(180, 274);
            this.attack = random.Next(103, 229);
            this.image = Properties.Resources.pikachu;
        }
    }
}
