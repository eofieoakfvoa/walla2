using System.Runtime.InteropServices;
using System.IO;
using System.Windows;
using System.Security.Principal;

public class Menu
{
    public void initMenu()
    {
        Scene test = new();
        test.ChangeScene<MenuColors>();
        string[] textFromFile = File.ReadAllLines(@"MenuTemplate.txt");
        foreach (string line in textFromFile)
        {
           // Console.WriteLine(line);
        }         

    }
}