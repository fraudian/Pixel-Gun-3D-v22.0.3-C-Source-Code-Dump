using UnityEngine;

namespace Org.BouncyCastle.Utilities.Collections
{
    public interface ISet : ICollection, IEnumerable
    {
        // Properties
        public abstract bool IsEmpty { get; }
        public abstract bool IsFixedSize { get; }
        public abstract bool IsReadOnly { get; }
        
        // Methods
        public abstract void Add(object o); // 0
        public abstract void AddAll(System.Collections.IEnumerable e); // 0
        public abstract void Clear(); // 0
        public abstract bool Contains(object o); // 0
        public abstract bool get_IsEmpty(); // 0
        public abstract bool get_IsFixedSize(); // 0
        public abstract bool get_IsReadOnly(); // 0
        public abstract void Remove(object o); // 0
        public abstract void RemoveAll(System.Collections.IEnumerable e); // 0
    
    }

}
