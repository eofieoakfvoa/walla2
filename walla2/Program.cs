﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

class Program1
{
    static void Main()
    {
        Console1 consoletest = new();
        consoletest.InitConsole();
        consoletest.Update();
        Scene test = new();
        Menu init = new();
        init.initMenu();
        Console.ReadLine();
    }
}