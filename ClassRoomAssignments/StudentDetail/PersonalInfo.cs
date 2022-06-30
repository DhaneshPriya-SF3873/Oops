using System;
namespace StudentDetail
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }


        public void DisplayPersonalInfo()
        {
            System.Console.WriteLine("Student Name is:"+ Name);
            System.Console.WriteLine("Father Name is:" +FatherName);
        }
        
        
        
        
        
        
    }
}