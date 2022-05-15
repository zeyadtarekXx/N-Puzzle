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
                    x = (int)Math.Floor(Convert.ToDouble(x));
                    md += Math.Abs(i / n - x) + Math.Abs(i % n - y);
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
            int[] copy = new int[current.perimeter * current.perimeter];
            copypuzzle(copy, current.puzzle, current.perimeter * current.perimeter);

            int temp = copy[indx + 1];
            copy[indx + 1] = copy[indx];
            copy[indx] = temp;

            Node newPuzzle = new Node(current.perimeter, copy);
            newPuzzle.zeroIndx =current.zeroIndx+ 1;
            newPuzzle.g = current.g + 1;

            return newPuzzle;
        }
        public static Node moveLeft(int indx, Node current)
        {
         
            int[] copy = new int[current.perimeter * current.perimeter];
            copypuzzle(copy, current.puzzle, current.perimeter * current.perimeter);

            int temp = copy[indx - 1];
            copy[indx - 1] = copy[indx];
            copy[indx] = temp;

            Node newPuzzle = new Node(current.perimeter, copy);
            newPuzzle.zeroIndx = current.zeroIndx - 1;
            newPuzzle.g = current.g + 1;

            return newPuzzle;
        }
        public static Node moveUp(int indx, Node current)
        {
            int[] copy = new int[current.perimeter * current.perimeter];
            copypuzzle(copy, current.puzzle, current.perimeter * current.perimeter);

            int temp = copy[indx - current.perimeter];
            copy[indx - current.perimeter] = copy[indx];
            copy[indx] = temp;

            Node newPuzzle = new Node(current.perimeter, copy);
            newPuzzle.zeroIndx = current.zeroIndx - current.perimeter;
            newPuzzle.g = current.g + 1;

            return newPuzzle;

        }
        public static Node moveDown(int indx, Node current)
        {
            int[] copy = new int[current.perimeter * current.perimeter];
            copypuzzle(copy, current.puzzle, current.perimeter * current.perimeter);

            int temp = copy[indx + current.perimeter];
            copy[indx + current.perimeter] = copy[indx];
            copy[indx] = temp;

            Node newPuzzle = new Node(current.perimeter, copy);
            newPuzzle.zeroIndx = current.zeroIndx + current.perimeter;
            newPuzzle.g = current.g + 1;

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
        public static void copypuzzle(int[] x, int[] y, int size)
        {
            for (int i = 0; i < size; i++)
            {
                x[i] = y[i];
            }
        }
 
    }
}
