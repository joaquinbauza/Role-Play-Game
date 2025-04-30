using System; 
using Library;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Archer jota = new Archer("jota", 120, 30);
            Archer baez = new Archer("baez", 120, 30);

            Elemento arco = new Elemento("Arco", 15, 5);
            Elemento capa = new Elemento("Capa", 0, 15);

            Elemento arco_encantado = new Elemento("Arco encantado", 20, 10);
            Elemento tunica = new Elemento("Tunica", 0, 10);

            jota.Inventory.Add(arco);
            jota.Inventory.Add(capa);

            baez.Inventory.Add(arco_encantado);
            baez.Inventory.Add(tunica);

            jota.ShowElements();
            baez.ShowElements();

            jota.Attack(baez);
            baez.Attack(jota);
            jota.Attack(baez);
        }
    }
}