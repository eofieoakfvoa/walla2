using System.Diagnostics;

public class Scene
{
 public ConsoleColor foregroundColor;
 public ConsoleColor backgroundColor;
 public bool clearLine;
 
    public void ChangeScene<T>() where T : Scene, new()
    {
        T newscene = new();
        Console.BackgroundColor = newscene.backgroundColor;
        Console.ForegroundColor = newscene.foregroundColor;
        if (newscene.clearLine == true)
        {
            Console.Clear();
        }
    }

}

public class Menu : Scene
{
    public Menu()
    {
        foregroundColor = ConsoleColor.DarkBlue;
        backgroundColor = ConsoleColor.Black;
        clearLine = true;
        
    }
}
public class Battle : Scene
{
    public Battle()
    {
        foregroundColor = ConsoleColor.DarkBlue;
        backgroundColor = ConsoleColor.DarkGray;
        clearLine = true;
    }
}
public class DamageTaken : Scene
{
    public DamageTaken()
    {
        foregroundColor = ConsoleColor.Red;
        backgroundColor = ConsoleColor.DarkRed;
        clearLine = false;
    }
}