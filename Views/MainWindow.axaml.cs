using System;
using System.Reactive;
using System.Reactive.Disposables;
using Alien_Universe_DB.ViewModels;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace Alien_Universe_DB.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    private MainWindowViewModel ViewModel { get; }
    private IDisposable? _disposable { get; }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    public MainWindow()
    {
        InitializeComponent();
        ViewModel = new MainWindowViewModel();
        DataContext = ViewModel;

        _disposable = null;
        this.Opened += (_, _) =>
        {
            ViewModel.ShowMovieWindow.RegisterHandler(async interaction =>
            {
                var win = new MoviesWindow
                {
                    DataContext = interaction.Input
                };

                await win.ShowDialog(this);
                interaction.SetOutput(Unit.Default);
            });
        };
    }
}