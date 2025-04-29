namespace Library;

public class Outfit
{
    public string Name { get; set; }
    public int Attack_Defense { get; set; }

    public Outfit(string name, int attackDefense_value)
    {
        Name = name;
        Attack_Defense = attackDefense_value;
    }
}