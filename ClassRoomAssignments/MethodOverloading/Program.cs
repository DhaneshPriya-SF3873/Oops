using System;
namespace MethodOverloading
{
    class Program
    {

        //method with one parameter
        static void Display(int a)
        {
            System.Console.WriteLine("Arguments: "+a);
        }

        //method with two parameters

        static void Display(int a, int b)
        {
            System.Console.WriteLine("Arguments: "+a+" "+"and"+" "+b);
        }

        static void Display(string a)
        {
            System.Console.WriteLine("Name: "+a);
        }
        static void Main(string[] args)
        {
            
            Display(100);
            Display(100,200);
            Display("Dhanesh");
            Console.ReadLine();
            


       } 
        
                
    }
    
}