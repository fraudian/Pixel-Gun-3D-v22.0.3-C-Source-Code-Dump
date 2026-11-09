using UnityEngine;

namespace Progress
{
    internal abstract class 三七业三丁丗一七丝 : 丙丕丈一一丝丑七丈
    {
        // Fields
        private System.Collections.Generic.Dictionary<int, object> 丑与丘丏与丛丄专丙;
        
        // Methods
        internal bool 丟不下下且业丛丄丏(int 下上丐丆丝丟丝丒不)
        {
            if(this.丑与丘丏与丛丄专丙 != null)
            {
                    return this.丑与丘丏与丛丄专丙.ContainsKey(key:  下上丐丆丝丟丝丒不);
            }
            
            return this.丑与丘丏与丛丄专丙.ContainsKey(key:  下上丐丆丝丟丝丒不);
        }
        internal object 专丏丕下上与与丟不(int 下上丐丆丝丟丝丒不)
        {
            if((this.丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不)) == false)
            {
                    return 0;
            }
            
            if(this.丑与丘丏与丛丄专丙 != null)
            {
                    return this.丑与丘丏与丛丄专丙.Item[下上丐丆丝丟丝丒不];
            }
            
            return this.丑与丘丏与丛丄专丙.Item[下上丐丆丝丟丝丒不];
        }
        internal void 丂上丆且丘三不丟业(int 下上丐丆丝丟丝丒不, object 丙业与丙丗丝不丈东)
        {
            this.丑与丘丏与丛丄专丙.set_Item(key:  下上丐丆丝丟丝丒不, value:  丙业与丙丗丝不丈东);
        }
        internal void 万万丌丄且三世上万(int 下下丏一丙不丘丌丞)
        {
            bool val_1 = this.丑与丘丏与丛丄专丙.Remove(key:  下下丏一丙不丘丌丞);
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            this.丑与丘丏与丛丄专丙.Clear();
            UnityEngine.Debug.LogError(message:  "********************* "("********************* ") + 一丐丗丁丞丆丅丟丄);
            System.Collections.Generic.Dictionary<System.Int32, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Object>();
            this.丑与丘丏与丛丄专丙 = null;
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            return (object)new System.Collections.Generic.Dictionary<System.Int32, System.Object>(dictionary:  this.丑与丘丏与丛丄专丙);
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丑与丘丏与丛丄专丙.Clear();
        }
        internal bool 且丏三丝下丒丄东下(int 下上丐丆丝丟丝丒不, out object 丙业与丙丗丝不丈东)
        {
            if(this.丑与丘丏与丛丄专丙 != null)
            {
                    return this.丑与丘丏与丛丄专丙.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  object val_1 = 丙业与丙丗丝不丈东);
            }
            
            return this.丑与丘丏与丛丄专丙.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  val_1);
        }
        public static int 丟东三世业不丄丛三(int 且丄东东丒丁丙丄丝, int 业不丈丝丗丙丛东丄)
        {
            return (int)System.String.CompareOrdinal(strA:  且丄东东丒丁丙丄丝.ToString(), strB:  业不丈丝丗丙丛东丄.ToString());
        }
        internal virtual System.Collections.Generic.List<int> 一丆丞丆上丘万丐不()
        {
            return 0;
        }
        protected 三七业三丁丗一七丝()
        {
            this.丑与丘丏与丛丄专丙 = new System.Collections.Generic.Dictionary<System.Int32, System.Object>();
        }
    
    }

}
