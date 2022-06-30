using System;
using System.Collections.Generic;

namespace CafeteriaCardManagement
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderId { get;}
        public string UserId { get; }
        public DateTime OrderDate { get; set; }

        public List<OrderItem> OrderList { get; set; }
        
        public double OrderPrice { get; set; }

        public OrderDetails(string userId,DateTime orderDate,List<OrderItem> orderList,double orderPrice) 
        {
             s_orderId++;
            OrderId="OID"+ s_orderId;
            UserId=userId;
            OrderDate=orderDate;
            OrderList=orderList;
            OrderPrice=orderPrice;
            
        }
        
        
        
        


        
        
    }
}