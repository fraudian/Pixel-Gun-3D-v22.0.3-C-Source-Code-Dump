using UnityEngine;

namespace PGCompany.TrophyRoad
{
    internal class RewardView : PGBehaviour
    {
        // Fields
        private System.Action<PGCompany.TrophyRoad.RewardView> 丝丈丆世且三与丝东;
        private UnityEngine.GameObject _holder;
        private UnityEngine.GameObject _lockContainer;
        private UnityEngine.GameObject _issuedContainer;
        private UnityEngine.GameObject _activeContainer;
        private PGCompany.InventoryItemView _itemView;
        internal PGCompany.TrophyRoad.丆丅且丞丝丗与且与 丆丅且丞丝丗与且与;
        
        // Methods
        internal void 且世万七丈丄丁丗丝(System.Action<PGCompany.TrophyRoad.RewardView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丝丈丆世且三与丝东, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝丈丆世且三与丝东 != 1152921559539327480);
        
        }
        internal void 丞丕丛丄丕世丂丟一(System.Action<PGCompany.TrophyRoad.RewardView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丝丈丆世且三与丝东, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝丈丆世且三与丝东 != 1152921559539464056);
        
        }
        public void Setup(PGCompany.TrophyRoad.丆丅且丞丝丗与且与 三丏丑不业丏不丂丈)
        {
            var val_6;
            var val_7;
            var val_8;
            this.丆丅且丞丝丗与且与 = 三丏丑不业丏不丂丈;
            if(三丏丑不业丏不丂丈 != null)
            {
                    var val_1 = (三丏丑不业丏不丂丈.三东丏不丗世丅丌丄 != 0) ? 1 : 0;
            }
            else
            {
                    val_6 = 0;
            }
            
            if((val_6 & 1) == 0)
            {
                goto label_3;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
            if(this.丆丅且丞丝丗与且与.业且万丝丛东丂丄丑 == false)
            {
                goto label_7;
            }
            
            bool val_4 = this.丆丅且丞丝丗与且与.丏世丄丗丅丂业丅丌;
            val_4 = val_4 ^ 1;
            val_7 = val_4 & 255;
            goto label_9;
            label_3:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
            return;
            label_7:
            val_7 = 0;
            label_9:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  (val_7 != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._issuedContainer, 丏业丟一东丂东丘丛:  this.丆丅且丞丝丗与且与.丏世丄丗丅丂业丅丌);
            if(this.丆丅且丞丝丗与且与.业且万丝丛东丂丄丑 != false)
            {
                    val_8 = 0;
            }
            else
            {
                    bool val_5 = this.丆丅且丞丝丗与且与.丏世丄丗丅丂业丅丌;
                val_5 = val_5 ^ 1;
                val_8 = val_5 & 255;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._activeContainer, 丏业丟一东丂东丘丛:  (val_8 == true) ? 1 : 0);
            this._itemView.Setup(丈丄不七三万丄丁不:  三丏丑不业丏不丂丈.三东丏不丗世丅丌丄);
        }
        public void U_Click()
        {
            if(this.丝丈丆世且三与丝东 == null)
            {
                    return;
            }
            
            this.丝丈丆世且三与丝东.Invoke(obj:  this);
        }
        public RewardView()
        {
        
        }
    
    }

}
