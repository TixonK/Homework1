Console.Clear();

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

if ((a>b) & (a>c))
{
    Console.WriteLine("Maxx = ");
    Console.WriteLine(a);
}

else if ((b>a) & (b>c))
{
    Console.WriteLine("Maxx = ");
    Console.WriteLine(b);
}

else 
{
    Console.WriteLine("Maxx = ");
    Console.WriteLine(c);
}