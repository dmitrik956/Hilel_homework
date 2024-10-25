bool continueProgram = true;
while (continueProgram)
{
    Console.WriteLine("Первое  число");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Второе  число");
    int n2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Математическую операция");
    char one = char.Parse(Console.ReadLine()!); ;
    int res;
    switch (one)
    {
        case '-':
            res = n1 - n2;
            Console.WriteLine($"Результат: {n1} - {n2} = {res}");
            break;
        case '+':
            res = n1 + n2;
            Console.WriteLine($"Результат: {n1} + {n2} = {res}");
            break;
        case '*':
            res = n1 * n2;
            Console.WriteLine($"Результат: {n1} * {n2} = {res}");
            break;
        case '/':
            if (n2 != 0)
            {
                res = n1 / n2;
                Console.WriteLine($"Результат: {n1} / {n2} = {res}");
            }
            else
                Console.WriteLine("На 0 делить нельзя");
            break;
        default:
            Console.WriteLine("Некорректная математическая операция");
            break;
    }
    Console.WriteLine("Хотите продолжить? (да/нет)");
    string? answer = Console.ReadLine()?.ToLower();

    if (answer != "да")
    {
        continueProgram = false;
        Console.WriteLine("Программа завершена.");
    }
}











