using Alien_Universe_DB.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace Alien_Universe_DB.Views;

public partial class MoviesWindow : ReactiveWindow<MainWindowViewModel>
{
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    public MoviesWindow()
    {
        InitializeComponent();
    }
}