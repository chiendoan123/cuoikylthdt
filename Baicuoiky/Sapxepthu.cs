﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Baicuoiky
{
    class Sapxepthu : IComparer<Thu>
    {
        public int Compare(Thu x, Thu y)
        {            
            return x.Idthu.CompareTo(y.Idthu);            
        }
    }
}
