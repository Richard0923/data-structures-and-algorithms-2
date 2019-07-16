### Lecture Notes: Insertion Sort Algorithm

Insertion Sort is 1 of 3 types of common sorting algorithm or generally called Simple Sorts the other ones 
are called Bubble Sort and Selection Sort. Both Insertion and Bubble are also what's considered Stable sorts 
which assures that equal values will be kept in relative ordering. Insertion sort has a Space complexity of O(1) 
but its only useful for smaller list containing less than 50 elements. 

### Learning Objective 

1. Student will learn how to use Insertion Sort.
2. Student will learn how to implement a simple sort method.
3. Student will know what the diffrence between Insertion sort and Selection sort 

### Lecture Flow 

The Insertion Sort algorithm will take one element from the array and compare it to the element to the right and move that element accordingly.

It will compare the two elements using an efficiency of:
1. Time = O(n^2) 
2. Space = O(1)


### Diagram 

Pass 1: 20, 47, 2, 7, 19 
Pass 2: 2, 20, 47, 7, 19
Pass 3: 2, 7, 20, 47, 19
Pass 4: 2, 7, 19, 20, 47

### Algorithm

1. First have a For loop to iterate throw an array.
2. At every index have a Temp variable to hold the current value of that index.
3. Declare a j varable to be one position less than the current index.
4. Have a While loop inside the For loop with the condition being j is greater than zero and the Temp is less than j.
5. Inside that While move the value of j one position then decrement j one position.
6. Increment the For Loop one more position till you hit the end.

### Pseudocode

	InsertionSort(int[] arr)
		FOR i = 1 to arr.length
			int j <-- i - 1
			int temp <-- arr[i]

			WHILE j >= 0 AND temp < arr[j]
				arr[j + 1] <-- arr[j]
				j <-- j - 1

			arr[j + 1] <-- temp

### Readings and Reference

## Watch 

https://www.youtube.com/watch?v=OGzPmgsI-pQ

## Read 

https://www.c-sharpcorner.com/blogs/insertion-sorting-algorithm-in-c-sharp1

https://www.geeksforgeeks.org/insertion-sort/
