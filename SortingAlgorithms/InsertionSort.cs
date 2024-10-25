namespace SortingAlgorithms;

public class InsertionSort
{
    /*
        - Based on partitioning the sorting array.
        - It is in-place algorithm (use a small amount of memory - doesn't depend on n)
        - It's a stable algorithm
        - It's time complexity is O(n^2) (Quadratic)
        - It degrades quickly
    */


    public static void Sort(int[] arr)
    {

        for (int partIndex = 1; partIndex < arr.Length; partIndex++)
        {
            int curUnsorted = arr[partIndex];
            int i = 0;
            for (i = partIndex; i > 0 && arr[i-1] > curUnsorted; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[i] = curUnsorted;
        }
    }
}