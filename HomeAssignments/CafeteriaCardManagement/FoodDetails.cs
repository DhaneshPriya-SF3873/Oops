using System;
namespace CafeteriaCardManagement
{
    
    
    public class FoodDetails
    {
        private static int  s_foodId=100; 
        public string FoodId { get;}
        
        
        public string FoodName { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
        

        public FoodDetails(string foodName, double price, int availableQuantity)
        {
            s_foodId++;
            FoodId="FID"+s_foodId;
            FoodName=foodName;
            Price=price;
            AvailableQuantity=availableQuantity;

        }
            


        }
        
        
        
        
        
        
    }
