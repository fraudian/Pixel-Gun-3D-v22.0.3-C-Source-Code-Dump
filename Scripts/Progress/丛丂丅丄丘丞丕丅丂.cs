using UnityEngine;

namespace Progress
{
    internal class 丛丂丅丄丘丞丕丅丂 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        internal System.Collections.Generic.List<Rilisoft.AchievementProgressData> 丂专丌下丈与丕三丘;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丛丂丅丄丘丞丕丅丂.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丛丂丅丄丘丞丕丅丂.丐丌丞上世丛丐丏丛;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 5;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_5;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            System.Func<System.Object, System.Collections.Generic.Dictionary<System.String, System.Object>> val_27;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_28;
            var val_29;
            val_22 = this;
            this.丂专丌下丈与丕三丘.Clear();
            string val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄);
            Dictionary.Enumerator<TKey, TValue> val_3 = GetEnumerator();
            label_36:
            if(((-2087004816) & 1) == 0)
            {
                goto label_8;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_5.GetAwaiter();
            val_23 = 0;
            new Rilisoft.AchievementProgressData() = new Rilisoft.AchievementProgressData();
            int val_11 = System.Int32.Parse(s:  val_7._value._obj.丐丏七丌丕丗业且上());
            if(new Rilisoft.AchievementProgressData() != null)
            {
                    val_24 = new Rilisoft.AchievementProgressData();
                .AchievementId = val_11;
            }
            else
            {
                    mem[16] = val_11;
                val_24 = 16;
            }
            
            bool val_13 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "p", 丙业与丙丗丝不丈东: out  (Rilisoft.AchievementProgressData)[1152921541174604256].Points);
            bool val_15 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "s", 丙业与丙丗丝不丈东: out  (Rilisoft.AchievementProgressData)[1152921541174604256].Stage);
            val_25 = null;
            val_25 = null;
            val_27 = 丛丂丅丄丘丞丕丅丂.<>c.<>9__9_0;
            if(val_27 == null)
            {
                    val_27 = null;
                val_27 = new System.Func<System.Object, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  丛丂丅丄丘丞丕丅丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> 丛丂丅丄丘丞丕丅丂.<>c::丙丝丏丙丁专丟丑丐(object 丄三丅七丆丛与与上));
                丛丂丅丄丘丞丕丅丂.<>c.<>9__9_0 = val_27;
            }
            
            val_28 = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  null, 丒丘丏上丙丟丑丕丈:  "c", 万一一丈丆与不七下:  null, 不丐不丕东东丏丄专:  true);
            if(val_28 == null)
            {
                    val_28 = null;
                val_28 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            val_29 = 0;
            .CustomData = val_28;
            goto label_26;
            label_32:
            val_29 = 1;
            label_26:
            if(val_29 >= this.丂专丌下丈与丕三丘.Count)
            {
                goto label_28;
            }
            
            Rilisoft.AchievementProgressData val_20 = this.丂专丌下丈与丕三丘.Item[1];
            if(val_20.AchievementId != val_24)
            {
                goto label_32;
            }
            
            if(this.丂专丌下丈与丕三丘.Item[1] != null)
            {
                goto label_36;
            }
            
            label_28:
            this.丂专丌下丈与丕三丘.Add(item:  new Rilisoft.AchievementProgressData());
            goto label_36;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            object val_3;
            object val_4;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            List.Enumerator<T> val_2 = this.丂专丌下丈与丕三丘.GetEnumerator();
            label_10:
            if(((-2086806784) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_4 = val_3;
            null.Add(key:  "p", value:  val_4);
            null.Add(key:  "s", value:  "p");
            if(null != null)
            {
                    if(null.Count >= 1)
            {
                    null.Add(key:  "c", value:  "p");
            }
            
            }
            
            val_1.Add(key:  val_5.m_stringLength.ToString(), value:  null);
            goto label_10;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            return (object)val_1;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
            this.丂专丌下丈与丕三丘 = Rilisoft.AchievementProgressData.丞七丟丄丐丂三丈丌(丞丕丒专一下丙业上:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "achievementsProgress"));
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丂专丌下丈与丕三丘.Clear();
        }
        internal void 三世与丆一丝丟一万(Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘, bool 丑上东丄专与丁丆不)
        {
            if(丕丞且丂丒丄东不丘 == null)
            {
                    return;
            }
            
            if((this.丄丁一丝且下丑世万(丕丞且丂丒丄东不丘:  丕丞且丂丒丄东不丘)) != false)
            {
                    return;
            }
            
            丑上东丄专与丁丆不 = 丑上东丄专与丁丆不;
            bool val_2 = this.丙丗丛丞丒万一上丞(丕丞且丂丒丄东不丘:  丕丞且丂丒丄东不丘, 丑上东丄专与丁丆不:  丑上东丄专与丁丆不);
        }
        private bool 丄丁一丝且下丑世万(Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_8;
            System.Collections.Generic.List<Rilisoft.AchievementProgressData> val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = 丕丞且丂丒丄东不丘;
            val_9 = this;
            val_10 = 1152921541174486816;
            val_11 = 0;
            goto label_1;
            label_7:
            Rilisoft.AchievementProgressData val_1 = this.丂专丌下丈与丕三丘.Item[0];
            if(val_1.AchievementId == 丕丞且丂丒丄东不丘.AchievementId)
            {
                goto label_5;
            }
            
            val_11 = 1;
            label_1:
            if(val_11 < this.丂专丌下丈与丕三丘.Count)
            {
                goto label_7;
            }
            
            val_12 = 0;
            return (bool)val_12;
            label_5:
            val_9 = this.丂专丌下丈与丕三丘;
            Rilisoft.AchievementProgressData val_3 = val_9.Item[0];
            if(val_3 == null)
            {
                    return (bool)val_12;
            }
            
            if(val_3 == val_8)
            {
                goto label_11;
            }
            
            val_9 = val_3.CustomData;
            val_3.Points = 丕丞且丂丒丄东不丘.Points;
            val_3.Stage = 丕丞且丂丒丄东不丘.Stage;
            val_9.Clear();
            val_8 = 丕丞且丂丒丄东不丘.CustomData;
            Dictionary.Enumerator<TKey, TValue> val_4 = val_8.GetEnumerator();
            val_10 = 1152921516595683744;
            label_16:
            if(((-2086247944) & 1) == 0)
            {
                goto label_14;
            }
            
            ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
            val_3.CustomData.set_Item(key:  val_5._value._obj.丐丏七丌丕丗业且上(), value:  val_5._value._obj);
            goto label_16;
            label_11:
            object[] val_7 = new object[1];
            val_8 = 丕丞且丂丒丄东不丘.AchievementId;
            val_7[0] = val_8;
            UnityEngine.Debug.LogErrorFormat(format:  "ReferenceEquals!!!!!!!!! {0}", args:  val_7);
            goto label_29;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_29:
            val_12 = 1;
            return (bool)val_12;
        }
        private bool 丙丗丛丞丒万一上丞(Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘, bool 丑上东丄专与丁丆不)
        {
            var val_8;
            var val_21;
            var val_22;
            System.Collections.Generic.List<Rilisoft.AchievementProgressData> val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_32;
            var val_33;
            val_21 = 丑上东丄专与丁丆不;
            val_22 = 0;
            goto label_1;
            label_7:
            Rilisoft.AchievementProgressData val_1 = this.丂专丌下丈与丕三丘.Item[0];
            if(val_1.AchievementId == 丕丞且丂丒丄东不丘.AchievementId)
            {
                goto label_5;
            }
            
            val_22 = 1;
            label_1:
            if(val_22 < this.丂专丌下丈与丕三丘.Count)
            {
                goto label_7;
            }
            
            goto label_10;
            label_5:
            val_23 = this.丂专丌下丈与丕三丘;
            if(val_23.Item[0] != null)
            {
                    val_24 = 0;
                return (bool)val_24;
            }
            
            label_10:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Dictionary.Enumerator<TKey, TValue> val_5 = 丕丞且丂丒丄东不丘.CustomData.GetEnumerator();
            val_25 = 0;
            val_26 = 0;
            label_40:
            if(((-2086029472) & 1) == 0)
            {
                goto label_14;
            }
            
            ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
            val_4.set_Item(key:  val_9._value._obj.丐丏七丌丕丗业且上(), value:  val_9._value._obj);
            goto label_40;
            label_28:
            if(((-2086029536) & 1) == 0)
            {
                goto label_29;
            }
            
            ConfiguredValueTaskAwaiter val_17 = val_8.GetAwaiter();
            null.set_Item(key:  val_17._value._obj.丐丏七丌丕丗业且上(), value:  val_17._value._obj);
            goto label_28;
            label_29:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((1 != 1) && (198 == 198))
            {
                
            }
            else
            {
                    if( != 0)
            {
                
            }
            
            }
            
            val_4.set_Item(key:  val_9._value._obj.丐丏七丌丕丗业且上(), value:  null);
            goto label_40;
            label_14:
            val_32 = -2086029632;
            val_33 = 2;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_57;
            }
            
            if(( == 0) || (198 == 263))
            {
                goto label_64;
            }
            
            label_63:
            label_64:
            val_23 = this.丂专丌下丈与丕三丘;
            Rilisoft.AchievementProgressData val_20 = new Rilisoft.AchievementProgressData();
            if(val_20 == null)
            {
                goto label_61;
            }
            
            .AchievementId = 丕丞且丂丒丄东不丘.AchievementId;
            .Points = 丕丞且丂丒丄东不丘.Points;
            .Stage = 丕丞且丂丒丄东不丘.Stage;
            goto label_62;
            label_57:
            if( != 0)
            {
                goto label_63;
            }
            
            goto label_64;
            label_61:
            mem[16] = 丕丞且丂丒丄东不丘.AchievementId;
            mem[32] = 丕丞且丂丒丄东不丘.Points;
            .Stage = 丕丞且丂丒丄东不丘.Stage;
            label_62:
            .CustomData = val_4;
            val_23.Add(item:  val_20);
            val_24 = 1;
            return (bool)val_24;
        }
        public 丛丂丅丄丘丞丕丅丂()
        {
            this.丂专丌下丈与丕三丘 = new System.Collections.Generic.List<Rilisoft.AchievementProgressData>();
            this = new System.Object();
            goto typeof(Progress.丛丂丅丄丘丞丕丅丂).__il2cppRuntimeField_238;
        }
        private static 丛丂丅丄丘丞丕丅丂()
        {
            Progress.丛丂丅丄丘丞丕丅丂.丕丟一七丑丙丂丆丙 = "achievements_slot";
            Progress.丛丂丅丄丘丞丕丅丂.丐丌丞上世丛丐丏丛 = "achievements_slot_key";
        }
    
    }

}
