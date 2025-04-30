namespace Library;

public class Archer
{
    public string Name { get; set; }
    public int Health { get; set; }
    public  Weapon Weapon { get; set; }
    public Armour Armour { get; set; }

    public Archer(string name, int health, Weapon weapon, Armour armour)
    {
        Name = name;
        Health = health;
        Weapon = weapon;
        Armour = armour; 
    }

    public void ChangeGun(Weapon newWeapon)
    {
        Weapon = newWeapon;
        Console.WriteLine($"Ha cambiado de {Weapon} a {newWeapon} "); //muestra el cambio de arma que se realizó
    }

    public void ChangeOutfit(Armour newArmour)
    {
        Armour = newArmour;
        Console.WriteLine($"El nuevo outfit del Arquero es {newArmour}"); //muestra el cambio de outfit que se realizó
    }

    public int GetTotalAttack()
    {
        Console.WriteLine($"El ataque realizado fue: "); //para ver cuanto daño total realizado con su arma 
        return Weapon.Attack_Damage;
    }

    public int GetTotalDefense()
    {
        Console.WriteLine($"El ataque recibido fue: "); //para ver cuanto daño defendió con su armadura
        return Armour.Attack_Defense;
    }

    public void DamageCharacter(int Attack_Damage, int Attack_Defense) // para cuando recibe el daño, ver la salud que le queda al personaje
    {
        Health -= Attack_Damage + Attack_Defense;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}

