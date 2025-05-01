<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> 054b1551bddccbd560fd5d20d5271091588da943
using Library;

namespace App
{
    class Program
    {
<<<<<<< HEAD
        static void Main(string[] args)
        {
            Mago randalf = new Mago("Randalf", 100, 94);
            Mago recoba = new Mago ("Recoba", 100, 20);
            
            Elemento baston = new Elemento("Bastón de Poder", 10, 5);
            Elemento tunica = new Elemento("Túnica encantada", 0, 10);
            
            Elemento oraculo = new Elemento("Libro Oscuro", 15, 2);
            Elemento capa = new Elemento("Capa de sombras", 0, 8);

            randalf.Inventory.Add(baston);
            randalf.Inventory.Add(tunica);
            
=======
        static void Main(stirng[] args)
        {
            Mago randalf = new Mago ("Randalf", 100, 94);
            Mago recoba = new Mago ("Recoba", 100, 20);

            Elemento baston = new Elemento ("Baston de poder", 10, 5);
            Elemento tunica = new Element ("Tunica encantada", 0, 10);

            Elemento oraculo = new Elemento ("Libro Osucro", 15, 2);
            Elemento capa = new Elemento ("Capa de sombras", 0, 8);

            randalf.Inventory.Add(baston);
            randalf.Inventory.Add(tunica);

>>>>>>> 054b1551bddccbd560fd5d20d5271091588da943
            recoba.Inventory.Add(oraculo);
            recoba.Inventory.Add(capa);

            randalf.ShowElements();
            recoba.ShowElements();

            randalf.Attack(recoba);
            recoba.Attack(randalf);
            randalf.Attack(recoba);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 054b1551bddccbd560fd5d20d5271091588da943
