namespace Library;

public class Armour
{
    public string Name { get; set; }
    public int Attack_Defense { get; set; }

    public Armour(string name, int attackDefense_value)
    {
        Name = name;
        Attack_Defense = attackDefense_value;
    }
}