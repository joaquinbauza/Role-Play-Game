namespace Library
{
        public class Elves : Personaje
        {
                public Elves(string nombre, int vida, int ataque)
                {
                        this.Name = nombre;
                        this.Health = vida;
                        this.AttackPoints = ataque;
                        this.InitialHealth = vida;
                }
        }        
}
