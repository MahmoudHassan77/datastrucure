using Arrayes;
/*
 ----------------------Introduction---------------------
 - Arrays is a data structure containing a number of data values have the same type
 - It has a fixed size 
 - Arrays belong to the category of reference type
 - It save its address in stack and allocate a part of heap for its values
 - the size of the part allocated in the heap is the number of element * the size of element
 - It is contiguous memory allocation (take a chunk of memory) العناصر ورا بعضها to be easy accessible
 Example: array = [7][10][9][5][12] is an array of 5 elements each element has 4 bytes and start index is 0x04
         address of array[0] = 0x04
         address of array[1] = 0x04 + (1*4) = 0x08
         address of array[2] = 0x04 + (2*4) = 0x0C
         address of array[3] = 0x04 + (3*4) = 0x10
         address of array[3] = 0x04 + (4*4) = 0x14
 - Fast access You can access the element by its index directly O(1)
 - It has difficulty in insertion and deletion 
*/



// -------------------------Implementation-------------------------------

// ArraysDemo();

/*
 Create non zero based array its index start from 1
 It isn't recommended to create non zero based arrays because:
  - No one expects from an array to be non zero based array 
  - It cannot be consumed by other languages which don't support non zero based array
  - Non zero based arrays are slower than zero based array 
*/
// Test1BaseArray();

// Multi dimensional or jagged arrays
// MultiDimensionalArray();

// Iterate over an array in unsafe C# code 
// IterateOver(new int[]{2, 4, 5, 7});

// Operations



// int[] arr = new int[5];
// // Add element
// arr[0] = 3;
// arr[1] = 9;
// arr[2] = 4;
// arr[3] = 6;
// arr[4] = 7;
// int[] newArr = Operations.AddElementToFullArray(arr, 5);
// PrintArrMethod1(newArr);
// int index = Operations.SearchAboutElement(arr, 4);
// Console.WriteLine(index);
// int ele = Operations.AccessElementByIndex(arr, 4);
// Console.WriteLine(ele);
// int[] newArr1 = Operations.RemoveElementWithIndexCompletelyAndRemoveSlot(arr, 3);
// PrintArrMethod1(newArr1);
// int[] newArr2 = Operations.RemoveElementCompletelyAndRemoveSlot(arr, 7);
// PrintArrMethod1(newArr2);
// Operations.RemoveElementWithIndex(arr, 3);
// PrintArrMethod1(arr);


Console.ReadKey();

static void ArraysDemo()
{
    int[] arr1; // A variable arr1 is a null reference in this case, It doesn't point to any memory location
    arr1 = new int[10]; // A chunk of memory for keeping 10 integer values will be allocated 
    int[] arr2 = new int[5]; // Declaration in one line
    int[] arr3 = new int[3] { 1, 2, 3 }; // Declaration and initialization at the same line
    int[] arr4 = { 1, 2, 3, 4 }; // Short syntax
    
    // print array values
    PrintArrMethod1(arr3);
    Console.WriteLine();
    Console.WriteLine("======================");
    PrintArrMethod2(arr3);
    // if you try to access an element by an unavailable index you will immediately get out of range exception
    // arr3[5]
    
    // When you put [] after datatype you means you will use array type that exists in System.Array you can use another ways to declare an array
    Array a = new int[5];
    Array a2 = Array.CreateInstance(typeof(int), 5);
    a2.SetValue(2,0); // (value, index)

}

static void PrintArrMethod1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
static void PrintArrMethod2(int[] arr)
{
    foreach (var number in arr)
    {
        Console.Write($"{number} ");
    }
}


static void Test1BaseArray()
{
    // you can set array start index and length ==> length = 4, start index = 1
    Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
    myArray.SetValue(2019, 1);
    myArray.SetValue(2020, 2);
    myArray.SetValue(2021, 3);
    myArray.SetValue(2022, 4);
    
    Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
    Console.WriteLine($"Starting index: {myArray.GetUpperBound(0)}");
    
    //for (int i = myArray.GetLowerBound(0); i < myArray.GetUpperBound(0); i++)
    for (int i = 1; i < 5; i++)
    {
        Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
    }
}

static void MultiDimensionalArray()
{
    int[,] a;
    a = new int[4, 5];

    int[,] a2 = new int[4, 5];
    int[,] a3 = new int[2, 3] { { 1, 2, 3 }, { 2, 4, 5 } };
    int[,] a4 = { { 1, 2, 3 }, { 2, 4, 5 } };
    
    // Jagged Array => multi dimensional array contains arrays with different length
    int[][] jaggedArr = new int[2][];
    jaggedArr[0] = new int[3] { 1, 3, 5 };
    jaggedArr[1] = new int[] { 1, 3, 5, 7 };
    // Print 2D array 
    Print2DArray(a3);
    PrintJaggedArray(jaggedArr);
}

static void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }

        Console.WriteLine();
    }
}
static void PrintJaggedArray(int[][] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr[i].Length; j++)
        {
            Console.Write($"{arr[i][j]} ");
        }

        Console.WriteLine();
    }
}


// to prove that arrays are laid out contiguously in memory 
static unsafe void IterateOver(int[] arr)
{
    // The fixed keyword can be used to (pin) the array in memory and avoid GC to move it (create a pointer to a managed object).
    // (unsafe) This is typically used when interacting with unmanaged code or when you need to perform low-level memory operations.
    // It ensures that the object being pointed is not moved by the Garbage Collector during the scope of the fixed block.
    fixed (int* b = arr) // It tells the garbage collector to pin the object and not move it around.
    {
        int* p = b;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(*p); // print the value that pointer points
            p++; // The pointer will be shifted by 4 bytes since the pointer points to the int type and int type is 4 bytes in size
        }
    }
    // It will print arr elements in order and this proves that they are arranged contiguously in memory
}