namespace SudokuResolver.ConsoleApplication
{
    using SudokuResolver.BusinessLogic;

    class Program
    {
        static void Main(string[] args)
        {
            var collection = new BoardsTemplateCollection();
            var boardsToSolve = collection.GetBoards();

            var solver = new Solver(boardsToSolve);
            solver.Solve();
        }
    }
}