using System;
using System.Collections.Generic;
using System.Text;

namespace NPuzzle
{
    class Node 
    {

        public Node parent;
        public int[] puzzle;
        public List<Node> childrenOfNode = new List<Node>();
        public int perimeter;
        //h 
        public int heuristic_value;
        public int expansion_order;
        public int f, g;
        public int zeroIndx;
        public String puzzleStr;
        

        public Node(int p, int[] puzzle)
        {
            this.puzzle = puzzle;
            this.perimeter = p;
            puzzleToStr();
            findZeroIndx();
        }
        public Node()
        {

        }

       
        public void set_F(int g, int h)
        {
            this.g = g;
            this.heuristic_value = h;
            this.f = g + h;
        }

        public int findZeroIndx()
        {
            int size = this.perimeter * this.perimeter;
            for (int i = 0; i < size; i++)
            {
                if (this.puzzle[i] == 0)
                {
                    this.zeroIndx = i;
                    return zeroIndx;
                }
            }
            return -1 ;
        }
        
        public void puzzleToStr()
        {
            this.puzzleStr = null;
            int size = this.perimeter * this.perimeter;
            for (int i = 1; i <= size; i++)
            {
                this.puzzleStr += puzzle[i-1] + " ";
                if (i%this.perimeter==0)
                    this.puzzleStr += "\n";
            }
        }

   
    }
}
