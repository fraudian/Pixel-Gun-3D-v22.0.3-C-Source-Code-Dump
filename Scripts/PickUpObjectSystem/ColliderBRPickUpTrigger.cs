using UnityEngine;

namespace PickUpObjectSystem
{
    internal sealed class ColliderBRPickUpTrigger : BasePickUpTrigger
    {
        // Fields
        private bool 丟专上且丏丏丅丂不;
        private bool 万丒丗专不丕专一七;
        private float 丁业与丄丑业丆丆丐;
        
        // Methods
        private void OnDestroy()
        {
            if(this == null)
            {
                    return;
            }
            
            this.Invoke();
        }
        private bool 丂丂丂丁丑丏世丆且()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_10 = null;
            val_10 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
            {
                    return false;
            }
            
            val_11 = null;
            val_11 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
            {
                    return false;
            }
            
            val_12 = null;
            val_12 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_628 == 0)
            {
                    return false;
            }
            
            val_13 = null;
            val_13 = null;
            val_14 = null;
            val_14 = null;
            val_15 = null;
            val_15 = null;
            val_16 = null;
            val_16 = null;
            if(InGameGUI.丙丞专丌丁丞与不丐.isTurretInterfaceActive == true)
            {
                    return false;
            }
            
            val_17 = null;
            val_17 = null;
            return false;
        }
        private void 三三丒且丙丏丏业丐()
        {
            var val_14;
            string val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            if( == null)
            {
                goto label_26;
            }
            
            val_14 = null;
            val_14 = null;
            val_16 = null;
            if((typeof(Player_move_c).__il2cppRuntimeField_538.Count + WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count) < WeaponManager.丂丐丛业世丝丁丛丕)
            {
                goto label_26;
            }
            
            val_17 = 0;
            goto label_12;
            label_31:
            val_18 = null;
            val_18 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0].七丝丈东丈丕丐与丗() == false)
            {
                goto label_18;
            }
            
            val_19 = null;
            val_19 = null;
            三丈丟与丏丘丈丐万 val_9 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
            val_15 = val_9.丙丗丕丟七丟上丈丌.业上丙丞丐丄丆丅七();
            if((System.String.op_Equality(a:  val_15, b:  X25 + 104)) == true)
            {
                goto label_26;
            }
            
            label_18:
            val_16 = null;
            val_17 = 1;
            label_12:
            val_16 = null;
            val_15 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
            if(val_17 < val_15.Count)
            {
                goto label_31;
            }
            
            this.丟专上且丏丏丅丂不 = true;
            return;
            label_26:
            if(0 != 0)
            {
                    0.Invoke();
            }
            
            this.万丒丗专不丕专一七 = true;
        }
        private void 丅世不且万万一七丟()
        {
            if(this != null)
            {
                    this.Invoke();
            }
            
            this.万丒丗专不丕专一七 = false;
        }
        private void Update()
        {
            bool val_5;
            int val_1 = UnityEngine.Time.frameCount;
            if(0 != 0)
            {
                    return;
            }
            
            bool val_2 = this.丂丂丂丁丑丏世丆且();
            val_5 = this.丟专上且丏丏丅丂不;
            var val_3 = (val_5 == true) ? 1 : 0;
            val_3 = val_2 ^ val_3;
            if(val_3 != false)
            {
                    this.丟专上且丏丏丅丂不 = val_2;
                if(val_2 != false)
            {
                    this.三三丒且丙丏丏业丐();
            }
            else
            {
                    if(val_2 != false)
            {
                    val_2.Invoke();
            }
            
                this.万丒丗专不丕专一七 = false;
            }
            
                val_5 = this.丟专上且丏丏丅丂不;
            }
            
            if(val_5 == false)
            {
                    return;
            }
            
            if(this.万丒丗专不丕专一七 == true)
            {
                    return;
            }
            
            if(val_2 != false)
            {
                    val_2.Invoke();
            }
            
            this.万丒丗专不丕专一七 = true;
        }
        public ColliderBRPickUpTrigger()
        {
            this.丁业与丄丑业丆丆丐 = 5f;
            val_1 = new PGBehaviour();
        }
    
    }

}
