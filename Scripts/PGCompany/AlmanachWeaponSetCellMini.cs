using UnityEngine;

namespace PGCompany
{
    internal class AlmanachWeaponSetCellMini : MonoBehaviour
    {
        // Fields
        public UIWidget mainWidget;
        public System.Collections.Generic.List<UIRect> weaponSetRectsToUpdate;
        private PGCompany.InventoryItemView _itemView;
        private System.Collections.Generic.List<UILabel> number;
        private UITextureMasked texture;
        private UIBasicSprite silhouetteTexture;
        private UnityEngine.GameObject silhouetteGO;
        private UnityEngine.GameObject purchasedGO;
        private UnityEngine.GameObject lockedGO;
        private PGCompany.丟丝东丈丐丙三下丛 丅业丗丕丙丝丘丒丈;
        
        // Methods
        public void UpdateWeaponSetRects()
        {
            List.Enumerator<T> val_1 = this.weaponSetRectsToUpdate.GetEnumerator();
            label_7:
            if((2040437896 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            val_2.ResetAndUpdateAnchors();
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)
        {
            UnityEngine.GameObject val_18;
            PGCompany.InventoryItemView val_19;
            PGCompany.三东丏不丗世丅丌丄 val_20;
            var val_21;
            val_18 = this;
            val_19 = this._itemView;
            this.丅业丗丕丙丝丘丒丈 = 一业一丕丅下业世与;
            val_19.Setup(与且专丈不万东一万:  一业一丕丅下业世与);
            if(一业一丕丅下业世与 == null)
            {
                goto label_2;
            }
            
            val_20 = 一业一丕丅下业世与.丑丐丙丄丅世世丑丒();
            val_19 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_20, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if((PGCompany.丌东丛不丅三下业上.不与与丈丝丌丑丒丞(一业一丕丅下业世与:  一业一丕丅下业世与)) == 0)
            {
                goto label_6;
            }
            
            val_20 = 0;
            if(一业一丕丅下业世与.丄丕三丄专丆丛丙专() == false)
            {
                goto label_7;
            }
            
            label_6:
            val_21 = (~val_19) & 1;
            goto label_8;
            label_2:
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  0);
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.silhouetteTexture, 与万丆丛丒万丝丙丑:  0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.number, 丕丗丘丑丛与丑业丒:  "");
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.purchasedGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.silhouetteGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedGO, 丏业丟一东丂东丘丛:  false);
            return;
            label_7:
            val_21 = 0;
            label_8:
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  一业一丕丅下业世与);
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.silhouetteTexture, 与万丆丛丒万丝丙丑:  一业一丕丅下业世与.丗丁丆丝丐丆丛与丕());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.number, 丕丗丘丑丛与丑业丒:  "#" + 一业一丕丅下业世与.丏万东丐丛不丛不世().ToString());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.silhouetteGO, 丏业丟一东丂东丘丛:  (val_19 | ((val_21 != 0) ? 1 : 0)) ^ 1);
            val_18 = this.purchasedGO;
            val_18.SetActive(value:  val_19 & (~val_21));
        }
        public AlmanachWeaponSetCellMini()
        {
        
        }
    
    }

}
