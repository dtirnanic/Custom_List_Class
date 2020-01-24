using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] items;
        public int capacity = 4;
        public int count;
        //count represents the number of items in the list (the array)


        public CustomList()
        {
            items = new T[capacity]; //assigning (list[array]) capacity
        }

        public void Add(T item)
        {
            //what happens if count and capacity are equal
            //copy count
            //add copy to existing count
            //clear values from new array
            //add next item in list
            items[count] = item;
            count++;

            if (count == capacity)
            {
                
                //items.Clone(capacity);
            }
        }
    }
}
