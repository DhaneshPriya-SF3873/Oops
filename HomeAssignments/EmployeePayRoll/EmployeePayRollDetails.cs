using System;
namespace EmployeePayRoll
{
public enum Gender{Default,Male,Female,Transgender}
public enum OfficeLocation{Default,MathuraTowers,EymardComplex,KarunaConclave}

    public class EmployeePayRollDetails
    {
        private static int  s_employeeId=3000;
        public string EmployeeId { get; }
        
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
         public DateTime Dob { get; set; }
         public long PhoneNumber { get; set; }
        public string MailId { get; set; }
        public OfficeLocation OfficeLocation { get; set; }
       public int Month { get; set; }
       public int NumberOfLeaves { get; set; }
       
       
       
       
        
        


        //Parameter constructor
         public EmployeePayRollDetails(string name,string fatherName, Gender gender,DateTime dob,long phoneNumber,string mailId,OfficeLocation officeLocation)
         {
             s_employeeId++;
             EmployeeId="SF"+s_employeeId;
             Name=name;
             FatherName=fatherName;
             Gender=gender;
             Dob=dob;
             PhoneNumber=phoneNumber;
             MailId=mailId;
             OfficeLocation=officeLocation;

         }

        public void DisplayDetails()
        {
           Console.WriteLine("Your Id: "+ EmployeeId+"\n"+"Your Name: "+Name+" "+"\n"+"Your Father's Name:"+ FatherName+" "+"\n"+"Your Gender: "+Gender+"\n"+"Your Dob:"+Dob+"\n"+"Your Phone number:"+PhoneNumber+"\n"+"Your Mail Id:"+MailId+"\n"+"Your Office Location: "+OfficeLocation);
        }
    
        public void NumberOfLeavesTaken()
         {
            Console.WriteLine("No of leaves taken:");
             int NumberOfLeaves=int.Parse(Console.ReadLine());

        }
        public  void CalaculateSalary(DateTime monthYear)
        {
            NumberOfLeavesTaken();
            int numberOfDays=DateTime.DaysInMonth(monthYear.Year,monthYear.Month);
            int workDays=numberOfDays-NumberOfLeaves;
            int totalSalary=workDays*500;
            System.Console.WriteLine("Your Salary on the"+" "+monthYear.ToString("MM/yyyy")+"is "+totalSalary);
        }
    }
}
