using System;
namespace BloodBankManagement
{
    public enum BloodGroup{Default,Apositive,Bpositive,OPositive,ABPositive}
    public class UserRegistration
    {
        private static int s_donorId=1000;

        public int  DonorId { get; set; }
        
        
        
        
        public string DonorName { get; set; }
        public int Age { get; set; }
        public long MobileNumber { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public DateTime LastDonation { get; set; }
        
        
        
        
        
        
        
        
        
        public UserRegistration(string donorName,int age, long mobileNumber,BloodGroup bloodGroup,DateTime lastDonation)
        {
            s_donorId++;
            DonorId=s_donorId;
            DonorName=donorName;
            Age=age;
            MobileNumber=mobileNumber;
            BloodGroup=bloodGroup;
            LastDonation=lastDonation;
        }


        public void DonorDetails()
        {
            System.Console.WriteLine("Your Donor Id:"+DonorId+"\n"+"Your Name:"+DonorName+"\n"+"Your age:"+Age+"\n"+"Your Mobile number:"+MobileNumber+"\n"+"Your Blood Group:"+BloodGroup+"\n"+"Your Last Donation:"+LastDonation);
        }

        public void NextEligibilityDate()
        {
         System.Console.WriteLine(LastDonation.AddMonths(3));
        }
    }
}