using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPOfferItemView : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.OfferItem>
    {
        // Fields
        private bool <丘三丁丝丒丏业丞丈>k__BackingField;
        private Rilisoft.OfferItem <丅丝丌丝丁丏丙东丞>k__BackingField;
        public System.Action<PGCompany.BattlePass.BPOfferItemView> OnClickAction;
        internal UIBasicSprite _itemTexture;
        private UnityEngine.GameObject _countContainer;
        private UIBasicSprite _itemCountTexture;
        private UILabel _itemCountLabel;
        private UnityEngine.GameObject _existsIndicator;
        private UnityEngine.GameObject _lockIndicator;
        private UILabel _debugLabel;
        
        // Properties
        public bool 丒丕丂丌丁丂万东丏 { get; set; }
        public Rilisoft.OfferItem 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public bool get_HasUndroppedRewards()
        {
            return (bool)this.<丘三丁丝丒丏业丞丈>k__BackingField;
        }
        public void set_HasUndroppedRewards(bool 丙业与丙丗丝不丈东)
        {
            this.<丘三丁丝丒丏业丞丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.OfferItem get_Context()
        {
            return (Rilisoft.OfferItem)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.OfferItem 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            bool val_24;
            UIBasicSprite val_25;
            UIBasicSprite val_26;
            var val_27;
            var val_28;
            val_24 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                goto label_1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._existsIndicator, 丏业丟一东丂东丘丛:  false);
            UnityEngine.Texture val_1 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Texture;
            val_25 = this._itemTexture;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Count) <= 1)
            {
                goto label_6;
            }
            
            if(val_25 == 0)
            {
                goto label_9;
            }
            
            val_26 = val_24;
            if(val_25 == this._itemCountTexture)
            {
                goto label_16;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemTexture.gameObject, 丏业丟一东丂东丘丛:  false);
            goto label_16;
            label_1:
            if(this._itemTexture != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemTexture.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._existsIndicator, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockIndicator, 丏业丟一东丂东丘丛:  false);
            return;
            label_6:
            if(val_25 != 0)
            {
                    val_25 = this._itemTexture;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemTexture.gameObject, 丏业丟一东丂东丘丛:  true);
            }
            
            if(this._itemCountTexture != 0)
            {
                    val_25 = this._itemTexture;
                if(this._itemCountTexture != val_25)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemCountTexture.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  false);
            goto label_56;
            label_9:
            val_26 = this._itemCountTexture;
            label_16:
            val_25 = mem[this._itemCountTexture];
            if(val_25 != 0)
            {
                    val_25 = mem[this._itemCountTexture];
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[this._itemCountTexture].gameObject, 丏业丟一东丂东丘丛:  true);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  true);
            if(this._itemCountLabel != 0)
            {
                    val_25 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Count.ToString();
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemCountLabel, 丕丗丘丑丛与丑业丒:  val_25);
            }
            
            label_56:
            if(this._itemTexture == 0)
            {
                goto label_66;
            }
            
            UITweener val_19 = this._itemTexture.GetComponent<UITweener>();
            if(val_19 == 0)
            {
                goto label_66;
            }
            
            val_25 = this.<丘三丁丝丒丏业丞丈>k__BackingField;
            if(val_19 == null)
            {
                goto label_67;
            }
            
            if(val_25 == false)
            {
                goto label_68;
            }
            
            label_70:
            val_27 = 1;
            goto label_69;
            label_67:
            if(val_25 == true)
            {
                goto label_70;
            }
            
            label_68:
            val_19.ResetToBeginning();
            val_27 = 0;
            label_69:
            val_19.enabled = false;
            label_66:
            if(this._itemCountTexture == 0)
            {
                    return;
            }
            
            UITweener val_22 = this._itemCountTexture.GetComponent<UITweener>();
            if(val_22 == 0)
            {
                    return;
            }
            
            val_24 = this.<丘三丁丝丒丏业丞丈>k__BackingField;
            if(val_22 == null)
            {
                goto label_79;
            }
            
            if(val_24 == false)
            {
                goto label_80;
            }
            
            label_82:
            val_28 = 1;
            goto label_81;
            label_79:
            if(val_24 == true)
            {
                goto label_82;
            }
            
            label_80:
            val_22.ResetToBeginning();
            val_28 = 0;
            label_81:
            val_22.enabled = false;
        }
        private void OnClick()
        {
            if(this.OnClickAction == null)
            {
                    return;
            }
            
            this.OnClickAction.Invoke(obj:  this);
        }
        public BPOfferItemView()
        {
        
        }
    
    }

}
