using System.Data;
using System.Numerics;
using System.Runtime.InteropServices;

public class Console1
{
    //ändra 1920, 1080 till en sak som faktiskt fungerar på alla skärmar
    float rowtopixelWidth = 1920 / Console.LargestWindowWidth;
    float rowtopixelHeight = 1080 / Console.LargestWindowHeight;
    public List<Vector2> grid = new();
    public void InitConsole()
    {
        //console använder rows, columns istället för pixlar därför behöver converta, pixelwidth/height inte perfekt men fungerar typ
        int windowsPixelWidth = 512;
        //för någon anledning är max 1071 på en 1080 skärm?,,,,, 512 / 400
        int windowsPixelHeight = 400;
        int windowsWidth = (int)MathF.Floor(windowsPixelWidth/rowtopixelWidth);
        int windowsHeight = (int)MathF.Floor(windowsPixelHeight/rowtopixelHeight);
        Console.SetWindowSize(windowsWidth,windowsHeight);
        int maxY = 0;
        int maxX = 0;

        for (int i = 0; i < windowsWidth; i++)
        {
            for (int y = 0; y < windowsHeight; y++)
            {
                Vector2 test = new Vector2(i,y);
                grid.Add(test);
                maxY = y;
            }
            maxX = i;
        }
        File.WriteAllText(@"MenuTemplate.txt", string.Empty);
        for (int Y = 0; Y < maxY; Y++)
        {
            string Line = "_";
            for (int x = 0; x < maxX; x++)
            {
                Line = Line + "_";
            } 
            File.AppendAllText(@"MenuTemplate.txt", Line + Environment.NewLine);
        }

    }
    public static void Update()
    {

    }
}