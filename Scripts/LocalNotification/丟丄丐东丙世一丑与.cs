using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丟丄丐东丙世一丑与 : 专丐丛东丄专万下丏
    {
        // Properties
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        protected override void 丗七且下上丐世丛且()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540884734616] = val_1;
            .下丄丈不与世丐业专 = "RewardedVideoAvailable";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丟丄丐东丙世一丑与::且专东三与丄丈万丁());
            val_1.set_Item(key:  "RewardedVideoAvailable", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            .下丄丈不与世丐业专 = "RewardedVideoForNovice";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丟丄丐东丙世一丑与::丏丄丂丙丁丘三丟丅());
            val_1.set_Item(key:  "RewardedVideoForNovice", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        private System.TimeSpan 且专东三与丄丈万丁()
        {
            丕丄丘不专丘七专与 val_15;
            var val_16;
            var val_17;
            long val_18;
            var val_19;
            string val_2 = 0;
            丕丄丘不专丘七专与 val_4 = 0;
            丅丒不上七丘万丙一 val_3 = 0;
            if((PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  val_2, 丟丐丗万丅下丗丝万: out  val_3, 丌东丙丝丂一丅三丞: out  val_4, 丏丞专丏业丗丝七丝: out  0)) != false)
            {
                    val_15 = val_4;
                System.TimeSpan val_8 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().业丞不上丞丛三与万(丅专与丒丈丗丒丘丌:  val_2, 丟丐丗万丅下丗丝万:  val_3, 丌东丙丝丂一丅三丞:  val_15);
                val_16 = null;
                val_16 = null;
                if((System.TimeSpan.op_Equality(t1:  new System.TimeSpan() {_ticks = val_8._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.MaxValue})) != true)
            {
                    System.DateTime val_10 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.丝丞且丈东丅丟丏与(丅专与丒丈丗丒丘丌:  val_2);
                val_15 = val_10.dateData;
                System.DateTime val_11 = PGCompany.且世万丐七丆丛丄丌.丒丌丟业丂丌丈丕丒();
                System.DateTime val_12 = PGCompany.万下丂且东丌一丌丆.万下专丒丞丒丘与丐(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_15}, 丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_8._ticks});
                System.TimeSpan val_13 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_12.dateData}, d2:  new System.DateTime() {dateData = val_11.dateData});
                val_17 = null;
                val_18 = val_13._ticks;
                val_17 = null;
                if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_18}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return val_18;
            }
            
            }
            
                val_19 = null;
            }
            else
            {
                    val_19 = null;
            }
            
            val_18 = System.TimeSpan.Zero;
            return val_18;
        }
        private System.TimeSpan 丏丄丂丙丁丘三丟丅()
        {
            object val_9;
            var val_10;
            string val_1 = 0;
            bool val_3 = LocalNotification.丟丄丐东丙世一丑与.世丈且业丆丑丏丐一();
            if((this.与丅三丟一丐丒丌丁(丙业与丙丗丝不丈东: out  new System.TimeSpan(), 丏丞专丏业丗丝七丝: out  val_1)) == false)
            {
                goto label_1;
            }
            
            if(val_3 == false)
            {
                    return (System.TimeSpan)0;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_1)) == false)
            {
                goto label_3;
            }
            
            string val_5 = "[LocalNotificationScheduleVideoRewards.GetTimeForRewardedVideoForNoviceAvailable] value: "("[LocalNotificationScheduleVideoRewards.GetTimeForRewardedVideoForNoviceAvailable] value: ") + 0;
            goto label_4;
            label_1:
            if(val_3 == false)
            {
                    return (System.TimeSpan)0;
            }
            
            val_9 = "[LocalNotificationScheduleVideoRewards.GetTimeForRewardedVideoForNoviceAvailable] TryGetTimeSpanForNovice: false. "("[LocalNotificationScheduleVideoRewards.GetTimeForRewardedVideoForNoviceAvailable] TryGetTimeSpanForNovice: false. ") + val_1;
            val_10 = null;
            goto label_8;
            label_3:
            label_4:
            val_9 = "[LocalNotificationScheduleVideoRewards.GetTimeForRewardedVideoForNoviceAvailable] value: "("[LocalNotificationScheduleVideoRewards.GetTimeForRewardedVideoForNoviceAvailable] value: ") + 0 + ". " + val_1;
            val_10 = null;
            label_8:
            UnityEngine.Debug.Log(message:  val_9);
            return (System.TimeSpan)0;
        }
        private bool 与丅三丟一丐丒丌丁(out System.TimeSpan 丙业与丙丗丝不丈东, out string 丏丞专丏业丗丝七丝)
        {
            var val_29;
            long val_30;
            ulong val_31;
            var val_32;
            string val_33;
            var val_34;
            var val_35;
            string val_5 = 0;
            val_29 = null;
            val_29 = null;
            丙业与丙丗丝不丈东._ticks = System.TimeSpan.Zero;
            val_30 = PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世();
            if((val_30.丄业丐丟丙万不世丈(丏丞专丏业丗丝七丝: out  string val_2 = 丏丞专丏业丗丝七丝)) == true)
            {
                goto label_8;
            }
            
            val_30 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世();
            if((val_30.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  val_5, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_2)) == false)
            {
                goto label_8;
            }
            
            if((System.String.Equals(a:  val_5, b:  "chestInLobbyNovice", comparisonType:  4)) == false)
            {
                goto label_9;
            }
            
            System.TimeSpan val_10 = PGCompany.Ads.丅七丘丂与丆丛专丅.业丞不上丞丛三与万(丐不丏不丏丐不丅丒:  new System.Nullable<System.Single>() {HasValue = false});
            val_30 = val_10._ticks;
            System.DateTime val_11 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.丝丞且丈东丅丟丏与(丅专与丒丈丗丒丘丌:  val_5);
            System.DateTime val_12 = PGCompany.万下丂且东丌一丌丆.万下专丒丞丒丘与丐(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_11.dateData}, 丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_30});
            val_31 = val_12.dateData;
            val_32 = null;
            val_32 = null;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_31}, d2:  new System.DateTime() {dateData = System.DateTime.MaxValue})) == false)
            {
                goto label_17;
            }
            
            val_33 = "DateTime.MaxValue";
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_33 = "TimeSpan.Zero", 丄丙下丝丛丒七丂丘: out  val_2);
            label_8:
            val_34 = 0;
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_33, 丄丙下丝丛丒七丂丘: out  val_2);
            label_9:
            val_34 = val_5;
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_33, 丄丙下丝丛丒七丂丘: out  val_2);
            label_17:
            System.DateTime val_14 = PGCompany.且世万丐七丆丛丄丌.丒丌丟业丂丌丈丕丒();
            val_31 = val_14.dateData;
            System.DateTime val_15 = PGCompany.万下丂且东丌一丌丆.万下专丒丞丒丘与丐(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_11.dateData}, 丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_30});
            System.TimeSpan val_16 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_15.dateData}, d2:  new System.DateTime() {dateData = val_31});
            val_30 = val_16._ticks;
            System.TimeSpan val_17 = System.TimeSpan.FromHours(value:  1);
            System.TimeSpan val_18 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = val_30}, t2:  new System.TimeSpan() {_ticks = val_17._ticks});
            丙业与丙丗丝不丈东._ticks = val_18._ticks;
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_18._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
            {
                    return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_33, 丄丙下丝丛丒七丂丘: out  val_2);
            }
            
            System.DateTime val_22 = System.DateTime.Now;
            if((LocalNotification.不丑世丞丕丄不丄丈.万丆丝丂且丆三丈丅(不丗万丘丆丗上丗丏:  new System.DateTime() {})) == false)
            {
                    return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_33, 丄丙下丝丛丒七丂丘: out  val_2);
            }
            
            System.DateTime val_24 = LocalNotification.不丑世丞丕丄不丄丈.下三七丌专三丗丂上(不丗万丘丆丗上丗丏:  new System.DateTime() {});
            System.DateTime val_25 = val_24.dateData.AddMinutes(value:  -1);
            System.DateTime val_26 = System.DateTime.Now;
            System.TimeSpan val_27 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_25.dateData}, d2:  new System.DateTime() {dateData = val_26.dateData});
            丙业与丙丗丝不丈东._ticks = val_27._ticks;
            val_35 = null;
            val_35 = null;
            if((System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_27._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == false)
            {
                    return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_33, 丄丙下丝丛丒七丂丘: out  val_2);
            }
            
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_33, 丄丙下丝丛丒七丂丘: out  val_2);
        }
        public 丟丄丐东丙世一丑与()
        {
            val_1 = new System.Object();
        }
    
    }

}
