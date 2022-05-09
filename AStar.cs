using System;
using System.Collections.Generic;
using System.Text;


namespace NPuzzle
{
    class AStar
    {
        private HashSet<string> hashset= new HashSet<string>();
        private Queue<Node> pqueue;

        public void solver(Node parentnode)
        {
            hashset.Add(parentnode.puzzleStr);
            pqueue.Enqueue(parentnode);
            Node node;
            while(true)
            {
                node = pqueue.Dequeue();
                if (Helpers.goal(node.puzzle))
                {
                   
                    break;
                }
                else
                {
                    int zeroindx= node.zeroIndx;
                    PotentialNodes(zeroindx, node);

                }

            }
        }
        public void PotentialNodes(int indx, Node current)
        {
            int zeroRow= indx / current.perimeter;
            int zeroCol = indx % current.perimeter;
           
            if (zeroCol < current.perimeter - 1)
            {
                Node newPuzzle = Helpers.moveRight(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(current.g + 1, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.Enqueue(newPuzzle);
                    hashset.Add(newPuzzle.puzzleStr);
                    current.childrenOfNode.Add(newPuzzle);

                }
            }
            if (zeroCol > 0)
            {
                Node newPuzzle = Helpers.moveLeft(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(current.g + 1, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.Enqueue(newPuzzle);
                    hashset.Add(newPuzzle.puzzleStr);
                    current.childrenOfNode.Add(newPuzzle);
                }

            }
            if (zeroRow < current.perimeter - 1)
            {
                Node newPuzzle = Helpers.moveDown(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(current.g + 1, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.Enqueue(newPuzzle);
                    hashset.Add(newPuzzle.puzzleStr);
                    current.childrenOfNode.Add(newPuzzle);
                }

            }
            if (zeroRow > 0)
            {
                Node newPuzzle = Helpers.moveUp(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(current.g + 1, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.Enqueue(newPuzzle);
                    hashset.Add(newPuzzle.puzzleStr);
                    current.childrenOfNode.Add(newPuzzle);
                }

            }

        }
    }
}
