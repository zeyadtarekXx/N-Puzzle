using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace NPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
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
            Readfromfile test = new Readfromfile("8 Puzzle (2).txt");
            //Readfromfile test = new Readfromfile("8 Puzzle (3).txt");
            //Readfromfile test = new Readfromfile("15 Puzzle - 1.txt");
            //Readfromfile test = new Readfromfile("24 Puzzle 1.txt");
            //Readfromfile test = new Readfromfile("24 Puzzle 2.txt");
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
            Node node = new Node(); 
            if(Solvable.isSolvable(t)) 
            {
                 node=AStar.solver(t);
            }
            List<string> list = new List<string>();
            int size, n;
            list=Helpers.getStates(node, out n, out size);
            for (int i = 0; i <= size; i++)
            {
                Console.WriteLine(list[i]);
                Console.WriteLine("\n");
            }
            
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Elapsed Time is {0} s", stopwatch.ElapsedMilliseconds/1000);
          
                

        }
    }
}
