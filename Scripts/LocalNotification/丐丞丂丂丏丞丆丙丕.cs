using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丐丞丂丂丏丞丆丙丕 : 专丐丛东丄专万下丏
    {
        // Fields
        private const int 丂丘上东丏丛不与丐 = 2;
        private System.Collections.Generic.List<int> 三下丂与东丅丈丗丐;
        
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            string val_3;
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540874640760] = val_1;
            val_3 = "Discount";
            .下丄丈不与世丐业专 = val_3;
            if(val_1 == null)
            {
                    val_3 = "Discount";
            }
            
            val_1.set_Item(key:  val_3, value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        internal override System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> 丘丟万三丂丂丂丕丄(PGCompany.DataObjects.丆丏丛丝丈三七丗东 丂丗下世三丞丁丏且)
        {
            var val_9;
            var val_10;
            var val_11;
            if((ContainsKey(key:  丂丗下世三丞丁丏且.Id)) == false)
            {
                goto label_3;
            }
            
            val_9 = this.丁东七丘一丟与丘一();
            val_10 = val_9.Count;
            System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> val_4 = null;
            val_11 = val_4;
            val_4 = new System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>();
            if(val_10 == 0)
            {
                    return (System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>)val_11;
            }
            
            val_10 = 0;
            goto label_6;
            label_11:
            System.TimeSpan val_5 = val_9.Item[0];
            LocalNotification.丝东上丅丟一东丗丗 val_6 = this.丘丟万三丂丂丂丕丄(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_5._ticks});
            if(val_6 != null)
            {
                    val_4.Add(item:  val_6);
            }
            
            val_10 = 1;
            label_6:
            if(val_10 < val_9.Count)
            {
                goto label_11;
            }
            
            return (System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>)val_11;
            label_3:
            System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> val_8 = null;
            val_11 = val_8;
            val_8 = new System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>();
            return (System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>)val_11;
        }
        private System.Collections.Generic.List<System.TimeSpan> 丁东七丘一丟与丘一()
        {
            var val_15;
            System.Collections.Generic.List<System.TimeSpan> val_1 = new System.Collections.Generic.List<System.TimeSpan>();
            val_15 = 0;
            goto label_1;
            label_14:
            if(val_1.Count > 2)
            {
                    return val_1;
            }
            
            var val_16 = this.三下丂与东丅丈丗丐.Item[0];
            System.DateTime val_4 = System.DateTime.Now;
            var val_15 = val_4.dateData.DayOfWeek;
            int val_6 = val_16 + 1;
            val_15 = val_6 - val_15;
            val_6 = val_15 + 7;
            val_16 = (val_15 > 0) ? (val_15) : (val_6);
            System.TimeSpan val_7 = System.TimeSpan.FromHours(value:  12);
            System.DateTime val_8 = System.DateTime.Now;
            System.TimeSpan val_9 = val_8.dateData.TimeOfDay;
            System.TimeSpan val_11 = System.TimeSpan.FromSeconds(value:  val_9._ticks.TotalSeconds);
            System.TimeSpan val_12 = System.TimeSpan.FromDays(value:  (double)val_16);
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = 1152921540874931480}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != true)
            {
                    val_1.Add(item:  new System.TimeSpan() {_ticks = val_7._ticks});
            }
            
            val_15 = 1;
            label_1:
            if(val_15 < this.三下丂与东丅丈丗丐.Count)
            {
                goto label_14;
            }
            
            return val_1;
        }
        public 丐丞丂丂丏丞丆丙丕()
        {
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(val_1 != null)
            {
                    val_1.Add(item:  2);
            }
            else
            {
                    val_1.Add(item:  2);
            }
            
            val_1.Add(item:  5);
            this.三下丂与东丅丈丗丐 = val_1;
            this = new System.Object();
        }
    
    }

}
