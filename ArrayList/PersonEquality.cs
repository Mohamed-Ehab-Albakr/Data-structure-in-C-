using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ArrayList
{
    internal class PersonEquality : IEqualityComparer<person>
    {
        public bool Equals(person? x, person? y)
        {
            if (x.id == y.id
                && x.name == y.name
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public int GetHashCode([DisallowNull] person obj)
        {
            throw new NotImplementedException();
        }
    }
}
