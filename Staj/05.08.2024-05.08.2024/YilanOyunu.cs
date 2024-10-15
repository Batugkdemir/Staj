using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Game
{
    static void Main()
    {
        Console.WindowHeight = 20; 
        Console.WindowWidth = 40;  
        List<Position> snake = new List<Position> { new Position(5, 5) };
        Position food = GenerateFood(snake);
        int score = 0;
        char direction = 'D'; 

        while (true)
        {
            Console.Clear();
            DrawGame(snake, food, score);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.UpArrow && direction != 'D') direction = 'U';
                else if (keyInfo.Key == ConsoleKey.DownArrow && direction != 'U') direction = 'D';
                else if (keyInfo.Key == ConsoleKey.LeftArrow && direction != 'R') direction = 'L';
                else if (keyInfo.Key == ConsoleKey.RightArrow && direction != 'L') direction = 'R';
            }

            
            Position head = MoveSnake(snake, direction);

            if (head.X == food.X && head.Y == food.Y)
            {
                score++;
                snake.Add(food); 
                food = GenerateFood(snake); 
            }
            else
            {
                snake.Insert(0, head);
                snake.RemoveAt(snake.Count - 1); 
            }

            if (IsGameOver(snake))
            {
                Console.Clear();
                Console.WriteLine("Oyun Bitti! Skor: " + score);
                break;
            }

            Thread.Sleep(200); 
        }
    }

    static void DrawGame(List<Position> snake, Position food, int score)
    {
        foreach (var segment in snake)
        {
            Console.SetCursorPosition(segment.X, segment.Y);
            Console.Write("■");
        }
        
        Console.SetCursorPosition(food.X, food.Y);
        Console.Write("●");

        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Skor: " + score);
    }

    static Position MoveSnake(List<Position> snake, char direction)
    {
        Position head = snake.First();
        switch (direction)
        {
            case 'U': return new Position(head.X, head.Y - 1);
            case 'D': return new Position(head.X, head.Y + 1);
            case 'L': return new Position(head.X - 1, head.Y);
            case 'R': return new Position(head.X + 1, head.Y);
            default: return head;
        }
    }

    static Position GenerateFood(List<Position> snake)
    {
        Random rand = new Random();
        Position food;
        do
        {
            food = new Position(rand.Next(1, 38), rand.Next(1, 18));
        } while (snake.Any(s => s.X == food.X && s.Y == food.Y)); 
        return food;
    }

    static bool IsGameOver(List<Position> snake)
    {
        Position head = snake.First();
        if (snake.Skip(1).Any(s => s.X == head.X && s.Y == head.Y))
            return true;

        if (head.X < 0 || head.X >= Console.WindowWidth || head.Y < 0 || head.Y >= Console.WindowHeight)
            return true;

        return false;
    }
}

struct Position
{
    public int X;
    public int Y;

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}
