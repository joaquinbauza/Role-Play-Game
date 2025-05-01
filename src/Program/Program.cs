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

            Mago randalf = new Mago("Randalf", 100, 94);
            Mago recoba = new Mago ("Recoba", 100, 20);
            
            Elemento baston = new Elemento("Bastón de Poder", 10, 5);
            Elemento tunica = new Elemento("Túnica encantada", 0, 10);
            
            Elemento oraculo = new Elemento("Libro Oscuro", 15, 2);
            Elemento capa = new Elemento("Capa de sombras", 0, 8);

            randalf.Inventory.Add(baston);
            randalf.Inventory.Add(tunica);
            
            recoba.Inventory.Add(oraculo);
            recoba.Inventory.Add(capa);

            randalf.ShowElements();
            recoba.ShowElements();

            randalf.Attack(recoba);
            recoba.Attack(randalf);
            randalf.Attack(recoba);
        }
    }
}