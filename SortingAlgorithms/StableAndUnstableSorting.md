# Stable and Unstable Sorting

## Stable

 ```c#
int[] unSortedArr = [5, 4, 1, 6, 1, 5, 2];
int[] sortedArr = [1, 1, 2, 4, 5, 5, 6];
 ```
 - The number (1) existed in index 0 in sorted array was 2 in unsorted array
 - The number (1) existed in index 1 in sorted array was 4 in unsorted array
 - The number (5) existed in index 4 in sorted array was 0 in unsorted array
 - The number (5) existed in index 5 in sorted array was 5 in unsorted array

> So stable sorting doesn't change the order of duplicated elements 


-----------------

## Unstable

 ```c#
int[] unSortedArr = [5, 4, 1, 6, 1, 5, 2];
int[] sortedArr = [1, 1, 2, 4, 5, 5, 6];
 ```
 - The number (1) existed in index 0 in sorted array was 4 in unsorted array
 - The number (1) existed in index 1 in sorted array was 2 in unsorted array
 - The number (5) existed in index 4 in sorted array was 0 in unsorted array
 - The number (5) existed in index 5 in sorted array was 5 in unsorted array
  
Note that the duplicated element (1) order is changed

> So unstable sorting may change the order of duplicated elements 