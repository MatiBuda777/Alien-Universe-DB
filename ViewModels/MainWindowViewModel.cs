using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using Alien_Universe_DB.Models;
using Avalonia.Controls;
using ReactiveUI;

namespace Alien_Universe_DB.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Movie> Movies { get; } = MoviesDataViewModel.MovieList;

    private Movie? _selectedMovie;
    public Movie? SelectedMovie { 
        get => _selectedMovie;
        set => this.RaiseAndSetIfChanged(ref _selectedMovie, value);
    }

    public ReactiveCommand<Unit, Unit> ShowMovieCommand { get; }
    public Interaction<Movie, Unit> ShowMovieWindow { get; }

    public MainWindowViewModel()
    {
        ShowMovieWindow = new Interaction<Movie, Unit>();
        var canShow = this.WhenAnyValue(x => x.SelectedMovie)
            .Select(movie => movie != null);
        ShowMovieCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            Console.WriteLine("Opening Movie Window...");
            await ShowMovieWindow.Handle(_selectedMovie!);
        }, canShow);
    }

}