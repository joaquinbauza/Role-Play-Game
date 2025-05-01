namespace Library
{
        public class Archer : Personaje
        {
                public Archer(string nombre, int vida, int ataque)
                {
                        this.Name = nombre;
                        this.Health = vida;
                        this.AttackPoints = ataque;
                        this.InitialHealth = vida;
                }
        }        
}