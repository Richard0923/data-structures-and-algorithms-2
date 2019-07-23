# Challenge Summary
<!-- Short summary or background information -->
Create a method called tree intersection that takes in 2 trees and returns any value that is in both trees.

## Challenge Description
<!-- Description of the challenge -->
1. Write a function called tree_intersection that takes two binary tree parameters.
2. Without utilizing any of the built-in library methods available to your language, return a set of values found in both trees.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach we took was populating a hash table with the values of the first tree then do the same for the second tree and if they are any collisions added that value to an array.

Big O is

Time: O(h) h = The hieght of the tree.
Space: O(2n)

## Solution
<!-- Embedded whiteboard image -->
![Whiteboard Picture](/assets/tree_intersectionWB.jpg)