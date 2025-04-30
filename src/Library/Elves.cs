namespace Library;

public class Elves
{
    public string Name { get; set; }
    public int Health { get; set; }
    public  Weapon Weapon { get; set; }
    public Outfit Outfit { get; set; }

    public Elves(string name, int health, Weapon weapon, Outfit outfit)
    {
        Name = name;
        Health = health;
        Weapon = weapon;
        Outfit = outfit; 
    }

    public void ChangeGun(Weapon newWeapon)
    {
        Weapon = newWeapon;
        Console.WriteLine($"Ha cambiado de {Weapon} a {newWeapon} "); //Cambio de arma
    }

    public void ChangeOutfit(Outfit new_Outfit)
    {
        Outfit = new_Outfit;
        Console.WriteLine($"El nuevo outfit del Elfo es {new_Outfit}"); //Cambio de ropa
    }

    public int GetTotalAttack()
    {
        Console.WriteLine($"El ataque realizado fue: "); //Daño del arma 
        return Weapon.AttackDamage;
    }

    public int GetTotalDefense()
    {
        Console.WriteLine($"El ataque recibido fue: "); //Armadura
        return Outfit.AttackDefense;
    }

    public void DamageCharacter(int Attack_Damage) //Daño - salud
    {
        Health -= Attack_Damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}