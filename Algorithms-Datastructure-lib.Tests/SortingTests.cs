using NUnit.Framework;
using NUnit.Framework.Legacy;
using SortingAlgorithms;

namespace Algorithms_Datastructure_lib.Tests;

[TestFixture]
public class SortingTests
{

    private int[][] Samples()
    {
        int[][] samples = new int[9][];
        samples[0] = [1];
        samples[1] = [2, 1];
        samples[2] = [2, 1, 3];
        samples[3] = [1, 1, 1];
        samples[4] = [2, -1, 3, 3];
        samples[5] = [4, -5, 3, 3];
        samples[6] = [0, -5, 3, 3];
        samples[7] = [0, -5, 3, 0];
        samples[8] = [3, 2, 5, 5, 1, 0, 7, 8];
        return samples;
    }
    private void RunTestForSortAlgorithm(Action<int[]> sort)
    {
        foreach (var sample in Samples())
        {
            sort(sample);
            CollectionAssert.IsOrdered(sample);
            PrintOut(sample);
        }
    }

    private void PrintOut(int[] sample)
    {
        TestContext.WriteLine("--------Trace-----------\n");
        foreach (var item in sample)
        {
            TestContext.Write(item + " ");
        }
        TestContext.WriteLine("\n----------------------\n");
    }

    [Test]
    public void BubbleSort_ValidInput_SortedInput()
    {
        RunTestForSortAlgorithm(BubbleSort.Sort);
    }
    [Test]
    public void SelectionSort_ValidInput_SortedInput()
    {
        RunTestForSortAlgorithm(SelectionSort.Sort);
    }

    [Test]
    public void InsertionSort_ValidInput_SortedInput()
    {
        RunTestForSortAlgorithm(InsertionSort.Sort);
    }
}
