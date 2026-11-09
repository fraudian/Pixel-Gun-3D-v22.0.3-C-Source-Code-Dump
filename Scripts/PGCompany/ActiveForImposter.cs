using UnityEngine;

namespace PGCompany
{
    public sealed class ActiveForImposter : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _activeObject;
        
        // Methods
        private void Update()
        {
            var val_5;
            var val_6;
            UnityEngine.GameObject val_7;
            var val_8;
            UnityEngine.GameObject val_9;
            bool val_10;
            var val_11;
            val_5 = null;
            val_5 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
            {
                goto label_5;
            }
            
            val_6 = 1152921505284374528;
            val_7 = this._activeObject;
            goto label_6;
            label_5:
            val_8 = null;
            val_8 = null;
            val_7 = this._activeObject;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
            {
                goto label_12;
            }
            
            val_6 = 1152921505284374528;
            label_6:
            val_9 = val_7;
            val_10 = 0;
            goto label_15;
            label_12:
            val_11 = null;
            val_11 = null;
            val_10 = 丟东丘丏上世且上丕();
            val_9 = val_7;
            label_15:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  val_10);
        }
        public ActiveForImposter()
        {
            val_1 = new Photon.MonoBehaviour();
        }
    
    }

}
