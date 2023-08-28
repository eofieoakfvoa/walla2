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
            Debug.WriteLine("Hi");
            changeBorder();
            ConsoleManager.Update();
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
    public void changeBorder()
    {
        //save fil som den tar current border ifrån (som en integer border[0] skulle va 0 t.ex), tar nästa i stringen
        string border = "■▒i";
        for (int X = 0; X < ConsoleManager.maxX; X++)
        {
            for (int Y = 0; Y < ConsoleManager.maxY; Y++)
            {
                if (X == 0 || Y == 0 || X+1 == ConsoleManager.maxX || Y+1 == ConsoleManager.maxY)
                {
                    ConsoleManager.Grid[new Vector2(X,Y)] = "▒";    
                }
            }
        }
    }
    public void ChangeResolution()
    {
        string border = "■▒i";
    }
}