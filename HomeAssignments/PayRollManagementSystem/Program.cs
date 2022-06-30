using System;
using System.Collections.Generic;
namespace PayRollManagementSystem
{
    class Program
    {
       static List<AddingEmployeeDetails> employeeDetail=new List<AddingEmployeeDetails>();
       static AddingEmployeeDetails currentUser=null;
        static void Main(string[] args)
        {
            int option;
            do
            {
            Console.WriteLine("Select the Main Menu");
           Console.WriteLine("1.Add new Employee 2.Existing Employee Login 3.Exit");
           option=int.Parse(Console.ReadLine());
           switch (option)
           {
               case 1:
               {
                   AddNewEmployee();
                   break;
               }
               case 2:
               {
                    EmployeeDetails();
                   break;
               }
               case 3:
               {
                   
                   break;
               }
           }
           
            }while(option!=3);  


         static void AddNewEmployee()
        {
            System.Console.WriteLine("Enter the Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the Branch: 1.Eymard 2.Mathura 3.Karuna ");
            int branchName=int.Parse(Console.ReadLine());
            Branch branch=Branch.Default;
            while(!(branchName>0 && branchName<4))
            {
            System.Console.WriteLine("Enter the Branch: 1.Eymard 2.Mathura 3.Karuna ");
             branchName=int.Parse(Console.ReadLine());
            }
            branch=(Branch)branchName;
            System.Console.WriteLine("Enter the Team: 1.Developemnt 2.Networking 3.HR");
            int teamName=int.Parse(Console.ReadLine());
            Team team=Team.Default;
            while(!(teamName>0 && teamName<4))
            {
             System.Console.WriteLine("Enter the Team: 1.Developemnt 2.Networking 3.HR");
             teamName=int.Parse(Console.ReadLine());
            }
            team=(Team)teamName;
            System.Console.WriteLine("Enter the Date:(dd/MM/yyyy)");
            DateTime date=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
            System.Console.WriteLine("Enter the check in time: ");
            DateTime checkInTime=DateTime.ParseExact(Console.ReadLine(),("hh:mm:ss tt"),null);
            System.Console.WriteLine("Enter the Check out time: ");
            DateTime checkOutTime=DateTime.ParseExact(Console.ReadLine(),("hh:mm:ss tt"),null);
           
            AddingEmployeeDetails employee1=new AddingEmployeeDetails(name,branch,team,date,checkInTime,checkOutTime);
            System.Console.WriteLine("Your Id:" +employee1.EmployeeId);
            employeeDetail.Add(employee1);
            
            }  



        static void EmployeeDetails()
       {
           
           System.Console.WriteLine("Enter the Employee Id");
           string employeeId=Console.ReadLine();
           foreach(AddingEmployeeDetails employee in employeeDetail)
           {
               if(employeeId==employee.EmployeeId)
               {
                   currentUser=employee;
                   SubMenu();
               }
           }
       }


           static void SubMenu()
           {
           int option;
           do
           {
           System.Console.WriteLine("SubMenu");
           System.Console.WriteLine("1.Show Details\n2.Calculate Salary\n3.Exit");
           option=int.Parse(Console.ReadLine());
           switch (option)
           {
               case 1:
               {
                   currentUser.ShowDetails();
                   break;

               }
               case 2:
               {
                   currentUser.CalculateSalary();
                   break;
               }
               case 3:
               {
                   
                   break;
               }
               
           }
           }while(option!=3);
           }
           
       
       }
          
       } 
        
                
    }
    
