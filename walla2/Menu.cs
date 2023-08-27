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
        
        //kanske göra så att loadtext() gör addtext() automatiskt så blir coden mindre?
        (string text, Vector2 location) = Console1.LoadText(1);
        (string text2, Vector2 location2) = Console1.LoadText(2);
        (string text3, Vector2 location3) = Console1.LoadText(3);
        Console1.AddText(text, location);
        Console1.AddText(text2, location2);
        Console1.AddText(text3, location3);


        Console1.Update();

        while (Console.ReadKey().Key == ConsoleKey.DownArrow) 
        {
            
        }
        while (Console.ReadKey().Key == ConsoleKey.UpArrow) 
        {
                
        }
        while (Console.ReadKey().Key == ConsoleKey.Enter) 
        {
                
        }


    }
}