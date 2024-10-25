namespace SortingAlgorithms;

public static class SelectionSort
{

    /*
        Selected sort assume the first number is the largest and compare it with rest of numbers until
        it catch the largest element and swap it with the last element and reduce 
        the array size by 1 and repeat this process 
        - Selected sort is an in-place algorithm => uses a small amount of extra memory (doesn't depend on n)
        - Selected sort is unstable because it swap the largest number with whatever is occupying the last position
        - Selected sort has O(n^2) time complexity (Quadratic)
        - Degrades quickly (though usually faster than Bubble Sort)
    */
    public static void Sort(int[] arr)
    {
        for (int partIndex = arr.Length-1; partIndex > 0; partIndex--)
        {
            int largestAt = 0;
            for (int i = 0; i <= partIndex; i++)
            {
                if (arr[i] > arr[largestAt]) largestAt = i;
            }
            Helpers.Swap(arr, largestAt,partIndex);
        }
    }
}
