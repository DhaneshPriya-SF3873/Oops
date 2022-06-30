namespace MovieTicketBooking
{
    public class UserDetails
    {
        private static int _userId=1000;
        public string UserId { get;  }
        public string Name { get; set; }
        public int Age { get; set; }
        public long PhoneNumber { get; set; }
        public double WalletBalance { get; set; }


        public UserDetails(string name,int age,long phoneNumber,double walletBalance)
        {
            _userId++;
            UserId="UID"+_userId;
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
            WalletBalance=walletBalance;
        }
        
        
        
        
        
        
        
        

        
        
        
    }
}