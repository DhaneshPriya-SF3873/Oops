using System;
namespace AccessSpecifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Base value=new Base();
            //System.Console.WriteLine(value.DisplayPrivate());
            value.DisplayPrivate();
            System.Console.WriteLine(value.PublicValue);
            Derived value1=new Derived();
            value1.DisplayProtected();
            value1.DisplayInternal();
            System.Console.WriteLine(value._internalValue);
            OutsideDervied value3=new OutsideDervied();
            value3.DisplayOutside();
        }
        
                
    }
    
}