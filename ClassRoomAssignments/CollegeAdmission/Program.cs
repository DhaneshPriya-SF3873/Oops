using System;
using System.IO;
using System.Collections.Generic;
namespace CollegeAdmission
{
    class Program
    {
        static List<StudentInfo> studentList=new List<StudentInfo>();
        static StudentInfo currentUser=null;

        public static void Main(string[] args)
        {
            Default();
           
           
            int option;
            do
            {
              Console.WriteLine("Select Main Menu");
              Console.WriteLine("1.Registration \n2.Login \n3.Exit");
               option=int.Parse(Console.ReadLine());
              switch (option)
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
           
            }while(option!=3);
           

        }

    public static void Registration()
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
            gender=(Gender)genderValue;
           
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
              Insert(studentList);
              Display();
              
    }    

   static void Default()
   {
       StudentInfo student=new StudentInfo("Dhanesh","Sankar",Gender.Female,new DateTime(1997,10,31),6379724671,"priya@gmail.com",90,90,90);
       studentList.Add(student);
   }
             
    public static void Login()
    {
        System.Console.WriteLine("Enter your Registration Id");
            string registrationId=Console.ReadLine().ToUpper();
            
            foreach(StudentInfo student in studentList)
           {
               if(registrationId==student.RegistrationId)
               {
                   System.Console.WriteLine("Login Successful");
                   currentUser=student;
                   SubMenu();
               }

           }
    }

     static void SubMenu()
    {
        int option;
        do{

   
        System.Console.WriteLine("Enter the option: 1.DisplayDetails \n 2.Calculate Total and Average \n 3.Check Eligibility");
         option=int.Parse(Console.ReadLine());
        switch (option)
        {
            
            case 1:
            {
                currentUser.DisplayDetails();
                
                break;
            }
            case 2:
            {
              currentUser.Calculate();
              break;
            }
            case 3:
            {
                bool eligible=currentUser.CheckEligibility(75.0);
               if(eligible)
               {
                   System.Console.WriteLine("You are eligible for admission");
               }
               else
               {
                   System.Console.WriteLine("You are not eligible for admission");
               }
                break;
            }
        }
        }while(option!=4);
        
        

    }
 

  static void Insert(List<StudentInfo>studentList)
  {
      StreamWriter write=null;
                if(!File.Exists("Data.csv"))
                {
                    System.Console.WriteLine("File doesn't exist. Creating a new CSV file");
                                    File.Create("Data.csv");
                }
                else
                {
                    write=new StreamWriter(File.OpenWrite("Data.csv"));
                    foreach(var v in studentList)
                    {
                        write.WriteLine(v.StudentName+","+v.FatherName+","+v.Gender+","+v.DOB+","+v.PhoneNumber+","+v.EmailId+","+v.Physics+","+v.Chemistry+","+v.Maths);
                    }
                    write.WriteLine();
                }
                write.Close();

           }


           static void Display()
            {
                StreamReader reader=null;
                List<StudentInfo> listA =new List<StudentInfo>();
                if(File.Exists("Data.csv"))
                {
                    reader=new StreamReader(File.OpenRead("Data.csv"));
                    while(!reader.EndOfStream)
                    {
                        var line=reader.ReadLine();
                        var values=line.Split(',');
                        if(values[0]!="" && values[0]!="n")
                        {
                         listA.Add(new StudentInfo(values[1],values[2],(Gender)Enum.Parse(typeof(Gender),values[3]),DateTime.Parse(values[4]),long.Parse(values[5]),values[6],int.Parse(values[7]),int.Parse(values[8]),int.Parse(values[9])));
                        } 
                    }                }

                else
                {
                    System.Console.WriteLine("File doesn't exist");
                }
                reader.Close();
                foreach(var coloumn1 in listA)
                {
                    System.Console.WriteLine("Your Name:\t"+coloumn1.StudentName+"\t Father Name:\t"+coloumn1.FatherName+"Gender:\t"+coloumn1.Gender+"DOB:\t"+coloumn1.DOB+"Phone Number:\t"+coloumn1.PhoneNumber+"Mail Id:\t"+coloumn1.EmailId+"Physics Mark:\t"+coloumn1.Physics+"Chemistry Mark:\t"+coloumn1.Chemistry+"Maths Mark:\t"+coloumn1.Maths);
                }
            }
  }
    }


    

