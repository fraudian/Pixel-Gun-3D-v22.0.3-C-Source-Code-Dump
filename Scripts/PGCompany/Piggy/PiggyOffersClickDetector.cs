using UnityEngine;

namespace PGCompany.Piggy
{
    internal sealed class PiggyOffersClickDetector : PGBehaviour
    {
        // Fields
        private UnityEngine.BoxCollider _collider;
        private UnityEngine.Coroutine 丞且丝丛七丙丙上丂;
        
        // Methods
        private void Awake()
        {
            var val_4;
            System.Func<System.Boolean> val_6;
            if(this.丞且丝丛七丙丙上丂 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丞且丝丛七丙丙上丂);
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = PiggyOffersClickDetector.<>c.<>9__2_0;
            if(val_6 == null)
            {
                    System.Func<System.Boolean> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Func<System.Boolean>(object:  PiggyOffersClickDetector.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PiggyOffersClickDetector.<>c::丒万丟丞丛丗丗丌且());
                PiggyOffersClickDetector.<>c.<>9__2_0 = val_6;
            }
            
            this.丞且丝丛七丙丙上丂 = CoroutineRunner.丆万七与丏丁丞丂专(且丐丈丕三丟丕丙丒:  val_1, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersClickDetector::丞丄世丆丄丝专丈丐()));
        }
        private void OnEnable()
        {
            this.丞丐丑专专世丙万丝();
            PGCompany.Piggy.业世且丐丕专丛专丐.万丞下世东且专丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersClickDetector::丞丐丑专专世丙万丝()));
        }
        private void OnDisable()
        {
            PGCompany.Piggy.业世且丐丕专丛专丐.三丗丆丕丟上丈万三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Piggy.PiggyOffersClickDetector::丞丐丑专专世丙万丝()));
        }
        private void 丞丐丑专专世丙万丝()
        {
            UnityEngine.BoxCollider val_4 = this._collider;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4 = 97931;
            if((PGCompany.Piggy.业世且丐丕专丛专丐.<不丁丄七丛不丆丁丕>k__BackingField) == null)
            {
                    val_4 = 0;
            }
            
            if(null == 0)
            {
                goto label_6;
            }
            
            if(this._collider != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            this._collider.enabled = val_4.上上丈丌一丟丞丂三();
            return;
            label_6:
            if(this._collider != null)
            {
                goto label_8;
            }
            
            goto label_9;
        }
        private void 丞丄世丆丄丝专丈丐()
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            this.丞且丝丛七丙丙上丂 = 0;
            val_11 = null;
            val_11 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟.丌丒丒丙与东丈丟东() == 0)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟.Camera == 0)
            {
                    return;
            }
            
            val_14 = null;
            val_14 = null;
            UnityEngine.Vector3 val_6 = PGCompany.Piggy.PiggyOffersLobby.丝业丆丁业三丈丟东.丘丛丝七丐丁七一丐();
            UnityEngine.Vector3 val_7 = MainMenuController.丄丞丁丈与业上丞丟.丌丒丒丙与东丈丟东().WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            if(this._collider == 0)
            {
                    return;
            }
            
            val_15 = null;
            val_15 = null;
            UnityEngine.Vector3 val_10 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this._collider.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        public void HandleClicked()
        {
            if((PGCompany.Piggy.业世且丐丕专丛专丐.<不丁丄七丛不丆丁丕>k__BackingField.丙三丁与丕三丄丄丆()) == false)
            {
                    return;
            }
            
            PGCompany.Piggy.业世且丐丕专丛专丐.丈丏万丛丈不丝丞七();
        }
        public PiggyOffersClickDetector()
        {
        
        }
    
    }

}
