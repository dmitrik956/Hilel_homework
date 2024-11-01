//Задача #1
//decimal totalSalary = 0;

//Console.WriteLine("Сколько работников?");
//int Workers = int.Parse(Console.ReadLine()!);

//for (int i = 1 ; i <= Workers ; i++)
//{
//    Console.WriteLine($"Какая зарплата у работника номер {i}");
//    decimal workerSalary = decimal.Parse(Console.ReadLine()!);
//   totalSalary += workerSalary;
//}

//Console.WriteLine($"Средняя зарплата работников {totalSalary / Workers}");

//Задача #2
//Console.WriteLine("Укажите количество строчек");
//int Stars = int.Parse(Console.ReadLine()!);
//for (int x = 0; x <=Stars; x++)
//{
//    Console.WriteLine(new string ('*', x));
//}

//Задача #3
//    Console.WriteLine("Укажите клоичество нужных вам простых чисел");
//    int Numbers = int.Parse(Console.ReadLine()!);

//    if (Numbers <= 0)
//    {
//        Console.WriteLine("Количество должно быть больше 0");
//        return;
//    }

//    Console.WriteLine("Простые числа:");

//    int number = 2; 
//    int primesFound = 0; 

//    while (primesFound < Numbers)
//    {
//        if (IsPrime(number))
//        {
//            Console.Write($"{number} ");
//            primesFound++;
//        }
//        number++;
//    }
//static bool IsPrime(int n)
//{
//    if (n < 2) return false;
//    for (int y = 2; y <= Math.Sqrt(n); y++)
//    {
//        if (n % y == 0) return false;
//    }
//    return true;
//}


//Задача #4
//Console.WriteLine("Придумайте пароль");
//string pass =Console.ReadLine()!;

       
//        if (IsPasswordValid(pass))
//        {
//            Console.WriteLine("Пароль является верным.");
//        }
//        else
//        {
//            Console.WriteLine("Пароль не соответствует требованиям.");
//        }
//    static bool IsPasswordValid(string pass)
//    {
//        if (pass.Length < 8) return false;

//        bool Digit = pass.Any(char.IsDigit);

//        bool SpecialSimb = pass.Any(c => "!\"№;%".Contains(c));

//        return Digit && SpecialSimb;
//    }

//Задача #5
//Console.WriteLine("Сколько раз вы хотите произвести последовательность?");
//int numberOfCicleFib = int.Parse(Console.ReadLine()!);
//int FirstFibNumb = 0;
//int SecondFibNumb = 1;
//Console.WriteLine(FirstFibNumb);
//for (int q = 1; numberOfCicleFib >= q; q++)
//{
//    Console.WriteLine(SecondFibNumb);
//    int res = FirstFibNumb + SecondFibNumb;
//    FirstFibNumb = SecondFibNumb;
//    SecondFibNumb = res;
//}

//Задача #6
//Console.WriteLine("Укажите количесвто отработаных часов");
//int Hours = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Укажите почасовую оплату");
//int PayPerHour = int.Parse(Console.ReadLine()!);
//Console.WriteLine(Hours*PayPerHour);

//Задача #7
//Console.WriteLine("Введите число");
//decimal numToTimes1 = decimal.Parse(Console.ReadLine()!);
//for (int j = 1; j<=10; j++)
//{
//    Console.WriteLine(numToTimes1 * j);
//}
//Задача #8
//Console.WriteLine("Укажите ваше число");
//int SimpleNumber = int.Parse(Console.ReadLine()!);
//if (IsPrime(SimpleNumber))
//{
//    Console.WriteLine($"Ваше число {SimpleNumber} является простым");
//}
//else
//{
//    Console.WriteLine($"Ваше число {SimpleNumber} НЕ является простым");
//}

//    static bool IsPrime(int num)
//{
//    if (num < 2) return false; 

//    for (int I = 2; I <= Math.Sqrt(num); I++)
//    {
//        if (num % I == 0)
//        {
//            return false; 
//        }
//    }
//    return true;
//}
