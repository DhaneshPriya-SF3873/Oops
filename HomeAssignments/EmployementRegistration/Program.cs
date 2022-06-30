
using System;
namespace EmployementRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegistration details=new EmployeeRegistration();
            details.StudentName="Dhanesh Priya";
            details.FatherName="Sankar";
            details.DoorNumber=177;
            details.Address="Manickam Palayam,Housing Unit, Erode.";
            details.SSLCMark=462;
            details.HSCMark=1010;
            details.UGOverall=7.88;
            details.Date=DateTime.Now;
            details.PersonalInformation();
            details.HomeInformation();
            details.EducationalInformation();
            details.DisplayEmployeeDetails();
            


       } 
        
                
    }
    
}