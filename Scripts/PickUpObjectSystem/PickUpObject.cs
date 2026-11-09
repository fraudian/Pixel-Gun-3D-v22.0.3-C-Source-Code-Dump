using UnityEngine;

namespace PickUpObjectSystem
{
    internal sealed class PickUpObject : PGBehaviour, 世丂丈世且万世丞上
    {
        // Fields
        private int 丏世丑万世一七丟丞;
        private bool 万丙丛丐且丑丗丏业;
        private bool 三丐三丅一一丗丑丄;
        private PickUpObjectSystem.丈东丐世丌丏丞丂世 丙丌丂丄丌丄业丏丑;
        internal PickUpObjectSystem.BasePickUpTrigger 七东丅丄业丒丅丁丕;
        internal System.Collections.Generic.List<PickUpObjectSystem.丞不丏七丙丝丛东与> 丄不世丘丟不丄业丌;
        private PickUpObjectSystem.丘一三丆丛丂丘丗丘 丒丄丅丟丞丅丄七丕;
        
        // Properties
        internal int 丁业世丅丌丛上下与 { get; set; }
        internal PickUpObjectSystem.丈东丐世丌丏丞丂世 丈东丐世丌丏丞丂世 { get; set; }
        internal PickUpObjectSystem.丘一三丆丛丂丘丗丘 丅万丂世不丘丕下一 { get; }
        
        // Methods
        internal int 业丐丐三丕一丗丛丁()
        {
            return (int)this.丏世丑万世一七丟丞;
        }
        internal void 下东丄丄丟丞东丁丅(int 丙业与丙丗丝不丈东)
        {
            this.丏世丑万世一七丟丞 = 丙业与丙丗丝不丈东;
        }
        internal PickUpObjectSystem.丈东丐世丌丏丞丂世 丂丌丂丘丙专丘丕三()
        {
            return (PickUpObjectSystem.丈东丐世丌丏丞丂世)this.丙丌丂丄丌丄业丏丑;
        }
        internal void 万丛丛一东一东东丆(PickUpObjectSystem.丈东丐世丌丏丞丂世 丙业与丙丗丝不丈东)
        {
            this.丙丌丂丄丌丄业丏丑 = 丙业与丙丗丝不丈东;
        }
        internal PickUpObjectSystem.丘一三丆丛丂丘丗丘 丏丘下丞丘不丑万丏()
        {
            return new PickUpObjectSystem.丘一三丆丛丂丘丗丘() {丞丅上丏丂且下丅与 = this.丒丄丅丟丞丅丄七丕};
        }
        internal void 丘上丐世丆丑且丞丒(string 丞丅上丏丂且下丅与, int 丌丒丝东丌下丕丁丅)
        {
            mem[1152921540856221824] = 丌丒丝东丌下丕丁丅;
            mem[1152921540856221828] = 0;
            this.丒丄丅丟丞丅丄七丕 = 丞丅上丏丂且下丅与;
            this.七东丅丄业丒丅丁丕.丙丁丕丙丅丕丈世万 = this;
            if(this.七东丅丄业丒丅丁丕 == 0)
            {
                    return;
            }
            
            this.七东丅丄业丒丅丁丕.丟专不丐世丌丙下丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PickUpObjectSystem.PickUpObject::专一丏丆丁与丄丒万()));
            this.七东丅丄业丒丅丁丕.丄丛丗且万丁丆丗丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PickUpObjectSystem.PickUpObject::丒丄丘丂丅业世不一()));
        }
        private void OnDestroy()
        {
            if(this.七东丅丄业丒丅丁丕 != 0)
            {
                    this.七东丅丄业丒丅丁丕.丟世东丆专业丗丏丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PickUpObjectSystem.PickUpObject::专一丏丆丁与丄丒万()));
                this.七东丅丄业丒丅丁丕.丏上丂丞业不丂世丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PickUpObjectSystem.PickUpObject::丒丄丘丂丅业世不一()));
            }
            
            if(this.万丙丛丐且丑丗丏业 == false)
            {
                    return;
            }
            
            InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂丟丗丗三不丁丏上(丆丗上丗丆丑丘一丞:  this, 丁丈丝上丐且丘且专:  false);
            this.万丙丛丐且丑丗丏业 = false;
        }
        private void 专一丏丆丁与丄丒万()
        {
            if(GameConnect.万不丒丌丙万丗东不() == false)
            {
                    return;
            }
            
            if(this.万丙丛丐且丑丗丏业 == true)
            {
                    return;
            }
            
            if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
            {
                    return;
            }
            
            this.万丙丛丐且丑丗丏业 = InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂下丗丛丂丄业业业(丆丗上丗丆丑丘一丞:  this);
        }
        private void 丒丄丘丂丅业世不一()
        {
            if(this.万丙丛丐且丑丗丏业 == false)
            {
                    return;
            }
            
            if(GameConnect.万不丒丌丙万丗东不() == false)
            {
                    return;
            }
            
            if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
            {
                    return;
            }
            
            InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂丟丗丗三不丁丏上(丆丗上丗丆丑丘一丞:  this, 丁丈丝上丐且丘且专:  false);
            this.万丙丛丐且丑丗丏业 = false;
        }
        internal void 七世丙丂东东丌专丕(int 丅上丁不丛丁上七丈)
        {
            if(this.三丐三丅一一丗丑丄 != false)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.丄不世丘丟不丄业丌.GetEnumerator();
            label_5:
            if((1890154184 & 1) == 0)
            {
                goto label_3;
            }
            
            if(0.丐丏七丌丕丗业且上() != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.三丐三丅一一丗丑丄 = true;
            if(this.万丙丛丐且丑丗丏业 == false)
            {
                    return;
            }
            
            if(GameConnect.万不丒丌丙万丗东不() == false)
            {
                    return;
            }
            
            if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
            {
                    return;
            }
            
            InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂丟丗丗三不丁丏上(丆丗上丗丆丑丘一丞:  this, 丁丈丝上丐且丘且专:  false);
            this.万丙丛丐且丑丗丏业 = false;
        }
        public bool AlreadyHaveThisWeapon()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_7 = 0;
            label_11:
            val_7 = null;
            val_7 = null;
            val_8 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
            if(val_7 >= val_8.Count)
            {
                goto label_5;
            }
            
            val_9 = null;
            val_9 = null;
            val_8 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
            val_7 = val_7 + 1;
            if((System.String.op_Equality(a:  val_8.丈专世七丗三丙丝下(), b:  this.丒丄丅丟丞丅丄七丕)) == false)
            {
                goto label_11;
            }
            
            val_10 = 1;
            return (bool)val_10;
            label_5:
            val_10 = 0;
            return (bool)val_10;
        }
        public void AddWeaponToPlayer()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(PickUpObjectSystem.PickUpObjectController.丄丘七三上丕世丞业 != 0)
            {
                    val_3 = null;
                val_3 = null;
                PickUpObjectSystem.PickUpObjectController.丄丘七三上丕世丞业.丂丘丗丛上世丝丅丗(不丌丘丟丅丛丄丌丞:  this);
            }
            
            if(this.万丙丛丐且丑丗丏业 == false)
            {
                    return;
            }
            
            InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂丟丗丗三不丁丏上(丆丗上丗丆丑丘一丞:  this, 丁丈丝上丐且丘且专:  true);
            this.万丙丛丐且丑丗丏业 = false;
        }
        public string GetWeaponName()
        {
            return (string)this.丒丄丅丟丞丅丄七丕;
        }
        public int GetCurrentAmmoInClip()
        {
            return (int)this;
        }
        public int GetCurrentAmmoInBackpack()
        {
            return 0;
        }
        public ItemRarity GetRarity()
        {
            丕丈丏丝丗下丟丅丂 val_2 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[this.丒丄丅丟丞丅丄七丕];
            if(val_2 != null)
            {
                    return val_2.七东与丄丕丁丛世三();
            }
            
            return val_2.七东与丄丕丁丛世三();
        }
        public bool IsGadget()
        {
            return true;
        }
        public PickUpObject()
        {
            this.丄不世丘丟不丄业丌 = new System.Collections.Generic.List<PickUpObjectSystem.丞不丏七丙丝丛东与>();
        }
        private UnityEngine.Transform IPickUpWeapon.get_transform()
        {
            return this.transform;
        }
    
    }

}
