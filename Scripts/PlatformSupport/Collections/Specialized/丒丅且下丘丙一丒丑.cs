using UnityEngine;

namespace PlatformSupport.Collections.Specialized
{
    internal sealed class 丒丅且下丘丙一丒丑 : IList, ICollection, IEnumerable
    {
        // Fields
        private readonly System.Collections.IList 丄丅不七丝三不丒东;
        
        // Properties
        public int 丒专下与丑丁丆丟业 { get; }
        public bool 丅丅丌一丕七业世丌 { get; }
        public bool 丛且万丗下上丐业丂 { get; }
        public bool 丛万丛丂丌万一丟万 { get; }
        public object 不下下丞三一丘丗丐 { get; set; }
        public object 七丆丑丆丙丛丒丘世 { get; }
        
        // Methods
        internal 丒丅且下丘丙一丒丑(System.Collections.IList 丝丘丑业丛万丞丌丝)
        {
            this.丄丅不七丝三不丒东 = 丝丘丑业丛万丞丌丝;
        }
        public int get_Count()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丄丅不七丝三不丒东.Count;
        }
        public bool get_IsReadOnly()
        {
            return true;
        }
        public bool get_IsFixedSize()
        {
            return true;
        }
        public bool get_IsSynchronized()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丄丅不七丝三不丒东.IsSynchronized;
        }
        public object get_Item(int 丞世不丒下上上丝丑)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丄丅不七丝三不丒东.Item[丞世不丒下上上丝丑];
        }
        public void set_Item(int 丞世不丒下上上丝丑, object 丙业与丙丗丝不丈东)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public object get_SyncRoot()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丄丅不七丝三不丒东.SyncRoot;
        }
        public int Add(object 丙业与丙丗丝不丈东)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public void Clear()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public bool Contains(object 丙业与丙丗丝不丈东)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丄丅不七丝三不丒东.Contains(value:  丙业与丙丗丝不丈东);
        }
        public void CopyTo(System.Array 三丒丂世丕丟东丆丏, int 丞世不丒下上上丝丑)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丄丅不七丝三不丒东.CopyTo(array:  三丒丂世丕丟东丆丏, index:  丞世不丒下上上丝丑);
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丄丅不七丝三不丒东.GetEnumerator();
        }
        public int IndexOf(object 丙业与丙丗丝不丈东)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丄丅不七丝三不丒东.IndexOf(value:  丙业与丙丗丝不丈东);
        }
        public void Insert(int 丞世不丒下上上丝丑, object 丙业与丙丗丝不丈东)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public void Remove(object 丙业与丙丗丝不丈东)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public void RemoveAt(int 丞世不丒下上上丝丑)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
    
    }

}
