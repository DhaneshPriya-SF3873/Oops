using System;
namespace AccessSpecifiers
{
    public class Derived:Base
    {
        
        public void DisplayProtected()
        {
            System.Console.WriteLine(ProtectedValue);
        }
        public void DisplayInternal()
        {
            System.Console.WriteLine(_internalValue);
        }
    }
}