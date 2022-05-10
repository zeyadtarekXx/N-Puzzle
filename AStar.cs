using System;
using System.Collections.Generic;
using System.Text;


namespace NPuzzle
{
    class AStar
    {
        private HashSet<string> hashset= new HashSet<string>();
        private PriorityQueue pqueue;

        public void solver(Node parentnode)
        {
            hashset.Add(new string(parentnode.puzzleStr));
            Node node=null;
            int count = 0;
            while(true)
            {
                if (node==null)
                {
                    node = parentnode;
                    Console.WriteLine(node.puzzleStr);
                }
                else
                  node = pqueue.getMin();
                //Console.WriteLine("\n");

                if (Helpers.goal(node.puzzle))
                {
                    Console.WriteLine(count);
                    break;
                }
                else
                {
                    int zeroindx= node.zeroIndx;
                    if (count == 21)
                        count++;
                    PotentialNodes(zeroindx, node);

                    Console.WriteLine(pqueue.getMin().puzzleStr);
                    

                }
                //for (int i = 0; i < node.childrenOfNode.Count; i++)
                //{
                    //Console.WriteLine("Childern");
                    //Console.WriteLine(node.childrenOfNode[i].puzzleStr);
                //}
            
                count++;

            }
        }
        public void PotentialNodes(int indx, Node current)
        {

            pqueue = new PriorityQueue();
            int zeroRow= indx / current.perimeter;
            int zeroCol = indx % current.perimeter;
           
            if (zeroCol < current.perimeter - 1)
            {
                Node newPuzzle = new Node();
                newPuzzle=Helpers.moveRight(indx, current);
                //if(newPuzzle==null)
                //Console.WriteLine("right");
                // Console.WriteLine(newPuzzle.puzzleStr);
                // Console.WriteLine(newPuzzle.puzzleStr);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(current.g + 1, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(newPuzzle.puzzleStr);
                    current.childrenOfNode.Add(newPuzzle);

                }
            }
            if (zeroCol > 0)
            {
                Node newPuzzle = Helpers.moveLeft(indx, current);
                //Console.WriteLine("left");
                //Console.WriteLine(newPuzzle.puzzleStr);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(current.g + 1, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(new string(newPuzzle.puzzleStr));
                    current.childrenOfNode.Add(newPuzzle);
                }

            }
            if (zeroRow < current.perimeter - 1)
            {
                Node newPuzzle = Helpers.moveDown(indx, current);
                //Console.WriteLine("down");
                //Console.WriteLine(newPuzzle.puzzleStr);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(current.g + 1, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(new string(newPuzzle.puzzleStr));
                    current.childrenOfNode.Add(newPuzzle);
                }

            }
            if (zeroRow > 0)
            {
                Node newPuzzle = Helpers.moveUp(indx, current);
                //Console.WriteLine("up");
                //Console.WriteLine(newPuzzle.puzzleStr);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(current.g + 1, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(new string(newPuzzle.puzzleStr));
                    current.childrenOfNode.Add(newPuzzle);
                }

            }

        }
    }
}
