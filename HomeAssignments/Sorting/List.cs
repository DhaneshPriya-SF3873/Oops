using System;
namespace ListManipulation
{
    public partial class List<T>
    {
        private int _count;
        private int _capacity;

        public int Count { get{return _count;}}
        public int Capacity { get{return _capacity;}  }
        private  T [] Array{ get; set; }
        

        public List()
        {
          
          _count=0;
          _capacity=1;
           Array=new T[_capacity];
       }
       public List(int size)
       {
           
           _count=0;
           _capacity=size*2;
           Array=new T[_capacity];
       }

       public void AddElement(T a)
       {
           if(_count==_capacity)
           {
               Growsize();
           }
           Array[_count]=a;
           _count++;
       }

       public void Growsize()
       {
           //declares a temp[] array
           T[] temp=new T[_capacity*2];
          //initaialize a double size array of array

           for(int i=0; i<_capacity; i++)
           {
               //copy all elements of old array
               temp[i]=Array[i];
           }

           Array=temp;
           _capacity=_capacity*2;
       }


       public void DisplayArray()
       {
           for(int i=0; i<_count; i++)
           {
               System.Console.WriteLine(Array[i]+" ");
           }
              System.Console.WriteLine();
       }
        
      
        
        
        

    }
}