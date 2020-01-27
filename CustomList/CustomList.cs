using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        

        public int capacity { get; set; } = 4;
        public int count { get; set; }
        T[] items;
        
       

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }


        //count represents the number of items in the list (the array)  

        public CustomList()
        {
            items = new T[capacity]; //assigning (list[array]) capacity  
        }


        public void Add(T item)
        {
            items[count] = item;
            count++;
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
            
        }

        public void IncreaseCapacity()
        {
            
            
        }

        public void CopyArray()
        {
            
                
            
        }

        public void Remove(T item)
        {            
            T[] tempArray = new T[capacity];

            for (int i = 0; i < count+1; i++)
            {
                if (!items[i].Equals(item)) 
                {
                    tempArray[i] = items[i];
                }
                else
                {   
                    count--;
                }
            }
            items = tempArray; 
        }
    }


}

    

   
