namespace LibraryTests;
using Library;

public class Tests
{
    public Archer archer1;
    public Archer archer2;
    [SetUp]
    public void Setup()
    {
        Weapon weapon1 = new Weapon("Arco", 10);
        Armour outfit1 = new Armour("Capa", 5);
        Archer archer1 = new Archer("jota", 100, weapon1, outfit1);

        Weapon weapon2 = new Weapon("Ballesta", 7);
        Armour outfit2 = new Armour("Traje", 10);
        Archer archer2 = new Archer("bolso gallina", 70, weapon2, outfit2);
    }

    [Test]
    public void TestGetTotalAttack() //para ver si me devuelve los dos lo mismo, que seria lo esperado, de lado izquierdo lo que se espera, derecha lo que devuelve
    {
        Assert.AreEqual(100,archer1.GetTotalAttack());
    }

    public void TestGetTotalDefense()
    {
        Assert.AreEqual(5,archer1.GetTotalDefense());
    }
}