using UnityEngine;

namespace Progress
{
    internal sealed class 丛东丙丙三丐丒业三
    {
        // Fields
        internal static readonly string 丐专丂丄丆丏七丘专;
        internal static readonly string 丛与丂丕丆丘丞三一;
        internal static readonly string 丝万丂万丏一丂丈三;
        internal static readonly string 丂丙世丗业一专丁丁;
        internal static readonly string 东丒七丟下万专丒与;
        internal static readonly string 不丕万丏丒七东丁丒;
        internal static readonly string 一万丁丟万丈丗丗三;
        internal static readonly string 丛世丏丑丝丑丁丂不;
        internal static readonly string 丛丄业丈东万丘丞丁;
        
        // Methods
        internal System.Collections.Generic.Dictionary<string, object> 丈万上丙丝丂丑丄丂(Progress.世丝上丗万丙丏世丞.丁丘丏三丙上专丕丗 专丞丙一丟专丞与丗)
        {
            var val_12;
            var val_13;
            PGCompany.上丅丙丟不业不丆东 val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(专丞丙一丟专丞与丗.SavePaymentType.Count >= 1)
            {
                    val_12 = null;
                val_12 = null;
                val_1.set_Item(key:  Progress.丛东丙丙三丐丒业三.一万丁丟万丈丗丗三, value:  丙丛不一丄丕世丗上(万丝且丘不丑丝下丑:  专丞丙一丟专丞与丗.SavePaymentType));
            }
            
            if(专丞丙一丟专丞与丗.SaveTimeBuyPromotions.Count >= 1)
            {
                    val_13 = null;
                val_13 = null;
                val_1.set_Item(key:  Progress.丛东丙丙三丐丒业三.丛世丏丑丝丑丁丂不, value:  丙丛不一丄丕世丗上(万丝且丘不丑丝下丑:  专丞丙一丟专丞与丗.SaveTimeBuyPromotions));
            }
            
            val_14 = 专丞丙一丟专丞与丗.SaveTimeGeneration;
            if(val_14.Count >= 1)
            {
                    val_15 = null;
                val_15 = null;
                val_14 = Progress.丛东丙丙三丐丒业三.丛丄业丈东万丘丞丁;
                val_1.set_Item(key:  val_14, value:  丙丛不一丄丕世丗上(万丝且丘不丑丝下丑:  专丞丙一丟专丞与丗.SaveTimeGeneration));
            }
            
            if(专丞丙一丟专丞与丗.丟一不丐丆丑丕东丅() != false)
            {
                    val_16 = null;
                val_16 = null;
                val_14 = Progress.丛东丙丙三丐丒业三.丂丙世丗业一专丁丁;
                val_1.set_Item(key:  val_14, value:  1);
            }
            
            if(专丞丙一丟专丞与丗.一且丄丄丏丛丁丗东() >= 1)
            {
                    val_17 = null;
                val_17 = null;
                val_14 = Progress.丛东丙丙三丐丒业三.不丕万丏丒七东丁丒;
                val_1.set_Item(key:  val_14, value:  专丞丙一丟专丞与丗.一且丄丄丏丛丁丗东());
            }
            
            if(专丞丙一丟专丞与丗.丈丂丗与下万丕丁不() == false)
            {
                    return val_1;
            }
            
            val_18 = null;
            val_18 = null;
            val_14 = 1;
            val_1.set_Item(key:  Progress.丛东丙丙三丐丒业三.东丒七丟下万专丒与, value:  1);
            return val_1;
        }
        internal Progress.世丝上丗万丙丏世丞.丁丘丏三丙上专丕丗 三丆丁丙与万丑丕丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            string val_34;
            var val_35;
            世丝上丗万丙丏世丞.丁丘丏三丙上专丕丗 val_1 = new 世丝上丗万丙丏世丞.丁丘丏三丙上专丕丗();
            val_23 = null;
            val_23 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Progress.丛东丙丙三丐丒业三.一万丁丟万丈丗丗三)) != false)
            {
                    val_24 = null;
                val_24 = null;
                object val_3 = 一丐丗丁丞丆丅丟丄.Item[Progress.丛东丙丙三丐丒业三.一万丁丟万丈丗丗三];
                .SavePaymentType = val_3.丙丛不一丄丕世丗上(一丐丗丁丞丆丅丟丄:  val_3);
            }
            
            val_25 = null;
            val_25 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Progress.丛东丙丙三丐丒业三.丛世丏丑丝丑丁丂不)) != false)
            {
                    val_26 = null;
                val_26 = null;
                object val_6 = 一丐丗丁丞丆丅丟丄.Item[Progress.丛东丙丙三丐丒业三.丛世丏丑丝丑丁丂不];
                .SaveTimeBuyPromotions = val_6.丙丛不一丄丕世丗上(一丐丗丁丞丆丅丟丄:  val_6);
            }
            
            val_27 = null;
            val_27 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Progress.丛东丙丙三丐丒业三.丛丄业丈东万丘丞丁)) != false)
            {
                    val_28 = null;
                val_28 = null;
                object val_9 = 一丐丗丁丞丆丅丟丄.Item[Progress.丛东丙丙三丐丒业三.丛丄业丈东万丘丞丁];
                .SaveTimeGeneration = val_9.丙丛不一丄丕世丗上(一丐丗丁丞丆丅丟丄:  val_9);
            }
            
            val_29 = null;
            val_29 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Progress.丛东丙丙三丐丒业三.丂丙世丗业一专丁丁)) != false)
            {
                    val_30 = null;
                val_30 = null;
                System.IFormatProvider val_23 = System.Globalization.CultureInfo.InvariantCulture;
                val_23 = System.Convert.ToBoolean(value:  一丐丗丁丞丆丅丟丄.Item[Progress.丛东丙丙三丐丒业三.丂丙世丗业一专丁丁], provider:  val_23);
                val_1.专丞下世七丄丞丛丞(丙业与丙丗丝不丈东:  val_23);
            }
            
            val_31 = null;
            val_31 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Progress.丛东丙丙三丐丒业三.不丕万丏丒七东丁丒)) != false)
            {
                    val_32 = null;
                val_32 = null;
                val_1.下丒不丘万世丂下丙(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item[Progress.丛东丙丙三丐丒业三.不丕万丏丒七东丁丒], provider:  System.Globalization.CultureInfo.InvariantCulture));
            }
            
            val_33 = null;
            val_33 = null;
            val_34 = Progress.丛东丙丙三丐丒业三.东丒七丟下万专丒与;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  val_34)) == false)
            {
                    return (丁丘丏三丙上专丕丗)val_1;
            }
            
            val_35 = null;
            val_35 = null;
            val_34 = System.Globalization.CultureInfo.InvariantCulture;
            System.IFormatProvider val_24 = val_34;
            val_24 = System.Convert.ToBoolean(value:  一丐丗丁丞丆丅丟丄.Item[Progress.丛东丙丙三丐丒业三.东丒七丟下万专丒与], provider:  val_24);
            val_1.世丕七丕丛上业一丄(丙业与丙丗丝不丈东:  val_24);
            return (丁丘丏三丙上专丕丗)val_1;
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
            val_1.set_Item(key:  val_2.Current.丙东专丂世丈丏丁丂().ToString(), value:  2119228776);
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
            if((2119381728 & 1) == 0)
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
        public 丛东丙丙三丐丒业三()
        {
        
        }
        private static 丛东丙丙三丐丒业三()
        {
            Progress.丛东丙丙三丐丒业三.丐专丂丄丆丏七丘专 = "o";
            Progress.丛东丙丙三丐丒业三.丛与丂丕丆丘丞三一 = "pt";
            Progress.丛东丙丙三丐丒业三.丝万丂万丏一丂丈三 = "t";
            Progress.丛东丙丙三丐丒业三.丂丙世丗业一专丁丁 = "io";
            Progress.丛东丙丙三丐丒业三.东丒七丟下万专丒与 = "icm";
            Progress.丛东丙丙三丐丒业三.不丕万丏丒七东丁丒 = "ltv";
            Progress.丛东丙丙三丐丒业三.一万丁丟万丈丗丗三 = "spt";
            Progress.丛东丙丙三丐丒业三.丛世丏丑丝丑丁丂不 = "sbt";
            Progress.丛东丙丙三丐丒业三.丛丄业丈东万丘丞丁 = "stg";
        }
    
    }

}
