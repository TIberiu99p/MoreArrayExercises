using System;
using NUnit.Framework;


namespace MoreArrayExercises.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        private int[] arr;
        private int size;
        private int value;
        [SetUp]
        public void Setup() 
        { 
            //arange
            arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 20 };
            size = arr.Length;
            value = 8;
        }

        [Test]
        public void TestSumArray()
        {   
            
            //act
            int result = Program.SumArray(arr);
            //assert
            Assert.That(result, Is.EqualTo(210));

        }

        [Test]
        public void TestSequentialSearch()
        {
            //act
            int result = Program.SequnatialSearch(arr, size, value);
            //assert
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void TestBinarySearch()
        {

            //act
            int result = Program.BinarySearch(arr, size, value);
            //assert
            Assert.That(result, Is.EqualTo(7));
        }
    }
}
