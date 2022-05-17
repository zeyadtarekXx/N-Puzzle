using System;
using System.IO;


namespace ConsoleApp3
{
    class Readfromfile
    {
        public int N;
        public int[] p;
        StreamReader sr;
        public Readfromfile(String fileName)
        {
            sr = new StreamReader(fileName);
            Console.SetIn(sr);
            N = int.Parse(Console.ReadLine());
            p = new int[N * N];
            int k = 0;
            //Console.ReadLine();
            for (int i = 0; i < N ; i++)
            {
                string lineItems = Console.ReadLine();
                if (lineItems== String.Empty)
                {
                    i--;
                    continue;
                }
                string[] lineItems2 = lineItems.Split(' ');
                for (int j = 0; j < N; j++)
                {
                    p[k++] = int.Parse(lineItems2[j]);
                }
            }
            sr.Close();
        }
    }
}
