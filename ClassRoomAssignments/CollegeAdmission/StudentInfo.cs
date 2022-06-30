using System;
namespace CollegeAdmission
{ 
    /// <summary>
    /// Used to select the Student's Gender Information
    /// </summary>
    public enum Gender {Default,Male,Female,Transgender}
    /// <summary>
    /// Class <see cref="StudentInfo" /> used to collect student's details for the admission process
    /// </summary>
    public class StudentInfo
    {
        //  Field
        /// <summary>
        /// Static field used to auto increment and it uniquely identify an instance of <see cref="StudentInfo"/> class's Object
        /// </summary>
            private static int s_registerNumber=3000;
            //Property
            /// <summary>
            /// property RegisterNumber used to uniquely identify a <see cref="StudentInfo"/> class's Object
            /// </summary>
        

            public string RegistrationId { get; } 
            /// <summary>
            /// Property Name used to provide a name for the student in the object of <see cref="StudentInfo"/> class
            /// </summary>
            
            public string StudentName { get; set; }
            /// <summary>
            /// Property FatherName used to provide a name for the student in the object of <see cref="StudentInfo"/> class
            /// </summary>
           
            public string FatherName { get; set; }
            /// <summary>
            /// Property Gender used to provide a gender for the student in the object of <see cref="StudentInfo"/> class
            /// </summary>
            

            public Gender Gender { get; set; }
            /// <summary>
            /// Property PhoneNumber used to provide a PhoneNumber for the student in the object of <see cref="StudentInfo"/> class
            /// </summary>
            /// <value></value>
            public long PhoneNumber { get; set; }
            /// <summary>
            /// Property EmailId used to provide a EmailId for the student in the object of <see cref"=StudentInfo"/> class
            /// </summary>
            /// <value></value>
            public string EmailId { get; set; }
            /// <summary>
            /// Property DOB used to provide a DOB for the student in the object of <see cref="StudentInfo"/> class
            /// </summary>
            /// <value></value>
            public DateTime DOB { get; set; }
            /// <summary>
            /// Property Physics used to provide a physics for the student in the object of <see cref="StudentInfo"/> class
            /// </summary>
            
            public int Physics { get; set; }
            /// <summary>
            /// Property Chemistry used to provide a chemistry for the student in the object of <see cref="StudentInfo"/> class
            /// </summary>
         
            public int Chemistry { get; set; }
            /// <summary>
            /// Property Maths used to provide a Maths for the student in the object of <see cref="StudentInfo"/> class
            /// </summary>
            /// <value></value>
            public int Maths { get; set; }
      /// <summary>
      /// Constructor of<see cref="StudentInfo"/> class used to initaialize values to its properties
      /// </summary>
      /// <param name="name"> Parameter name used to initialize a Student's Name to Name Property</param>
      /// <param name="fatherName"> Parameter fatherName used to initialize a Student's Father Name to Father's Name Property</param>
      /// <param name="gender"> Parameter gender used to initialize a Student's Gender to Gender Property</param>
      /// <param name="dob"> Parameter dob used to initaialize a Student's dob to dob Property</param>
      /// <param name="phoneNumber"> Parameter phoneNumber used to initaialize a Student's phoneNumber to phoneNumber Property</param>
      /// <param name="mailid">Parameter mailid used to initaialize a Student's mailid to mailid Property</param>
      /// <param name="physics">Parameter physics used to initaialize a Student's physics to physics Property</param>
      /// <param name="chemistry">Parameter chemistry used to initaialize a Student's chemistry to chemistry Property</param>
      /// <param name="maths">Parameter maths used to initaialize a Student's maths to maths Property</param>
 

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
         Chemistry=chemistry;
         Maths=maths;
         


     }
     /// <summary>
     /// Method DisplayDetails display the details of the Student information in the object of <see cref="StudentInfo"/> class
     /// </summary>
     public void DisplayDetails()
     {
         System.Console.WriteLine("Registration Id:"+RegistrationId);
               System.Console.WriteLine("Your Name: "+StudentName+" "+"\n"+"Your Father's Name:"+ FatherName+" "+"\n"+"Your Gender: "+Gender+"\n"+"Your Phone number:"+" "+PhoneNumber+" "+"\n"+"Your Date of birth: "+DOB+" "+"\n"+"Your Email Id: "+EmailId+" "+"\n"+"Your Physics mark: "+Physics+"\n"+ "Your Chemistry Mark:"+Chemistry+" "+"\n"+"Your Maths Mark: "+Maths);
     }

     
     /// <summary>
     /// Method check eligibility get cutoof value as parameter and check the eligibility of the student
     /// If cutoff less than or equal the he is eligible and return true else false
     /// </summary>
     /// <param name="cutOff">used to provide cutoff value for eligibility checking</param>
     /// <returns>returns true eligible else false</returns>
      
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
      /// <summary>
      /// Method Calculate display the average of the student mark in the physics,chemistry and maths.
      /// </summary>
       public  void Calculate()
    {
         int total=Physics+Chemistry+Maths;
          double average=total/3.0;
          System.Console.WriteLine("The Total mark is"+total +"\t"+"Average is:"+average);
    } 
}
}
