using System;
using Alien_Universe_DB.Models;
using ReactiveUI;

namespace Alien_Universe_DB.ViewModels;

public class MoviesWindowViewModel : ViewModelBase
{
    private Movie? _selectedMovie;
    public Movie? SelectedMovie 
    {
        get => _selectedMovie;
        set => this.RaiseAndSetIfChanged(ref _selectedMovie, value);
    }

    public MoviesWindowViewModel(Movie movie)
    {
        Console.WriteLine("Creating Movie Window...");
        SelectedMovie = movie;
        Console.WriteLine(SelectedMovie);
    }
}