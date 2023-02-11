using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class Pokemon
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public Bitmap image { get; set; }
        public string getName() { return name; }
        public int getHp() { return hp; }
        public int getAttack() { return attack; }
        public Bitmap getImage() { return image; }

        public void takeDamage(int damage) 
        {
            this.hp = this.hp - damage;
        }
    }
}
