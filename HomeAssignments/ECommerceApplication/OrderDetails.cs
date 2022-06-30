using System;
namespace ECommerceApplication
{
    public enum Status{Default,Ordered,Cancelled}
    public class OrderDetails
    {
        private static int s_orderId=1000;
        public string OrderId { get;  }
        public string ProductId { get; set; }
        public string CustomerId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public Status OrderStatus { get; set; }


        public OrderDetails(string customerId,string productId,double totalPrice,DateTime purchaseDate,int quantity,Status orderStatus)
        {
            CustomerId=customerId;
            ProductId=productId;
            TotalPrice=totalPrice;
            PurchaseDate=purchaseDate;
            Quantity=quantity;
            OrderStatus=orderStatus;


        }
        
        
        
        
        
        
        
    }
}