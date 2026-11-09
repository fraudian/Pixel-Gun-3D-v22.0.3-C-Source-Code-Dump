using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemCoolnessView : PGBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PGCompany.ItemCoolnessView.ItemCoolnessEntry> _coolnessObjects;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.丝一丅丆三东丂丞七(丞丘丞丏业且丛丏丘:  PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  丈丄不七三万丄丁不));
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
        {
            this.丝一丅丆三东丂丞七(丞丘丞丏业且丛丏丘:  下丅丙一丂丗丅丝七);
        }
        internal void 丝一丅丆三东丂丞七(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘)
        {
            var val_5;
            .丞丘丞丏业且丛丏丘 = 丞丘丞丏业且丛丏丘;
            val_5 = null;
            val_5 = null;
            if((ItemCoolnessView.<>c.<>9__4_0) == null)
            {
                goto label_4;
            }
            
            label_13:
            this._coolnessObjects.ForEach(action:  ItemCoolnessView.<>c.<>9__4_0);
            if((this._coolnessObjects.Find(match:  new System.Predicate<ItemCoolnessEntry>(object:  new ItemCoolnessView.世丞丒丅一专丌丐丏(), method:  System.Boolean ItemCoolnessView.世丞丒丅一专丌丐丏::丑专业与不上不七专(PGCompany.ItemCoolnessView.ItemCoolnessEntry 三且丑东与丝丛丐丏)))) == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3.gameObject, 丏业丟一东丂东丘丛:  true);
            return;
            label_4:
            ItemCoolnessView.<>c.<>9__4_0 = new System.Action<ItemCoolnessEntry>(object:  ItemCoolnessView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ItemCoolnessView.<>c::三丁丒三丗三七东丛(PGCompany.ItemCoolnessView.ItemCoolnessEntry 三且丑东与丝丛丐丏));
            if(this._coolnessObjects != null)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        public ItemCoolnessView()
        {
            this._coolnessObjects = new System.Collections.Generic.List<ItemCoolnessEntry>();
        }
    
    }

}
