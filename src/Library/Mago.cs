namespace Library
{
    public class Dwarves : Personaje
    {
        public Dwarves(string nombre, int vida, int ataque)
        {
            this.Name = nombre;
            this.Health = vida;
            this.AttackPoints = ataque;
            this.InitialHealth = vida; 
        }
    }
}

