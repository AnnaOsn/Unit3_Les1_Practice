// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine()!);
if (a == b*b)
{     Console.WriteLine("yes");}
    
//Console.WriteLine(a);
//Console.Write("min: ");
//Console.WriteLine(b);

else
{
    Console.WriteLine("no");
}
//Console.WriteLine(b);
//Console.Write("min: ");
//Console.WriteLine(a);
