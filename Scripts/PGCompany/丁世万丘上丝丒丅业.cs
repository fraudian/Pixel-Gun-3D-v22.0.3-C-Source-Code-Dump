using UnityEngine;

namespace PGCompany
{
    internal class 丁世万丘上丝丒丅业 : 丂丏丑丈丕三丙丛丑
    {
        // Methods
        internal override void 丈且东丑丂且万丒丅()
        {
            PGCompany.七不丐丐丒丆世丒丏.丁专七上业丐七丙业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丁世万丘上丝丒丅业::上专丄丑专丑丘业丌()));
        }
        internal override void 丏丟业下与丝丕丈丘()
        {
            PGCompany.七不丐丐丒丆世丒丏.丛七一丘上丁丝一与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丁世万丘上丝丒丅业::上专丄丑专丑丘业丌()));
        }
        private void 上专丄丑专丑丘业丌()
        {
            this.且上上丌丅丟丆丕丒();
        }
        protected override void 丅丘丙丒丆丄三丝丌()
        {
            CategoryNames val_1;
            var val_9;
            var val_10;
            var val_11;
            val_9 = this;
            System.Collections.Generic.List<System.String> val_6 = 0;
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  0);
            val_10 = PGCompany.七不丐丐丒丆世丒丏.丑七不且上丗丁一世().一丈丅丞丙丁丁丂不();
            Dictionary.Enumerator<TKey, TValue> val_4 = val_10.GetEnumerator();
            label_8:
            if(((-654136936) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
            if(val_5._value._obj == 0)
            {
                goto label_8;
            }
            
            val_10;
            if((val_5._value._obj.TryGetValue(key:  val_1, value: out  val_6)) == false)
            {
                goto label_8;
            }
            
            if(val_6 == 0)
            {
                goto label_9;
            }
            
            val_11 = val_6.Count;
            if(this != null)
            {
                goto label_12;
            }
            
            goto label_11;
            label_9:
            val_11 = 0;
            if(this != null)
            {
                goto label_12;
            }
            
            label_11:
            label_12:
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  0);
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public 丁世万丘上丝丒丅业()
        {
        
        }
    
    }

}
