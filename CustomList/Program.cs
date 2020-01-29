using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5, 7, 9 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> List;

            List = odd - even;
            Console.WriteLine();

            //CustomList<int> list = new CustomList<int>();
            //// foreach loop to test
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Remove(2);
            ////list.Remove(3);
            //for (int i = 0; i < list.count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            ////CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            ////CustomList<int> even = new CustomList<int>() { 2, 4, 6 };

            ////CustomList<int> zipList = new CustomList<int>(); 
            ////zipList.Zip(odd, even);

            ////CustomList<int> plusOperator = new CustomList<int>();

            ////plusOperator = odd + even;

            ////odd.ToString();

            //Console.WriteLine(plusOperator); 
            //Console.ReadLine();
        }
    }
}
