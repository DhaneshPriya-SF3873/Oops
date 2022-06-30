namespace MovieTicketBooking
{
    public class MovieDetails
    {
        private static int _movieId=500;
         public string MovieId { get;  }
        public string MovieName { get; set; }
        public int NumberOfSeats { get; set; }
        public int TicketPrice { get; set; }
        
        public MovieDetails(string movieName,int numberOfSeats,int ticketPrice)
        {
            
             _movieId++;
             MovieId="MID"+_movieId;
            MovieName=movieName;
            NumberOfSeats=numberOfSeats;
            TicketPrice=ticketPrice;
            
        }
        
        
        
        
    }
}