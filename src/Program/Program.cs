using System;
 using System.Linq.Expressions;
 using Library;

 namespace App
 {
     class Program
     {
         static void Main(string[] args)
         {
             Dwarves Franibanez = new Dwarves("Franibanez", 10, 15);
             Dwarves FerScoco = new Dwarves("FerScoco", 100, 80);

             Elemento MazoDeCartas = new Elemento("MazoDeCartas", 10, 5);
             Elemento BuzoDeLana = new Elemento("BuzoDeLana", 0, 10);
             
             Elemento VaritaDeSauco = new Elemento("VaritaDeSauco", 100, 5);
             Elemento CapaDeInvisibilidad = new Elemento("CapaDeInvisibilidad", 0, 100);

             Franibanez.Inventory.Add(MazoDeCartas);
             Franibanez.Inventory.Add(BuzoDeLana);

             FerScoco.Inventory.Add(VaritaDeSauco);
             FerScoco.Inventory.Add(CapaDeInvisibilidad);

             Franibanez.ShowElements();
             FerScoco.ShowElements();

             FerScoco.Attack(Franibanez);
             Franibanez.Attack(FerScoco);
             FerScoco.Attack(Franibanez);

        }
    }
}
