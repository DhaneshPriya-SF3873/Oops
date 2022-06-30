using System;
namespace AbstractClass
{
    public class Syncfusion:AbstractBase
    {
        //Abstract property definition
        public override string Name { get{return name;} set{name=value;} }

        //Abstract method definition

       public override void Salary(int dates)
       {
        Display();
        Amount=(double)dates*500;
        Console.WriteLine(Amount);
       }
        
        
    }
}