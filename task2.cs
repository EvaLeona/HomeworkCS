using System;

public class MainClass
{
public static void Main()
{
var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
if (a > b)
Console.WriteLine($"max={a}");
else
Console.WriteLine($"max={b}");
}
}