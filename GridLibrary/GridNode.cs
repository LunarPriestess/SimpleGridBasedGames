﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridLibrary
{
    internal class GridNode<TValue>
    {
        public TValue Data { get; set; }

        public int X { get; set; }
 
        public int Y { get; set; }

        public GridNode(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y}): {Data}";
        }

    }
}
