namespace Library;

public class Archer
{
    public string Name { get; set; }
    public int Life { get; set; }
    public  Gun gun { get; set; }
    public Outfit outfit { get; set; }

    public Archer(string name, int life, Gun gun, Outfit outfit)
    {
        Name = name;
        Life = life;
        gun = gun;
        outfit = outfit; 
    }

    public void ChangeGun(Gun new_gun)
    {
        gun = new_gun;
        Console.WriteLine($"Ha cambiado de {gun} a {new_gun} ");
    }

    public void ChangeOutfit(Outfit new_Outfit)
    {
        outfit = new_Outfit;
        Console.WriteLine($"El nuevo outfit del Arquero es {new_Outfit}");
    }
}

