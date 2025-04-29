namespace Library;

public class Gun
{
    public string Name { get; set; }
    public int Attack_Damage { get; set; }

    public Gun(string name, int attackvalue)
    {
        Name = name;
        Attack_Damage = attackvalue;
    }
}
