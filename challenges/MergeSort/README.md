# Lecture Notes: Insertion Sort Algorithm

Merge Sort is a Divide and Conquer Algorithm that produces a stable sort which means that it keeps the repeated in the same order that they appear in. This algorithm works by dividing
the input array in half and compares and places the appropriate element in its place. After it merges them and return the result, one key fact to remember is that merge sort does all this 
by using recursion. 

## Learning Objective 

1. Students will learn how to use recursion.
2. Students will learn implement a divide and conquer algorithm.
3. Students will learn a way to sort arrays.

## Lecture Flow 

Merge Sort is a sorting algorithm that splits and array in 2 and uses recursion to sort the input array.

Merge Sort's efficiency is:
Time: O(n Log n)
Space: O(n)

## Diagram 

## Array [2, 8, 16, 9]
##	  [2, 8] [16, 9]
##	  [2][8] [16][9]
##	  [2, 8] [9, 16]
##	  [2, 8, 9, 16]


## Algorithm

1. Merge sort starts by divideing the array in half.
2. Then it uses recursion to to keep divideing the array until both arrays only have 1 element each.
3. lastly in merges and sorts all those elements into its original array.

## Pseudocode

ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left


## Readings and Reference

### Watch 

https://www.youtube.com/watch?v=JSceec-wEyw&feature=youtu.be

### Read 

https://www.c-sharpcorner.com/blogs/a-simple-merge-sort-implementation-c-sharp

https://www.geeksforgeeks.org/merge-sort/
