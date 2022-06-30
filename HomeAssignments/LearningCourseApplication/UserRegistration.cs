namespace LearningCourseApplication
{
    public class UserRegistration
    {
        private static int s_userId=3000;
        public string UserId { get;  }
       public string Name { get; set; }
        public string EmailId { get; set; }
        public long PhoneNumber { get; set; }
        public string Gender { get; set; }

        public double WalletBalance { get; set; }
        
        

        public UserRegistration(string name,string emailId,long phoneNumber,string gender,double walletBalance )
        {
            s_userId++;
            UserId="SF"+s_userId;
            Name=name;
            EmailId=emailId;
            PhoneNumber=phoneNumber;
            Gender=gender;
            WalletBalance=walletBalance;

        }
        

        
        
        
        
        
        
    }
}