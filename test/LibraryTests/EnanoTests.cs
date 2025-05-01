using Library;
namespace LibraryTests;

public class EnanoTests
{
    [Test]
    public void CrearEnano()
    {
        string nombre = "Thorin";
        int vida = 120;
        int ataque = 50;

        Enano enano = new Enano(nombre, vida, ataque);

        Assert.That(enano.Name, Is.EqualTo(nombre));
        Assert.That(enano.Health, Is.EqualTo(vida));
        Assert.That(enano.AttackPoints, Is.EqualTo(ataque));
    }

    [Test]
    public void AgregarElemento()
    {
        Enano enano = new Enano("Thorin", 120, 50);
        Elemento hacha = new Elemento("Hacha", 20, 5);

        enano.Inventory.Add(hacha);

        Assert.Contains(hacha, enano.Inventory);
    }

    [Test]
    public void AttackRestaVidaCorrectamente()
    {
        Enano thorin = new Enano("Thorin", 120, 50);
        Enano balin = new Enano("Balin", 100, 30);

        Elemento hacha = new Elemento("Hacha de guerra", 15, 0);
        Elemento escudo = new Elemento("Escudo pesado", 0, 10);

        Elemento lanza = new Elemento("Lanza", 10, 2);
        Elemento armadura = new Elemento("Armadura enana", 0, 12);

        thorin.Inventory.Add(hacha);
        thorin.Inventory.Add(escudo);

        balin.Inventory.Add(lanza);
        balin.Inventory.Add(armadura);

        thorin.Attack(balin);
        Assert.That(balin.Health, Is.EqualTo(49));
    }

    [Test]
    public void CuraPersonajeDeberiaRestaurarVida()
    {
        Enano enano = new Enano("Thorin", 120, 50);
        enano.Health = 80;
        enano.HealPj();
        Assert.That(enano.Health, Is.EqualTo(enano.InitialHealth));
    }
}