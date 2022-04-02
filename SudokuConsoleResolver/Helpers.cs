namespace SudokuConsoleResolver
{
    using System;
    using System.Threading;

    public static class Helpers
    {
        public static readonly int gridSize = 9;
        public static readonly char emptySpace = ' ';
        public static readonly char dash = '-';
        public static readonly char verticalBar = '|';

        public static readonly string defaultSpace = new string(emptySpace, 2);
        public static readonly string rowDelimiter = emptySpace + new string(dash, 35);
        public static readonly string columnDelimiter = defaultSpace + verticalBar + defaultSpace;
        public static readonly string startColumnDelimiter = verticalBar.ToString();
        public static readonly string endColumnDelimiter = defaultSpace + verticalBar;
        public static readonly string numbersDelimiter = defaultSpace;

        public static bool isNumberInRow(int[,] board, int number, int row)
        {
            for (int i = 0; i < gridSize; i++)
            {
                if (board[row, i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isNumberInColumn(int[,] board, int number, int column)
        {
            for (int i = 0; i < gridSize; i++)
            {
                if (board[i, column] == number)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isNumberInBox(int[,] board, int number, int row, int column)
        {
            int currentBoxRow = row - row % 3;
            int currentBoxColumn = column - column % 3;

            for (int i = currentBoxRow; i < currentBoxRow + 3; i++)
            {
                for (int j = currentBoxColumn; j < currentBoxColumn + 3; j++)
                {
                    if (board[i, j] == number)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool isValidPlacement(int[,] board, int number, int row, int column)
            => !isNumberInRow(board, number, row)
            && !isNumberInColumn(board, number, column)
            && !isNumberInBox(board, number, row, column);

        public static void printBoard(int[,] board)
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
                    Thread.Sleep(50);
                    Console.Write(board[row, column]);
                }
                Console.Write(endColumnDelimiter);
                Console.WriteLine();
            }

            Console.WriteLine(rowDelimiter);
        }

        public static bool solveBoard(int[,] board)
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int column = 0; column < gridSize; column++)
                {
                    if (board[row, column] == 0)
                    {
                        for (int numberToTry = 1; numberToTry <= gridSize; numberToTry++)
                        {
                            if (isValidPlacement(board, numberToTry, row, column))
                            {
                                board[row, column] = numberToTry;

                                if (solveBoard(board))
                                {
                                    return true;
                                }
                                else
                                {
                                    board[row, column] = 0;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
    }
}