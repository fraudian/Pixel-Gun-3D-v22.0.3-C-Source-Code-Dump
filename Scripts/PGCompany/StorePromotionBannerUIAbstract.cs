using UnityEngine;

namespace PGCompany
{
    internal abstract class StorePromotionBannerUIAbstract : PGBehaviour
    {
        // Fields
        private System.Action<PGCompany.StorePromotionBannerUIAbstract> 丝上丂一不专丂丄不;
        private PGCompany.东丑丆丗丏丐丟下丄 <丒丄丙世且丑丑丄不>k__BackingField;
        
        // Properties
        internal PGCompany.东丑丆丗丏丐丟下丄 丒丁丝与且丂且丐丝 { get; set; }
        
        // Methods
        internal void 东丑业丒且业丌丝丙(System.Action<PGCompany.StorePromotionBannerUIAbstract> 丙业与丙丗丝不丈东)
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
            while(this.丝上丂一不专丂丄不 != 1152921555989450536);
        
        }
        internal void 丝七一不与不丙丕丈(System.Action<PGCompany.StorePromotionBannerUIAbstract> 丙业与丙丗丝不丈东)
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
            while(this.丝上丂一不专丂丄不 != 1152921555989587112);
        
        }
        internal PGCompany.东丑丆丗丏丐丟下丄 与丞丆丑东东丟丆丌()
        {
            return (PGCompany.东丑丆丗丏丐丟下丄)this.<丒丄丙世且丑丑丄不>k__BackingField;
        }
        private void 丛丐丟万丐世万丏丌(PGCompany.东丑丆丗丏丐丟下丄 丙业与丙丗丝不丈东)
        {
            this.<丒丄丙世且丑丑丄不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            this.<丒丄丙世且丑丑丄不>k__BackingField = 且丘丏丁丑与丙与丁;
            goto typeof(PGCompany.StorePromotionBannerUIAbstract).__il2cppRuntimeField_168;
        }
        protected abstract void 丝一丅丆三东丂丞七(); // 0
        protected virtual void 丞丁丅七丏丐东丝东()
        {
        
        }
        protected virtual void 丘专上丈世丟上专丒()
        {
        
        }
        protected virtual void OnEnable()
        {
        
        }
        protected virtual void OnDisable()
        {
        
        }
        public void U_Hide()
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
        public void U_Refuse()
        {
            this.丆世与丑丆丅丐万且();
        }
        public void U_Purchase()
        {
            if((this.<丒丄丙世且丑丑丄不>k__BackingField) == null)
            {
                    return;
            }
            
            this.<丒丄丙世且丑丑丄不>k__BackingField.丏丝丘七丕与世丅丆();
            this.丆世与丑丆丅丐万且();
        }
        protected StorePromotionBannerUIAbstract()
        {
        
        }
    
    }

}
