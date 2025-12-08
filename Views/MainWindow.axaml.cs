using System;
using System.Reactive;
using System.Reactive.Disposables;
using Alien_Universe_DB.Models;
using Alien_Universe_DB.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace Alien_Universe_DB.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();

        this.WhenActivated((CompositeDisposable disposables) =>
        {
            ViewModel!.ShowMovieWindow.RegisterHandler(async interaction =>
            {
                var win = new MoviesWindow()
                {
                    DataContext = interaction.Input
                };
                Console.WriteLine(interaction.Input);

                await win.ShowDialog(this);
                interaction.SetOutput(Unit.Default);
            }).DisposeWith(disposables);
        });
    }
}