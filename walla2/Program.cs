// See https://aka.ms/new-console-template for more information
using System;


class Program1
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console1 consoletest = new();
        consoletest.InitConsole();
        Scene test = new();
        Menu init = new();
        init.initMenu();
        test.ChangeScene<DamageTaken>();
        Console.WriteLine("YOU TOOK 50 DAMAGE");
        Console.ReadLine();
    }
}