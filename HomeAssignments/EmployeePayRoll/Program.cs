using System;
using System.Collections.Generic;
namespace EmployeePayRoll
{
    class Program
    {

        static List<EmployeePayRollDetails> employeeList=new List<EmployeePayRollDetails>();
        static EmployeePayRollDetails currentUser=null;
        static void Main(string[] args)
        
        {
            Default();
            int choice;
        do
          
        {
            System.Console.WriteLine("Select the Main Menu");
            System.Console.WriteLine("1.Registration \n2.Login \n3.Exit");
            choice=int.Parse(Console.ReadLine());
            
            switch (choice)
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
        }while(choice!=3);


     static void Registration()
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
            System.Console.WriteLine("Enter Your Phone Number: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Email Id: ");
            string mailId=Console.ReadLine();
            System.Console.WriteLine("Select Your office location 1.Mathura Towers 2.Eymard Complex 3.Karuna Conclave");
            int officeLocationValue=int.Parse(Console.ReadLine());
            OfficeLocation officeLocation=OfficeLocation.Default;
            while(!(officeLocationValue>0 && officeLocationValue<4))
            {
                
             System.Console.WriteLine("Select Your office location 1.Mathura Towers 2.Eymard Complex 3.Karuna Conclave");
               officeLocationValue=int.Parse(Console.ReadLine());

            }
           officeLocation=(OfficeLocation)officeLocationValue;

           EmployeePayRollDetails employeeDetail1=new EmployeePayRollDetails(name,fatherName,gender,dob,phoneNumber,mailId,officeLocation);
            employeeList.Add(employeeDetail1);
    }
            
            static void Default()
            {
                EmployeePayRollDetails employeeDetail1=new EmployeePayRollDetails("Dhanesh","Sankar",Gender.Female,new DateTime(31/10/1997),6562487421,"priya@gmail.com",OfficeLocation.MathuraTowers);
            employeeList.Add(employeeDetail1);
            }

     static void Login()
    {

    System.Console.WriteLine("Enter the Employee ID:");
      string employeeId=Console.ReadLine();
       foreach(EmployeePayRollDetails employee in employeeList)
            {
                if(employeeId==employee.EmployeeId)
                {
                    System.Console.WriteLine("Login successful");
                    currentUser=employee;
                    SubMenu();

                    
                }
              if(employeeId!=employee.EmployeeId)
                {
                    System.Console.WriteLine(" User Invalid Id");
                }

                
    }
            
     static void SubMenu()
       {
      int option;
      do
      {
        System.Console.WriteLine("SubMenu");
        System.Console.WriteLine("Select the option 1.Calculate Salary \n2.Display Details\n3.Exit");
        option=int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
            {
            System.Console.WriteLine("Enter the Month and year (MM/yyyy): ");
            DateTime monthYear=DateTime.ParseExact(Console.ReadLine(),"MM/yyyy",null);
                currentUser.CalaculateSalary(monthYear);
                break;
            }
            case 2:
            {
                currentUser.DisplayDetails();
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
}
    



