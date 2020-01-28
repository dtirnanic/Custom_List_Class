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

        [TestMethod]
        public void Check_Eight_Capacity_Array()
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

        //Tests for Remove method
        [TestMethod]
        public void Check_CountAfterOneRemove_index_()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 6;
            int value3 = 7;

            //Arrange
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value2);

            //Assert
            Assert.AreEqual( myList.count, 2);
        }

        [TestMethod]
        public void Check_CountAfterTwoRemove_index_()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 6;
            int value3 = 7;

            //Arrange
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value2);
            myList.Remove(value3);

            //Assert
            Assert.AreEqual(myList.count, 1);
        }

        [TestMethod]
        public void Remove_Nonduplicates()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();


            //Arrange
            myList.Add(1);
            myList.Add(2);
            myList.Add(9);
            myList.Add(2);
            myList.Add(5);
            myList.Remove(2);

            //Assert
            Assert.AreEqual(myList[2], 2);
        }

        [TestMethod]
        public void Check_Zip_List()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            int expectedResult = 123456;
            //Arrange
            odd.Zip(odd, even);

            //Assert
            Assert.AreEqual(expectedResult,123456);
        }

        [TestMethod]
        public void Check_Add2Lists_index_()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int>  addOperator = new CustomList<int>();
            int expectedResult = 135246;

            //Arrange
            addOperator = odd + even;

            //Assert
            Assert.AreEqual(expectedResult, 135246);
        }


        [TestMethod]
        public void Check_Remove2Lists_index_()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 , 7};
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> removeOperator = new CustomList<int>();
            int expectedResult = 7;

            //Arrange
            removeOperator = odd - even;

            //Assert
            Assert.AreEqual(expectedResult, 7);
        }

        [TestMethod]
        public void Check_ToString_index_()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            string expectedValue = "123";

            //Arrange
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            

            //Assert
            Assert.AreEqual(expectedValue, myList.ToString());
        }
    }


}
