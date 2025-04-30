namespace Library;

public class Archer
{
    public string Name { get; set; }
    public int Health { get; set; }
    public  Weapon Weapon { get; set; }
    public Outfit outfit { get; set; }

    public Archer(string name, int health, Weapon weapon, Outfit outfit)
    {
        Name = name;
        Health = health;
        weapon = weapon;
        outfit = outfit; 
    }

    public void ChangeGun(Weapon newWeapon)
    {
        Weapon = newWeapon;
        Console.WriteLine($"Ha cambiado de {Weapon} a {newWeapon} "); //muestra el cambio de arma que se realizó
    }

    public void ChangeOutfit(Outfit new_Outfit)
    {
        outfit = new_Outfit;
        Console.WriteLine($"El nuevo outfit del Arquero es {new_Outfit}"); //muestra el cambio de outfit que se realizó
    }

    public int GetTotalAttack()
    {
        Console.WriteLine($"El ataque realizado fue: "); //para ver cuanto daño total realizado con su arma 
        return Weapon.Attack_Damage;
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

