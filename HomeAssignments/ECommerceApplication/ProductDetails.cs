using System;
namespace ECommerceApplication
{
    public class ProductDetails
    {
        private static int s_productId=100;
        public string ProductId { get; set; }
        
        
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public int ShippingDuration { get; set; }
        
        
        
        public ProductDetails(string productName,int stock,int price,int shippingDuration)
        {
              s_productId++;
              ProductId="PID"+s_productId;
              ProductName=productName;
              Stock=stock;
              Price=price;
              ShippingDuration=shippingDuration;
              
        }
        
        
        
        
    }
}