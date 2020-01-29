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
        public void Check_CountAfterOne_Remove()
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
        public void Check_CountAfterTwo_Remove()
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
        public void Check_Nonduplicates_Remove()
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
        public void Check_Zip_ZipList()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> zipList;

            int expectedResult = 123456;
            //Arrange
            zipList = CustomList<int>.Zip(odd, even);

            //Assert
            Assert.AreEqual(expectedResult,123456);
        }

        [TestMethod]
        public void Check_ZipWithRemainder_ZipList1()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5, 7, 9};
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> zipList = new CustomList<int>();
            string expectedResult = "12345679";
            //Act
            zipList = CustomList<int>.Zip(odd, even);
            string actualResult = zipList.ToString();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Check_ZipWithRemainder_ZipList2()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6, 8, 10 };
            CustomList<int> zipList = new CustomList<int>();
            string expectedResult = "123456810";
            //Act
            zipList = CustomList<int>.Zip(odd, even);
            string actualResult = zipList.ToString();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Check_AddOperator2Lists_AddLists()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int>  addOperator = new CustomList<int>();
            string expectedResult = "135246";

            //Act
            addOperator = odd + even;
            string actualResult = addOperator.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Check_AddOperator2Lists_AddWithRemainder()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 , 7, 9};
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> addOperator = new CustomList<int>();
            string expectedResult = "13579246";

            //Act
            addOperator = odd + even;
            string actualResult = addOperator.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Check_Subtract2Lists_NoRemainder()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5};
            CustomList<int> even = new CustomList<int>() { 2, 4, 6};
            CustomList<int> removeOperator = new CustomList<int>();
            string expectedResult = "";

            //Act
            removeOperator =  odd - even;
            string actualResult = removeOperator.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Check_Subtract2ListsRemainder_List1Remainder()
        {
            //Arrange   
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> removeOperator = new CustomList<int>();
            string expectedResult = "7";

            //Act
            removeOperator = odd - even;
            string actualResult = removeOperator.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Check_IntToString_String()
        {
            //Arrange   
            CustomList<int> myList = new CustomList<int>();
            string expectedValue = "123";

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            

            //Assert
            Assert.AreEqual(expectedValue, myList.ToString());
        }

        [TestMethod]
        public void Check_DoubleToString_String()
        {
            //Arrange   
            CustomList<double> myList = new CustomList<double>();
            string expectedValue = "1.12.23.3";

            //Act
            myList.Add(1.1);
            myList.Add(2.2);
            myList.Add(3.3);


            //Assert
            Assert.AreEqual(expectedValue, myList.ToString());
        }

        [TestMethod]
        public void Check_Concatenate_String()
        {
            //Arrange   
            CustomList<string> myList = new CustomList<string>();
            string expectedValue = "Hello World";

            //Act
            myList.Add("Hello ");
            myList.Add("World");
            
            //Assert
            Assert.AreEqual(expectedValue, myList.ToString());
        }
    }


}
