using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace maui_draughts_testing
{
  public class DraughtsViewModel : INotifyPropertyChanged
  {
    private DraughtsBoard _board;
    public DraughtsDrawable DraughtsDrawable { get; }

    public DraughtsViewModel()
    {
      _board = new DraughtsBoard();
      DraughtsDrawable = new DraughtsDrawable(_board);
    }

    public void ProcessMove(int row, int col)
    {
      // Implement the logic for selecting, moving pieces, and capturing.
      // For example, let's implement simple piece selection logic.

      if (_board.Board[row, col].Owner != Player.None)
      {
        // Assuming piece selection logic is added here.
        _board.SelectedPiece = _board.Board[row, col];
      }

      // For now, just logging the move for debugging purposes.
      System.Diagnostics.Debug.WriteLine($"Tapped on row {row}, col {col}");
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
