namespace OnlineDTHRecharge
{
    public class UserRegistration
    {
        private static int s_userId=1000;
        public string UserId { get; }
        public string UserName { get; set; }
        public long MobileNumber { get; set; }
        public string EmailId { get; set; }
        public double WalletBalance { get; set; }
        
        
        public UserRegistration(string userName,long mobileNumber,string emailId,double walletBalance)
        {
            s_userId++;
            UserId="UID"+s_userId;
            UserName=userName;
            MobileNumber=mobileNumber;
            EmailId=emailId;
            WalletBalance=walletBalance;
        }
        
        
        
    }
}