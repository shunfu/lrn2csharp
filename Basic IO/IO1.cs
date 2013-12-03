using System;

public class IO1
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
        Console.ReadKey();
	}
}
