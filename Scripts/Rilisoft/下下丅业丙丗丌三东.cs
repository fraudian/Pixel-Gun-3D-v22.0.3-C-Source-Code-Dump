using UnityEngine;

namespace Rilisoft
{
    internal sealed class 下下丅业丙丗丌三东
    {
        // Fields
        private const int 与与丛丞丝丛丅丟丟 = 3;
        private static readonly Rilisoft.下下丅业丙丗丌三东 下东专丂丑丙丞丒丝;
        private static readonly System.Collections.Generic.List<Rilisoft.LocalNotificationKind> 丑丑丂丛一丌专丄丝;
        private static readonly System.TimeSpan 三与丐专丒不丏与丙;
        private static readonly System.TimeSpan 专世丂丁上丟专丐七;
        private readonly System.Nullable<int> 丙三七世专丙不丝与;
        private readonly System.Nullable<System.TimeSpan> 专东丝丙丂丌一七万;
        private readonly System.Nullable<System.TimeSpan> 丟下上丗丆丆丏丗丌;
        private readonly System.Collections.Generic.List<Rilisoft.LocalNotificationKind> 丙丕丈丏且一丗丗专;
        private System.Collections.Generic.Dictionary<Rilisoft.LocalNotificationKind, int> 三丌丟丛丛丐东七东;
        
        // Properties
        internal static Rilisoft.下下丅业丙丗丌三东 万丝上三丈下丌业与 { get; }
        internal System.TimeSpan 丕业丅丅与世丝丙丗 { get; }
        internal System.TimeSpan 丈丂东世丟上丅丒丈 { get; }
        internal int 丞丟丝丟丗丘丏东世 { get; }
        
        // Methods
        private 下下丅业丙丗丌三东()
        {
            this.三丌丟丛丛丐东七东 = 0;
            mem[1152921543177546224] = 0;
            mem[1152921543177546240] = 0;
            this.丙三七世专丙不丝与 = 0;
        }
        private 下下丅业丙丗丌三东(System.Nullable<System.TimeSpan> 丂专丐丁丌丕丗七丞, System.Nullable<System.TimeSpan> 不丏丑丌与专丕一业, System.Nullable<int> 专丈丗丛丘丟世丞丐, System.Collections.Generic.List<Rilisoft.LocalNotificationKind> 且万丌丂丈世丅丑丕, System.Collections.Generic.Dictionary<Rilisoft.LocalNotificationKind, int> 丞丑不丂丗下一丘丂)
        {
            val_1 = new System.Object();
            mem[1152921543177666416] = val_1;
            this.丟下上丗丆丆丏丗丌 = 丂专丐丁丌丕丗七丞;
            this.丙三七世专丙不丝与 = 丞丑不丂丗下一丘丂;
            this.专东丝丙丂丌一七万 = 专丈丗丛丘丟世丞丐.HasValue;
            mem[1152921543177666432] = 不丏丑丌与专丕一业.HasValue;
            this.丙丕丈丏且一丗丗专 = X6;
            this.三丌丟丛丛丐东七东 = X7;
        }
        internal static Rilisoft.下下丅业丙丗丌三东 丟一丞丝丑七丈与丝()
        {
            null = null;
            return (Rilisoft.下下丅业丙丗丌三东)Rilisoft.下下丅业丙丗丌三东.下东专丂丑丙丞丒丝;
        }
        internal System.TimeSpan 东丗丁万且东丄丙与()
        {
            null = null;
            return (System.TimeSpan)Rilisoft.下下丅业丙丗丌三东.三与丐专丒不丏与丙;
        }
        internal System.TimeSpan 下与丅且丝万且丁丂()
        {
            null = null;
            return (System.TimeSpan)Rilisoft.下下丅业丙丗丌三东.专世丂丁上丟专丐七;
        }
        internal int 专丈丅东丕七业丁七()
        {
            System.Nullable<System.Int32> val_5 = this.丙三七世专丙不丝与;
            if((val_5 & 1) == 0)
            {
                    return 3;
            }
            
            val_5 = ???;
            return 3;
        }
        internal static System.Collections.Generic.List<Rilisoft.LocalNotificationKind> 丅且丞万丆上丆上丗()
        {
            null = null;
            return (System.Collections.Generic.List<Rilisoft.LocalNotificationKind>)Rilisoft.下下丅业丙丗丌三东.丑丑丂丛一丌专丄丝;
        }
        internal System.Collections.Generic.List<Rilisoft.LocalNotificationKind> 一丘丈一丄与丏丏上()
        {
            if(this.丙丕丈丏且一丗丗专 == null)
            {
                    return Rilisoft.下下丅业丙丗丌三东.丅且丞万丆上丆上丗();
            }
            
            return (System.Collections.Generic.List<Rilisoft.LocalNotificationKind>)this.丙丕丈丏且一丗丗专;
        }
        internal bool 丙东东丒丗不丂丅丗(Rilisoft.LocalNotificationKind 丛专下下丟不与万丘, out int 东且丁丆丛丁丏丘且)
        {
            var val_7;
            int val_8 = 1152921543178545792;
            if(this.三丌丟丛丛丐东七东 != null)
            {
                    return 0.TryGetValue(key:  丛专下下丟不与万丘, value: out  val_8 = val_8);
            }
            
            this.三丌丟丛丛丐东七东 = new System.Collections.Generic.Dictionary<Rilisoft.LocalNotificationKind, System.Int32>();
            System.Collections.Generic.List<Rilisoft.LocalNotificationKind> val_2 = this.一丘丈一丄与丏丏上();
            int val_3 = val_2.Count;
            if(val_3 != 0)
            {
                    val_7 = 1152921543178467264;
                var val_7 = 0;
                do
            {
                Rilisoft.LocalNotificationKind val_4 = val_2.Item[0];
                if((this.三丌丟丛丛丐东七东.ContainsKey(key:  val_4)) != true)
            {
                    this.三丌丟丛丛丐东七东.Add(key:  val_4, value:  0);
            }
            
                val_7 = val_7 + 1;
            }
            while(val_3 != val_7);
            
            }
            
            return 0.TryGetValue(key:  丛专下下丟不与万丘, value: out  val_8);
        }
        internal System.Nullable<int> 东下业丅万下丗丙上(Rilisoft.LocalNotificationKind 丛专下下丟不与万丘)
        {
            var val_3;
            if((this.丙东东丒丗不丂丅丗(丛专下下丟不与万丘:  丛专下下丟不与万丘, 东且丁丆丛丁丏丘且: out  0)) != false)
            {
                    val_3 = 0;
                return (System.Nullable<System.Int32>)val_3;
            }
            
            val_3 = 0;
            return (System.Nullable<System.Int32>)val_3;
        }
        internal static Rilisoft.下下丅业丙丗丌三东 东丝七业丄丑丒世七(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑)
        {
            var val_17;
            bool val_18;
            var val_19;
            bool val_20;
            var val_21;
            System.Collections.Generic.Dictionary<Rilisoft.LocalNotificationKind, System.Int32> val_22;
            System.Collections.Generic.List<Rilisoft.LocalNotificationKind> val_23;
            var val_24;
            val_17 = 1152921505473298432;
            System.Collections.Generic.List<System.Object> val_4 = 0;
            if(万丝且丘不丑丝下丑 == null)
            {
                goto label_1;
            }
            
            System.Nullable<System.TimeSpan> val_1 = Rilisoft.下下丅业丙丗丌三东.丘丑丑丛丕丕丐与万(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  "nightStart");
            val_18 = val_1.HasValue;
            val_19 = "nightStart";
            System.Nullable<System.TimeSpan> val_2 = Rilisoft.下下丅业丙丗丌三东.丘丑丑丛丕丕丐与万(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  "nightEnd");
            val_20 = val_2.HasValue;
            val_21 = "nightEnd";
            System.Nullable<System.Int32> val_3 = Rilisoft.下下丅业丙丗丌三东.丄丛丂与丝丗丏业丑(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  "maxDailyNotificationCount");
            val_22 = 0;
            val_23 = val_22;
            if((val_4 == 0) || ((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  "notificationsOrderedByPriority", 丙业与丙丗丝不丈东: out  val_4)) == false))
            {
                goto label_9;
            }
            
            System.Collections.Generic.List<Rilisoft.LocalNotificationKind> val_6 = null;
            val_23 = val_6;
            val_6 = new System.Collections.Generic.List<Rilisoft.LocalNotificationKind>();
            System.Collections.Generic.Dictionary<Rilisoft.LocalNotificationKind, System.Int32> val_7 = null;
            val_22 = val_7;
            val_7 = new System.Collections.Generic.Dictionary<Rilisoft.LocalNotificationKind, System.Int32>();
            if(val_4.Count == 0)
            {
                goto label_9;
            }
            
            var val_17 = 0;
            goto label_41;
            label_1:
            Rilisoft.下下丅业丙丗丌三东 val_9 = null;
            val_24 = val_9;
            val_9 = new Rilisoft.下下丅业丙丗丌三东();
            .三丌丟丛丛丐东七东 = 0;
            mem[1152921543178862480] = 0;
            mem[1152921543178862496] = 0;
            .丙三七世专丙不丝与 = 0;
            return (Rilisoft.下下丅业丙丗丌三东)val_24;
            label_9:
            Rilisoft.下下丅业丙丗丌三东 val_16 = null;
            val_24 = val_16;
            val_16 = new Rilisoft.下下丅业丙丗丌三东();
            mem[1152921543178882976] = ;
            .丟下上丗丆丆丏丗丌 = val_1;
            .丙三七世专丙不丝与 = val_3;
            .专东丝丙丂丌一七万 = val_2;
            mem[1152921543178882992] = ;
            .丙丕丈丏且一丗丗专 = val_23;
            .三丌丟丛丛丐东七东 = val_22;
            return (Rilisoft.下下丅业丙丗丌三东)val_24;
        }
        private static System.Nullable<int> 丄丛丂与丝丗丏业丑(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不)
        {
            var val_4;
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_4 = 0;
                return (System.Nullable<System.Int32>)val_4;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = 下上丐丆丝丟丝丒不;
            UnityEngine.Debug.LogWarningFormat(format:  "Failed to find Int32 key: `{0}`", args:  val_3);
            val_4 = 0;
            return (System.Nullable<System.Int32>)val_4;
        }
        private static System.Nullable<System.TimeSpan> 丘丑丑丛丕丕丐与万(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不)
        {
            System.Object[] val_8;
            string val_9;
            int val_1 = System.String.alignConst;
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东: out  val_1)) == false)
            {
                goto label_3;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_1)) == false)
            {
                goto label_4;
            }
            
            val_8 = new object[1];
            val_8[0] = 下上丐丆丝丟丝丒不;
            val_9 = "`{0}` is null or empty.";
            goto label_31;
            label_3:
            object[] val_5 = new object[1];
            val_8 = val_5;
            val_8[0] = 下上丐丆丝丟丝丒不;
            val_9 = "Failed to find key: `{0}`";
            label_31:
            UnityEngine.Debug.LogWarningFormat(format:  val_9, args:  val_5);
            return 0;
            label_4:
            if((System.TimeSpan.TryParse(s:  val_1, result: out  new System.TimeSpan())) != false)
            {
                    return 0;
            }
            
            object[] val_7 = new object[2];
            val_7[0] = 下上丐丆丝丟丝丒不;
            val_7[1] = val_1;
            goto label_31;
        }
        private static 下下丅业丙丗丌三东()
        {
            .三丌丟丛丛丐东七东 = 0;
            mem[1152921543179297456] = 0;
            mem[1152921543179297472] = 0;
            .丙三七世专丙不丝与 = 0;
            Rilisoft.下下丅业丙丗丌三东.下东专丂丑丙丞丒丝 = new Rilisoft.下下丅业丙丗丌三东();
            System.Collections.Generic.List<Rilisoft.LocalNotificationKind> val_2 = new System.Collections.Generic.List<Rilisoft.LocalNotificationKind>();
            if(val_2 != null)
            {
                    val_2.Add(item:  31);
                val_2.Add(item:  26);
                val_2.Add(item:  24);
                val_2.Add(item:  21);
                val_2.Add(item:  25);
                val_2.Add(item:  3);
                val_2.Add(item:  15);
                val_2.Add(item:  28);
                val_2.Add(item:  30);
                val_2.Add(item:  29);
                val_2.Add(item:  23);
                val_2.Add(item:  22);
                val_2.Add(item:  18);
                val_2.Add(item:  20);
                val_2.Add(item:  19);
                val_2.Add(item:  13);
                val_2.Add(item:  14);
                val_2.Add(item:  6);
                val_2.Add(item:  16);
                val_2.Add(item:  17);
                val_2.Add(item:  4);
                val_2.Add(item:  5);
                val_2.Add(item:  27);
                val_2.Add(item:  9);
                val_2.Add(item:  8);
                val_2.Add(item:  2);
                val_2.Add(item:  7);
                val_2.Add(item:  10);
                val_2.Add(item:  12);
                val_2.Add(item:  1);
            }
            else
            {
                    val_2.Add(item:  31);
                val_2.Add(item:  26);
                val_2.Add(item:  24);
                val_2.Add(item:  21);
                val_2.Add(item:  25);
                val_2.Add(item:  3);
                val_2.Add(item:  15);
                val_2.Add(item:  28);
                val_2.Add(item:  30);
                val_2.Add(item:  29);
                val_2.Add(item:  23);
                val_2.Add(item:  22);
                val_2.Add(item:  18);
                val_2.Add(item:  20);
                val_2.Add(item:  19);
                val_2.Add(item:  13);
                val_2.Add(item:  14);
                val_2.Add(item:  6);
                val_2.Add(item:  16);
                val_2.Add(item:  17);
                val_2.Add(item:  4);
                val_2.Add(item:  5);
                val_2.Add(item:  27);
                val_2.Add(item:  9);
                val_2.Add(item:  8);
                val_2.Add(item:  2);
                val_2.Add(item:  7);
                val_2.Add(item:  10);
                val_2.Add(item:  12);
                val_2.Add(item:  1);
            }
            
            val_2.Add(item:  11);
            Rilisoft.下下丅业丙丗丌三东.丑丑丂丛一丌专丄丝 = val_2;
            System.TimeSpan val_3 = System.TimeSpan.FromHours(value:  23);
            Rilisoft.下下丅业丙丗丌三东.三与丐专丒不丏与丙 = val_3._ticks;
            System.TimeSpan val_4 = System.TimeSpan.FromHours(value:  8);
            Rilisoft.下下丅业丙丗丌三东.专世丂丁上丟专丐七 = val_4._ticks;
        }
    
    }

}
