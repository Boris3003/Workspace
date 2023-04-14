// more figure
Console.Write("Enter first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int second = int.Parse(Console.ReadLine());
int min = first;
int max = second;
if(first> second)
{
    min = second;
    max = first;
}
Console.WriteLine($"Minimum number: {min}");
Console.WriteLine($"Maximum number: {max}");