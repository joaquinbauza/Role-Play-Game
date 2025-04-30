namespace Library;

public class Outfit
{
    public string Name { get; set; }
    public int AttackDefense { get; set; }

    public Outfit(string name, int attackDefense_value)
    {
        Name = name;
        AttackDefense = attackDefense_value;
    }
}