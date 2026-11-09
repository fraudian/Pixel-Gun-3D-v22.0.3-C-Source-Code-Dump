using UnityEngine;

namespace PGCompany
{
    internal sealed class GiftUniversalRewardShower : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _oldGiftInfo;
        private UnityEngine.GameObject _universalGachaTransitionUI;
        private float _delayForTransitionUI;
        private float _delayForUniversalRewardWindow;
        
        // Methods
        private void OnEnable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._universalGachaTransitionUI, 丏业丟一东丂东丘丛:  false);
            bool val_2 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().丐专与世丐丌丏七万(且丒丛与丞世丙丕丌:  6);
            if(val_2 != false)
            {
                    UnityEngine.Coroutine val_4 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this._delayForTransitionUI, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.GiftUniversalRewardShower::丛丟丗丑丕万丐丁上()));
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._oldGiftInfo, 丏业丟一东丂东丘丛:  (~val_2) & 1);
        }
        private void 丛丟丗丑丕万丐丁上()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._universalGachaTransitionUI, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Coroutine val_2 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this._delayForUniversalRewardWindow, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.GiftUniversalRewardShower::与三丆丏丌三丈七丂()));
        }
        private void 与三丆丏丌三丈七丂()
        {
            UniversalRewardBanner.丝七丘丌丝业一丟丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GiftUniversalRewardShower::丝丆丏专丕丄丌不丅()));
            UniversalRewardBanner.丒丏丏丛丕丐丂丛丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GiftUniversalRewardShower::丝丆丏专丕丄丌不丅()));
            UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  6, 丌世丕丗不丘世丞专:  1, 一七丁不丝丈丕丑丒:  0);
        }
        private void 丝丆丏专丕丄丌不丅()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._universalGachaTransitionUI, 丏业丟一东丂东丘丛:  false);
            UniversalRewardBanner.丝七丘丌丝业一丟丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GiftUniversalRewardShower::丝丆丏专丕丄丌不丅()));
        }
        public GiftUniversalRewardShower()
        {
        
        }
    
    }

}
