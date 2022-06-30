using System;
namespace StudentDetail
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UGDetails info=new UGDetails();
            info.Name="Dhanesh";
            info.FatherName="Sankar";
            info.Chemistry=90;
            info.Maths=76;
            info.Physics=78;
            info.Sem1=66;
            info.Sem2=74;
            info.Sem3=89;
            info.Sem4=90;
            info.CalculateHscScore();
            info.CalculateUGScore();
            info.DisplayPersonalInfo();
            info.DisplayUGMarks();


            



        





       } 
        
                
    }
    
}
