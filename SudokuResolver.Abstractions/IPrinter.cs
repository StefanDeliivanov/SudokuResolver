namespace SudokuResolver.Abstractions
{
    using SudokuResolver.Abstractions.BaseInterfaces;

    public interface IPrinter : IOperationContract
    {
        void PrintBoard(int[,] board);
    }
}