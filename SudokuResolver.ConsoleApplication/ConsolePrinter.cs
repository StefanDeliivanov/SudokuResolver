﻿namespace SudokuResolver.ConsoleApplication
{
    using System;
    using System.Threading;
    using SudokuResolver.Abstractions;
    using SudokuResolver.BusinessLogic;
    using static SudokuResolver.BusinessLogic.DataConstants;
    using static SudokuResolver.BusinessLogic.DataConstants.ConsoleDataConstants;

    public class ConsolePrinter : IPrinter
    {
        private void PrintBoardHelper(int[,] board, int milliSecondsDelay = 0)
        {
            for (int row = 0; row < gridSize; row++)
            {
                if (row % 3 == 0)
                {
                    Console.WriteLine(rowDelimiter);
                    Console.Write(startColumnDelimiter);
                }
                else Console.Write(startColumnDelimiter);

                for (int column = 0; column < gridSize; column++)
                {
                    if (column % 3 == 0 && column != 0)
                    {
                        Console.Write(columnDelimiter);
                    }
                    else
                    {
                        Console.Write(numbersDelimiter);
                    }
                    Thread.Sleep(milliSecondsDelay);
                    if (board[row, column] == 0)
                    {
                        Console.Write('X');
                    }
                    else Console.Write(board[row, column]);
                }
                Console.Write(endColumnDelimiter);
                Console.WriteLine();
            }

            Console.WriteLine(rowDelimiter);
        }

        public void PrintBoard(int[,] board)
        {
            var solver = new Solver();

            Console.WriteLine("Starting board!");
            PrintBoardHelper(board);
            Console.WriteLine();

            if (solver.SolveBoard(board))
            {
                Console.WriteLine("Solved successfully!");
                Console.WriteLine();
                PrintBoardHelper(board, 50);
            }
            else
            {
                Console.WriteLine("Unsolvable board :(");
            }
        }
    }
}