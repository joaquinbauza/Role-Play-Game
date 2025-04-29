namespace LibraryTests;
using Library;

public class Tests
{
    public Archer archer1;
    public Archer archer2;
    [SetUp]
    public void Setup()
    {
        Gun gun1 = new Gun("Arco", 10);
        Outfit outfit1 = new Outfit("Capa", 5);
        Archer archer1 = new Archer("jota", 100, gun1, outfit1);

        Gun gun2 = new Gun("Ballesta", 7);
        Outfit outfit2 = new Outfit("Traje", 10);
        Archer archer2 = new Archer("bolso gallina", 70, gun2, outfit2);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}