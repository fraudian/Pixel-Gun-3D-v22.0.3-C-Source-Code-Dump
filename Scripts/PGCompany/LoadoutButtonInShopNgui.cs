using UnityEngine;

namespace PGCompany
{
    public class LoadoutButtonInShopNgui : PGBehaviour
    {
        // Fields
        private UILabel _currentLoadoutNumberLabel;
        private UnityEngine.GameObject _firstShowEffect;
        private UnityEngine.GameObject _neverEnterUiNotification;
        
        // Methods
        private void OnEnable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._firstShowEffect, 丏业丟一东丂东丘丛:  false);
            this.丕三东七丞丛上丂丗();
            this.丕丕业七丙七丅丈丄();
        }
        private void Update()
        {
            this.丕丕业七丙七丅丈丄();
            if((double)System.Math.Abs(UnityEngine.Time.timeScale) >= 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._firstShowEffect, 丏业丟一东丂东丘丛:  false);
        }
        private void OnDisable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._firstShowEffect, 丏业丟一东丂东丘丛:  false);
        }
        private void 丕丕业七丙七丅丈丄()
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._currentLoadoutNumberLabel, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丑专丘世丙丑丝世七() + 1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._neverEnterUiNotification, 丏业丟一东丂东丘丛:  (~(Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  71))) & 1);
        }
        private void 丕三东七丞丛上丂丗()
        {
            if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.loadout")) == false)
            {
                    return;
            }
            
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  72)) != true)
            {
                    if((丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  "LoadoutButtonInShopNgui-shown-effect-"("LoadoutButtonInShopNgui-shown-effect-") + 丅丛丟上丁丆上丛专.不七不丙丏上与三一().业与丆丌丆丅丄丝万(), 丞丌丑丛上丕丙丕下:  0)) == 1)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  72);
                return;
            }
            
            }
            
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  72)) != false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._firstShowEffect, 丏业丟一东丂东丘丛:  true);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  72);
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "LoadoutButtonInShopNgui-shown-effect-"("LoadoutButtonInShopNgui-shown-effect-") + 丅丛丟上丁丆上丛专.不七不丙丏上与三一().业与丆丌丆丅丄丝万(), 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        public LoadoutButtonInShopNgui()
        {
        
        }
    
    }

}
