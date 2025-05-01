using Library;
namespace LibraryTests;

public class ElvesTests
{
    [Test]
    public void CrearElfo()
    {
        string nombre = "Legolas";
        int vida = 100;
        int ataque = 30;

        Elves elfo = new Elves(nombre, vida, ataque);

        Assert.That(elfo.Name, Is.EqualTo(nombre));
        Assert.That(elfo.Health, Is.EqualTo(vida));
        Assert.That(elfo.AttackPoints, Is.EqualTo(ataque));
    }

    [Test]
    public void AgregarElemento()
    {
        Elves elfo = new Elves("Legolas", 100, 30);
        Elemento arco = new Elemento("Arco", 15, 2);

        elfo.Inventory.Add(arco);

        Assert.Contains(arco, elfo.Inventory);
    }

    [Test]
    public void AttackRestaVidaCorrectamente()
    {
        Elves legolas = new Elves("Legolas", 100, 40);
        Elves thranduil = new Elves("Thranduil", 100, 20);

        Elemento arco = new Elemento("Arco Élfico", 10, 0);
        Elemento capa = new Elemento("Capa liviana", 0, 5);

        Elemento espada = new Elemento("Espada", 15, 3);
        Elemento manto = new Elemento("Manto mágico", 0, 10);

        legolas.Inventory.Add(arco);
        legolas.Inventory.Add(capa);

        thranduil.Inventory.Add(espada);
        thranduil.Inventory.Add(manto);

        legolas.Attack(thranduil);
        Assert.That(thranduil.Health, Is.EqualTo(63));
    }

    [Test]
    public void CuraPersonajeDeberiaRestaurarVida()
    {
        Elves elfo = new Elves("Legolas", 100, 40);
        elfo.Health = 30;
        elfo.HealPj();
        Assert.That(elfo.Health, Is.EqualTo(elfo.InitialHealth));
    }
}
