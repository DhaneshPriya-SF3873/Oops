using System;
using System.Collections.Generic;
namespace BankApplication
{
    class Program
    {
        static List<BankDetails> bankList=new List<BankDetails>();
        static BankDetails currentUser =null;
        public static void Main(string[] args)
        {
            Default();
           
            int option;
            do
            {
              Console.WriteLine("Select Main Menu");
              Console.WriteLine("1.Registration \n2.Login \n3.Exit");
               option=int.Parse(Console.ReadLine());
              switch (option)
           {
               case 1:
               {
                   Registration();
                        
             break;
                
                   
               }
               case 2:
               {
                   Login();
                  
                   break;
               }
               case 3:
               {
                   
                   break;
               }
           }
           
            }while(option!=3);
           

        }


public static void Registration()
{
    System.Console.WriteLine("Enter Your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter Your Father's Name: ");
            string fatherName=Console.ReadLine();
            Console.WriteLine("Select Your Gender 1.Male 2.Female 3.Transgender");
            int genderValue=int.Parse(Console.ReadLine());
            Gender gender=Gender.Default;
            while(!(genderValue>0 && genderValue<4))
            {
                Console.WriteLine("Select Your Gender 1.Male 2.Female 3.Transgender");
                genderValue=int.Parse(Console.ReadLine());
                
            }
            gender=(Gender)genderValue;
            System.Console.WriteLine("Enter Your DOB: ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter Your Email Id: ");
            string mailId=Console.ReadLine();
            System.Console.WriteLine("Enter Your Phone Number: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Balance: ");
            double balance=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Account Type: ");
            string accountType=Console.ReadLine();
          
            
            

           

           BankDetails bankApp1=new BankDetails(name,fatherName,gender,dob,mailId,phoneNumber,balance,accountType);
           bankList.Add(bankApp1);
}

static void Default()
   {
       BankDetails bankApp1=new BankDetails("Dhanesh","Sankar",Gender.Female,new DateTime(1997/10/31),"priya@gmail.com",6375167564,500.0,"savings");
        bankList.Add(bankApp1);
   }
        
public static void Login()
{
    System.Console.WriteLine("Enter the Account number:");
    string accountNumber=Console.ReadLine();
    foreach(BankDetails bank in bankList)
    {
    if(accountNumber==bank.AccountNumber)
    {
        System.Console.WriteLine("Login Successful");
        currentUser=bank;
        SubMenu();
    }
    if(accountNumber!=bank.AccountNumber)
    {
        System.Console.WriteLine("Invalid User Id");
    }


}
           

 static void SubMenu()
 {
  int option;
        do{

   
        System.Console.WriteLine("Enter the option: 1.Deposit \n 2.WithDraw \n 3.balance \n4.Exit");
         option=int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
            {
                currentUser.DepositAmount();
                break;
            }
            case 2:
            {
                currentUser.CashWithdraw();
                break;
            }
            case 3:
            {
                currentUser.BalanceCheck();
                break;
            }
        }
    }while(option!=4);

            


       } 
        
                
    }
    
}
}
