// See https://aka.ms/new-console-template for more information
using System;


class Program1
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Scene test = new();
        test.ChangeScene<Menu>();
        Console.WriteLine("Hello");
        test.ChangeScene<DamageTaken>();
        Console.WriteLine("YOU TOOK 50 DAMAGE");
        Console.ReadLine();
    }
}