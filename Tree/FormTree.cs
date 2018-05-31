using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Tree
{
    public partial class FormTree : Form
    {
        DrawTree myTree;
        Graphics g;
        bool drawing = false;

        public FormTree()
        {
            InitializeComponent();
        }

        private void FormTree_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            myTree = new DrawTree();
            DrawTree.bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
        }

        public void MyDraw()
        {
            if (DrawTree.bitmap != null)
            {
                myTree.Draw();
                g.DrawImage(DrawTree.bitmap, ClientRectangle);
            }
        }

        private void FormTree_Paint(object sender, PaintEventArgs e)
        {
            MyDraw();
        }

        private void FormTree_MouseDown(object sender, MouseEventArgs e)
        {
            myTree.DeSelect(myTree.head);
            myTree.selectNodeTree = myTree.FindNode(myTree.head, e.X, e.Y);
            drawing = myTree.selectNodeTree != null;
            if (drawing)
                myTree.selectNodeTree.Visit = true;
        }

        private void FormTree_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
                myTree.Delta(myTree.selectNodeTree, myTree.selectNodeTree.X - e.X, myTree.selectNodeTree.Y - e.Y);
            else
            {
                myTree.DeSelect(myTree.head);
                myTree.selectNodeTree = myTree.FindNode(myTree.head, e.X, e.Y);
                if (myTree.selectNodeTree != null)
                    myTree.selectNodeTree.Visit = true;
            }
            MyDraw();
        }

        private void FormTree_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            textBoxRes.Text = "";
            Random rnd = new Random();
            myTree.Clear();
            for (int i = 0; i < 20; i++)
            {
                int k = rnd.Next(30);
                myTree.AddNode(ref myTree.head, k, 200, 40);
            }
            MyDraw();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            var min = myTree.head.FindMin();
            if (min == null)
                textBoxRes.Text = "Дерево пустое";
            else
                textBoxRes.Text = Convert.ToString(min);
        }
    }
}
