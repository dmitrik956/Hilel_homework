
class ToDoApp
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Список справ:");
            Console.WriteLine("1. Додати справу");
            Console.WriteLine("2. Вивести всі справи");
            Console.WriteLine("3. Позначити справу як виконану");
            Console.WriteLine("4. Видалити справу");
            Console.WriteLine("5. Завантажити список справ");
            Console.WriteLine("6. Вийти");

            Console.Write("\nВиберіть опцію: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    MarkTaskCompleted();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    LoadTasks();
                    break;
                case "6":
                    Console.WriteLine("Дякуємо за використання додатку! До побачення!");
                    return;
                default:
                    Console.WriteLine("Некоректна опція. Спробуйте ще раз.");
                    break;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
            Console.ReadKey();
        }
    }

    static void AddTask()
    {
        Console.Write("Введіть назву справи: ");
        string task = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(task))
        {
            Console.WriteLine("Назва справи не може бути порожньою.");
            return;
        }

        tasks.Add(task);
        Console.WriteLine($"Справу '{task}' додано до списку.");
    }

    static void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список справ порожній.");
            return;
        }

        Console.WriteLine("Ваш список справ:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    static void MarkTaskCompleted()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список справ порожній.");
            return;
        }

        ShowTasks();

        Console.Write("Введіть номер справи, яку хочете позначити як виконану: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1] += " (виконано)";
            Console.WriteLine($"Справу №{taskNumber} позначено як виконану.");
        }
        else
        {
            Console.WriteLine("Некоректний номер справи.");
        }
    }

    static void DeleteTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список справ порожній.");
            return;
        }

        ShowTasks();

        Console.Write("Введіть номер справи, яку хочете видалити: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            Console.WriteLine($"Справу '{tasks[taskNumber - 1]}' видалено.");
            tasks.RemoveAt(taskNumber - 1);
        }
        else
        {
            Console.WriteLine("Некоректний номер справи.");
        }
    }

    static void LoadTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список справ порожній.");
            return;
        }

        Console.WriteLine("Збережений список справ:");
        ShowTasks();
    }
}
