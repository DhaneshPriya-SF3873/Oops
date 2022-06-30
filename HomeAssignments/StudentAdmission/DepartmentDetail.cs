namespace StudentAdmission
{
    public class DepartmentDetail
    {
        private static int s_departmentId=100;
        public string DepartmentId { get;  }

        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }
        
        public DepartmentDetail(string departmentName,int numberOfSeats)
        {
           s_departmentId++;
           DepartmentId="DID"+s_departmentId;
           DepartmentName=departmentName;
           NumberOfSeats=numberOfSeats;

        }
        
        
        
        
        
    }
}