using UnityEngine;

namespace Rilisoft
{
    internal abstract class 丆丑丙丈世万丛丈丝 : IDictionary<string, string>, ICollection<System.Collections.Generic.KeyValuePair<string, string>>, IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, IEnumerable
    {
        // Properties
        public abstract System.Collections.Generic.ICollection<string> 丕世七丂丗专丝上丕 { get; }
        public abstract System.Collections.Generic.ICollection<string> 丂丘且上丕三东丕丒 { get; }
        public string 不下下丞三一丘丗丐 { get; set; }
        public abstract int 丒专下与丑丁丆丟业 { get; }
        public abstract bool 丅丅丌一丕七业世丌 { get; }
        
        // Methods
        protected abstract void 丕丐丐三丒丏丟丞一(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东); // 0
        protected abstract bool 丟丅丆上丅专丑专丅(string 下上丐丆丝丟丝丒不); // 0
        protected abstract void 一丕丆丐上一与丐丗(System.Collections.Generic.KeyValuePair<string, string>[] 三丒丂世丕丟东丆丏, int 专丞丁世丈下且丁丑); // 0
        protected abstract bool 丕丈丏丟东丕下下丁(string 下上丐丆丝丟丝丒不); // 0
        protected abstract bool 且丒丑丆丛丗丂丈下(string 下上丐丆丝丟丝丒不, out string 丙业与丙丗丝不丈东); // 0
        public abstract void 丂且不业丂专丛丆东(); // 0
        public void Add(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            if(下上丐丆丝丟丝丒不 != null)
            {
                
            }
            else
            {
                    System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "key");
            }
        
        }
        public bool ContainsKey(string 下上丐丆丝丟丝丒不)
        {
            if(下上丐丆丝丟丝丒不 != null)
            {
                
            }
            else
            {
                    System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "key");
            }
        
        }
        public abstract System.Collections.Generic.ICollection<string> get_Keys(); // 0
        public bool Remove(string 下上丐丆丝丟丝丒不)
        {
            if(下上丐丆丝丟丝丒不 != null)
            {
                
            }
            else
            {
                    System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "key");
            }
        
        }
        public bool TryGetValue(string 下上丐丆丝丟丝丒不, out string 丙业与丙丗丝不丈东)
        {
            if(下上丐丆丝丟丝丒不 != null)
            {
                
            }
            else
            {
                    System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "key");
            }
        
        }
        public abstract System.Collections.Generic.ICollection<string> get_Values(); // 0
        public string get_Item(string 下上丐丆丝丟丝丒不)
        {
            string val_1 = 0;
            if((this.TryGetValue(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东: out  val_1)) != false)
            {
                    return val_1;
            }
            
            System.Collections.Generic.KeyNotFoundException val_3 = new System.Collections.Generic.KeyNotFoundException();
        }
        public void set_Item(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            if(下上丐丆丝丟丝丒不 != null)
            {
                
            }
            else
            {
                    System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "key");
            }
        
        }
        public void Add(System.Collections.Generic.KeyValuePair<string, string> 下丅丙一丂丗丅丝七)
        {
            string val_1 = 下丅丙一丂丗丅丝七.Value.丐丏七丌丕丗业且上();
        }
        public abstract void Clear(); // 0
        public bool Contains(System.Collections.Generic.KeyValuePair<string, string> 下丅丙一丂丗丅丝七)
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(下丅丙一丂丗丅丝七.Value.丐丏七丌丕丗业且上() != null)
            {
                    string val_2 = 下丅丙一丂丗丅丝七.Value.丐丏七丌丕丗业且上();
                if((val_5 & 1) != 0)
            {
                    val_5 = System.Collections.Generic.EqualityComparer<System.String>.Default;
                val_6 = val_5;
            }
            else
            {
                    val_6 = 0;
            }
            
                val_6 = val_6 & 1;
                return (bool)val_6;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "Key is null.", paramName:  "item");
        }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, string>[] 三丒丂世丕丟东丆丏, int 专丞丁世丈下且丁丑)
        {
            var val_4;
            string val_6;
            if(三丒丂世丕丟东丆丏 == null)
            {
                goto label_1;
            }
            
            if((专丞丁世丈下且丁丑 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            if(三丒丂世丕丟东丆丏.Length < 专丞丁世丈下且丁丑)
            {
                goto label_3;
            }
            
            int val_4 = 三丒丂世丕丟东丆丏.Length;
            val_4 = val_4 - 专丞丁世丈下且丁丑;
            if(val_4 < this)
            {
                goto label_4;
            }
            
            goto typeof(Rilisoft.丆丑丙丈世万丛丈丝).__il2cppRuntimeField_298;
            label_1:
            System.ArgumentNullException val_1 = null;
            val_4 = val_1;
            val_1 = new System.ArgumentNullException(paramName:  "array");
            goto label_6;
            label_2:
            System.ArgumentOutOfRangeException val_2 = null;
            val_4 = val_2;
            val_2 = new System.ArgumentOutOfRangeException(paramName:  "arrayIndex");
            goto label_6;
            label_3:
            val_6 = "Index larger than largest valid index of array.";
            goto label_7;
            label_4:
            System.ArgumentException val_3 = null;
            val_6 = "Destination array cannot hold the requested elements!";
            label_7:
            val_4 = val_3;
            val_3 = new System.ArgumentException(message:  val_6);
            label_6:
        }
        public abstract int get_Count(); // 0
        public abstract bool get_IsReadOnly(); // 0
        public bool Remove(System.Collections.Generic.KeyValuePair<string, string> 下丅丙一丂丗丅丝七)
        {
            var val_4;
            if((this.Contains(下丅丙一丂丗丅丝七:  new System.Collections.Generic.KeyValuePair<System.String, System.String>() {Value = 下丅丙一丂丗丅丝七.Value})) != false)
            {
                    val_4 = this;
                bool val_3 = this.Remove(下上丐丆丝丟丝丒不:  下丅丙一丂丗丅丝七.Value.丐丏七丌丕丗业且上());
            }
            else
            {
                    val_4 = 0;
            }
            
            val_4 = val_4 & 1;
            return (bool)val_4;
        }
        public abstract System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator(); // 0
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            goto typeof(Rilisoft.丆丑丙丈世万丛丈丝).__il2cppRuntimeField_328;
        }
        protected 丆丑丙丈世万丛丈丝()
        {
        
        }
    
    }

}
