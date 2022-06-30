using System;
namespace EmployementRegistration
{
    public class EmployeeRegistration:IPersonalInfo,IHomeInfo,IEducationalInfo
    {
        public string StudentName { get; set; }
        public string FatherName { get; set; }

        public   int DoorNumber { get; set; }
        public   string Address { get; set; }
          
          public int SSLCMark { get; set; }
         public int HSCMark { get; set; }
         public double UGOverall { get; set; }
          private static int RegisterNumber =100;
        public DateTime Date { get; set; }
        public void PersonalInformation()
         {
           System.Console.WriteLine("Name: "+StudentName);
           System.Console.WriteLine("Father's Name : "+FatherName);
         }
         public  void HomeInformation()
         {
             System.Console.WriteLine("DoorNumber: "+DoorNumber);
             System.Console.WriteLine("Address: "+Address);
         }
         public void EducationalInformation()
         {
           System.Console.WriteLine("SSLC: "+SSLCMark);
           System.Console.WriteLine("HSC: "+HSCMark);
           System.Console.WriteLine("Overall UG: "+UGOverall);
         }
          public void DisplayEmployeeDetails()
          {
              RegisterNumber++;
              System.Console.WriteLine("Register Number: "+RegisterNumber);
              DateTime registration=DateTime.Now;
              System.Console.WriteLine("Registration Date:" +registration.ToShortDateString());
              DateTime validity=DateTime.Now.AddYears(2);
              System.Console.WriteLine("Validity till: "+validity.ToShortDateString());
          }
        

         
    }
}