using UnityEngine;

namespace PGCompany.ShopSystem
{
    internal class 丄万上专一世丛万一
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<string, PGCompany.ShopSystem.丄丛丏丅丈且丏业业> 丒丆业丄东三丗下七;
        private readonly System.Collections.Generic.Dictionary<string, PGCompany.ShopSystem.丈丈世丏丂丄丂万丒> 上丅丛业上丛丛世与;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.ShopSystem.不丘丁东丆丏与丌七> 且丑不丛丏丏丐丄丐;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.ShopSystem.三丑丄丆丌丏丆丘上> 丗专丞丑且丆丙专丈;
        
        // Methods
        internal 丄万上专一世丛万一(System.Collections.Generic.List<PGCompany.ShopSystem.丄丛丏丅丈且丏业业> 一丄丑且下丘业丏丐, System.Collections.Generic.List<PGCompany.ShopSystem.丈丈世丏丂丄丂万丒> 丐万丂丞万丌丐丞世, System.Collections.Generic.List<PGCompany.ShopSystem.不丘丁东丆丏与丌七> 丗丛丙丟一丒一与丈)
        {
            int val_8;
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.ShopSystem.三丑丄丆丌丏丆丘上> val_32;
            var val_33;
            var val_34;
            System.Collections.Generic.List<PGCompany.ShopSystem.不丘丁东丆丏与丌七> val_35;
            var val_36;
            System.Comparison<PGCompany.ShopSystem.不丘丁东丆丏与丌七> val_38;
            var val_39;
            int val_40;
            var val_41;
            val_1 = new System.Object();
            this.丒丆业丄东三丗下七 = new System.Collections.Generic.Dictionary<System.String, PGCompany.ShopSystem.丄丛丏丅丈且丏业业>();
            this.上丅丛业上丛丛世与 = new System.Collections.Generic.Dictionary<System.String, PGCompany.ShopSystem.丈丈世丏丂丄丂万丒>();
            this.且丑不丛丏丏丐丄丐 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.ShopSystem.不丘丁东丆丏与丌七>();
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.ShopSystem.三丑丄丆丌丏丆丘上> val_5 = null;
            val_32 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.ShopSystem.三丑丄丆丌丏丆丘上>();
            this.丗专丞丑且丆丙专丈 = val_32;
            if(一丄丑且下丘业丏丐 == null)
            {
                goto label_19;
            }
            
            List.Enumerator<T> val_6 = 一丄丑且下丘业丏丐.GetEnumerator();
            label_11:
            if(((-96035808) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_9 = val_8.丐丏七丌丕丗业且上();
            if(val_9 == null)
            {
                goto label_11;
            }
            
            if((this.丒丆业丄东三丗下七.ContainsKey(key:  val_9.m_stringLength)) == false)
            {
                goto label_5;
            }
            
            val_33 = null;
            val_33 = null;
            string val_11 = "duplicate shop id: \'"("duplicate shop id: \'") + val_9.m_stringLength + "\'";
            if(LogsSystem.丆丏丌丆丆丑丞不丈.丕万丂丕丞丙东丅丄 != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_5:
            this.丒丆业丄东三丗下七.Add(key:  val_9.m_stringLength, value:  val_9);
            goto label_11;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_1 != null)
            {
                goto label_12;
            }
            
            goto label_37;
            label_19:
            if(val_1 == null)
            {
                goto label_37;
            }
            
            label_12:
            List.Enumerator<T> val_12 = val_1.GetEnumerator();
            label_30:
            if(((-96035840) & 1) == 0)
            {
                goto label_21;
            }
            
            string val_13 = val_8.丐丏七丌丕丗业且上();
            if(val_13 == null)
            {
                goto label_30;
            }
            
            if((this.上丅丛业上丛丛世与.ContainsKey(key:  val_13.m_stringLength)) == false)
            {
                goto label_24;
            }
            
            val_34 = null;
            val_34 = null;
            string val_15 = "duplicate tab id: \'"("duplicate tab id: \'") + val_13.m_stringLength + "\'";
            if(LogsSystem.丆丏丌丆丆丑丞不丈.丕万丂丕丞丙东丅丄 != null)
            {
                goto label_30;
            }
            
            goto label_30;
            label_24:
            this.上丅丛业上丛丛世与.Add(key:  val_13.m_stringLength, value:  val_13);
            goto label_30;
            label_21:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            label_37:
            val_35 = 丗丛丙丟一丒一与丈;
            if(val_35 == 0)
            {
                goto label_38;
            }
            
            val_36 = null;
            val_36 = null;
            val_38 = 丄万上专一世丛万一.<>c.<>9__4_0;
            if(val_38 == null)
            {
                    System.Comparison<PGCompany.ShopSystem.不丘丁东丆丏与丌七> val_16 = null;
                val_38 = val_16;
                val_16 = new System.Comparison<PGCompany.ShopSystem.不丘丁东丆丏与丌七>(object:  丄万上专一世丛万一.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丄万上专一世丛万一.<>c::丁与丑三丗上丏丁丙(PGCompany.ShopSystem.不丘丁东丆丏与丌七 丛丏丗丈不业丈丘且, PGCompany.ShopSystem.不丘丁东丆丏与丌七 且丕东丞业专丗丕专));
                丄万上专一世丛万一.<>c.<>9__4_0 = val_38;
                val_35 = 丗丛丙丟一丒一与丈;
            }
            
            val_35.Sort(comparison:  val_16);
            List.Enumerator<T> val_17 = val_35.GetEnumerator();
            val_32 = 1152921542068226016;
            label_53:
            if(((-96035872) & 1) == 0)
            {
                goto label_44;
            }
            
            string val_18 = val_8.丐丏七丌丕丗业且上();
            if(val_18 == null)
            {
                goto label_53;
            }
            
            if((this.且丑不丛丏丏丐丄丐.ContainsKey(key:  val_18.m_stringLength)) == false)
            {
                goto label_47;
            }
            
            val_39 = null;
            val_39 = null;
            val_8 = val_18.m_stringLength;
            string val_20 = System.String.Format(format:  "duplicate offer id: \'{0}\'", arg0:  val_8);
            if(LogsSystem.丆丏丌丆丆丑丞不丈.丕万丂丕丞丙东丅丄 != null)
            {
                goto label_53;
            }
            
            goto label_53;
            label_47:
            this.且丑不丛丏丏丐丄丐.Add(key:  val_18.m_stringLength, value:  val_18);
            goto label_53;
            label_38:
            val_40 = 0;
            goto label_54;
            label_44:
            val_41 = 0;
            val_40 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (454 != 454))
            {
                goto label_63;
            }
            
            label_54:
            val_41 = 0;
            goto label_65;
            label_63:
            if( != 0)
            {
                    val_40 = 0;
            }
            
            label_65:
            Dictionary.Enumerator<TKey, TValue> val_21 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_69:
            if(((-96035920) & 1) == 0)
            {
                goto label_70;
            }
            
            ConfiguredValueTaskAwaiter val_23 = val_8.GetAwaiter();
            System.Collections.Generic.List<System.String> val_28 = new System.Collections.Generic.List<System.String>();
            bool val_29 = this.丑丞丐与丙丒丕丛丏(下丈与下丙三丄丑万:  val_23._value._obj.丙东专丂世丈丏丁丂(), 丐万丂丞万丌丐丞世: ref  val_28);
            new PGCompany.ShopSystem.三丑丄丆丌丏丆丘上() = new PGCompany.ShopSystem.三丑丄丆丌丏丆丘上(三万不丄丏丝丄丗丙:  this.丅业丈专丏专三丒丛(下丈与下丙三丄丑万:  val_23._value._obj.丙东专丂世丈丏丁丂()), 丐万丂丞万丌丐丞世:  val_28, 丑七且丙丂丌丙下丞:  val_23._value._obj);
            this.丗专丞丑且丆丙专丈.Add(key:  val_23._value._obj.丙东专丂世丈丏丁丂(), value:  new PGCompany.ShopSystem.三丑丄丆丌丏丆丘上());
            goto label_69;
            label_70:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(1 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(575 == 575)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        internal bool 丘三业东专丂丘世丙(string 丑上丅丏七万东丗丕, ref System.Collections.Generic.List<string> 专丂丕丗丗东世丞下)
        {
            Dictionary.Enumerator<TKey, TValue> val_1 = this.上丅丛业上丛丛世与.GetEnumerator();
            label_6:
            if(((-95794872) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
            if((System.String.op_Equality(a:  0, b:  丑上丅丏七万东丗丕)) == false)
            {
                goto label_6;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_2._value._obj.丐丏七丌丕丗业且上());
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)System.Linq.Enumerable.Any<System.String>(source:  专丂丕丗丗东世丞下);
        }
        internal bool 丘三业东专丂丘世丙(string 丑上丅丏七万东丗丕, string 丞丑丞丒丙丄丄且丐, ref System.Collections.Generic.List<string> 专丂丕丗丗东世丞下)
        {
            string val_5;
            var val_18;
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.ShopSystem.丈丈世丏丂丄丂万丒>.万世丅七一专丕丞不();
            int val_2 = this.上丅丛业上丛丛世与.Count;
            Dictionary.Enumerator<TKey, TValue> val_3 = this.上丅丛业上丛丛世与.GetEnumerator();
            val_18 = 1152921560345606896;
            label_10:
            if(((-95628752) & 1) == 0)
            {
                goto label_6;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_5.GetAwaiter();
            if((System.String.op_Equality(a:  val_5, b:  丑上丅丏七万东丗丕)) == false)
            {
                goto label_10;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_7._value._obj.丐丏七丌丕丗业且上());
            goto label_10;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((System.Linq.Enumerable.Any<PGCompany.ShopSystem.丈丈世丏丂丄丂万丒>(source:  val_1)) == false)
            {
                goto label_31;
            }
            
            List.Enumerator<T> val_11 = val_1.GetEnumerator();
            val_18 = 1152921542068447904;
            label_25:
            if(((-95628792) & 1) == 0)
            {
                goto label_21;
            }
            
            string val_12 = 0.丐丏七丌丕丗业且上();
            if((System.String.op_Equality(a:  val_12.m_stringLength, b:  丞丑丞丒丙丄丄且丐)) == false)
            {
                goto label_25;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_12.m_stringLength);
            goto label_25;
            label_21:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_31:
            PGCompany.东丑丒丗一丞下丙丙<T> val_14 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.ShopSystem.丈丈世丏丂丄丂万丒>.万世丅七一专丕丞不();
            return (bool)System.Linq.Enumerable.Any<System.String>(source:  专丂丕丗丗东世丞下);
        }
        internal bool 世业丑丄世下丟丐丅(string 丑上丅丏七万东丗丕, ref System.Collections.Generic.List<int> 专丂丕丗丗东世丞下)
        {
            string val_4;
            System.Collections.Generic.IEnumerable<TSource> val_14;
            var val_16;
            var val_17;
            var val_18;
            val_14 = 1152921560346006416;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.上丅丛业上丛丛世与.GetEnumerator();
            val_16 = 0;
            val_17 = 0;
            var val_14 = 0;
            label_23:
            if(((-95463664) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if((System.String.op_Equality(a:  val_4, b:  丑上丅丏七万东丗丕)) == false)
            {
                goto label_23;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_7 = mem[1152921560345970352].GetEnumerator();
            label_10:
            if(((-95463728) & 1) == 0)
            {
                goto label_6;
            }
            
            ConfiguredValueTaskAwaiter val_8 = val_4.GetAwaiter();
            if((System.String.op_Equality(a:  val_4, b:  val_5._value._obj.丐丏七丌丕丗业且上())) == false)
            {
                goto label_10;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_8._value._obj.丙东专丂世丈丏丁丂());
            goto label_10;
            label_6:
            val_14 = val_14 + 1;
            mem2[0] = 129;
            val_18 = val_17;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_14 == 1) || ((1152921560345958000 + ((0 + 1)) << 2) != 129))
            {
                goto label_20;
            }
            
            var val_15 = 0;
            val_15 = val_15 ^ (val_14 >> 31);
            val_14 = val_14 + val_15;
            goto label_23;
            label_20:
            if( == 0)
            {
                goto label_23;
            }
            
            goto label_23;
            label_2:
            val_14 = val_14 + 1;
            mem2[0] = 154;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_14 != 1)
            {
                    if(( == 0) || ((1152921560345958000 + ((0 + 1)) << 2) == 154))
            {
                    return (bool)System.Linq.Enumerable.Any<System.Int32>(source:  null);
            }
            
                return (bool)System.Linq.Enumerable.Any<System.Int32>(source:  null);
            }
            
            if( != 0)
            {
                    return (bool)System.Linq.Enumerable.Any<System.Int32>(source:  null);
            }
            
            return (bool)System.Linq.Enumerable.Any<System.Int32>(source:  null);
        }
        internal bool 专丗东丕专丁丘下丂(string 丑上丅丏七万东丗丕, ref System.Collections.Generic.List<PGCompany.ShopSystem.三丑丄丆丌丏丆丘上> 专丂丕丗丗东世丞下)
        {
            string val_3;
            string val_4;
            System.Collections.Generic.IEnumerable<TSource> val_13;
            var val_15;
            var val_16;
            var val_17;
            val_13 = 1152921560346158192;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.上丅丛业上丛丛世与.GetEnumerator();
            val_15 = 0;
            val_16 = 0;
            var val_13 = 0;
            label_23:
            if(((-95311888) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if((System.String.op_Equality(a:  val_4, b:  丑上丅丏七万东丗丕)) == false)
            {
                goto label_23;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_7 = mem[1152921560346122136].GetEnumerator();
            label_10:
            if(((-95311952) & 1) == 0)
            {
                goto label_6;
            }
            
            ConfiguredValueTaskAwaiter val_8 = val_4.GetAwaiter();
            if((System.String.op_Equality(a:  val_3, b:  val_5._value._obj.丐丏七丌丕丗业且上())) == false)
            {
                goto label_10;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_8._value._obj);
            goto label_10;
            label_6:
            val_13 = val_13 + 1;
            mem2[0] = 129;
            val_17 = val_16;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_13 == 1) || ((1152921560346109776 + ((0 + 1)) << 2) != 129))
            {
                goto label_20;
            }
            
            var val_14 = 0;
            val_14 = val_14 ^ (val_13 >> 31);
            val_13 = val_13 + val_14;
            goto label_23;
            label_20:
            if( == 0)
            {
                goto label_23;
            }
            
            goto label_23;
            label_2:
            val_13 = val_13 + 1;
            mem2[0] = 154;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_13 != 1)
            {
                    if(( == 0) || ((1152921560346109776 + ((0 + 1)) << 2) == 154))
            {
                    return (bool)System.Linq.Enumerable.Any<PGCompany.ShopSystem.三丑丄丆丌丏丆丘上>(source:  null);
            }
            
                return (bool)System.Linq.Enumerable.Any<PGCompany.ShopSystem.三丑丄丆丌丏丆丘上>(source:  null);
            }
            
            if( != 0)
            {
                    return (bool)System.Linq.Enumerable.Any<PGCompany.ShopSystem.三丑丄丆丌丏丆丘上>(source:  null);
            }
            
            return (bool)System.Linq.Enumerable.Any<PGCompany.ShopSystem.三丑丄丆丌丏丆丘上>(source:  null);
        }
        internal bool 世世三丏七七丗丒世(string 丐丅丒专丛丏上与业, bool 丙且丙丛业一丟丌丘, ref System.Collections.Generic.List<PGCompany.ShopSystem.三丑丄丆丌丏丆丘上> 专丂丕丗丗东世丞下)
        {
            var val_7;
            var val_16;
            bool val_17;
            var val_18;
            System.Collections.Generic.List<PGCompany.ShopSystem.三丑丄丆丌丏丆丘上> val_19;
            val_16 = 1152921560346317152;
            val_17 = 丙且丙丛业一丟丌丘;
            val_18 = 1152921537830280192;
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            if((this.丂丑且丏三丛丏丙丏(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业, 丙且丙丛业一丟丌丘:  val_17, 专丂丕丗丗东世丞下: ref  val_1, 上一丟丏下三丏丗丄:  0)) == false)
            {
                goto label_4;
            }
            
            List.Enumerator<T> val_5 = val_1.GetEnumerator();
            val_17 = 1152921525710254080;
            val_18 = 1152921560346238624;
            label_13:
            if(((-95152896) & 1) == 0)
            {
                goto label_6;
            }
            
            int val_8 = val_7.丙东专丂世丈丏丁丂();
            if((this.丗专丞丑且丆丙专丈.ContainsKey(key:  val_8)) == false)
            {
                goto label_13;
            }
            
            PGCompany.ShopSystem.三丑丄丆丌丏丆丘上 val_10 = this.丗专丞丑且丆丙专丈.Item[val_8];
            if((val_10 == null) || (val_10.丅业东万丌丕上丌丄() == false))
            {
                goto label_13;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_10);
            goto label_13;
            label_4:
            val_16 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            val_19 = 0;
            return (bool)System.Linq.Enumerable.Any<PGCompany.ShopSystem.三丑丄丆丌丏丆丘上>(source:  val_19 = 专丂丕丗丗东世丞下);
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            return (bool)System.Linq.Enumerable.Any<PGCompany.ShopSystem.三丑丄丆丌丏丆丘上>(source:  val_19);
        }
        internal bool 丒丄丙丐丑丁丕丅专(string 丐丅丒专丛丏上与业, bool 丙且丙丛业一丟丌丘, ref System.Collections.Generic.List<int> 专丂丕丗丗东世丞下)
        {
            return this.丂丑且丏三丛丏丙丏(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业, 丙且丙丛业一丟丌丘:  丙且丙丛业一丟丌丘, 专丂丕丗丗东世丞下: ref  System.Collections.Generic.List<System.Int32> val_2 = 专丂丕丗丗东世丞下, 上一丟丏下三丏丗丄:  0);
        }
        private bool 丂丑且丏三丛丏丙丏(string 丐丅丒专丛丏上与业, bool 丙且丙丛业一丟丌丘, ref System.Collections.Generic.List<int> 专丂丕丗丗东世丞下, int 上一丟丏下三丏丗丄 = 0)
        {
            string val_4;
            LogsSystem.丟丝上丗丆万丘丞万 val_17;
            System.Collections.Generic.Dictionary<System.String, PGCompany.ShopSystem.丈丈世丏丂丄丂万丒> val_18;
            var val_19;
            var val_20;
            System.Collections.Generic.List<System.Int32> val_21;
            val_17 = 1152921560346610752;
            val_18 = 丙且丙丛业一丟丌丘;
            if(上一丟丏下三丏丗丄 >= 4)
            {
                goto label_1;
            }
            
            if((this.上丅丛业上丛丛世与.ContainsKey(key:  丐丅丒专丛丏上与业)) == false)
            {
                goto label_3;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            val_19 = 1152921560345352640;
            label_9:
            if(((-94859312) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_4.GetAwaiter();
            if((System.String.op_Equality(a:  val_4, b:  丐丅丒专丛丏上与业)) == false)
            {
                goto label_9;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_6._value._obj.丙东专丂世丈丏丁丂());
            goto label_9;
            label_1:
            val_20 = null;
            val_20 = null;
            val_17 = LogsSystem.丆丏丌丆丆丑丞不丈.丕万丂丕丞丙东丅丄;
            label_3:
            val_21 = 0;
            return (bool)System.Linq.Enumerable.Any<System.Int32>(source:  val_21 = 专丂丕丗丗东世丞下);
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_18 == true)
            {
                goto label_14;
            }
            
            goto label_37;
            label_14:
            val_18 = this.上丅丛业上丛丛世与;
            Dictionary.Enumerator<TKey, TValue> val_9 = val_18.GetEnumerator();
            val_19 = 1152921560345608944;
            label_29:
            if(((-94859368) & 1) == 0)
            {
                goto label_25;
            }
            
            ConfiguredValueTaskAwaiter val_10 = 0.GetAwaiter();
            if((System.String.op_Equality(a:  val_6._value._obj, b:  丐丅丒专丛丏上与业)) == false)
            {
                goto label_29;
            }
            
            string val_12 = val_10._value._obj.丐丏七丌丕丗业且上();
            int val_13 = 上一丟丏下三丏丗丄 + 1;
            goto label_29;
            label_25:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_37:
            return (bool)System.Linq.Enumerable.Any<System.Int32>(source:  val_21);
        }
        internal PGCompany.ShopSystem.三丑丄丆丌丏丆丘上 万世丏丘丟丕世丙万(int 下丈与下丙三丄丑万)
        {
            var val_3;
            if((this.丗专丞丑且丆丙专丈.ContainsKey(key:  下丈与下丙三丄丑万)) != false)
            {
                    PGCompany.ShopSystem.三丑丄丆丌丏丆丘上 val_2 = this.丗专丞丑且丆丙专丈.Item[下丈与下丙三丄丑万];
                return (PGCompany.ShopSystem.三丑丄丆丌丏丆丘上)val_3;
            }
            
            val_3 = 0;
            return (PGCompany.ShopSystem.三丑丄丆丌丏丆丘上)val_3;
        }
        internal string 一丁专上下专丕丑不(string 丐丅丒专丛丏上与业)
        {
            string val_3;
            string val_4;
            val_3 = 丐丅丒专丛丏上与业;
            if((this.上丅丛业上丛丛世与.ContainsKey(key:  val_3)) != false)
            {
                    val_3 = this.上丅丛业上丛丛世与.Item[val_3];
                val_4 = val_2.TabParent;
                return (string)val_4;
            }
            
            val_4 = 0;
            return (string)val_4;
        }
        internal string 丅业丈专丏专三丒丛(int 下丈与下丙三丄丑万)
        {
            var val_12;
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            bool val_3 = this.丑丞丐与丙丒丕丛丏(下丈与下丙三丄丑万:  下丈与下丙三丄丑万, 丐万丂丞万丌丐丞世: ref  val_1);
            if((((System.Linq.Enumerable.Any<System.String>(source:  val_1)) != false) && ((this.上丅丛业上丛丛世与.TryGetValue(key:  val_1.Item[0], value: out  0)) != false)) && ((this.丒丆业丄东三丗下七.TryGetValue(key:  28563616, value: out  0)) != false))
            {
                    val_12 = 11993091;
            }
            else
            {
                    val_12 = 0;
            }
            
            if((PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不()) != null)
            {
                    return (string)val_12;
            }
            
            return (string)val_12;
        }
        internal bool 丑丞丐与丙丒丕丛丏(int 下丈与下丙三丄丑万, ref System.Collections.Generic.List<string> 丐万丂丞万丌丐丞世)
        {
            System.Collections.Generic.List<System.String> val_5;
            var val_6;
            val_5 = 1152921560347211184;
            if((this.且丑不丛丏丏丐丄丐.ContainsKey(key:  下丈与下丙三丄丑万)) != false)
            {
                    if(this.且丑不丛丏丏丐丄丐.Item[下丈与下丙三丄丑万] == null)
            {
                    return (bool)val_6;
            }
            
                if((this.丄丌丒业丁丛丄丌丂(丂丅丑丙丟丏丝业七:  val_2.ShopTab, 丐万丂丞万丌丐丞世: ref  System.Collections.Generic.List<System.String> val_3 = 丐万丂丞万丌丐丞世)) != false)
            {
                    val_5 = val_3;
                val_5.Reverse();
                val_6 = 1;
                return (bool)val_6;
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        private bool 丄丌丒业丁丛丄丌丂(string 丂丅丑丙丟丏丝业七, ref System.Collections.Generic.List<string> 丐万丂丞万丌丐丞世)
        {
            string val_4;
            string val_5;
            val_4 = 丂丅丑丙丟丏丝业七;
            goto label_0;
            label_9:
            PGCompany.ShopSystem.丈丈世丏丂丄丂万丒 val_1 = this.上丅丛业上丛丛世与.Item[val_4];
            丐万丂丞万丌丐丞世.Add(item:  val_1.Id);
            val_5 = val_1.TabParent;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) == true)
            {
                    return System.Linq.Enumerable.Any<System.String>(source:  丐万丂丞万丌丐丞世);
            }
            
            val_4 = val_1.TabParent;
            label_0:
            val_5 = this.上丅丛业上丛丛世与;
            if((val_5.ContainsKey(key:  val_4)) == true)
            {
                goto label_9;
            }
            
            return System.Linq.Enumerable.Any<System.String>(source:  丐万丂丞万丌丐丞世);
        }
    
    }

}
