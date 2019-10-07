using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsApp.Models.Classes
{
    public class LanternsBoard
    {
        private int RowSize { get; set; }
        private int ColumnSize { get; set; }

        public List<LanternsBoardTile> Board { get; set; }

        public LanternsBoard(int rowSize, int columnSize)
        {
            RowSize = rowSize;
            ColumnSize = columnSize;
            Board = new List<LanternsBoardTile>();

            MakeGameBoard();
        }

        public void MakeGameBoard()
        {
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    Board.Add(new LanternsBoardTile(i, j));
                }
            }
        }
    }
}
