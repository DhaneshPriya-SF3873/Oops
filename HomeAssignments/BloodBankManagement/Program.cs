using System;
using System.Collections.Generic;
namespace BloodBankManagement
{
    class Program
    {
      static List<UserRegistration> bloodBank = new List<UserRegistration>();
       static List<DonateBlood> bloodBank1 = new List<DonateBlood>();

      static UserRegistration currentUser=null;
      static DonateBlood currentUser1=null;
        static void Main(string[] args)
        {
            int option;
            do{
            System.Console.WriteLine("Select the Main Menu");
            System.Console.WriteLine("1.User Registration\n2.User Login\n3.Fetch Donor Details\n4.Exit");
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
                    UserLogin();
                    break;
                }
                case 3:
                {
                    FetchDDonorDetails();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    break;
                }
            }
            }while(option!=4);
            

     static void UserRegistration()
    {
            System.Console.WriteLine("Enter the Donor Name: ");
            string donorName=Console.ReadLine();
            System.Console.WriteLine("Enter the Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Mobile Number: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Blood Group:"+"\n"+"1.APositive"+"\n"+"2.BPositive"+"\n"+"3.OPositive"+"\n"+"4.ABPositive");
            int bloodGroupName=int.Parse(Console.ReadLine());
            BloodGroup bloodGroup=BloodGroup.Default;
            while(!(bloodGroupName>=1 && bloodGroupName<5))
            {
            System.Console.WriteLine("Enter the Blood Group");
             bloodGroupName=int.Parse(Console.ReadLine());
            }
            bloodGroup=(BloodGroup)bloodGroupName;
            System.Console.WriteLine("Enter the Last Donation: ");
            DateTime lastDonation=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
            
           


           UserRegistration bloodbank1=new UserRegistration(donorName,age,mobileNumber,bloodGroup,lastDonation);
           bloodBank.Add(bloodbank1);


          

           

    }


    
    
        
    
     static void UserLogin()
    {
        System.Console.WriteLine("Enter the Donor Id");
        int donorId=int.Parse(Console.ReadLine());
        foreach(UserRegistration blood in bloodBank)
        {
            if(donorId==blood.DonorId)
            {
                System.Console.WriteLine("SubMenu");
                currentUser=blood;
                SubMenu();

            }
            else
            {
                System.Console.WriteLine("Invalid Donor Id\nPlease enter Valid one.");
            }
    


    
    static void SubMenu()
    {
        int option;
        do{

        
        System.Console.WriteLine("1.Donate Blood\n2.Donation History\n3.Next Eligibility date\n4.Exit");
        option=int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
            {
                currentUser1.DonateBlood1();
                break;
            }
            case 2:
            {
                currentUser.DonorDetails();
                break;
            }
            case 3:
            {
                currentUser.NextEligibilityDate();
                break;
            }
            case 4:
            {
                break;
            }
        }
        }while(option!=4);
    }



    
    
        }
    }
    
     static void FetchDDonorDetails()
    {
            System.Console.WriteLine("Enter the Blood Group:"+"\n"+"1.APositive"+"\n"+"2.BPositive"+"\n"+"3.OPositive"+"\n"+"4.ABPositive");
            int bloodGroupName=int.Parse(Console.ReadLine());
            BloodGroup bloodGroup=BloodGroup.Default;
            while(!(bloodGroupName>=1 && bloodGroupName<5))
            {
            System.Console.WriteLine("Enter the Blood Group");
             bloodGroupName=int.Parse(Console.ReadLine());
            }
            bloodGroup=(BloodGroup)bloodGroupName;
        foreach(UserRegistration blood in bloodBank)
        if(bloodGroup==blood.BloodGroup)
        {   
             currentUser=blood; 
            System.Console.WriteLine("Your name: "+blood.DonorName+"\n"+"Your Mobile Number: "+blood.MobileNumber);
           
        }
    }
            


       } 
        
                
    }
    
}