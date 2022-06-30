using System.Collections.Generic;
namespace MovieTicketBooking
{
    public class TheatreDetails
    {
        private static int _theatreId=300;
         public string TheatreId { get;  }
        public string TheatreName { get; set; }

        public List<MovieDetails> MovieList{get; set;}
        
        public TheatreDetails(string theatreName,List<MovieDetails> movieList)
        {
            _theatreId++;
            TheatreId="TID"+_theatreId;
            TheatreName=theatreName;
            MovieList=movieList;




        }
    }
}