namespace Sorts
{
    /// <summary>
    /// This class sorts a numeric array by a merge method.
    /// </summary>
    public static class MergeSort
    {
        /// <summary>
        /// This method takes an array and passes it to the sorting method, 
        /// if the array is correct.
        /// </summary>
        /// <param name="array">The source array to sort.</param>
        public static void Sorting(int[] array)
        {
            if (array == null || array.Length < 1)
            {
                return;
            }

            Sorting(array, 0, array.Length - 1);
        }

        /// <summary>
        /// MergeSort of the array.
        /// Gets the array along with the left and right bounds of the array.
        /// </summary>
        /// <param name="array">The source array to sort.</param>
        /// <param name="left">Left bound of the array.</param>
        /// <param name="right">Right bound of the array.</param>
        private static void Sorting(int[] array, int left, int right)
        {
            var size = (right - left) + 1;
            if (size < 2) 
            {
                return;
            }

            var middle = (left + right) / 2;
            Sorting(array, left, middle);
            Sorting(array, middle + 1, right);

            int[] buffer = new int[size];
            var i = left;
            var j = middle + 1;
            for (int k = 0; k < size; k++) 
            {
                if (i > middle)
                {
                    buffer[k] = array[j++];
                }
                else if (j > right)
                {
                    buffer[k] = array[i++];
                }
                else if (array[j] < array[i])
                {
                    buffer[k] = array[j++];
                }
                else
                {
                    buffer[k] = array[i++];
                }
            }

            for (int k = 0; k < size; k++) 
            {
                array[left + k] = buffer[k];
            }
        }
    }
}
