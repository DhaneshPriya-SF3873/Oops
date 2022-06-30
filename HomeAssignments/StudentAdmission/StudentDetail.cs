using System;
namespace StudentAdmission
{
    public enum Gender{Default,Male,Female}
    public class StudentDetail
    {
            private static int s_studentId=3000;
            public string StudentId { get;  }
            public string StudentName { get; set; }
            public string FatherName { get; set; }
            public DateTime DOB { get; set; }
            public Gender Gender { get; set; }
            public int Physics { get; set; }
            public int Chemistry { get; set; }
            public int Maths { get; set; }
            
            public StudentDetail(string studentName,string fatherName,DateTime dOB,Gender gender,int physics,int chemistry,int maths)
            {
              s_studentId++;
              StudentId="SF"+s_studentId;
              StudentName=studentName;
              FatherName=fatherName;
              DOB=dOB;
              Gender=gender;
              Physics=physics;
              Chemistry=chemistry;
              Maths=maths;
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