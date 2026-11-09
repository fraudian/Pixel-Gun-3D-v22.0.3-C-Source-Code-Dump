using UnityEngine;

namespace Org.BouncyCastle.Utilities.Collections
{
    public class HashSet : ISet, ICollection, IEnumerable
    {
        // Fields
        private readonly System.Collections.IDictionary impl;
        
        // Properties
        public virtual int Count { get; }
        public virtual bool IsEmpty { get; }
        public virtual bool IsFixedSize { get; }
        public virtual bool IsReadOnly { get; }
        public virtual bool IsSynchronized { get; }
        public virtual object SyncRoot { get; }
        
        // Methods
        public HashSet()
        {
            this.impl = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
        }
        public HashSet(System.Collections.IEnumerable s)
        {
            var val_15;
            var val_16;
            this.impl = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.IEnumerator val_3 = s.GetEnumerator();
            label_19:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            object val_7 = val_3.Current;
            goto label_19;
            label_13:
            val_15 = 0;
            val_16 = 0;
            if(val_3 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_3.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_16 = ???;
            val_15 = ???;
        }
        public virtual void Add(object o)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.impl.set_Item(key:  o, value:  0);
        }
        public virtual void AddAll(System.Collections.IEnumerable e)
        {
            var val_14;
            var val_15;
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.IEnumerator val_2 = e.GetEnumerator();
            label_17:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            object val_6 = val_2.Current;
            goto label_17;
            label_11:
            val_14 = 0;
            val_15 = 0;
            if(val_2 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_2.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_15 = ???;
            val_14 = ???;
        }
        public virtual void Clear()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.impl.Clear();
        }
        public virtual bool Contains(object o)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.impl.Contains(key:  o);
        }
        public virtual void CopyTo(System.Array array, int index)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.impl.Keys.CopyTo(array:  array, index:  index);
        }
        public virtual int get_Count()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.impl.Count;
        }
        public virtual System.Collections.IEnumerator GetEnumerator()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            var val_5 = 0;
            val_5 = val_5 + 1;
            return this.impl.Keys.GetEnumerator();
        }
        public virtual bool get_IsEmpty()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (bool)(this.impl.Count == 0) ? 1 : 0;
        }
        public virtual bool get_IsFixedSize()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.impl.IsFixedSize;
        }
        public virtual bool get_IsReadOnly()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.impl.IsReadOnly;
        }
        public virtual bool get_IsSynchronized()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.impl.IsSynchronized;
        }
        public virtual void Remove(object o)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.impl.Remove(key:  o);
        }
        public virtual void RemoveAll(System.Collections.IEnumerable e)
        {
            var val_14;
            var val_15;
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.IEnumerator val_2 = e.GetEnumerator();
            label_17:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            object val_6 = val_2.Current;
            goto label_17;
            label_11:
            val_14 = 0;
            val_15 = 0;
            if(val_2 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_2.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_15 = ???;
            val_14 = ???;
        }
        public virtual object get_SyncRoot()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.impl.SyncRoot;
        }
    
    }

}
