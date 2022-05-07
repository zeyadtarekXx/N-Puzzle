using System;


namespace NPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] current = new int[,] {   {8,6,7},
                                                {2,5,4},
                                                {3,0,1}
                                    };
            int[,] current1 = new int[,] {   {1,2,5},
                                                {3,0,6},
                                                {7,4,8}
                                    };
            int[,] goal = new int [,] {    {1,2,3},
                                             {4,5,6},
                                             {7,8,0}
                                    };
            Helpers help = new Helpers();
            int md = help.ManhattanDistance(current);
            int hd = help.HammingDistance(current1);
            Console.WriteLine(md);
        }
    }
}
