namespace SudokuResolver.BusinessLogic
{
    using System;
    using System.Threading;
    using static DataConstants;

    public static class HelperMethods
    {
        public static bool IsNumberInRowValid(int[,] board, int number, int row)
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

        public static bool IsNumberInColumnValid(int[,] board, int number, int column)
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

        public static bool IsNumberInBoxValid(int[,] board, int number, int row, int column)
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

        public static bool IsValidPlacement(int[,] board, int number, int row, int column)
            => !IsNumberInRowValid(board, number, row)
            && !IsNumberInColumnValid(board, number, column)
            && !IsNumberInBoxValid(board, number, row, column);

        public static void PrintBoard(int[,] board, int milliSecondsDelay = 0)
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
                            if (IsValidPlacement(board, numberToTry, row, column))
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