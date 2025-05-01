namespace Library
{
        public class Enano : Personaje
        {
                public Enano(string nombre, int vida, int ataque)
                {
                        this.Name = nombre;
                        this.Health = vida;
                        this.AttackPoints = ataque;
                        this.InitialHealth = vida;
                }
        }        
}