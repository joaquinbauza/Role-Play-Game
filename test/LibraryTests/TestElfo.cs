namespace LibraryTests;
using Library;

public class Tests
{
    public Elves elfo1;
    public Elves elfo2;
    [SetUp]
    public void Setup()
    {
        Weapon weapon1 = new Weapon("Daga", 5);
        Outfit outfit1 = new Outfit("Pechera", 7);
        Elves elfo1 = new Elves("Christian", 100, weapon1, outfit1);

        Weapon weapon2 = new Weapon("Espada", 10);
        Outfit outfit2 = new Outfit("Armadura", 12);
        Elves elfo2 = new Elves("Daniel", 70, weapon2, outfit2);
    }

    [Test]
    public void TestGetTotalAttack() //para ver si me devuelve los dos lo mismo, que seria lo esperado, de lado izquierdo lo que se espera, derecha lo que devuelve
    {
        Assert.AreEqual(100,elfo1.GetTotalAttack());
    }

    public void TestGetTotalDefense()
    {
        Assert.AreEqual(5,elfo2.GetTotalDefense());
    }
}