using System;
namespace AdmissionLibrary
{
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentInfo
    {
            private static int s_registerNumber=3000; //field
            public string RegistrationId { get; } //Property
            public string StudentName { get; set; }
            public string FatherName { get; set; }
            public Gender Gender { get; set; }
            public long PhoneNumber { get; set; }
            public string EmailId { get; set; }
            public DateTime DOB { get; set; }
            public int Physics { get; set; }
            public int Chemistry { get; set; }
            public int Maths { get; set; }


    //Default constructor
     public StudentInfo()
     {
         StudentName="YourName";
         FatherName="YourFatherName";
         

     }
     //Parameter Constructor
     public StudentInfo(string name, string fatherName, Gender gender, DateTime dob,long phoneNumber,string mailid, int physics,int chemistry,int maths)
     {
          
         s_registerNumber++;
         RegistrationId="SF"+s_registerNumber;
         StudentName=name;
         FatherName=fatherName;
         Gender=gender;
         DOB=dob;
         PhoneNumber=phoneNumber;
         EmailId=mailid;
         Physics=physics;
         Chemistry=Chemistry;
         Maths=maths;
         


     }
     public void Display()
     {
         System.Console.WriteLine("Registration Id:"+RegistrationId);
               System.Console.WriteLine("Your Name: "+StudentName+" "+"\n"+"Your Father's Name:"+ FatherName+" "+"\n"+"Your Phone number:"+" "+PhoneNumber+" "+"\n"+"Your Date of birth: "+DOB+" "+"\n"+"Your Email Id: "+EmailId+" "+"\n"+"Your Physics mark: "+Physics+"\n"+ "Your Chemistry Mark:"+Chemistry+" "+"\n"+"Your Maths Mark: "+Maths);
     }
     public void Display1()
     {
          System.Console.WriteLine("Registration Id:"+RegistrationId);
               System.Console.WriteLine("Your Name: "+StudentName+" "+"\n"+"Your Father's Name:"+ FatherName+" "+"\n"+"Your Phone number:"+" "+PhoneNumber+" "+"\n"+"Your Date of birth: "+DOB+" "+"\n"+"Your Email Id: "+EmailId+" "+"\n"+"Your Physics mark: "+Physics+"\n"+ "Your Chemistry Mark:"+Chemistry+" "+"\n"+"Your Maths Mark: "+Maths);
     }
      
      public bool CheckEligibility(double cutOff)
      {
          int sum=Physics+Chemistry+Maths;
          double average=sum/3;
        if(average>=cutOff)
        {
                return true;
        }
         else
         {
                return false;
         }
      }

         
        

          

        
          
         
       
            
            

            
            
            
            
            
            
            
            
            
            
            
            
            
        
    }
}