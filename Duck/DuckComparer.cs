﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    internal class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortCriteria = SortCriteria.SizeThenKind;
        public int Compare(Duck x, Duck y)
        {
            if (SortCriteria == SortCriteria.SizeThenKind)
            {
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else
                {
                    if (x.Kind > y.Kind)
                        return 1;
                    else if (x.Kind < y.Kind)
                        return -1;
                    else
                        return 0;
                }
            }
            else
            {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else
                {
                    if (x.Size > y.Size)
                        return 1;
                    else if (x.Size < y.Size)
                        return -1;
                    else
                        return 0;
                }
            }
        }
    }
    enum SortCriteria
    {
        SizeThenKind,
        KindThenSize,
    }
}
