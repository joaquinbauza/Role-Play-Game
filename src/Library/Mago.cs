namespace Library
{
    public class Mago : Personaje
    {
        public Mago(string nombre, int vida, int ataque)
        {
            this.Name = nombre;
            this.Health = vida;
            this.AttackPoints = ataque;
            this.InitialHealth = vida;
        }

        // Hereda toda la lógica de Personaje.
    }
}