namespace ListManipulation
{
    public partial class List<T>
    {
        public void Insert(int index, T value)
        {
            T[] temp=new T[_capacity*2];
            for(int i=0; i<_count; i++)
            {
                if(i<index)
                {
                    temp[i]=Array[i];

                }
                else if(i>=index)
                {
                    temp[i+1]=Array[i];
                }
            }
            temp[index]=value;
            Array=temp;
            _count++;
        }

        public void Remove(T value)
        {
            T[] temp=new T[_capacity*2];
            int j=0;
            for(int i=0; i<_count; i++)
            {
                if(value.Equals(Array[i]))
                {
                    i++;
                }
                temp[j]=Array[i];
                j++;
            }
            Array=temp;
            _count--;
        }

        public void RemoveAt(int index)
        {
            T[] temp=new T[_capacity*2];
            int j=0;
            for(int i=0; i<_count; i++)
            {
                if(i==index)
                {
                    i++;
                }
                temp[j]=Array[i];
                j++;
            }
            Array=temp;
            _count--;

        }

        
    public void BubbleSort(int [] Array)
    {

    }






        






    }
}
}