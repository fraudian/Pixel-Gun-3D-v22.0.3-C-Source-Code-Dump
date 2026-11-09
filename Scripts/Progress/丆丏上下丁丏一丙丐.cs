using UnityEngine;

namespace Progress
{
    internal class 丆丏上下丁丏一丙丐 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        internal System.Collections.Generic.HashSet<string> 专丈丘丐丞丛世三丛;
        internal System.Collections.Generic.HashSet<string> 丟丏丂上丗不三业丈;
        internal System.Collections.Generic.HashSet<string> 丟丏下一丟丕丂丂下;
        internal System.Collections.Generic.Dictionary<string, int> 丑业丑丟丘丕三世专;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 34;
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丆丏上下丁丏一丙丐.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丆丏上下丁丏一丙丐.丐丌丞上世丛丐丏丛;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(this.专丈丘丐丞丛世三丛.Count >= 1)
            {
                    val_1.Add(key:  "w", value:  System.Linq.Enumerable.ToList<System.String>(source:  this.专丈丘丐丞丛世三丛));
            }
            
            if(this.丟丏丂上丗不三业丈.Count >= 1)
            {
                    val_1.Add(key:  "s", value:  System.Linq.Enumerable.ToList<System.String>(source:  this.丟丏丂上丗不三业丈));
            }
            
            if(this.丟丏下一丟丕丂丂下.Count >= 1)
            {
                    val_1.Add(key:  "c", value:  System.Linq.Enumerable.ToList<System.String>(source:  this.丟丏下一丟丕丂丂下));
            }
            
            if(this.丑业丑丟丘丕三世专.Count < 1)
            {
                    return (object)val_1;
            }
            
            val_1.Add(key:  "cc", value:  this.丑业丑丟丘丕三世专);
            return (object)val_1;
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_5;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            this.专丈丘丐丞丛世三丛.Clear();
            this.丟丏丂上丗不三业丈.Clear();
            this.丟丏下一丟丕丂丂下.Clear();
            this.丑业丑丟丘丕三世专.Clear();
            val_26 = 1152921504689381376;
            val_27 = 1;
            if((0.ContainsKey(key:  "w")) == false)
            {
                goto label_23;
            }
            
            object val_2 = 0.Item["w"];
            if(val_2 == null)
            {
                goto label_23;
            }
            
            List.Enumerator<T> val_3 = val_2.GetEnumerator();
            label_16:
            if(((-2084435344) & 1) == 0)
            {
                goto label_13;
            }
            
            bool val_7 = this.专丈丘丐丞丛世三丛.Add(item:  val_5.丐丏七丌丕丗业且上());
            goto label_16;
            label_13:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_26 = 1152921504689381376;
            if(val_27 != 0)
            {
                goto label_18;
            }
            
            goto label_24;
            label_23:
            if(val_27 == 0)
            {
                goto label_24;
            }
            
            label_18:
            label_24:
            if((0.ContainsKey(key:  "s")) == false)
            {
                goto label_39;
            }
            
            object val_9 = 0.Item["s"];
            if(val_9 == null)
            {
                goto label_39;
            }
            
            List.Enumerator<T> val_10 = val_9.GetEnumerator();
            label_33:
            if(((-2084435344) & 1) == 0)
            {
                goto label_30;
            }
            
            bool val_12 = this.丟丏丂上丗不三业丈.Add(item:  val_5.丐丏七丌丕丗业且上());
            goto label_33;
            label_30:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_26 = 1152921504689381376;
            if(val_27 != 0)
            {
                goto label_34;
            }
            
            goto label_40;
            label_39:
            if(val_27 == 0)
            {
                goto label_40;
            }
            
            label_34:
            label_40:
            if((0.ContainsKey(key:  "c")) != false)
            {
                    object val_14 = 0.Item["c"];
            }
            
            val_28 = 0;
            label_78:
            val_29 = 0;
            label_79:
            if(val_27 == 0)
            {
                goto label_81;
            }
            
            label_80:
            label_81:
            if((0.ContainsKey(key:  "cc")) == false)
            {
                    return;
            }
            
            object val_16 = 0.Item["cc"];
            if(val_16 == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_18 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == ) ? (val_16) : 0.GetEnumerator();
            val_27 = 1152921516595683744;
            label_57:
            if(((-2084435384) & 1) == 0)
            {
                goto label_53;
            }
            
            ConfiguredValueTaskAwaiter val_19 = 0.GetAwaiter();
            this.丑业丑丟丘丕三世专.Add(key:  val_19._value._obj.丐丏七丌丕丗业且上(), value:  System.Convert.ToInt32(value:  val_19._value._obj));
            goto label_57;
            label_61:
            if(((-2084435344) & 1) == 0)
            {
                goto label_58;
            }
            
            bool val_24 = this.丟丏下一丟丕丂丂下.Add(item:  val_5.丐丏七丌丕丗业且上());
            goto label_61;
            label_58:
            val_30 = 0;
            val_31 = 0;
            goto label_62;
            label_53:
            val_29 = val_29 + 1;
            mem2[0] = 450;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_29 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((1152921541177117200 + ((val_29 + 1)) << 2) == 450)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
            
            return;
            label_62:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if(340 == 340)
            {
                goto label_78;
            }
            
            }
            
            if( == 0)
            {
                goto label_79;
            }
            
            if((public System.Boolean Dictionary.Enumerator<System.String, System.Object>::MoveNext()) != 0)
            {
                goto label_80;
            }
            
            goto label_81;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.专丈丘丐丞丛世三丛.Clear();
            this.丟丏丂上丗不三业丈.Clear();
            this.丟丏下一丟丕丂丂下.Clear();
            this.丑业丑丟丘丕三世专.Clear();
        }
        public 丆丏上下丁丏一丙丐()
        {
            this.专丈丘丐丞丛世三丛 = new System.Collections.Generic.HashSet<System.String>();
            this.丟丏丂上丗不三业丈 = new System.Collections.Generic.HashSet<System.String>();
            this.丟丏下一丟丕丂丂下 = new System.Collections.Generic.HashSet<System.String>();
            this.丑业丑丟丘丕三世专 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        }
        private static 丆丏上下丁丏一丙丐()
        {
            Progress.丆丏上下丁丏一丙丐.丕丟一七丑丙丂丆丙 = "almanach_slot";
            Progress.丆丏上下丁丏一丙丐.丐丌丞上世丛丐丏丛 = "walmanach_slot_key";
        }
    
    }

}
