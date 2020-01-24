using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void Check_Zero_index_Add()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            int value = 5;

            //Arrange
            myList.Add(value);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }

        [TestMethod]
        public void Check__index_Add()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expectedResult = 1;

            //Arrange
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.count);
        }

        [TestMethod]
        public void Check_One_index_Add()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 10;

            //Arrange
            myList.Add(value);
            myList.Add(value2);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }

        [TestMethod]
        public void Check_Two_index_Add()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 10;

            //Arrange
            myList.Add(value);
            myList.Add(value2);

            //Assert
            Assert.AreEqual(value2, myList[1]);
        }

        [TestMethod]
        public void Check_Five_index_Add()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 10;
            int value3 = 11;
            int value4 = 12;
            int value5 = 13;

            //Arrange
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            //Assert
            Assert.AreEqual(value5, myList[4]);
        }

        [TestMethod]
        public void Check_Zero_index_Copy_Array()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 10;
            int value3 = 11;
            int value4 = 12;
            int value5 = 13;

            //Arrange
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }
    }
}
