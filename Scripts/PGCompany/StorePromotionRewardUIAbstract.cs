using UnityEngine;

namespace PGCompany
{
    internal abstract class StorePromotionRewardUIAbstract : PGBehaviour
    {
        // Fields
        private System.Action<PGCompany.StorePromotionRewardUIAbstract> 丝上丂一不专丂丄不;
        private PGCompany.东丑丆丗丏丐丟下丄 <丒丄丙世且丑丑丄不>k__BackingField;
        private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> <下下下世丕丁世一丐>k__BackingField;
        
        // Properties
        internal PGCompany.东丑丆丗丏丐丟下丄 丒丁丝与且丂且丐丝 { get; set; }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 下丐丐丁与丂下世七 { get; set; }
        
        // Methods
        internal void 东丑业丒且业丌丝丙(System.Action<PGCompany.StorePromotionRewardUIAbstract> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丝上丂一不专丂丄不, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝上丂一不专丂丄不 != 1152921555998770808);
        
        }
        internal void 丝七一不与不丙丕丈(System.Action<PGCompany.StorePromotionRewardUIAbstract> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丝上丂一不专丂丄不, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝上丂一不专丂丄不 != 1152921555998907384);
        
        }
        internal PGCompany.东丑丆丗丏丐丟下丄 与丞丆丑东东丟丆丌()
        {
            return (PGCompany.东丑丆丗丏丐丟下丄)this.<丒丄丙世且丑丑丄不>k__BackingField;
        }
        private void 丛丐丟万丐世万丏丌(PGCompany.东丑丆丗丏丐丟下丄 丙业与丙丗丝不丈东)
        {
            this.<丒丄丙世且丑丑丄不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丏丁东上与东丙丕()
        {
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)this.<下下下世丕丁世一丐>k__BackingField;
        }
        private void 万万丐东上丙丁万东(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            this.<下下下世丕丁世一丐>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected virtual void OnEnable()
        {
        
        }
        protected virtual void OnDisable()
        {
        
        }
        internal virtual void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, object 一丐丗丁丞丆丅丟丄)
        {
            this.<丒丄丙世且丑丑丄不>k__BackingField = 且丘丏丁丑与丙与丁;
            this.<下下下世丕丁世一丐>k__BackingField = 上业丟世三与七七三;
            goto typeof(PGCompany.StorePromotionRewardUIAbstract).__il2cppRuntimeField_198;
        }
        protected void 上与丟丗一上丛丌专(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三)
        {
            this.<下下下世丕丁世一丐>k__BackingField = 上业丟世三与七七三;
        }
        protected abstract void 丝一丅丆三东丂丞七(); // 0
        public virtual void U_Hide()
        {
            this.丆世与丑丆丅丐万且();
        }
        internal void 丆世与丑丆丅丐万且()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
            if(this.丝上丂一不专丂丄不 == null)
            {
                    return;
            }
            
            this.丝上丂一不专丂丄不.Invoke(obj:  this);
        }
        protected StorePromotionRewardUIAbstract()
        {
        
        }
    
    }

}
