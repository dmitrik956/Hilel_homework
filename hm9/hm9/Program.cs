//                                                TASK#1
//using system.text;

//class program
//{
//    static void main(string[] args)
//    {
//        stringbuilder report = new stringbuilder();

//        // добавляем заголовок
//        report.appendline("текстовий звіт");
//        report.appendline($"дата: {datetime.now:dd.mm.yyyy}");
//        report.appendline("список подій:");

//        while (true)
//        {
//            console.write("введіть подію (або натисніть enter для завершення): ");
//            string eventinput = console.readline();
//            if (string.isnullorwhitespace(eventinput))
//                break;

//            report.appendline($"- {eventinput}");
//        }

//        console.writeline("\nваш звіт:");
//        console.writeline(report.tostring());
//    }
//}

//                                                 TASK#2
//class program
//{
//    static void main(string[] args)
//    {
//        int[] array = { 10, 20, 20, 30, 5, 15 };

//        if (array.length < 2)
//        {
//            console.writeline("масив містить менше двох елементів.");
//            return;
//        }

//        int max = int.minvalue, secondmax = int.minvalue;

//        foreach (int num in array)
//        {
//            if (num > max)
//            {
//                secondmax = max;
//                max = num;
//            }
//            else if (num > secondmax && num < max)
//            {
//                secondmax = num;
//            }
//        }

//        if (secondmax == int.minvalue)
//        {
//            console.writeline("другого найбільшого елементу немає.");
//        }
//        else
//        {
//            console.writeline($"другий найбільший елемент: {secondmax}");
//        }
//    }
//}

//                                                TASK#3

//class program
//{
//    static void main(string[] args)
//    {
//        int[,] array = {
//            { 9, 8, 7 },
//            { 6, 5, 4 },
//            { 3, 2, 1 }
//        };

//        int[] flatarray = new int[array.getlength(0) * array.getlength(1)];
//        int index = 0;
//        for (int i = 0; i < array.getlength(0); i++)
//        {
//            for (int j = 0; j < array.getlength(1); j++)
//            {
//                flatarray[index++] = array[i, j];
//            }
//        }

//        array.sort(flatarray);

//        index = 0;
//        for (int i = 0; i < array.getlength(0); i++)
//        {
//            for (int j = 0; j < array.getlength(1); j++)
//            {
//                array[i, j] = flatarray[index++];
//            }
//        }

//        console.writeline("відсортований масив:");
//        for (int i = 0; i < array.getlength(0); i++)
//        {
//            for (int j = 0; j < array.getlength(1); j++)
//            {
//                console.write($"{array[i, j]} ");
//            }
//            console.writeline();
//        }
//    }
//}

//                                   TASK#4
//class program
//{
//    static void main(string[] args)
//    {
//        int[] array = { 1, 2, 3, 4, 5 };

//        console.write("введіть індекс для видалення: ");
//        int indextoremove = int.parse(console.readline()!);

//        if (indextoremove < 0 || indextoremove >= array.length)
//        {
//            console.writeline("індекс поза межами масиву.");
//            return;
//        }

//        int[] newarray = new int[array.length - 1];
//        int newindex = 0;

//        for (int i = 0; i < array.length; i++)
//        {
//            if (i != indextoremove)
//            {
//                newarray[newindex++] = array[i];
//            }
//        }

//        console.writeline("масив після видалення:");
//        console.writeline(string.join(", ", newarray));
//    }
//}

//                                    TASK#5
//class program
//{
//    static void main(string[] args)
//    {
//        int[,] array = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        int diagonalsum = 0;

//        for (int i = 0; i < array.getlength(0); i++)
//        {
//            diagonalsum += array[i, i]; 
//        }

//        console.writeline($"сума елементів по діагоналі: {diagonalsum}");
//    }
//}
