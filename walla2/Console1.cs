using System.Data;

public class Console1
{
    //ändra 1920, 1080 till en sak som faktiskt fungerar på alla skärmar
    float rowtopixelWidth = 1920 / Console.LargestWindowWidth;
    float rowtopixelHeight = 1080 / Console.LargestWindowWidth;
    public void InitConsole()
    {
        //console använder rows, columns istället för pixlar därför behöver converta
        int Windowswidth = 512;
        int windowsHeight = 100;
        Console.SetWindowSize(Convert.ToInt32(Windowswidth/rowtopixelWidth),Convert.ToInt32(windowsHeight/rowtopixelHeight));

        for (int i = 0; i < windowsHeight; i++)
        {
            
        }

    }
    public static void Update()
    {

    }
}