using UnityEngine;

namespace PGCompany
{
    internal abstract class 丌与世世丆丄丞丌世 : IDisposable
    {
        // Fields
        private System.Action<PGCompany.专丟专世丅丂丁且专, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, object> 万丗丛丌与丒丄一世;
        internal PGCompany.东丑丆丗丏丐丟下丄 丒丁丝与且丂且丐丝;
        internal PGCompany.StorePromotionPurchaseSettings 丅万丂世不丘丕下一;
        
        // Methods
        internal void 丘下丟一丌上业丘万(System.Action<PGCompany.专丟专世丅丂丁且专, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, object> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.万丗丛丌与丒丄一世, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万丗丛丌与丒丄一世 != 1152921555938056304);
        
        }
        internal void 三七一不丆丒不三丛(System.Action<PGCompany.专丟专世丅丂丁且专, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, object> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.万丗丛丌与丒丄一世, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万丗丛丌与丒丄一世 != 1152921555938192880);
        
        }
        internal abstract void 东丞丐业丂丞不丕丈<T>(T 丞万丕丏东与丑下丕); // 0
        public abstract void Dispose(); // 0
        protected void 丆丌丄业丙丘丅七世(PGCompany.专丟专世丅丂丁且专 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丛丐与丌丑专丑七丄, object 一丐丗丁丞丆丅丟丄)
        {
            if(this.万丗丛丌与丒丄一世 == null)
            {
                    return;
            }
            
            this.万丗丛丌与丒丄一世.Invoke(arg1:  且丘丏丁丑与丙与丁, arg2:  丛丐与丌丑专丑七丄, arg3:  一丐丗丁丞丆丅丟丄);
        }
        protected virtual void 丘丕丑上且丞世七三(PGCompany.专丟专世丅丂丁且专 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丛丐与丌丑专丑七丄, object 一丐丗丁丞丆丅丟丄)
        {
        
        }
        protected 丌与世世丆丄丞丌世()
        {
        
        }
    
    }

}
