namespace SudokuResolver.Abstractions
{
    using SudokuResolver.Abstractions.BaseInterfaces;

    public interface ISolver : IOperationContract
    {
        bool SolveBoard(int[,] board);
    }
}