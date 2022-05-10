using System;
using System.Collections.Generic;
using System.Text;

namespace NPuzzle
{
    class PriorityQueue
    {
        public static Node[] nodes = new Node[100];
        public static int size =  -1 ; 
        private int getParentIndex(int indx)
        {
            if(indx < 0)
            {
                return -1;
            }
            return (indx - 1) / 2;
        }
        private int getLeftChildIndex(int indx)
        {
            if(indx < 0)
            {
                return -1;
            }
            return ((2 * indx) + 1);
        }

        private int getRightChildIndex(int indx)
        {
            if (indx < 0)
            {
                return -1;
            }
            return ((2 * indx) + 2);
        }

        private void swap(int i, int j)
        {
            Node temp = nodes[i];
            nodes[i] = nodes[j];
            nodes[j] = temp;
        }

        public Node HeapExtractMin()
        {
            if (size > -1)
            {
                Node n = nodes[0];
                nodes[0] = nodes[size];
                size = size - 1;
                this.shiftElementsDown(0);
                return n;
            }
            throw new InvalidOperationException("Heap is empty");
        }

        private void shiftElementsDown(int indx)
        {
            int min = indx;
            int l = this.getLeftChildIndex(indx);
            int r = this.getRightChildIndex(indx);

            if (l <= size && nodes[l].f < nodes[min].f)
            {
                min = l;
            }
            if (r <= size && nodes[r].f < nodes[min].f)
            {
                min = r;
            }
            if(indx != min)
            {
                swap(indx, min);
                this.shiftElementsDown(min);

            }
        }

        private void shiftElementsUp(int i)
        {
            while (i > 0 && nodes[getParentIndex(i)].f > nodes[i].f)
            {
                swap(getParentIndex(i), i);
                i = getParentIndex(i);
            }
        }

        public void HeapInsert(Node n)
        {
            size = size + 1;
            nodes[size] = n;
            this.shiftElementsUp(size);
        }

        public Node getMin()
        {
            return nodes[0];
        }

    }
}
