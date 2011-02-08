using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.google.zxing
{
    internal static class ArrayExtensions
    {
        internal static bool IsBlank(this Object obj)
        {
            return obj == null;
        }
        internal static bool HasValue(this Object obj)
        {
            return obj != null;
        }
    }
}
