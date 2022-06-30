using System;
using System.Collections.Generic;
namespace MovieTicketBooking
{
    class Program
    {
       static List<UserDetails> userDetailsList=new List<UserDetails>();
        static List<MovieDetails> movieList1=new List<MovieDetails>();
        static List<MovieDetails> movieList2=new List<MovieDetails>();
        static List<MovieDetails> movieList3=new List<MovieDetails>();
        static List<TheatreDetails> theatreList=new List<TheatreDetails>();
        
        static List<BookingDetails> bookingList=new List<BookingDetails>();
         static UserDetails currentUser=null;

        public static void Main(string[] args)
        {
             AddDefaultData();
             ShowMainMenu();
                    
            

        }
       

       public static void UserRegistration()
         {
             System.Console.WriteLine("Enter the Name: ");
             string name=Console.ReadLine();
             System.Console.WriteLine("Enter the Age: ");
             int age=int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter the Phone Number: ");
             long phoneNumber=long.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter the Wallet Balance: ");
             double walletBalance=double.Parse(Console.ReadLine());


             UserDetails userRegistration=new UserDetails(name,age,phoneNumber,walletBalance);
             userDetailsList.Add(userRegistration);
             System.Console.WriteLine("Your user Id: "+userRegistration.UserId);
             
             
             
         }

         public static void AddDefaultData()
         {
             UserDetails user1=new UserDetails("Ravichandran",30,8599488003,1000);
           UserDetails user2=new UserDetails("Baskaran",30,9857747327,2000);
           userDetailsList.Add(user1);
           userDetailsList.Add(user2);
           MovieDetails movie1=new MovieDetails("Movie1",5,200);
           MovieDetails movie2=new MovieDetails("Movie2",5,300);
           MovieDetails movie3=new MovieDetails("Movie3",1,50);
           movieList1.Add(movie1);
           movieList1.Add(movie2);
           movieList1.Add(movie3);
           MovieDetails movie4=new MovieDetails("Movie4",11,400);
           MovieDetails movie5=new MovieDetails("Movie5",20,300);
           MovieDetails movie6=new MovieDetails("Movie6",2,500);
           movieList2.Add(movie4);
           movieList2.Add(movie5);
           movieList2.Add(movie6);
           MovieDetails movie7=new MovieDetails("Movie7",11,100);
           MovieDetails movie8=new MovieDetails("Movie8",20,200);
           MovieDetails movie9=new MovieDetails("Movie9",2,350);
           movieList3.Add(movie7);
           movieList3.Add(movie8);
           movieList3.Add(movie9);

           TheatreDetails theatre1=new TheatreDetails("Theatre1",movieList1);
           TheatreDetails theatre2=new TheatreDetails("Theatre2",movieList2);
           TheatreDetails theatre3=new TheatreDetails("Theatre1",movieList3);
           theatreList.Add(theatre1);
           theatreList.Add(theatre2);
           theatreList.Add(theatre3);

         BookingDetails booking1=new BookingDetails("UID1001","MID501","TID301",1,200,BookingStatus.Booked);
         BookingDetails booking2=new BookingDetails("UID1001","MID504","TID302",1,400,BookingStatus.Booked);
         BookingDetails booking3=new BookingDetails("UID1002","MID505","TID302",1,300,BookingStatus.Booked);
         bookingList.Add(booking1);
         bookingList.Add(booking2);
         bookingList.Add(booking3);
         }

    public static  void ShowMainMenu()
    {
     int option;
            string choice="yes";
           do
           {
           System.Console.WriteLine("Select the Main Menu:");
           System.Console.WriteLine("1.Registration 2.Login 3.Exit");
           option=int.Parse(Console.ReadLine());
          

           switch (option)
           {
               case 1:
               {
                   UserRegistration();
                   break;
               }
               case 2:
               {
                   Login();
                   break;
               }
               case 3:
               {
                   choice="no";
                   break;
               }
           }
           
           }while(choice=="yes");


    }

       public static void Login()
       {
           System.Console.WriteLine("Enter the User Id: ");
           string userId1=Console.ReadLine();
           foreach(UserDetails user in userDetailsList)
           {
               if(userId1==user.UserId)
               {
                   currentUser=user;
                   ShowSubMenu();
                   
               }
           }
           
       }
        public static void ShowSubMenu()
        {
            int option;
            do
            {
          System.Console.WriteLine("1.Ticket Booking\n2.Ticket Cancellation\n3.Booking History\n4.Wallet Recharge\n5.Exit");
           option=int.Parse(Console.ReadLine());
          switch (option)
          {
              case 1:
              {
                  TicketBooking();
                  break;
              }
              case 2:
              {
                 TicketCancellation();
                  break;
              }
              case 3:
              {
                  BookingHistory();
                  break;
              }
              case 4:
              {
                  WalletRecharge();
                  break;
              }
              case 5:
              {
                  break;
              }
          }
            }while(option!=5);
          
        }

        public static void TicketBooking()
        {
           foreach(TheatreDetails theatres in theatreList)
         {
             
             System.Console.WriteLine("The Theatre Id:"+theatres.TheatreId+"\n"+"TheatreName: "+theatres.TheatreName);
             
         }

         System.Console.WriteLine("Select the theatre Id");
         string theatreId=Console.ReadLine();
         foreach(TheatreDetails theatres in theatreList)
         {
             if(theatreId==theatres.TheatreId)
             {
                 foreach(MovieDetails movies in theatres.MovieList)
                {
                    System.Console.WriteLine("Movie Id: "+movies.MovieId+"\n"+"Movie Name: "+movies.MovieName +"\n"+"Number of seats:"+movies.NumberOfSeats+"\n"+"Ticket Price: "+movies.TicketPrice);
                }
                  
            System.Console.WriteLine("Select the Movie Id: ");
            string movieId=Console.ReadLine();
           foreach(MovieDetails movies in theatres.MovieList)
           {
           if(movieId==movies.MovieId)
           {
               System.Console.WriteLine("Enter the number of seats");
               int numberOfSeats=int.Parse(Console.ReadLine());
               if(numberOfSeats<movies.NumberOfSeats)
               {
                  double totalPrice=numberOfSeats*movies.TicketPrice;
                  if(totalPrice<currentUser.WalletBalance)
                  {
                      currentUser.WalletBalance=currentUser.WalletBalance-totalPrice;
                      movies.NumberOfSeats=movies.NumberOfSeats-numberOfSeats;
                      BookingDetails booked=new BookingDetails(currentUser.UserId,movies.MovieId,theatres.TheatreId,numberOfSeats,totalPrice, BookingStatus.Booked);
            bookingList.Add(booked);
            System.Console.WriteLine("Booked Successful");
            System.Console.WriteLine("Your Booking Id: "+booked.BookingId);
                  }
                  else
                  {
                      System.Console.WriteLine("Insufficent Balance\n please recharge.");
                  }
               }
               else
               {
                   System.Console.WriteLine("Seats are not available");
               }
               
         
       
           
               
      
       
            
             }
  } 
    }
                }  
        
        }

        public static void TicketCancellation()
        {
            BookingHistory();
            System.Console.WriteLine("Select the Booking Id:");
            string bookingId=Console.ReadLine();
           foreach(BookingDetails books in bookingList)
           {
               if(bookingId==books.BookingId && books.BookingStatus==BookingStatus.Booked)
               {
                  foreach(TheatreDetails theatres in theatreList)
               { 
                  if(books.TheatreId==theatres.TheatreId)
                  {
                      foreach(MovieDetails movies in theatres.MovieList)
                      {
                          if(movies.MovieId==books.MovieId)
                          {
                          movies.NumberOfSeats=movies.NumberOfSeats-books.NumberOfSeats;
                          currentUser.WalletBalance=currentUser.WalletBalance+books.TotalPrice;
                          books.BookingStatus=BookingStatus.Cancelled;
                          System.Console.WriteLine("Your booking Cancelled");

                          }
                      }
                  }
                 
             }
               }
           }
        }
        public static void BookingHistory()
        {
           foreach(BookingDetails books in bookingList)
         {
             if(currentUser.UserId==books.UserId)
             {
              System.Console.WriteLine("User Id:"+books.UserId+"\n"+"Movie Id: "+books.MovieId+"\n"+"Theatre Id: "+books.TheatreId+"\n"+"Number of Seats: "+books.NumberOfSeats+"\n"+"Total Price: "+books.TotalPrice+"\n"+"Booking Status: "+books.BookingStatus);
             }
             
         }
        }
        public static void WalletRecharge()
        {
         System.Console.WriteLine("Wallet Balance:"+currentUser.WalletBalance);
         System.Console.WriteLine("Do you want to recharge(yes/no)");
         string recharge=Console.ReadLine().ToLower();
         if(recharge=="yes")
         {
            System.Console.WriteLine("Enter the amount: ");
            double amount=double.Parse(Console.ReadLine());
            
             currentUser.WalletBalance=currentUser.WalletBalance+amount;
             System.Console.WriteLine("Your amount: "+currentUser.WalletBalance);

         }
        }
                
    }
    
}