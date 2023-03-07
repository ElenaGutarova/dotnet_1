// Найти максимальное из двух введенных чисел
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32( Console.ReadLine ());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;
if (a > b)
{
    Console.Write("max ");
    Console.WriteLine (max = a);
    Console.Write("min ");
    Console.WriteLine (min = b);
    
}
else
{
    Console.Write("max ");
    Console.WriteLine(max = b);
    Console.Write("min ");
    Console.WriteLine (min = a);
}
