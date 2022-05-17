using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace NPuzzle
{
    class Program
    {
        public static Node final_node;
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch_bfs = new Stopwatch();

            //Complete
            //Solvable
            //Hamming and Manhattan
            //Readfromfile test = new Readfromfile("50 Puzzle.txt");
            //Readfromfile test = new Readfromfile("9999 Puzzle.txt");
            //Readfromfile test = new Readfromfile("99 Puzzle - 1.txt");
            //Readfromfile test = new Readfromfile("99 Puzzle - 2.txt");

            //Manhattan only
            //Readfromfile test = new Readfromfile("15 Puzzle 1.txt");
            //Readfromfile test = new Readfromfile("15 Puzzle 3.txt");
            //Readfromfile test = new Readfromfile("15 Puzzle 4.txt");
            //Readfromfile test = new Readfromfile("15 Puzzle 5.txt");

            //Complete
            //unsolvable
            //Readfromfile test = new Readfromfile("15 Puzzle 1 - Unsolvable.txt");
            //Readfromfile test = new Readfromfile("99 Puzzle - Unsolvable Case 1.txt");
            //Readfromfile test = new Readfromfile("99 Puzzle - Unsolvable Case 2.txt");
            // Readfromfile test = new Readfromfile("9999 Puzzle- Unsolvable.txt");

            //Sample testing
            //Solvable
            //Readfromfile test = new Readfromfile("8 Puzzle (1).txt");
            //Readfromfile test = new Readfromfile("8 Puzzle (2).txt");
            //Readfromfile test = new Readfromfile("8 Puzzle (3).txt");
            //Readfromfile test = new Readfromfile("15 Puzzle - 1.txt");
            //Readfromfile test = new Readfromfile("24 Puzzle 1.txt");
            Readfromfile test = new Readfromfile("24 Puzzle 2.txt");
            //Sample testing
            //unSolvable
            //Readfromfile test = new Readfromfile("8 Puzzle - Case 1.txt");
            //Readfromfile test = new Readfromfile("8 Puzzle(2) - Case 1.txt");
            //Readfromfile test = new Readfromfile("8 Puzzle(3) - Case 1.txt");
            //Readfromfile test = new Readfromfile("15 Puzzle - Case 2.txt");

            //v.large test
            //Readfromfile test = new Readfromfile("TEST.txt");


            Node t = new Node(test.N, test.p);
            t.findZeroIndx();

            if (Solvable.isSolvable(t))
            {
                //AStar
                stopwatch.Start();
                final_node = AStar.solver(t);
                stopwatch.Stop();

                Console.WriteLine("A* Time is {0} ms", stopwatch.ElapsedMilliseconds);
                Console.WriteLine("A* Time is {0} s", stopwatch.ElapsedMilliseconds / 1000);
                List<int[]> list = new List<int[]>();
                int size, n, puzSize;
                list = Helpers.getStates_puzz(final_node, out n, out size);
                Console.WriteLine("AStar movements: {0} ", size);
                puzSize = n * n;
                Console.WriteLine("AStar steps ");
                for (int i = 0; i <= size; i++)
                {
                    for (int j = 0; j < puzSize; j++)
                    {
                        Console.Write(list[i][j] + " ");
                        if ((j + 1) % n == 0)
                            Console.Write("\n");
                    }
                    Console.Write("\n");
                }

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("------------------------------------------\n");
                //BFS
                //Compare
                stopwatch_bfs.Start();
                BFS.breadthFirstSearch(t);
                stopwatch_bfs.Stop();

                Console.WriteLine("BFS Time is {0} ms", stopwatch_bfs.ElapsedMilliseconds);
                Console.WriteLine("BFS Time is {0} s", stopwatch_bfs.ElapsedMilliseconds / 1000);
                size = BFS.steps.Count;
                Console.WriteLine("BFS movements: {0} ", size-1);
                Console.WriteLine("BFS Steps ");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < puzSize; j++)
                    {
                        Console.Write(BFS.steps[i][j] + " ");
                        if ((j + 1) % n == 0)
                            Console.Write("\n");
                    }
                    Console.Write("\n");

                }
            }
        }
    }
}
