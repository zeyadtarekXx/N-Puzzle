using System;
using System.Collections.Generic;
using System.Text;

namespace NPuzzle
{
    class BFS
    {
        public static List<int[]> steps = new List<int[]>();
        public static void breadthFirstSearch(Node root)
        {
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
                AStar.PotentialNodes(x, current);
                for (int i = 0; i < current.childrenOfNode.Count; i++)
                {
                    Node child = current.childrenOfNode[i];

                    if (Helpers.goal(child.puzzle))
                    {
                        reached = true;
                        Node c = child;

                        steps.Insert(0, c.puzzle);
                        while (c.parent != null)
                        {
                            c = c.parent;
                            steps.Insert(0, c.puzzle);
                        }
                        break;
                    }

                    if (contains(white, child) == false && contains(black, child) == false)
                    {
                        white.Add(child);
                    }
                }
            }
        }
        private static bool contains(List<Node> n, Node o)
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
