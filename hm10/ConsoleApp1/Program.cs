class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите имя и фамилию: ");
        string fullName = Console.ReadLine()!;

        string[] parts = fullName.Split(' ');

        if (parts.Length >= 2)
        {
            string firstName = parts[0];
            string lastName = parts[1];

            if (char.ToLower(firstName[0]) == char.ToLower(lastName[0]))
            {
                Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
            }
            else
            {
                Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
            }
        }
        else
        {
            Console.WriteLine("Помилка: Введіть і ім’я, і прізвище.");
        }

        Console.Write("Введите строку, разделенную запятыми: ");
        string commaSeparated = Console.ReadLine()!;
        string result = commaSeparated.Replace(" ", "");

        Console.WriteLine("Результат без пробелов: " + result);
    }
}
