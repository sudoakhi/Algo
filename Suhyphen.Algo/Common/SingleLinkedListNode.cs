﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Common
{
    internal sealed class SingleLinkedListNode
    {
        internal int _value;
        internal SingleLinkedListNode _next;

        public SingleLinkedListNode(int value)
        {
            _value = value;
            _next = null;
        }
    }
}
