using Alien_Universe_DB.ViewModels;
using Avalonia.ReactiveUI;

namespace Alien_Universe_DB.Views;

public partial class MoviesWindow : ReactiveWindow<MoviesWindowViewModel>
{
    public MoviesWindow()
    {
        InitializeComponent();
    }
}