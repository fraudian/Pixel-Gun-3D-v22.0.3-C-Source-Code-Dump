using UnityEngine;

namespace Progress
{
    internal sealed class 丏丄三东不世丞业一 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        internal Progress.丏丄三东不世丞业一.且三三丂上三丏一三 且丈丘七丐下专东丁;
        internal 丙丒七丗世不不丙丙 丁丅世丌丐业丐丅业;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 45;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 丘上丐世丆丑且丞丒()
        {
            this.且丈丘七丐下专东丁 = new 丏丄三东不世丞业一.且三三丂上三丏一三();
            this.丁丅世丌丐业丐丅业 = new 丙丒七丗世不不丙丙();
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丏丄三东不世丞业一.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丏丄三东不世丞业一.丐丌丞上世丛丐丏丛;
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            this.且丈丘七丐下专东丁 = this.丁丅世丌丐业丐丅业.三丆丁丙与万丑丕丗(一丐丗丁丞丆丅丟丄:  (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            if(this.丁丅世丌丐业丐丅业 != null)
            {
                    return this.丁丅世丌丐业丐丅业.丈万上丙丝丂丑丄丂(专丞丙一丟专丞与丗:  this.且丈丘七丐下专东丁);
            }
            
            return this.丁丅世丌丐业丐丅业.丈万上丙丝丂丑丄丂(专丞丙一丟专丞与丗:  this.且丈丘七丐下专东丁);
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 与世丄万丈丈上丆下()
        {
            object val_26;
            int val_27;
            int val_28;
            var val_29;
            int val_30;
            int val_31;
            var val_32;
            且三三丂上三丏一三 val_33;
            decimal val_34;
            val_26 = this;
            val_27 = 0;
            val_28 = 0;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "keyGameTotalKills")) != false)
            {
                    val_29 = 0;
                decimal val_3 = System.Decimal.op_Implicit(value:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "keyGameTotalKills", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
                val_28 = val_3.flags;
                val_27 = val_3.lo;
            }
            
            val_30 = 0;
            val_31 = 0;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "keyGameDeath")) != false)
            {
                    val_29 = 0;
                decimal val_6 = System.Decimal.op_Implicit(value:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "keyGameDeath", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
                val_31 = val_6.flags;
                val_30 = val_6.lo;
            }
            
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_28, hi = val_3.hi, lo = val_27, mid = val_3.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_17;
            }
            
            this.且丈丘七丐下专东丁.丕上东七丘丙丆丟丒 = new KillRateObject(丞丗丄七专丈丕丕业:  new System.Decimal() {flags = val_28, hi = val_3.hi, lo = val_27, mid = val_3.mid}, 丗丁丈一丌丆一东三:  new System.Decimal() {flags = val_31, hi = val_6.hi, lo = val_30, mid = val_6.mid}, 丂丛丑东不丅丈一东:  100, 业东丞丏丒业万丏丘:  false);
            val_32 = null;
            val_33 = this.且丈丘七丐下专东丁;
            val_32 = null;
            val_34 = System.Decimal.Zero;
            this.且丈丘七丐下专东丁.下丌世丝丁上丗七丗 = new KillRateObject(丞丗丄七专丈丕丕业:  new System.Decimal() {flags = val_34, hi = val_34, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丗丁丈一丌丆一东三:  new System.Decimal() {flags = val_34, hi = val_34, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丂丛丑东不丅丈一东:  100, 业东丞丏丒业万丏丘:  false);
            if(this.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且 != null)
            {
                    if(this.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count > 0)
            {
                goto label_26;
            }
            
            }
            
            decimal val_11 = System.Math.Round(d:  new System.Decimal() {flags = val_28, hi = val_3.hi, lo = val_27, mid = val_3.mid}, decimals:  2);
            val_28 = val_11.lo;
            decimal val_12 = System.Math.Round(d:  new System.Decimal() {flags = val_31, hi = val_6.hi, lo = val_30, mid = val_6.mid}, decimals:  2);
            val_31 = val_12.lo;
            KillrateController val_13 = Rilisoft.Singleton<KillrateController>.Instance;
            this.丒丞丝丑上万丑丒丈(丂丌丙丝且东丗丙万:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_28, mid = val_11.mid}, 丒丒丏丗丁丛丅七丙:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_31, mid = val_12.mid}, 一丑丗三一丛一丄业:  val_13.丏丐一七丑下丘丌且);
            label_26:
            Progress.丏丄三东不世丞业一.三七东丘上下丏丘下();
            return;
            label_17:
            decimal val_14 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = val_28, hi = val_3.hi, lo = val_27, mid = val_3.mid}, d2:  new System.Decimal() {flags = val_31, hi = val_6.hi, lo = val_30, mid = val_6.mid});
            decimal val_15 = System.Decimal.op_Division(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_14.flags, hi = val_14.hi, lo = val_14.lo, mid = val_14.mid});
            decimal val_16 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_28, hi = val_3.hi, lo = val_27, mid = val_3.mid}, d2:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.mid});
            val_28 = val_16.flags;
            decimal val_17 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_31, hi = val_6.hi, lo = val_30, mid = val_6.mid}, d2:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.mid});
            val_33 = 1152921505224470528;
            this.且丈丘七丐下专东丁.丕上东七丘丙丆丟丒 = new KillRateObject(丞丗丄七专丈丕丕业:  new System.Decimal() {flags = val_28, hi = val_16.hi, lo = val_16.lo, mid = val_16.mid}, 丗丁丈一丌丆一东三:  new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid}, 丂丛丑东不丅丈一东:  100, 业东丞丏丒业万丏丘:  false);
            val_34 = System.Decimal.Zero;
            this.且丈丘七丐下专东丁.下丌世丝丁上丗七丗 = new KillRateObject(丞丗丄七专丈丕丕业:  new System.Decimal() {flags = val_34, hi = val_34, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丗丁丈一丌丆一东三:  new System.Decimal() {flags = val_34, hi = val_34, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丂丛丑东不丅丈一东:  100, 业东丞丏丒业万丏丘:  false);
            if(this.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且 == null)
            {
                goto label_38;
            }
            
            val_31 = this.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且;
            if(val_31.Count > 0)
            {
                goto label_41;
            }
            
            label_38:
            decimal val_21 = System.Math.Round(d:  new System.Decimal() {flags = val_28, hi = val_16.hi, lo = val_16.lo, mid = val_16.mid}, decimals:  2);
            val_28 = val_21.flags;
            val_31 = val_21.lo;
            decimal val_22 = System.Math.Round(d:  new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid}, decimals:  2);
            KillrateController val_23 = Rilisoft.Singleton<KillrateController>.Instance;
            this.丒丞丝丑上万丑丒丈(丂丌丙丝且东丗丙万:  new System.Decimal() {flags = val_28, hi = val_21.hi, lo = val_31, mid = val_21.mid}, 丒丒丏丗丁丛丅七丙:  new System.Decimal() {flags = val_22.flags, hi = val_22.hi, lo = val_22.lo, mid = val_22.mid}, 一丑丗三一丛一丄业:  val_23.丏丐一七丑下丘丌且);
            label_41:
            Progress.丏丄三东不世丞业一.三七东丘上下丏丘下();
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
            object[] val_25 = new object[1];
            val_26 = val_26;
            val_25[0] = val_26;
            UnityEngine.Debug.LogFormat(format:  "[BRV] MigrateFromLegacyData. Slot =-=-= {0}", args:  val_25);
        }
        internal void 丒丞丝丑上万丑丒丈(decimal 丂丌丙丝且东丗丙万, decimal 丒丒丏丗丁丛丅七丙, int 一丑丗三一丛一丄业)
        {
            System.Collections.Generic.List<KillRateObject> val_8;
            int val_9 = 一丑丗三一丛一丄业;
            decimal val_1 = System.Decimal.op_Implicit(value:  val_9 = 一丑丗三一丛一丄业);
            decimal val_2 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 丂丌丙丝且东丗丙万.flags, hi = 丂丌丙丝且东丗丙万.hi, lo = 丂丌丙丝且东丗丙万.lo, mid = 丂丌丙丝且东丗丙万.mid}, d2:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid});
            decimal val_3 = System.Math.Round(d:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid}, decimals:  2);
            decimal val_4 = System.Decimal.op_Implicit(value:  val_9);
            decimal val_5 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 丒丒丏丗丁丛丅七丙.flags, hi = 丒丒丏丗丁丛丅七丙.hi, lo = 丒丒丏丗丁丛丅七丙.lo, mid = 丒丒丏丗丁丛丅七丙.mid}, d2:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
            decimal val_6 = System.Math.Round(d:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, decimals:  2);
            if(val_9 < 1)
            {
                    return;
            }
            
            do
            {
                val_8 = this.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且;
                val_8.Add(item:  new KillRateObject(丞丗丄七专丈丕丕业:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, 丗丁丈一丌丆一东三:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, 丂丛丑东不丅丈一东:  2, 业东丞丏丒业万丏丘:  false));
                val_9 = val_9 - 1;
            }
            while(val_9 != 0);
        
        }
        internal bool 上丝丅丅丄丕丂一丆(decimal 丂丌丙丝且东丗丙万, decimal 丒丒丏丗丁丛丅七丙, Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, bool 业东丞丏丒业万丏丘)
        {
            if(丂丛丑东不丅丈一东 != 20)
            {
                    if(丂丛丑东不丅丈一东 != 3)
            {
                goto label_2;
            }
            
            }
            
            this.且丈丘七丐下专东丁.下丌世丝丁上丗七丗.一丆一专丆丛专丘丌(丙业与丙丗丝不丈东:  new System.Decimal() {flags = 丂丌丙丝且东丗丙万.flags, hi = 丂丌丙丝且东丗丙万.hi, lo = 丂丌丙丝且东丗丙万.lo, mid = 丂丌丙丝且东丗丙万.mid});
            this.且丈丘七丐下专东丁.下丌世丝丁上丗七丗.丗下丞七丐一丐一丛(丙业与丙丗丝不丈东:  new System.Decimal() {flags = 丒丒丏丗丁丛丅七丙.flags, hi = 丒丒丏丗丁丛丅七丙.hi, lo = 丒丒丏丗丁丛丅七丙.lo, mid = 丒丒丏丗丁丛丅七丙.mid});
            return true;
            label_2:
            this.且丈丘七丐下专东丁.丕上东七丘丙丆丟丒.一丆一专丆丛专丘丌(丙业与丙丗丝不丈东:  new System.Decimal() {flags = 丂丌丙丝且东丗丙万.flags, hi = 丂丌丙丝且东丗丙万.hi, lo = 丂丌丙丝且东丗丙万.lo, mid = 丂丌丙丝且东丗丙万.mid});
            this.且丈丘七丐下专东丁.丕上东七丘丙丆丟丒.丗下丞七丐一丐一丛(丙业与丙丗丝不丈东:  new System.Decimal() {flags = 丒丒丏丗丁丛丅七丙.flags, hi = 丒丒丏丗丁丛丅七丙.hi, lo = 丒丒丏丗丁丛丅七丙.lo, mid = 丒丒丏丗丁丛丅七丙.mid});
            KillRateObject val_1 = null;
            业东丞丏丒业万丏丘 = 业东丞丏丒业万丏丘;
            val_1 = new KillRateObject(丞丗丄七专丈丕丕业:  new System.Decimal() {flags = 丂丌丙丝且东丗丙万.flags, hi = 丂丌丙丝且东丗丙万.hi, lo = 丂丌丙丝且东丗丙万.lo, mid = 丂丌丙丝且东丗丙万.mid}, 丗丁丈一丌丆一东三:  new System.Decimal() {flags = 丒丒丏丗丁丛丅七丙.flags, hi = 丒丒丏丗丁丛丅七丙.hi, lo = 丒丒丏丗丁丛丅七丙.lo, mid = 丒丒丏丗丁丛丅七丙.mid}, 丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 业东丞丏丒业万丏丘:  业东丞丏丒业万丏丘);
            this.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Add(item:  val_1);
            if(this.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count < 31)
            {
                    return true;
            }
            
            this.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.RemoveAt(index:  0);
            return true;
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.且丈丘七丐下专东丁 = new 丏丄三东不世丞业一.且三三丂上三丏一三();
        }
        public 丏丄三东不世丞业一()
        {
        
        }
        private static 丏丄三东不世丞业一()
        {
            Progress.丏丄三东不世丞业一.丕丟一七丑丙丂丆丙 = "kill_rate_slot";
            Progress.丏丄三东不世丞业一.丐丌丞上世丛丐丏丛 = "kill_rate_slot_key";
        }
        internal static void 三七东丘上下丏丘下()
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "keyGameTotalKills", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "keyGameDeath", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
    
    }

}
