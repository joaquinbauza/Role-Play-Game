namespace Library;

public class Archer
{
    public string Name { get; set; }
    public int Health { get; set; }
    public  Gun gun { get; set; }
    public Outfit outfit { get; set; }

    public Archer(string name, int health, Gun gun, Outfit outfit)
    {
        Name = name;
        Health = health;
        gun = gun;
        outfit = outfit; 
    }

    public void ChangeGun(Gun new_gun)
    {
        gun = new_gun;
        Console.WriteLine($"Ha cambiado de {gun} a {new_gun} "); //muestra el cambio de arma que se realizó
    }

    public void ChangeOutfit(Outfit new_Outfit)
    {
        outfit = new_Outfit;
        Console.WriteLine($"El nuevo outfit del Arquero es {new_Outfit}"); //muestra el cambio de outfit que se realizó
    }

    public int GetTotalAttack()
    {
        Console.WriteLine($"El ataque realizado fue: "); //para ver cuanto daño total realizado con su arma 
        return gun.Attack_Damage;
    }

    public int GetTotalDefense()
    {
        Console.WriteLine($"El ataque recibido fue: "); //para ver cuanto daño defendió con su armadura
        return outfit.Attack_Defense;
    }

    public void DamageCharacter(int Attack_Damage) // para cuando recibe el daño, ver la salud que le queda al personaje
    {
        Health -= Attack_Damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}

