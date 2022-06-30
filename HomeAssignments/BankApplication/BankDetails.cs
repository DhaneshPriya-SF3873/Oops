using System;
namespace BankApplication
{
    public enum Gender{Default,Male,Female,Transgender}
    public class BankDetails
    {
        private static int  s_accountNumber=10000;
        public string AccountNumber { get; }
        
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
         public DateTime Dob { get; set; }
        public string MailId { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set;}
        public string AccountType { get; set; }
       
        
        
        
        
        
        
         

         //Parameter constructor
         public BankDetails(string name,string fatherName,Gender gender,DateTime dob,string mailId,long phoneNumber,double balance,string accountType)
         {
             s_accountNumber++;
             AccountNumber="HDFC"+s_accountNumber;
             Name=name;
             FatherName=fatherName;
             Gender=gender;
             Dob=dob;
             MailId=mailId;
             PhoneNumber=phoneNumber;
             Balance=balance;
             AccountType=accountType;
             
         }
        
        public void BalanceCheck()
        {
            
             System.Console.WriteLine("Your Balance is: "+Balance);
           
            
        }

        public void CashWithdraw()
        {
            System.Console.WriteLine("Enter the withdraw amount:");
            double withdraw=double.Parse(Console.ReadLine());
            if(withdraw>Balance)
            {
             System.Console.WriteLine("You have a insufficient amount");
            }
            else if(withdraw<0)
            {
                System.Console.WriteLine("Your amount is invalid");
            }
            else
            {
            Balance=Balance-withdraw;
            BalanceCheck();
            }

        }
         

         public void DepositAmount()
         {
             System.Console.WriteLine("Enter the deposited amount:");
             double depositAmount=double.Parse(Console.ReadLine());
           
             if(depositAmount>0)
             {
                  Balance=Balance+depositAmount;
                  BalanceCheck();
             }
             else
             {
                 System.Console.WriteLine("You Deposit amount is invalid");
             }

         }


        
        
        

        
        
        
        
        
        
        
        
        
        
        
        
    }
}