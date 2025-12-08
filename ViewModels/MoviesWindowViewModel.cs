using Alien_Universe_DB.Models;
using ReactiveUI;

namespace Alien_Universe_DB.ViewModels;

public class MoviesWindowViewModel : ViewModelBase
{
    public Movie SelectedMovie { get; set; }

    public MoviesWindowViewModel(Movie movie)
    {
        SelectedMovie = movie;
    }
}