using UnityEngine;

namespace Progress
{
    public static class 上专丙七丒七丏丘上
    {
        // Methods
        internal static System.Collections.Generic.Dictionary<string, object> 丆丆且与下不三丟丄(object 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_4 = Progress.上专丙七丒七丏丘上.丒世丛下丁丛一丝丄(丌且专不丙丕专丅万:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  万且万且丑丗且丌丆));
            if(val_4 == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            if((System.Linq.Enumerable.Any<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_4)) == false)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            return val_4.Item[0];
        }
        internal static System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丒世丛下丁丛一丝丄(string 丌且专不丙丕专丅万)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_13;
            var val_16;
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            if((System.String.IsNullOrEmpty(value:  丌且专不丙丕专丅万)) == true)
            {
                    return val_1;
            }
            
            object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject(value:  丌且专不丙丕专丅万);
            if(val_3 == null)
            {
                    return val_1;
            }
            
            if(val_3 == 1)
            {
                    val_13 = Progress.上专丙七丒七丏丘上.下丅丗丘丛丘万七且(丁东与丛东三丝万丂:  val_3);
                val_1.Add(item:  val_13);
            }
            
            System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> val_7 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Newtonsoft.Json.Linq.JArray.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0.GetEnumerator();
            label_25:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_1.Add(item:  Progress.上专丙七丒七丏丘上.下丅丗丘丛丘万七且(丁东与丛东三丝万丂:  val_7.Current.ToObject<Newtonsoft.Json.Linq.JObject>()));
            goto label_25;
            label_17:
            val_16 = 0;
            val_13 = 0;
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_7.Dispose();
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
        internal static System.Collections.Generic.Dictionary<string, object> 下丅丗丘丛丘万七且(Newtonsoft.Json.Linq.JObject 丁东与丛东三丝万丂)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(丁东与丛东三丝万丂 == null)
            {
                    return val_1;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = 丁东与丛东三丝万丂.ToObject<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            if(val_2 == null)
            {
                    return val_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = val_2.GetEnumerator();
            label_5:
            if((2117180792 & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
            val_1.Add(key:  val_4._value._obj.丐丏七丌丕丗业且上(), value:  Progress.上专丙七丒七丏丘上.丝三丙上丈下七且丘(丙业与丙丗丝不丈东:  val_4._value._obj));
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal static object 丝三丙上丈下七且丘(object 丙业与丙丗丝不丈东)
        {
            Newtonsoft.Json.Linq.JObject val_12;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_12 = 丙业与丙丗丝不丈东;
            if(val_12 == null)
            {
                    return (object)val_12;
            }
            
            object val_4 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Newtonsoft.Json.Linq.JValue.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_12) : 0.Value;
            goto label_10;
            label_24:
            object val_13 = val_12;
            if((丙业与丙丗丝不丈东 + 286) == 0)
            {
                goto label_15;
            }
            
            var val_11 = 丙业与丙丗丝不丈东 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_14:
            if(((丙业与丙丗丝不丈东 + 176 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (丙业与丙丗丝不丈东 + 286))
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            val_13 = val_13 + (((丙业与丙丗丝不丈东 + 176 + 8)) << 4);
            val_14 = val_13 + 296;
            label_15:
            if(val_12.MoveNext() == false)
            {
                goto label_16;
            }
            
            object val_16 = val_12;
            if((丙业与丙丗丝不丈东 + 286) == 0)
            {
                goto label_21;
            }
            
            var val_14 = 丙业与丙丗丝不丈东 + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_20:
            if(((丙业与丙丗丝不丈东 + 176 + 8) + -8) == null)
            {
                goto label_19;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (丙业与丙丗丝不丈东 + 286))
            {
                goto label_20;
            }
            
            goto label_21;
            label_19:
            val_16 = val_16 + (((丙业与丙丗丝不丈东 + 176 + 8)) << 4);
            val_15 = val_16 + 296;
            label_21:
            Add(item:  val_12.Current);
            goto label_24;
            label_16:
            val_16 = 0;
            val_17 = 0;
            if(val_12 != 0)
            {
                goto label_25;
            }
            
            goto label_31;
            label_25:
            object val_19 = val_12;
            if((丙业与丙丗丝不丈东 + 286) == 0)
            {
                goto label_35;
            }
            
            var val_17 = 丙业与丙丗丝不丈东 + 176;
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_34:
            if(((丙业与丙丗丝不丈东 + 176 + 8) + -8) == null)
            {
                goto label_33;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < (丙业与丙丗丝不丈东 + 286))
            {
                goto label_34;
            }
            
            goto label_35;
            label_33:
            val_19 = val_19 + (((丙业与丙丗丝不丈东 + 176 + 8)) << 4);
            val_18 = val_19 + 296;
            label_35:
            val_12.Dispose();
            label_31:
            label_10:
            val_12 = ToArray();
            return (object)val_12;
        }
    
    }

}
