// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Scene test = new();
string guess = Console.ReadLine();

if (guess == "a"){
    test.ChangeScene<Menu>();
}
if (guess == "b"){
    test.ChangeScene<Battle>();
}
string guess2 = Console.ReadLine();

if (guess2 == "a"){
    test.ChangeScene<Menu>();
}
if (guess2 == "b"){
    test.ChangeScene<Battle>();
}
string guess3 = Console.ReadLine();

if (guess3 == "a"){
    test.ChangeScene<Menu>();
}
if (guess3 == "b"){
    test.ChangeScene<Battle>();
}


