using System;
using System.Reactive;
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
        
        this.WhenActivated((CompositeDisposable disposables) =>
        {
            ViewModel!.ShowCharacterWindow.RegisterHandler(async interaction =>
            {
                var win = new CharactersWindow()
                {
                    DataContext = new CharactersWindowViewModel(interaction.Input),
                };
                Console.WriteLine(interaction.Input);

                await win.ShowDialog(this);
                interaction.SetOutput(Unit.Default);
            }).DisposeWith(disposables);
        });
    }
}