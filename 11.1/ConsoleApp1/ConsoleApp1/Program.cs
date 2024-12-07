
class Program
{
    static void Main(string[] args)
    {
        string secretWord = "собака";
        int maxAttempts = 6;

        char[] guessedWord = new string('_', secretWord.Length).ToCharArray();
        HashSet<char> guessedLetters = new HashSet<char>();
        int attemptsLeft = maxAttempts;

        Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
        Console.WriteLine($"Кількість літер у слові: {secretWord.Length}");
        Console.WriteLine($"Кількість можливих невірних спроб: {maxAttempts}");

        while (attemptsLeft > 0 && new string(guessedWord) != secretWord)
        {
            Console.WriteLine($"\nПоточний стан слова: {new string(guessedWord)}");
            Console.Write("Введіть вашу літеру: ");
            string input = Console.ReadLine()?.ToLower();

            if (string.IsNullOrWhiteSpace(input) || input.Length != 1)
            {
                Console.WriteLine("Будь ласка, введіть одну літеру.");
                continue;
            }

            char guessedLetter = input[0];

            if (guessedLetters.Contains(guessedLetter))
            {
                Console.WriteLine("Ви вже вводили цю літеру. Спробуйте іншу.");
                continue;
            }

            guessedLetters.Add(guessedLetter);

            if (secretWord.Contains(guessedLetter))
            {
                Console.Write($"Така літера є у слові! Позиція літери: ");

                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guessedLetter)
                    {
                        guessedWord[i] = guessedLetter;
                        Console.Write($"{i + 1} ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                attemptsLeft--;
                Console.WriteLine($"Такої літери немає! Залишилось спроб: {attemptsLeft}");
            }
        }

        if (new string(guessedWord) == secretWord)
        {
            Console.WriteLine($"\nВітаємо, ви вгадали слово! Зашифроване слово: {secretWord}.");
        }
        else
        {
            Console.WriteLine($"\nНа жаль, ви програли. Зашифроване слово було: {secretWord}.");
        }

        Console.WriteLine("Дякуємо за гру.");
    }
}
