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

        public bool PlaceLakeTileOnBoard(LakeTile lakeTile, int row, int column)
        {
            bool canLakeTileBePlayed = false;
            LanternsBoardTile boardTile = null;

            if (Board.Exists(tile => tile.Row == row && tile.Column == column))
            {
                boardTile = Board.Find(tile => tile.Row == row && tile.Column == column);
                canLakeTileBePlayed = CheckLegalLakeTilePlacement(boardTile, lakeTile, row, column);
            }

            if (canLakeTileBePlayed)
            {
                boardTile.TileId = lakeTile.TileId;
            }

            return canLakeTileBePlayed;
        }

        public bool CheckLegalLakeTilePlacement(LanternsBoardTile boardTile, LakeTile lakeTile, int row, int column)
        {
            if (boardTile.TileId != 0)
            {
                return false;
            }

            int numberOfAdjacentTiles = 0;

            numberOfAdjacentTiles += CheckAdjacentTile(row - 1, column);
            numberOfAdjacentTiles += CheckAdjacentTile(row, column - 1);
            numberOfAdjacentTiles += CheckAdjacentTile(row + 1, column);
            numberOfAdjacentTiles += CheckAdjacentTile(row, column + 1);

            if (numberOfAdjacentTiles > 0)
            {
                return true;
            }

            return false;
        }

        public int CheckAdjacentTile(int row, int column)
        {
            int returnValue = 0;

            if (Board.Exists(tile => (tile.Row == row ) && tile.Column == column))
            {
                var tempTile = Board.Find(tile => tile.Row == row && tile.Column == column);
                if (tempTile.TileId != 0)
                {
                    returnValue++;
                }
            }

            return returnValue;
        }

        public void PlaceInitialLakeTile(LakeTile lakeTile, int row, int column)
        {
            LanternsBoardTile boardTile = Board.Find(tile => tile.Row == row && tile.Column == column);
            boardTile.TileId = lakeTile.TileId;
        }
    }
}
