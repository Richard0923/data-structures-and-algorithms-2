# Challenge Summary
<!-- Short summary or background information -->
Complete a working and tested Implementaion of Insertion Sort

## Challenge Description
<!-- Description of the challenge -->
This Algorithm must start at the beginning of the array and moves right rearranging the order until the array is in Ascending order 

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
Time = O(n^2) Space = O(1)

## Solution
<!-- Embedded whiteboard image -->
  InsertionSort(int[] arr)
  
    FOR i = 1 to arr.length
    
      int j <-- i - 1
      int temp <-- arr[i]
      
      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1
        
      arr[j + 1] <-- temp
