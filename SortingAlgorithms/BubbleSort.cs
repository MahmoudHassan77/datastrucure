namespace SortingAlgorithms;

public static class BubbleSort
{

    // Bubble sort is valuable from the learning perspective.
    // You will never see it working in real world since the performance is very bad
    // It is an in place algorithm => uses a small amount of extra memory (doesn't depend on n)
    // We just need a couple of iterators and nothing else
    // So the bubble sort is a memory efficient
    // Bubble sort is a stable algorithm
    // Bubble sort has O(n^2) time complexity (Quadratic)
    // Bubble sort degrades quickly => it means that for sorting 100 items it will require to perform 10000 steps تقدر تحلله بسرعه

    public static void Sort(int[] arr)
    {
        for (int partIndex = arr.Length-1; partIndex > 0; partIndex--)
        {
            for (int i = 0; i < partIndex; i++)
            {
                if (arr[i] > arr[i + 1]) Helpers.Swap(arr, i, i + 1);  // if we put >= instead of > the algorithm will become unstable
            }
        }
    }
}

