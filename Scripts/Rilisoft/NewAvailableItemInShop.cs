using UnityEngine;

namespace Rilisoft
{
    public class NewAvailableItemInShop : MonoBehaviour
    {
        // Fields
        public string _tag;
        public CategoryNames category;
        private UIBasicSprite 丐下丆且丂三且且三;
        public System.Collections.Generic.List<UILabel> itemName;
        
        // Methods
        private void OnClick()
        {
            LevelUpWithOffers val_1 = this.GetComponentInParent<LevelUpWithOffers>();
            if(val_1 == 0)
            {
                    return;
            }
            
            ExpController.丑七不且上丗丁一世().HandleNewAvailableItem(世丞丑上丅与世丁世:  val_1.gameObject, 丘丌丂下上丆丞丈丌:  this);
        }
        private void 丝七上丕丈丆丛丘丝()
        {
            this.丐下丆且丂三且且三 = this.GetComponentsInChildren<UITexture>()[1];
            this.itemName.Clear();
            this.itemName.AddRange(collection:  this.GetComponentsInChildren<UILabel>(includeInactive:  true));
        }
        public void SetTexture(UnityEngine.Texture 与万丆丛丒万丝丙丑)
        {
            var val_7;
            UIBasicSprite val_8;
            if(this.丐下丆且丂三且且三 == 0)
            {
                    this.丐下丆且丂三且且三 = this.GetComponentsInChildren<UITexture>()[1];
            }
            
            if(与万丆丛丒万丝丙丑 == 0)
            {
                goto label_8;
            }
            
            if((与万丆丛丒万丝丙丑.name.Contains(value:  "icon1_big")) == false)
            {
                goto label_11;
            }
            
            val_7 = 1;
            goto label_14;
            label_8:
            val_8 = this.丐下丆且丂三且且三;
            if(val_8 != null)
            {
                goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
            }
            
            goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
            label_11:
            val_7 = 0;
            label_14:
            val_8 = 丞东丑专丛丆丄丝世.上且丂一丌丛丝丕丝(与丄丈丘丟丕丏丐丁:  this.丐下丆且丂三且且三, 丁丒丘丈上上丙丗三:  false);
            this.丐下丆且丂三且且三 = val_8;
            if(val_8 == null)
            {
                
            }
        
        }
        public NewAvailableItemInShop()
        {
            this._tag = System.String.alignConst;
        }
    
    }

}
