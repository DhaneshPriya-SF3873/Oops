using System;
namespace LinearSearch
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
            Console.WriteLine("Enter the number you want to found");
            int number=int.Parse(Console.ReadLine());
            for( int i=0; i<input; i++)
            {
                if(number==numberArray[i])
                {
                    System.Console.WriteLine("The number is at position"+" "+i);
                }
            }

           

            
            

            
            


       } 
        
                
    }
    
}

