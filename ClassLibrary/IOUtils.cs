using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class IOUtils
    {
        public string [] Str { get; set; }

        public IOUtils(string filename)
        {
            this.Str = File.ReadAllLines(filename, Encoding.Default);
        }

        public string[] Printer(Node head)
        {
            string[] st = new string[0];
            int L = 0;
            Node p = head;
            if (p != null)
                do
                {
                    Array.Resize<string>(ref st, ++L);
                    st[L - 1] = p.Count.ToString() + " " + p.Inf.ToString();
                    p = p.Next;
                }
                while (p != null);
            return st;
        }

        public string[] SetList(Node head)
        {
            
            int L = Str.Length;
            string[] sArr = { " " };
            for (int i = 0; i < L; i++)
            {
                char[] sep = { ' ', '.', ';', ':', '(', ')', '{', '}', '[', ']', '"', '=', '!', '<', '>', '+', '-', '/', '&', ',', '|' };
                if (Str[i] != null)
                {
                    sArr = Str[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                }
                
            }
            return sArr;
        }
    }
}
