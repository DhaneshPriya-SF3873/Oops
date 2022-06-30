using System;
namespace SelectionSort
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
            for(int i=0; i<input; i++)
            {
                for(int j=i+1; j<input; j++)
                {
                    if(numberArray[i]>numberArray[j])
                    {
                       int temp=numberArray[i];
                        numberArray[i]=numberArray[j];
                        numberArray[j]=temp;

                    }
                }
            }
            for( int i=0; i<input; i++)
            {
                
            System.Console.WriteLine(numberArray[i]+" ");
                
            }
            

           

            
            

            
            


       } 
        
                
    }
    
}
