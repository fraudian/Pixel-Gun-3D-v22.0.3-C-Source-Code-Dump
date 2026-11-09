using UnityEngine;

namespace Org.BouncyCastle.Utilities.Collections
{
    public sealed class EmptyEnumerator : IEnumerator
    {
        // Fields
        public static readonly System.Collections.IEnumerator Instance;
        
        // Properties
        public object Current { get; }
        
        // Methods
        private EmptyEnumerator()
        {
        
        }
        public bool MoveNext()
        {
            return false;
        }
        public void Reset()
        {
        
        }
        public object get_Current()
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "No elements");
        }
        private static EmptyEnumerator()
        {
            Org.BouncyCastle.Utilities.Collections.EmptyEnumerator.Instance = new Org.BouncyCastle.Utilities.Collections.EmptyEnumerator();
        }
    
    }

}
