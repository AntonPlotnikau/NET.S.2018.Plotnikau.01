﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorts;

namespace SortsTests
{
    /// <summary>
    /// This class tests MergeSort.
    /// </summary>
    [TestClass]
    public class MergeSortTest
    {
        /// <summary>
        /// This method checks the source array after sorting and the expected array. 
        /// </summary>
        [TestMethod]
        public void Sorting_UnsortedArray_SortedArray()
        {
            int[] sourceArray = { 3, 2, 4, 1, 5 };
            int[] expectedArray = { 1, 2, 3, 4, 5 };

            MergeSort.Sorting(sourceArray);

            Assert.ReferenceEquals(sourceArray, expectedArray);
        }

        /// <summary>
        /// Checks sort for zero capacity processing.
        /// </summary>
        [TestMethod]
        public void Sorting_ActualZeroCapacity_ExpectedZeroCapacity()
        {
            int[] sourceArray = new int[0];
            int[] expectedArray = new int[0];

            MergeSort.Sorting(sourceArray);

            Assert.ReferenceEquals(sourceArray, expectedArray);
        }

        /// <summary>
        /// Checks sort for null reference processing.
        /// </summary>
        [TestMethod]
        public void Sorting_ActualNullReference_ExpectedNullReference()
        {
            int[] sourceArray = null;
            int[] expectedArray = null;

            MergeSort.Sorting(sourceArray);

            Assert.ReferenceEquals(sourceArray, expectedArray);
        }
    }
}