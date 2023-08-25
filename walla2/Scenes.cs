using System.Diagnostics;

public class Scene
{
 public ConsoleColor foregroundColor;
 public ConsoleColor backgroundColor;
 private bool ClearLine;
    public void ChangeScene<T>() where T : Scene, new()
    {
        T newscene = new();
        Console.BackgroundColor = newscene.backgroundColor;
        Console.ForegroundColor = newscene.foregroundColor;
    }

}

public class Menu : Scene
{
    public Menu()
    {
        foregroundColor = ConsoleColor.Black;
        backgroundColor = ConsoleColor.DarkBlue;
        
    }
}
public class Battle : Scene
{
    public Battle()
    {
        foregroundColor = ConsoleColor.White;
        backgroundColor = ConsoleColor.DarkBlue;
    }
}