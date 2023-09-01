//gör så den ritar ut från en dictionary ksk så att key vector2 t.ex 1,2 ska va ett i, kanske gör det lättare i framtiden?
//▒ ser ut som bricks typ ■ pixel nästan? □, https://en.wikipedia.org/wiki/Geometric_Shapes_(Unicode_block)

using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Numerics;

public static class ConsoleManager
{
    //ändra 1920, 1080 till en sak som faktiskt fungerar på alla skärmar
    static float rowtopixelWidth = 1920 / Console.LargestWindowWidth;
    static float rowtopixelHeight = 1080 / Console.LargestWindowHeight;
    public static Dictionary<Vector2, string> Grid = new();
    public static int maxY = 0;
    public static int maxX = 0;
    public static string currentScreen = "Console";
    


    public static int Width
    {
        get
        {
            return Console.WindowWidth;
        }
        set
        {
            if (value < maxX)
            {

                Console.WindowWidth = value;
            }
        }
    }

    public static void InitConsole()
    {
        //console använder rows, columns istället för pixlar därför behöver converta, pixelwidth/height inte perfekt men fungerar typ
        int windowsPixelWidth = 512;
        //--för någon anledning är max 1071 på en 1080 skärm?,,,,, 512 / 400
        int windowsPixelHeight = 400;
        int windowsWidth = (int)MathF.Floor(windowsPixelWidth / rowtopixelWidth);
        int windowsHeight = (int)MathF.Floor(windowsPixelHeight / rowtopixelHeight);
        Console.SetWindowSize(windowsWidth, windowsHeight);
        //skapar en grid där allting är tomt by default.
        for (int x = 0; x < windowsWidth; x++)
        {
            for (int y = 0; y < windowsHeight; y++)
            {
                Vector2 test = new Vector2(x, y);
                Grid.Add(test, " ");
                maxY = y;
            }
            maxX = x;
        }

    }
    public static void Update()
    {
        File.WriteAllText(@"Screen.txt", string.Empty);
        Console.Clear();
        //draw
        for (int Y = 0; Y < maxY; Y++)
        {
            string Line = string.Empty;
            for (int x = 0; x < maxX; x++)
            {

                Line = Line + Grid[new Vector2(x, Y)];
                if (x == maxX - 1)
                {
                    Line = Line + " n";
                }

            }
            //refresh
            File.AppendAllText(@"Screen.txt", Line + Environment.NewLine);
        }
        string[] textFromFile = File.ReadAllLines(@"Screen.txt");
        foreach (string line in textFromFile)
        {
            Console.WriteLine(line);
        }
    }
    public static void AddText(string Text, Vector2 Position)
    {
        Position.X = Position.X - Text.Length / 2;
        for (int i = 0; i < Text.Length; i++)
        {
            string letter = Text[i].ToString();
            Grid[new Vector2(Position.X + i, Position.Y)] = letter;
        }
    }
    public static (string, Vector2) LoadText(int Location)
    {
        string Text = File.ReadLines(@"text.txt").ElementAtOrDefault(Location);
        string[] textSplit = Text.Split("|");
        Vector2 text1vector = new Vector2(int.Parse(textSplit[1]), int.Parse(textSplit[2]));
        return (textSplit[0], text1vector);
    }


}