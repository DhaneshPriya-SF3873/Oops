using System;
using System.IO;
namespace ReadWriteTestFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
                Console.WriteLine("Folder Created");
            }
            else
            {
                System.Console.WriteLine("Folder Exists");
                if(!File.Exists("TestFolder/Test.txt"))
                {
                    File.Create("TestFolder/Test.txt");
                    System.Console.WriteLine("File created");
                }
                else
                {
                    System.Console.WriteLine("File Found");
                }

                
            }
            
       System.Console.WriteLine("Select option 1.Read File Info 2.Write File Info");    
       int option=int.Parse(Console.ReadLine());
       switch(option)
       {
           case 1:
           {
               string line;
               StreamReader sr=null;
               try
               {
                   //pass the filepath and file to streamReader Constructor
                   sr=new StreamReader("TestFolder/Test.txt");
                   //Read the first line of text
                   line=sr.ReadLine();
               while(line!=null)
               {
                   //write the line to console window
                  Console.WriteLine(line);
                   //Read the next line
                   line=sr.ReadLine();
               }
               }catch(Exception e)
               {
                 Console.WriteLine("Exception: "+e.Message);
               }
               finally
               {
                   Console.WriteLine("Executing final block");
                   sr.Close();
               }
              break;
               

           }

           case 2:
           {
               StreamWriter sw=null;
               try
               {
                   string []old=File.ReadAllLines("TestFolder/Test.txt");
                   //pass the filepath and file name to the StreamWriter constructor
                   sw=new StreamWriter("TestFolder/Test.txt");
                   System.Console.WriteLine("Enter new content to be placed in file");
                   string info=Console.ReadLine();
                   string old1="";
                   foreach(string text in old)
                   {
                       old1=old1+"\n"+text;
                   }//append old text info
                   old1=old1+"\n"+info;
                   sw.WriteLine(old1);
               }
               catch(Exception e)
               {
                   System.Console.WriteLine("Exception: "+e.Message);

               }
               finally
               {
                   //close the file;
                   sw.Close();
               }

               break;
                   

               }

               
           }

       }

       


       } 
        
                
    }
    
