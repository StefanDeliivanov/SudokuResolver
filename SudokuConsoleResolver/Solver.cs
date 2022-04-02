namespace SudokuConsoleResolver
{
    using System;
    using System.Collections.Generic;
    using static HelperMethods;

    public class Solver
    {
        public readonly List<int[,]> boardsToSolve;

        public Solver(List<int[,]> boardsToSolve)
        {
            this.boardsToSolve = boardsToSolve;
        }

        public void Solve()
        {
            foreach (var currentBoard in this.boardsToSolve)
            {
                Console.WriteLine("Starting board!");
                PrintBoard(currentBoard);
                Console.WriteLine();

                if (solveBoard(currentBoard))
                {
                    Console.WriteLine("Solved successfully!");
                    Console.WriteLine();
                    PrintBoard(currentBoard, 50);
                }
                else
                {
                    Console.WriteLine("Unsolvable board :(");
                }
            }
        }
    }
}