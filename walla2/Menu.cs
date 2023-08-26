using System.Runtime.InteropServices;
using System.IO;
using System.Windows;
using System.Security.Principal;
using System.Numerics;
// Menu.cs ska ta text från text.txt seperata de från |, skicka till console1.cs med en funktion som tar texten och vector2, tar längden av stringen sen cuttar den i helften och tar kordinaterna - det för att senare börja därifrån

public class Menu
{
    public void initMenu()
    {
        Scene test = new();
        //test.ChangeScene<MenuColors>(); 
        string text1 = File.ReadLines(@"text.txt").ElementAtOrDefault(1);
        string[] text1split = text1.Split("|");
        Vector2 text1vector = new Vector2(int.Parse(text1split[1]), int.Parse(text1split[2]));
        Console1 consoletest = new();
        consoletest.AddText(text1split[0], text1vector);
        consoletest.Update();
        
        
    }
}