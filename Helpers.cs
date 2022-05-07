using System;
using System.Collections.Generic;
using System.Text;

namespace NPuzzle
{
    class Helpers
    {
        public int ManhattanDistance(int[,] current)
        {
            int n = (int)Math.Sqrt(current.Length);
            int md = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (current[i, j] != 0 && current[i, j] != i * n + j + 1)//only enter if the number isn't in order
                    {
                        //look for this element in goal to compare 
                        /* for (int k = 0; k < n; k++)
                             for (int h = 0; h < n; h++)
                                 if (current[i, j] == goal[k, h])
                                     md += Math.Abs(i - k) + Math.Abs(j - h);
                         */
                        int x, y;
                        x = Math.DivRem(current[i, j] - 1, n,out y);
                        md += Math.Abs(i - x) + Math.Abs(j - y);
                    }
                }
            }
            return md;
        }

        public int HammingDistance(int[,] current)
        {
            int n = (int)Math.Sqrt(current.Length);
            int hd = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (current[i, j] != 0 && current[i, j] != i*n+j+1)
                    {
                        hd++;
                    }
                }
            }
           return hd;
        }
    }
}
