namespace Arrayes;


/* Array operations
     1- Accessing an element, either direct or through a searching process
     2- Adding an element: to the end, to the beginning 
     3- Inserting an element 
     4- Updating an element
     5- Removing an element 
*/

/* Big O values for array operations
   1- Accessing an element - O(1) -constant
   2- Search (in un sorted array) - O(n) -linear  ==> implies a for-loop
   3- Adding an element (to a full array) - O(n)  ==> need to be resized
   4- Adding an element (array has space) -O(1)  ==> if you know index, otherwise (bad case) O(n)
   5- inserting/ Updating at index -O(1)  ==> if you know index, otherwise (bad case) O(n)
   6- Removing an element -O(1)  ==> if you know index, otherwise (bad case) O(n)
   7- Removing an element (by shifting elements) -O(n)  ==> need to be resized
 
 */


public static class Operations
{
    // Access by index O(1) -constant
    public static T AccessElementByIndex<T>(T[] arr, int index)
    {
        return arr[index];
    }
    
    // Searching for an element O(n)
    public static int SearchAboutElement<T>(T[] arr, T element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(arr[i], element)) return i;
        }
        return -1;
    }
    
    // Add to full array
    public static T[] AddElementToFullArray<T>(T[] arr, T element)
    {
        // usually we double array size when it is full
        T[] newArr = new T[arr.Length * 2];
        for (int i = 0; i< arr.Length; i++)
        {
            // O(1) add element by index
            newArr[i] = arr[i];
        }
        // another way 
        // Array.Copy(arr, newArr, arr.Length);
        newArr[arr.Length] = element;
        return newArr;
    }
    
    // Remove an element by assigning null O(1)
    public static void RemoveElementWithIndex<T>(T?[] arr, int index)
    {
        arr[index] = default(T);
    }
    // Remove an element with its slot and resize the array O(n)
    public static T[] RemoveElementCompletelyAndRemoveSlot<T>(T[] arr, T element)
    {
        T[] newArr = new T[arr.Length-1];
        int i = 0;
        foreach (var item in arr)
        {
            if (!EqualityComparer<T>.Default.Equals(item, element))
            {
                newArr[i] = item;
                i++;
            }
        }
        return newArr;
    }
    // Remove an element with its slot and resize the array O(n)
    public static T[] RemoveElementWithIndexCompletelyAndRemoveSlot<T>(T[] arr, int index)
    {
        T[] newArr = new T[arr.Length-1];
        Array.Copy(arr, 0, newArr,0, index);
        Array.Copy(arr, index+1, newArr,index, arr.Length-1-index);
        return newArr;
    }
}
