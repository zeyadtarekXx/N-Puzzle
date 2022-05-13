using System;


namespace NPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] current = new int[] {8,6,7,
                                       2,5,4,
                                       3,0,1};//md 21
            int[] current0 = new int[]{ 0, 1, 2,
                                        5, 6 ,3,
                                        4, 7, 8};

            int[] current1 = new int[] {1,2,5,
                                        3,0,6,
                                        7,4,8};//md 8

            int[] current3 = new int[] {0,1,3,
                                        4,2,5,
                                        7,8,6};//md 8
            int[,] goal = new int [,] {    {1,2,3},
                                             {4,5,6},
                                             {7,8,0}
                                    };
            //Helpers help = new Helpers();
            PriorityQueue queue = new PriorityQueue();
            Node node = new Node(3, current0);
            //node.set_F(2, 5);
            Node node2 = new Node(3, current1);
            //node2.set_F(2, 3);
            Node node3 = new Node(3, current3);
            //node2.set_F(1, 3);
            //queue.HeapInsert(node);
            //queue.HeapInsert(node3);

            //queue.HeapInsert(node2);


            Readfromfile test = new Readfromfile("8 Puzzle(3) - Case 1.txt");
            Node t = new Node(test.N, test.p);
            Solvable.isSolvable(t);

            AStar a = new AStar();

            //a.solver(t);
            //if (queue.getMin() == null)
               Console.WriteLine("null");
            //else
            //Console.WriteLine(queue.getMin().puzzleStr);
            int md = Helpers.ManhattanDistance(current);
            //int hd = help.HammingDistance(current1);
            //Console.WriteLine(md);

        }
    }
}
