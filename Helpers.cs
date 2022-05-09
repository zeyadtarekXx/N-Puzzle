using System;

namespace NPuzzle
{
    class Helpers
    {
        public static int ManhattanDistance(int[] current)
        {
            int n = (int)Math.Sqrt(current.Length);
            int md = 0;
            int size = n * n;
            for (int i = 0; i < size; i++)
            {
                if (current[i] != 0 && current[i] != i + 1)
                {
                    int x, y;
                    x = Math.DivRem(current[i] - 1, n, out y);
                    md += Math.Abs(i / 3 - x) + Math.Abs(i % 3 - y);
                }
            }
            return md;
        }

        public static int HammingDistance(int[] current)
        {
            int size= current.Length;
            int hd = 0;
            for (int i = 0; i < size; i++)
            {
                if (current[i] != 0 && current[i] != i+1)
                {
                    hd++;
                }
            }
           return hd;
        }
        public static Node moveRight(int indx, Node current)
        {
            Node newPuzzle = new Node(current.perimeter, current.puzzle);
            newPuzzle.parent = current;

            newPuzzle.puzzle[indx + 1] = current.puzzle[indx];
            newPuzzle.puzzle[indx] = current.puzzle[indx + 1];

            newPuzzle.puzzleToStr();
            newPuzzle.zeroIndx += 1;

            return newPuzzle;
        }
        public static Node moveLeft(int indx, Node current)
        {
            Node newPuzzle = new Node(current.perimeter,current.puzzle);
            newPuzzle.parent = current;

            newPuzzle.puzzle[indx-1] = current.puzzle[indx];
            newPuzzle.puzzle[indx] = current.puzzle[indx - 1];

            newPuzzle.puzzleToStr();
            newPuzzle.zeroIndx -= 1;

            return newPuzzle;
        }
        public static Node moveUp(int indx, Node current)
        {
            Node newPuzzle = new Node(current.perimeter, current.puzzle);
            newPuzzle.parent = current;

            newPuzzle.puzzle[indx - current.perimeter ] = current.puzzle[indx];
            newPuzzle.puzzle[indx] = current.puzzle[indx - current.perimeter];

            newPuzzle.puzzleToStr();
            newPuzzle.zeroIndx -= current.perimeter;

            return newPuzzle;

        }
        public static Node moveDown(int indx, Node current)
        {
            Node newPuzzle = new Node(current.perimeter, current.puzzle);
            newPuzzle.parent = current;

            newPuzzle.puzzle[indx + current.perimeter] = current.puzzle[indx];
            newPuzzle.puzzle[indx] = current.puzzle[indx + current.perimeter];

            newPuzzle.puzzleToStr();
            newPuzzle.zeroIndx += current.perimeter;

            return newPuzzle;
        }
        public static bool goal(int [] puzzle)
        {
            int size = puzzle.Length;
            for (int i = 0; i < size-1; i++)
            {
                if (puzzle[i] != i + 1)
                {
                    return false; 
                }
            }
            return true;
        }
    }
}
