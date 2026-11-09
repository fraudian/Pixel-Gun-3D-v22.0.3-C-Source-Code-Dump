using UnityEngine;

namespace PGCompany
{
    public sealed class MatchHistoryPlayerView : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject[] _myPlayerObjects;
        private UnityEngine.GameObject _grayBackground;
        private UnityEngine.GameObject _teammateBackground;
        private UnityEngine.GameObject _opponentBackground;
        private UITexture _texture;
        private UILabel _cupsLabel;
        private UILabel _nick;
        private UnityEngine.GameObject _noPlayerTexture;
        private UnityEngine.GameObject _cupsContainer;
        private UIButton _button;
        internal Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 丒上上丑丏丕丒丘与;
        public ContextMenuBase ContextMenu;
        
        // Methods
        internal void 丑丄与万世且丛且上()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._teammateBackground, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._opponentBackground, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._grayBackground, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._myPlayerObjects, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._texture, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._noPlayerTexture, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._cupsLabel, 丕丗丘丑丛与丑业丒:  0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._cupsContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._nick, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
            this._button.enabled = false;
        }
        internal void 丈丏丛丏世东丒东丄(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 一丐丗丁丞丆丅丟丄)
        {
            this.丒上上丑丏丕丒丘与 = 一丐丗丁丞丆丅丟丄;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._teammateBackground, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._opponentBackground, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._grayBackground, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._myPlayerObjects, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._texture, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  业丂丏与世一丏业不.丑七不且上丗丁一世().三世丑三万丄丌丕丌(), 丁丅丈丌丟世丗丗丟:  1));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._noPlayerTexture, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._cupsLabel, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.一丁丈丕丁业下不丁());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._cupsContainer, 丏业丟一东丂东丘丛:  (一丐丗丁丞丆丅丟丄.一丁丈丕丁业下不丁() >> 31) ^ 1);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._nick, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丒丛上上丑丁业丅下().与与丌万丟丄丌丘三());
            this._button.enabled = false;
        }
        internal void 丏丒丞丑丕且丞丂与(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 一丐丗丁丞丆丅丟丄, bool 丈丏丂丛与丛丐丁三)
        {
            this.丒上上丑丏丕丒丘与 = 一丐丗丁丞丆丅丟丄;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._teammateBackground, 丏业丟一东丂东丘丛:  丈丏丂丛与丛丐丁三);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._opponentBackground, 丏业丟一东丂东丘丛:  (~丈丏丂丛与丛丐丁三) & 1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._grayBackground, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._myPlayerObjects, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._texture, 丏业丟一东丂东丘丛:  true);
            if((PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丗丗丁专丘三丟世丅(丄丒且丙三丆丟与丏:  一丐丗丁丞丆丅丟丄.业上丙丞丐丄丆丅七())) != false)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丗业上丂世一七丆丏(丄丒且丙三丆丟与丏:  一丐丗丁丞丆丅丟丄.业上丙丞丐丄丆丅七()), 丁丅丈丌丟世丗丗丟:  1));
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._noPlayerTexture, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._cupsLabel, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.一丁丈丕丁业下不丁());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._cupsContainer, 丏业丟一东丂东丘丛:  (一丐丗丁丞丆丅丟丄.一丁丈丕丁业下不丁() >> 31) ^ 1);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._nick, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.与与丌万丟丄丌丘三());
            this._button.enabled = true;
        }
        internal void 万专丄丂丂丝与丝丒()
        {
            if(this._texture == 0)
            {
                    return;
            }
            
            if(this._texture.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if(this._texture != 0)
            {
                    return;
            }
            
            PGCompany.一丆丏专不丙上丟业 val_5 = PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世();
            if(this.丒上上丑丏丕丒丘与 == null)
            {
                goto label_11;
            }
            
            if(val_5 != null)
            {
                goto label_18;
            }
            
            label_19:
            label_18:
            if((val_5.丗丗丁专丘三丟世丅(丄丒且丙三丆丟与丏:  this.丒上上丑丏丕丒丘与.业上丙丞丐丄丆丅七())) == false)
            {
                    return;
            }
            
            PGCompany.一丆丏专不丙上丟业 val_8 = PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世();
            if(this.丒上上丑丏丕丒丘与 == null)
            {
                goto label_14;
            }
            
            if(val_8 != null)
            {
                goto label_20;
            }
            
            label_21:
            label_20:
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  val_8.丗业上丂世一七丆丏(丄丒且丙三丆丟与丏:  this.丒上上丑丏丕丒丘与.业上丙丞丐丄丆丅七()), 丁丅丈丌丟世丗丗丟:  1));
            return;
            label_11:
            if(val_5 != null)
            {
                goto label_18;
            }
            
            goto label_19;
            label_14:
            if(val_8 != null)
            {
                goto label_20;
            }
            
            goto label_21;
        }
        public void U_HandleClick()
        {
            var val_13;
            var val_14;
            val_13 = this;
            if(this.丒上上丑丏丕丒丘与 == null)
            {
                    return;
            }
            
            val_14 = 0;
            if((System.String.op_Equality(a:  this.丒上上丑丏丕丒丘与.业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
            {
                    return;
            }
            
            if(丈东丛丗上业不丒三.丁丟丆与丈丆丌丑且() != null)
            {
                    val_14 = 0;
            }
            
            ContextMenuBase val_8 = 丈东丛丗上业不丒三.丁丟丆与丈丆丌丑且();
            val_8.Pointer = 1152921505278197760;
            ContextMenuBase val_9 = 丈东丛丗上业不丒三.丁丟丆与丈丆丌丑且();
            UnityEngine.Transform val_10 = this.丌丟丄业且三丛丕丄();
            val_13 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_12 = val_13.position;
        }
        public MatchHistoryPlayerView()
        {
        
        }
    
    }

}
