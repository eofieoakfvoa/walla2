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
        test.ChangeScene<MenuColors>(); 
        string text1 = File.ReadLines(@"text.txt").ElementAtOrDefault(1);
        string[] text1split = text1.Split("|");
        Vector2 text1vector = new Vector2(int.Parse(text1split[1]), int.Parse(text1split[2]));  
        Console1.AddText(text1split[0], text1vector);
        string text2 = File.ReadLines(@"text.txt").ElementAtOrDefault(2);
        string[] text2split = text2.Split("|");
        Vector2 text2vector = new Vector2(int.Parse(text2split[1]), int.Parse(text2split[2]));  
        Console1.AddText(text1split[0], text1vector);
        string text3 = File.ReadLines(@"text.txt").ElementAtOrDefault(3);
        string[] text3split = text3.Split("|");
        Vector2 text3vector = new Vector2(int.Parse(text3split[1]), int.Parse(text3split[2]));  
        Console1.AddText(text1split[0], text1vector);
        Console1.AddText(text2split[0], text2vector);
        Console1.AddText(text3split[0], text3vector);
        Console1.Update();
    }
}