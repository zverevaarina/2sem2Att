using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FindeMinT
    {
        public NodeTree head;
        public int? FindMin()
        {
            var h = head;
            if (h == null)
                return null;
            return h.FindMin();
        }

    }
}
