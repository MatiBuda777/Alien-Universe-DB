using System;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using Alien_Universe_DB.Models;
using ReactiveUI;

namespace Alien_Universe_DB.ViewModels;

public class CharactersWindowViewModel : ViewModelBase
{
    private Character? _selectedCharacter;
    private Movie? _selectedMovie;
    
    public Character? SelectedCharacter
    {
        get => _selectedCharacter;
        set => this.RaiseAndSetIfChanged(ref _selectedCharacter, value);
    }
    
    public Movie? SelectedMovie 
    {
        get => _selectedMovie;
        set => this.RaiseAndSetIfChanged(ref _selectedMovie, value);
    }

    public ReactiveCommand<Unit, Unit> ShowMovieCommand { get; }
    public Interaction<Movie, Unit> ShowMovieWindow { get; }

    public CharactersWindowViewModel(Character character)
    {
        // data from Movie to Character Window
        Console.WriteLine("Creating Movie Window...");
        SelectedCharacter = character;
        Console.WriteLine(SelectedCharacter);
        
        // going from Character to Movie Window
        ShowMovieWindow = new Interaction<Movie, Unit>();
        var canShow = this.WhenAnyValue(x => x.SelectedMovie)
            .Select(movie => movie != null);
        ShowMovieCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            Console.WriteLine("Opening Movie Window...");
            var findMovie = MoviesDataViewModel.MovieList.FirstOrDefault(m => m == SelectedMovie);
            if (findMovie != null) await ShowMovieWindow.Handle(findMovie);
        }, canShow);
    }
}