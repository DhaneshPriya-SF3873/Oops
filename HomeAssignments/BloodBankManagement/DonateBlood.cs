using System;
namespace BloodBankManagement
{
    public class DonateBlood
    {
        public double Weight { get; set; }
        public int  BloodPressure { get; set; }
        public double Hemoglobin { get; set; }
        
        


        public void DonateBlood1()
        {
            System.Console.WriteLine("Enter the weight:'");
            double Weight=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Blood Pressue: ");
            int BloodPressure=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Hemoglobin level: ");
            double Hemoglobin=double.Parse(Console.ReadLine());
            if(Hemoglobin>13)
            {
                System.Console.WriteLine("You are eligible");
            }
            else
            {
                System.Console.WriteLine("You are not eligible for Donating Blood");
            }

            
        }
        
        
    }
}