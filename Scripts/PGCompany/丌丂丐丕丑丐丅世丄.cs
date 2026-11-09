using UnityEngine;

namespace PGCompany
{
    internal static class 丌丂丐丕丑丐丅世丄
    {
        // Fields
        internal static readonly string 丐下丕丏丗不不业三;
        
        // Methods
        internal static string 世丏丘万丑七专业丂(string 下丄三丂专丈下七丆)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            string val_5 = PGCompany.丌丂丐丕丑丐丅世丄.丐下丕丏丗不不业三;
            val_5 = val_5.Length + 1;
            if(下丄三丂专丈下七丆 != null)
            {
                    val_6 = 下丄三丂专丈下七丆.Length;
                return 下丄三丂专丈下七丆.Remove(startIndex:  val_6 - val_5, count:  val_5);
            }
            
            val_6 = 0.Length;
            return 下丄三丂专丈下七丆.Remove(startIndex:  val_6 - val_5, count:  val_5);
        }
        internal static string 世专丌七且丝丅世丙(string 不丌万且丈且不七丛)
        {
            null = null;
            return 不丌万且丈且不七丛 + "_" + PGCompany.丌丂丐丕丑丐丅世丄.丐下丕丏丗不不业三;
        }
        public static string 丅丌丁丑世丛专三东(System.Collections.Generic.List<PlaceableItemSettings> 业世丟丐丘丐专与不)
        {
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  业世丟丐丘丐专与不, formatting:  1);
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  val_1);
            return val_1;
        }
        internal static System.Collections.Generic.List<PlaceableItemSettings> 业丏丅与与东下丐三(string 丌且专不丙丕专丅万)
        {
            string val_8;
            string val_9;
            var val_11;
            if((System.String.IsNullOrEmpty(value:  丌且专不丙丕专丅万)) == false)
            {
                goto label_1;
            }
            
            val_8 = "ClanPlaceableItems config is null";
            goto label_2;
            label_1:
            val_9 = public System.Collections.Generic.List<PlaceableItemSettings> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.List<PlaceableItemSettings>>(string 丞丕丒专一下丙业上);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_11 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            if(val_11 == null)
            {
                goto label_19;
            }
            
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "SUCESS ClanPlaceableItems config parse");
            List.Enumerator<T> val_4 = val_11.GetEnumerator();
            goto label_11;
            label_14:
            val_9 = 0.丐丏七丌丕丗业且上().Id;
            mem2[0] = val_9;
            label_11:
            if(((-2069129320) & 1) != 0)
            {
                goto label_14;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.List<PlaceableItemSettings>)val_11;
            label_19:
            val_8 = "FAILURE ClanPlaceableItems config parse";
            label_2:
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  val_8);
            System.Collections.Generic.List<PlaceableItemSettings> val_7 = null;
            val_11 = val_7;
            val_7 = new System.Collections.Generic.List<PlaceableItemSettings>();
            return (System.Collections.Generic.List<PlaceableItemSettings>)val_11;
        }
        internal static System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Collections.Generic.Dictionary<string, int>> 丁与丛丙丏上三丛业(string 丌且专不丙丕专丅万)
        {
            var val_9;
            var val_15;
            var val_25;
            string val_34;
            var val_35;
            var val_36;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            val_34 = 丌且专不丙丕专丅万;
            System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_1 = null;
            val_35 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
            if((System.String.IsNullOrEmpty(value:  val_34)) != false)
            {
                    丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "IntemIndexes config is null");
                return (System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Collections.Generic.Dictionary<System.String, System.Int32>>)val_35;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_1.Add(key:  216, value:  null);
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_1.Add(key:  226, value:  null);
            object val_5 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_34);
            Dictionary.Enumerator<TKey, TValue> val_7 = GetEnumerator();
            val_36 = 1152921516595685792;
            val_34 = 0;
            label_64:
            if(((-2068935328) & 1) == 0)
            {
                goto label_11;
            }
            
            ConfiguredValueTaskAwaiter val_11 = val_9.GetAwaiter();
            if(val_11._value._obj == 0)
            {
                goto label_64;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_12 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            Dictionary.Enumerator<TKey, TValue> val_13 = val_11._value._obj.GetEnumerator();
            label_19:
            if(((-2068935392) & 1) == 0)
            {
                goto label_15;
            }
            
            ConfiguredValueTaskAwaiter val_17 = val_15.GetAwaiter();
            null.Add(key:  val_17._value._obj.丐丏七丌丕丗业且上(), value:  System.Convert.ToInt32(value:  val_17._value._obj));
            goto label_19;
            label_15:
            var val_34 = 0;
            val_34 = val_34 + 1;
            mem2[0] = 185;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_36 = val_34;
            if((val_36 != 1) && ((-2068935664 + ((0 + 1)) << 2) == 185))
            {
                    var val_35 = 0;
                val_35 = val_35 ^ (val_36 >> 31);
                val_36 = val_36 + val_35;
            }
            
            if(((丞东丑专丛丆丄丝世.与丛丆专东丐一且丅<Rilisoft.OfferItemType>(丙业与丙丗丝不丈东:  val_11._value._obj.丐丏七丌丕丗业且上())) != 1240) || (null.Count < 1))
            {
                goto label_64;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_23 = null.GetEnumerator();
            label_46:
            if(((-2068935456) & 1) == 0)
            {
                goto label_36;
            }
            
            ConfiguredValueTaskAwaiter val_27 = val_25.GetAwaiter();
            val_38 = null;
            val_38 = null;
            if((val_27._value._obj.丐丏七丌丕丗业且上().EndsWith(value:  PGCompany.丌丂丐丕丑丐丅世丄.丐下丕丏丗不不业三)) == false)
            {
                goto label_40;
            }
            
            val_1.Item[216].Add(key:  val_27._value._obj.丐丏七丌丕丗业且上(), value:  -2068935472);
            goto label_46;
            label_40:
            val_1.Item[226].Add(key:  val_27._value._obj.丐丏七丌丕丗业且上(), value:  -2068935472);
            goto label_46;
            label_36:
            var val_37 = val_36;
            val_39 = 0;
            val_37 = val_37 + 1;
            mem2[0] = 343;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_39 = val_37;
            if((val_39 == 1) || ((-2068935664 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) != 343))
            {
                goto label_61;
            }
            
            var val_38 = 0;
            val_38 = val_38 ^ (val_39 >> 31);
            val_39 = val_39 + val_38;
            goto label_64;
            label_61:
            if( == 0)
            {
                goto label_64;
            }
            
            goto label_64;
            label_11:
            var val_40 = val_39;
            val_40 = -2068935664;
            val_41 = 0;
            val_40 = val_40 + 1;
            mem2[0] = 371;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_40 != 1)
            {
                    if( == null)
            {
                    return (System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Collections.Generic.Dictionary<System.String, System.Int32>>)val_35;
            }
            
                if((val_40 + ((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) != 371)
            {
                    return (System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Collections.Generic.Dictionary<System.String, System.Int32>>)val_35;
            }
            
                return (System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Collections.Generic.Dictionary<System.String, System.Int32>>)val_35;
            }
            
            if( == null)
            {
                    return (System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Collections.Generic.Dictionary<System.String, System.Int32>>)val_35;
            }
            
            return (System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.Collections.Generic.Dictionary<System.String, System.Int32>>)val_35;
        }
        private static 丌丂丐丕丑丐丅世丄()
        {
            PGCompany.丌丂丐丕丑丐丅世丄.丐下丕丏丗不不业三 = "main";
        }
    
    }

}
