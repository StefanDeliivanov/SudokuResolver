namespace SudokuConsoleResolver
{
    using System;
    using System.Collections.Generic;
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

            int[,] board2 = new int[,]
            {
                { 0, 2, 1, 6, 0, 0, 0, 9, 0},
                { 8, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 5, 4, 0, 0},
                { 0, 3, 8, 0, 0, 6, 0, 0, 5},
                { 7, 0, 0, 0, 0, 0, 0, 3, 0},
                { 9, 0, 0, 8, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 2, 0, 0, 0, 9},
                { 0, 7, 0, 0, 0, 0, 0, 0, 0},
                { 0, 6, 3, 1, 0, 0, 0, 2, 0}
            };

            List<int[,]> boardsToSolve = new();
            boardsToSolve.Add(board);
            boardsToSolve.Add(board2);

            foreach (var currentBoard in boardsToSolve)
            {
                Console.WriteLine("Starting board!");
                printBoard(currentBoard);
                Console.WriteLine();

                if (solveBoard(currentBoard))
                {
                    Console.WriteLine("Solved successfully!");
                    Console.WriteLine();
                    printBoard(currentBoard);
                }
                else
                {
                    Console.WriteLine("Unsolvable board :(");
                }
            }
        }
    }
}