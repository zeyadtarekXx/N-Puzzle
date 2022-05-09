 class Node
    {
        public Node parent;
        public int[] puzzle;
        public List<Node> childrenOfNode = new List<Node>();
        public int perimeter;
        //h 
        public int heuristic_value;
        public int expansion_order;
        public int f , g;

        public Node(int p , int[] puzzle)
        {
            this.puzzle = puzzle;
            this.perimeter = p;
        }
       public void set_F(int g , int h)
        {
            this.g = g;
            this.heuristic_value = h;
            this.f = g + h;
        }

    }
