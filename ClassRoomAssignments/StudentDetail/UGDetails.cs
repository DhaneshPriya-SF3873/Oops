namespace StudentDetail
{
    public class UGDetails:HscMarks,ICalculateUG
    {
        public int Sem1 { get; set; }
        public int Sem2 { get; set; }
        public int Sem3{ get; set; }
        public int Sem4 { get; set; }


        public void DisplayUGMarks()
        {
            System.Console.WriteLine("Display UG Marks:"+"Sem 1: "+Sem1+"Sem 2: "+Sem2+"Sem 3: "+Sem3+"Sem 4: "+Sem4);
            

        }


        public void CalculateUGScore()
        {
             Total=Physics+Chemistry+Maths;
             Average=(Total/3);
            System.Console.WriteLine("Total: "+Total);
            System.Console.WriteLine("Average: "+Average);


        }
        
        
    }
}