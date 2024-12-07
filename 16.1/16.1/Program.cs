
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введіть шлях до вихідного файлу: ");
            string sourcePath = Console.ReadLine()!;

            Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
            string destinationPath = Console.ReadLine()!;

            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Помилка: Вихідний файл не знайдено.");
                return;
            }

            string content = File.ReadAllText(sourcePath);

            File.WriteAllText(destinationPath, content);

            Console.WriteLine("Файл успішно скопійовано!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка під час копіювання файлу: {ex.Message}");
        }
    }
}
