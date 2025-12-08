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
    public ObservableCollection<Movie> Movies { get; } = new()
    {
        new Movie
        {
            OriginalTitle = "Alien",
            PolishTitle = "Obcy – ósmy pasażer Nostromo",
            ReleaseYear = 1979,
            Director = "Ridley Scott",
            Screenwriter = "Dan O’Bannon",
            Genre = "Sci-Fi / Horror",
            DurationMinutes = 117,
            ImdbRating = 8.5,
            MainCharacters = new List<string> { "Ellen Ripley", "Dallas", "Ash", "Lambert", "Kane" },
            ShipName = "USCSS Nostromo",
            PlotSummary = "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety. Po lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
            Trivia = "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne."
        },
        new Movie
        {
            OriginalTitle = "Aliens",
            PolishTitle = "Obcy – decydujące starcie",
            ReleaseYear = 1986,
            Director = "James Cameron",
            Screenwriter = "James Cameron, David Giler, Walter Hill",
            Genre = "Sci-Fi / Akcja / Horror",
            DurationMinutes = 137,
            ImdbRating = 8.4,
            MainCharacters = new List<string> { "Ellen Ripley", "Hicks", "Newt", "Bishop", "Vasquez" },
            ShipName = "USS Sulaco",
            PlotSummary = "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            Trivia = "James Cameron napisał scenariusz podczas lotu do Londynu, tworząc tytuł, który jest liczbą mnogą słowa „Alien” – symbolicznie zapowiadając, że tym razem potworów będzie więcej."
        },
        new Movie
        {
            OriginalTitle = "Alien³",
            PolishTitle = "Obcy³",
            ReleaseYear = 1992,
            Director = "David Fincher",
            Screenwriter = "David Giler, Walter Hill, Larry Ferguson",
            Genre = "Sci-Fi / Horror",
            DurationMinutes = 114,
            ImdbRating = 6.5,
            MainCharacters = new List<string> { "Ellen Ripley", "Dillon", "Clemens", "Morse", "Andrews" },
            ShipName = "E.E.V. z USS Sulaco",
            PlotSummary = "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161, gdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie wśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
            Trivia = "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą, a produkcja była pełna konfliktów – reżyser później odciął się od tego projektu."
        },
        new Movie
        {
            OriginalTitle = "Alien: Resurrection",
            PolishTitle = "Obcy: Przebudzenie",
            ReleaseYear = 1997,
            Director = "Jean-Pierre Jeunet",
            Screenwriter = "Joss Whedon",
            Genre = "Sci-Fi / Horror",
            DurationMinutes = 109,
            ImdbRating = 6.2,
            MainCharacters = new List<string> { "Ellen Ripley (klon)", "Call", "Johner", "Christie", "Dr. Gediman" },
            ShipName = "USM Auriga",
            PlotSummary = "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała. Klonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników musi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
            Trivia = "Postać androidki Call gra Winona Ryder, a film miał początkowo być początkiem nowej trylogii, która jednak nigdy nie powstała."
        },
        new Movie
        {
            OriginalTitle = "Prometheus",
            PolishTitle = "Prometeusz",
            ReleaseYear = 2012,
            Director = "Ridley Scott",
            Screenwriter = "Jon Spaihts, Damon Lindelof",
            Genre = "Sci-Fi / Thriller",
            DurationMinutes = 124,
            ImdbRating = 7.0,
            MainCharacters = new List<string> { "Elizabeth Shaw", "David", "Charlie Holloway", "Meredith Vickers" },
            ShipName = "USCSS Prometheus",
            PlotSummary = "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości. Na miejscu załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś, co nigdy nie powinno zostać obudzone.",
            Trivia = "Ridley Scott planował, aby film stanowił zarówno prequel „Obcego”, jak i samodzielną opowieść o powstaniu życia i człowieka – wiele elementów łączy się z mitologią obcych w sposób pośredni."
        },
        new Movie
        {
            OriginalTitle = "Alien: Covenant",
            PolishTitle = "Obcy: Przymierze",
            ReleaseYear = 2017,
            Director = "Ridley Scott",
            Screenwriter = "John Logan, Dante Harper",
            Genre = "Sci-Fi / Horror",
            DurationMinutes = 122,
            ImdbRating = 6.4,
            MainCharacters = new List<string> { "Daniels", "David", "Walter", "Oram", "Tennessee" },
            ShipName = "USCSS Covenant",
            PlotSummary = "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia. Na miejscu natrafiają jednak na Davida – syntetyka ocalałego z Prometeusza – oraz nowe formy obcych stworzeń, które mogą zakończyć ludzką ekspansję w kosmosie.",
            Trivia = "Film pierwotnie miał być zatytułowany „Paradise Lost”, a reżyser planował jeszcze jedną część łączącą fabułę z oryginalnym „Obcym” z 1979 roku."
        }
    };

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