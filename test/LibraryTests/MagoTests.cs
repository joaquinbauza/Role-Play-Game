using Library;
namespace LibraryTests;

public class MagoTests
{
    [Test]
    public void CrearMago()
    {
            // Arrange
            string nombre = "Gandalf";
            int vida = 100;
            int ataque = 20;

            // Act
            Mago mago = new Mago(nombre, vida, ataque);

            // Assert
            Assert.That(mago.Name, Is.EqualTo(nombre));
            Assert.That(mago.Health, Is.EqualTo(vida));
            Assert.That(mago.AttackPoints, Is.EqualTo(ataque));      
    }
    
    [Test]
    
    public void AgregarElemento()
    {
        // Arrange
            Mago mago = new Mago("Gandalf", 100, 20);
            Elemento elemento = new Elemento("Varita", 10, 5);

            // Act
            mago.Inventory.Add(elemento);

            // Assert
            Assert.Contains(elemento, mago.Inventory);
    }
    [Test]
    
    public void AttackRestaVidaCorrectamente()
    {
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

            randalf.Attack(recoba);
            Assert.That(recoba.Health, Is.EqualTo(6));
    }        
    
    [Test]
    public void CuraPersonajeDeberiaRestaurarVida()
    {
        Mago randalf = new Mago("Randalf", 100, 94);
        randalf.Health  = 50;
        randalf.HealPj();
        Assert.That(randalf.Health, Is.EqualTo(randalf.InitialHealth));
    }
}