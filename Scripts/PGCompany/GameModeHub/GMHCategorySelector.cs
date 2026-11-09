using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHCategorySelector : PGBehaviour
    {
        // Fields
        private System.Action 丐丌三丈东丘丝丑世;
        private System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三> 下丗丅丗丆丂上万与;
        private System.Collections.Generic.List<PGCompany.GameModeHub.GMHCategoryView> categoryViews;
        private System.Collections.Generic.List<PGCompany.GameModeHub.丟与丗不不上丆丞三> 上专上七下丆丅下丈;
        private PGCompany.GameModeHub.丟与丗不不上丆丞三 丙三东丞丈东丘丞丛;
        
        // Properties
        internal PGCompany.GameModeHub.丟与丗不不上丆丞三 专丛丞丛万且与丆丒 { get; }
        
        // Methods
        internal void 丌丐与丙东万上丛东(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丐丌三丈东丘丝丑世, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐丌三丈东丘丝丑世 != 1152921560481532472);
        
        }
        internal void 丄专丏丅丗丐丏万专(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丐丌三丈东丘丝丑世, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐丌三丈东丘丝丑世 != 1152921560481669048);
        
        }
        internal void 与丞与丗东丟丅丒万(System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.下丗丅丗丆丂上万与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下丗丅丗丆丂上万与 != 1152921560481805632);
        
        }
        internal void 丑丈丈不世丄丒三丑(System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.下丗丅丗丆丂上万与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下丗丅丗丆丂上万与 != 1152921560481942208);
        
        }
        internal PGCompany.GameModeHub.丟与丗不不上丆丞三 上丝丞丞丌且丝丛丟()
        {
            return (PGCompany.GameModeHub.丟与丗不不上丆丞三)this.丙三东丞丈东丘丞丛;
        }
        internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.GameModeHub.丟与丗不不上丆丞三> 万丞丛东丑丑丅一业, PGCompany.GameModeHub.丟与丗不不上丆丞三 下丌丝丅丐且且专丝)
        {
            this.上专上七下丆丅下丈 = 万丞丛东丑丑丅一业;
            if(下丌丝丅丐且且专丝 != null)
            {
                    this.丙三东丞丈东丘丞丛 = 下丌丝丅丐且且专丝;
                if(this.丐丌三丈东丘丝丑世 != null)
            {
                    this.丐丌三丈东丘丝丑世.Invoke();
            }
            
            }
            
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            var val_5 = 0;
            goto label_1;
            label_8:
            if(val_5 < this.上专上七下丆丅下丈.Count)
            {
                    PGCompany.GameModeHub.GMHCategoryView val_2 = this.categoryViews.Item[0];
                PGCompany.GameModeHub.丟与丗不不上丆丞三 val_3 = this.上专上七下丆丅下丈.Item[0];
            }
            
            val_5 = 1;
            label_1:
            if(val_5 < this.categoryViews.Count)
            {
                goto label_8;
            }
        
        }
        public void OnSelectCategory(PGCompany.GameModeHub.丟与丗不不上丆丞三 七丆丒与丗丌丄且丂)
        {
            this.丙三东丞丈东丘丞丛 = 七丆丒与丗丌丄且丂;
            if(this.丐丌三丈东丘丝丑世 == null)
            {
                    return;
            }
            
            this.丐丌三丈东丘丝丑世.Invoke();
        }
        public void OnLockedCategoryClick(PGCompany.GameModeHub.丟与丗不不上丆丞三 七丆丒与丗丌丄且丂)
        {
            if(this.下丗丅丗丆丂上万与 == null)
            {
                    return;
            }
            
            this.下丗丅丗丆丂上万与.Invoke(obj:  七丆丒与丗丌丄且丂);
        }
        internal void 丈丒丌丈业下三丄丒()
        {
            this.categoryViews = System.Linq.Enumerable.ToList<PGCompany.GameModeHub.GMHCategoryView>(source:  this.GetComponentsInChildren<PGCompany.GameModeHub.GMHCategoryView>());
        }
        public GMHCategorySelector()
        {
        
        }
    
    }

}
