using System;
using System.Collections.Generic;
namespace EbBill
{
    class Program
    {
        static List<EbDetails> ebList=new List<EbDetails>();
        static EbDetails currentUser=null;


        static void Main(string[] args)
        {
             Default();
            int option;
            do
            {

            
           System.Console.WriteLine("Select the Main Menu");
           System.Console.WriteLine("select the option\n1.Registration\n2.Login\n3.Exit");
            option=int.Parse(Console.ReadLine());
           switch(option)
           {
               case 1:
               {
                   Registration();
                   break;
               }
               case 2:
               {
                   Login();
                   break;

               }
               case 3:
               {
                   break;
               }
           }
        }while(option!=3);  



        static void Registration()
        {
          System.Console.WriteLine("Enter Your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter Your Father's Name: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter Your Email Id:");
            string mailId=Console.ReadLine();
            System.Console.WriteLine("Enter Your Phone Number: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            
            

           EbDetails ebDetail1=new EbDetails(name,fatherName,mailId,phoneNumber);
           ebList.Add(ebDetail1);
        }

   static void Default()
   {
       EbDetails ebDetail1=new EbDetails("Dhanesh","Sankar","priya@gmail.com",8245694862);
       ebList.Add(ebDetail1);
   }

   static void Login()
   {
    
    System.Console.WriteLine("Enter the Meter Id");
    string meterId =Console.ReadLine();
     foreach(EbDetails eb in ebList)
     {
         if(meterId==eb.MeterId)
         {
             System.Console.WriteLine("SubMenu");
             currentUser=eb;
             SubMenu();       
      }
      if(meterId!=eb.MeterId)
      {
          System.Console.WriteLine("Invalid User Id");
      }
     }

     static void SubMenu()
     {
         int option;
         do
         {
         System.Console.WriteLine("select the option\n1.CalculateAmount\n2.Display Details\n3.Exit");
         option=int.Parse(Console.ReadLine());
         switch (option)
         {
             case 1:
             {
                 currentUser.RegisterUnits();
                 currentUser.CalculateBill();
                 break;
             }
             case 2:
             {
                 currentUser.DisplayDetails();
                 break;
             }
             case 3:
             {
              break;
             }
         }
         }while(option!=3);
         
     }

    
   }
        }
    }
    
}