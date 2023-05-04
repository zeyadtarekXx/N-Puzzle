# N-Puzzle
The N-Puzzle is known in finite versions such as the 8-puzzle (a 3x3 board) and the 15-puzzle (a 4x4 board),
and with various names like "sliding block", "tile puzzle", etc. The N-Puzzle is a board game for a single player.
It consists of (N) numbered squared tiles in random order, and one blank space ("a missing tile"). 
The objective of the puzzle is to rearrange the tiles in order by making sliding moves that use the empty space, using the fewest moves.
Moves of the puzzle are made by sliding an adjacent tile into the empty space
Only tiles that are horizontally or vertically adjacent to the blank space (not diagonally adjacent) may be moved. 

We solved this problem by using Astar(A*) Algorithm and BFS Algorithm
using Manhattan heuristic and Hamming Heuristic
Priority Queue>>OPEN LIST //
Hashset>>CLOSED LIST

before the Algorithm Starts we make sure that the puzzle is Solvable by checking number of inversions (using enhanced merge sort)

IMPLEMENTATION
1.	Read in a file containing an N board with (N – 1) numbered tiles and one blank space – representing an initial state. 
2.	Determine whether a given state is solvable or not? 
3.	Implement A* search algorithm on N-puzzle by constructing the graph/tree and the priority queue according to the following two different priority functions 
    1.	Hamming Distance
    2.	Manhattan Distance
4.	Print a STEP by STEP movements occur in the A* algorithms till you reach the final solvable board.
//EXTRAS
1.	Apply different shortest path algorithm (BFS) to search for the goal state. 
2.	Simulation user friendly GUI which allows you to rewind the search one step (movement) at a time over a generic N-puzzle.

![2023-05-04 21_45_57-WhatsApp](https://user-images.githubusercontent.com/61972622/236299727-ce5da394-eb51-4072-8825-016affba85c1.png)
![2023-05-04 21_45_35-WhatsApp](https://user-images.githubusercontent.com/61972622/236299740-d856f31a-35ea-4f10-97ea-0de870dc8b95.png)
![2023-05-04 21_45_52-WhatsApp](https://user-images.githubusercontent.com/61972622/236299753-dbf28751-4246-4097-9442-f26661356005.png)
