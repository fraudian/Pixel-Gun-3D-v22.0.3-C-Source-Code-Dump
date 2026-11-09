using UnityEngine;

namespace PGCompany.LootBoxSystem
{
    internal sealed class 丞万下丒丒且丁丒三 : 丗丑丂丂上丏丝丙三
    {
        // Fields
        private PGCompany.LootBoxSystem.丅且丕丌丞丟且丈丒 世丂上丌丞且丁七丏;
        internal System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 丞丙上丐万上丁丟东;
        internal System.Collections.Generic.List<PGCompany.LootBoxSystem.丞万下丒丒且丁丒三.七丘丟专世丅丂丙丑> 与上丂三丘一不丏下;
        internal System.Collections.Generic.Dictionary<int, int> 世三与丒上丅业丗东;
        internal System.Collections.Generic.Dictionary<int, int> 业丒丟且万丂一不丟;
        
        // Methods
        public 丞万下丒丒且丁丒三(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.LootBoxSystem.世七丈丆丐丕专业丗 与不丕丆丈不丙丟丛)
        {
            this.与上丂三丘一不丏下 = new System.Collections.Generic.List<七丘丟专世丅丂丙丑>();
            this.世三与丒上丅业丗东 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            this.业丒丟且万丂一不丟 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            this.世丂上丌丞且丁七丏 = PGCompany.LootBoxSystem.七丈三丂且丗丈世一.丑七不且上丗丁一世().世丈丁业丛上丘丗丐();
        }
        protected override System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 丞丏丏七万丞丐丒丆()
        {
            var val_19;
            var val_23;
            var val_24;
            System.Func<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.Int32> val_26;
            var val_28;
            System.Func<System.Linq.IGrouping<System.Int32, PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>, System.Int32> val_30;
            var val_32;
            var val_33;
            var val_34;
            var val_37;
            var val_38;
            var val_40;
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> val_1 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>();
            if(this.世丂上丌丞且丁七丏 == null)
            {
                    return val_1;
            }
            
            val_24 = null;
            val_24 = null;
            val_26 = 丞万下丒丒且丁丒三.<>c.<>9__6_1;
            if(val_26 == null)
            {
                    System.Func<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.Int32> val_4 = null;
                val_26 = val_4;
                val_4 = new System.Func<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.Int32>(object:  丞万下丒丒且丁丒三.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丞万下丒丒且丁丒三.<>c::万丛丞与丛丕丅丄丘(PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 一丐丗丁丞丆丅丟丄));
                丞万下丒丒且丁丒三.<>c.<>9__6_1 = val_26;
            }
            
            val_28 = null;
            val_28 = null;
            val_30 = 丞万下丒丒且丁丒三.<>c.<>9__6_2;
            if(val_30 == null)
            {
                    System.Func<System.Linq.IGrouping<System.Int32, PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>, System.Int32> val_6 = null;
                val_30 = val_6;
                val_6 = new System.Func<System.Linq.IGrouping<System.Int32, PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>, System.Int32>(object:  丞万下丒丒且丁丒三.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丞万下丒丒且丁丒三.<>c::与与万丝丑丄丒丝丄(System.Linq.IGrouping<int, PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒> 丐丏东世不丅丌且万));
                丞万下丒丒且丁丒三.<>c.<>9__6_2 = val_30;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_32 = System.Linq.Enumerable.Select<System.Linq.IGrouping<System.Int32, PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>, System.Int32>(source:  System.Linq.Enumerable.GroupBy<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.Int32>(source:  this.世丂上丌丞且丁七丏.LootBoxRateDatas.FindAll(match:  new System.Predicate<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>(object:  this, method:  System.Boolean PGCompany.LootBoxSystem.丞万下丒丒且丁丒三::丒丈世丞万丙丑世丑(PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 一丐丗丁丞丆丅丟丄))), keySelector:  val_4), selector:  val_6).GetEnumerator();
            val_33 = 0;
            val_34 = 0;
            var val_30 = 0;
            label_61:
            if(val_32 != null)
            {
                goto label_58;
            }
            
            label_59:
            label_58:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_32.MoveNext() == false)
            {
                goto label_23;
            }
            
            new 丞万下丒丒且丁丒三.丘丞上世丗丘丏丐东() = new System.Object();
            var val_29 = 0;
            val_29 = val_29 + 1;
            .上丈丐下丗丟与丂上 = val_32.Current;
            System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上> val_15 = new System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上>(object:  new 丞万下丒丒且丁丒三.丘丞上世丗丘丏丐东(), method:  System.Boolean 丞万下丒丒且丁丒三.丘丞上世丗丘丏丐东::丙丕丏三丑一丗丌丟(PGCompany.LootBoxSystem.丏丛且不丏与万一上 一丐丗丁丞丆丅丟丄));
            List.Enumerator<T> val_17 = this.世丂上丌丞且丁七丏.LootBoxItemDatas.FindAll(match:  null).GetEnumerator();
            val_37 = val_32;
            label_50:
            if(((-7479520) & 1) == 0)
            {
                goto label_33;
            }
            
            string val_20 = val_19.丐丏七丌丕丗业且上();
            List.Enumerator<T> val_21 = this.世丂上丌丞且丁七丏.LootBoxItemDatas.GetEnumerator();
            label_39:
            if(((-7479552) & 1) == 0)
            {
                goto label_36;
            }
            
            string val_24 = val_23.丐丏七丌丕丗业且上();
            new PGCompany.LootBoxSystem.丗上丆专不上丏丏丒() = new PGCompany.LootBoxSystem.丗上丆专不上丏丏丒(丈丄不七三万丄丁不:  val_24);
            .万丗丂上不下七丅万 = val_24;
            val_1.Add(item:  new PGCompany.LootBoxSystem.丗上丆专不上丏丏丒());
            goto label_39;
            label_36:
            val_30 = val_30 + 1;
            val_38 = val_34;
            mem2[0] = 267;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if((val_30 == 1) || ((-7479632 + ((0 + 1)) << 2) != 267))
            {
                goto label_47;
            }
            
            var val_31 = 0;
            val_31 = val_31 ^ (val_30 >> 31);
            val_30 = val_30 + val_31;
            goto label_50;
            label_47:
            if( == 0)
            {
                goto label_50;
            }
            
            goto label_50;
            label_33:
            val_30 = val_30 + 1;
            val_40 = val_34;
            mem2[0] = 292;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_30 == 1) || ((-7479632 + ((0 + 1)) << 2) != 292))
            {
                goto label_57;
            }
            
            var val_32 = 0;
            val_32 = val_32 ^ (val_30 >> 31);
            val_30 = val_30 + val_32;
            if( != null)
            {
                goto label_58;
            }
            
            goto label_59;
            label_57:
            if( == 0)
            {
                goto label_61;
            }
            
            goto label_61;
            label_23:
            val_30 = val_30 + 1;
            mem2[0] = 315;
            if(val_32 == null)
            {
                
            }
            else
            {
                    var val_33 = 0;
                val_33 = val_33 + 1;
                Dispose();
            }
            
            if(val_30 != 1)
            {
                    if( == 0)
            {
                    return val_1;
            }
            
                if((-7479632 + ((0 + 1)) << 2) == 315)
            {
                    return val_1;
            }
            
                return val_1;
            }
            
            if( != 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        protected override System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丕丈丞丂丝丒丛丐且(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丙万丏不丈三丈丈业)
        {
            return this.丘丂丝丆丒下丁丂丅(丙万丏不丈三丈丈业:  丙万丏不丈三丈丈业);
        }
        private System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒> 丂世丗丌丅丁与东丒(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丙万丏不丈三丈丈业)
        {
            var val_8;
            var val_21;
            System.Predicate<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七> val_23;
            System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上> val_24;
            丞万下丒丒且丁丒三.业东下丕世丗丏万丏 val_1 = new 丞万下丒丒且丁丒三.业东下丕世丗丏万丏();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .丙万丏不丈三丈丈业 = 丙万丏不丈三丈丈业;
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒> val_2 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>();
            if(this.丟不丛丑一丗丄业丟() == null)
            {
                    return val_2;
            }
            
            if(this.世丂上丌丞且丁七丏 == null)
            {
                    return val_2;
            }
            
            List.Enumerator<T> val_6 = this.世丂上丌丞且丁七丏.LootBoxRateDatas.FindAll(match:  new System.Predicate<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>(object:  val_1, method:  System.Boolean 丞万下丒丒且丁丒三.业东下丕世丗丏万丏::丅业丈丞丗万丆丂丈(PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 一丐丗丁丞丆丅丟丄))).GetEnumerator();
            label_31:
            if(((-7071136) & 1) == 0)
            {
                goto label_7;
            }
            
            new 丞万下丒丒且丁丒三.丙丏丆丕下丁丈丑丅() = new System.Object();
            .一丛丆丂丝丙丝且丞 = val_8.丐丏七丌丕丗业且上();
            System.Predicate<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七> val_11 = new System.Predicate<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七>(object:  new 丞万下丒丒且丁丒三.丙丏丆丕下丁丈丑丅(), method:  System.Boolean 丞万下丒丒且丁丒三.丙丏丆丕下丁丈丑丅::丝专业丛丝丅丘丝丂(PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七 与丕丁三万专世不丅));
            System.Collections.Generic.List<T> val_12 = this.世丂上丌丞且丁七丏.LootBoxAttrFilter.FindAll(match:  null);
            if(val_12.Count < 1)
            {
                goto label_12;
            }
            
            val_21 = null;
            val_21 = null;
            val_23 = 丞万下丒丒且丁丒三.<>c.<>9__8_2;
            if(val_23 == null)
            {
                goto label_15;
            }
            
            if(val_12 != null)
            {
                goto label_20;
            }
            
            goto label_17;
            label_15:
            val_23 = null;
            val_23 = new System.Predicate<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七>(object:  丞万下丒丒且丁丒三.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丞万下丒丒且丁丒三.<>c::丐丛丂丈东丆丙丂丅(PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七 下丁丟丅业丝丅专七));
            丞万下丒丒且丁丒三.<>c.<>9__8_2 = val_23;
            if(val_12 != null)
            {
                goto label_20;
            }
            
            label_17:
            label_20:
            if((val_12.Exists(match:  null)) == true)
            {
                goto label_31;
            }
            
            label_12:
            System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上> val_16 = new System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上>(object:  new 丞万下丒丒且丁丒三.丙丏丆丕下丁丈丑丅(), method:  System.Boolean 丞万下丒丒且丁丒三.丙丏丆丕下丁丈丑丅::丒丄丘丆下万丝丐不(PGCompany.LootBoxSystem.丏丛且不丏与万一上 一丐丗丁丞丆丅丟丄));
            System.Collections.Generic.List<T> val_17 = this.世丂上丌丞且丁七丏.LootBoxItemDatas.FindAll(match:  null);
            val_24 = (丞万下丒丒且丁丒三.业东下丕世丗丏万丏)[1152921560434398912].丗三丝不且丏丒丟且;
            if(val_24 == null)
            {
                goto label_25;
            }
            
            if(val_17 != null)
            {
                goto label_28;
            }
            
            goto label_27;
            label_25:
            val_24 = null;
            val_24 = new System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上>(object:  val_1, method:  System.Boolean 丞万下丒丒且丁丒三.业东下丕世丗丏万丏::丟丁不三丑丞与丕上(PGCompany.LootBoxSystem.丏丛且不丏与万一上 一丐丗丁丞丆丅丟丄));
            .丗三丝不且丏丒丟且 = val_24;
            if(val_17 != null)
            {
                goto label_28;
            }
            
            label_27:
            label_28:
            if((val_17.Exists(match:  null)) == false)
            {
                goto label_31;
            }
            
            val_2.Add(item:  (丞万下丒丒且丁丒三.丙丏丆丕下丁丈丑丅)[1152921560434427584].一丛丆丂丝丙丝且丞);
            goto label_31;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_2;
        }
        private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丘丂丝丆丒下丁丂丅(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丙万丏不丈三丈丈业)
        {
            float val_14;
            var val_27;
            var val_68;
            var val_79;
            var val_90;
            var val_98;
            var val_106;
            var val_114;
            PGCompany.LootBoxSystem.丞万下丒丒且丁丒三 val_115;
            System.Collections.Generic.List<T> val_117;
            int val_118;
            var val_119;
            int val_120;
            var val_121;
            var val_122;
            var val_123;
            var val_124;
            System.Predicate<PGCompany.LootBoxSystem.一丏丙丒世丅丞下东> val_125;
            var val_126;
            var val_127;
            var val_130;
            var val_131;
            var val_132;
            System.Func<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.Int32> val_134;
            var val_135;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_136;
            System.Collections.Generic.List<T> val_137;
            var val_138;
            var val_139;
            var val_140;
            var val_141;
            var val_142;
            var val_143;
            var val_145;
            var val_146;
            var val_147;
            var val_148;
            var val_150;
            System.Func<PGCompany.LootBoxSystem.丏丛且不丏与万一上, System.Int32> val_152;
            System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上> val_153;
            var val_154;
            var val_156;
            System.Collections.Generic.List<T> val_157;
            System.Collections.Generic.Dictionary<TKey, TValue> val_158;
            var val_159;
            System.Collections.Generic.List<T> val_160;
            var val_161;
            var val_162;
            val_114;
            val_115 = this;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_81 = 0;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_92 = 0;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_112 = 0;
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>>();
            System.Collections.Generic.List<System.Int32> val_2 = null;
            val_117 = val_2;
            val_2 = new System.Collections.Generic.List<System.Int32>();
            if((PGCompany.AttributeSystem.丒三丝丛丘丛丆丌丂.丟丐下丐三一丄丞丑<System.Int32>(丆下丕丅丕一丝丁丛:  33)) != true)
            {
                    PGCompany.AttributeSystem.丒三丝丛丘丛丆丌丂.丂且不业丂专丛丆东<System.Int32>(丂专三与丕丂三丛下:  PGCompany.AttributeSystem.丟丙丂丗丈丂丆丁丒<System.Int32>.丄丞丛业且丛专丁上(丆下丕丅丕一丝丁丛:  33, 丙业与丙丗丝不丈东:  专且丝丄丙丗丈不丞.丈丐且丐丆丑丂丄丘(东丏丕丗丕丞丁三丌:  1, 世万丈与丑专丝一丞:  232)), 专丒丌丆下丐丞丟丞:  0);
            }
            
            val_118 = PGCompany.AttributeSystem.丒三丝丛丘丛丆丌丂.三丛丞丂丑世丆三丕<System.Int32>(丆下丕丅丕一丝丁丛:  33);
            if(val_118 != null)
            {
                    val_119 = System.Int32 PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<System.Int32>::业上丙丞丐丄丆丅七();
                val_120 = val_118.业上丙丞丐丄丆丅七();
            }
            else
            {
                    val_119 = System.Int32 PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<System.Int32>::业上丙丞丐丄丆丅七();
                val_120 = 0.业上丙丞丐丄丆丅七();
            }
            
            this.世三与丒上丅业丗东.set_Item(key:  val_120, value:  val_118);
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒> val_9 = this.丂世丗丌丅丁与东丒(丙万丏不丈三丈丈业:  丙万丏不丈三丈丈业);
            if(val_9.Count == 0)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            }
            
            if((PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<System.Int32>.丌且丕丐丛上丅且丁(三丟东丕丄丄下下丑:  val_118, 丒丒丄丁且丄丆丂丌:  0)) == true)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            }
            
            List.Enumerator<T> val_12 = val_9.GetEnumerator();
            val_121 = 1152921560434268160;
            val_122 = 0;
            goto label_19;
            label_92:
            val_117 = new 丞万下丒丒且丁丒三.丌万一一业丝丁丈丝();
            val_117 = new System.Object();
            val_123 = 0;
            .一丛丆丂丝丙丝且丞 = val_14.丐丏七丌丕丗业且上();
            goto label_21;
            label_91:
            val_124 = null;
            val_124 = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = (丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].一丛丆丂丝丙丝且丞.Chance, hi = (丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].一丛丆丂丝丙丝且丞.Chance}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == true)
            {
                goto label_25;
            }
            
            new System.Random() = new System.Random(Seed:  val_118);
            if(val_14 > (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = (丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].一丛丆丂丝丙丝且丞.Chance, hi = (丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].一丛丆丂丝丙丝且丞.Chance})))
            {
                goto label_85;
            }
            
            if((val_1.ContainsKey(key:  (丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].一丛丆丂丝丙丝且丞.LootGroup)) != true)
            {
                    System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒> val_21 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>();
                val_1.set_Item(key:  (丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].一丛丆丂丝丙丝且丞.LootGroup, value:  null);
            }
            
            val_1.Item[(丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].一丛丆丂丝丙丝且丞.LootGroup].Add(item:  (丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].一丛丆丂丝丙丝且丞);
            val_125 = (丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].上丌丘丑一且丆且丏;
            if(val_125 == null)
            {
                    val_125 = null;
                val_125 = new System.Predicate<PGCompany.LootBoxSystem.一丏丙丒世丅丞下东>(object:  new 丞万下丒丒且丁丒三.丌万一一业丝丁丈丝(), method:  System.Boolean 丞万下丒丒且丁丒三.丌万一一业丝丁丈丝::七不丐且丕七下业丈(PGCompany.LootBoxSystem.一丏丙丒世丅丞下东 东丝丄丝丙专丘三丏));
                .上丌丘丑一且丆且丏 = val_125;
            }
            
            List.Enumerator<T> val_25 = this.世丂上丌丞且丁七丏.LootBoxAttrModifier.FindAll(match:  null).GetEnumerator();
            label_66:
            if(((-6550384) & 1) == 0)
            {
                goto label_44;
            }
            
            string val_28 = val_27.丐丏七丌丕丗业且上();
            PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T> val_31 = PGCompany.AttributeSystem.丟丙丂丗丈丂丆丁丒<System.Int32>.丄丞丛业且丛专丁上(丆下丕丅丕一丝丁丛:  val_28.万东丏一且丛东丐丛(), 丙业与丙丗丝不丈东:  val_28 + 48);
            if((this.世三与丒上丅业丗东.ContainsKey(key:  val_28.万东丏一且丛东丐丛())) != true)
            {
                    int val_34 = val_31.业上丙丞丐丄丆丅七();
                PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T> val_36 = PGCompany.AttributeSystem.丒三丝丛丘丛丆丌丂.三丛丞丂丑世丆三丕<System.Int32>(丆下丕丅丕一丝丁丛:  val_31.业上丙丞丐丄丆丅七());
                if(val_36 != null)
            {
                    val_126 = (val_36 == 0) ? 0 : (val_36);
            }
            else
            {
                    val_126 = 0;
            }
            
                this.世三与丒上丅业丗东.set_Item(key:  val_34, value:  0);
            }
            
            PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T> val_38 = PGCompany.AttributeSystem.丒三丝丛丘丛丆丌丂.丈丄专丙丝丑丒丗丈<System.Int32>(世三三丁丕丐丘丐丟:  val_34, 上丄业丑且一万丁丞:  val_31, 专丒丌丆下丐丞丟丞:  0, 一丗丈丛万丄世一丘:  "LootBox");
            mem[1152921560434883704].set_Item(key:  val_38.业上丙丞丐丄丆丅七(), value:  val_38);
            goto label_66;
            label_44:
            var val_114 = 0;
            val_127 = -6550880;
            val_114 = val_114 + 1;
            mem2[0] = 565;
            val_115 = val_115;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_116 = val_114;
            if((val_116 != 1) && ((val_127 + ((0 + 1)) << 2) == 565))
            {
                    var val_115 = 0;
                val_115 = val_115 ^ (val_116 >> 31);
                val_116 = val_116 + val_115;
            }
            
            label_85:
            val_118 = PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<System.Int32>.七万丘且丅世丝丈东(丗专万丄丟丁丈丕丗:  val_118, 丘丒一丄丅丆世丌专:  PGCompany.AttributeSystem.丟丙丂丗丈丂丆丁丒<System.Int32>.丄丞丛业且丛专丁上(丆下丕丅丕一丝丁丛:  33, 丙业与丙丗丝不丈东:  1));
            label_25:
            val_123 = 1;
            label_21:
            if(val_123 < (丞万下丒丒且丁丒三.丌万一一业丝丁丈丝)[1152921560434944288].一丛丆丂丝丙丝且丞.Count)
            {
                goto label_91;
            }
            
            val_121 = 1152921560434268160;
            val_122 = 0;
            label_19:
            if(((-6550352) & 1) != 0)
            {
                goto label_92;
            }
            
            var val_117 = val_116;
            val_117 = val_117 + 1;
            mem2[0] = 652;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_119 = val_117;
            if((val_119 != 1) && ((val_127 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) == 652))
            {
                    var val_118 = 0;
                val_130 = ;
                val_118 = val_118 ^ (val_119 >> 31);
                val_119 = val_119 + val_118;
            }
            else
            {
                    val_130 = 0;
            }
            
            PGCompany.AttributeSystem.丒三丝丛丘丛丆丌丂.丂且不业丂专丛丆东<System.Int32>(丂专三与丕丂三丛下:  val_118, 专丒丌丆下丐丞丟丞:  0);
            if(val_118 != null)
            {
                    val_131 = System.Int32 PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<System.Int32>::业上丙丞丐丄丆丅七();
                val_120 = val_118.业上丙丞丐丄丆丅七();
            }
            else
            {
                    val_131 = System.Int32 PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<System.Int32>::业上丙丞丐丄丆丅七();
                val_120 = 0.业上丙丞丐丄丆丅七();
            }
            
            mem[1152921560434883704].set_Item(key:  val_120, value:  val_118);
            if(val_1.Count == 0)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_45 = val_1.GetEnumerator();
            label_154:
            if(((-6550432) & 1) == 0)
            {
                goto label_142;
            }
            
            ConfiguredValueTaskAwaiter val_47 = val_14.GetAwaiter();
            new 丞万下丒丒且丁丒三.丂七一丐丄丆丁东丟() = new System.Object();
            val_132 = null;
            val_132 = null;
            val_134 = 丞万下丒丒且丁丒三.<>c.<>9__9_1;
            if(val_134 == null)
            {
                    val_134 = null;
                val_134 = new System.Func<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒, System.Int32>(object:  丞万下丒丒且丁丒三.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丞万下丒丒且丁丒三.<>c::专丝丁丈丟丞专丕专(PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 一丐丗丁丞丆丅丟丄));
                丞万下丒丒且丁丒三.<>c.<>9__9_1 = val_134;
            }
            
            .三丟丂且丞丗丕下且 = System.Linq.Enumerable.Max<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>(source:  val_47._value._obj, selector:  null);
            System.Predicate<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒> val_51 = new System.Predicate<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>(object:  new 丞万下丒丒且丁丒三.丂七一丐丄丆丁东丟(), method:  System.Boolean 丞万下丒丒且丁丒三.丂七一丐丄丆丁东丟::丐丘丄丗东丌丑三丝(PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 一丐丗丁丞丆丅丟丄));
            PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 val_53 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>(丑东与丅丐丅丂丞业:  val_47._value._obj.FindAll(match:  null));
            val_2.Add(item:  val_53.LootRateIndex);
            goto label_154;
            label_142:
            val_135 = -6550880;
            val_136 = 丙万丏不丈三丈丈业;
            val_137 = val_117;
            val_138 = val_119 + 1;
            mem2[0] = 843;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || ((val_135 + (((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31))) << 2) != 843))
            {
                goto label_172;
            }
            
            var val_120 = 0;
            val_120 = val_120 ^ ( >> 31);
            val_138 =  + val_120;
            if( != 0)
            {
                goto label_176;
            }
            
            goto label_174;
            label_172:
            if( != 0)
            {
                    val_139 = 0;
            }
            
            if( != 0)
            {
                goto label_176;
            }
            
            label_174:
            label_176:
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_56 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            if(val_2.Count == 0)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            }
            
            System.Collections.Generic.List<TSource> val_57 = System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  null);
            List.Enumerator<T> val_58 = val_2.GetEnumerator();
            label_326:
            if(((-6550480) & 1) == 0)
            {
                goto label_179;
            }
            
            new 丞万下丒丒且丁丒三.丐东丌丆七七丄三丘() = new System.Object();
            .丝上业一丆七丞丄丘 = val_14.丙东专丂世丈丏丁丂();
            System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上> val_61 = new System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上>(object:  new 丞万下丒丒且丁丒三.丐东丌丆七七丄三丘(), method:  System.Boolean 丞万下丒丒且丁丒三.丐东丌丆七七丄三丘::丅丂丝丘丈一丞三丆(PGCompany.LootBoxSystem.丏丛且不丏与万一上 一丐丗丁丞丆丅丟丄));
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上> val_63 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上>();
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上>> val_64 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上>>();
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_65 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            List.Enumerator<T> val_66 = this.世丂上丌丞且丁七丏.LootBoxItemDatas.FindAll(match:  null).GetEnumerator();
            val_140 = 1152921560433915056;
            val_141 = val_139;
            label_199:
            if(((-6550512) & 1) == 0)
            {
                goto label_184;
            }
            
            string val_69 = val_68.丐丏七丌丕丗业且上();
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_186;
            }
            
            if((专且丝丄丙丗丈不丞.丆与丏丞丟丙丁丒不(万丁世丌丁丌丆万丟:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_69 + 40, hi = val_69 + 40}), 世万丈与丑专丝一丞:  1f)) == false)
            {
                goto label_199;
            }
            
            null.Add(item:  val_69);
            goto label_199;
            label_186:
            if((null.ContainsKey(key:  (丞万下丒丒且丁丒三.丐东丌丆七七丄三丘)[1152921560435079456].丝上业一丆七丞丄丘)) != true)
            {
                    System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上> val_75 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上>();
                null.set_Item(key:  (丞万下丒丒且丁丒三.丐东丌丆七七丄三丘)[1152921560435079456].丝上业一丆七丞丄丘, value:  null);
            }
            
            null.Item[(丞万下丒丒且丁丒三.丐东丌丆七七丄三丘)[1152921560435079456].丝上业一丆七丞丄丘].Add(item:  val_69);
            goto label_199;
            label_184:
            val_142 =  + 1;
            mem2[0] = 1147;
            val_143 = 1152921536765414464;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_142 == 1) || ((-6550880 + ((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) != 1147))
            {
                goto label_214;
            }
            
            var val_121 = 0;
            val_121 = val_121 ^ (val_142 >> 31);
            val_142 = val_142 + val_121;
            if(null != null)
            {
                goto label_218;
            }
            
            goto label_216;
            label_214:
            if( != 0)
            {
                    val_141 = 0;
            }
            
            if(null != null)
            {
                goto label_218;
            }
            
            label_216:
            label_218:
            List.Enumerator<T> val_77 = null.GetEnumerator();
            label_224:
            if(((-6550512) & 1) == 0)
            {
                goto label_219;
            }
            
            string val_80 = val_79.丐丏七丌丕丗业且上();
            if((val_80.丙与丌下丆一丕三丗(丏专丕万丘丝与万三:  val_80, 丁丛七上丁丑专丟七:  val_57, 万且丆丙丌丆东丏不: out  val_81)) == false)
            {
                goto label_224;
            }
            
            val_56.AddRange(collection:  val_81);
            val_57.AddRange(collection:  val_81);
            val_65.AddRange(collection:  val_81);
            goto label_224;
            label_219:
            val_145 = val_142 + 1;
            mem2[0] = 1245;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_145 == 1) || ((-6550880 + (((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1) + 1)) << 2) != 1245))
            {
                goto label_232;
            }
            
            var val_122 = 0;
            val_122 = val_122 ^ (val_145 >> 31);
            val_145 = val_145 + val_122;
            if(null != null)
            {
                goto label_236;
            }
            
            goto label_234;
            label_232:
            if( != 0)
            {
                    val_141 = 0;
            }
            
            if(null != null)
            {
                goto label_236;
            }
            
            label_234:
            label_236:
            Dictionary.Enumerator<TKey, TValue> val_83 = null.GetEnumerator();
            label_295:
            if(((-6550560) & 1) == 0)
            {
                goto label_237;
            }
            
            ConfiguredValueTaskAwaiter val_84 = val_14.GetAwaiter();
            new 丞万下丒丒且丁丒三.丛丘丒丂世丟世丆丑() = new System.Object();
            System.Collections.Generic.Dictionary<PGCompany.LootBoxSystem.丏丛且不丏与万一上, System.Single> val_86 = new System.Collections.Generic.Dictionary<PGCompany.LootBoxSystem.丏丛且不丏与万一上, System.Single>();
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上> val_87 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上>();
            List.Enumerator<T> val_88 = val_84._value._obj.GetEnumerator();
            val_146 = 1152921560433915056;
            label_243:
            if(((-6550512) & 1) == 0)
            {
                goto label_239;
            }
            
            string val_91 = val_90.丐丏七丌丕丗业且上();
            if((val_91.丙与丌下丆一丕三丗(丏专丕万丘丝与万三:  val_91, 丁丛七上丁丑专丟七:  val_57, 万且丆丙丌丆东丏不: out  val_92)) == false)
            {
                goto label_243;
            }
            
            val_14 = val_91 + 40;
            string val_97 = "availableRewardsToWeight:"("availableRewardsToWeight:") + System.String.Format(format:  " {0} => {1}", arg0:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_92), arg1:  val_14)(System.String.Format(format:  " {0} => {1}", arg0:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_92), arg1:  val_14));
            null.Add(item:  val_91);
            goto label_243;
            label_239:
            val_147 = val_145 + 1;
            mem2[0] = 1412;
            val_148 = val_141;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (val_98 != 1412))
            {
                goto label_255;
            }
            
            var val_123 = 0;
            val_123 = val_123 ^ 0;
            val_147 =  + val_123;
            if(null != null)
            {
                goto label_259;
            }
            
            goto label_257;
            label_255:
            if( != 0)
            {
                    val_148 = 0;
            }
            
            if(null != null)
            {
                goto label_259;
            }
            
            label_257:
            label_259:
            val_150 = null;
            if(null.Count == 0)
            {
                goto label_295;
            }
            
            if((((val_99 + 295) & 2) != 0) && ((val_99 + 216) == 0))
            {
                    val_150 = null;
            }
            
            val_152 = 丞万下丒丒且丁丒三.<>c.<>9__9_4;
            if(val_152 == null)
            {
                    val_152 = null;
                val_152 = new System.Func<PGCompany.LootBoxSystem.丏丛且不丏与万一上, System.Int32>(object:  丞万下丒丒且丁丒三.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丞万下丒丒且丁丒三.<>c::业丄丑业丒丘万不专(PGCompany.LootBoxSystem.丏丛且不丏与万一上 一丐丗丁丞丆丅丟丄));
                丞万下丒丒且丁丒三.<>c.<>9__9_4 = val_152;
                val_146 = 1152921560433915056;
            }
            
            int val_101 = System.Linq.Enumerable.Max<PGCompany.LootBoxSystem.丏丛且不丏与万一上>(source:  null, selector:  null);
            if(new 丞万下丒丒且丁丒三.丛丘丒丂世丟世丆丑() != null)
            {
                    .三丟丂且丞丗丕下且 = val_101;
            }
            else
            {
                    .三丟丂且丞丗丕下且 = val_101;
            }
            
            val_153 = (丞万下丒丒且丁丒三.丛丘丒丂世丟世丆丑)[1152921560435124512].丟丕丁与丝丝丂下丕;
            if(val_153 == null)
            {
                    val_153 = null;
                val_153 = new System.Predicate<PGCompany.LootBoxSystem.丏丛且不丏与万一上>(object:  new 丞万下丒丒且丁丒三.丛丘丒丂世丟世丆丑(), method:  System.Boolean 丞万下丒丒且丁丒三.丛丘丒丂世丟世丆丑::下专丒丛与下丞丄丈(PGCompany.LootBoxSystem.丏丛且不丏与万一上 一丐丗丁丞丆丅丟丄));
                .丟丕丁与丝丝丂下丕 = val_153;
            }
            
            List.Enumerator<T> val_104 = null.FindAll(match:  null).GetEnumerator();
            label_276:
            if(((-6550512) & 1) == 0)
            {
                goto label_271;
            }
            
            string val_107 = val_106.丐丏七丌丕丗业且上();
            val_86.Add(key:  val_107, value:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_107 + 40, hi = val_107 + 40}));
            goto label_276;
            label_271:
            val_154 =  + 1;
            mem2[0] = 1582;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_154 == 1) || ((-6550880 + ((val_149 + 1)) << 2) != 1582))
            {
                goto label_284;
            }
            
            val_156 = 1152921536765414464;
            val_157 = val_65;
            val_158 = val_86;
            var val_124 = 0;
            val_124 = val_124 ^ (val_154 >> 31);
            val_154 = val_154 + val_124;
            if(val_158 != 0)
            {
                goto label_288;
            }
            
            goto label_286;
            label_284:
            val_156 = 1152921536765414464;
            val_157 = val_65;
            val_158 = val_86;
            if(val_158 != 0)
            {
                goto label_288;
            }
            
            label_286:
            label_288:
            if(val_86.Count == 0)
            {
                goto label_295;
            }
            
            PGCompany.LootBoxSystem.丏丛且不丏与万一上 val_111 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.LootBoxSystem.丏丛且不丏与万一上>(丑东与丅丐丅丂丞业:  val_86);
            bool val_113 = val_111.丙与丌下丆一丕三丗(丏专丕万丘丝与万三:  val_111, 丁丛七上丁丑专丟七:  val_57, 万且丆丙丌丆东丏不: out  val_112);
            val_56.AddRange(collection:  val_112);
            val_57.AddRange(collection:  val_112);
            val_65.AddRange(collection:  val_112);
            goto label_295;
            label_237:
            val_159 = val_145 + 1;
            mem2[0] = 1680;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_159 != 1) && ((-6550880 + ((((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1) + 1) + 1)) << 2) == 1680))
            {
                    val_160 = val_65;
                var val_125 = 0;
                val_125 = val_125 ^ (val_159 >> 31);
                val_159 = val_159 + val_125;
            }
            else
            {
                    val_160 = val_65;
            }
            
            mem[1152921560434883688].Add(item:  new 七丘丟专世丅丂丙丑() {三三丄丂丞不丙三丙 = (丞万下丒丒且丁丒三.丐东丌丆七七丄三丘)[1152921560435079456].丝上业一丆七丞丄丘, 下丐丐丁与丂下世七 = val_65});
            goto label_326;
            label_179:
            val_161 = -6550880;
            val_162 =  + 1;
            mem2[0] = 1721;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_162 != 1)
            {
                    if( == 0)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            }
            
                if((val_161 + ((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) != 1721)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            }
            
                return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            }
            
            if( == 0)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            }
            
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        }
        private bool 丙与丌下丆一丕三丗(PGCompany.LootBoxSystem.丏丛且不丏与万一上 丏专丕万丘丝与万三, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丁丛七上丁丑专丟七, out System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 万且丆丙丌丆东丏不)
        {
            var val_8;
            .丁丛七上丁丑专丟七 = 丁丛七上丁丑专丟七;
            val_8 = null;
            val_8 = null;
            if((丞万下丒丒且丁丒三.<>c.<>9__10_0) == null)
            {
                goto label_5;
            }
            
            label_12:
            System.Collections.Generic.List<T> val_2 = 丏专丕万丘丝与万三.Rewards.FindAll(match:  丞万下丒丒且丁丒三.<>c.<>9__10_0);
            万且丆丙丌丆东丏不 = val_2;
            int val_4 = val_2.RemoveAll(match:  new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  new 丞万下丒丒且丁丒三.下丌丛三下专丘丐丕(), method:  System.Boolean 丞万下丒丒且丁丒三.下丌丛三下专丘丐丕::丁与丒丅丐丙丟丒万(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛)));
            return (bool)(万且丆丙丌丆东丏不.Count > 0) ? 1 : 0;
            label_5:
            丞万下丒丒且丁丒三.<>c.<>9__10_0 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  丞万下丒丒且丁丒三.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丞万下丒丒且丁丒三.<>c::业丞七万东丐七专丗(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
            if(丏专丕万丘丝与万三.Rewards != null)
            {
                goto label_12;
            }
            
            goto label_12;
        }
        private bool 丒丈世丞万丙丑世丑(PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 一丐丗丁丞丆丅丟丄)
        {
            return (bool)(一丐丗丁丞丆丅丟丄.LootBoxIndex == this.丟不丛丑一丗丄业丟().业东丅东丌上丗丑不()) ? 1 : 0;
        }
    
    }

}
