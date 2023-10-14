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

        ConsoleManager.addText(1, new string[]{"Center", "Center"});
        ConsoleManager.addText(2, new string[]{"Center", "Center"});
        ConsoleManager.addText(3, new string[]{"Center", "Center"});



        ConsoleManager.Update();
        List<int> Options = new()
        {
            0,
            1
        };

        int NextScene = InputHandler.MenuSelection("True", Options, "True");
        if (NextScene == 1)
        {
            
            tamagotchiManager.initTamagochiScene();

        }
        else
        {
            Options optionsinit = new();
            optionsinit.initOptions();
        }
        

    }
}