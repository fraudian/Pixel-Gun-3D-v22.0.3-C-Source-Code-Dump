using UnityEngine;

namespace Rilisoft
{
    public class ClanStockItemView : ClanItemView
    {
        // Fields
        private UnityEngine.GameObject _baseContentObject;
        private UnityEngine.GameObject _emptyContentObject;
        private UISprite _notInStockBorderSprite;
        private UnityEngine.GameObject _notInStockObject;
        private UISprite _notInStockRareSprite;
        
        // Methods
        public override void Set(ClanItem 下丅丙一丂丗丅丝七)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._baseContentObject, 丏业丟一东丂东丘丛:  (下丅丙一丂丗丅丝七 != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._emptyContentObject, 丏业丟一东丂东丘丛:  (下丅丙一丂丗丅丝七 == 0) ? 1 : 0);
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            this.Set(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        }
        protected override void 不丆业丌丆丛丑丗丏()
        {
            if(this.Item == null)
            {
                    return;
            }
            
            if(this.Item.Type == 20)
            {
                    if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丐丛业丅丟上丘丟东(丞一丁业丄一一业且:  this.Item.Id)) <= 0)
            {
                goto label_6;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notInStockObject, 丏业丟一东丂东丘丛:  false);
            this.不丆业丌丆丛丑丗丏();
            return;
            label_6:
            UIBasicSprite val_8 = this.丟丁丞丕七丝丆世丑();
            UnityEngine.Texture val_9 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/fort_notinstock_cell");
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notInStockObject, 丏业丟一东丂东丘丛:  true);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this._notInStockRareSprite.spriteName = System.String.Format(format:  "storage_icon_{0}", arg0:  this.Item.Rarity.ToString().ToLower());
            UnityEngine.Color val_17 = Rilisoft.ClanStockWindow.专且丈七丈丛丆东丈(丈下丑丆上丏丗丈专:  this.Item.Rarity);
            this._notInStockBorderSprite.color = new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a};
        }
        public ClanStockItemView()
        {
        
        }
    
    }

}
