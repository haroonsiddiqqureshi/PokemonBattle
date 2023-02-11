namespace PokemonBattle.PokemonLists
{
    internal class Snorlax : Pokemon
    {
        public Snorlax()
        {
            Random random = new Random();
            this.name = "Snorlax";
            this.hp = random.Next(430, 524);
            this.attack = random.Next(202, 350);
            this.image = Properties.Resources.snorlax;
        }
    }
}
