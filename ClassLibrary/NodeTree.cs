using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NodeTree
    {
        public int Data { get; set; }
        public NodeTree Left { get; set; }
        public NodeTree Right { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Visit { get; set; }

        public NodeTree(NodeTree left, NodeTree right, int data, int x, int y)
        {
            this.Left = left;
            this.Right = right;
            this.Data = data;
            this.X = x;
            this.Y = y;
            this.Visit = false;
        }

        public int FindMin()
        {
            if (Right == null && Left == null)
                return Data;
            if (Right == null)
                return Left.FindMin();
            if (Left == null)
                return Right.FindMin();
            return Math.Min(Left.FindMin(), Right.FindMin());
        }

    }
}
