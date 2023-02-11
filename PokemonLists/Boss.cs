namespace PokemonBattle.PokemonLists
{
    internal class Boss : Pokemon
    {
        public Boss()
        {
            Random random = new Random();
            this.name = "Boss";
            this.hp = random.Next(1000, 2500);
            this.attack = random.Next(85, 167);
            this.image = Properties.Resources.Boss;
        }
    }
}
