using MovieDatabase;

bool keepRunning = true;

do
{
    // Create a list of 10 movies

    List<Movie> moviesList = new List<Movie>();
    moviesList.Add(new Movie("The God Father", "drama"));
    moviesList.Add(new Movie("Cars", "animated"));
    moviesList.Add(new Movie("The Departed", "drama"));
    moviesList.Add(new Movie("The Lion King", "animated"));
    moviesList.Add(new Movie("Finding Nemo", "animated"));
    moviesList.Add(new Movie("The Mummy", "drama"));
    moviesList.Add(new Movie("The Matrix", "scifi"));
    moviesList.Add(new Movie("Top Gun", "drama"));
    moviesList.Add(new Movie("White Chicks", "drama"));
    moviesList.Add(new Movie("The Ring", "horror"));

    //count of movies
    int amtOfMovies = moviesList.Count();

    Console.WriteLine("Welcome to the Movie List Application!");
    Console.WriteLine("There are " + amtOfMovies + " movies in this collection");

    Console.WriteLine("Please enter one of the following categories to display movie List \n 1) animated\n 2) drama\n 3) horror\n 4) scifi\n");

    string genreSelected = Console.ReadLine().ToLower();
    //print movie details for that category

    List<Movie> relatedMovieList = moviesList.Where(x => x.Category == genreSelected).ToList();

    foreach (Movie m in relatedMovieList)
    {
        Console.WriteLine(m.Title);
    }
    Console.WriteLine();



    Console.WriteLine("Continue? (y/n)");
    string response = Console.ReadLine().ToLower();

    if (response == "y")

    {
        keepRunning = true;

    }

    else if (response == "n")
    {
        keepRunning = false;
    }
    else Console.WriteLine("Please enter a y or n");

} while (keepRunning);