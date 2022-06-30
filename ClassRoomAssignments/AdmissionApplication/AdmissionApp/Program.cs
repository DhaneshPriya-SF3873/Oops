using System;
using AdmissionLibrary;
using System.Collections.Generic;
namespace AdmissionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Purchase a File
            List<StudentInfo> studentList=new List<StudentInfo>();
            string option;
            do
            {
                
            Console.WriteLine("Enter Your  Name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Your Father's Name: ");
            string fatherName=Console.ReadLine();
            Console.WriteLine("Select Your Gender 1.Male 2.Female 3.Transgender");
            int genderValue=int.Parse(Console.ReadLine());
            Gender gender=Gender.Default;
            while(!(genderValue>0 && genderValue<4))
            {
                Console.WriteLine("Select Your Gender 1.Male 2.Female 3.Transgender");
                genderValue=int.Parse(Console.ReadLine());
                
            }
           
            Console.WriteLine("Enter Your Date of birth:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.WriteLine("Enter Your Phone number:");
            long phoneNumber=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Email id");
            string mailid=Console.ReadLine();
            Console.WriteLine("Enter the Physics Mark:");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Chemistry Mark:");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Maths Mark");
             int maths=int.Parse(Console.ReadLine());


             //class object declared with parameter constructor
             StudentInfo student1=new StudentInfo(name,fatherName,gender,dob,phoneNumber,mailid,physics,chemistry,maths);
             System.Console.WriteLine("Registration Id:"+student1.RegistrationId);
             //Add prinout to the file
             studentList.Add(student1);

                System.Console.WriteLine("Do yo want to continue(Yes/No)");
                option=Console.ReadLine().ToUpper();
                
            }while(option=="YES");
              

            System.Console.WriteLine("Enter your Registration Id");
            string registrationId=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter your Registration Id1");
            string registrationId1=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter your Registration Id2");
            string registrationId2=Console.ReadLine().ToUpper();
            
            
            
            

           
          
           foreach(StudentInfo student in studentList)
           {
               if(registrationId==student.RegistrationId)
               {
                  
               student.Display1();
               bool eligible=student.CheckEligibility(75.0);
               if(eligible)
               {
                   System.Console.WriteLine("You are eligible for admission");
               }
               else
               {
                   System.Console.WriteLine("You are not eligible for admission");
               }

               
               }
           }

        
            


            


       } 
        
                
    }
    
}