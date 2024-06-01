namespace maui_draughts_testing
{
  public class DraughtsDrawable : IDrawable
  {
    private const int CellSize = 50;
    private readonly DraughtsBoard _board;

    public DraughtsDrawable(DraughtsBoard board)
    {
      _board = board;
    }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
      for (int row = 0; row < 8; row++)
      {
        for (int col = 0; col < 8; col++)
        {
          DrawCell(canvas, row, col);
          DrawPiece(canvas, row, col);
        }
      }
    }

    private void DrawCell(ICanvas canvas, int row, int col)
    {
      var color = (row + col) % 2 == 0 ? Colors.White : Colors.Black;
      canvas.FillColor = color;
      canvas.FillRectangle(col * CellSize, row * CellSize, CellSize, CellSize);
    }

    private void DrawPiece(ICanvas canvas, int row, int col)
    {
      var piece = _board.Board[row, col];
      if (piece.Owner == Player.None) return;

      var pieceColor = piece.Owner == Player.Black ? Colors.Black : Colors.White;
      canvas.FillColor = pieceColor;
      canvas.FillCircle(col * CellSize + CellSize / 2, row * CellSize + CellSize / 2, CellSize / 2 - 5);

      if (piece.Type == PieceType.King)
      {
        canvas.StrokeColor = Colors.Gold;
        canvas.StrokeSize = 2;
        canvas.DrawCircle(col * CellSize + CellSize / 2, row * CellSize + CellSize / 2, CellSize / 2 - 10);
      }
    }
  }
}
