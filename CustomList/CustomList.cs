using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {


        public int capacity { get; set; } = 4;
        public int count { get; set; }
        T[] items;


        public T this[int i]
        {
            get
            {
                if (count < i || i < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return items[i];
                }
            }
            set { items[i] = value; }
        }

        public CustomList()
        {
            items = new T[capacity]; //assigning (list[array]) capacity  6
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
            
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

        public void Remove(T item)
        {
            T[] tempArray = new T[capacity];
            bool hasFound = false;
            for (int i = 0; i < count; i++) 
            {
                if (items[i].Equals(item) && hasFound == false)
                {
                    hasFound = true;
                    count--;
                }
                
                if (hasFound == true)
                {
                   
                    tempArray[i] = items[i + 1];
                }
                else
                {
                    tempArray[i] = items[i];
                }              
            }
            items = tempArray;
        }

        public static CustomList<T> Zip(CustomList<T> list1, CustomList<T> list2)
        {
            int i = 0;
            CustomList<T> zipList = new CustomList<T>();

            do
            {
                if (i + 1 <= list1.count)
                {
                    zipList.Add(list1[i]);
                }

                if (i + 1 <= list2.count)
                {
                    zipList.Add(list2[i]);
                }
                i++;
            }
            while ((i+1 <= list1.count) || (i+1 <= list2.count));

            return zipList;
        }

        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list = new CustomList<T>();

            for (int i = 0; i < list1.count; i++)
            {
                list.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                list.Add(list2[i]);
            }
            
            return list;
        }

        public static CustomList<T> operator - (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list = new CustomList<T>();

            for (int i = 0; i < list1.count; i++)
            {
                list.Remove(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                list.Remove(list2[i]);
            }

            return list;
        }

        public override string ToString()
        {
            //CustomList<T> list = new CustomList<T>();
            string value = "";

            for (int i = 0; i < count; i++)
            {
                value += items[i].ToString();  
            }
            return value;
        }
    }
}

    

   
