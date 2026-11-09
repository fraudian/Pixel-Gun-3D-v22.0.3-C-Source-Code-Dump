using UnityEngine;

namespace Progress
{
    internal sealed class 一丒丂丘丛丂下丟世
    {
        // Fields
        internal static readonly string 丐专丂丄丆丏七丘专;
        internal static readonly string 丟丟丏上丘丈丐业专;
        internal static readonly string 丝万丂万丏一丂丈三;
        internal static readonly string 丕下世不丗上丑丅丟;
        internal static readonly string 丒丒七丒且丐丆丁丗;
        internal static readonly string 三丁且丟丐丈丟丞丆;
        internal static readonly string 丁丌七一丐丛且丞丕;
        
        // Methods
        internal System.Collections.Generic.Dictionary<string, object> 丈万上丙丝丂丑丄丂(Progress.下丏丕丙丒七丞丞丄.丁丘丏三丙上专丕丗 专丞丙一丟专丞与丗)
        {
            var val_10;
            var val_11;
            var val_12;
            PGCompany.上丅丙丟不业不丆东 val_13;
            var val_14;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(专丞丙一丟专丞与丗.SaveSets.Count >= 1)
            {
                    val_10 = null;
                val_10 = null;
                val_1.set_Item(key:  Progress.一丒丂丘丛丂下丟世.丕下世不丗上丑丅丟, value:  丙丛不一丄丕世丗上(万丝且丘不丑丝下丑:  专丞丙一丟专丞与丗.SaveSets));
            }
            
            if(专丞丙一丟专丞与丗.SaveTimeBuyPromotions.Count >= 1)
            {
                    val_11 = null;
                val_11 = null;
                val_1.set_Item(key:  Progress.一丒丂丘丛丂下丟世.丒丒七丒且丐丆丁丗, value:  丙丛不一丄丕世丗上(万丝且丘不丑丝下丑:  专丞丙一丟专丞与丗.SaveTimeBuyPromotions));
            }
            
            if(专丞丙一丟专丞与丗.SaveLastTimeViewPromotions.Count >= 1)
            {
                    val_12 = null;
                val_12 = null;
                val_1.set_Item(key:  Progress.一丒丂丘丛丂下丟世.三丁且丟丐丈丟丞丆, value:  丙丛不一丄丕世丗上(万丝且丘不丑丝下丑:  专丞丙一丟专丞与丗.SaveLastTimeViewPromotions));
            }
            
            val_13 = 专丞丙一丟专丞与丗.SaveLastPresentationTimeViewPromotions;
            if(val_13.Count < 1)
            {
                    return val_1;
            }
            
            val_14 = null;
            val_14 = null;
            val_13 = Progress.一丒丂丘丛丂下丟世.丁丌七一丐丛且丞丕;
            val_1.set_Item(key:  val_13, value:  丙丛不一丄丕世丗上(万丝且丘不丑丝下丑:  专丞丙一丟专丞与丗.SaveLastPresentationTimeViewPromotions));
            return val_1;
        }
        internal Progress.下丏丕丙丒七丞丞丄.丁丘丏三丙上专丕丗 三丆丁丙与万丑丕丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            string val_21;
            var val_22;
            val_14 = null;
            val_14 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Progress.一丒丂丘丛丂下丟世.丕下世不丗上丑丅丟)) != false)
            {
                    val_15 = null;
                val_15 = null;
                object val_3 = 一丐丗丁丞丆丅丟丄.Item[Progress.一丒丂丘丛丂下丟世.丕下世不丗上丑丅丟];
                .SaveSets = val_3.丙丛不一丄丕世丗上(一丐丗丁丞丆丅丟丄:  val_3);
            }
            
            val_16 = null;
            val_16 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Progress.一丒丂丘丛丂下丟世.丒丒七丒且丐丆丁丗)) != false)
            {
                    val_17 = null;
                val_17 = null;
                object val_6 = 一丐丗丁丞丆丅丟丄.Item[Progress.一丒丂丘丛丂下丟世.丒丒七丒且丐丆丁丗];
                .SaveTimeBuyPromotions = val_6.丙丛不一丄丕世丗上(一丐丗丁丞丆丅丟丄:  val_6);
            }
            
            val_18 = null;
            val_18 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Progress.一丒丂丘丛丂下丟世.三丁且丟丐丈丟丞丆)) != false)
            {
                    val_19 = null;
                val_19 = null;
                object val_9 = 一丐丗丁丞丆丅丟丄.Item[Progress.一丒丂丘丛丂下丟世.三丁且丟丐丈丟丞丆];
                .SaveLastTimeViewPromotions = val_9.丙丛不一丄丕世丗上(一丐丗丁丞丆丅丟丄:  val_9);
            }
            
            val_20 = null;
            val_20 = null;
            val_21 = Progress.一丒丂丘丛丂下丟世.丁丌七一丐丛且丞丕;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  val_21)) == false)
            {
                    return (丁丘丏三丙上专丕丗)new 下丏丕丙丒七丞丞丄.丁丘丏三丙上专丕丗();
            }
            
            val_22 = null;
            val_22 = null;
            val_21 = Progress.一丒丂丘丛丂下丟世.丁丌七一丐丛且丞丕;
            object val_12 = 一丐丗丁丞丆丅丟丄.Item[val_21];
            .SaveLastPresentationTimeViewPromotions = val_12.丙丛不一丄丕世丗上(一丐丗丁丞丆丅丟丄:  val_12);
            return (丁丘丏三丙上专丕丗)new 下丏丕丙丒七丞丞丄.丁丘丏三丙上专丕丗();
        }
        private System.Collections.Generic.Dictionary<string, int> 丙丛不一丄丕世丗上(PGCompany.上丅丙丟不业不丆东 万丝且丘不丑丝下丑)
        {
            var val_10;
            var val_11;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>> val_2 = 万丝且丘不丑丝下丑.GetEnumerator();
            label_14:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_7;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_1.set_Item(key:  val_2.Current.丙东专丂世丈丏丁丂().ToString(), value:  2115420568);
            goto label_14;
            label_7:
            val_10 = 0;
            val_11 = 0;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_2.Dispose();
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
        private PGCompany.上丅丙丟不业不丆东 丙丛不一丄丕世丗上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_2;
            object val_14 = 一丐丗丁丞丆丅丟丄;
            if(val_14 != null)
            {
                    val_14 = 0;
            }
            
            if(val_14 == 0)
            {
                    return (PGCompany.上丅丙丟不业不丆东);
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = val_14.GetEnumerator();
            label_11:
            if((2115573520 & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_2.GetAwaiter();
            new PGCompany.上丅丙丟不业不丆东().set_Item(下上丐丆丝丟丝丒不:  System.Convert.ToInt32(value:  val_7._value._obj.丐丏七丌丕丗业且上(), provider:  System.Globalization.CultureInfo.InvariantCulture), 丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  val_7._value._obj, provider:  System.Globalization.CultureInfo.InvariantCulture));
            goto label_11;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (PGCompany.上丅丙丟不业不丆东);
        }
        public 一丒丂丘丛丂下丟世()
        {
        
        }
        private static 一丒丂丘丛丂下丟世()
        {
            Progress.一丒丂丘丛丂下丟世.丐专丂丄丆丏七丘专 = "o";
            Progress.一丒丂丘丛丂下丟世.丟丟丏上丘丈丐业专 = "i";
            Progress.一丒丂丘丛丂下丟世.丝万丂万丏一丂丈三 = "t";
            Progress.一丒丂丘丛丂下丟世.丕下世不丗上丑丅丟 = "ss";
            Progress.一丒丂丘丛丂下丟世.丒丒七丒且丐丆丁丗 = "st";
            Progress.一丒丂丘丛丂下丟世.三丁且丟丐丈丟丞丆 = "sltv";
            Progress.一丒丂丘丛丂下丟世.丁丌七一丐丛且丞丕 = "slptv";
        }
    
    }

}
