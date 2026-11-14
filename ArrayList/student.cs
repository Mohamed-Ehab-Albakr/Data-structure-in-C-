using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ArrayList
{
    internal class student : IEqualityComparer<student>
    {
        public int ssn;
        public bool Equals(student? x, student? y)
        {
            if (x.ssn == y.ssn)
            {
                return true;
            }
            else return false;
        }

        public int GetHashCode([DisallowNull] student obj)
        {
            return 0;
        }
    }
}
