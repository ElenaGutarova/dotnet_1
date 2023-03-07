// Найти максимальное из двух введенных чисел
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32( Console.ReadLine ());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;
if (a > b)
{
    Console.WriteLine (max = a);
    Console.WriteLine (min = b);
    
}
else
{
    Console.WriteLine(max = b);
    Console.WriteLine (min = a);
}
Console.Write("max ");
Console.WriteLine(max);
Console.Write("min ");
Console.WriteLine(min);