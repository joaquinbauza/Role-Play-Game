namespace Library;

public class Weapon
{
    public string Name { get; set; }
    public int Attack_Damage { get; set; }

    public Weapon(string name, int attackvalue)
    {
        Name = name;
        Attack_Damage = attackvalue;
    }
}
