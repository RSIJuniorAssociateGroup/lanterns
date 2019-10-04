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

        public List<BoardTile> Board { get; set; }

        public LanternsBoard(int rowSize, int columnSize)
        {
            RowSize = rowSize;
            ColumnSize = columnSize;
            Board = new List<BoardTile>();

            MakeGameBoard();
            PlaceAndTestLakeTile();
        }

        public void MakeGameBoard()
        {
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    Board.Add(new BoardTile(i, j));
                }
            }
        }

        private void PlaceAndTestLakeTile()
        {
            
            int row = 1;
            int column = 1;

            BoardTile tile = Board.Find(t => t.Row == row && t.Column == column);

            tile.ReceivedTile(new LakeTile(555, "red", "green", "yellow", "blue"));

            Console.WriteLine(tile.TileId);
        }
    }
}
