using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Node
    {
        public string Inf { get; set; }
        public Node Next { get; set; }
        public int Count { get; set; }
        public Node(string inf, Node next)
        {
            this.Inf = inf;
            this.Next = next;
            this.Count = 1;
        }
        public void AddCount()
        { Count++; }
    }
}
