using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丟东丛上丛业丕三丄 : 专丐丛东丄专万下丏
    {
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540870544264] = val_1;
            .下丄丈不与世丐业专 = "ChallengesUpdated";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丟东丛上丛业丕三丄::丘丒不不丌丘下丒一());
            val_1.set_Item(key:  "ChallengesUpdated", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        private System.TimeSpan 丘丒不不丌丘下丒一()
        {
            int val_15;
            var val_16;
            long val_17;
            var val_18;
            val_15 = Rilisoft.Singleton<BattlePassController>.Instance;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = val_15.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            if(val_2.丗丄上丑丑丅丐丒丌() == true)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            val_15 = BPChallengesController.丑七不且上丗丁一世().丒丑丅丑丕万丞丅丟() + 1;
            if((val_15 & 2147483648) != 0)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            System.Nullable<System.DateTime> val_7 = BPChallengesController.丑七不且上丗丁一世().丏万业丁一丆丛丗下(丟丒业且万上丁三丆:  val_15);
            val_15 = 1152921516340667232;
            if((1904087504 & 1) == 0)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            System.Nullable<System.DateTime> val_8 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(( & 1) == 0)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            System.DateTime val_9 = System.DateTime.SpecifyKind(value:  new System.DateTime() {}, kind:  1);
            System.Nullable<System.DateTime> val_10 = FriendsController.业丈丏丏丞丘丛丈丛();
            System.TimeSpan val_11 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_9.dateData}, d2:  new System.DateTime() {});
            val_16 = null;
            val_16 = null;
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_11._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
            {
                    System.TimeSpan val_13 = System.TimeSpan.FromDays(value:  1);
                val_17;
            }
            else
            {
                    val_17 = val_17;
            }
            
            val_18 = null;
            val_18 = null;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_17}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == false)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            return (System.TimeSpan)System.TimeSpan.Zero;
        }
        public 丟东丛上丛业丕三丄()
        {
            val_1 = new System.Object();
        }
    
    }

}
