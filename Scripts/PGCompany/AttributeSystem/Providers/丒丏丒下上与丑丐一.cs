using UnityEngine;

namespace PGCompany.AttributeSystem.Providers
{
    internal abstract class 丒丏丒下上与丑丐一 : 且丁丞与不三丟丌丅, IDisposable
    {
        // Fields
        private System.Action<int> 丄丙上与专丂丅丘丄;
        protected PGCompany.AttributeSystem.三丘丌不丌丞不丟丟 世丈丝丏三且丙丝上;
        
        // Methods
        public void 丟丗与丅与七上丞丑(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄丙上与专丂丅丘丄, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丙上与专丂丅丘丄 != 1152921560606051520);
        
        }
        public void 三丗专上丏上丟三业(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄丙上与专丂丅丘丄, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丙上与专丂丅丘丄 != 1152921560606188096);
        
        }
        internal 丒丏丒下上与丑丐一(PGCompany.AttributeSystem.三丘丌不丌丞不丟丟 丆下丕丅丕一丝丁丛)
        {
            this.世丈丝丏三且丙丝上 = 丆下丕丅丕一丝丁丛;
            PGCompany.丗丝万丏世丛丈丏丕.丟丂丁专不世东丈丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AttributeSystem.Providers.丒丏丒下上与丑丐一::丟七丏一不东丘世丒()));
        }
        public bool 丟丐下丐三一丄丞丑<T>(int 丆下丕丅丕一丝丁丛)
        {
            return true;
        }
        public T 东且丛且业丗丑丙丗<T>(int 丆下丕丅丕一丝丁丛)
        {
            if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) != 0)
            {
                    return (int)null;
            }
            
            return (int)null;
        }
        public void 丂上丆且丘三不丟业<T>(int 丆下丕丅丕一丝丁丛, T 丙业与丙丗丝不丈东, PGCompany.AttributeSystem.丌丑业丈丅丟丙与且 专丒丌丆下丐丞丟丞)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        protected abstract int 丌专丁东丙上七且三(); // 0
        private void 丟七丏一不东丘世丒()
        {
            if(this.丄丙上与专丂丅丘丄 == null)
            {
                    return;
            }
            
            this.丄丙上与专丂丅丘丄.Invoke(obj:  this.世丈丝丏三且丙丝上);
        }
        public void Dispose()
        {
            PGCompany.丗丝万丏世丛丈丏丕.丝专丁丘丛丝丄业七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AttributeSystem.Providers.丒丏丒下上与丑丐一::丟七丏一不东丘世丒()));
        }
    
    }

}
