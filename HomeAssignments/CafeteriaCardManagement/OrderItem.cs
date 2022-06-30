namespace CafeteriaCardManagement
{
    public class OrderItem
    {
         public string FoodId { get;}
         public string FoodName { get; set; }
         public double Price { get; set; }
         public int Count { get; set; }
           


           public OrderItem(string foodId,string foodName,double price,int count )
           {
               FoodId=foodId;
               FoodName=foodName;
               Price=price;
               Count=count;
               
           }
         
         
         

    }
}