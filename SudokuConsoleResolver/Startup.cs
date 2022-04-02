namespace SudokuConsoleResolver
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var collection = new BoardsCollection();
            var boardsToSolve = collection.GetBoards();

            var solver = new Solver(boardsToSolve);
            solver.Solve();
        }
    }
}