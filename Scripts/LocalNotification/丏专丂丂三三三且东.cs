using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丏专丂丂三三三且东 : 专丐丛东丄专万下丏
    {
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540875205592] = val_1;
            .下丄丈不与世丐业专 = "DoubleReward";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丏专丂丂三三三且东::丘丒不不丌丘下丒一());
            val_1.set_Item(key:  "DoubleReward", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        private System.TimeSpan 丘丒不不丌丘下丒一()
        {
            var val_15;
            var val_17;
            var val_20;
            var val_21;
            System.TimeSpan val_23;
            val_15 = 1152921505442680832;
            if(Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丈丙三三丟七且且丟() == false)
            {
                goto label_4;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_12;
            label_4:
            val_17 = null;
            goto label_58;
            label_12:
            System.Collections.Generic.IEnumerator<T> val_6 = Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().七不丈专丙世丅丕丝().GetEnumerator();
            label_33:
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_20;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            T val_10 = val_6.Current;
            if(((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  val_10)) == true) || ((Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  val_10)) == true))
            {
                goto label_33;
            }
            
            val_15 = 0;
            val_20 = 0;
            val_21 = 1;
            if(val_6 != null)
            {
                goto label_36;
            }
            
            goto label_44;
            label_20:
            val_15 = 0;
            val_20 = 0;
            val_21 = 0;
            if(val_6 != null)
            {
                goto label_36;
            }
            
            goto label_44;
            label_36:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_6.Dispose();
            label_44:
            if( == 1)
            {
                goto label_49;
            }
            
            if(( == false) || (95 == 95))
            {
                goto label_60;
            }
            
            label_59:
            label_60:
            val_17 = null;
            if(( & 1) != 0)
            {
                    System.TimeSpan val_16 = System.TimeSpan.FromDays(value:  1);
                val_23 = val_16._ticks;
                if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_16._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return val_23;
            }
            
            }
            
            label_58:
            val_23 = System.TimeSpan.Zero;
            return val_23;
            label_49:
            if( == true)
            {
                goto label_59;
            }
            
            goto label_60;
        }
        public 丏专丂丂三三三且东()
        {
            val_1 = new System.Object();
        }
    
    }

}
