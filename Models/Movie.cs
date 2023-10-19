namespace MovieApp.Models;

    public class Rating
    {
        public string Source { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }

    public class Movie
    {
        public string Title { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Rated { get; set; } = string.Empty;
        public string Released { get; set; } = string.Empty;
        public string Runtime { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public string Writer { get; set; } = string.Empty;
        public string Actors { get; set; } = string.Empty;
        public string Plot { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Awards { get; set; } = string.Empty;
        public string Poster { get; set; } = string.Empty;
        public List<Rating>? Ratings { get; set; }
        public string Metascore { get; set; } = string.Empty;
        public string imdbRating { get; set; } = string.Empty;
        public string imdbVotes { get; set; } = string.Empty;
        public string imdbID { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string DVD { get; set; } = string.Empty;
        public string BoxOffice { get; set; } = string.Empty;
        public string Production { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public string Response { get; set; } = string.Empty;
    }

