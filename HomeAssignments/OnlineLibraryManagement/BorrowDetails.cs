using System;
namespace OnlineLibraryManagement
{
    public class BorrowDetails
    {
        private static int s_borrowId=300;
        public string BorrowId { get; }
        public string BookId { get; }
        public string UserId { get;  }

        public DateTime BorrowedDate  { get; set; }


        public BorrowDetails(string bookId,string userId,DateTime borrowedDate)
        {
            s_borrowId++;
            BorrowId="LB"+s_borrowId;
            BookId=bookId;
            UserId=userId;
            BorrowedDate=borrowedDate;
            
        }
        
        
        
        
        
        
    }
}