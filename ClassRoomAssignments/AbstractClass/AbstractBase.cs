namespace AbstractClass
{
    public abstract class  AbstractBase
    {
        protected string name;//Normal field
        public abstract string Name { get; set; } //Abstract property
        public double Amount { get; set; } //Normal Property
        
        
        

        public void Display()
        {
            System.Console.WriteLine("Name: "+Name);
        }
        public abstract void Salary(int dates);
        
    }
}