using System;
using System.Reactive;
using System.Reactive.Linq;
using Alien_Universe_DB.Models;
using ReactiveUI;

namespace Alien_Universe_DB.ViewModels;

public class MoviesWindowViewModel : ViewModelBase
{
    private Movie? _selectedMovie;
    private Character? _selectedCharacter;
    
    
    public Movie? SelectedMovie 
    {
        get => _selectedMovie;
        set => this.RaiseAndSetIfChanged(ref _selectedMovie, value);
    }
    
    public Character? SelectedCharacter
    {
        get => _selectedCharacter;
        set => this.RaiseAndSetIfChanged(ref _selectedCharacter, value);
    }
    
    public ReactiveCommand<Unit, Unit> ShowCharacterCommand { get; }
    public Interaction<Character, Unit> ShowCharacterWindow { get; }
    

    public MoviesWindowViewModel(Movie movie)
    {
        // data from Main to Movie Window
        Console.WriteLine("Creating Character Window...");
        SelectedMovie = movie;
        Console.WriteLine(SelectedMovie);
        
        // going from Movie to Character Window
        ShowCharacterWindow = new Interaction<Character, Unit>();
        var canShow = this.WhenAnyValue(x => x.SelectedCharacter)
            .Select(character => character != null);
        ShowCharacterCommand = ReactiveCommand.CreateFromTask(async () => 
        {
            Console.WriteLine("Creating Character Window...");
            await ShowCharacterWindow.Handle(_selectedCharacter!);
        }, canShow);
    }
}