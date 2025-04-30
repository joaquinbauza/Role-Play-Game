using System.Reflection.PortableExecutable;

namespace Library;

public class Archer : Personaje
{
    public Archer(string name, int health, int attack)
    {
        this.Name = name;
        this.Health = health;
        this.AttackDamage = attack;
        this.InitialHealth = health;
    }
}

