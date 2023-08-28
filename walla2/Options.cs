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
        List<int> Options = new();
        //ska fixa senare
        Options.Add(0);
        Options.Add(1);
        Options.Add(2);
        TempHighlightText test1 = new();

        int NextScene =test1.TextSelection("True", Options, "False");
        //Måste ändå fixa detta senare ksk en class som e hardcoded skulle iallafall se snyggare ut och va hardcoded i båda fallen HAHAHAHAHAHAHAHAHAHAHAHAHAHHAHAHAHAHAHAHAHAHAHHAHAHHAHAHAHAHAHHAHAHAHAHAHAHHAHAHAHAHAHAHAHHAHAHAHAHAHAHAHAHAHAHHAHAHAHAHAHHAHAHHAHAHAHAHHAHAHAHAHHAHAHAHAHAHHAHAHAHAHAH
        if (NextScene == 1)
        {
            Debug.WriteLine("Border");
        }
        else if (NextScene == 2)
        {
            Debug.WriteLine("Resolution");
        }
        else if (NextScene == 3)
        {
            Debug.WriteLine("Exit");
        }
        

    }
}