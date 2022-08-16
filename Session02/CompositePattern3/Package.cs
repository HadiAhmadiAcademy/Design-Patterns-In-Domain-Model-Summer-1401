using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern3
{
    public abstract class Product       //Component
    {
         public abstract long Price();
    }

    public class Package : Product      //Composite
    {
        private readonly List<Product> _parts;
        public Package(List<Product> parts)
        {
            _parts = parts;
        }

        public override long Price()
        {
            return _parts.Sum(a => a.Price());
        }
    }
    public class SpecificProduct : Product
    {
        public override long Price()
        {
            return 0;
        }
    }

    public class ConfigurableProduct : Product
    {
        public override long Price()
        {
            return 0;
        }
    }
}
