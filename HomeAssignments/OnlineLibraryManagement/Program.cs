using System;
using System.Collections.Generic;
namespace OnlineLibraryManagement
{
    class Program
    {
       static  List<UserDetails> userDetailsList =new List<UserDetails>();
       static List<BookDetails> bookDetailsList=new List<BookDetails>();

       static List<BorrowDetails> borrowDetailsList=new List<BorrowDetails>();
              static UserDetails currentUser=null;
       
        static void Main(string[] args)
        {
            AddDefaultData();
            ShowMainMenu();
        }
     public static void AddDefaultData()
     {
            UserDetails user1=new UserDetails("Ravichandran",30,Gender.Male,"EEE",9938388333,"ravi@gmail.com");
            UserDetails user2=new UserDetails("Priyadharshini",23,Gender.Feamle,"CSE",9944444455,"priya@gmail.com");
           userDetailsList.Add(user1);
           userDetailsList.Add(user2);

           BookDetails book1=new BookDetails("c#","Author1",3);
           BookDetails book2=new BookDetails("HTML","Author2",5);
           BookDetails book3=new BookDetails("CSS","Author1",3);
           BookDetails book4=new BookDetails("JS","Author1",3);
           BookDetails book5=new BookDetails("TS","Author2",2);
           bookDetailsList.Add(book1);
           bookDetailsList.Add(book2);
           bookDetailsList.Add(book3);
           bookDetailsList.Add(book4);
           bookDetailsList.Add(book5);

           BorrowDetails borrow1=new BorrowDetails("BID101","SF3001",DateTime.Now);
           BorrowDetails borrow2=new BorrowDetails("BID103","SF3001",DateTime.Now);
           BorrowDetails borrow3=new BorrowDetails("BID104","SF3001",DateTime.Now);
           BorrowDetails borrow4=new BorrowDetails("BID102","SF3002",DateTime.Now);
           BorrowDetails borrow5=new BorrowDetails("BID105","SF3002",DateTime.Now);
           borrowDetailsList.Add(borrow1);
           borrowDetailsList.Add(borrow2);
           borrowDetailsList.Add(borrow3);
           borrowDetailsList.Add(borrow4);
           borrowDetailsList.Add(borrow5);
     }

     public static void ShowMainMenu()
     {

     
        int option;
            do
            {

            Console.WriteLine("Select the MainMenu");
            System.Console.WriteLine("Enter the option \n1.User Registration\n2.User Login\n3.Admin Login\n4.Exit");
            option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                {
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    UserLogin();
                    break;
                }
                case 3:
                {
                    LoginMenu();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    break;
                }

            }

            }while(option!=4);
     }
            
        
         static void UserRegistration()
        {
            System.Console.WriteLine("Enter the Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the Age: ");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Select Your Gender 1.Male 2.Female 3.Transgender");
            int genderValue=int.Parse(Console.ReadLine());
            Gender gender=Gender.Default;
            while(!(genderValue>0 && genderValue<4))
            {
                Console.WriteLine("Select Your Gender 1.Male 2.Female 3.Transgender");
                genderValue=int.Parse(Console.ReadLine());
                
            }
            gender=(Gender)genderValue;
            System.Console.WriteLine("Enter the Department: ");
            string department=Console.ReadLine();
            System.Console.WriteLine("Enter the Mobile Number: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Mail Id: ");
            string mailId=Console.ReadLine();
            
        UserDetails userInfo1=new UserDetails(name,age,gender,department,mobileNumber,mailId);
        userDetailsList.Add(userInfo1);
        System.Console.WriteLine("Your User Id: "+userInfo1.UserId);
            
        }


        
         static void SubMenu()
        {
            int option;
            do
            {
            System.Console.WriteLine("Enter the option\n1.Borrow Book\n2.Show Return Date\n3.Show Borrowed Histoy\n4.Return Books\n5.Exit");
             option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                {
                    BorrowBook();
                    break;
                }
                case 2:
                {
                    ShowReturnDate();
                    break;
                }
                case 3:
                {
                    BorrowHistory();
                    break;
                }
                case 4:
                {
                    ReturnBook();
                    break;
                }
                case 5:
                {
                    break;
                }
            }
            }while(option!=5);
        }


    public static void BorrowBook()
    {
        foreach(BookDetails books in bookDetailsList)
        {
            System.Console.WriteLine("Book Id: "+books.BookId+"\n"+"Book Name: "+books.BookName+"\n"+"Book Counts: "+books.BookCount);
         
        }
        System.Console.WriteLine("Enter the Book Id:");
        string bookId=Console.ReadLine();
         foreach(BookDetails books in bookDetailsList)
         {
          if(bookId==books.BookId)
          {
              System.Console.WriteLine("Enter the number of books: ");
              int bookCount=int.Parse(Console.ReadLine());
              if(bookCount<books.BookCount)
              {
                 foreach(BorrowDetails borrow in borrowDetailsList)
                 {
                     borrow.BorrowedDate=DateTime.Now;
                     System.Console.WriteLine("Book Id: "+borrow.BookId+"\n"+"User Id: "+currentUser.UserId+"Borrowed Date:"+borrow.BorrowedDate);
                     
                 }

              } 
              else
              {
                  System.Console.WriteLine("Books are not available for the selected count");
              }
              
          }
         }
        
        
    }

    public static void  ShowReturnDate()
    {
        
         foreach(BorrowDetails borrow in borrowDetailsList)
         {
             borrow.BorrowedDate=DateTime.Now.AddDays(15);
             System.Console.WriteLine("Your Return Date is:" + borrow.BorrowedDate);

         }
    }

    public static void BorrowHistory()
    {
           foreach(BorrowDetails borrow in borrowDetailsList)
                 {
                     borrow.BorrowedDate=DateTime.Now;
                     System.Console.WriteLine("Book Id: "+borrow.BookId+"\n"+"User Id: "+currentUser.UserId+"Borrowed Date:"+borrow.BorrowedDate);
                     
                 }

    }
    
        public static void UserLogin()
        {
            System.Console.WriteLine("Enter the User Id");
            string userId=Console.ReadLine();
            foreach(UserDetails user in userDetailsList)
            {
                if(userId==user.UserId)
                {
                  currentUser=user;
                  SubMenu();
                }
            }
            
        }

              public static void LoginMenu()
              {
                  int option;
                  do{
                  System.Console.WriteLine("1.Return Book 2.Renew Book 3.Exit");
                   option=int.Parse(Console.ReadLine());
                  switch (option)
                  {
                      case 1:
                      {
                          ReturnBook();
                          break;
                      }
                      case 2:
                      {
                          RenewBook();
                          break;
                      }
                      case 3:
                      {
                          break;
                      }
                  }
                  }while(option!=3);

                  
                  
              }


              public static void ReturnBook()
              {
                  foreach(BorrowDetails borrow in borrowDetailsList)
                 {
                     System.Console.WriteLine("Book Id: "+borrow.BookId+"\n"+"User Id: "+currentUser.UserId+"Borrowed Date:"+borrow.BorrowedDate);
                     System.Console.WriteLine("Enter the Borrow Id");
                     string borrowId=Console.ReadLine();
                     System.Console.WriteLine("Enter the User Id");
                     string userId=Console.ReadLine();
                     if(borrowId==borrow.BorrowId && userId==borrow.BorrowId)
                     {
                         System.Console.WriteLine("Book Id: "+borrow.BookId+"\n"+"User Id: "+currentUser.UserId+"Borrowed Date:"+borrow.BorrowedDate);
                     }
                 }

              }

              public static void RenewBook()
              {
                     System.Console.WriteLine("Enter the Borrow Id");
                     string borrowId=Console.ReadLine();
                     System.Console.WriteLine("Enter the User Id");
                     string userId=Console.ReadLine();
                     foreach(BorrowDetails borrow in borrowDetailsList)
                     {
                     if(borrowId==borrow.BorrowId && userId==borrow.BorrowId)
                     {
                         borrow.BorrowedDate=DateTime.Now;
                         System.Console.WriteLine("Book Id: "+borrow.BookId+"\n"+"User Id: "+currentUser.UserId+"Borrowed Date:"+borrow.BorrowedDate);
                     }
                     }

              }
              
    
              
            


       } 
        
                
    }
    
