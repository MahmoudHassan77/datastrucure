namespace SortingAlgorithms;

public static class Helpers
{
    public static void Swap(int[] arr, int i, int j)
    {
        if(i == j) return;

        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        
    }
}
