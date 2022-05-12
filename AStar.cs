using System;
using System.Collections.Generic;
using System.Text;


namespace NPuzzle
{
    class AStar
    {
        private HashSet<string> hashset= new HashSet<string>();
        private PriorityQueue pqueue =new PriorityQueue();
        static int count = 0;
        bool dubpath = false;
        int movements=0;
        public bool dubPath(Node node)
        {
            int minh=node.parent.heuristic_value;
            if(node.heuristic_value>minh)
            {

                return false;
            }
            else
            {
                solver(node);
                return true;
            }
           
        }

        public void solver(Node parentnode)
        {
            hashset.Add(new string(parentnode.puzzleStr));
            Node node=null;
            while(true)
            {
                if (node==null)
                {
                    node = parentnode;
                    Console.WriteLine(node.puzzleStr);
                    
                }
                else
                {
                    //if(pqueue.checkDublic())
                    //{

                    //    for(int i=0;i<pqueue.minNum;i++)
                    //    {
                    //        dubpath = true; //movement I started from
                    //       solver(pqueue.nodes[i]);
                            
                    //    }
                    //}
                    //else
                    //{
                    node = pqueue.HeapExtractMin();
                    Console.WriteLine("depth");
                    Console.WriteLine(node.g);
                    Console.WriteLine(node.puzzleStr);
                    if (count == 9)
                        count++;

                    //}

                }

                if (Helpers.goal(node.puzzle))
                {
                    //Console.WriteLine(count);
                    //Console.WriteLine("depth");
                    //Console.WriteLine(node.g);
                    //Console.WriteLine(node.puzzleStr);
                    break;
                }
                else
                {
                    int zeroindx= node.zeroIndx;
                    PotentialNodes(zeroindx, node);
                    //node = pqueue.getMin();
                    //if (dubpath && node.heuristic_value > node.parent.heuristic_value)
                    //{
                    //    dubpath = false;
                    //    return;
                    //}
                    //if (node!=null)
                    //Console.WriteLine(node.puzzleStr);
                }
                count++;
            }
        }
        public void PotentialNodes(int indx, Node current)
        {
           // pqueue = new PriorityQueue();
            int zeroRow= indx / current.perimeter;
            int zeroCol = indx % current.perimeter;
            //current.g ++;
            if (zeroCol < current.perimeter - 1)
            {
                Node newPuzzle = Helpers.moveRight(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(newPuzzle.g , Helpers.ManhattanDistance(newPuzzle.puzzle));
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
                    newPuzzle.set_F(newPuzzle.g , Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(new string(newPuzzle.puzzleStr));
                    current.childrenOfNode.Add(newPuzzle);
                    newPuzzle.parent = current;
                }

            }
            if (zeroRow < current.perimeter - 1)
            {
                Node newPuzzle = Helpers.moveDown(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(newPuzzle.g, Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(new string(newPuzzle.puzzleStr));
                    current.childrenOfNode.Add(newPuzzle);
                    newPuzzle.parent = current;
                }

            }
            if (zeroRow > 0)
            {
                Node newPuzzle = Helpers.moveUp(indx, current);
                if (!hashset.Contains(newPuzzle.puzzleStr))
                {
                    newPuzzle.set_F(newPuzzle.g , Helpers.ManhattanDistance(newPuzzle.puzzle));
                    newPuzzle.expansion_order = current.expansion_order + 1;
                    pqueue.HeapInsert(newPuzzle);
                    hashset.Add(new string(newPuzzle.puzzleStr));
                    current.childrenOfNode.Add(newPuzzle);
                    newPuzzle.parent = current;
                }

            }

        }
    }
}
