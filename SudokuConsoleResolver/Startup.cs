namespace SudokuConsoleResolver
{
    using System;
    using static Helpers;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[,] board = new int[,]
            {
                { 7, 0, 2, 0, 5, 0, 6, 0, 0},
                { 0, 0, 0, 0, 0, 3, 0, 0, 0},
                { 1, 0, 0, 0, 0, 9, 5, 0, 0},
                { 8, 0, 0, 0, 0, 0, 0, 9, 0},
                { 0, 4, 3, 0, 0, 0, 7, 5, 0},
                { 0, 9, 0, 0, 0, 0, 0, 0, 8},
                { 0, 0, 9, 7, 0, 0, 0, 0, 5},
                { 0, 0, 0, 2, 0, 0, 0, 0, 0},
                { 0, 0, 7, 0, 4, 0, 2, 0, 3}
            };

            Console.WriteLine("Starting board!");
            printBoard(board);
            Console.WriteLine();

            if (solveBoard(board))
            {
                Console.WriteLine("Solved successfully!");
                Console.WriteLine();
                printBoard(board);
            }
            else
            {
                Console.WriteLine("Unsolvable board :(");
            }
        }
    }
}