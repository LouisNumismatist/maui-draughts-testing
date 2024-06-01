namespace maui_draughts_testing
{
  public class DraughtsBoard
  {
    public Piece[,] Board { get; private set; }
    public Piece SelectedPiece { get; set; } // Add a property to track the selected piece.

    public DraughtsBoard()
    {
      Board = new Piece[8, 8];
      InitializeBoard();
    }

    private void InitializeBoard()
    {
      for (int row = 0; row < 8; row++)
      {
        for (int col = 0; col < 8; col++)
        {
          if (row < 3 && (row + col) % 2 != 0)
            Board[row, col] = new Piece { Owner = Player.Black, Type = PieceType.Man };
          else if (row > 4 && (row + col) % 2 != 0)
            Board[row, col] = new Piece { Owner = Player.White, Type = PieceType.Man };
          else
            Board[row, col] = new Piece { Owner = Player.None, Type = PieceType.None };
        }
      }
    }
  }
}
