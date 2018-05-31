using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class List
    {
        public Node Head { get; set; }
        public int Count { get; set; }

        public List()
        {
            this.Head = null;
            this.Count = 0;
        }

        public void Add(string [] s)
        {
            for (int i = 0; i < s.Length; i++)
                AddSort(s[i]);
        }

        public void AddSort(string inf)
        {
            if (Head != null)
            {
                Node l = Head;
                int k = string.CompareOrdinal(inf, l.Inf);

                if (k <= 0)
                    if (k == 0)
                        l.AddCount();
                    else
                    {
                        Node p = new Node(inf, l);
                        Head = p;
                    }
                else
                {
                    Node r;
                    do
                    {
                        r = l;
                        l = l.Next;
                        if (l != null)
                            k = string.CompareOrdinal(l.Inf, inf);
                    }
                    while ((l != null) && (k < 0));

                    if (l != null)
                        if (k == 0)
                            l.AddCount();
                        else
                        {
                            Node p = new Node(inf, l);
                            r.Next = p;
                        }
                    else
                    {
                        Node p = new Node(inf, null);
                        r.Next = p;
                    }
                }
            }
            else
                Head = new Node(inf, null);
            Count++;
        }
    }
}
