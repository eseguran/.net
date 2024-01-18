// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your name?");
var name = Console.ReadLine();
Console.WriteLine($"{Environment.NewLine} Hello, {name}!");
Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
