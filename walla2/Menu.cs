using System.Runtime.InteropServices;
using System.IO;
using System.Windows;
using System.Security.Principal;

public class Menu
{
    public void initMenu()
    {
        int Windowswidth = 200;
        int windowsHeight = 50;
        Scene test = new();
        test.ChangeScene<MenuColors>();
        Console.SetWindowSize(Windowswidth,windowsHeight);
        string[] textFromFile = File.ReadAllLines(@"MenuTemplate.txt");
        for (int i = 0; i < windowsHeight; i++)
        {
            
        }
        foreach (string line in textFromFile)
        {
            Console.WriteLine(line);
        }         

    }
}