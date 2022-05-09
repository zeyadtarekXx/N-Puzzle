using System;

namespace NPuzzle
{
    class Helpers
    {
        public int ManhattanDistance(int[] current)
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

        public int HammingDistance(int[] current)
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
    }
}
