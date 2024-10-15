using System;

class HelloWorld
{
    static void Main()
    {
        char[,] numbers = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        do
        {
            try
            {
                
                Console.WriteLine("Hamle İçin Sütun Yazınız.");
                int sutun = int.Parse(Console.ReadLine());
                Console.WriteLine("Hamle İçin Satır Yazınız.");
                int satır = int.Parse(Console.ReadLine());
                Console.WriteLine("Hamle Yazınız (X or O).");
                char hamle = Console.ReadKey().KeyChar;
                Console.WriteLine(); 

                if (numbers[satır - 1, sutun - 1] == ' ')
                {
                    if (hamle == 'X' || hamle == 'O')
                    {
                        numbers[satır - 1, sutun - 1] = hamle;

                        
                        if (CheckWin(numbers, hamle))
                        {
                            Console.Clear();
                            DrawBoard(numbers);
                            Console.WriteLine($"Tebrikler! {hamle} kazandı!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen X veya O Giriniz");
                    }
                }
                else
                {
                    Console.WriteLine("\nLütfen Boş Bir Yer Seçiniz.");
                }

                Console.WriteLine("-----------------------------");
                DrawBoard(numbers);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lütfen Sayıyla Giriş Yapınız.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("\nLütfen İstenilen Değerlerden Birini Giriniz.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("\nLütfen İstenilen Değerlerden Birini Giriniz.");
            }
        }
        while (true);
    }

    static void DrawBoard(char[,] numbers)
    {
        Console.Write("  1  2  3\n");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + 1);
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" " + numbers[i, j] + " ");
            }
            Console.Write("\n");
        }
    }

    static bool CheckWin(char[,] board, char player)
    {
        
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                return true;
        }

        
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                return true;
        }

        
        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            return true;

        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            return true;

        return false;
    }
}
