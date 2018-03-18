using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorts.Tests
{
    /// <summary>
    /// This class tests MergeSort.
    /// </summary>
    [TestClass]
    public class MergeSortTests
    {
        /// <summary>
        /// This method checks the source array after sorting and the expected array. 
        /// </summary>
        [TestMethod]
        public void Sorting_UnsortedArray_SortedArray()
        {
            int[] sourceArray = new int[1000000];
            sourceArray[0] = int.MinValue;
            sourceArray[1] = int.MaxValue;
            Random rand = new Random();
            for (int i = 2; i < sourceArray.Length; i++)
            {
                sourceArray[i] = rand.Next();
            }

            int[] expectedArray = new int[1000000];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                expectedArray[i] = sourceArray[i];
            }

            Array.Sort(expectedArray);
            MergeSort.Sorting(sourceArray);

            CollectionAssert.AreEqual(sourceArray, expectedArray);
        }

        /// <summary>
        /// Checks sort for zero capacity processing.
        /// </summary>
        [TestMethod]
        public void Sorting_ZeroCapacity()
        {
            int[] sourceArray = new int[0];
            int[] expectedArray = sourceArray;

            MergeSort.Sorting(sourceArray);

            Assert.AreSame(expectedArray, sourceArray);
        }

        /// <summary>
        /// Test generation of ArgumentNullException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsNullTest()
            => MergeSort.Sorting(null);
    }
}
