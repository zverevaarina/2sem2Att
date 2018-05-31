using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using ClassLibrary;

namespace Tree
{
    class DrawTree
    {
        public NodeTree head;
        public NodeTree selectNodeTree;
        const int step = 50;
        const int dh = 1;

        public static Bitmap bitmap;
        Graphics g;
        Pen myPen = Pens.Black;
        SolidBrush myBrush = (SolidBrush)Brushes.White;
        Font myFont = new Font("Courier New", 10, FontStyle.Bold);

        public void Draw()
        {
            using (g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                if (head != null)
                    DrawNode(g, head);
            }
        }

        public void DrawNode(Graphics g, NodeTree node)  
        {

            Pen myPen = Pens.Black;
            SolidBrush myBrush = (SolidBrush)Brushes.White;
            Font myFont = new Font("Courier New", 10, FontStyle.Bold);

            int R = 17;
            if (node.Left != null)
                g.DrawLine(myPen, node.X, node.Y, node.Left.X, node.Left.Y);
            if (node.Right != null)
                g.DrawLine(myPen, node.X, node.Y, node.Right.X, node.Right.Y);

            if (node.Visit)
                myBrush = (SolidBrush)Brushes.CadetBlue;
            else
                myBrush = (SolidBrush)Brushes.AliceBlue;

            g.FillEllipse(myBrush, node.X - R, node.Y - R, 2 * R, 2 * R);
            g.DrawEllipse(myPen, node.X - R, node.Y - R, 2 * R, 2 * R);
            string s = Convert.ToString(node.Data);
            SizeF size = g.MeasureString(s, myFont);
            g.DrawString(s, myFont, Brushes.Black,
                node.X - size.Width / 2,
                node.Y - size.Height / 2);

            if (node.Left != null)
                DrawNode(g, node.Left);
            if (node.Right != null)
                DrawNode(g, node.Right);
        }

        public void DeSelect(NodeTree node)
        {
            if (node != null)
            {
                node.Visit = false;
                DeSelect(node.Left);
                DeSelect(node.Right);
            }
        }

        public void Delta(NodeTree nodeT, int dx, int dy)
        {
            nodeT.X -= dx; nodeT.Y -= dy;
            if (nodeT.Left != null)
                Delta(nodeT.Left, dx, dy);
            if (nodeT.Right != null)
                Delta(nodeT.Right, dx, dy);
        }

        public void AddNode(ref NodeTree t, int data, int x, int y)
        {
            if (t == null)
                t = new NodeTree(null, null, data, x, y);
            else
                if (data < Convert.ToInt32(t.Data))
                AddNode(ref t.Left, data, t.X - step, t.Y + dh * step);
            else
                    if (data > Convert.ToInt32(t.Data))
                AddNode(ref t.Right, data, t.X + step, t.Y + dh * step);
        }

        public NodeTree FindNode(NodeTree node, int x, int y)
        {
            NodeTree result = null;
            if (node == null)
                return result;

            if (((node.X - x) * (node.X - x) + (node.Y - y) * (node.Y - y)) < 100)
                result = node;
            else
            {
                result = FindNode(node.Left, x, y);
                if (result == null)
                    result = FindNode(node.Right, x, y);
            }
            return result;
        }

        public void Clear()
        {
            head = selectNodeTree = null;
        }
    }
}
