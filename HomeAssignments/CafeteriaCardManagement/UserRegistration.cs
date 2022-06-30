namespace CafeteriaCardManagement
{
    public class UserRegistration
    { 
        private static int  s_userId=1000;
        
        public string UserId { get;  }
        private static int s_workStationNumber=100;
        public string WorkStationNumber { get; set; }
        
        
        public string UserName { get; set; }
        public long MobileNumber{ get; set; }
        public double Balance { get; set; }


        public UserRegistration(string userName,long mobileNumber,double balance)
        {
            s_userId++;
            UserId="SF"+s_userId;
            s_workStationNumber++;
            WorkStationNumber="WS"+s_workStationNumber;
            UserName=userName;
            MobileNumber=mobileNumber;
            Balance=balance;
        }
        
        
        
        
        
        
    }
}