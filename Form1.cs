using PokemonBattle.PokemonLists;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {
        public List<Pokemon> Pokemons = new List<Pokemon>();
        Pokemon selectPokemon;
        Pokemon selectBoss;
        int selected;
        int heart = 4;
        int emheart = 1;
        public Form1()
        {
            InitializeComponent();
            Pokemons.Add(new Pikachu());
            Pokemons.Add(new Charmander());
            Pokemons.Add(new Lapras());
            Pokemons.Add(new Snorlax());
            selectBoss = new Boss();
            this.PictureBoss.Image = selectBoss.getImage();
            this.EMname.Text = "Pichai_dubai";
            this.EMattack.Text = selectBoss.getAttack().ToString();
            this.EMhp.Text = selectBoss.getHp().ToString();
        }
        private void First_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[0];
            this.ALpicture.Image = selectPokemon.getImage();
            this.ALname.Text = selectPokemon.getName();
            this.ALhp.Text = selectPokemon.getHp().ToString();
            this.ALattack.Text = selectPokemon.getAttack().ToString();
            this.selected = 1;
        }

        private void Second_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[1];
            this.ALpicture.Image = selectPokemon.getImage();
            this.ALname.Text = selectPokemon.getName();
            this.ALhp.Text = selectPokemon.getHp().ToString();
            this.ALattack.Text = selectPokemon.getAttack().ToString();
            this.selected = 2;
        }

        private void Third_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[2];
            this.ALpicture.Image = selectPokemon.getImage();
            this.ALname.Text = selectPokemon.getName();
            this.ALhp.Text = selectPokemon.getHp().ToString();
            this.ALattack.Text = selectPokemon.getAttack().ToString();
            this.selected = 3;
        }

        private void Fourth_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[3];
            this.ALpicture.Image = selectPokemon.getImage();
            this.ALname.Text = selectPokemon.getName();
            this.ALhp.Text = selectPokemon.getHp().ToString();
            this.ALattack.Text = selectPokemon.getAttack().ToString();
            this.selected = 4;
        }
        private async void Attack(object sender, EventArgs e)
        {
            selectBoss.takeDamage(selectPokemon.getAttack());
            this.EMhp.Text = selectBoss.getHp().ToString();
            await Task.Delay(500);
            selectPokemon.takeDamage(selectBoss.getAttack());
            if (selectPokemon.getHp() <= 0)
            {
                if (selected == 1)
                {
                    this.First.Hide();
                }
                if (selected == 2)
                {
                    this.Second.Hide();
                }
                if (selected == 3)
                {
                    this.Third.Hide();
                }
                if (selected == 4)
                {
                    this.Fourth.Hide();
                }
                this.ALpicture.Image = null;
                this.ALname.Text = null;
                this.ALhp.Text = null;
                this.ALattack.Text = null;
                this.heart -= 1;
                if (heart == 0)
                {
                    MessageBox.Show("You Lose!\nGame Over");
                }
                return;
            }
            if (selectBoss.getHp() <= 0)
            {
                this.PictureBoss.Image = null;
                this.EMname.Text = null;
                this.EMhp.Text = null;
                this.EMattack.Text = null;
                this.emheart-= 1;
                if (emheart == 0)
                {
                    MessageBox.Show("You Win!");
                }
            }
            this.ALhp.Text = selectPokemon.getHp().ToString();
        }
    }
}