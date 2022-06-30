using System;
namespace Sorting1
{
    class Program
    {
        static void Main(string[] args)
        {
          int [] array=new int[5]{20,30,49,76,56};
         int length= array.Length;
         Sorting value=new Sorting();
    
         value.BubbleSort(array);
         value.InsertionSort(array);
         value.SelectionSort(array);
         
         

         

          



            


       } 
        
                
    }
    
}