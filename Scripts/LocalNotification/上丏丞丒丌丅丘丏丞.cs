using UnityEngine;

namespace LocalNotification
{
    internal sealed class 上丏丞丒丌丅丘丏丞 : 专丐丛东丄专万下丏
    {
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540870957416] = val_1;
            .下丄丈不与世丐业专 = "ChestEventOpenAvailable";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.上丏丞丒丌丅丘丏丞::万丛丂丂丝丆丝丈下());
            val_1.set_Item(key:  "ChestEventOpenAvailable", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            .下丄丈不与世丐业专 = "ChestEventHalfTime";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.上丏丞丒丌丅丘丏丞::专上丙丌丆丂丅丅丙());
            val_1.set_Item(key:  "ChestEventHalfTime", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            .下丄丈不与世丐业专 = "ChestEventLastOneDay";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.上丏丞丒丌丅丘丏丞::七与且丘七丄世一下());
            val_1.set_Item(key:  "ChestEventLastOneDay", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        private System.TimeSpan 万丛丂丂丝丆丝丈下()
        {
            var val_9;
            double val_10;
            var val_11;
            System.TimeSpan val_12;
            Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            if(val_2 == null)
            {
                goto label_7;
            }
            
            val_9 = BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  0);
            if(val_9 <= 49)
            {
                goto label_7;
            }
            
            List.Enumerator<T> val_5 = val_2.丄三丐丟丗丄丟上丞().GetEnumerator();
            val_10 = 6;
            label_12:
            if((1904521112 & 1) == 0)
            {
                goto label_9;
            }
            
            if(0.丐丏七丌丕丗业且上().丟丂丞不专丆万丒世() > val_9)
            {
                goto label_12;
            }
            
            goto label_13;
            label_7:
            val_9 = 1152921504624898048;
            val_11 = null;
            val_11 = null;
            val_12 = System.TimeSpan.Zero;
            return (System.TimeSpan)val_8._ticks;
            label_9:
            val_10 = 0;
            label_13:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.TimeSpan val_8 = System.TimeSpan.FromHours(value:  null);
            return (System.TimeSpan)val_8._ticks;
        }
        private System.TimeSpan 专上丙丌丆丂丅丅丙()
        {
            long val_15;
            var val_16;
            System.TimeSpan val_17;
            val_15 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            if(val_15 == null)
            {
                goto label_5;
            }
            
            System.Nullable<System.TimeSpan> val_3 = val_15.丙世丑丅丒丑业与不();
            if((1904674096 & 1) == 0)
            {
                goto label_5;
            }
            
            Rilisoft.GameEventData val_4 = val_15.丁专丗万三上丟三丆();
            if((val_4.EndDate & 1) == 0)
            {
                goto label_9;
            }
            
            Rilisoft.GameEventData val_5 = val_15.丁专丗万三上丟三丆();
            if((val_5.StartDate & 1) == 0)
            {
                goto label_9;
            }
            
            Rilisoft.GameEventData val_6 = val_15.丁专丗万三上丟三丆();
            Rilisoft.GameEventData val_7 = val_15.丁专丗万三上丟三丆();
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_6.EndDate}, d2:  new System.DateTime() {dateData = val_7.StartDate});
            long val_9 = val_8._ticks.System.IConvertible.ToInt64(provider:  0);
            System.TimeSpan val_12 = System.TimeSpan.FromTicks(value:  ((val_9 < 0) ? (val_9 + 1) : (val_9)) >> 1);
            val_15 = val_12._ticks;
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = 1152921540871259440}, t2:  new System.TimeSpan() {_ticks = val_15})) == false)
            {
                goto label_16;
            }
            
            val_16 = null;
            val_16 = null;
            goto label_21;
            label_5:
            val_15 = 1152921504624898048;
            val_16 = null;
            val_16 = null;
            label_21:
            val_17 = System.TimeSpan.Zero;
            return (System.TimeSpan)val_14._ticks;
            label_9:
            System.TimeSpan val_14 = System.TimeSpan.FromSeconds(value:  0);
            return (System.TimeSpan)val_14._ticks;
            label_16:
            return (System.TimeSpan)val_14._ticks;
        }
        private System.TimeSpan 七与且丘七丄世一下()
        {
            System.TimeSpan val_8;
            System.TimeSpan val_9;
            var val_10;
            Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            if(val_2 == null)
            {
                goto label_5;
            }
            
            System.Nullable<System.TimeSpan> val_3 = val_2.丙世丑丅丒丑业与不();
            val_8 = 1152921516341017568;
            if((1904822960 & 1) == 0)
            {
                goto label_5;
            }
            
            System.TimeSpan val_4 = System.TimeSpan.FromDays(value:  1);
            if(( & 1) == 0)
            {
                goto label_11;
            }
            
            val_8 = System.TimeSpan.Zero;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_3.HasValue.丐丏七丌丕丗业且上()}, t2:  new System.TimeSpan() {_ticks = val_8})) == false)
            {
                goto label_11;
            }
            
            return val_9;
            label_5:
            val_8 = 1152921504624898048;
            val_10 = null;
            val_10 = null;
            goto label_17;
            label_11:
            val_10 = null;
            val_10 = null;
            label_17:
            val_9 = System.TimeSpan.Zero;
            return val_9;
        }
        public 上丏丞丒丌丅丘丏丞()
        {
            val_1 = new System.Object();
        }
    
    }

}
