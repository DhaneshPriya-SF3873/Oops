using System;
namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numberArray=new int[5];
            Console.WriteLine("Enter the input");
            int input=int.Parse(Console.ReadLine());
            for(int i=0; i<input; i++)
            {
                Console.WriteLine("Element"+i+" "+":");
                numberArray[i]=int.Parse(Console.ReadLine());
            }
            for(int i=1; i<input; i++)
            {
                int temp=numberArray[i];
                 int j=i-1;
                 while(j>=0 && numberArray[j]>temp)
                 {
                     numberArray[j+1]=numberArray[j];
                     j=j-1;
                 }
            numberArray[j+1]=temp;
            }

            for(int i=0; i<input; i++)
            {
                System.Console.WriteLine(numberArray[i]);
            }


       } 
        
                
    }
    
}
