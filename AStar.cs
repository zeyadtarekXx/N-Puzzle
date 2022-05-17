using System;
using System.Collections.Generic;
using System.Text;


namespace NPuzzle
{
    class AStar
    {
        private static HashSet<string> hashset= new HashSet<string>();//closed list
        private static PriorityQueue pqueue =new PriorityQueue();//open list
        public static Node solver(Node parentnode)
        {
            hashset.Add(new string(parentnode.puzzleStr));
            Node node=null;
            while(true)
            {
                if (node==null)
                {
                    node = parentnode;
                }
                else
                {
                    node = pqueue.HeapExtractMin();
                }

                if (Helpers.goal(node.puzzle))
                {
                    return node;  
                }
                else
                {
                    int zeroindx= node.zeroIndx;
                    PotentialNodes(zeroindx, node);
                }
            }
        }
        public static void PotentialNodes(int indx, Node current)
        {
            int zeroRow= indx / current.perimeter;
            int zeroCol = indx % current.perimeter;
            if (zeroCol < current.perimeter - 1)
            {
                Node newPuzzle = Helpers.moveRight(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    //if(true)
                     newPuzzle.set_F(newPuzzle.g , Helpers.ManhattanDistance(newPuzzle.puzzle));
                    //else
                    // newPuzzle.set_F(newPuzzle.g, Helpers.HammingDistance(newPuzzle.puzzle));

                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(newPuzzle.puzzleStr);
                    current.childrenOfNode.Add(newPuzzle);
                    newPuzzle.parent = current;

                }
            }
            if (zeroCol > 0)
            {
                Node newPuzzle = Helpers.moveLeft(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                   // if (true)
                        newPuzzle.set_F(newPuzzle.g, Helpers.ManhattanDistance(newPuzzle.puzzle));
                   // else
                   //     newPuzzle.set_F(newPuzzle.g, Helpers.HammingDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(newPuzzle.puzzleStr);
                    current.childrenOfNode.Add(newPuzzle);
                    newPuzzle.parent = current;
                }

            }
            if (zeroRow < current.perimeter - 1)
            {
                Node newPuzzle = Helpers.moveDown(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                   // if (true)
                       newPuzzle.set_F(newPuzzle.g, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    //else
                     //   newPuzzle.set_F(newPuzzle.g, Helpers.HammingDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(newPuzzle.puzzleStr);
                    current.childrenOfNode.Add(newPuzzle);
                    newPuzzle.parent = current;
                }

            }
            if (zeroRow > 0)
            {
                Node newPuzzle = Helpers.moveUp(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    //if (true)
                        newPuzzle.set_F(newPuzzle.g, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    //else
                     //   newPuzzle.set_F(newPuzzle.g, Helpers.HammingDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(newPuzzle.puzzleStr);
                    current.childrenOfNode.Add(newPuzzle);
                    newPuzzle.parent = current;
                }

            }

        }
    }
}
