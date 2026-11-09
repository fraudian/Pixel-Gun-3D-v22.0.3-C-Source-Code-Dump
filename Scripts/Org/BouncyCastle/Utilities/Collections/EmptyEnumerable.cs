using UnityEngine;

namespace Org.BouncyCastle.Utilities.Collections
{
    public sealed class EmptyEnumerable : IEnumerable
    {
        // Fields
        public static readonly System.Collections.IEnumerable Instance;
        
        // Methods
        private EmptyEnumerable()
        {
        
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            null = null;
            return (System.Collections.IEnumerator)Org.BouncyCastle.Utilities.Collections.EmptyEnumerator.Instance;
        }
        private static EmptyEnumerable()
        {
            Org.BouncyCastle.Utilities.Collections.EmptyEnumerable.Instance = new Org.BouncyCastle.Utilities.Collections.EmptyEnumerable();
        }
    
    }

}
