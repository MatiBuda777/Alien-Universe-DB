using Alien_Universe_DB.ViewModels;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace Alien_Universe_DB.Views;

public partial class CharactersWindow : ReactiveWindow<CharactersWindowViewModel>
{
    public CharactersWindow()
    {
        InitializeComponent();
    }
}