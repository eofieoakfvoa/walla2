using System.Runtime.InteropServices;
using System.IO;
using System.Windows;
using System.Security.Principal;
// Menu.cs ska ta text från text.txt seperata de från |, skicka till console1.cs med en funktion som tar texten och vector2, tar längden av stringen sen cuttar den i helften och tar kordinaterna - det för att senare börja därifrån

public class Menu
{
    public void initMenu()
    {
        Scene test = new();
        //test.ChangeScene<MenuColors>(); 
        string textFromFile = File.ReadLines(@"text.txt").ElementAtOrDefault(0);
        System.Console.WriteLine(textFromFile);
        
    }
}