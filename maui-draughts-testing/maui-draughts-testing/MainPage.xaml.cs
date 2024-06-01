using Microsoft.Maui.Controls;

namespace maui_draughts_testing
{
  public partial class MainPage : ContentPage
  {
    private DraughtsViewModel _viewModel;

    public MainPage()
    {
      InitializeComponent();
      _viewModel = new DraughtsViewModel();
      BindingContext = _viewModel;
    }

    private void OnTapped(object sender, TappedEventArgs e)
    {
      if (e.GetPosition((View)sender) is Point touchPoint)
      {
        int row = (int)(touchPoint.Y / 50);
        int col = (int)(touchPoint.X / 50);

        _viewModel.ProcessMove(row, col);
        DraughtsGraphicsView.Invalidate();
      }
    }
  }
}
