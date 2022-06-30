using System;
using System.Collections.Generic;
namespace LearningCourseApplication
{
    class Program
    {
        static List<UserRegistration> userRegistrationList=new List<UserRegistration>();
        static List<CourseDetails> courseDetailsList=new List<CourseDetails>();
        static UserRegistration currentUser=null;
        static void Main(string[] args)
        {
            DefaultCourseData();
            int option;
            do{
            System.Console.WriteLine("MainMenu");
            System.Console.WriteLine("1.User Registration 2.Login 3.Exit");
             option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    UserRegistration();
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


        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter the name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the email id:");
            string emailId=Console.ReadLine();
            System.Console.WriteLine("Enter the phonenumber: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Gender: ");
            string gender=Console.ReadLine();
            System.Console.WriteLine("Enter the Wallet Balance: ");
            double walletBalance=double.Parse(Console.ReadLine());
            
          UserRegistration user=new UserRegistration(name,emailId,phoneNumber,gender,walletBalance);
          userRegistrationList.Add(user);
          System.Console.WriteLine("User Id: "+user.UserId);
            
            
        }


      public static void Login()
      {
          System.Console.WriteLine("Enter the UserId: ");
          string userId=Console.ReadLine();
          foreach(UserRegistration users in userRegistrationList)
          {
              if(userId==users.UserId)
              {
                  currentUser=users;
                  SubMenu();
              }
          }
          
      }
            
        public static void SubMenu()
        {
            int option;
            do
            {
            System.Console.WriteLine("1.Course Details 2.Wallet Balance 3.Exit");
            option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    CourseDetails();
                    break;
                }
                case 2:
                {
                    WalletBalance();
                    break;
                }
                case 3:
                {
                    break;
                }
            }
            
            }while(option!=3);

        }   

        public static void DefaultCourseData()
        {
           CourseDetails course1=new CourseDetails("Development","C#","English",3500);
           CourseDetails course2=new CourseDetails("Photography","Adobe ligthroom photo editing","English",4500);
           courseDetailsList.Add(course1);
           courseDetailsList.Add(course2);

        }
        public static void CourseDetails()
        {
            foreach(CourseDetails course in courseDetailsList)
            {
                System.Console.WriteLine("Course Id: "+course.CourseId+"\n"+"Course Type: "+course.CourseType+"\n"+"Course Name: "+course.CourseName+"\n"+"Languages:"+course.Language+"Price:"+course.Price);
            }
            string option;
            int numberOfCourse; 
            do
            {
            System.Console.WriteLine("Enter the Course Id: ");
            string CourseId=Console.ReadLine();
            System.Console.WriteLine("Enter the number of course: ");
            numberOfCourse=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Do you want to select other course");
            option=Console.ReadLine().ToLower();
            
            
            }while(option=="yes");
            
            
            foreach(CourseDetails course in courseDetailsList)
            {
                 if(currentUser.WalletBalance>course.Price)
            {
                 course.Price=course.Price*numberOfCourse;
                 System.Console.WriteLine("Your course amount is: "+course.Price);
            }
            }
        
           
        }


    
        public static void WalletBalance()
        {
             foreach(CourseDetails course in courseDetailsList)
             {
                if(currentUser.WalletBalance<course.Price)
                {
                    System.Console.WriteLine("Enter the amount to be recharged: ");
                    double amount=double.Parse(Console.ReadLine());
                    
                    currentUser.WalletBalance=currentUser.WalletBalance+amount;
                    System.Console.WriteLine("Your recharged amount is: "+currentUser.WalletBalance);
                }
             }
           
        }




        
    }   
}