using System.Data;
using System.Numerics;
using System.Runtime.InteropServices;
//gör så den ritar ut från en dictionary ksk så att key vector2 t.ex 1,2 ska va ett i, kanske gör det lättare i framtiden?
//▒ ser ut som bricks typ ■ pixel nästan? □, https://en.wikipedia.org/wiki/Geometric_Shapes_(Unicode_block)
public class Console1
{
    //ändra 1920, 1080 till en sak som faktiskt fungerar på alla skärmar
    float rowtopixelWidth = 1920 / Console.LargestWindowWidth;
    float rowtopixelHeight = 1080 / Console.LargestWindowHeight;
    public Dictionary<Vector2, string> Grid = new();
    private int maxY = 0;
    private int maxX = 0;
    public void InitConsole()
    {
        //console använder rows, columns istället för pixlar därför behöver converta, pixelwidth/height inte perfekt men fungerar typ
        int windowsPixelWidth = 512;
        //för någon anledning är max 1071 på en 1080 skärm?,,,,, 512 / 400
        int windowsPixelHeight = 400;
        int windowsWidth = (int)MathF.Floor(windowsPixelWidth/rowtopixelWidth);
        int windowsHeight = (int)MathF.Floor(windowsPixelHeight/rowtopixelHeight);
        Console.SetWindowSize(windowsWidth, windowsHeight);

        for (int i = 0; i < windowsWidth; i++)
        {
            for (int y = 0; y < windowsHeight; y++)
            {
                Vector2 test = new Vector2(i,y);
                Grid.Add(test, "_");
                maxY = y;
            }
            maxX = i;
        }

    }
    public void Update()
    {
        File.WriteAllText(@"MenuTemplate.txt", string.Empty);
        //draw
        for (int Y = 0; Y < maxY; Y++)
        {
            string Line = string.Empty;
            for (int x = 0; x < maxX; x++)
            {

                Line = Line + Grid[new Vector2(x,Y)];
                
            } 
            File.AppendAllText(@"MenuTemplate.txt", Line + Environment.NewLine);
         }
    }
}