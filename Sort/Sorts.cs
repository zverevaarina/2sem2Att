using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Sort
{
    public struct TElement
    {
        public int x;
        public int y;
        public int inf;
        public Color color;
    }
    class Sorts
    {
        static TElement[] Element = new TElement[12];
        static Pen MyPen = new Pen(Color.CadetBlue, 1);
        static Pen MyPen0 = new Pen(Color.CadetBlue, 4);
        static Font font = new Font("Arial", 12);
        static int n = -1;
        static int m = -1;

        static void Change(Graphics gBitmap, int n1, int n2)
        {
            Element[n1].color = Color.Red;
            Element[n2].color = Color.Red;
            int x1 = Element[n1].x;
            int y1 = Element[n1].y;
            int x2 = Element[n2].x;
            int y2 = Element[n2].y;
            int y3 = 0;
            int y4 = 0;
            double y;

            for (int t = 0; t < 20; t++)
            {
                switch (t)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        y = 30 * t / 4;
                        Element[n1].y = y1 - (int)(y);
                        Element[n2].y = y2 + (int)(y);
                        y3 = Element[n1].y;
                        y4 = Element[n2].y;
                        break;
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        y = (x2 - x1) * (t - 4) / 7;
                        Element[n1].x = x1 + (int)(y);
                        Element[n2].x = x2 - (int)(y);
                        break;
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                        y = 30 * (t - 11) / 4;
                        Element[n1].y = y3 + (int)(y);
                        Element[n2].y = y4 - (int)(y);
                        break;
                }
                FormSort.MyDraw();
                Thread.Sleep(15);
            }
            Element[n1].color = Color.CadetBlue;
            Element[n2].color = Color.CadetBlue;
            FormSort.MyDraw();
        }

        public static void Drawing(Graphics gBitmap)
        {
            const int d = 15;
            int L = Element.Length;
            string s;
            SizeF size;
            gBitmap.Clear(Color.White);
            for (int i = 0; i <= L - 1; i++)
            {
                MyPen.Color = Element[i].color;
                gBitmap.DrawEllipse(MyPen, Element[i].x - d, Element[i].y - d, 2 * d, 2 * d);

                s = Convert.ToString(Element[i].inf);
                size = gBitmap.MeasureString(s, font);
                gBitmap.DrawString(s, font, Brushes.CadetBlue, Element[i].x - size.Width / 2, Element[i].y - size.Height / 2);
            }
        }

        public static void SortBuble(Graphics gBitmap)
        {
            int L = Element.Length;
            for (int i = 1; i <= L - 1; i++)
                for (int j = L - 1; j >= i; j--)
                {
                    TElement tmp;
                    if (Element[j - 1].inf > Element[j].inf)
                    {
                        n = j - 1; m = j;
                        Change(gBitmap, j, j - 1);
                        tmp = Element[j];
                        Element[j] = Element[j - 1];
                        Element[j - 1] = tmp;
                    }
                }
        }

        public static void StartQuickSort(Graphics gBitmap)
        {
            int left = 0;
            int right = Element.Length - 1;
            QuickSort(gBitmap, left, right);
        }
        public static void QuickSort(Graphics gBitmap, int left, int right)  // Рекурсивная
        {

            int i = left; int j = right;
            int x = Element[(left + right) / 2].inf;

            do
            {
                while (Element[i].inf < x)
                    i++;
                while (Element[j].inf > x)
                    j--;
                if (i <= j)
                {
                    Change(gBitmap, i, j);
                    TElement tmp = Element[i];
                    Element[i] = Element[j];
                    Element[j] = tmp;
                    i++; j--;
                }
            }
            while (i <= j);

            if (left < j)
                QuickSort(gBitmap, left, j);
            if (i < right)
                QuickSort(gBitmap, i, right);
        }

        public static void SetRandom()
        {
            int L = Element.Length;
            Random rnd = new Random();
            for (int i = 0; i <= L - 1; i++)
            {
                Element[i].x = 50 + i * 30;
                Element[i].y = 100;
                Element[i].color = Color.CadetBlue;
                Element[i].inf = rnd.Next(100);
            }
        }
    }
}
