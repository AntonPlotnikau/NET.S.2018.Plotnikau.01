using System;

namespace Sorts
{
    /// <summary>
    /// This class sorts a numeric array by a quick method.
    /// </summary>
    public static class QuickSort
    {
        /// <summary>
        /// This method takes an array and passes it to the sorting method, 
        /// if the array is correct.
        /// </summary>
        /// <param name="array">The source array to sort.</param>
        public static void Sorting(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length < 1)
            {
                return;
            }

            Sorting(array, 0, array.Length - 1);
        }

        /// <summary>
        /// QuickSort of the array.
        /// Gets the array along with the left and right bounds of the array.
        /// </summary>
        /// <param name="array">The source array to sort.</param>
        /// <param name="left">Left bound of the array.</param>
        /// <param name="right">Right bound of the array.</param>
        private static void Sorting(int[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var middle = array[(left + right) / 2];

            while (i <= j) 
            {
                while (array[i] < middle) 
                {
                    i++;
                }

                while (array[j] > middle) 
                {
                    j--;
                }

                if (i <= j) 
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (j > left) 
            {
                Sorting(array, left, j);
            }

            if (i < right) 
            {
                Sorting(array, i, right);
            }
        }
    }
}
