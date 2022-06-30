namespace MovieTicketBooking
{
    public enum BookingStatus{Default,Booked,Cancelled}
    public class BookingDetails
    {
      private static int _bookingId=700;
       public string BookingId { get;  }
 
 
      public string UserId { get;  }
       public string TheatreId { get; }
        public string MovieId { get;}
        public int NumberOfSeats { get; set; }
        public double TotalPrice { get; set; }
        public BookingStatus BookingStatus { get; set; }
        
        public BookingDetails(string userId ,string movieId,string theatreId,int numberOfSeats,double totalPrice,BookingStatus bookingStatus )
        {
            _bookingId++;
            BookingId="BID"+_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theatreId;
             NumberOfSeats=numberOfSeats;
             TotalPrice=totalPrice;
             BookingStatus=bookingStatus;
            

        }
        
        
        

        
        
    }
}