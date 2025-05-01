namespace Library;

<<<<<<< HEAD

public class Elemento: IElemento 
{
    
=======
public class Elemento: IElemento
{
>>>>>>> 054b1551bddccbd560fd5d20d5271091588da943
    public string Name {get; private set;}
    public int Attack {get; private set;}
    public int Armor {get; private set;}

    public Elemento (string nombre, int ataque, int armadura)
    {
        this.Name = nombre;
        this.Attack = ataque;
        this.Armor = armadura;
    }
}