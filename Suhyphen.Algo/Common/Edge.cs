﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Common
{
    internal sealed class Edge
    {
        internal string _sourceVertex;
        internal string _destinationVertex;
        internal int _weight;

        public Edge(string sourceVertex, string destinationVertex, int weight)
        {
            _sourceVertex = sourceVertex;
            _destinationVertex = destinationVertex;
            _weight = weight;
        }
    }
}
