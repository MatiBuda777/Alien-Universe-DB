using System.Reactive.Disposables;
using Alien_Universe_DB.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace Alien_Universe_DB.Views;

public partial class MoviesWindow : ReactiveWindow<MoviesWindowViewModel>
{
    public MoviesWindow()
    {
        InitializeComponent();
    }
}