using UnityEngine;

namespace Rilisoft.Offers
{
    internal abstract class 丛丝下且丟丈丞丈丗 : IDisposable
    {
        // Fields
        private System.Collections.Generic.List<System.Decimal> 丌丞丈不丆丝丈专丑;
        
        // Properties
        internal abstract Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丒三丝一上丙专丗丒 { get; }
        internal abstract System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丁丛丁丗丙万丐丈丁 { get; }
        internal abstract System.Collections.Generic.List<int> 丘丄世丅丄丕与丛丂 { get; }
        
        // Methods
        internal abstract Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 不业丙丒丂丞下丆丙(); // 0
        internal abstract System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丞丏上丘丈上万一七(); // 0
        internal abstract void 丐世丑与丏世丗丑上(bool 下丕丆世专丅丕丘世); // 0
        internal abstract System.Collections.Generic.List<int> 且一专丅丞丏七丙丟(); // 0
        internal 丛丝下且丟丈丞丈丗()
        {
        
        }
        protected System.Collections.Generic.List<System.Decimal> 丗下丐专丛丕专世丝(bool 下丕丆世专丅丕丘世)
        {
            ulong val_8;
            System.Collections.Generic.List<System.Decimal> val_9;
            if(下丕丆世专丅丕丘世 != true)
            {
                    val_9 = this.丌丞丈不丆丝丈专丑;
                if(val_9 != null)
            {
                    return (System.Collections.Generic.List<System.Decimal>)val_7;
            }
            
            }
            
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_4 = val_1.dateData.AddDays(value:  (double)-(System.Math.Max(val1:  1, val2:  Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "pci"))));
            val_8 = val_1.dateData;
            System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<System.Decimal>(source:  PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_4.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_8}));
            this.丌丞丈不丆丝丈专丑 = val_7;
            return (System.Collections.Generic.List<System.Decimal>)val_7;
        }
        protected virtual System.Collections.Generic.List<int> 下丁丞丈丌丐丂丞丕()
        {
            var val_52;
            int val_53;
            var val_54;
            var val_55;
            System.Int32[] val_56;
            ulong val_57;
            int val_58;
            var val_59;
            var val_60;
            var val_61;
            decimal val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            int val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            int val_86;
            if((this.丌丞丈不丆丝丈专丑 == null) || (this.丌丞丈不丆丝丈专丑.Count < 1))
            {
                goto label_2;
            }
            
            decimal val_2 = System.Linq.Enumerable.Sum(source:  this.丌丞丈不丆丝丈专丑);
            decimal val_4 = System.Decimal.op_Implicit(value:  this.丌丞丈不丆丝丈专丑.Count);
            decimal val_5 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid}, d2:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
            int val_6 = val_5.flags.丕丛丕丈丅丆且业业(下下丏一丙不丘丌丞:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid});
            System.DateTime val_7 = System.DateTime.UtcNow;
            int val_9 = System.Math.Max(val1:  1, val2:  Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "pci"));
            System.DateTime val_11 = val_7.dateData.AddDays(value:  (double)-(((val_9 < 0) ? (val_9 + 1) : (val_9)) >> 1));
            System.Collections.Generic.List<System.Decimal> val_13 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_11.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_7.dateData});
            System.Collections.Generic.List<System.Int32> val_14 = null;
            val_52 = val_14;
            val_14 = new System.Collections.Generic.List<System.Int32>();
            if(val_13 == null)
            {
                goto label_18;
            }
            
            decimal val_15 = System.Linq.Enumerable.Sum(source:  val_13);
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.mid}, d2:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid})) == false)
            {
                goto label_18;
            }
            
            decimal val_17 = System.Decimal.op_Implicit(value:  val_6);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid}, d2:  new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid})) == false)
            {
                goto label_21;
            }
            
            val_53 = 0;
            goto label_22;
            label_31:
            val_54 = null;
            val_54 = null;
            if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == val_6)
            {
                goto label_27;
            }
            
            val_53 = 1;
            label_22:
            val_55 = null;
            val_55 = null;
            val_56 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
            if(val_53 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_31;
            }
            
            return (System.Collections.Generic.List<System.Int32>)val_52;
            label_2:
            System.DateTime val_19 = System.DateTime.UtcNow;
            System.DateTime val_20 = val_19.dateData.AddDays(value:  -365);
            val_57 = val_19.dateData;
            System.Collections.Generic.List<System.Decimal> val_22 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_20.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_57});
            if(val_22 == null)
            {
                goto label_39;
            }
            
            val_57 = 1152921543745709504;
            if(val_22.Count < 1)
            {
                goto label_39;
            }
            
            decimal val_24 = System.Linq.Enumerable.Sum(source:  val_22);
            val_53 = val_22.Count;
            decimal val_26 = System.Decimal.op_Implicit(value:  val_53);
            decimal val_27 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_24.flags, hi = val_24.hi, lo = val_24.lo, mid = val_24.mid}, d2:  new System.Decimal() {flags = val_26.flags, hi = val_26.hi, lo = val_26.lo, mid = val_26.mid});
            val_58 = val_27.flags.丕丛丕丈丅丆且业业(下下丏一丙不丘丌丞:  new System.Decimal() {flags = val_27.flags, hi = val_27.hi, lo = val_27.lo, mid = val_27.mid});
            goto label_42;
            label_39:
            int val_29 = 0;
            val_22.上丏丄且丅一东丐丕(丅丄丆丞下丄丒专丕: out  new System.Decimal(), 上专丅业三丏丈丈丗: out  val_29);
            val_59 = null;
            val_59 = null;
            val_60 = 0;
            val_61 = null;
            if(((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false) || (val_29 <= 0))
            {
                goto label_46;
            }
            
            decimal val_31 = System.Decimal.op_Implicit(value:  0);
            val_60 = 0;
            decimal val_32 = System.Decimal.op_Division(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_31.flags, hi = val_31.hi, lo = val_31.lo, mid = val_31.mid});
            val_62 = val_32.flags;
            val_63 = val_32.lo;
            goto label_49;
            label_18:
            decimal val_33 = System.Decimal.op_Implicit(value:  val_6);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid}, d2:  new System.Decimal() {flags = val_33.flags, hi = val_33.hi, lo = val_33.lo, mid = val_33.mid})) == false)
            {
                goto label_52;
            }
            
            val_53 = 1;
            goto label_53;
            label_62:
            val_64 = null;
            val_64 = null;
            val_65 = (long)val_13;
            System.Int32[] val_35 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(val_13)) << 2);
            if(((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(val_13)) << 2) + 32) == val_6)
            {
                goto label_106;
            }
            
            val_53 = 2;
            label_53:
            val_66 = null;
            val_66 = null;
            val_56 = val_53 - 1;
            if(val_56 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_62;
            }
            
            return (System.Collections.Generic.List<System.Int32>)val_52;
            label_46:
            val_61 = null;
            val_62 = System.Decimal.Zero;
            label_49:
            val_67 = new System.Decimal().丕丛丕丈丅丆且业业(下下丏一丙不丘丌丞:  new System.Decimal() {flags = val_62, hi = val_62, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0});
            val_68 = null;
            val_68 = null;
            val_53 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
            if(val_67 < (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + 32))
            {
                    val_69 = null;
                val_69 = null;
                val_67 = mem[丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + 32];
                val_67 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + 32;
            }
            
            val_58 = val_67;
            label_42:
            val_52 = this.不与东丌一丘专丈丘(世丈三丐丞一丒丛不:  val_58);
            return (System.Collections.Generic.List<System.Int32>)val_52;
            label_52:
            val_70 = -2;
            goto label_75;
            label_84:
            val_71 = null;
            val_71 = null;
            System.Int32[] val_38 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(val_13)) << 2);
            if(((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(val_13)) << 2) + 32) == val_6)
            {
                goto label_80;
            }
            
            val_70 = -1;
            label_75:
            val_72 = null;
            val_72 = null;
            if((val_70 + 2) < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_84;
            }
            
            return (System.Collections.Generic.List<System.Int32>)val_52;
            label_80:
            if((0 & 2147483648) != 0)
            {
                    return (System.Collections.Generic.List<System.Int32>)val_52;
            }
            
            val_73 = null;
            val_73 = null;
            System.Int32[] val_40 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(val_13)) << 2);
            val_14.Add(item:  (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(val_13)) << 2) + 32);
            if(((-1) & 2147483648) != 0)
            {
                goto label_150;
            }
            
            var val_56 = 0;
            long val_57 = -1;
            label_99:
            val_74 = null;
            val_74 = null;
            System.Int32[] val_41 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (-4);
            val_14.Add(item:  (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + -4) + 32);
            if((val_70 & 2147483648) != 0)
            {
                goto label_150;
            }
            
            val_56 = val_56 + 1;
            val_57 = val_57 - 1;
            if(val_56 < 1)
            {
                goto label_99;
            }
            
            goto label_150;
            label_21:
            val_75 = 1;
            goto label_101;
            label_110:
            val_76 = null;
            val_76 = null;
            val_65 = (long)val_15.flags;
            System.Int32[] val_42 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(val_15.flags)) << 2);
            if(((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(val_15.flags)) << 2) + 32) == val_6)
            {
                goto label_106;
            }
            
            val_75 = 2;
            label_101:
            val_77 = null;
            val_77 = null;
            if((val_75 - 1) < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_110;
            }
            
            return (System.Collections.Generic.List<System.Int32>)val_52;
            label_106:
            if((val_13 & 2147483648) != 0)
            {
                    return (System.Collections.Generic.List<System.Int32>)val_52;
            }
            
            val_78 = null;
            val_78 = null;
            System.Int32[] val_44 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(val_13)) << 2);
            val_14.Add(item:  (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(val_13)) << 2) + 32);
            if(val_13 >= 1)
            {
                    val_79 = null;
                val_79 = null;
                System.Int32[] val_45 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (-4);
                val_14.Add(item:  (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + -4) + 32);
            }
            
            val_80 = null;
            val_80 = null;
            if(val_13 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_150;
            }
            
            val_81 = null;
            val_81 = null;
            val_14.Add(item:  丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32);
            if(val_52 != null)
            {
                goto label_152;
            }
            
            goto label_134;
            label_27:
            if((val_53 & 2147483648) != 0)
            {
                    return (System.Collections.Generic.List<System.Int32>)val_52;
            }
            
            val_82 = null;
            val_82 = null;
            val_14.Add(item:  丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32);
            val_83 = 1;
            goto label_141;
            label_151:
            val_84 = null;
            val_84 = null;
            System.Int32[] val_46 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32)) << 2);
            val_14.Add(item:  (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32)) << 2) + 32);
            val_83 = 2;
            label_141:
            val_85 = null;
            val_85 = null;
            if((val_83 - 1) <= 1)
            {
                    if((val_53 + val_83) < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_151;
            }
            
            }
            
            label_150:
            if(val_52 != null)
            {
                goto label_152;
            }
            
            label_134:
            label_152:
            val_14.Sort();
            goto label_153;
            label_157:
            if(val_52 != null)
            {
                    val_86 = val_14.Item[val_14.Count - 1];
            }
            else
            {
                    val_86 = val_14.Item[val_14.Count - 1];
            }
            
            val_14.Add(item:  val_86);
            label_153:
            if(val_14.Count <= 2)
            {
                goto label_157;
            }
            
            return (System.Collections.Generic.List<System.Int32>)val_52;
        }
        private System.Collections.Generic.List<int> 不与东丌一丘专丈丘(int 世丈三丐丞一丒丛不)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            val_6 = -2;
            goto label_1;
            label_10:
            val_7 = null;
            val_7 = null;
            System.Int32[] val_2 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(W22)) << 2);
            if(((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(W22)) << 2) + 32) == 世丈三丐丞一丒丛不)
            {
                goto label_6;
            }
            
            val_6 = -1;
            label_1:
            val_8 = null;
            val_8 = null;
            if((val_6 + 2) < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_10;
            }
            
            return val_1;
            label_6:
            if((0 & 2147483648) != 0)
            {
                    return val_1;
            }
            
            val_9 = null;
            val_9 = null;
            System.Int32[] val_4 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(W22)) << 2);
            val_1.Add(item:  (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(W22)) << 2) + 32);
            int val_10 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length;
            val_10 = val_10 - 1;
            if(1 <= val_10)
            {
                    val_10 = null;
                val_10 = null;
                val_1.Add(item:  丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32);
            }
            
            if(((-1) & 2147483648) != 0)
            {
                goto label_25;
            }
            
            long val_11 = -1;
            label_32:
            val_11 = null;
            val_11 = null;
            System.Int32[] val_5 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (-4);
            val_1.Add(item:  (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + -4) + 32);
            var val_6 = 0 + 1;
            if((val_6 & 2147483648) != 0)
            {
                goto label_31;
            }
            
            val_11 = val_11 - 1;
            val_6 = -3;
            if((0 + 1) < 2)
            {
                goto label_32;
            }
            
            label_31:
            if(val_6 > 0)
            {
                goto label_33;
            }
            
            val_12 = val_6 + 1;
            goto label_34;
            label_25:
            val_12 = 0;
            label_34:
            do
            {
                val_13 = null;
                val_13 = null;
                System.Int32[] val_9 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(W22)) << 2);
                val_1.Add(item:  (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(W22)) << 2) + 32);
                val_6 = (2 - val_12) - 1;
            }
            while(val_6 != 0);
            
            label_33:
            val_1.Sort();
            return val_1;
        }
        private int 丕丛丕丈丅丆且业业(decimal 下下丏一丙不丘丌丞)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = 0;
            do
            {
                val_4 = null;
                val_4 = null;
                if(val_3 >= 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                    return 0;
            }
            
                val_5 = null;
                val_5 = null;
                decimal val_1 = System.Decimal.op_Implicit(value:  丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32);
                val_3 = val_3 + 1;
            }
            while((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, d2:  new System.Decimal() {flags = 下下丏一丙不丘丌丞.flags, hi = 下下丏一丙不丘丌丞.hi, lo = 下下丏一丙不丘丌丞.lo, mid = 下下丏一丙不丘丌丞.mid})) == true);
            
            return 0;
        }
        protected void 上丏丄且丅一东丐丕(out decimal 丅丄丆丞下丄丒专丕, out int 上专丅业三丏丈丈丗)
        {
            var val_18;
            var val_22;
            var val_28;
            var val_64;
            PGCompany.东丑丒丗一丞下丙丙<T> val_65;
            var val_66;
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_68;
            var val_69;
            var val_73;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            丅丄丆丞下丄丒专丕.flags = 0;
            丅丄丆丞下丄丒专丕.hi = 0;
            丅丄丆丞下丄丒专丕.lo = 0;
            丅丄丆丞下丄丒专丕.mid = 0;
            上专丅业三丏丈丈丗 = 0;
            val_65 = PGCompany.东丑丒丗一丞下丙丙<Rilisoft.OfferItem>.万世丅七一专丕丞不();
            val_66 = null;
            val_66 = null;
            val_68 = 丛丝下且丟丈丞丈丗.<>c.<>9__13_0;
            if(val_68 == null)
            {
                    System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_3 = null;
                val_68 = val_3;
                val_3 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  丛丝下且丟丈丞丈丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛丝下且丟丈丞丈丗.<>c::丌丄专丏下丈丌丙丅(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
                丛丝下且丟丈丞丈丗.<>c.<>9__13_0 = val_68;
            }
            
            val_69 = System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙(), predicate:  val_3);
            if(val_69 == null)
            {
                goto label_11;
            }
            
            var val_66 = 0;
            val_66 = val_66 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = val_69.GetEnumerator();
            label_29:
            var val_67 = 0;
            val_67 = val_67 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_21;
            }
            
            var val_68 = 0;
            val_68 = val_68 + 1;
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  10, 丞一丁业丄一一业且:  val_6.Current.与不丞丑七丘丁丂丛(), 丂丕丂丏专丂丄丕且:  1);
            val_65.Add(item:  new Rilisoft.OfferItem());
            goto label_29;
            label_21:
            val_64 = 484708096;
            val_73 = 0;
            val_69 = 0;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_69 = 0;
                val_69 = val_69 + 1;
                val_6.Dispose();
            }
            
            if(( == 1) || ( != 128))
            {
                goto label_44;
            }
            
            label_11:
            val_73 = 0;
            goto label_46;
            label_44:
            if( != false)
            {
                    val_69 = 0;
            }
            
            label_46:
            Dictionary.Enumerator<TKey, TValue> val_15 = 七丌丞万七万丁丐丙.且不业七三丏与丐丙().GetEnumerator();
            label_105:
            if((484708464 & 1) == 0)
            {
                goto label_50;
            }
            
            ConfiguredValueTaskAwaiter val_19 = val_18.GetAwaiter();
            List.Enumerator<T> val_20 = val_19._value._obj.GetEnumerator();
            label_93:
            if((484708416 & 1) == 0)
            {
                goto label_52;
            }
            
            string val_23 = val_22.丐丏七丌丕丗业且上();
            if((val_23 == null) || ((System.String.op_Equality(a:  val_23.Item[0], b:  "Armor_Army_1")) == true))
            {
                goto label_93;
            }
            
            List.Enumerator<T> val_26 = val_23.GetEnumerator();
            label_73:
            if((484708384 & 1) == 0)
            {
                goto label_55;
            }
            
            string val_29 = val_28.丐丏七丌丕丗业且上();
            if((七丌丞万七万丁丐丙.一丐丂丁丏丕丒不丗(丞丅上丏丂且下丅与:  val_29, 七丆丒与丗丌丄且丂:  val_19._value._obj.丙东专丂世丈丏丁丂())) == false)
            {
                goto label_73;
            }
            
            if(val_19._value._obj.丙东专丂世丈丏丁丂() == 7)
            {
                    val_75 = BalanceController.世下一丅且不世不丆(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  val_29));
            }
            else
            {
                    val_75 = 上丑三丁丄丛丁万丑.丟丘世丁丐丑丄丁丂(不三丙万与丗丌七丈:  val_19._value._obj.丙东专丂世丈丏丁丂(), 丞一丁业丄一一业且:  val_29);
            }
            
            val_76 = null;
            val_76 = null;
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  ((System.String.op_Equality(a:  val_75.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true) ? 1010 : 1000, 丞一丁业丄一一业且:  val_75.东与三丌丅三丒丏业(), 丂丕丂丏专丂丄丕且:  val_75.丟丂丞不专丆万丒世());
            val_65.Add(item:  new Rilisoft.OfferItem());
            goto label_73;
            label_55:
             =  + 1;
            mem2[0] = 376;
            val_77 = val_69;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || ((val_64 + ((val_73 + 1)) << 2) != 376))
            {
                goto label_90;
            }
            
            var val_70 = 0;
            val_70 = val_70 ^ ( >> 31);
             =  + val_70;
            goto label_93;
            label_90:
            if( == 0)
            {
                goto label_93;
            }
            
            goto label_93;
            label_52:
             =  + 1;
            mem2[0] = 404;
            val_78 = val_69;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || ((val_64 + ((val_73 + 1)) << 2) != 404))
            {
                goto label_102;
            }
            
            var val_71 = 0;
            val_71 = val_71 ^ ( >> 31);
             =  + val_71;
            goto label_105;
            label_102:
            if( == 0)
            {
                goto label_105;
            }
            
            goto label_105;
            label_50:
            val_79 =  + 1;
            mem2[0] = 432;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && ((val_64 + ((val_73 + 1)) << 2) == 432))
            {
                    var val_72 = 0;
                val_72 = val_72 ^ ( >> 31);
                val_79 =  + val_72;
            }
            else
            {
                    if( != 0)
            {
                    val_69 = 0;
            }
            
            }
            
            Dictionary.Enumerator<TKey, TValue> val_44 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().GetEnumerator();
            label_131:
            if((484708336 & 1) == 0)
            {
                goto label_118;
            }
            
            ConfiguredValueTaskAwaiter val_45 = val_18.GetAwaiter();
            if((丁下万丟且丟丛下业.东丞丄丌丙丟丘世丈(丗丑丐丕丟丝且下丕:  val_45._value._obj.丐丏七丌丕丗业且上(), 丝丒上丑一三丑丐丛:  true)) == false)
            {
                goto label_131;
            }
            
            丈丞丕丘丕丗与上一 val_50 = 上丑三丁丄丛丁万丑.丟丘世丁丐丑丄丁丂(不三丙万与丗丌七丈:  val_45._value._obj.丒万丕七专不丏丞丌(), 丞一丁业丄一一业且:  val_45._value._obj.丐丏七丌丕丗业且上());
            val_80 = null;
            val_80 = null;
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  ((System.String.op_Equality(a:  val_50.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true) ? 1010 : 1000, 丞一丁业丄一一业且:  val_50.东与三丌丅三丒丏业(), 丂丕丂丏专丂丄丕且:  val_50.丟丂丞不专丆万丒世());
            val_65.Add(item:  new Rilisoft.OfferItem());
            goto label_131;
            label_118:
            val_81 =  + 1;
            mem2[0] = 581;
            val_82 = 1152921505475907584;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_81 != 1) && ((val_64 + (((val_73 + 1) + 1)) << 2) == 581))
            {
                    var val_73 = 0;
                val_73 = val_73 ^ (val_81 >> 31);
                val_81 = val_81 + val_73;
            }
            else
            {
                    if( != 0)
            {
                    val_69 = 0;
            }
            
            }
            
            Dictionary.Enumerator<TKey, TValue> val_59 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈().GetEnumerator();
            label_156:
            if((484708272 & 1) == 0)
            {
                goto label_153;
            }
            
            ConfiguredValueTaskAwaiter val_60 = val_18.GetAwaiter();
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  val_60._value._obj.丙东专丂世丈丏丁丂());
            new Rilisoft.OfferItem().Count = 1;
            val_65.Add(item:  new Rilisoft.OfferItem());
            goto label_156;
            label_153:
            val_83 = 484708096;
            val_81 = val_81 + 1;
            mem2[0] = 663;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_81 == 1)
            {
                goto label_164;
            }
            
            if(( == 0) || ((val_83 + ((((val_73 + 1) + 1) + 1)) << 2) == 663))
            {
                goto label_174;
            }
            
            label_173:
            label_174:
            Rilisoft.Offers.丛丝下且丟丈丞丈丗.丕业专丛丗万丈丁丙(丂丏丟一丈丐丘丞丞:  val_65);
            decimal val_63 = Rilisoft.Offers.丁且丕专万丈丒丏丗.且丄丗东丌业下东丐(丑七不与丛丆一丂丞:  val_65, 世丈三丐丞一丒丛不:  100);
            丅丄丆丞下丄丒专丕.flags = val_63.flags;
            丅丄丆丞下丄丒专丕.hi = val_63.hi;
            丅丄丆丞下丄丒专丕.lo = val_63.lo;
            丅丄丆丞下丄丒专丕.mid = val_63.mid;
            上专丅业三丏丈丈丗 = val_65.Count;
            if((PGCompany.东丑丒丗一丞下丙丙<Rilisoft.OfferItem>.万世丅七一专丕丞不()) != null)
            {
                    return;
            }
            
            return;
            label_164:
            if( != 0)
            {
                goto label_173;
            }
            
            goto label_174;
        }
        internal static System.Collections.Generic.Dictionary<int, Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅> 业下丈丘万丗丟丒丑(System.Collections.Generic.IEnumerable<int> 丏丅东丙东业三丈丗)
        {
            var val_15;
            System.Func<System.Int32, System.Int32> val_17;
            var val_18;
            var val_22;
            var val_23;
            System.Collections.Generic.Dictionary<System.Int32, 丂丘丛下丆一丕丂丅> val_1 = new System.Collections.Generic.Dictionary<System.Int32, 丂丘丛下丆一丕丂丅>();
            if(丏丅东丙东业三丈丗 == null)
            {
                    return val_1;
            }
            
            if((System.Linq.Enumerable.Any<System.Int32>(source:  丏丅东丙东业三丈丗)) == false)
            {
                    return val_1;
            }
            
            val_15 = null;
            val_15 = null;
            val_17 = 丛丝下且丟丈丞丈丗.<>c.<>9__14_0;
            if(val_17 == null)
            {
                    System.Func<System.Int32, System.Int32> val_3 = null;
                val_17 = val_3;
                val_3 = new System.Func<System.Int32, System.Int32>(object:  丛丝下且丟丈丞丈丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丛丝下且丟丈丞丈丗.<>c::丕七丁丈且专七三丂(int 东七上世万下丗丄丛));
                丛丝下且丟丈丞丈丗.<>c.<>9__14_0 = val_17;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_4 = System.Linq.Enumerable.OrderBy<System.Int32, System.Int32>(source:  丏丅东丙东业三丈丗, keySelector:  val_3);
            if((System.Linq.Enumerable.Count<System.Int32>(source:  val_4)) >= 2)
            {
                goto label_8;
            }
            
            val_18 = 0;
            if(val_4 != null)
            {
                goto label_11;
            }
            
            goto label_10;
            label_8:
            val_18 = System.Linq.Enumerable.Last<System.Int32>(source:  val_4);
            if(val_4 != null)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            var val_18 = 0;
            val_18 = val_18 + 1;
            System.Collections.Generic.IEnumerator<T> val_9 = val_4.GetEnumerator();
            label_30:
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(val_9.MoveNext() == false)
            {
                goto label_21;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            T val_13 = val_9.Current;
            if((val_1.ContainsKey(key:  val_13)) == true)
            {
                goto label_30;
            }
            
            val_1.Add(key:  val_13, value:  (val_13 != (System.Linq.Enumerable.First<System.Int32>(source:  val_4))) ? ((val_13 == val_18) ? (2 + 1) : 2) : (0 + 1));
            goto label_30;
            label_21:
            val_22 = 0;
            val_23 = 0;
            if(val_9 == null)
            {
                
            }
            else
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_9.Dispose();
            }
            
            if( != 1)
            {
                    return val_1;
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
        public virtual void Dispose()
        {
        
        }
        private static void 丕业专丛丗万丈丁丙(System.Collections.Generic.List<Rilisoft.OfferItem> 丂丏丟一丈丐丘丞丞)
        {
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            val_27 = 1152921505290498048;
            System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_2 = 七丌丞万七万丁丐丙.且不业七三丏与丐丙().Item[7];
            val_28 = 1152921524490163648;
            val_29 = 1152921516223708000;
            val_30 = 0;
            goto label_4;
            label_35:
            if((七丌丞万七万丁丐丙.一丐丂丁丏丕丒不丗(丞丅上丏丂且下丅与:  val_2.Item[0].Item[0], 七丆丒与丗丌丄且丂:  7)) != false)
            {
                    int val_8 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  val_2.Item[0].Item[0]);
                int val_10 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_8);
                int val_27 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().丄丏且丆丈一东丟丙(丞世不丒下上上丝丑:  val_8);
                if(val_27 < val_10)
            {
                    do
            {
                丈丞丕丘丕丗与上一 val_13 = BalanceController.且丅丑与三丘丈丏万(丞世不丒下上上丝丑:  val_8, 丕丒一丂丗万三七三:  val_27, 丐丏上业丈丂与万丞:  false);
                new 丈丞丕丘丕丗与上一() = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  上丑三丁丄丛丁万丑.丙不一上丂丗丌下专(丞丅上丏丂且下丅与:  val_2.Item[0].Item[0], 丒世丘丘上丆丝东丞:  val_13.丟丂丞不专丆万丒世()), 丏丂不专上丘丂不丅:  val_13.东与三丌丅三丒丏业());
                val_31 = null;
                val_31 = null;
                new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  ((System.String.op_Equality(a:  new 丈丞丕丘丕丗与上一().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true) ? 1010 : 1000, 丞一丁业丄一一业且:  new 丈丞丕丘丕丗与上一().东与三丌丅三丒丏业(), 丂丕丂丏专丂丄丕且:  new 丈丞丕丘丕丗与上一().丟丂丞不专丆万丒世());
                丂丏丟一丈丐丘丞丞.Add(item:  new Rilisoft.OfferItem());
                val_27 = 1152921505290498048;
                val_28 = 1152921524490163648;
                val_29 = 1152921516223708000;
                val_27 = val_27 + 1;
            }
            while(val_27 < val_10);
            
            }
            
            }
            
            val_30 = 1;
            label_4:
            if(val_30 < val_2.Count)
            {
                goto label_35;
            }
        
        }
    
    }

}
