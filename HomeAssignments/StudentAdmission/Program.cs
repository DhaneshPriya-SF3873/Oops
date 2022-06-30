using System;
using System.Collections.Generic;
using System.IO;
namespace StudentAdmission
{
    class Program
    {
        static List<StudentDetail> studentDetailList=new List<StudentDetail>();
        static List<DepartmentDetail> departmentDetailList=new List<DepartmentDetail>();
        static List<AdmissionDetail> admissionDetailList=new List<AdmissionDetail>();

        static StudentDetail currentUser=null;
        //static AdmissionDetail currentUser1=null;
        static void Main(string[] args)
        {
            DisplayStudentDetail();
            DisplayDepartmentDetail();
            DisplayAdmissionDetail();
            ShowMainMenu();
            InsertStudentDetail();
            InsertDepartmentDetail();
            InsertAdmissionDetail();
        }
        public static void ShowMainMenu()
        {

        
            int option;
            do
            {
              System.Console.WriteLine("Select the MainMenu");
            System.Console.WriteLine("1.Student Registration \n2.Student Login \n3.Check Department wise seat availability\n4.Exit");
             option=int.Parse(Console.ReadLine());
             switch (option)
             {
                 case 1:
                 {
                     StudentRegistration();
                     break;

                 }
                 case 2:
                 {
                     StudentLogin();
                     break;
                 }
                 case 3:
                 {
                     DepartmentwiseSeatAvailability();
                     break;
                 }
                 case 4:
                 {
                     break;
                 }
             }
            }while(option!=4);
        }
        
           
     public  static void StudentRegistration()
     {
             Console.WriteLine("Enter Your Name: ");
            string studentName=Console.ReadLine();
            Console.WriteLine("Enter Your Father's Name: ");
            string fatherName=Console.ReadLine();
            Console.WriteLine("Enter Your Date of birth:");
            DateTime dOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.WriteLine("Select Your Gender 1.Male 2.Female 3.Transgender");
            int genderValue=int.Parse(Console.ReadLine());
            Gender gender=Gender.Default;
            while(!(genderValue>0 && genderValue<4))
            {
                Console.WriteLine("Select Your Gender 1.Male 2.Female 3.Transgender");
                genderValue=int.Parse(Console.ReadLine());
                
            }
            gender=(Gender)genderValue;
            Console.WriteLine("Enter the Physics Mark:");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Chemistry Mark:");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Maths Mark");
            int maths=int.Parse(Console.ReadLine());

            StudentDetail student=new StudentDetail(studentName,fatherName,dOB,gender,physics,chemistry,maths);
            studentDetailList.AddElement(student);
            System.Console.WriteLine("Student Id: "+student.StudentId);
           
            
            

     }
 static void DisplayStudentDetail()
            {
                StreamReader reader=null;
            
                if(File.Exists("StudentDetail.csv"))
                {
                    reader=new StreamReader(File.OpenRead("StudentDetail.csv"));
                    while(!reader.EndOfStream)
                    {
                        var line=reader.ReadLine();
                        var values=line.Split(',');
                        if(values[0]!="" && values[0]!="n")
                        {
                         studentDetailList.AddElement(new StudentDetail(values[1],values[2],DateTime.ParseExact(values[3],"dd/MM/yyyy",null),(Gender)Enum.Parse(typeof(Gender),values[4]),int.Parse(values[5]),int.Parse(values[6]),int.Parse(values[7])));
                        } 
                    }              
                      }

                else
                {
                    System.Console.WriteLine("File doesn't exist");
                }
                reader.Close();
                foreach(StudentDetail coloumn1 in studentDetailList)
                {
                    System.Console.WriteLine("Your Name:\t"+coloumn1.StudentName+"\t Father Name:\t"+coloumn1.FatherName+"DOB:\t"+coloumn1.DOB+"Gender:\t"+coloumn1.Gender+"Physics Mark:\t"+coloumn1.Physics+"Chemistry Mark:\t"+coloumn1.Chemistry+"Maths Mark:\t"+coloumn1.Maths);
                }
            }


    static void DisplayDepartmentDetail()
            {
                StreamReader reader=null;
               
                if(File.Exists("DepartmentDetail.csv"))
                {
                    reader=new StreamReader(File.OpenRead("DepartmentDetail.csv"));
                    while(!reader.EndOfStream)
                    {
                        var line=reader.ReadLine();
                        var values=line.Split(',');
                        if(values[0]!="" && values[0]!="n")
                        {
                         departmentDetailList.AddElement(new DepartmentDetail(values[1],int.Parse(values[2])));
                        } 
                    }              
                      }

                else
                {
                    System.Console.WriteLine("File doesn't exist");
                }
                reader.Close();
                foreach(DepartmentDetail coloumn1 in departmentDetailList)
                {
                    System.Console.WriteLine("Department Name:\t"+coloumn1.DepartmentName+"\t Number Of Seats:\t"+coloumn1.NumberOfSeats);
                }
            }

    static void DisplayAdmissionDetail()
            {
                StreamReader reader=null;
                
                if(File.Exists("AdmissionDetail.csv"))
                {
                    reader=new StreamReader(File.OpenRead("AdmissionDetail.csv"));
                    while(!reader.EndOfStream)
                    {
                        var line=reader.ReadLine();
                        var values=line.Split(',');
                        if(values[0]!="" && values[0]!="n")
                        {
                         admissionDetailList.AddElement(new AdmissionDetail(values[1],values[2],DateTime.ParseExact(values[3],"dd/MM/yyyy",null),(Status)Enum.Parse(typeof(Status),values[4])));
                        } 
                    }              
                      }

                else
                {
                    System.Console.WriteLine("File doesn't exist");
                }
                reader.Close();
                foreach(AdmissionDetail coloumn1 in admissionDetailList)
                {
                    System.Console.WriteLine("Admission Id: \t "+coloumn1.AdmissionId+"Student Id:\t"+coloumn1.StudentId+"\t Department Id:\t"+coloumn1.DepartmentId+"\t Admission Date: \t"+coloumn1.AdmissionDate+"\t Admission Status: \t"+coloumn1.AdmissionStatus);
                }
            }
      
      static void InsertStudentDetail()
            {
                StreamWriter write=null;
                if(!File.Exists("StudentDetail.csv"))
                {
                    System.Console.WriteLine("File doesn't exist. Creating a new CSV file");
                    File.Create("StudentDetail.csv");
                }
                else
                {
                    write=new StreamWriter(File.OpenWrite("StudentDetail.csv"));
                    foreach(StudentDetail v in studentDetailList)
                    {
                        write.WriteLine(v.StudentId+","+v.StudentName+","+v.FatherName+","+v.DOB.ToString("dd/MM/yyyy")+","+v.Gender+","+v.Physics+","+v.Chemistry+","+v.Maths);
                    }
                    write.WriteLine();
                }
                write.Close();

                }

                static void InsertDepartmentDetail()
            {
                StreamWriter write=null;
                if(!File.Exists("DepartmentDetail.csv"))
                {
                    System.Console.WriteLine("File doesn't exist. Creating a new CSV file");
                    File.Create("DepartmentDetail.csv");
                }
                else
                {
                    write=new StreamWriter(File.OpenWrite("DepartmentDetail.csv"));
                    foreach(DepartmentDetail v in departmentDetailList)
                    {
                        write.WriteLine(v.DepartmentId+","+v.DepartmentName+","+v.NumberOfSeats);
                    }
                    write.WriteLine();
                }
                write.Close();

                }


                 static void InsertAdmissionDetail()
            {
                StreamWriter write=null;
                if(!File.Exists("AdmissionDetail.csv"))
                {
                    System.Console.WriteLine("File doesn't exist. Creating a new CSV file");
                    File.Create("AdmissionDetail.csv");
                }
                else
                {
                    write=new StreamWriter(File.OpenWrite("AdmissionDetail.csv"));
                    foreach(AdmissionDetail v in admissionDetailList)
                    {
                        write.WriteLine(v.AdmissionId+","+v.StudentId+","+v.DepartmentId+","+v.AdmissionDate.ToString("dd/MM/yyyy")+","+v.AdmissionStatus);
                    }
                    write.WriteLine();
                }
                write.Close();

                }

            



            

    

    

    

     public static void StudentLogin()
     {
         System.Console.WriteLine("Enter the Student Id: ");
         string StudentId=Console.ReadLine();
         string element =StudentId;
         StudentDetail student;
         int result=BinarySearch(studentDetailList,element,out student);
            if(result==-1)
            {
                System.Console.WriteLine("Element not found");
            }
            else
             {
                 currentUser=student;
                 SubMenu();
              }
         }
     


     static int BinarySearch(List<StudentDetail> array,string element, out StudentDetail student)
        {
            int left=0, right=array.Count-1;
            while(left<=right)
            {
                int middle=left+(right-left)/2;

                if(array[middle].StudentId==element)
                {
                    student=array[middle];
                    return middle;
                }

                if(array[middle].StudentId.CompareTo(element)<0)
                {
                    left=middle+1;
                }
                else
                {
                right=middle-1;
                }
                
            }
            student=null;
            return-1;
        }

            public static void SubMenu()
            {
                int option;
                do{
                 System.Console.WriteLine("1.Check Eligibility\n2.Show Details\n3.Take Admission\n4.Cancel Admission\n5.Show Admission Detail\n6.Exit");
                 option=int.Parse(Console.ReadLine());
                 switch(option)
                 {
                     case 1:
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
                     case 2:
                     {
                         ShowStudentDetail();
                         break;
                     }
                     case 3:
                     {
                         TakeAdmission();
                         break;
                     }
                     case 4:
                     {
                         CancelAdmission();
                         break;
                     }
                     case 5:
                     {
                         ShowAdmissionDetail();
                         break;
                     }
                     case 6:
                     {
                         break;
                     }
                 }
                 
                }while(option!=6);
            }
            
        
       public static void ShowStudentDetail()
       {
           foreach(StudentDetail student in studentDetailList)
           {
               System.Console.WriteLine("Student Name: "+student.StudentName+"\n"+"Father Name: "+student.FatherName+"\n"+"DOB: "+student.DOB+"\n"+"Gender: "+student.Gender+"\n"+"Physics Mark: "+student.Physics+"\n"+"Chemistry Mark: "+student.Chemistry+"\n"+"Maths Mark: "+student.Maths);
           }
       }

    public static AdmissionDetail admit= null;
    public static void TakeAdmission()
    {
        foreach(DepartmentDetail department in departmentDetailList)
        {
             System.Console.WriteLine("Department Id \t:"+department.DepartmentId+"Department Name:\t"+department.DepartmentName+"\t Number Of Seats:\t"+department.NumberOfSeats);
        }
        System.Console.WriteLine("Enter the Department Id: ");
        string departmentId=Console.ReadLine(); int count =1;
        foreach(DepartmentDetail department in departmentDetailList)
        {
            if(departmentId==department.DepartmentId)
            {
                    if(currentUser.CheckEligibility(75))
                    {
                        foreach(AdmissionDetail admission in admissionDetailList)
                        { count++;
                           if(currentUser.StudentId==admission.StudentId)
                           {
                               if(admission.AdmissionStatus==Status.Cancelled)
                               {
                                   if(department.NumberOfSeats>0)
                                   {
                                       department.NumberOfSeats--;
                                       DateTime date=DateTime.Now;
                                       admit=new AdmissionDetail(currentUser.StudentId,department.DepartmentId,date,Status.Booked);
                                        admissionDetailList.AddElement(admit);
                                        System.Console.WriteLine("Admission taken successfully");
                                        System.Console.WriteLine("Your Admission Id: "+admit.AdmissionId);
                                   }
                               }
                           }
                          


                        }
                         
                     }
            }
                        if(count>admissionDetailList.Count && departmentId==department.DepartmentId)
                           {
                               if(department.NumberOfSeats>0)
                                   {
                                       department.NumberOfSeats--;
                                       DateTime date=DateTime.Now;
                                        admit=new AdmissionDetail(currentUser.StudentId,department.DepartmentId,date,Status.Booked);
                                       
                                   }
                           }
        }
                                if(count>admissionDetailList.Count && admit!=null)
                           {
                                  admissionDetailList.AddElement(admit);
                                        System.Console.WriteLine("Admission taken successfully");
                                        System.Console.WriteLine("Your Admission Id: "+admit.AdmissionId);
                           }
    }
   public static void CancelAdmission()
   {
       System.Console.WriteLine("Do you want to cancel admission: ");
       string option=Console.ReadLine().ToLower();
       if(option=="yes")
       foreach(AdmissionDetail admission in admissionDetailList)
       {
          if(admission.StudentId==currentUser.StudentId)
          {
            if(admission.AdmissionStatus==Status.Booked)
               {
                   admission.AdmissionStatus=Status.Cancelled;
                   foreach(DepartmentDetail departments in departmentDetailList)
                    {
                        if(admission.DepartmentId==departments.DepartmentId)
                        {
                        departments.NumberOfSeats=departments.NumberOfSeats+1;
                     System.Console.WriteLine("Cancelled Successfully");
                        }
                    
                    }    
               }
          }
               
               
        }

       
       
   }

    public static void ShowAdmissionDetail()
    {
        foreach(AdmissionDetail admission in admissionDetailList)
        {
            System.Console.WriteLine("Student Id: "+admission.StudentId+"\n"+"Department Id: "+admission.DepartmentId+"\n"+"Admission Date: "+admission.AdmissionDate+"\n"+"Admission Status: "+admission.AdmissionStatus);
        }
    }
    public static void DepartmentwiseSeatAvailability()
    {
        foreach(DepartmentDetail departments in departmentDetailList)
        {
            System.Console.WriteLine("Department Id: "+departments.DepartmentId+"\n"+"Department Name: "+departments.DepartmentName+"\n"+"Number of Seats: "+departments.NumberOfSeats);
        }
    }
                
    }
    
}