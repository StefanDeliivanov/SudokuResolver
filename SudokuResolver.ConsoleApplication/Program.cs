namespace SudokuResolver.ConsoleApplication
{
    using SudokuResolver.BusinessLogic;

    class Program
    {
        static void Main(string[] args)
        {
            var collection = new BoardTemplatesCollection();
            var boardsToSolve = collection.GetBoards();
            var solver = new Solver();

            foreach (var board in boardsToSolve)
            {
                solver.Solve(board);
            }
        }
    }
}