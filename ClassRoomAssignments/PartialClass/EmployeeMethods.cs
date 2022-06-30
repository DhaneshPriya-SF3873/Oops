using System;
namespace PartialClass
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string employeeId,string employeeName)
        {
           EmployeeId = employeeId;
           EmployeeName =employeeName;
        }

        public void DisplayEmployeeInfo()
        {
            System.Console.WriteLine("Employee Id: "+EmployeeId+" "+"Employee Name: "+EmployeeName);
        }
    }
}