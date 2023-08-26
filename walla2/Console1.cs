using System.Data;
using System.Numerics;

public class Console1
{
    //ändra 1920, 1080 till en sak som faktiskt fungerar på alla skärmar
    float rowtopixelWidth = 1920 / Console.LargestWindowWidth;
    float rowtopixelHeight = 1080 / Console.LargestWindowWidth;
    public List<Vector2> grid = new();
    public void InitConsole()
    {
        //console använder rows, columns istället för pixlar därför behöver converta
        int windowsPixelWidth = 512;
        int windowsPixelHeight = 100;
        int windowsWidth = Convert.ToInt32(windowsPixelWidth/rowtopixelWidth);
        int windowsHeight = Convert.ToInt32(windowsPixelHeight/rowtopixelHeight);
        Console.SetWindowSize(windowsWidth,windowsHeight);

        for (int i = 0; i < windowsWidth; i++)
        {
            for (int y = 0; y < windowsHeight; y++)
            {
                Vector2 test = new Vector2(i,y);
                grid.Add(test);
            }
        }

    }
    public static void Update()
    {

    }
}