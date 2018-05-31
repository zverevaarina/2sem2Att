using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sort
{
    public partial class FormSort : Form
    {
        static Graphics gBitmap;
        static Graphics gScreen;
        static Bitmap bitmap;
        static Rectangle r;

        public FormSort()
        {
            InitializeComponent();
            Sorts.SetRandom();
        }

        private void FormSort_Load(object sender, EventArgs e)
        {
            gBitmap = this.CreateGraphics();
            gScreen = CreateGraphics();
            bitmap = new Bitmap(ClientRectangle.Width,
            ClientRectangle.Height);
            gBitmap = Graphics.FromImage(bitmap);
            r = ClientRectangle;
        }

        private void FormSort_Paint(object sender, PaintEventArgs e)
        {
            MyDraw();
        }

        public static void MyDraw()
        {
            gBitmap.Clear(Color.White);
            Sorts.Drawing(gBitmap);
            gScreen.DrawImage(bitmap, r);
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            Sorts.SortBuble(gBitmap);
        }

        private void Rundom_Click(object sender, EventArgs e)
        {
            Sorts.SetRandom();
            Sorts.Drawing(gBitmap);
        }

        private void QuickSort_Click(object sender, EventArgs e)
        {
            Sorts.StartQuickSort(gBitmap);
        }
    }
}
