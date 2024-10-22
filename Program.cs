Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Вкажіть цифру від 1 до 7");
while (true)
{
    switch (byte.Parse(Console.ReadLine()!))
    {
        case 1:
            Console.WriteLine("Понеділок");
            break;
        case 2:
            Console.WriteLine("Вівіторок");
            break;
        case 3:
            Console.WriteLine("Середа");
            break;
        case 4:
            Console.WriteLine("Четвер");
            break;
        case 5:
            Console.WriteLine("П'ятниця");
            break;
        case 6:
            Console.WriteLine("Субота");
            break;
        case 7:
            Console.WriteLine("Неділя");
            break;
        default:
            Console.WriteLine("Некортектна цифра");
            break;
    };
}



