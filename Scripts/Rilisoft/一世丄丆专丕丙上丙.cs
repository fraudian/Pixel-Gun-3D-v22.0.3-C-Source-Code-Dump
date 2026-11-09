using UnityEngine;

namespace Rilisoft
{
    internal abstract class 一世丄丆专丕丙上丙 : 丆丑丙丈世万丛丈丝
    {
        // Fields
        private readonly Rilisoft.丆丑丙丈世万丛丈丝 丄丁业丝不七与丝丈;
        
        // Properties
        public override System.Collections.Generic.ICollection<string> 丕世七丂丗专丝上丕 { get; }
        public override System.Collections.Generic.ICollection<string> 丂丘且上丕三东丕丒 { get; }
        public override int 丒专下与丑丁丆丟业 { get; }
        public override bool 丅丅丌一丕七业世丌 { get; }
        protected Rilisoft.丆丑丙丈世万丛丈丝 丑东丄专丗丕万下一 { get; }
        
        // Methods
        protected 一世丄丆专丕丙上丙(Rilisoft.丆丑丙丈世万丛丈丝 丆丞且三丟东丕东丂)
        {
            this.丄丁业丝不七与丝丈 = 丆丞且三丟东丕东丂;
        }
        public bool 丄丄丛东丌丙丗丌丛(string 下上丐丆丝丟丝丒不)
        {
            if(下上丐丆丝丟丝丒不 != null)
            {
                
            }
            else
            {
                    System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "key");
            }
        
        }
        protected abstract void 丞东世三丂丁丒三东(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东); // 0
        protected abstract bool 业不丗上万丞专上丅(string 下上丐丆丝丟丝丒不); // 0
        protected abstract bool 丑丟丘丆丌丄且上上(string 下上丐丆丝丟丝丒不); // 0
        protected override void 丕丐丐三丒丏丟丞一(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            goto typeof(Rilisoft.一世丄丆专丕丙上丙).__il2cppRuntimeField_338;
        }
        protected override bool 丟丅丆上丅专丑专丅(string 下上丐丆丝丟丝丒不)
        {
            if(this.丄丁业丝不七与丝丈 != null)
            {
                    return this.丄丁业丝不七与丝丈.ContainsKey(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            }
            
            return this.丄丁业丝不七与丝丈.ContainsKey(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
        }
        protected override void 一丕丆丐上一与丐丗(System.Collections.Generic.KeyValuePair<string, string>[] 三丒丂世丕丟东丆丏, int 专丞丁世丈下且丁丑)
        {
            this.丄丁业丝不七与丝丈.CopyTo(三丒丂世丕丟东丆丏:  三丒丂世丕丟东丆丏, 专丞丁世丈下且丁丑:  专丞丁世丈下且丁丑);
        }
        protected override bool 丕丈丏丟东丕下下丁(string 下上丐丆丝丟丝丒不)
        {
            goto typeof(Rilisoft.一世丄丆专丕丙上丙).__il2cppRuntimeField_348;
        }
        protected override bool 且丒丑丆丛丗丂丈下(string 下上丐丆丝丟丝丒不, out string 丙业与丙丗丝不丈东)
        {
            if(this.丄丁业丝不七与丝丈 != null)
            {
                    return this.丄丁业丝不七与丝丈.TryGetValue(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东: out  string val_1 = 丙业与丙丗丝不丈东);
            }
            
            return this.丄丁业丝不七与丝丈.TryGetValue(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东: out  val_1);
        }
        public override void 丂且不业丂专丛丆东()
        {
            if(this.丄丁业丝不七与丝丈 == null)
            {
                
            }
        
        }
        public override System.Collections.Generic.ICollection<string> get_Keys()
        {
            if(this.丄丁业丝不七与丝丈 == null)
            {
                
            }
        
        }
        public override System.Collections.Generic.ICollection<string> get_Values()
        {
            if(this.丄丁业丝不七与丝丈 == null)
            {
                
            }
        
        }
        public override void Clear()
        {
            if(this.丄丁业丝不七与丝丈 == null)
            {
                
            }
        
        }
        public override int get_Count()
        {
            if(this.丄丁业丝不七与丝丈 == null)
            {
                
            }
        
        }
        public override bool get_IsReadOnly()
        {
            if(this.丄丁业丝不七与丝丈 == null)
            {
                
            }
        
        }
        public override System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator()
        {
            if(this.丄丁业丝不七与丝丈 == null)
            {
                
            }
        
        }
        protected Rilisoft.丆丑丙丈世万丛丈丝 丝且丏万丒丏世丏丂()
        {
            return (Rilisoft.丆丑丙丈世万丛丈丝)this.丄丁业丝不七与丝丈;
        }
    
    }

}
