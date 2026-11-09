using UnityEngine;

namespace Org.BouncyCastle.Utilities.Collections
{
    public sealed class EnumerableProxy : IEnumerable
    {
        // Fields
        private readonly System.Collections.IEnumerable inner;
        
        // Methods
        public EnumerableProxy(System.Collections.IEnumerable inner)
        {
            if(inner != null)
            {
                    this.inner = inner;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "inner");
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.inner.GetEnumerator();
        }
    
    }

}
