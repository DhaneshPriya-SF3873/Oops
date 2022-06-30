namespace OnlineLibraryManagement
{
    public enum Gender{Default,Male,Feamle,Transgender}
    public class UserDetails
    {
        private static int s_userId=3000; 
        public string UserId { get;  }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Department { get; set; }
        public long MobileNumber { get; set; }
        public string MailId { get; set; }
        public UserDetails(string name, int age ,Gender gender,string department,long mobileNumber,string mailId)
        {
            s_userId++;
            UserId="SF"+s_userId;
            Name=name;
            Age=age;
            Gender=gender;
            Department=department;
            MobileNumber=mobileNumber;
            MailId=mailId;

        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}