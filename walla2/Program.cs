// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

class Program1
{
    static void Main()
    {
        ConsoleManager.InitConsole();
        ConsoleManager.Update();
        Scene test = new();
        Menu init = new();
        init.initMenu();
        Console.ReadLine();
    }
}