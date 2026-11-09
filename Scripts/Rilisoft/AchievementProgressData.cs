using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class AchievementProgressData
    {
        // Fields
        public int AchievementId;
        public System.Collections.Generic.Dictionary<string, object> CustomData;
        public int Points;
        public int Stage;
        
        // Methods
        public AchievementProgressData()
        {
            this.CustomData = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            var val_12;
            var val_16;
            string val_30;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_31;
            var val_32;
            var val_33;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            val_31 = this;
            if(万且万且丑丗且丌丆 == null)
            {
                goto label_39;
            }
            
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.AchievementProgressData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 万且万且丑丗且丌丆 : 0;
            var val_3 = (((System.Collections.Generic.Dictionary<System.String, System.Object>)[1152921542197276080]) == 0) ? 1 : 0;
            if(this.CustomData == null)
            {
                    return (bool)val_32;
            }
            
            val_33 = 1152921542197178096;
            val_30 = (System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.AchievementProgressData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 24.Keys;
            if(this.CustomData.Keys.Count != val_30.Count)
            {
                goto label_39;
            }
            
            val_30 = (System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.AchievementProgressData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 24.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_10 = this.CustomData.Keys.GetEnumerator();
            val_35 = 1152921516622703376;
            val_36 = 0;
            val_37 = 0;
            label_32:
            if(((-1064324784) & 1) == 0)
            {
                goto label_17;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_14 = val_30.GetEnumerator();
            label_20:
            if(((-1064324816) & 1) == 0)
            {
                goto label_19;
            }
            
            if((System.String.Equals(a:  val_12.丐丏七丌丕丗业且上(), b:  val_16.丐丏七丌丕丗业且上(), comparisonType:  4)) == false)
            {
                goto label_20;
            }
            
            val_38 = 0 + 1;
            mem2[0] = 248;
            val_33 = 1;
            goto label_22;
            label_19:
            val_38 = 0 + 1;
            val_33 = 0;
            mem2[0] = 248;
            label_22:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_38 == 1) || ((1152921542197227664 + ((0 + 1)) << 2) != 248))
            {
                goto label_26;
            }
            
            var val_29 = 0;
            val_29 = val_29 ^ (val_38 >> 31);
            val_38 = val_38 + val_29;
            if(( & 1) != 0)
            {
                goto label_32;
            }
            
            goto label_31;
            label_26:
            if( == 0)
            {
                goto label_29;
            }
            
            val_36 = 0;
            val_37 = 0;
            if(( & 1) != 0)
            {
                goto label_32;
            }
            
            goto label_31;
            label_29:
            val_36 = 0;
            if(( & 1) != 0)
            {
                goto label_32;
            }
            
            label_31:
            val_39 = val_38 + 1;
            val_40 = 425;
            goto label_33;
            label_17:
            val_39 = 0 + 1;
            val_40 = 284;
            label_33:
            mem2[0] = 284;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_38 == 1)
            {
                goto label_40;
            }
            
            if((1152921542197227664 + ((0 + 1)) << 2) == 425)
            {
                goto label_39;
            }
            
            if((1152921542197227664 + ((0 + 1)) << 2) != 284)
            {
                goto label_40;
            }
            
            var val_30 = 0;
            val_30 = val_30 ^ (val_38 >> 31);
            val_39 = val_38 + val_30;
            goto label_42;
            label_40:
            if( != 0)
            {
                    val_37 = 0;
            }
            
            label_42:
            val_31 = this.CustomData;
            Dictionary.Enumerator<TKey, TValue> val_19 = val_31.GetEnumerator();
            val_33 = 1152921516595683744;
            val_35 = 1152921516595684768;
            label_53:
            if(((-1064324864) & 1) == 0)
            {
                goto label_44;
            }
            
            ConfiguredValueTaskAwaiter val_21 = val_12.GetAwaiter();
            val_31;
            val_30 = (System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.AchievementProgressData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 24.Item[val_21._value._obj.丐丏七丌丕丗业且上()];
            if((val_30 | val_31) == null)
            {
                goto label_53;
            }
            
            var val_25 = (val_30 == 0) ? 1 : 0;
            var val_26 = (val_31 != 0) ? 1 : 0;
            if(((val_26 & val_25) & 1) != 0)
            {
                goto label_49;
            }
            
            val_25 = val_26 | val_25;
            if(val_25 == 0)
            {
                goto label_49;
            }
            
            if(val_31 == val_30)
            {
                goto label_53;
            }
            
            val_31 = val_31;
            if((System.String.op_Inequality(a:  val_21._value._obj, b:  val_30)) == false)
            {
                goto label_53;
            }
            
            label_49:
            val_41 = val_38 + 1;
            val_42 = 425;
            goto label_54;
            label_44:
            val_41 = val_38 + 1;
            val_42 = 423;
            label_54:
            mem2[0] = 423;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(val_41 == 1)
            {
                goto label_64;
            }
            
            if((1152921542197227664 + (((0 + 1) + 1)) << 2) != 425)
            {
                goto label_65;
            }
            
            label_39:
            val_32 = 0;
            return (bool)val_32;
            label_64:
            if( != 0)
            {
                    return (bool)val_32;
            }
            
            return (bool)val_32;
            label_65:
            if( == 0)
            {
                    return (bool)val_32;
            }
            
            if((1152921542197227664 + (((0 + 1) + 1)) << 2) == 423)
            {
                    return (bool)val_32;
            }
            
            return (bool)val_32;
        }
        internal static Rilisoft.AchievementProgressData 东丝七业丄丑丒世七(string 丞丕丒专一下丙业上)
        {
            var val_4;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丕丒专一下丙业上)) != false)
            {
                    return 0;
            }
            
            if((Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丞丕丒专一下丙业上)) == null)
            {
                    return Rilisoft.AchievementProgressData.东丝七业丄丑丒世七(万且万且丑丗且丌丆:  null);
            }
            
            val_4 = 0;
            return Rilisoft.AchievementProgressData.东丝七业丄丑丒世七(万且万且丑丗且丌丆:  null);
        }
        internal static Rilisoft.AchievementProgressData 东丝七业丄丑丒世七(System.Collections.Generic.Dictionary<string, object> 万且万且丑丗且丌丆)
        {
            var val_12;
            var val_13;
            var val_14;
            System.Func<System.Object, System.Collections.Generic.Dictionary<System.String, System.Object>> val_16;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_17;
            if(万且万且丑丗且丌丆 != null)
            {
                    Rilisoft.AchievementProgressData val_1 = null;
                val_12 = val_1;
                val_1 = new Rilisoft.AchievementProgressData();
                System.Func<System.Object, System.Int32> val_2 = null;
                val_13 = 1152921542197517808;
                val_2 = new System.Func<System.Object, System.Int32>(object:  0, method:  static System.Int32 Rilisoft.AchievementProgressData::三丂丈丛下下丒一丈(object 丄三丅七丆丛与与上));
                .AchievementId = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.Int32>(丏丂万业丙专丏丒丒:  万且万且丑丗且丌丆, 丒丘丏上丙丟丑丕丈:  "id", 万一一丈丆与不七下:  val_2, 不丐不丕东东丏丄专:  false);
                .Points = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.Int32>(丏丂万业丙专丏丒丒:  万且万且丑丗且丌丆, 丒丘丏上丙丟丑丕丈:  "p", 万一一丈丆与不七下:  new System.Func<System.Object, System.Int32>(object:  0, method:  static System.Int32 Rilisoft.AchievementProgressData::三丂丈丛下下丒一丈(object 丄三丅七丆丛与与上)), 不丐不丕东东丏丄专:  false);
                .Stage = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.Int32>(丏丂万业丙专丏丒丒:  万且万且丑丗且丌丆, 丒丘丏上丙丟丑丕丈:  "s", 万一一丈丆与不七下:  new System.Func<System.Object, System.Int32>(object:  0, method:  static System.Int32 Rilisoft.AchievementProgressData::三丂丈丛下下丒一丈(object 丄三丅七丆丛与与上)), 不丐不丕东东丏丄专:  false);
                val_14 = null;
                val_14 = null;
                val_16 = AchievementProgressData.<>c.<>9__7_0;
                if(val_16 == null)
            {
                    System.Func<System.Object, System.Collections.Generic.Dictionary<System.String, System.Object>> val_8 = null;
                val_16 = val_8;
                val_8 = new System.Func<System.Object, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  AchievementProgressData.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> AchievementProgressData.<>c::一丐不万世上丈丅不(object 丄三丅七丆丛与与上));
                AchievementProgressData.<>c.<>9__7_0 = val_16;
            }
            
                val_17 = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  万且万且丑丗且丌丆, 丒丘丏上丙丟丑丕丈:  "cd", 万一一丈丆与不七下:  val_8, 不丐不丕东东丏丄专:  true);
                if(val_17 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_10 = null;
                val_17 = val_10;
                val_10 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
                .CustomData = val_17;
                if((Rilisoft.AchievementProgressData)[1152921542197604528].AchievementId != 36)
            {
                    return (Rilisoft.AchievementProgressData)val_12;
            }
            
                .CustomData = Rilisoft.东丝下且丄三丙不丌.丕不丒丌与丕丄丆丈(丅丌丟丟七专业丗一:  val_10);
                return (Rilisoft.AchievementProgressData)val_12;
            }
            
            val_12 = 0;
            return (Rilisoft.AchievementProgressData)val_12;
        }
        private static int 三丂丈丛下下丒一丈(object 丄三丅七丆丛与与上)
        {
            return System.Convert.ToInt32(value:  丄三丅七丆丛与与上, provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        internal static System.Collections.Generic.List<Rilisoft.AchievementProgressData> 丞七丟丄丐丂三丈丌(string 丞丕丒专一下丙业上)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丕丒专一下丙业上)) == true)
            {
                    return (System.Collections.Generic.List<Rilisoft.AchievementProgressData>)new System.Collections.Generic.List<Rilisoft.AchievementProgressData>(capacity:  0);
            }
            
            object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丞丕丒专一下丙业上);
            UnityEngine.Debug.LogError(message:  "[Achievements] parse progresses error");
            return (System.Collections.Generic.List<Rilisoft.AchievementProgressData>)new System.Collections.Generic.List<Rilisoft.AchievementProgressData>(capacity:  0);
        }
        internal System.Collections.Generic.Dictionary<string, object> 丆且丄东丁丑且东丌()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "id", value:  this.AchievementId);
            val_1.Add(key:  "p", value:  this.Points);
            val_1.Add(key:  "s", value:  this.Stage);
            if(this.CustomData == null)
            {
                    return val_1;
            }
            
            if(this.CustomData.Count < 1)
            {
                    return val_1;
            }
            
            val_1.Add(key:  "cd", value:  this.CustomData);
            return val_1;
        }
        internal System.Collections.Generic.Dictionary<string, object> 与业且丂丈丏丛丆与()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "p", value:  this.Points);
            val_1.Add(key:  "s", value:  this.Stage);
            if(this.CustomData == null)
            {
                    return val_1;
            }
            
            if(this.CustomData.Count < 1)
            {
                    return val_1;
            }
            
            val_1.Add(key:  "cd", value:  this.CustomData);
            return val_1;
        }
        internal void 丅七与三丘世业万三(System.Collections.Generic.Dictionary<string, object> 东且丁丆丛丁丏丘且)
        {
            var val_2;
            if(东且丁丆丛丁丏丘且 == null)
            {
                    return;
            }
            
            val_2 = 1152921516595668352;
            东且丁丆丛丁丏丘且.set_Item(key:  "id", value:  this.AchievementId);
            东且丁丆丛丁丏丘且.set_Item(key:  "p", value:  this.Points);
            东且丁丆丛丁丏丘且.set_Item(key:  "s", value:  this.Stage);
            if(this.CustomData == null)
            {
                    return;
            }
            
            if(this.CustomData.Count < 1)
            {
                    return;
            }
            
            东且丁丆丛丁丏丘且.set_Item(key:  "cd", value:  this.CustomData);
        }
        internal static string 丝丅丌丁丒丟三丏上(string 丆丁丗与东丗七丕丐, string 三丅三不丘丝一业与)
        {
            Rilisoft.AchievementProgressSyncObject val_9;
            var val_10;
            System.Func<Rilisoft.AchievementProgressData, System.Collections.Generic.Dictionary<System.String, System.Object>> val_12;
            Rilisoft.AchievementProgressSyncObject val_3 = null;
            val_9 = val_3;
            val_3 = new Rilisoft.AchievementProgressSyncObject(丕丞且丂丒丄东不丘:  Rilisoft.AchievementProgressData.丞七丟丄丐丂三丈丌(丞丕丒专一下丙业上:  丆丁丗与东丗七丕丐));
            Rilisoft.AchievementProgressSyncObject val_5 = Rilisoft.AchievementProgressData.丝丅丌丁丒丟三丏上(丐丕丆丟丗丑三丙业:  val_3, 丗丅丙丏丝一七东丗:  new Rilisoft.AchievementProgressSyncObject(丕丞且丂丒丄东不丘:  Rilisoft.AchievementProgressData.丞七丟丄丐丂三丈丌(丞丕丒专一下丙业上:  三丅三不丘丝一业与)));
            val_10 = null;
            val_10 = null;
            val_12 = AchievementProgressData.<>c.<>9__13_0;
            if(val_12 != null)
            {
                    return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Select<Rilisoft.AchievementProgressData, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_5._progressData, selector:  System.Func<Rilisoft.AchievementProgressData, System.Collections.Generic.Dictionary<System.String, System.Object>> val_6 = null)));
            }
            
            val_12 = val_6;
            val_6 = new System.Func<Rilisoft.AchievementProgressData, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  AchievementProgressData.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> AchievementProgressData.<>c::丌丈丆三东且丝且丝(Rilisoft.AchievementProgressData 丄三丅七丆丛与与上));
            AchievementProgressData.<>c.<>9__13_0 = val_12;
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Select<Rilisoft.AchievementProgressData, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_5._progressData, selector:  val_6)));
        }
        internal static Rilisoft.AchievementProgressSyncObject 丝丅丌丁丒丟三丏上(Rilisoft.AchievementProgressSyncObject 丐丕丆丟丗丑三丙业, Rilisoft.AchievementProgressSyncObject 丗丅丙丏丝一七东丗)
        {
            var val_5;
            .万丏丏丞一丈上不丑 = new Rilisoft.AchievementProgressSyncObject();
            List.Enumerator<T> val_3 = 丐丕丆丟丗丑三丙业._progressData.GetEnumerator();
            label_13:
            if(((-1062738816) & 1) == 0)
            {
                goto label_4;
            }
            
            new AchievementProgressData.上丄与丏丌丅不丂丂() = new System.Object();
            .下丅丙一丂丗丅丝七 = val_5.丐丏七丌丕丗业且上();
            System.Func<Rilisoft.AchievementProgressData, System.Boolean> val_8 = new System.Func<Rilisoft.AchievementProgressData, System.Boolean>(object:  new AchievementProgressData.上丄与丏丌丅不丂丂(), method:  System.Boolean AchievementProgressData.上丄与丏丌丅不丂丂::三丏万不丘丗丅不专(Rilisoft.AchievementProgressData 七丞丙丒三丕且丌丟));
            Rilisoft.AchievementProgressData val_9 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.AchievementProgressData>(source:  丗丅丙丏丝一七东丗._progressData, predicate:  null);
            if(val_9 == null)
            {
                goto label_7;
            }
            
            (AchievementProgressData.丌丟丘丏丕丅七万丕)[1152921542198866144].万丏丏丞一丈上不丑._progressData.Add(item:  Rilisoft.AchievementProgressData.丝丅丌丁丒丟三丏上(丐丕丆丟丗丑三丙业:  (AchievementProgressData.上丄与丏丌丅不丂丂)[1152921542198878432].下丅丙一丂丗丅丝七, 丗丅丙丏丝一七东丗:  val_9));
            goto label_13;
            label_7:
            (AchievementProgressData.丌丟丘丏丕丅七万丕)[1152921542198866144].万丏丏丞一丈上不丑._progressData.Add(item:  (AchievementProgressData.上丄与丏丌丅不丂丂)[1152921542198878432].下丅丙一丂丗丅丝七);
            goto label_13;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            (AchievementProgressData.丌丟丘丏丕丅七万丕)[1152921542198866144].万丏丏丞一丈上不丑._progressData.AddRange(collection:  System.Linq.Enumerable.Where<Rilisoft.AchievementProgressData>(source:  丗丅丙丏丝一七东丗._progressData, predicate:  new System.Func<Rilisoft.AchievementProgressData, System.Boolean>(object:  new AchievementProgressData.丌丟丘丏丕丅七万丕(), method:  System.Boolean AchievementProgressData.丌丟丘丏丕丅七万丕::丕万丘丝丘万丈丌与(Rilisoft.AchievementProgressData 七丞丙丒三丕且丌丟))));
            Rilisoft.丞专七丛丛丌世丈丕.丐东丒丌丞丌丄丏丗(丌一一七丗丗七下七:  "[MERGE] [ONE] " + Rilisoft.AchievementProgressSyncObject.丂丆丑世一不丘丏七(世丘万七丗丆丒与七:  丐丕丆丟丗丑三丙业)(Rilisoft.AchievementProgressSyncObject.丂丆丑世一不丘丏七(世丘万七丗丆丒与七:  丐丕丆丟丗丑三丙业)));
            Rilisoft.丞专七丛丛丌世丈丕.丐东丒丌丞丌丄丏丗(丌一一七丗丗七下七:  "[MERGE] [TWO] " + Rilisoft.AchievementProgressSyncObject.丂丆丑世一不丘丏七(世丘万七丗丆丒与七:  丗丅丙丏丝一七东丗)(Rilisoft.AchievementProgressSyncObject.丂丆丑世一不丘丏七(世丘万七丗丆丒与七:  丗丅丙丏丝一七东丗)));
            Rilisoft.丞专七丛丛丌世丈丕.丐东丒丌丞丌丄丏丗(丌一一七丗丗七下七:  "[MERGE] [RES] " + Rilisoft.AchievementProgressSyncObject.丂丆丑世一不丘丏七(世丘万七丗丆丒与七:  (AchievementProgressData.丌丟丘丏丕丅七万丕)[1152921542198866144].万丏丏丞一丈上不丑)(Rilisoft.AchievementProgressSyncObject.丂丆丑世一不丘丏七(世丘万七丗丆丒与七:  (AchievementProgressData.丌丟丘丏丕丅七万丕)[1152921542198866144].万丏丏丞一丈上不丑)));
            return (Rilisoft.AchievementProgressSyncObject)(AchievementProgressData.丌丟丘丏丕丅七万丕)[1152921542198866144].万丏丏丞一丈上不丑;
        }
        internal static Rilisoft.AchievementProgressData 丝丅丌丁丒丟三丏上(Rilisoft.AchievementProgressData 丐丕丆丟丗丑三丙业, Rilisoft.AchievementProgressData 丗丅丙丏丝一七东丗)
        {
            TSource[] val_10;
            var val_31;
            var val_32;
            object val_33;
            var val_34;
            var val_35;
            val_31 = 丗丅丙丏丝一七东丗;
            if(丐丕丆丟丗丑三丙业 == null)
            {
                goto label_1;
            }
            
            if(val_31 == null)
            {
                goto label_2;
            }
            
            if(丐丕丆丟丗丑三丙业.Stage != 丗丅丙丏丝一七东丗.Stage)
            {
                goto label_3;
            }
            
            val_32 = 丐丕丆丟丗丑三丙业;
            if(丐丕丆丟丗丑三丙业.Points == 丗丅丙丏丝一七东丗.Points)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            if(丐丕丆丟丗丑三丙业.CustomData == null)
            {
                goto label_5;
            }
            
            if(丗丅丙丏丝一七东丗.CustomData == null)
            {
                goto label_6;
            }
            
            AchievementProgressData.丕丛业丁丏下一七丘 val_2 = null;
            val_33 = val_2;
            val_2 = new AchievementProgressData.丕丛业丁丏下一七丘();
            .一丆丙且七三丅下丒 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.Object>>();
            System.Action<System.Collections.Generic.KeyValuePair<System.String, System.Object>> val_4 = null;
            val_34 = 1152921542199067552;
            val_4 = new System.Action<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(object:  val_2, method:  System.Void AchievementProgressData.丕丛业丁丏下一七丘::丕万丘丝丘万丈丌与(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(丌丛丏业世丄丞三丌:  丐丕丆丟丗丑三丙业.CustomData, 七丐丅专且专七三丆:  val_4);
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(丌丛丏业世丄丞三丌:  丗丅丙丏丝一七东丗.CustomData, 七丐丅专且专七三丆:  new System.Action<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(object:  val_2, method:  System.Void AchievementProgressData.丕丛业丁丏下一七丘::三丏万不丘丗丅不专(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一)));
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if((AchievementProgressData.丕丛业丁丏下一七丘)[1152921542199292512].一丆丙且七三丅下丒.Count < 1)
            {
                    return (Rilisoft.AchievementProgressData)(丐丕丆丟丗丑三丙业.Points > 丗丅丙丏丝一七东丗.Points) ? 丐丕丆丟丗丑三丙业 : (val_31);
            }
            
            List.Enumerator<T> val_8 = (AchievementProgressData.丕丛业丁丏下一七丘)[1152921542199292512].一丆丙且七三丅下丒.GetEnumerator();
            val_34 = 1152921505425694720;
            label_56:
            if(((-1062320656) & 1) == 0)
            {
                goto label_13;
            }
            
            ConfiguredValueTaskAwaiter val_11 = val_10.GetAwaiter();
            new AchievementProgressData.丗丁丆丞丑东丕丘丏() = new System.Object();
            .下上丐丆丝丟丝丒不 = val_11._value._obj.丐丏七丌丕丗业且上();
            if((System.Linq.Enumerable.Contains<System.String>(source:  val_6.Keys, value:  (AchievementProgressData.丗丁丆丞丑东丕丘丏)[1152921542199329376].下上丐丆丝丟丝丒不)) == true)
            {
                goto label_56;
            }
            
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Boolean> val_16 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Boolean>(object:  new AchievementProgressData.丗丁丆丞丑东丕丘丏(), method:  System.Boolean AchievementProgressData.丗丁丆丞丑东丕丘丏::上下万下丆一业上专(System.Collections.Generic.KeyValuePair<string, object> 丟三下万一丄七一丗));
            TSource[] val_18 = System.Linq.Enumerable.ToArray<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(source:  (AchievementProgressData.丕丛业丁丏下一七丘)[1152921542199292512].一丆丙且七三丅下丒, predicate:  null));
            if(val_18.Length <= 1)
            {
                goto label_19;
            }
            
            object val_30 = val_18[32];
            var val_31 = val_18[48];
            if((val_31 == null) || (val_30 == null))
            {
                goto label_22;
            }
            
            if((System.Type.op_Inequality(left:  val_30.GetType(), right:  val_31.GetType())) == false)
            {
                goto label_26;
            }
            
            val_6.Add(key:  (AchievementProgressData.丗丁丆丞丑东丕丘丏)[1152921542199329376].下上丐丆丝丟丝丒不, value:  val_30);
            goto label_56;
            label_19:
            val_6.Add(key:  val_18[32].丐丏七丌丕丗业且上(), value:  val_18[32]);
            goto label_56;
            label_22:
            val_6.Add(key:  (AchievementProgressData.丗丁丆丞丑东丕丘丏)[1152921542199329376].下上丐丆丝丟丝丒不, value:  (val_30 != null) ? (val_30) : (val_31));
            goto label_56;
            label_26:
            if(val_30 == null)
            {
                goto label_35;
            }
            
            if(null == null)
            {
                goto label_36;
            }
            
            if(null == null)
            {
                goto label_37;
            }
            
            if(null == null)
            {
                goto label_38;
            }
            
            if(null == null)
            {
                goto label_39;
            }
            
            if(null == null)
            {
                goto label_40;
            }
            
            label_35:
            val_6.Add(key:  (AchievementProgressData.丗丁丆丞丑东丕丘丏)[1152921542199329376].下上丐丆丝丟丝丒不, value:  val_30);
            goto label_56;
            label_36:
            val_6.Add(key:  (AchievementProgressData.丗丁丆丞丑东丕丘丏)[1152921542199329376].下上丐丆丝丟丝丒不, value:  (null > null) ? (val_30) : (val_31));
            goto label_56;
            label_37:
            val_6.Add(key:  (AchievementProgressData.丗丁丆丞丑东丕丘丏)[1152921542199329376].下上丐丆丝丟丝丒不, value:  (null > null) ? (val_30) : (val_31));
            goto label_56;
            label_38:
            val_6.Add(key:  (AchievementProgressData.丗丁丆丞丑东丕丘丏)[1152921542199329376].下上丐丆丝丟丝丒不, value:  (null > null) ? (val_30) : (val_31));
            goto label_56;
            label_39:
            val_6.Add(key:  (AchievementProgressData.丗丁丆丞丑东丕丘丏)[1152921542199329376].下上丐丆丝丟丝丒不, value:  (val_30.Length > val_31.Length) ? (val_30) : (val_31));
            goto label_56;
            label_40:
            if(null != null)
            {
                    val_35 = 1;
            }
            
            val_10 = null;
            val_6.Add(key:  (AchievementProgressData.丗丁丆丞丑东丕丘丏)[1152921542199329376].下上丐丆丝丟丝丒不, value:  val_10);
            goto label_56;
            label_1:
            val_32 = val_31;
            return (Rilisoft.AchievementProgressData)(丐丕丆丟丗丑三丙业.Points > 丗丅丙丏丝一七东丗.Points) ? 丐丕丆丟丗丑三丙业 : (val_31);
            label_2:
            val_32 = 丐丕丆丟丗丑三丙业;
            return (Rilisoft.AchievementProgressData)(丐丕丆丟丗丑三丙业.Points > 丗丅丙丏丝一七东丗.Points) ? 丐丕丆丟丗丑三丙业 : (val_31);
            label_6:
            val_31 = 丐丕丆丟丗丑三丙业;
            label_5:
            mem2[0] = 丐丕丆丟丗丑三丙业.CustomData;
            return (Rilisoft.AchievementProgressData)(丐丕丆丟丗丑三丙业.Points > 丗丅丙丏丝一七东丗.Points) ? 丐丕丆丟丗丑三丙业 : (val_31);
            label_13:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = val_6;
            return (Rilisoft.AchievementProgressData)(丐丕丆丟丗丑三丙业.Points > 丗丅丙丏丝一七东丗.Points) ? 丐丕丆丟丗丑三丙业 : (val_31);
        }
    
    }

}
