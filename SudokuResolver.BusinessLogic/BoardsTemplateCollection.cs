namespace SudokuResolver.BusinessLogic
{
    using System.Collections.Generic;

    public class BoardsTemplateCollection
    {
        private List<int[,]> collectionList = new();

        private readonly int[,] board = new int[,]
        {
            { 7, 0, 2, 0, 5, 0, 6, 0, 0},
            { 0, 0, 0, 0, 0, 3, 0, 0, 0},
            { 1, 0, 0, 0, 0, 9, 5, 0, 0},
            { 8, 0, 0, 0, 0, 0, 0, 9, 0},
            { 0, 4, 3, 0, 0, 0, 7, 5, 0},
            { 0, 9, 0, 0, 0, 0, 0, 0, 8},
            { 0, 0, 9, 7, 0, 0, 0, 0, 5},
            { 0, 0, 0, 2, 0, 0, 0, 0, 0},
            { 0, 0, 7, 0, 4, 0, 2, 0, 3}
        };

        private readonly int[,] board2 = new int[,]
        {
            { 0, 2, 1, 6, 0, 0, 0, 9, 0},
            { 8, 0, 0, 0, 0, 0, 0, 0, 0},
            { 0, 0, 0, 0, 0, 5, 4, 0, 0},
            { 0, 3, 8, 0, 0, 6, 0, 0, 5},
            { 7, 0, 0, 0, 0, 0, 0, 3, 0},
            { 9, 0, 0, 8, 0, 0, 0, 0, 0},
            { 0, 0, 0, 0, 2, 0, 0, 0, 9},
            { 0, 7, 0, 0, 0, 0, 0, 0, 0},
            { 0, 6, 3, 1, 0, 0, 0, 2, 0}
        };

        private readonly int[,] board3 = new int[,]
        {
            { 2, 3, 0, 4, 1, 5, 0, 6, 8},
            { 0, 8, 0, 2, 3, 6, 5, 1, 9},
            { 1, 6, 0, 9, 8, 7, 2, 3, 4},
            { 3, 1, 7, 0, 9, 4, 0, 2, 5},
            { 4, 5, 8, 1, 2, 0, 6, 9, 7},
            { 9, 2, 6, 0, 5, 8, 3, 0, 1},
            { 0, 0, 0, 5, 0, 0, 1, 0, 2},
            { 0, 0, 0, 8, 4, 2, 9, 0, 3},
            { 5, 9, 2, 3, 7, 1, 4, 8, 6}
        };

        public List<int[,]> GetBoards()
        {
            collectionList.Add(board);
            collectionList.Add(board2);
            collectionList.Add(board3);

            return collectionList;
        }
    }
}