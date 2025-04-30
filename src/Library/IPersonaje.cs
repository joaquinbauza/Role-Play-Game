namespace Library;

public interface IPersonaje
{
    string Name { get; set; }
    int Health { get; set;} 
    int InitialHealth { get; set; }
    int AttackPoints { get; set; }
    
    int GetTotalArmor();
    int GetTotalAtack();
    string HealPj();
    void ShowElements();
    void Attack(IPersonaje personaje);

}