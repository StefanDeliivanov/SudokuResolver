namespace SudokuResolver.BusinessLogic
{
    using SudokuResolver.Abstractions;
    using static SudokuResolver.BusinessLogic.DataConstants;

    public class Solver : ISolver
    {
        private static bool IsNumberInRowValid(int[,] board, int number, int row)
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

        private static bool IsNumberInColumnValid(int[,] board, int number, int column)
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

        private static bool IsNumberInBoxValid(int[,] board, int number, int row, int column)
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

        private static bool IsValidPlacement(int[,] board, int number, int row, int column)
            => !IsNumberInRowValid(board, number, row)
            && !IsNumberInColumnValid(board, number, column)
            && !IsNumberInBoxValid(board, number, row, column);

        public bool SolveBoard(int[,] board)
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

                                if (SolveBoard(board))
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