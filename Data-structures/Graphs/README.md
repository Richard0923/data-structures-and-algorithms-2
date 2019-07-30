# Graphs
<!-- Short summary or background information -->
Graphs are a non-linear data structure that is a collection of Vertices or Nodes and each vertices is connected by Edges that can have a value to them called Weight

## Challenge
<!-- Description of the challenge -->
Implement A graph that has 5 Methods:
1. AddNode()
2. AddEdge()
3. GetNodes()
4. GetNeighbors()
5. Size()

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
AddVertex() 

Time: O(1) Its Just adding the vertex to the graph. 

Space: O(n) Creates a new Index in the graph and adds the value being given. 


AddEdge() 

Time: O(1) Its Just adding the edge to the graph. 

Space: O(n) Creates a new edge in the graph and adds the weight being given. 


GetVertices()

Time: O(n) It goes threw the Graph and adds every Vertex to a List. 

Space: O(n) Creates a new list and populates that list with all the Vertices inside that graph. 


GetNeighbors()

Time: O(n) It goes threw the Graph and adds every Edge to a Dictionary. 

Space: O(n) Creates a new Dictionary and populates that Dictionary with all the Edges inside that graph.


Size()

Time: O(1) Returns the size int property. 

Space: O(1)  



## API
<!-- Description of each method publicly available in your Graph -->
Methods Available:
1. AddVertex()
2. AddEdge()
3. AddUndirectedEdge()
4. GetVertices()
5. GetNeighbors()
6. Size()
