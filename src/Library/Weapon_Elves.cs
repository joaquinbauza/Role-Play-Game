namespace Library;

public class Weapon
{
    public string Name { get; set; }
    public int AttackDamage { get; set; }

    public Weapon(string name, int attackvalue)
    {
        Name = name;
        AttackDamage = attackvalue;
    }
}