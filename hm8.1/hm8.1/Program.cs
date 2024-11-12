//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = new int[10];
//        Random random = new Random();

//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = random.Next(-10, 11);
//        }

//        Console.WriteLine("Массив:");
//        foreach (int value in array)
//        {
//            Console.Write(value + " ");
//        }
//        Console.WriteLine();

//        int sum = 0;
//        foreach (int value in array)
//        {
//            sum += value;
//        }

//        if (sum >= 0)
//        {
//            Console.WriteLine("Сума не отрицательное число");
//        }
//        else
//        {
//            Console.WriteLine("Сума отрицательное число");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] multiplicationTable = new int[9, 9];

//        for (int i = 0; i < 9; i++)
//        {
//            for (int j = 0; j < 9; j++)
//            {
//                multiplicationTable[i, j] = (i + 1) * (j + 1);
//            }
//        }

//        Console.WriteLine("Таблица умножения 9x9:");
//        for (int i = 0; i < 9; i++)
//        {
//            for (int j = 0; j < 9; j++)
//            {
//                Console.Write($"{multiplicationTable[i, j],2} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] AnyNumber = new int[5, 5];
//        Random random = new Random();

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                AnyNumber[i, j] = random.Next(-50, 51);
//            }
//        }
//        Console.WriteLine("Двумерный масив 5x5:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"{AnyNumber[i, j],4} ");
//            }
//            Console.WriteLine();
//        }

//        int maxElement = AnyNumber[0, 0];
//        int minElement = AnyNumber[0, 0];
//        int minRow = 0, minCol = 0;
//        int maxRow = 0, maxCol = 0;

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (AnyNumber[i, j] > maxElement)
//                {
//                    maxElement = AnyNumber[i, j];
//                    maxRow = i;
//                    maxCol = j;
//                }

//                if (AnyNumber[i, j] < minElement)
//                {
//                    minElement = AnyNumber[i, j];
//                    minRow = i;
//                    minCol = j;
//                }
//            }
//        }

//        Console.WriteLine($"\nМаксимальний елемент масиву: {maxElement} (координати: [{maxRow}, {maxCol}])");
//        Console.WriteLine($"Минимальный елемент масиву: {minElement} (координати: [{minRow}, {minCol}])");
//    }
//}

//class Program
//{
//    enum Days
//    {
//        Monday = 0,
//        Tuesday = 1,
//        Wednesday = 2,
//        Thursday = 3,
//        Friday = 4,
//        Saturday = 5,
//        Sunday = 6
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Введите количество дней: ");
//        int daysInput = int.Parse(Console.ReadLine()!);

//        // Находим соответствующий день недели
//        Days resultDay = (Days)((int)Days.Monday + daysInput % 7);

//        // Выводим результат
//        Console.WriteLine($"Через {daysInput} дней будет: {resultDay}");
//    }
//}
