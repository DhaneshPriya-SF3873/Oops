using System;
using System.Collections.Generic;
namespace CafeteriaCardManagement
{
    class Program
    { 
         static    List<UserRegistration> userRegistrationList =new List<UserRegistration>();
            static  UserRegistration currentUser=null;
              static List<FoodDetails> foodDetailList=new List<FoodDetails>();
              static List<OrderItem> orderItemList1=new List<OrderItem>();
              static List<OrderItem> orderItemList2=new List<OrderItem>();
              static List<OrderDetails> orderDetailsList=new List<OrderDetails>();
        static void Main(string[] args)
        {
            AddDefaultData();
            MainMenu();
            
        } 
              
            public static void MainMenu()
            {

            
            int option;
            do{
            Console.WriteLine("Select the Main Menu");
            System.Console.WriteLine("1.User Registration\n2.User Login\n3.Exit");
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
                    break;
                }
            }
            }while(option!=3);
            }

         public static void UserRegistration()
            {
                System.Console.WriteLine("Enter the User Name:");
                string userName=Console.ReadLine();
                System.Console.WriteLine("Enter the Mobile Number: ");
                long mobileNumber=long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your Balance: ");
                double balance=double.Parse(Console.ReadLine());
                
                 UserRegistration userDetails=new UserRegistration(userName,mobileNumber,balance);
                 userRegistrationList.Add(userDetails);
                 System.Console.WriteLine("Your user Id: "+userDetails.UserId);
                 
            }

              public static  void UserLogin()
              {
                  System.Console.WriteLine("Enter your user Id: ");
                  string userId=Console.ReadLine();
                  foreach(UserRegistration check in userRegistrationList)
                  {
                      if(userId==check.UserId)
                      {
                         currentUser=check;
                         SubMenu();
                      }
                  }
              }

               public static void SubMenu()
              {
                  int option;
                  do
                  {
                  System.Console.WriteLine("SubMenu");
                  System.Console.WriteLine("1.FoodOrder\n2.View Food Order History\n3.Recharge\n4.Exit");
                   option=int.Parse(Console.ReadLine());
                  switch(option)
                  {
                      case 1:
                      {
                         FoodOrder();
                          break;
                      }
                      case 2:
                      {
                          ShowFoodOrderHistory();
                          break;
                      }
                      case 3:
                      {
                          Recharge();
                          break;
                      }
                      case 4:
                      {
                          break;
                      }
                  }
                  
                  }while(option!=4);
                  
              }
           

        public static void AddDefaultData()
            {

               UserRegistration user1=new UserRegistration("Ravichandran",8857777575,400);
               UserRegistration user2=new UserRegistration("Baskaran",9577747744,500);

                FoodDetails order1=new FoodDetails("Coffee",20,1000);
                foodDetailList.Add(order1);
                FoodDetails order2=new FoodDetails("Tea",15,1000);
                foodDetailList.Add(order2);
                FoodDetails order3=new FoodDetails("Biscuit",10,1000);
                foodDetailList.Add(order3);
                FoodDetails order4=new FoodDetails("Juice",50,1000);
                foodDetailList.Add(order4);
                FoodDetails order5=new FoodDetails("Puff",40,1000);
                foodDetailList.Add(order5);

                OrderDetails orderdetail1=new OrderDetails("SF1001",DateTime.Now,orderItemList1,70);
                OrderDetails orderdetail2=new OrderDetails("SF1002",DateTime.Now,orderItemList2,100);
                orderDetailsList.Add(orderdetail1);
                orderDetailsList.Add(orderdetail2);

                OrderItem orderitem1=new OrderItem("FID101","Coffee",20,1);
                OrderItem orderitem2=new OrderItem("FID103","Biscuit",10,1);
                OrderItem orderitem3=new OrderItem("FID105","Puff",40,1);
                orderItemList1.Add(orderitem1);
                orderItemList1.Add(orderitem2);
                orderItemList1.Add(orderitem3);

                OrderItem orderitem4=new OrderItem("FID103","Biscuit",10,1);
                OrderItem orderitem5=new OrderItem("FID104","Juice",50,1);
                OrderItem orderitem6=new OrderItem("FID105","Puff",40,1);
                orderItemList2.Add(orderitem4);
                orderItemList2.Add(orderitem5);
                orderItemList2.Add(orderitem6);


                


           
             }
    public static void FoodOrder()
    {
        foreach(FoodDetails foods in foodDetailList)
        {
           
            System.Console.WriteLine("Food Id: "+foods.FoodId+"\n"+"Food Name: "+foods.FoodName+"\n"+"FoodPrice:"+foods.Price+"\n"+"Available Quantity: "+foods.AvailableQuantity);
        }
        string foodId,option;
         
         do{

         System.Console.WriteLine("Enter the Food Id:");
         foodId=Console.ReadLine();
         System.Console.WriteLine("Enter the number of Quantity: ");
         int availableQuantity=int.Parse(Console.ReadLine());
         System.Console.WriteLine("Do you want to pick other Product");
         option=Console.ReadLine();
         }while(option=="yes");
        foreach(FoodDetails foods in foodDetailList)
        {

          if(foods.Price<currentUser.Balance)
          {
             foods.Price=foods.AvailableQuantity*foods.Price;
           System.Console.WriteLine("Your Price amount is: "+foods.Price);
           System.Console.WriteLine("Order placed Successfully"); 

           OrderItem order1=new OrderItem(foods.FoodId,foods.FoodName,foods.Price,foods.AvailableQuantity);
           orderItemList1.Add(order1);
           
          }
          
          else
          {
              System.Console.WriteLine("Insufficient Balance");
          }
          
        }
         
   }

        public static void ShowFoodOrderHistory()
        {
         foreach(OrderDetails orders in orderDetailsList)
         {
             System.Console.WriteLine("Order Id:"+orders.OrderId+"\n"+"User Id: "+orders.UserId+"\n"+"Order Date: "+orders.OrderDate+"\n"+"Order List:"+orders.OrderList);
         }
             
         
        }
       public static void Recharge()
       {
           System.Console.WriteLine("Enter the amount to be recharged");
           double recharge=double.Parse(Console.ReadLine());
           currentUser.Balance=currentUser.Balance+recharge;
           System.Console.WriteLine("Your Recharge amount is: "+currentUser.Balance);
           
       }
    

    


        


        
    



            


       
        
                
    }
    
}
