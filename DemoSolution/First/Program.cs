// See https://aka.ms/new-console-template for more information
using First;

Console.WriteLine("Hello, World!");
Console.WriteLine("Paresh Jadiya");

Console.WriteLine("paresh black Bhais aahe");


Console.WriteLine("Kindly enter first number");
int a=int.Parse(Console.ReadLine()); 
Console.WriteLine("Kindly enter second number");
int b=Convert.ToInt32(Console.ReadLine());

Calculator cs = new Calculator();
cs.Addition(a,b);

Console.ReadLine();
