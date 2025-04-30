using System;
using Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Elves Daniel = new Elves("Daniel", 100, 70);
            Elves Manuel = new Elves("Manuel", 120, 30);
            
            Elemento Daga = new Elemento("Daga", 10, 0);
            Elemento Pechera = new Elemento("Pechera", 0, 15);
            
            Elemento Espada = new Elemento("Espada", 15, 2);
            Elemento Ropa = new Elemento("Ropa", 0, 8);

            Daniel.Inventory.Add(Daga);
            Daniel.Inventory.Add(Pechera);
            
            Manuel.Inventory.Add(Espada);
            Manuel.Inventory.Add(Ropa);

            Daniel.ShowElements();
            Manuel.ShowElements();

            Daniel.Attack(Manuel);
            Manuel.Attack(Daniel);
            Daniel.Attack(Manuel);
        }
    }
}