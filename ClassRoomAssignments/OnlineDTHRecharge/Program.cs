using System;
using System.Collections.Generic;
using System.IO;
namespace OnlineDTHRecharge
{
    class program
    {
        
        static List<UserRegistration> userRegistrationDetailsList=new List<UserRegistration>();
        static List<PackDetail> packDetailList=new List<PackDetail>();
        static List<RechargeHistory> rechargeDetailList=new List<RechargeHistory>();
        static UserRegistration currentUser=null;
        public static void Main(string[] args)
        {
            AddDefaultData();
            MainMenu();

        }


        public static void AddDefaultData()
        {
           UserRegistration user1=new UserRegistration("John",9746646466,"john@gmail.com",500);
            UserRegistration user2=new UserRegistration("Merlin",9782136543,"merlin@gmail.com",150);
            userRegistrationDetailsList.Add(user1);
            userRegistrationDetailsList.Add(user2);


            PackDetail pack1=new PackDetail("RC150","Pack1",150,28,50);
            PackDetail pack2=new PackDetail("RC300","Pack2",300,56,75);
            PackDetail pack3=new PackDetail("RC500","Pack3",500,28,200);
            PackDetail pack4=new PackDetail("RC1500","Pack4",1500,365,200);
            packDetailList.Add(pack1);
            packDetailList.Add(pack2);
            packDetailList.Add(pack3);
            packDetailList.Add(pack4);



            RechargeHistory recharge1=new RechargeHistory("RC150","UID1001",new DateTime(29/11/2021),new DateTime(27/12/2021));
            RechargeHistory recharge2=new RechargeHistory("RC150","UID1002",new DateTime(01/01/2022),new DateTime(28/01/2022));
            rechargeDetailList.Add(recharge1);
            rechargeDetailList.Add(recharge2);
            

        }

        public static void MainMenu()
        {
            int option;
            do
             {
            System.Console.WriteLine("Select the MainMenu");
            System.Console.WriteLine("1.User Registration\n2.UserLogin\n3.Exit");
            option=int.Parse(Console.ReadLine());
            switch(option)
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
                    break;
                }
            }
        }while(option!=3);
        }

    public static void UserRegistration()
    {
        System.Console.WriteLine("Enter Your Name: ");
        string userName=Console.ReadLine();
        System.Console.WriteLine("Eneter Your Mobile Number: ");
        long mobileNumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Your EMailId: ");
        string emailId=Console.ReadLine();
        System.Console.WriteLine("Enter Your Wallet Balance: ");
        double walletBalance=double.Parse(Console.ReadLine());


        UserRegistration user=new UserRegistration(userName,mobileNumber,emailId,walletBalance);
        userRegistrationDetailsList.Add(user);
        System.Console.WriteLine("Your User Id: "+user.UserId);
        
        
    }

    public static void UserLogin()
    {
        System.Console.WriteLine("Enter Your User Id: ");
        string userId=Console.ReadLine();
        foreach(UserRegistration users in userRegistrationDetailsList)
        {
            if(userId==users.UserId)
            {
               currentUser=users;
               SubMenu();
            }
        }
    }
    
   public static void SubMenu()
   {
       int option;
       do{
       System.Console.WriteLine("1.Current Pack\n2.Pack Recharge\n3.Wallet Recharge\n4.View Pack Recharge History\n5.Exit");
       option=int.Parse(Console.ReadLine());
       switch(option)
       {
           case 1:
           {
               CurrentPack();
               break;
           }
           case 2:
           {
               PackRecharge();
               break;
           }
           case 3:
           {
               WalletRecharge();
               break;
           }
           case 4:
           {
               ViewPackHistoryDetail();
               break;
           }
           case 5:
           {
              
              break;
           }
       }
       
       }while(option!=5);
    }

     public static void PackRecharge()
     {
         foreach(PackDetail packs in packDetailList)
         {
             System.Console.WriteLine("Pack Id: "+packs.PackId+"\n"+"Pack Name: "+packs.PackName+"\n"+"Price:" +packs.Price+"\n"+"Validity: "+packs.Validity+"\n"+"Number of Channels: "+packs.NumberOfChannels);
         }
            System.Console.WriteLine("Enter the Pack Id: ");
            string packId=Console.ReadLine();
             foreach(PackDetail packs in packDetailList)
             {
            if(packId==packs.PackId)
            {
                if(currentUser.WalletBalance>=packs.Price)
                {
                    currentUser.WalletBalance=currentUser.WalletBalance-packs.Price;
                    foreach(RechargeHistory recharge in rechargeDetailList)
                    {
                        DateTime RechargeDate=DateTime.Now;
                        DateTime ValidTill=DateTime.Now.AddDays(28);
                        RechargeHistory recharge1=new RechargeHistory(recharge.PackId,recharge.UserId,recharge.RechargeDate,recharge.ValidTill);
                        rechargeDetailList.Add(recharge1);
                        System.Console.WriteLine("Your pack has Recharged Successfully");
                        System.Console.WriteLine("Your Pack Id: "+packs.PackId);
                    }

                    
                    
                }
                else
                {
                    System.Console.WriteLine("You have Insufficent Balance\nPlease Recharge");
                }
            }
                 
         }
     
     }


    public static void  CurrentPack()
    {
        System.Console.WriteLine("Enter the Pack Id: ");
        string packId=Console.ReadLine();
        foreach(PackDetail packs in packDetailList)
        {
            if(packId==packs.PackId)
            {
            System.Console.WriteLine("Pack Id: "+packs.PackId+"\n"+"Pack Name: "+packs.PackName+"\n"+"Price: "+packs.Price+"\n"+"Validity: "+packs.Validity+"\n"+"Number of channels: "+packs.NumberOfChannels);
            
            } 
        }
    }


    public static void WalletRecharge()
    {
        System.Console.WriteLine("Do you want to recharge the wallet: ");
        string option=Console.ReadLine().ToLower();
        if(option=="yes")
        {
            System.Console.WriteLine("Enter the amount to be recharged: ");
            double amount=double.Parse(Console.ReadLine());
            currentUser.WalletBalance=currentUser.WalletBalance+amount;
            System.Console.WriteLine("Your Recharged Amount is: "+currentUser.WalletBalance);
        }
    } 

     public static void ViewPackHistoryDetail()
     {
         foreach(RechargeHistory recharge in rechargeDetailList)
         {
             if(currentUser.UserId==recharge.UserId)
             {  
                System.Console.WriteLine("User Id: "+recharge.UserId+"\n"+"Pack Id: "+recharge.PackId+"\n"+"Recharge amount: "+recharge.RechargeDate+"\n"+"Validity: "+recharge.ValidTill);
             }
             else
             {
                 System.Console.WriteLine("You don't have a Pack");
             }
         }
         
                 
             
      }
     
    
     static void DisplayUserRegistration()
    {
        StreamReader reader =null;
        if(File.Exists("UserRegistration.csv"))
        {
            System.Console.WriteLine(File.OpenRead("UserRegistration.csv"));
           while(!reader.EndOfStream)
           {
             var lines=reader.ReadLine();
             var value=lines.Split(',');
             if(value[0]!=""&& value[0]!="n")
             {
               userRegistrationDetailsList.Add(new UserRegistration(value[1],long.Parse(value[2]),value[3],double.Parse(value[4])));
             }
            foreach(UserRegistration user in userRegistrationDetailsList)
            {
                System.Console.WriteLine("User Name:"+user.UserName+","+"Mobile Number: "+user.MobileNumber+","+"Email Id:"+user.EmailId+","+"Wallet Balance: "+user.WalletBalance);
            }
            reader.Close();
           }
         
        }
        

    }

    }
}
