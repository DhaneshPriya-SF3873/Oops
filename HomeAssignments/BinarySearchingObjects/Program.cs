using System;
using System.Collections.Generic;
namespace BinarySearchingObjects
{
    class Program
    {

        static int BinarySearch(List<Student> array,string element, out Student student)
        {
            int left=0, right=array.Count-1;
            while(left<=right)
            {
                int middle=left+(right-left)/2;

                if(array[middle].RegNum==element)
                {
                    student=array[middle];
                    return middle;
                }

                if(array[middle].RegNum.CompareTo(element)<0)
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
        static void Main(string[] args)
        {
            List<Student> studentList=new List<Student>();
            studentList.Add(new Student(){RegNum="SF1",Name="Dhanesh"});
            studentList.Add(new Student(){RegNum="SF2",Name="Priya"});
            studentList.Add(new Student(){RegNum="SF3",Name="Anu"});
            studentList.Add(new Student(){RegNum="SF4",Name="Madhu"});
            studentList.Add(new Student(){RegNum="SF5",Name="Saghana"});
            studentList.Add(new Student(){RegNum="SF6",Name="Sri"});

            string element="SF7";

            Student student;
            int result=BinarySearch(studentList,element,out student);
            if(result==-1)
            {
                System.Console.WriteLine("Element not found");
            }
            else
            {
                System.Console.WriteLine("Element found at index "+result+" "+"Reg Id: "+student.RegNum+"Name: "+student.Name);
            }
        

            




            


       } 
        
                
    }
    
}
