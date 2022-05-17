using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class BFS
    {
        AStar A = new AStar();
        public List<int[]> steps = new List<int[]>();
        public int counter = 0;

        public void breadthFirstSearch(Node root)
        {
           // List<Node> steps = new List<Node>();
            List<Node> white = new List<Node>();
            List<Node> black = new List<Node>();
            bool reached = false;
            white.Add(root);
            
            while (white.Count > 0 && !reached)
            {
                Node current = white[0];
                black.Add(current);
                white.RemoveAt(0);
                int x = current.findZeroIndx();
                A.PotentialNodes(x, current);
                //Console.WriteLine(current.childrenOfNode.Count);
                for (int i = 0; i < current.childrenOfNode.Count; i++)
                {
                    Node child = current.childrenOfNode[i];

                    if (Helpers.goal(child.puzzle))
                    {
                        //Console.WriteLine("first if");
                        reached = true;
                        Node c = child;

                        steps.Insert(0 , c.puzzle);
                        while (c.parent != null)
                        {
                            //Console.WriteLine("Found but getting steps");
                            c = c.parent;
                            steps.Insert(0,c.puzzle);
                        }
                        break;
                    }

                    if (contains(white, child) == false && contains(black, child) == false)
                    {
                        white.Add(child);
                        counter++;
                        //Console.WriteLine(counter);
                        //Console.WriteLine(white.Count);
                        //Console.WriteLine(child.puzzleStr);
                        // Console.WriteLine("Second if");
                    }
                }
            }

            
        }
        private bool contains(List<Node> n, Node o)
        {
            bool contain = false;
            for (int i = 0; i < n.Count; i++)
            {
                if (n[i].comparePuzzles(o.puzzle))
                {
                    contain = true;
                    break;
                }
            }
            return contain;
        }
    }
}
