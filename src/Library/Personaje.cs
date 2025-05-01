using System;
using System.Collections.Generic;

namespace Library;

public abstract class Personaje: IPersonaje
{
    public string Name {get; set;}
    public int Health {get; set;}
    public int InitialHealth { get; set; }
    public int AttackPoints { get; set; }

    public List<IElemento> Inventory {get; set;} = new List<IElemento>();

    public virtual int GetTotalAtack()
    {
        int total = this.AttackPoints;
        foreach (var item in Inventory)
                total += item.Attack;
            return total;

    }
    public virtual int GetTotalArmor()
    {
        int total = 0;
        foreach (var item in Inventory)
                total += item.Armor;
            return total;

    }
    public virtual string HealPj()
    {
        this.Health = this.InitialHealth;
        return $"{this.Name} ha sido curado a su salud inicial.";
    }

    public virtual void ShowElements()
    {
        Console.WriteLine($"Elementos de {Name}:");
            foreach (var item in Inventory)
                Console.WriteLine($"- {item.Name} | Ataque: {item.Attack} | Armadura: {item.Armor}");
            Console.WriteLine("--------------------");
    }
    public virtual void Attack(IPersonaje personaje)
    {
        int Damage = this.GetTotalAtack() - personaje.GetTotalArmor();
        if(Damage < 0 ) Damage = 0;
        personaje.Health -= Damage;
        if(personaje.Health <= 0)
        {
            personaje.Health = 0;
            Console.WriteLine($"{personaje.Name} fue asesinado por {this.Name} ");
        }
        else
        {
            Console.WriteLine($"{this.Name} le quito {Damage} a {personaje.Name}");
        }
    }

}
<<<<<<< HEAD

=======
>>>>>>> 054b1551bddccbd560fd5d20d5271091588da943
