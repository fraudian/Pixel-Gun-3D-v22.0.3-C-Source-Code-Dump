using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPPaymentStateSwitcher : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> _freeObjects;
        private System.Collections.Generic.List<UnityEngine.GameObject> _premObjects;
        
        // Methods
        private void OnEnable()
        {
            object val_8;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_9;
            var val_10;
            System.Collections.Generic.List<UnityEngine.GameObject> val_11;
            System.Action<UnityEngine.GameObject> val_12;
            var val_13;
            var val_14;
            var val_16;
            BPPaymentStateSwitcher.丛与丒丞丁丛上丄丆 val_1 = null;
            val_8 = val_1;
            val_1 = new BPPaymentStateSwitcher.丛与丒丞丁丛上丄丆();
            val_9 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_8 != null)
            {
                    .丅丑丈丂三业丆三万 = val_9;
            }
            else
            {
                    mem[16] = val_9;
                val_9 = mem[16];
            }
            
            if(val_9 == 0)
            {
                goto label_4;
            }
            
            val_10 = 1152921504615686144;
            this._freeObjects.ForEach(action:  new System.Action<UnityEngine.GameObject>(object:  val_1, method:  System.Void BPPaymentStateSwitcher.丛与丒丞丁丛上丄丆::万丈丏且丐丄丌丄丅(UnityEngine.GameObject 三丟东丕丄丄下下丑)));
            val_11 = this._premObjects;
            System.Action<UnityEngine.GameObject> val_5 = null;
            val_12 = val_5;
            val_5 = new System.Action<UnityEngine.GameObject>(object:  val_1, method:  System.Void BPPaymentStateSwitcher.丛与丒丞丁丛上丄丆::丒丛丑丈东下不丈丗(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            val_13 = public System.Void System.Collections.Generic.List<UnityEngine.GameObject>::ForEach(System.Action<T> action);
            goto label_7;
            label_4:
            val_10 = 1152921505685757952;
            val_14 = null;
            val_14 = null;
            val_8 = BPPaymentStateSwitcher.<>c.<>9__2_0;
            if(val_8 == null)
            {
                goto label_10;
            }
            
            label_19:
            this._freeObjects.ForEach(action:  val_8);
            val_16 = null;
            val_11 = this._premObjects;
            val_16 = null;
            val_12 = BPPaymentStateSwitcher.<>c.<>9__2_1;
            if(val_12 == null)
            {
                goto label_14;
            }
            
            label_23:
            val_13 = public System.Void System.Collections.Generic.List<UnityEngine.GameObject>::ForEach(System.Action<T> action);
            label_7:
            val_11.ForEach(action:  val_12);
            return;
            label_10:
            BPPaymentStateSwitcher.<>c.<>9__2_0 = new System.Action<UnityEngine.GameObject>(object:  BPPaymentStateSwitcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPPaymentStateSwitcher.<>c::下丞丆丕专一世七与(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            if(this._freeObjects != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_14:
            BPPaymentStateSwitcher.<>c.<>9__2_1 = new System.Action<UnityEngine.GameObject>(object:  BPPaymentStateSwitcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPPaymentStateSwitcher.<>c::丝丆丏丗丆丞丗万七(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            if(val_11 != null)
            {
                goto label_23;
            }
            
            goto label_23;
        }
        public BPPaymentStateSwitcher()
        {
            this._freeObjects = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this._premObjects = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
    
    }

}
