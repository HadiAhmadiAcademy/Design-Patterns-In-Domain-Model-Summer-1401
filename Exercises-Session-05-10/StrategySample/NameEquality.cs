using System;
using System.Collections.Generic;

namespace StrategySample
{
    public class NameCaseSensitiveEquality : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            return x.Name.Equals(y.Name, StringComparison.Ordinal);
        }

        public int GetHashCode(Customer obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    public class NameCaseInSensitiveEquality : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            return x.Name.Equals(y.Name, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode(Customer obj)
        {
            return obj.Name.ToLower().GetHashCode();
        }
    }

    public class AgeEquality : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            return x.Age == y.Age;
        }

        public int GetHashCode(Customer obj)
        {
            return obj.Age.GetHashCode();
        }
    }
}