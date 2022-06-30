namespace StudentDetail
{
    public class HscMarks:PersonalInfo,Icalculate
    {
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }
        
        
        
        public void Calculate()
        {
             Total=Physics+Chemistry+Maths;
             Average=(Total/3);
            System.Console.WriteLine("Total: "+Total);
            System.Console.WriteLine("Average: "+Average);


        }



        public void CalculateHscScore()
        {
         
         System.Console.WriteLine("Your Marks is Physics "+Physics+"Chemistry "+Chemistry+"Maths "+Maths);
        }
        
        
        
        
        
        
    }
}