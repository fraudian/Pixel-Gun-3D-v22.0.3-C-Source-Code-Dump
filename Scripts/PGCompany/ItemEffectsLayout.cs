using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemEffectsLayout : PGBehaviour
    {
        // Fields
        private UITable _table;
        private PGCompany.ItemEffectUI _effectUI;
        private System.Collections.Generic.List<PGCompany.ItemEffectUI> 东丗七万丏丒丟丛业;
        
        // Methods
        private void Awake()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._effectUI, 丏业丟一东丂东丘丛:  false);
        }
        internal void 七丗丏丌丌丛业世一(System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> 丌丞丌丌丈丁丏丅丟)
        {
            var val_9;
            UnityEngine.Transform val_11;
            var val_12;
            val_9 = null;
            val_9 = null;
            if((ItemEffectsLayout.<>c.<>9__4_0) == null)
            {
                goto label_3;
            }
            
            label_23:
            this.东丗七万丏丒丟丛业.ForEach(action:  ItemEffectsLayout.<>c.<>9__4_0);
            val_11 = this._table.transform;
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.ItemEffectUI>(专下丐丒丈万丗丟丝:  this.东丗七万丏丒丟丛业, 专丑业丁丗丏丌不丛:  this._effectUI.gameObject, 丈东丘丏与丌东东下:  val_11, 与业丄丂丂丆下上丞:  丌丞丌丌丈丁丏丅丟.Count, 丏东下下一丗专下丏:  0);
            val_12 = 0;
            goto label_10;
            label_18:
            val_11 = 丌丞丌丌丈丁丏丅丟.Item[0];
            this.东丗七万丏丒丟丛业.Item[0].世与东丗世三丞丞不(丏不丂丆且三丞丆丏:  val_11);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.东丗七万丏丒丟丛业.Item[0], 丏业丟一东丂东丘丛:  true);
            val_12 = 1;
            label_10:
            if(val_12 < 丌丞丌丌丈丁丏丅丟.Count)
            {
                goto label_18;
            }
            
            this._table.repositionNow = true;
            return;
            label_3:
            ItemEffectsLayout.<>c.<>9__4_0 = new System.Action<PGCompany.ItemEffectUI>(object:  ItemEffectsLayout.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ItemEffectsLayout.<>c::丕丌东丈丟三丙丅丄(PGCompany.ItemEffectUI 三丟东丕丄丄下下丑));
            if(this.东丗七万丏丒丟丛业 != null)
            {
                goto label_23;
            }
            
            goto label_23;
        }
        internal void 七丗丏丌丌丛业世一(string 丕丗丘丑丛与丑业丒)
        {
            var val_7 = null;
            if((ItemEffectsLayout.<>c.<>9__5_0) == null)
            {
                goto label_3;
            }
            
            label_18:
            this.东丗七万丏丒丟丛业.ForEach(action:  ItemEffectsLayout.<>c.<>9__5_0);
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.ItemEffectUI>(专下丐丒丈万丗丟丝:  this.东丗七万丏丒丟丛业, 专丑业丁丗丏丌不丛:  this._effectUI.gameObject, 丈东丘丏与丌东东下:  this._table.transform, 与业丄丂丂丆下上丞:  1, 丏东下下一丗专下丏:  0);
            this.东丗七万丏丒丟丛业.Item[0].世与东丗世三丞丞不(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8971"));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.东丗七万丏丒丟丛业.Item[0], 丏业丟一东丂东丘丛:  true);
            this._table.repositionNow = true;
            return;
            label_3:
            ItemEffectsLayout.<>c.<>9__5_0 = new System.Action<PGCompany.ItemEffectUI>(object:  ItemEffectsLayout.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ItemEffectsLayout.<>c::丑专且上丅一丑丅丛(PGCompany.ItemEffectUI 三丟东丕丄丄下下丑));
            if(this.东丗七万丏丒丟丛业 != null)
            {
                goto label_18;
            }
            
            goto label_18;
        }
        public ItemEffectsLayout()
        {
            this.东丗七万丏丒丟丛业 = new System.Collections.Generic.List<PGCompany.ItemEffectUI>();
        }
    
    }

}
