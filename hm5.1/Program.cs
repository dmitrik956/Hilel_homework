Console.WriteLine("Первое  число");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Второе  число");
int n2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Попробуйте деление");
char one = char.Parse(Console.ReadLine()!); ;
int res;

try
{
    int n1 / n2;

    Console.WriteLine(res);
}
catch
{
    Console.WriteLine("Делить на 0 невозможно");
}