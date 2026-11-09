using UnityEngine;

namespace PGCompany
{
    internal sealed class RentalOptionViewModel : MonoBehaviour
    {
        // Fields
        private int _index;
        private UITextureMasked _icon;
        private UILabel _weaponLabel;
        private UnityEngine.GameObject _nonSelectedFrame;
        private UnityEngine.GameObject _selectedFrame;
        private UITexture[] _pictograms;
        private UISprite _rarityBackground;
        private 三丅丁丗丗丝丂万且 丅丗世丝丌与与丕下;
        
        // Properties
        internal int 丐丒且丝丛丁丕丟丅 { get; }
        internal UITextureMasked 丛丙丂丝不丏上东不 { get; }
        internal UILabel 世世丙丟丛三丗丌丝 { get; }
        internal UnityEngine.GameObject 丝丐万七东丗丟三丈 { get; }
        internal UnityEngine.GameObject 丗丏丑且丑一万丏七 { get; }
        internal 三丅丁丗丗丝丂万且 丄三丅丑三一丅丄专 { get; }
        
        // Methods
        internal int 业东丅东丌上丗丑不()
        {
            return (int)this._index;
        }
        internal UITextureMasked 丑一丆丑且丟上业丛()
        {
            return (UITextureMasked)this._icon;
        }
        internal UILabel 丙丟与丘丄丒丙下丒()
        {
            return (UILabel)this._weaponLabel;
        }
        internal UnityEngine.GameObject 丛三丑丅丄丑丐丝丝()
        {
            return (UnityEngine.GameObject)this._nonSelectedFrame;
        }
        internal UnityEngine.GameObject 丛上下专丌七丝丁万()
        {
            return (UnityEngine.GameObject)this._selectedFrame;
        }
        internal 三丅丁丗丗丝丂万且 七丛丐七丆丆一丅七()
        {
            return (三丅丁丗丗丝丂万且)this.丅丗世丝丌与与丕下;
        }
        public void SetSelected(bool 丛丗七丅下丞丗且丐)
        {
            丛丗七丅下丞丗且丐 = (~丛丗七丅下丞丗且丐) & 1;
            this._nonSelectedFrame.SetActive(value:  丛丗七丅下丞丗且丐);
            this._selectedFrame.SetActive(value:  丛丗七丅下丞丗且丐);
        }
        internal void 且丙七丄丝丄丅一丑(三丅丁丗丗丝丂万且 丝丂丁丌丆三丆专且)
        {
            UILabel val_6;
            UITexture[] val_7;
            if(丝丂丁丌丆三丆专且 != null)
            {
                    this.业丄丂丙丁丞不丟丄(丝丂丁丌丆三丆专且:  丝丂丁丌丆三丆专且);
                return;
            }
            
            this.丅丗世丝丌与与丕下 = 0;
            if(this._weaponLabel != 0)
            {
                    val_6 = this._weaponLabel;
                val_6.text = System.String.alignConst;
                UnityEngine.Color val_2 = UnityEngine.Color.white;
                this._weaponLabel.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            }
            
            val_7 = this._pictograms;
            if(val_7 == null)
            {
                goto label_8;
            }
            
            val_6 = 0;
            goto label_9;
            label_16:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._pictograms[0].gameObject, 丏业丟一东丂东丘丛:  false);
            val_7 = this._pictograms;
            val_6 = 1;
            label_9:
            if(val_6 != this._pictograms.Length)
            {
                goto label_16;
            }
            
            label_8:
            if(this._rarityBackground == 0)
            {
                    return;
            }
            
            UnityEngine.Color val_5 = UnityEngine.Color.white;
            this._rarityBackground.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        }
        private void 业丄丂丙丁丞不丟丄(三丅丁丗丗丝丂万且 丝丂丁丌丆三丆专且)
        {
            UITextureMasked val_12;
            CategoryNames val_13;
            UITexture[] val_14;
            var val_15;
            this.丅丗世丝丌与与丕下 = 丝丂丁丌丆三丆专且;
            if(丝丂丁丌丆三丆专且 != null)
            {
                    val_12 = this._icon;
                val_13 = 丝丂丁丌丆三丆专且.丒万丕七专不丏丞丌();
            }
            else
            {
                    val_12 = this._icon;
                val_13 = 0.丒万丕七专不丏丞丌();
            }
            
            UnityEngine.Texture val_4 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  丝丂丁丌丆三丆专且.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_13, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            UnityEngine.Color val_5 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  丝丂丁丌丆三丆专且);
            if(this._weaponLabel != 0)
            {
                    this._weaponLabel.text = 丏丄丑上丛不丈且万.丒丅丈且且专不丅一(丆万一不丌且东丐丐:  丝丂丁丌丆三丆专且.与不丞丑七丘丁丂丛());
                this._weaponLabel.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            }
            
            val_14 = this._pictograms;
            if(val_14 == null)
            {
                goto label_14;
            }
            
            val_15 = 0;
            goto label_15;
            label_22:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._pictograms[0].gameObject, 丏业丟一东丂东丘丛:  (val_13 == val_15) ? 1 : 0);
            val_14 = this._pictograms;
            val_15 = 1;
            label_15:
            if(val_15 != this._pictograms.Length)
            {
                goto label_22;
            }
            
            label_14:
            if(this._rarityBackground == 0)
            {
                    return;
            }
            
            this._rarityBackground.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        }
        public RentalOptionViewModel()
        {
        
        }
    
    }

}
