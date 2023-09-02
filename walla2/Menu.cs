using System.Runtime.InteropServices;
using System.IO;
using System.Windows;
using System.Security.Principal;
using System.Numerics;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;
// Menu.cs ska ta text från text.txt seperata de från |, skicka till console1.cs med en funktion som tar texten och vector2, tar längden av stringen sen cuttar den i helften och tar kordinaterna - det för att senare börja därifrån

public class Menu
{
    public void initMenu()
    {

        Scene test = new();
        test.ChangeScene<MenuColors>(); 
        ConsoleManager.currentScreen = "Menu";
        //kanske göra så att loadtext() gör addtext() automatiskt så blir coden mindre?
        (string text, Vector2 location) = ConsoleManager.LoadText(1);
        (string text2, Vector2 location2) = ConsoleManager.LoadText(2);
        (string text3, Vector2 location3) = ConsoleManager.LoadText(3);
        ConsoleManager.AddText(text, location);
        ConsoleManager.AddText(text2, location2);
        ConsoleManager.AddText(text3, location3);


        ConsoleManager.Update();
        List<int> Options = new();
        //ska fixa senare
        Options.Add(0);
        Options.Add(1);
        TempHighlightText test1 = new();

        int NextScene = test1.MenuSelection("True", Options, "True");
        if (NextScene == 1)
        {
            Debug.WriteLine("GameBroken");
        }
        else
        {
            Options optionsinit = new();
            optionsinit.initOptions();
        }
        

    }
}