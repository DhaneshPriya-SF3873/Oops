using System;
namespace PayRollManagementSystem
{
    public enum Branch{Default,Eymard,Mathura,Karuna};
    public enum Team{Default,Developement,Networking,HR};
    public class AddingEmployeeDetails
    {
        private static int s_employeeId=3000; 
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public Branch Branch { get; set; }
        public Team Team { get; set; }
        public DateTime Date { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        
        
        
        
        
        
     public AddingEmployeeDetails(string name,Branch branch, Team team,DateTime date,DateTime checkInTime,DateTime checkOutTime)
     {
         s_employeeId++;
         EmployeeId="SF"+s_employeeId;
         Name=name;
         Branch=branch;
         Team=team;
         Date=date;
         CheckInTime=checkInTime;
         CheckOutTime=checkOutTime;

     }
        
        
        public  void ShowDetails()
        {
            System.Console.WriteLine("Your Name:"+EmployeeId+"\n"+"Your Branch: "+Branch+"\n"+"Your Team: "+Team+"\n"+"Date"+Date+"\n"+"Your Check In Time:"+CheckInTime+"\n"+"Your Check out Time"+CheckOutTime);
        }

        public void CalculateSalary()
        {
          int numberOfDays=DateTime.DaysInMonth(Date.Year,Date.Month);
          int workdays=numberOfDays*500;
          System.Console.WriteLine("Your Salary is: "+workdays);

        }
        
    }
}