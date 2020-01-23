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
            Assert.AreEqual(value, myList);
        }
    }
}
