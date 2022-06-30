namespace Sorting1
{
    public partial class Sorting
    {
         public void InsertionSort(int [] array)
        {
            int i,j;
            int value;
            for(i=1; i<array.Length; i++)
            {
                value=array[i];
                for(j=i-1; j>=0;)
                {
                    if(value<array[i])
                    {
                        array[j+1]=array[j];
                        j--;
                        array[j+1]=value;

                    }
                    else
                    {
                        break;
                    }
                }
            }
            System.Console.WriteLine("The insertion sort");
            foreach(int item in array)
            {
                System.Console.WriteLine(item);
            }
        }
     public void BubbleSort(int [] array)
     {
         int temp=0;
         for(int i=0; i<array.Length-1; i++)
         {
             for(int j=0; j<array.Length-1-i; j++)
             {
               if(array[j]>array[j=1])
             {
                  temp=array[j+1];
                 array[j]=array[j+1];
                 array[j+1]=temp;

             }
             }
         }
         System.Console.WriteLine("The bubble sort is: ");
       foreach(int item in array)
       {
                System.Console.WriteLine(item);
       }
      }

     public  void SelectionSort(int [] array)
     {
         int i,j;
         int temp, min,minIndex;
         for(i=0; i<array.Length; i++)
         {
             min=array[i];
             minIndex=i;
             for(j=i; j<array.Length; j++)
             {
                 if(array[j]<min)
                 {
                     min=array[j];
                     minIndex=j;
                 }
             }
             if(min<array[i])
             {
                 temp=array[i];
                 array[i]=array[minIndex];
                 array[minIndex]=temp;
             }
             }
             System.Console.WriteLine("The Selection sort is: ");
       foreach(int item in array)
       {
                System.Console.WriteLine(item);
       }

     }
     

     






    }}