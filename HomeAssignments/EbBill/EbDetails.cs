using System;
namespace EbBill
{
    public class EbDetails
    {
        private static int  s_meterId=1000;
        public string MeterId { get; }
        
         public string Name { get; set; }
        public string FatherName { get; set;}
        public string MailId { get; set; }
        public long PhoneNumber { get; set; }
         
        public int NumberOfUnits { get; set; }
        
        
        
        
        

        //Parameter Constructor
        public EbDetails(string name,string fatherName,string mailId,long phoneNumber)
        {
           s_meterId++;
           MeterId="TNEB"+s_meterId; 
           Name=name;
           FatherName=fatherName;
           MailId=mailId;
           PhoneNumber=phoneNumber; 
           
          
             
        }

       public void DisplayDetails()
        {
             System.Console.WriteLine("Your Meter Id:"+ MeterId+"\n"+"Your Name: "+Name+" "+"\n"+"Your Father's Name:"+ FatherName+" "+"\n"+"Your mail id:"+MailId+"\n"+"Your Phone number:"+PhoneNumber);
        }
        
        public double RegisterUnits()
        {
            Console.WriteLine("Enter the Number of units: ");
            double numberOfUnits=double.Parse(Console.ReadLine());
            return numberOfUnits;
            
        }

        public void CalculateBill()
        {
         if(NumberOfUnits>0 && NumberOfUnits<100)
         {
            System.Console.WriteLine("Your Bill amount is 50"); 
         }
         else if(NumberOfUnits>100 && NumberOfUnits<=200)
         {
             int total=50+(NumberOfUnits-100)*2;
             System.Console.WriteLine("Your Bill amount is"+total);
         }
         else if(NumberOfUnits>200 && NumberOfUnits<=400)
         {
             int total=250+(NumberOfUnits-200)*4;
             System.Console.WriteLine("Your Bill amount is"+total);
         }
         else
         {
          int  total=1050+(NumberOfUnits-400)*6;
          System.Console.WriteLine("Your Bill amount is" +total);

         
        }
    }
}}