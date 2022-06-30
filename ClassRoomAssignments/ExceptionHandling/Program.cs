using System;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            Console.WriteLine("Enter 2 numbers: ");
            int number1=int.Parse(Console.ReadLine());
            int number2=int.Parse(Console.ReadLine());
            int result=number1/number2;
          
             }
             catch(FormatException e)
             {
                 System.Console.WriteLine(e.Message);
             }
             catch(DivideByZeroException e)
             {
                 System.Console.WriteLine(e.Message);
                 System.Console.WriteLine(e.StackTrace);
             }
             catch(Exception e)
             {
                 System.Console.WriteLine(e.Message);
                 
             }
            finally
            {
                System.Console.WriteLine("Final Block Executed");
            }

            
            


       } 
        
                
    }
    
}