using UnityEngine;

namespace LocalNotification
{
    internal sealed class 不丙丕丙丞丞丈丝丒 : 专丐丛东丄专万下丏
    {
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540882307400] = val_1;
            .下丄丈不与世丐业专 = "Subscription20_CollectReward";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.不丙丕丙丞丞丈丝丒::丌丈丞下丟丟丝丛七());
            val_1.set_Item(key:  "Subscription20_CollectReward", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        private System.TimeSpan 丌丈丞下丟丟丝丛七()
        {
            System.TimeSpan val_9;
            var val_10;
            if(PixelTime.丙丅丅业丟丁世丁丗() <= 0)
            {
                goto label_7;
            }
            
            Subscription20.丘丛不东丒丆丁丑丁 val_4 = Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().不专丈不丞上丌丟丏(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗());
            if(val_4 == null)
            {
                goto label_7;
            }
            
            System.TimeSpan val_7 = System.TimeSpan.FromSeconds(value:  (double)val_4.丐丛丒与丅丝丌世丆(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗()));
            val_9 = val_7._ticks;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_7._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return val_9;
            }
            
            val_10 = null;
            goto label_13;
            label_7:
            val_10 = null;
            label_13:
            val_9 = System.TimeSpan.Zero;
            return val_9;
        }
        public 不丙丕丙丞丞丈丝丒()
        {
            val_1 = new System.Object();
        }
    
    }

}
