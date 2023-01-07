using System;
using System.Collections.Generic;
using System.Text;

namespace HeapSort
{
    interface Inode
    {
         int Data { get; set; }
         Node Left { get; set; }
         Node Right { get; set; }
    }
}
