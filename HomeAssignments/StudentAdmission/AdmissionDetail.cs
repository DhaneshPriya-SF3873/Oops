using System;
namespace StudentAdmission
{
    public enum Status{Default,Booked,Cancelled}
    public class AdmissionDetail
    {
        private static int s_admissionId=1000;
        public string AdmissionId { get;  }
        public string StudentId { get;  }
         public string DepartmentId { get;  }
        public DateTime AdmissionDate { get; set; }
        public Status AdmissionStatus { get; set; }


        public AdmissionDetail(string studentId,string departmentId,DateTime admissionDate,Status admissionStatus)
        {
            s_admissionId++;
            AdmissionId="AID"+s_admissionId;
            StudentId=studentId;
            DepartmentId=departmentId;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;
        }
        
        


        
        
        
        
    }
}