namespace maui_draughts_testing
{
  public enum PieceType { None, Man, King }
  public enum Player { None, Black, White }

  public class Piece
  {
    public PieceType Type { get; set; }
    public Player Owner { get; set; }
  }
}
