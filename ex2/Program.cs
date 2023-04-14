// maximal figure
Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int c = int.Parse(Console.ReadLine());
int max = a;
if(b> a) {max = b; if(c> b) {max = c;}}
else {if(c> a) max = c;}
Console.WriteLine($"Maximum number: {max}");