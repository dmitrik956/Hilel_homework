class XandO
{
    static char[,] board = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
    static char currentPlayer = 'X';

    static void Main(string[] args)
    {
        int turns = 0;

        while (true)
        {
            Console.Clear();
            DisplayBoard();

            Console.WriteLine($"\nХод игрока {currentPlayer}. Выберите ячейку (1-9): ");
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out int cell) && cell >= 1 && cell <= 9)
            {
                if (PlaceMarker(cell))
                {
                    turns++;
                    if (CheckWin())
                    {
                        Console.Clear();
                        DisplayBoard();
                        Console.WriteLine($"\nИгрок {currentPlayer} выиграл!");
                        break;
                    }
                    else if (turns == 9)
                    {
                        Console.Clear();
                        DisplayBoard();
                        Console.WriteLine("\nНичья!");
                        break;
                    }

                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Эта ячейка уже занята! Попробуйте снова.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод! Введите число от 1 до 9.");
                Console.ReadLine();
            }
        }
    }
    static void DisplayBoard()
    {
        Console.WriteLine("Крестики-Нолики");
        Console.WriteLine("-------------");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " | ");
            }
            Console.WriteLine("\n-------------");
        }
    }

    static bool PlaceMarker(int cell)
    {
        int row = (cell - 1) / 3;
        int col = (cell - 1) % 3;

        if (board[row, col] != 'X' && board[row, col] != 'O')
        {
            board[row, col] = currentPlayer;
            return true;
        }
        return false;
    }

    static bool CheckWin()
    {
        
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||  
                (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))    
            {
                return true;
            }
        }

        if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) || 
            (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))   
        {
            return true;
        }

        return false;
    }
}
