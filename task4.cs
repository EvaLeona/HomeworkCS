using System;

public class MainClass
{
public static void Main()
{
var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var c = int.Parse(Console.ReadLine());
if (a > b)
if (a > c)
Console.WriteLine($"max={a}");
else
Console.WriteLine($"max={c}");
else
if (b > c)
Console.WriteLine($"max={b}");
else
Console.WriteLine($"max={c}");
}
} 