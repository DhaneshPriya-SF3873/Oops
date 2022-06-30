namespace AccessSpecifiers
{
    public class Base
    {
        private int _privateValue=100;
        public int PublicValue=200;
        
        protected int ProtectedValue=300;
        internal int _internalValue=400;
        
        
      public void DisplayPrivate()
        {
         System.Console.WriteLine(_privateValue);
        }
     
        
    }

}