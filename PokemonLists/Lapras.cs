using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.PokemonLists
{
    internal class Lapras :Pokemon
    {
        public Lapras() 
        { 
            Random random= new Random();
            this.name = "Lapras";
            this.hp = random.Next(370, 464);
            this.attack = random.Next(157, 295);
            this.image = Properties.Resources.lapras;
        }
    }
}
