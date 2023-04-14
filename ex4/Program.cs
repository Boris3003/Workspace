// chetnie
Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine());
int x = 2;
if (N >= x)
{
     while (x <= N)
     {
        Console.Write($"{x}  ");
        x = x + 2;
     }
}
else Console.Write("четных чисел нет");
