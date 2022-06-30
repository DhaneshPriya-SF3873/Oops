using System;
using System.Collections.Generic;
namespace ECommerceApplication
{
    class Program
    {
       static List<CustomerDetails> customerDetailsList=new List<CustomerDetails>();
        static List<ProductDetails> productDetailsList=new List<ProductDetails>();
            
         static   List<OrderDetails> orderDetailsList=new List<OrderDetails>();
          static  CustomerDetails currentUser=null;
          static OrderDetails cancelProduct=null;
        static void Main(string[] args)
        {
          CustomerDefault();
          ProductDefault();
           OrderDefault();
            
            int option;
            do
            {
            System.Console.WriteLine("Select the Main Menu");
            System.Console.WriteLine("1.Customer Registration\n2.Login and Purchase\n3.Exit");
            option=int.Parse(Console.ReadLine());
            switch (option)
            {
                
                case 1:
                {
                    CustomerRegistration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
            }
            }while(option!=3);
        }
          public static  void CustomerRegistration()
            {
                System.Console.WriteLine("Enter the Customer Name: ");
                string customerName=Console.ReadLine();
                System.Console.WriteLine("Enter the City: ");
                string city=Console.ReadLine();
                System.Console.WriteLine("Enter the Mobile Number: ");
                long mobileNumber=long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the Wallet Initial balance: ");
                double walletBalance=double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the Email Id: ");
                string emailId=Console.ReadLine();
                

                CustomerDetails details1=new CustomerDetails(customerName,city,mobileNumber,walletBalance,emailId);
                System.Console.WriteLine("Your Id is: "+details1.CustomerId);
                customerDetailsList.Add(details1);
                
            }

            static void CustomerDefault()
            {
                CustomerDetails customer1=new CustomerDetails("Ravi","Chennai",9885858588,50000,"ravi@mail.com");
                customerDetailsList.Add(customer1);
                CustomerDetails customer2=new CustomerDetails("Baskaran","Chennai",9888475757,60000,"baskaran@mail.com");
                customerDetailsList.Add(customer2);
            }

            static void ProductDefault()
         {
             ProductDetails product1=new ProductDetails("Mobile",10,10000,3);
             productDetailsList.Add(product1);
             ProductDetails product2=new ProductDetails("Tablet",5,15000,2);
             productDetailsList.Add(product2);
             ProductDetails product3=new ProductDetails("Camera",3,20000,4);
             productDetailsList.Add(product3);
             ProductDetails product4=new ProductDetails("iPhone",5,50000,6);
             productDetailsList.Add(product4);
             ProductDetails product5=new ProductDetails("Laptop",3,40000,3);
             productDetailsList.Add(product5);
         }

         static void OrderDefault()
         {
             OrderDetails order1=new OrderDetails("CID1001","PID101",20000,DateTime.Today,2,Status.Ordered);
             orderDetailsList.Add(order1);
             OrderDetails order2=new OrderDetails("CID1002","PID102",40000,DateTime.Today,2,Status.Ordered);
             orderDetailsList.Add(order2);

         }

         public static void WalletBalance()
      {
          System.Console.WriteLine("Your current balance is:" +currentUser.WalletBalance);
          System.Console.WriteLine("Do You want to recharge(Yes/No");
          string recharge=Console.ReadLine().ToLower();
          if(recharge=="yes")
          {
            System.Console.WriteLine("Enter the amount: ");
            double amount=double.Parse(Console.ReadLine());
            currentUser.WalletBalance=currentUser.WalletBalance+amount;
            System.Console.WriteLine("Your updated Wallet balance is: "+currentUser.WalletBalance);
            
          }
          
      }

       public static void ProductList()
       {
           System.Console.WriteLine("Product Id \tProductName \tPrice Per Quantity \tAvailable Stock Quantity \tShipping Duration");
           foreach(ProductDetails product in productDetailsList)
           {
               System.Console.WriteLine(product.ProductId+"\t"+"\t"+product.ProductName+"\t"+"\t"+product.Price+"\t"+"\t"+"\t"+product.Stock+"\t"+"\t"+"\t"+product.ShippingDuration);         }
       }

       public static void Purchase()
           {
               DateTime deliveryDate;
               double totalPrice=0;
               System.Console.WriteLine("Enter the Product Id: ");
               string productId=Console.ReadLine().ToUpper();
               System.Console.WriteLine("Enter the quantity to be purchased: ");
               int quantity=int.Parse(Console.ReadLine());
               System.Console.WriteLine("Enter the purchase date: ");
               DateTime purchaseDate=DateTime.Now;
               
               foreach(ProductDetails product in productDetailsList)
               {
                   if(quantity>product.Stock)
                   {
                       System.Console.WriteLine("Required Count Not Available");
                   }
                   else
                   {
                       totalPrice=(quantity*product.Price)+500.0;
                       if(totalPrice>currentUser.WalletBalance)
                       {
                           System.Console.WriteLine("Insufficient Wallet Balance! Please recharge your wallet");
                       }
                       else
                       {
                           currentUser.WalletBalance=currentUser.WalletBalance-totalPrice;
                           product.Stock=product.Stock-quantity;
                           deliveryDate=purchaseDate.AddDays(product.ShippingDuration); 
                           OrderDetails order=new OrderDetails(currentUser.CustomerId,productId,totalPrice,purchaseDate,quantity,orderStatus);
           orderDetailsList.Add(order);
                           System.Console.WriteLine("Order placed successfully! Your order will be delivered on "+deliveryDate.ToString("dd/MM/yyyy");
                       }
                   }
               
           
                   
               }
           }
    
         public static void OrderHistory()
         {
           
               System.Console.WriteLine("Order Id \tCustomer Id \t Product Id \t TotalPrice \t  Purchase Date\t\tQuantity\t\tOrderStatus");
           
           foreach(OrderDetails order in orderDetailsList)
           {
               if(order.CustomerId==currentUser.CustomerId)
               {
                   System.Console.WriteLine(order.OrderId+order.ProductId+"\t"+"\t"+order.TotalPrice+"\t"+"\t"+order.PurchaseDate+"\t"+"\t"+order.Quantity+"\t"+"\t"+order.OrderStatus);
               }
           }
         }
        
    
        public  static void CancelOrder()
        {
         
         System.Console.WriteLine("Enter the id to be cancelled: ");
         string orderId=Console.ReadLine().ToUpper();
         foreach(OrderDetails order in orderDetailsList)
         {
             if(orderId==order.OrderId)
             {
                 cancelProduct=order;
                 currentUser.WalletBalance=currentUser.WalletBalance+order.TotalPrice;
                 order.OrderStatus=Status.Cancelled;
             }
         }
         
        }
        public   static void Login()
        {
            System.Console.WriteLine("Enter your Customer Id");
            string CustomerId=Console.ReadLine();
            foreach(CustomerDetails customer in customerDetailsList)
            {
                if(CustomerId==customer.CustomerId)
                {
                    System.Console.WriteLine("Login Successful");
                    currentUser=customer;
                    SubMenu();

                }
                else
                {
                    System.Console.WriteLine("Invalid Customer Id");
                }
            }
        }
           
        static  void SubMenu()
         {
             int option;
             do
             {
             System.Console.WriteLine("SubMenu");
             System.Console.WriteLine("1.Purchase\n2.OrderHistory\n3.Cancel Order\n4.Wallet Balance\n5.Exit");
             option=int.Parse(Console.ReadLine());
             switch (option)
             {
                 case 1:
                 {
                     ProductList();
                     Purchase();
                     break;
                 }
                 case 2:
                 {
                     OrderHistory();
                     break;
                 }
                 case 3:
                 {
                    OrderHistory();
                    CancelOrder();
                     break;
                 }
                 case 4:
                 {
                     WalletBalance();
                     break;
                 }
                 case 5:
                 {
                    
                     break;
                 }
                
             }
             
         }while(option!=5);
         }


         


         
         
  

     
      
    
    
      



         

    
        
                
    }
    
}