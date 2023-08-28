using System.Diagnostics;
using System.Numerics;
public class Options
{
    public void initOptions()
    {

        Scene test = new();
        test.ChangeScene<MenuColors>(); 
        ConsoleManager.currentScreen = "Options";
        (string text, Vector2 location) = ConsoleManager.LoadText(1);
        (string text2, Vector2 location2) = ConsoleManager.LoadText(6);
        (string text3, Vector2 location3) = ConsoleManager.LoadText(7);
        (string text4, Vector2 location4) = ConsoleManager.LoadText(8);
        ConsoleManager.AddText(text, location);
        ConsoleManager.AddText(text2, location2);
        ConsoleManager.AddText(text3, location3);
        ConsoleManager.AddText(text4, location4);


        ConsoleManager.Update();
        int selectedOption = 1;
        while (Console.ReadKey().Key == ConsoleKey.DownArrow) 
        {
            if (selectedOption == 1)
            {
                selectedOption ++;
            }
            else{
                selectedOption --;
            }
        }
        while (Console.ReadKey().Key == ConsoleKey.UpArrow) 
        {
            if (selectedOption == 3)
            {
                selectedOption --;
            }
            else{
                selectedOption ++;
            }
        }
        while (Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            if (selectedOption == 1)
            {
                selectedOption ++;
            }
            else
            {
                Options optionsinit = new();
                optionsinit.initOptions();
            }
        }

    }
}