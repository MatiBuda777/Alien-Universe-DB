using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Alien_Universe_DB.Views;

public partial class CharactersWindow : Window
{
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public CharactersWindow()
    {
        InitializeComponent();
    }
}