using Library;
namespace LibraryTests;

public class ArcherTests
{
    [Test]
    public void CrearArquero()
    {
        string nombre = "Robin";
        int vida = 90;
        int ataque = 60;

        Archer arquero = new Archer(nombre, vida, ataque);

        Assert.That(arquero.Name, Is.EqualTo(nombre));
        Assert.That(arquero.Health, Is.EqualTo(vida));
        Assert.That(arquero.AttackPoints, Is.EqualTo(ataque));
    }

    [Test]
    public void AgregarElemento()
    {
        Archer arquero = new Archer("Robin", 90, 60);
        Elemento arco = new Elemento("Arco largo", 18, 2);

        arquero.Inventory.Add(arco);

        Assert.Contains(arco, arquero.Inventory);
    }

    [Test]
    public void AttackRestaVidaCorrectamente()
    {
        Archer robin = new Archer("Robin", 90, 60);
        Archer marian = new Archer("Marian", 90, 40);

        Elemento arco = new Elemento("Arco largo", 12, 0);
        Elemento chaleco = new Elemento("Chaleco de cuero", 0, 5);

        Elemento ballesta = new Elemento("Ballesta", 10, 1);
        Elemento botas = new Elemento("Botas ágiles", 0, 6);

        robin.Inventory.Add(arco);
        robin.Inventory.Add(chaleco);

        marian.Inventory.Add(ballesta);
        marian.Inventory.Add(botas);

        robin.Attack(marian);
        Assert.That(marian.Health, Is.EqualTo(25));
    }

    [Test]
    public void CuraPersonajeDeberiaRestaurarVida()
    {
        Archer arquero = new Archer("Robin", 90, 60);
        arquero.Health = 40;
        arquero.HealPj();
        Assert.That(arquero.Health, Is.EqualTo(arquero.InitialHealth));
    }
}