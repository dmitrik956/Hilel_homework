
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть номер числа Фібоначчі: ");
        int n = int.Parse(Console.ReadLine()!);

        if (n < 0)
        {
            Console.WriteLine("Номер числа Фібоначчі має бути невід'ємним.");
            return;
        }

        int result = Fibonacci.Calculate(n);
        Console.WriteLine($"Число Фібоначчі порядку {n}: {result}");
    }
}

static class Fibonacci
{
    public static int Calculate(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1; 

        return Calculate(n - 1) + Calculate(n - 2);
    }
}
