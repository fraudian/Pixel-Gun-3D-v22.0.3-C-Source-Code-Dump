using UnityEngine;

namespace PGCompany.UpdateBanner
{
    internal sealed class UpdateBannerBlockView : PGBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UILabel> _titleTextLabel;
        private UILabel _mainTextLabel;
        private UITextureMasked _texture;
        private UnityEngine.GameObject _goButton;
        private UnityEngine.GameObject _soonButton;
        private System.Action<PGCompany.UpdateBanner.下丕丞丏丘业丏上丙> 丌万丄丒丗且丏且东;
        private PGCompany.UpdateBanner.下丕丞丏丘业丏上丙 丁丘丄丕下专东七不;
        private bool <丞丌丂丄丕专丕丟专>k__BackingField;
        
        // Properties
        internal bool 且丄七丁三丌丘丗业 { get; set; }
        
        // Methods
        internal bool 丄丏万丏不丘丝丝丑()
        {
            return (bool)this.<丞丌丂丄丕专丕丟专>k__BackingField;
        }
        private void 三丟丅丘丐丘一业丆(bool 丙业与丙丗丝不丈东)
        {
            this.<丞丌丂丄丕专丕丟专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.UpdateBanner.下丕丞丏丘业丏上丙 丐丞丟万丐三一且丞, System.Action<PGCompany.UpdateBanner.下丕丞丏丘业丏上丙> 丑丛东丐丗丏丛丒丝)
        {
            this.丌万丄丒丗且丏且东 = 丑丛东丐丗丏丛丒丝;
            this.丁丘丄丕下专东七不 = 丐丞丟万丐三一且丞;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._titleTextLabel, 丕丗丘丑丛与丑业丒:  丐丞丟万丐三一且丞.业丈丂丌丏一一丕上());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._mainTextLabel, 丕丗丘丑丛与丑业丒:  丐丞丟万丐三一且丞.丒一丞万丆丟丙不丌());
            UnityEngine.Texture val_3 = this._mainTextLabel.下丁丞上上且世丂丅(三丅丄丑丈世丏丘丆:  丐丞丟万丐三一且丞);
            this.丙丑丘业丕丗丗不丘(三丅丄丑丈世丏丘丆:  丐丞丟万丐三一且丞);
        }
        private void 丙丑丘业丕丗丗不丘(PGCompany.UpdateBanner.下丕丞丏丘业丏上丙 三丅丄丑丈世丏丘丆)
        {
            var val_26;
            if(三丅丄丑丈世丏丘丆.不业丙丒丂丞下丆丙() <= 3)
            {
                    var val_27 = 106046356 + (val_1) << 2;
                val_27 = val_27 + 106046356;
            }
            else
            {
                    val_26 = 1;
                bool val_23 = val_26 & 1;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._goButton, 丏业丟一东丂东丘丛:  val_23);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._soonButton, 丏业丟一东丂东丘丛:  true);
                this.<丞丌丂丄丕专丕丟专>k__BackingField = val_23;
            }
        
        }
        private UnityEngine.Texture 下丁丞上上且世丂丅(PGCompany.UpdateBanner.下丕丞丏丘业丏上丙 三丅丄丑丈世丏丘丆)
        {
            var val_14;
            if(三丅丄丑丈世丏丘丆.不业丙丒丂丞下丆丙() <= 3)
            {
                    var val_13 = 106046340 + (val_1) << 2;
                val_13 = val_13 + 106046340;
            }
            else
            {
                    val_14 = 0;
                return (UnityEngine.Texture)PGCompany.BattlePass.丕一丅且七上丐丘三.Load<UnityEngine.Texture>(丒丘丏上丙丟丑丕丈:  "bp_robot", 丏东丆丆丛丄丕丈丞:  null, 丗业三丝丁三丘一丟:  false);
            }
        
        }
        public void U_EventClicked()
        {
            if(this.丌万丄丒丗且丏且东 == null)
            {
                    return;
            }
            
            this.丌万丄丒丗且丏且东.Invoke(obj:  this.丁丘丄丕下专东七不);
        }
        public UpdateBannerBlockView()
        {
        
        }
    
    }

}
