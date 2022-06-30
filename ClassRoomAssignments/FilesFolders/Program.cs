using System;
using System.IO;
namespace FilesFolders
{
    class Program
    {
        static void Main(string[] args)
        {
         string path=@"C:\Users\DhaneshPriyaSankar\OneDrive - Syncfusion\Desktop\New folder";
    
        string folderPath=path+"/My Folder";
        string filePath=path+"/newFile.txt";

        if(!Directory.Exists(folderPath))
        {
             
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            Console.WriteLine("Directory Already Exists");
        }
        if(!File.Exists(filePath))
        {
           
            File.Create(filePath);
        }
        else
        {
           Console.WriteLine("File Already Exists");
        }
     Console.WriteLine("Select option\n 0.Exit\n1.Create Folder\n2.Create File\n3.Delete Folder\n4.Delete File");
     int num=int.Parse(Console.ReadLine());

     switch(num)
     {
         case 0:
         {
             break;
         }
         case 1:
         {
             Console.WriteLine("Enter the folder do you want to create: ");
             string name1=Console.ReadLine();
             string newPath=path+"\\"+name1;
             if(!Directory.Exists(newPath))
             {
                Directory.CreateDirectory(newPath);
             }
             else
             {
               Console.WriteLine("Directory Already Exists");
             }
             break;
         }
         case 2:
         {
            Console.WriteLine("Enter file name you want to create");
            string name1=Console.ReadLine();
            Console.WriteLine("Enter the extension you want to create:");
            string name2=Console.ReadLine();
            string newPath=path+"\\"+name1+"."+name2;
            if(!File.Exists(newPath))
            {
                File.Create(newPath);
            }
            else
            {
                Console.WriteLine("File Already Exists");
            }

             break;
         }
         case 3:
         {
             foreach(string name in Directory.GetDirectories(path))
             {
                 System.Console.WriteLine(name);
             }
             System.Console.WriteLine("Select folder you want to delete");
             string name1=Console.ReadLine();
             string newPath=path+"\\"+name1;
             foreach(string name in Directory.GetDirectories(path))
             {
                 if(name==newPath)
                 {
                     Directory.Delete(newPath);
                 }
             }

             break;
         }
         case 4:
         {
             foreach(string name in Directory.GetFiles(path))
             {
                 System.Console.WriteLine(name);
             }
             System.Console.WriteLine(" Select file you want to delete: ");
             string name1=Console.ReadLine();
             System.Console.WriteLine("Enter the extention you want to delete: ");
             string name2=Console.ReadLine();
             string newPath=path+"\\"+name1+"."+name2;
             foreach(string name in Directory.GetFiles(path))
             {
                 if(name==newPath)
                 {
                     File.Delete(newPath);
                     System.Console.WriteLine("File deleted");
                 }
             }
             break;
         }

     }
     

            


       } 
        
                
    }
    
}
