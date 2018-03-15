using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorts;

namespace Sorts.Tests
{
    /// <summary>
    /// This class tests QuickSort.
    /// </summary>
    [TestClass]
    public class QuickSortTests
    {
        /// <summary>
        /// This method checks the source array after sorting and the expected array.
        /// </summary>
        [TestMethod]
        public void Sorting_UnsortedArray_SortedArray()
        {
            int[] sourceArray = { 3, 2, 4, 1, 5 };
            int[] expectedArray = { 1, 2, 3, 4, 5 };

            QuickSort.Sorting(sourceArray);

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

            QuickSort.Sorting(sourceArray);

            Assert.AreSame(expectedArray, sourceArray);
        }

        /// <summary>
        /// Checks sort for null reference processing.
        /// </summary>
        [TestMethod]
        public void SortingNullTest()
        {
            int[] sourceArray = null;

            QuickSort.Sorting(sourceArray);

            Assert.IsNull(sourceArray);
        }
    }
}
