using UnityEngine;

namespace PGCompany.Analytics
{
    internal static class 一业丗丆世世上丁且
    {
        // Fields
        private static PGCompany.Analytics.一业丗丆世世上丁且.专不世七世三且丏丌 丘丘上丑与不丙丌世;
        private static PGCompany.Analytics.与丌丛一丆丈丂业丂 丕丂丒丁丆丈万丈丘;
        private static PGCompany.Analytics.与丌丛一丆丈丂业丂 丟丒万丐东丝丟业一;
        private static System.Collections.Generic.Dictionary<string, object> 丆与丛丅丂三万一丑;
        
        // Methods
        private static System.Collections.Generic.Dictionary<string, object> 丗丈万东丝专丘丌丞(int 丕专七丙丂丅丕与丘)
        {
            var val_8;
            object val_9;
            val_8 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
            val_9 = val_8.Comparer;
            if((System.Object.Equals(objA:  val_9, objB:  System.StringComparer.Ordinal)) == true)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_8;
            }
            
            PGCompany.七丑一上且三世丝三<K, V> val_5 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
            val_9 = System.StringComparer.Ordinal;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = null;
            val_8 = val_7;
            val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  丕专七丙丂丅丕与丘, comparer:  val_9);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_8;
        }
        private static void 丟下丌丂丈丕且丒丞(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑)
        {
            if((PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不()) == null)
            {
                
            }
        
        }
        private static System.Collections.Generic.Dictionary<string, int> 丂丑与丅丙一东丕丞()
        {
            var val_13;
            int val_14;
            char[] val_4 = new char[1];
            val_4[0] = '#';
            System.Collections.Generic.Dictionary<UnityEngine.UI.IClipper, System.Int32> val_6 = new System.Collections.Generic.Dictionary<UnityEngine.UI.IClipper, System.Int32>();
            val_13 = 0;
            goto label_9;
            label_21:
            val_14 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  2, 下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗()).Split(separator:  val_4)[0]);
            if(val_14 != null)
            {
                    UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                string val_10 = val_14.丒万丕七专不丏丞丌().ToString().Replace(oldValue:  "Category", newValue:  "");
                if((val_6.ContainsKey(key:  val_10)) != true)
            {
                    val_14 = val_14.业东丅东丌上丗丑不();
                val_6.Add(key:  val_10, value:  val_14);
            }
            
            }
            
            val_13 = 1;
            label_9:
            if(val_13 < val_5.Length)
            {
                goto label_21;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)val_6;
        }
        private static System.Collections.Generic.Dictionary<string, int> 丄专丅世万东丂丒丟(System.Collections.Generic.ICollection<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
        {
            int val_18;
            var val_19;
            var val_20;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            if(丈丄不七三万丄丁不 == null)
            {
                    return val_1;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = 丈丄不七三万丄丁不.GetEnumerator();
            label_27:
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            T val_7 = val_3.Current;
            if(val_7 == 0)
            {
                goto label_27;
            }
            
            if(val_7.丙丑丁专一专世万丕() > 0)
            {
                    val_18 = val_7.丙丑丁专一专世万丕();
            }
            else
            {
                    val_18 = val_7.丂丁丏一丙丛业且丌();
            }
            
            if(val_18 < 1)
            {
                goto label_27;
            }
            
            string val_13 = System.String.Format(format:  "{0}:{1}", arg0:  val_7.不业丙丒丂丞下丆丙(), arg1:  val_7.业上丙丞丐丄丆丅七());
            if((val_1.ContainsKey(key:  val_13)) == false)
            {
                goto label_22;
            }
            
            val_1.set_Item(key:  val_13, value:  val_1.Item[val_13] + val_18);
            goto label_27;
            label_22:
            val_1.Add(key:  val_13, value:  val_18);
            goto label_27;
            label_11:
            val_19 = 0;
            val_20 = 0;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_3.Dispose();
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
        private static System.Collections.Generic.Dictionary<string, object> 丟丞丆丂与万丂丑下(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            object val_51;
            var val_52;
            var val_53;
            object val_54;
            var val_55;
            object val_56;
            object val_57;
            var val_58;
            object val_59;
            object val_60;
            object val_61;
            var val_62;
            var val_63;
            var val_64;
            .且丟丅丄丒丑丂丁世 = 且丟丅丄丒丑丂丁世;
            val_51 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丁下丆三丏丌丕业丂();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  (val_51 != true) ? 20 : 10);
            val_52 = null;
            val_52 = null;
            val_53 = 1152921504622075904;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丕丛丑与业且与下丌, value:  (一业丗丆世世上丁且.业东下丕世丗丏万丏)[1152921560227389376].且丟丅丄丒丑丂丁世.丁丈丕丆下丙丏业世());
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丞专丑丄东业不东丛, value:  (一业丗丆世世上丁且.业东下丕世丗丏万丏)[1152921560227389376].且丟丅丄丒丑丂丁世.上上三七丟丝与丆与());
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丞丞东三丁丐丞万七, value:  (一业丗丆世世上丁且.业东下丕世丗丏万丏)[1152921560227389376].且丟丅丄丒丑丂丁世.三丒三丕不七丁丅丈());
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丗丈丛丁丛专丂丏东, value:  (一业丗丆世世上丁且.业东下丕世丗丏万丏)[1152921560227389376].且丟丅丄丒丑丂丁世.丁世丒丂丁不世丈丒());
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.且与万丟丝东丁丏丙, value:  (一业丗丆世世上丁且.业东下丕世丗丏万丏)[1152921560227389376].且丟丅丄丒丑丂丁世.丈专丙与丛下丈丕丒());
            世专丙丟且丗丄丆丌 val_11 = 丂丘丗丗与且丌丁丙.丕上丒丅丝丛丒丐丅();
            if((val_11 != null) && (val_11.丞丘丕丈丄丛且丝东() != null))
            {
                    val_51 = val_51 & ((val_11 != 0) ? 1 : 0);
                val_54 = 0;
            }
            else
            {
                    val_54 = 0;
            }
            
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丟丏丄与丞且世丑丘, value:  val_54);
            val_55 = null;
            val_55 = null;
            世专丙丟且丗丄丆丌 val_14 = 丂丘丗丗与且丌丁丙.丗专丕丌下专东丅丈();
            if((val_14 != null) && (val_14.丞丘丕丈丄丛且丝东() != null))
            {
                    val_51 = val_51 & ((val_14 != 0) ? 1 : 0);
                val_56 = 0;
            }
            else
            {
                    val_56 = 0;
            }
            
            val_57 = val_56;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丟丌下不丛丟不, value:  val_56);
            if(val_51 == false)
            {
                    return val_5;
            }
            
            val_58 = null;
            val_58 = null;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与万丌丗丛东一丞丄, value:  (一业丗丆世世上丁且.业东下丕世丗丏万丏)[1152921560227389376].且丟丅丄丒丑丂丁世.业不且丟丆下丏丌丒());
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.且上不丒且丄丑丑不, value:  System.Linq.Enumerable.Sum<七丈丗不丞丈丝丙七>(source:  (一业丗丆世世上丁且.业东下丕世丗丏万丏)[1152921560227389376].且丟丅丄丒丑丂丁世.丙丆丞东丆丏丞一不(), selector:  new System.Func<七丈丗不丞丈丝丙七, System.Int32>(object:  new 一业丗丆世世上丁且.业东下丕世丗丏万丏(), method:  System.Int32 一业丗丆世世上丁且.业东下丕世丗丏万丏::丛下上丛七丐丁丂七(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑))));
            一一万丒与专丙丁丛 val_21 = (一业丗丆世世上丁且.业东下丕世丗丏万丏)[1152921560227389376].且丟丅丄丒丑丂丁世.世丝丌一且丝专丑丛();
            System.Globalization.CultureInfo val_22 = System.Globalization.CultureInfo.InvariantCulture;
            if(val_21 != 0)
            {
                    val_59 = val_21.ToString(provider:  val_22);
            }
            else
            {
                    val_59 = val_21.ToString(provider:  val_22);
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丏业丈与丆下丆专, value:  val_59);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丄丞万丙丗业丘丄上, value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            System.Collections.Generic.List<PGCompany.丁下丒丕丆下丂丆丌> val_29 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丙丏丌不丒一一丒上(丄丒下业一不丈丝丘:  (一业丗丆世世上丁且.业东下丕世丗丏万丏)[1152921560227389376].且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁());
            if(val_29 != null)
            {
                    int val_30 = val_29.Count;
                val_60 = 0;
            }
            else
            {
                    val_60 = 0;
            }
            
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丁丗丁三丘东专东三, value:  val_60);
            System.Collections.Generic.List<Rilisoft.OfferItem> val_32 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丁丑丘丘丆上上上丅();
            if((val_32 != null) && (val_32.Count >= 1))
            {
                    val_53 = "ClanSilver";
                val_61 = 0;
                val_57 = 0;
                var val_51 = 0;
                do
            {
                if(val_32.Item[0] != null)
            {
                    if(val_32.Item[0].Type == 1200)
            {
                    if((System.String.op_Equality(a:  val_32.Item[0].Id, b:  "ClanSilver")) != false)
            {
                    val_61 = val_32.Item[0].Count + val_61;
            }
            
            }
            
                if(val_32.Item[0].Type == 1220)
            {
                    val_57 = val_32.Item[0].Count + val_57;
            }
            
            }
            
                val_51 = val_51 + 1;
            }
            while(val_51 < val_32.Count);
            
            }
            else
            {
                    val_57 = 0;
                val_61 = 0;
            }
            
            val_62 = null;
            val_63 = 1152921525544440992;
            val_64 = 1152921504622075904;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丕专世丕丏丙下丈丐, value:  val_61);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.一丟丐丙业丘东丒一, value:  val_57);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丙丝丁丗丙丛三丞, value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丙丘上丞专丏丘世世(丁丅丈丌丟世丗丗丟:  1));
            int val_50 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丙丘上丞专丏丘世世(丁丅丈丌丟世丗丗丟:  2);
            val_51 = val_50;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丑丟一丗丅丕专丂丟, value:  val_50);
            return val_5;
        }
        private static System.Collections.Generic.Dictionary<string, int> 丌业丒丁上丟专丗丞()
        {
            var val_14;
            int val_15;
            var val_16;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_14 = null;
            val_14 = null;
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丏不丆世丐上与七, value:  BankController.七丞且七一丑下丒丞());
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丕世七丂丗专丝上丕, value:  BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  0));
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒一丘丑东丏专丅万, value:  BankController.丈三丝丌且丘丄专丗());
            val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  79), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世东丙丟丄下丌与丈, value:  val_15);
            丞丂丘丒丟丞丑下丄 val_9 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_9 == null)
            {
                    return val_1;
            }
            
            val_16 = null;
            val_16 = null;
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丄丈不业七业丒万, value:  val_9.下上东丟丟世世且丄(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()));
            val_15 = PGCompany.Analytics.丂与丏丕一丒与丁丙.万丙丂一丛下业丌丌;
            val_1.set_Item(key:  val_15, value:  val_9.丝万下丌丄丟专丂世(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()));
            return val_1;
        }
        internal static void 东三专万丁丏丄丟丕(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, bool 东丒一东丐丑万业丁, int 丆专且丕专丗与一丏, int 东一丂丏丄东丛一丟, string 上且丕丙东丒上丆三, string 与丄不丌一世东丁丙, string 丟下丟丈万一丙东丄)
        {
            string val_5;
            string val_6;
            int val_7;
            var val_8;
            val_5 = 丟下丟丈万一丙东丄;
            val_6 = 与丄不丌一世东丁丙;
            val_7 = 丆专且丕专丗与一丏;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_6 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  6);
            val_8 = null;
            val_8 = null;
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  东丒一东丐丑万业丁));
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_7);
            val_7 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_6.set_Item(key:  val_7, value:  东一丂丏丄东丛一丟);
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  上且丕丙东丒上丆三);
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_6);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
            val_6.set_Item(key:  val_5, value:  val_5);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  74, 丗丟上上丒丐丗丞丙:  val_6);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_6);
        }
        internal static void 且丆丐专丆万丒业丐(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丁丅丈丌丟世丗丗丟, string 世丁丙世丄一万丆三)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_3 = null;
            val_3 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丁丅丈丌丟世丗丗丟);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  世丁丙世丄一万丆三);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  1023, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丙与不丞三丑丑业丏(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 且丙七丂万丁丙丕一, System.Nullable<int> 世与丝丒业丗丈丅丟)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4;
            var val_5;
            var val_6;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_4 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            if(((-213231208) & 1) != 0)
            {
                    val_5 = null;
                val_5 = null;
                val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  世与丝丒业丗丈丅丟.HasValue);
            }
            
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  且丙七丂万丁丙丕一)) != false)
            {
                    val_6 = null;
                val_6 = null;
                val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  且丙七丂万丁丙丕一);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  2, 丗丟上上丒丐丗丞丙:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_4);
        }
        internal static void 丄上三丟三丕丛丙丑(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 东一丂丏丄东丛一丟, int 丙丈丘下七丆丂万丝, string 上且丕丙东丒上丆三, string 与丄不丌一世东丁丙)
        {
            object val_3;
            int val_4;
            var val_5;
            val_3 = 上且丕丙东丒上丆三;
            val_4 = 丙丈丘下七丆丂万丝;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  东一丂丏丄东丛一丟);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_3, value:  与丄不丌一世东丁丙);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  75, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丟丐丗不不三七丗丘(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, long 丛丄丞丐丂丅丅与丏)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_32;
            var val_33;
            var val_34;
            object val_35;
            var val_36;
            var val_37;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            decimal val_6 = Rilisoft.Singleton<KillrateController>.Instance.万上丗丂丅丕丙且丆().CalculateKillRate;
            val_3.Add(key:  "total", value:  val_6);
            val_2.Add(key:  "Killrates", value:  val_3);
            string val_9 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            val_32 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_33 = null;
            val_33 = null;
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  ExperienceController.万丏丙丈东东万丝丞());
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅());
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且());
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌());
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  78));
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  UnityEngine.SystemInfo.deviceModel);
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  UnityEngine.SystemInfo.processorType);
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_2));
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  PGCompany.Analytics.一业丗丆世世上丁且.丌业丒丁上丟专丗丞());
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅, value:  PGCompany.Analytics.一业丗丆世世上丁且.丂丑与丅丙一东丕丞());
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  0);
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑, value:  "");
            val_34 = null;
            val_34 = null;
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  79);
            int val_25 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            val_35 = val_25;
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  val_25);
            丞丂丘丒丟丞丑下丄 val_27 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_27 != null)
            {
                    val_35 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_35)) != true)
            {
                    val_36 = null;
                val_36 = null;
                val_35 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑;
                val_32.set_Item(key:  val_35, value:  val_27.三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  val_35));
            }
            
            }
            
            if(丛丄丞丐丂丅丅与丏 >= 1)
            {
                    val_37 = null;
                val_37 = null;
                val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业万一丏丌上三丑丟, value:  丛丄丞丐丂丅丅与丏);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  1, 丗丟上上丒丐丗丞丙:  val_32);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_32);
        }
        internal static void 丙丏三一丝与丛丑丂(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丆丐七丅丆丗丛上与)
        {
            bool val_1 = PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑();
        }
        internal static void 丏丄丆丕且丁与下丘(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 专丑专丗丂丅丏与丗, string 丑东与丅丐丅丂丞业, int 下丅丌丌丆不东专丁, string 丈丕丁丘七丙丞不丙)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
            int val_8;
            int val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = 下丅丌丌丆不东专丁;
            val_9 = 专丑专丗丂丅丏与丗;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_7 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_8 >= 1)
            {
                    null.set_Item(key:  "gems", value:  val_8);
            }
            
            if((System.String.IsNullOrEmpty(value:  丈丕丁丘七丙丞不丙)) != true)
            {
                    null.set_Item(key:  "egg", value:  丈丕丁丘七丙丞不丙);
            }
            
            if((val_9 & 2147483648) == 0)
            {
                    val_10 = null;
                val_10 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_9);
            }
            
            val_11 = null;
            val_11 = null;
            val_9 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_8 = 1152921516595668352;
            val_7.set_Item(key:  val_9, value:  丑东与丅丐丅丂丞业);
            if(null.Count >= 1)
            {
                    val_12 = null;
                val_12 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  null);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  247, 丗丟上上丒丐丗丞丙:  val_7);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_7);
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(162 == 162)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        internal static void 下丛丑不丈业丗丏丕(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.三东丏不丗世丅丌丄 三丅丈丛下丛丆丏丂, bool 三丆丝丏丏下下丐不, bool 不丆丝与丗丏下丏丌, int 丏丝丌不丆上世丒七)
        {
            var val_9;
            int val_10;
            bool val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = 丏丝丌不丆上世丒七;
            val_11 = 三丆丝丏丏下下丐不;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  7);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_11);
            val_12 = null;
            val_12 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  丈丄不七三万丄丁不.丙丑丁专一专世万丕());
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  不丆丝与丗丏下丏丌);
            val_13 = null;
            val_11 = 丆丛丑世下一丐且丕;
            val_9 = 1152921505690550272;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  val_10);
            val_10 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_10, value:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七());
            if(三丅丈丛下丛丆丏丂 != 0)
            {
                    val_14 = null;
                val_14 = null;
                int val_7 = 三丅丈丛下丛丆丏丂.丂丁丏一丙丛业且丌();
                val_10 = val_7;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_7);
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  三丅丈丛下丛丆丏丂.业上丙丞丐丄丆丅七());
            }
            
            val_11.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  1020, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 上且丄业七丆丌不丘(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丌丒丝东丌下丕丁丅, string 丏丂不专上丘丂不丅, string 丑东与丅丐丅丂丞业)
        {
            object val_8;
            int val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = 丏丂不专上丘丂不丅;
            val_9 = 丌丒丝东丌下丕丁丅;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_10 = null;
            val_10 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_9);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_8);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丑东与丅丐丅丂丞业);
            val_9 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_9, value:  0);
            if((丑东与丅丐丅丂丞业.Equals(value:  "Battle")) != false)
            {
                    if(GameConnect.丑丌丛丈丅丅与不业() == 31)
            {
                    val_11 = null;
                val_11 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  "freeplay");
            }
            
            }
            
            if((System.String.op_Equality(a:  val_8, b:  "ClanSilver")) != false)
            {
                    val_12 = null;
                val_12 = null;
                val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
                val_2.set_Item(key:  val_8, value:  (PGCompany.ClanStoreBuffsController.丆丛七丆万丕丘业丂() != 0) ? 1 : 0);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  244, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丞丈丗一丑上丑东丈(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丌丒丝东丌下丕丁丅, string 丏丂不专上丘丂不丅, string 丑东与丅丐丅丂丞业)
        {
            object val_3;
            int val_4;
            var val_5;
            val_3 = 丏丂不专上丘丂不丅;
            val_4 = 丌丒丝东丌下丕丁丅;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_3, value:  丑东与丅丐丅丂丞业);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  245, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丞丟丙丅丒丛丌丛下(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丒丂丝万丏丑丞东下)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3;
            var val_4;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_4 = null;
            val_4 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丒丂丝万丏丑丞东下);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  242, 丗丟上上丒丐丗丞丙:  val_3);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_3);
        }
        internal static void 丄丄三丌丐丛与丙丕(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 三专七丗且专丞专丟, int 丏万业与丈丗丝丝且, System.Collections.Generic.List<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗> 丘丏丝不一丈丐丕丝)
        {
            int val_5;
            object val_14;
            string val_15;
            var val_16;
            val_15 = 丘丏丝不一丈丐丕丝;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = null;
            val_14 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            List.Enumerator<T> val_3 = val_15.GetEnumerator();
            label_11:
            if(((-211548864) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            val_2.set_Item(key:  val_6.丂丑丞丝且万丐万丟().NameDefault, value:  val_6.丂丑丞丝且万丐万丟().Count);
            goto label_11;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_16 = null;
            val_16 = null;
            val_5 = 丏万业与丈丗丝丝且 & (~(丏万业与丈丗丝丝且 >> 31));
            val_12.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            val_15 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_12.set_Item(key:  val_15, value:  三专七丗且专丞专丟);
            val_12.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_2);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  243, 丗丟上上丒丐丗丞丙:  val_12);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_12);
        }
        internal static void 东东上丟丏且丑三丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丐下丝丘丑丟丟丗丌, string 三丒三丒一专丈万丑)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_3 = null;
            val_3 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丐下丝丘丑丟丟丗丌);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  三丒三丒一专丈万丑);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  246, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丛丟一丌世丗丂丂丞(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丑丅世丐丒丏丐三丅, bool 丒丏下万世七丆上不, string 丞丟丂丄下万丈万东)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4;
            int val_5;
            var val_6;
            var val_7;
            val_5 = 丑丅世丐丒丏丐三丅;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_4 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_6 = null;
            val_6 = null;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_4.set_Item(key:  val_5, value:  丒丏下万世七丆上不);
            val_7 = null;
            val_7 = null;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丞丟丂丄下万丈万东);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  203, 丗丟上上丒丐丗丞丙:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_4);
        }
        internal static void 丕三丘丕且丐丙丂业(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 七丐丅专且专七三丆, string 下丅丙一丂丗丅丝七, string 与丄不丌一世东丁丙)
        {
            object val_3;
            int val_4;
            var val_5;
            val_3 = 下丅丙一丂丗丅丝七;
            val_4 = 七丐丅专且专七三丆;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_3, value:  与丄不丌一世东丁丙);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  253, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 与丙业丑与东上下不(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 七丐丅专且专七三丆, string 丝七丌丘丅丄七丅丟, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丑七不与丛丆一丂丞, string 丐丌丟丕丅且丙三与, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞)
        {
            object val_13;
            string val_14;
            int val_15;
            var val_16;
            var val_17;
            var val_18;
            val_13 = 丐丌丟丕丅且丙三与;
            val_14 = 丑七不与丛丆一丂丞;
            val_15 = 七丐丅专且专七三丆;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  6);
            val_16 = null;
            val_16 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_15);
            val_15 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_15, value:  丝七丌丘丅丄七丅丟);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_13);
            if(丒世丘丘上丆丝东丞 != null)
            {
                    val_17 = null;
                val_17 = null;
                int val_3 = 丒世丘丘上丆丝东丞.丂丁丏一丙丛业且丌();
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_3);
                val_13 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
                val_2.set_Item(key:  val_13, value:  丒世丘丘上丆丝东丞.业上丙丞丐丄丆丅七());
            }
            
            if((val_14 == null) || (val_14.Count < 1))
            {
                goto label_17;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            List.Enumerator<T> val_7 = val_14.GetEnumerator();
            val_15 = 1152921525631264896;
            label_22:
            if(((-210891968) & 1) == 0)
            {
                goto label_18;
            }
            
            string val_9 = val_3.丐丏七丌丕丗业且上();
            val_6.Add(key:  val_9.业上丙丞丐丄丆丅七(), value:  val_9.丂丁丏一丙丛业且丌());
            goto label_22;
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_18 = null;
            val_18 = null;
            val_14 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_14, value:  val_6);
            label_17:
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  204, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丟上丐丒世东丝七东(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丞丛丆专东一丛业业, string 丒丙丌丑三专业专丛, string 丅丅下丟丑专下与一, int 且丒丛与丞世丙丕丌 = 0, int 下丝丘丁专丐丅丛丝 = 0, int 业业丁且丒丞与上专 = 0, int 且丒万丏万丒丐丐丁 = 0, int 丝丒世丏丗专专东丝 = 0, System.Collections.Generic.List<string> 丌且丝丏丘丑丐丈丈, string 丕万丐东与一丈万与)
        {
            var val_7;
            int val_8;
            object val_9;
            int val_10;
            string val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_8 = 业业丁且丒丞与上专;
            val_9 = 丒丙丌丑三专业专丛;
            val_10 = 丞丛丆专东一丛业业;
            val_11 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  9);
            val_12 = null;
            val_12 = null;
            val_8 = 1152921516595668352;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_10);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_9);
            val_11 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_11, value:  丅丅下丟丑专下与一);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕万丐东与一丈万与)) != true)
            {
                    val_13 = null;
                val_13 = null;
                val_11 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
                val_2.set_Item(key:  val_11, value:  丕万丐东与一丈万与);
            }
            
            if(val_10 == 1)
            {
                    val_14 = null;
                val_14 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  且丒丛与丞世丙丕丌);
                val_10 = 1152921504622075904;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  下丝丘丁专丐丅丛丝);
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_8);
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  且丒万丏万丒丐丐丁);
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  丝丒世丏丗专专东丝);
                val_15 = null;
                val_11 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
                val_15 = null;
                val_9 = 一业丗丆世世上丁且.<>c.<>9__26_0;
                if(val_9 == null)
            {
                    System.Func<System.String, System.Boolean> val_4 = null;
                val_9 = val_4;
                val_4 = new System.Func<System.String, System.Boolean>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 一业丗丆世世上丁且.<>c::与丏万丞丐丘丅丟丘(string 三丟东丕丄丄下下丑));
                一业丗丆世世上丁且.<>c.<>9__26_0 = val_9;
            }
            
                val_2.set_Item(key:  val_11, value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  丌且丝丏丘丑丐丈丈, predicate:  val_4)));
            }
            
            val_7 = 1152921505690550272;
            val_11.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  205, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 业上丐丕且东丝丘与(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丑丅世丐丒丏丐三丅, int 一丟与丘丑丈七不丝, int 丁丁丄三丄不与丒七, int 丐丗丘三不丄不丅丁, int 业丅丏万万丁东丅丄, string 丘丂下丛一丑丙东丛, string 丂丈丛下丄专丅与三, string 丂丛丑东不丅丈一东)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_6;
            string val_7;
            int val_8;
            int val_9;
            int val_10;
            var val_11;
            var val_12;
            var val_13;
            val_7 = 丂丈丛下丄专丅与三;
            val_8 = 丐丗丘三不丄不丅丁;
            val_9 = 一丟与丘丑丈七不丝;
            val_10 = 丑丅世丐丒丏丐三丅;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_7 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  9);
            val_11 = null;
            val_11 = null;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_10);
            val_10 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_7.set_Item(key:  val_10, value:  (丁丁丄三丄不与丒七 < 2) ? 1 : 0);
            val_12 = null;
            val_12 = null;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_8);
            val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东;
            val_7.set_Item(key:  val_8, value:  业丅丏万万丁东丅丄);
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  val_9);
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  (PGCompany.ClanStoreBuffsController.丆丛七丆万丕丘业丂() != 0) ? 1 : 0);
            val_13 = null;
            val_13 = null;
            val_9 = 丂丛丑东不丅丈一东;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丘丂下丛一丑丙东丛);
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_7);
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_9);
            val_6 = 丆丛丑世下一丐且丕;
            val_6.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  206, 丗丟上上丒丐丗丞丙:  val_7);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_7);
        }
        internal static void 丅丕东不丛与下丁业(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丟三丞三丞丁世丙丐, int 专丞丞丈丁丕丑一三, bool 丙丌不丕业丙丙丏万)
        {
            bool val_7;
            int val_8;
            var val_9;
            var val_10;
            val_7 = 丙丌不丕业丙丙丏万;
            val_8 = 丟三丞三丞丁世丙丐;
            if((val_8 | 专丞丞丈丁丕丑一三) == 0)
            {
                    return;
            }
            
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_9 = null;
            val_9 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_8);
            val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_3.set_Item(key:  val_8, value:  专丞丞丈丁丕丑一三);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_7);
            val_10 = null;
            val_10 = null;
            val_7 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东;
            val_3.set_Item(key:  val_7, value:  (PGCompany.ClanStoreBuffsController.丆丛七丆万丕丘业丂() != 0) ? 1 : 0);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  207, 丗丟上上丒丐丗丞丙:  val_3);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_3);
        }
        internal static void 丛丕丑下丘且丈一万(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, string 丐丅丒专丛丏上与业)
        {
            int val_6;
            var val_26;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_47;
            string val_48;
            object val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            object val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_63;
            val_48 = 丐丅丒专丛丏上与业;
            一业丗丆世世上丁且.世丘丛上丞丆丟丟丐 val_1 = null;
            val_49 = val_1;
            val_1 = new 一业丗丆世世上丁且.世丘丛上丞丆丟丟丐();
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_50 = 且丘丏丁丑与丙与丁.三丘丆丅丝丙一丑与();
            Rilisoft.OfferItemType val_5 = val_50.不业丙丒丂丞下丆丙();
            if(val_5 <= 1155)
            {
                goto label_8;
            }
            
            if(val_5 != 1240)
            {
                    if(val_5 != 1250)
            {
                goto label_23;
            }
            
            }
            
            if(val_50 == null)
            {
                goto label_11;
            }
            
            if(null == null)
            {
                goto label_12;
            }
            
            if(null == null)
            {
                goto label_15;
            }
            
            val_51 = 0;
            goto label_15;
            label_8:
            if(val_5 != 1150)
            {
                    if(val_5 != 1155)
            {
                goto label_23;
            }
            
            }
            
            if(val_50 == null)
            {
                goto label_18;
            }
            
            if(null == null)
            {
                goto label_19;
            }
            
            if(null == null)
            {
                goto label_22;
            }
            
            val_52 = 0;
            goto label_22;
            label_11:
            label_15:
            val_53 = val_50.丝丝丌丟丆丂丂丞业();
            label_12:
            if(val_53 == null)
            {
                goto label_23;
            }
            
            PlaceableItemSettings val_10 = val_53.丈丏专三世七丒丘丑();
            val_54 = null;
            val_54 = null;
            var val_12 = (((System.String.op_Equality(a:  val_10.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛)) & true) != 0) ? (2 + 1) : 2;
            var val_15 = (((System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  且丘丏丁丑与丙与丁).丂丁丏一丙丛业且丌()) + val_53.且丆丟业丞丕丑上且()) >= val_53.丏丈丁专专丘丒丂丂()) ? 1 : 0;
            if(且丘丏丁丑与丙与丁 != null)
            {
                goto label_79;
            }
            
            goto label_80;
            label_23:
            val_56 = 0;
            val_55 = 0;
            if(且丘丏丁丑与丙与丁 != null)
            {
                goto label_79;
            }
            
            label_80:
            label_79:
            val_57 = 且丘丏丁丑与丙与丁.七丈丒丒下下且万与();
            if(val_57 != null)
            {
                    val_57 = 0;
            }
            
            PGCompany.三丛丗丆七丁丆上丌.丏七三丄丙不丗且丐(万丏丗丗丅丄丌业一:  val_57.七万丅丆且丁世丏丈(), 世七七丟丑丁丂与丞: out  (一业丗丆世世上丁且.世丘丛上丞丆丟丟丐)[1152921560231587200].世七七丟丑丁丂与丞, 三丐丘万上下上丛七: out  (一业丗丆世世上丁且.世丘丛上丞丆丟丟丐)[1152921560231587200].三丐丘万上下上丛七);
            if((PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世().与丕丞丑丅丌上且丝(丐丅丒专丛丏上与业:  2)) != null)
            {
                    丝丕专世丙丆丛丝丝 val_25 = val_23.SlotsSettings.Find(match:  new System.Predicate<丝丕专世丙丆丛丝丝>(object:  val_1, method:  System.Boolean 一业丗丆世世上丁且.世丘丛上丞丆丟丟丐::丑丂丘丗丛世丟专且(PGCompany.下七业丄丐世丘丘不.丝丕专世丙丆丛丝丝 丏丛与丅丛丌万专丌)));
            }
            
            val_49 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  7);
            val_58 = null;
            val_58 = null;
            val_49.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  且丘丏丁丑与丙与丁.丂丁丏一丙丛业且丌());
            val_49.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_55);
            val_49.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  且丘丏丁丑与丙与丁.丆丞上丛丂一业丟丕());
            val_49.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  false));
            val_49.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  且丘丏丁丑与丙与丁.业上丙丞丐丄丆丅七());
            val_49.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_48);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_49.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_26.ToString());
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_33 = null;
            val_48 = val_33;
            val_33 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            List.Enumerator<T> val_34 = 且丘丏丁丑与丙与丁.GetEnumerator();
            label_76:
            if(((-209891040) & 1) == 0)
            {
                goto label_65;
            }
            
            string val_36 = val_6.丐丏七丌丕丗业且上();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_37 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_59 = null;
            val_59 = null;
            null.Add(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.专丕与丒丗丁丘专丟, value:  val_36.业上丙丞丐丄丆丅七());
            val_6 = val_36.丂丁丏一丙丛业且丌();
            null.Add(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒专下与丑丁丆丟业, value:  val_6);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            null.Add(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒三丝一上丙专丗丒, value:  val_36.不业丙丒丂丞下丆丙().ToString());
            val_33.Add(item:  null);
            goto label_76;
            label_18:
            label_22:
            val_60 = val_50.丑且一丐东三不丈丝();
            label_19:
            if(val_60 != null)
            {
                    var val_45 = (val_60.且丆丟业丞丕丑上且() >= val_60.丏丈丁专专丘丒丂丂()) ? 1 : 0;
            }
            
            if(且丘丏丁丑与丙与丁 != null)
            {
                goto label_79;
            }
            
            goto label_80;
            label_65:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_61 = 1152921516595668352;
            val_63 = null;
            val_63 = null;
            val_47 = 丆丛丑世下一丐且丕;
            val_49.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_33);
            val_47.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  208, 丗丟上上丒丐丗丞丙:  val_49);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_49);
        }
        internal static void 三与丆丏下丐不丆丄(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丅丘丌且丈丘丄丗丄, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞, string 丐丅丒专丛丏上与业)
        {
            int val_10;
            object val_18;
            var val_19;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_20;
            var val_21;
            var val_22;
            var val_23;
            val_18 = 丐丅丒专丛丏上与业;
            val_19 = 丒世丘丘上丆丝东丞;
            val_20 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            if(val_19 != null)
            {
                    if((System.String.op_Equality(a:  val_19.业上丙丞丐丄丆丅七(), b:  "Real")) == true)
            {
                    return;
            }
            
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  7);
            val_21 = null;
            val_21 = null;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_19.丂丁丏一丙丛业且丌());
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_19.业上丙丞丐丄丆丅七());
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_18);
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_7 = null;
            val_18 = val_7;
            val_7 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            List.Enumerator<T> val_8 = 丅丘丌且丈丘丄丗丄.GetEnumerator();
            label_27:
            if(((-209561984) & 1) == 0)
            {
                goto label_16;
            }
            
            string val_11 = val_10.丐丏七丌丕丗业且上();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_22 = null;
            val_22 = null;
            null.Add(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.专丕与丒丗丁丘专丟, value:  val_11.业上丙丞丐丄丆丅七());
            val_10 = val_11.丂丁丏一丙丛业且丌();
            null.Add(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒专下与丑丁丆丟业, value:  val_10);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            null.Add(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒三丝一上丙专丗丒, value:  val_11.不业丙丒丂丞下丆丙().ToString());
            val_7.Add(item:  null);
            goto label_27;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_19 = 1152921516595668352;
            val_23 = null;
            val_23 = null;
            val_20 = val_20;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_7);
            val_20.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  208, 丗丟上上丒丐丗丞丙:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_4);
        }
        internal static void 下上一万丟专丒七丈(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丐世丌丛世且下丗一, string 丐丅丒专丛丏上与业, System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 丐三丏专七一丁且丕, System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 丞上丝丆丕丝丙上丛)
        {
            var val_28;
            string val_29;
            object val_30;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_31;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_32;
            var val_33;
            var val_34;
            System.Collections.Generic.List<T> val_35;
            int val_36;
            var val_37;
            var val_39;
            var val_40;
            var val_41;
            var val_43;
            var val_46;
            val_29 = 丐三丏专七一丁且丕;
            val_30 = 丐丅丒专丛丏上与业;
            val_31 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_32 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_33 = null;
            val_33 = null;
            val_34 = 1152921516595668352;
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丐世丌丛世且下丗一);
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_30);
            val_30 = 1152921554011105904;
            if(val_29.Count < 1)
            {
                goto label_11;
            }
            
            System.Collections.Generic.List<System.Object> val_4 = null;
            val_35 = val_4;
            val_4 = new System.Collections.Generic.List<System.Object>();
            List.Enumerator<T> val_5 = val_29.GetEnumerator();
            val_36 = 0;
            val_37 = 0;
            label_40:
            if(((-209294336) & 1) == 0)
            {
                goto label_13;
            }
            
            string val_7 = 丐世丌丛世且下丗一.丐丏七丌丕丗业且上();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丛丟东世万丒丐且世, value:  val_7.业上丙丞丐丄丆丅七());
            int val_10 = val_7.丂丁丏一丙丛业且丌();
            null.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒丆丕丁丟业上七丅, value:  val_10);
            System.Collections.Generic.List<System.String> val_11 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_12 = val_7.GetEnumerator();
            label_25:
            if(((-209294368) & 1) == 0)
            {
                goto label_22;
            }
            
            null.Add(item:  丐世丌丛世且下丗一.丐丏七丌丕丗业且上().业上丙丞丐丄丆丅七());
            goto label_25;
            label_22:
            var val_27 = 0;
            val_27 = val_27 + 1;
            mem2[0] = 210;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_29 = val_27;
            if((val_29 != 1) && ((-209294480 + ((0 + 1)) << 2) == 210))
            {
                    var val_28 = 0;
                val_28 = val_28 ^ (val_29 >> 31);
                val_29 = val_29 + val_28;
            }
            else
            {
                    if( != 0)
            {
                
            }
            
            }
            
            val_39 = null;
            val_39 = null;
            null.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒上一丁丆丛东专丙, value:  null);
            val_4.Add(item:  null);
            goto label_40;
            label_11:
            val_40 = 0;
            val_28 = 0;
            if(丞上丝丆丕丝丙上丛 != null)
            {
                goto label_69;
            }
            
            goto label_42;
            label_13:
            val_28 = val_29 + 1;
            mem2[0] = 260;
            val_31 = val_31;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(( != 1) && ((-209294480 + (((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31))) << 2) == 260))
            {
                    var val_30 = 0;
                val_30 = val_30 ^ ( >> 31);
                val_28 =  + val_30;
            }
            else
            {
                    if( != 0)
            {
                    val_40 = 0;
            }
            
            }
            
            val_41 = null;
            val_41 = null;
            val_32.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_4);
            val_30 = 1152921554011105904;
            if(丞上丝丆丕丝丙上丛 != null)
            {
                goto label_69;
            }
            
            label_42:
            label_69:
            if(丞上丝丆丕丝丙上丛.Count < 1)
            {
                goto label_70;
            }
            
            System.Collections.Generic.List<System.Object> val_16 = new System.Collections.Generic.List<System.Object>();
            List.Enumerator<T> val_17 = 丞上丝丆丕丝丙上丛.GetEnumerator();
            label_98:
            if(((-209294336) & 1) == 0)
            {
                goto label_72;
            }
            
            string val_19 = val_10.丐丏七丌丕丗业且上();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_20 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丛丟东世万丒丐且世, value:  val_19.业上丙丞丐丄丆丅七());
            null.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒丆丕丁丟业上七丅, value:  val_19.丂丁丏一丙丛业且丌());
            System.Collections.Generic.List<System.String> val_23 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_24 = val_19.GetEnumerator();
            label_84:
            if(((-209294368) & 1) == 0)
            {
                goto label_81;
            }
            
            null.Add(item:  val_10.丐丏七丌丕丗业且上().业上丙丞丐丄丆丅七());
            goto label_84;
            label_81:
             =  + 1;
            mem2[0] = 445;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && ((-209294480 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) == 445))
            {
                    var val_31 = 0;
                val_31 = val_31 ^ ( >> 31);
                 =  + val_31;
            }
            
            val_43 = null;
            val_43 = null;
            null.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒上一丁丆丛东专丙, value:  null);
            val_16.Add(item:  null);
            goto label_98;
            label_72:
            val_28 =  + 1;
            mem2[0] = 496;
            val_31 = val_31;
            val_30 = 1152921516595668352;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if( == 1)
            {
                goto label_118;
            }
            
            if(( == 0) || ((-209294480 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) == 496))
            {
                goto label_128;
            }
            
            label_127:
            label_128:
            val_46 = null;
            val_46 = null;
            val_29 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅;
            val_32.set_Item(key:  val_29, value:  val_16);
            label_70:
            丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  209, 丗丟上上丒丐丗丞丙:  val_32);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_32);
            return;
            label_118:
            if( != 0)
            {
                goto label_127;
            }
            
            goto label_128;
        }
        internal static void 丏丟丏丂丆上不丆三(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 东且丁丆丛丁丏丘且, bool 业丞七丂一丐丝丈七, int 业丅丏万万丁东丅丄, string 丂丝丐丅业丝丞丞丛, string 丅丅下丟丑专下与一)
        {
            object val_6;
            int val_7;
            int val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = 丂丝丐丅业丝丞丞丛;
            val_7 = 业丅丏万万丁东丅丄;
            val_8 = 东且丁丆丛丁丏丘且;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  6);
            val_9 = null;
            val_9 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_8);
            val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_8, value:  业丞七丂一丐丝丈七);
            val_10 = null;
            val_10 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_7);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  (PGCompany.ClanStoreBuffsController.丆丛七丆万丕丘业丂() != 0) ? 1 : 0);
            val_11 = null;
            val_11 = null;
            val_7 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_7, value:  val_6);
            val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_6, value:  丅丅下丟丑专下与一);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  210, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丝上世丌丆下丘丒丟(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丄专丆丈业一丂丅丞, int 丞东与丅丁业与七东, int 且东丝丏下万丒丘下, string 丂丝丐丅业丝丞丞丛, string 下七上与丝与丞丘一, string 丅丅下丟丑专下与一)
        {
            string val_5;
            object val_6;
            int val_7;
            var val_8;
            var val_9;
            val_5 = 丅丅下丟丑专下与一;
            val_6 = 丂丝丐丅业丝丞丞丛;
            val_7 = 丞东与丅丁业与七东;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  7);
            val_8 = null;
            val_8 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丄专丆丈业一丂丅丞);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_7);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  且东丝丏下万丒丘下);
            object val_4 = (PGCompany.ClanStoreBuffsController.丆丛七丆万丕丘业丂() != 0) ? 1 : 0;
            val_7 = val_4;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_4);
            val_9 = null;
            val_9 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_6);
            val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_6, value:  下七上与丝与丞丘一);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
            val_2.set_Item(key:  val_5, value:  val_5);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  211, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丂丈一丂丗丆丆丏丘(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, long 东东不丗丆下专丒丁, string 丌丂丛万丂专丙不丘)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_39;
            object val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            val_40 = 丌丂丛万丂专丙不丘;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  7);
            val_41 = null;
            val_41 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  ExperienceController.万丏丙丈东东万丝丞());
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅());
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且());
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌());
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_40);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  PGCompany.Analytics.一业丗丆世世上丁且.丂丑与丅丙一东丕丞());
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅, value:  PGCompany.Analytics.一业丗丆世世上丁且.丌业丒丁上丟专丗丞());
            丞丂丘丒丟丞丑下丄 val_14 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  0);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  0);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  "");
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  "");
            val_42 = null;
            val_42 = null;
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  79);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}));
            if(val_14 != null)
            {
                    int val_18 = 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与();
                val_18 = val_18 + 1;
                val_43 = null;
                val_43 = null;
                val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  (丌丅且丗七丘丅丛丑.丒不丐丁丕丝丟与丗(专世专丟丝丌与丘上:  val_18)) - 丌丅且丗七丘丅丛丑.丛丏丒业丂丅丂丕丐());
                val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  丌丅且丗七丘丅丛丑.丌丙且丏业丑上丟丕(专世专丟丝丌与丘上:  丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与()));
                string val_24 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_24)) != true)
            {
                    val_44 = null;
                val_44 = null;
                val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_14.三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  val_24));
            }
            
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_27 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            decimal val_30 = Rilisoft.Singleton<KillrateController>.Instance.万上丗丂丅丕丙且丆().CalculateKillRate;
            null.Add(key:  "total", value:  val_30);
            decimal val_33 = Rilisoft.Singleton<KillrateController>.Instance.世丏丒世不丏上丐丑().CalculateKillRate;
            null.Add(key:  "br", value:  val_33);
            val_2.Add(key:  "Killrates", value:  null);
            if((Rilisoft.Singleton<ClansController>.Instance.七丏丌丏丗万东上丝(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    val_2.Add(key:  "clan_stats", value:  PGCompany.Analytics.一业丗丆世世上丁且.丟丞丆丂与万丂丑下(且丟丅丄丒丑丂丁世:  val_14));
            }
            
            val_45 = null;
            val_45 = null;
            val_40 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丂丄不世丁丞丛丁一;
            val_3.set_Item(key:  val_40, value:  val_2);
            if(东东不丗丆下专丒丁 >= 1)
            {
                    val_46 = null;
                val_46 = null;
                val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业万一丏丌上三丑丟, value:  东东不丗丆下专丒丁);
            }
            
            val_39 = 丆丛丑世下一丐且丕;
            val_39.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  3, 丗丟上上丒丐丗丞丙:  val_3);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_3);
        }
        internal static void 丅七丏丕三不丗丛不(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丄丙丑丕不业丂丒丂)
        {
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            if(丄丙丑丕不业丂丒丂 == null)
            {
                goto label_6;
            }
            
            label_11:
            val_2.set_Item(key:  "screen", value:  丄丙丑丕不业丂丒丂);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_6:
            if(val_2 != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        internal static void 三丙专业丌丏丛丌与(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕)
        {
            bool val_1 = PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑();
        }
        internal static void 丙丑丟丆丑世丁专丅(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丅丈丌丟世丗丗丟, string 丐丅丒专丛丏上与业, string 世丁丙世丄一万丆三 = "")
        {
            PGCompany.Analytics.一业丗丆世世上丁且.下丝丆丟丕下丅上三(丆丛丑世下一丐且丕:  丆丛丑世下一丐且丕, 丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丅丑三下丕万丙丁丘:  世丁丙世丄一万丆三, 丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业, 丐丆丝业丙丈下世丁:  0, 丐丕丟与且丒丕丂丏:  0);
        }
        internal static void 丏世丄丞丂上丗三丑(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丐丅丒专丛丏上与业, string 世丁丙世丄一万丆三)
        {
            PGCompany.Analytics.一业丗丆世世上丁且.下丝丆丟丕下丅上三(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  1, 丅丑三下丕万丙丁丘:  世丁丙世丄一万丆三, 丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业, 丐丆丝业丙丈下世丁:  0, 丐丕丟与且丒丕丂丏:  0);
        }
        internal static void 丛且万丙丒专丑上丅(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.MainStore.世专丟丕丝丝专东一 丈丑丕丑上丙丝业丌, System.Collections.Generic.List<PGCompany.MainStore.世专丟丕丝丝专东一> 东丒丙不丏不且丗丐)
        {
            PGCompany.Analytics.一业丗丆世世上丁且.下丝丆丟丕下丅上三(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  2, 丅丑三下丕万丙丁丘:  "", 丐丅丒专丛丏上与业:  丈丑丕丑上丙丝业丌.丙业丆丘万丙专万丟(), 丐丆丝业丙丈下世丁:  0, 丐丕丟与且丒丕丂丏:  东丒丙不丏不且丗丐);
        }
        internal static void 专东丆丞丁专丙丑业(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丐丅丒专丛丏上与业, PGCompany.MainStore.下丐丒丙丂丁丗丘丘 且丘丏丁丑与丙与丁)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_8;
            string val_9;
            var val_10;
            if(且丘丏丁丑与丙与丁 == null)
            {
                goto label_10;
            }
            
            if(且丘丏丁丑与丙与丁.丒丒与丑丏世且丂业().业东丅东丌上丗丑不() != 17015)
            {
                goto label_3;
            }
            
            val_8 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            val_9 = "";
            val_10 = 4;
            goto label_15;
            label_3:
            if(且丘丏丁丑与丙与丁.丒丒与丑丏世且丂业().业东丅东丌上丗丑不() != 11015)
            {
                goto label_10;
            }
            
            val_8 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            val_9 = "";
            val_10 = 5;
            goto label_15;
            label_10:
            val_8 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            val_9 = "";
            val_10 = 3;
            label_15:
            PGCompany.Analytics.一业丗丆世世上丁且.下丝丆丟丕下丅上三(丆丛丑世下一丐且丕:  val_8, 丁丅丈丌丟世丗丗丟:  3, 丅丑三下丕万丙丁丘:  val_9, 丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业, 丐丆丝业丙丈下世丁:  且丘丏丁丑与丙与丁, 丐丕丟与且丒丕丂丏:  0);
        }
        internal static void 下丝丆丟丕下丅上三(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丅丈丌丟世丗丗丟, string 丅丑三下丕万丙丁丘, string 丐丅丒专丛丏上与业, PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.MainStore.世专丟丕丝丝专东一> 丐丕丟与且丒丕丂丏)
        {
            int val_31;
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_45;
            string val_46;
            int val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_52;
            var val_53;
            var val_54;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            Rilisoft.PlayerPaymentType val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            string val_66;
            var val_67;
            var val_68;
            val_46 = 丅丑三下丕万丙丁丘;
            val_47 = 丁丅丈丌丟世丗丗丟;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  13);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_47);
            if((System.String.IsNullOrEmpty(value:  丐丅丒专丛丏上与业)) != true)
            {
                    val_48 = null;
                val_49 = 1152921516595668352;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丐丅丒专丛丏上与业);
            }
            
            val_50 = null;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  MainStoreButton.丐七东丒世丞丅万丟())) != false)
            {
                    val_51 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  0);
                val_52 = 丆丛丑世下一丐且丕;
            }
            else
            {
                    val_53 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  1);
                val_52 = 丆丛丑世下一丐且丕;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  MainStoreButton.丐七东丒世丞丅万丟());
            }
            
            val_54 = null;
            val_54 = null;
            System.DateTime val_8 = System.DateTime.Now;
            val_55 = val_2;
            Rilisoft.PlayerPaymentType val_10 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().一与不丙丝万丐丂七(丏丄专业丞世丏丙丈:  丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_8.dateData}));
            val_47 = 1152921516595668352;
            val_55.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_10);
            val_56 = 1152921505690550272;
            if((System.String.IsNullOrEmpty(value:  val_46)) != true)
            {
                    val_57 = null;
                val_57 = null;
                val_55.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑, value:  val_46);
            }
            
            if((丐丕丟与且丒丕丂丏 != null) && (丐丕丟与且丒丕丂丏.Count != 0))
            {
                    System.Collections.Generic.List<System.String> val_13 = PGCompany.Analytics.一业丗丆世世上丁且.不丌一不且丕下丏丛(丛丝业万丌丏世与丑:  丐丕丟与且丒丕丂丏);
                if(val_13 != null)
            {
                    if(val_13.Count != 0)
            {
                    val_58 = null;
                val_58 = null;
                val_55.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_13);
            }
            
            }
            
            }
            
            val_45 = 丐丆丝业丙丈下世丁;
            if(val_45 == 0)
            {
                goto label_48;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_15 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_59 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            val_15.set_Item(key:  "name", value:  val_45);
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_16 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            List.Enumerator<T> val_17 = val_45.GetEnumerator();
            val_61 = 0;
            val_62 = 0;
            val_63 = 0;
            goto label_75;
            label_78:
            string val_19 = val_10.丐丏七丌丕丗业且上();
            List.Enumerator<T> val_20 = val_16.GetEnumerator();
            val_64 = 0;
            label_60:
            if(((-207321024) & 1) == 0)
            {
                goto label_53;
            }
            
            string val_21 = val_10.丐丏七丌丕丗业且上();
            if(val_19.业东丅东丌上丗丑不() != val_21.业东丅东丌上丗丑不())
            {
                goto label_60;
            }
            
            val_21.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_19.丂丁丏一丙丛业且丌() + val_21.丂丁丏一丙丛业且丌());
            goto label_60;
            label_53:
            val_63 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_63 == 1) || (367 != 367))
            {
                goto label_69;
            }
            
            var val_44 = 0;
            val_44 = val_44 ^ 0;
            val_63 = val_63 + val_44;
            if(( & 1) != 0)
            {
                goto label_75;
            }
            
            label_77:
            val_16.Add(item:  val_19.与下不与丐丈丁丈万());
            goto label_75;
            label_69:
            if( == 0)
            {
                goto label_74;
            }
            
            val_61 = 0;
            val_62 = 0;
            if(( & 1) != 0)
            {
                goto label_75;
            }
            
            goto label_77;
            label_74:
            val_61 = 0;
            if(( & 1) == 0)
            {
                goto label_77;
            }
            
            label_75:
            if(((-207320992) & 1) != 0)
            {
                goto label_78;
            }
            
            val_65 = val_63 + 1;
            mem2[0] = 409;
            val_56 = 1152921505690550272;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_63 != 1) && (367 == 409))
            {
                    var val_45 = 0;
                val_45 = val_45 ^ 0;
                val_65 = val_63 + val_45;
            }
            else
            {
                    if( != 0)
            {
                    val_62 = 0;
            }
            
            }
            
            System.Collections.Generic.List<System.String> val_28 = null;
            val_47 = val_28;
            val_28 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_29 = val_16.GetEnumerator();
            label_96:
            if(((-207320992) & 1) == 0)
            {
                goto label_91;
            }
            
            string val_33 = PGCompany.Analytics.一业丗丆世世上丁且.业业丙三一丙世丌丞(丈丄不七三万丄丁不:  val_31.丐丏七丌丕丗业且上());
            if((System.String.IsNullOrEmpty(value:  val_33)) == true)
            {
                goto label_96;
            }
            
            val_28.Add(item:  val_33);
            goto label_96;
            label_91:
            val_63 = val_63 + 1;
            mem2[0] = 483;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_63 == 1)
            {
                goto label_102;
            }
            
            if(( == 0) || ((-207321136 + ((val_63 + 1)) << 2) == 483))
            {
                goto label_129;
            }
            
            label_128:
            label_129:
            val_66 = public System.Int32 System.Collections.Generic.List<System.String>::get_Count();
            if(val_28.Count >= 1)
            {
                    val_66 = "content";
                val_59 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
                val_15.set_Item(key:  val_66, value:  val_28);
            }
            
            string val_36 = PGCompany.Analytics.一业丗丆世世上丁且.业业丙三一丙世丌丞(丈丄不七三万丄丁不:  丐丆丝业丙丈下世丁);
            if((System.String.IsNullOrEmpty(value:  val_36)) != true)
            {
                    val_59 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
                val_15.set_Item(key:  "price", value:  val_36);
            }
            
            decimal val_38 = 丐丆丝业丙丈下世丁.万丏丛上丌丏业三不();
            val_46 = val_38.flags;
            val_67 = null;
            val_67 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_46, hi = val_38.hi, lo = val_38.lo, mid = val_38.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
            {
                    decimal val_40 = 丐丆丝业丙丈下世丁.万丏丛上丌丏业三不();
                val_31 = val_40.flags;
                val_46 = val_40;
                val_15.set_Item(key:  "profit", value:  val_40);
            }
            
            System.Collections.Generic.List<System.String> val_42 = PGCompany.Analytics.一业丗丆世世上丁且.不丌一不且丕下丏丛(丏万且丈丙丁丁且世:  丐丆丝业丙丈下世丁.与不丞丑七丘丁丂丛());
            if(val_42 != null)
            {
                    if(val_42.Count >= 1)
            {
                    val_15.set_Item(key:  "tags", value:  val_42);
            }
            
            }
            
            val_68 = null;
            val_52 = val_52;
            val_55 = val_2;
            val_45 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅;
            set_Item(key:  val_45, value:  val_15);
            label_48:
            丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  235, 丗丟上上丒丐丗丞丙:  null);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  null);
            return;
            label_102:
            if( != 0)
            {
                goto label_128;
            }
            
            goto label_129;
        }
        private static string 业业丙三一丙世丌丞(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            object val_6;
            var val_7;
            if(丈丄不七三万丄丁不 != null)
            {
                    Rilisoft.OfferItemType val_1 = 丈丄不七三万丄丁不.不业丙丒丂丞下丆丙();
                val_6 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
                int val_3 = 丈丄不七三万丄丁不.丂丁丏一丙丛业且丌();
                if(val_3 <= 1)
            {
                    return (string)System.String.Format(format:  "{0}:{1}", arg0:  val_1, arg1:  val_6);
            }
            
                string val_4 = System.String.Format(format:  "{0}:{1}:{2}", arg0:  val_1, arg1:  val_6, arg2:  val_3);
                return (string)System.String.Format(format:  "{0}:{1}", arg0:  val_1, arg1:  val_6);
            }
            
            val_7 = "";
            return (string)System.String.Format(format:  "{0}:{1}", arg0:  val_1, arg1:  val_6);
        }
        private static System.Collections.Generic.Dictionary<string, int> 丏丁一丒下丝丄丛丄(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
        {
            var val_7;
            if((丈丄不七三万丄丁不 == null) || (丈丄不七三万丄丁不.Count == 0))
            {
                goto label_2;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = null;
            val_7 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            List.Enumerator<T> val_3 = 丈丄不七三万丄丁不.GetEnumerator();
            label_7:
            if(((-206903416) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            val_2.set_Item(key:  val_4.业上丙丞丐丄丆丅七(), value:  val_4.丂丁丏一丙丛业且丌());
            goto label_7;
            label_2:
            val_7 = 0;
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)val_7;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)val_7;
        }
        private static System.Collections.Generic.List<string> 不丌一不且丕下丏丛(TagSystem.三与下丘七丘丌丏丄 丏万且丈丙丁丁且世)
        {
            var val_7;
            if(丏万且丈丙丁丁且世 != null)
            {
                    val_7 = 0;
                if(丏万且丈丙丁丁且世.不丈丅万不下丙丄丅() == false)
            {
                    return (System.Collections.Generic.List<System.String>)val_7;
            }
            
                System.Collections.Generic.List<System.String> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Collections.Generic.List<System.String>();
                if((丏万且丈丙丁丁且世.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "new")) != false)
            {
                    val_2.Add(item:  "new");
            }
            
                if((丏万且丈丙丁丁且世.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "X3")) != false)
            {
                    val_2.Add(item:  "X3");
            }
            
                if((丏万且丈丙丁丁且世.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "X10")) != false)
            {
                    val_2.Add(item:  "X10");
            }
            
                if((丏万且丈丙丁丁且世.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "best-buy")) == false)
            {
                    return (System.Collections.Generic.List<System.String>)val_7;
            }
            
                val_2.Add(item:  "best-buy");
                return (System.Collections.Generic.List<System.String>)val_7;
            }
            
            val_7 = 0;
            return (System.Collections.Generic.List<System.String>)val_7;
        }
        private static System.Collections.Generic.List<string> 不丌一不且丕下丏丛(System.Collections.Generic.List<PGCompany.MainStore.世专丟丕丝丝专东一> 丛丝业万丌丏世与丑)
        {
            var val_5;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if((丛丝业万丌丏世与丑 == null) || (丛丝业万丌丏世与丑.Count == 0))
            {
                goto label_2;
            }
            
            System.Collections.Generic.List<System.String> val_2 = null;
            val_13 = val_2;
            val_2 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_3 = 丛丝业万丌丏世与丑.GetEnumerator();
            val_14 = 0;
            val_15 = 0;
            var val_12 = 0;
            label_21:
            if(((-206622016) & 1) == 0)
            {
                goto label_3;
            }
            
            List.Enumerator<T> val_9 = PGCompany.Analytics.一业丗丆世世上丁且.不丌一不且丕下丏丛(丏万且丈丙丁丁且世:  val_5.丐丏七丌丕丗业且上().与不丞丑七丘丁丂丛()).GetEnumerator();
            label_12:
            if(((-206622048) & 1) == 0)
            {
                goto label_8;
            }
            
            string val_10 = val_5.丐丏七丌丕丗业且上();
            if((val_2.Contains(item:  val_10)) == true)
            {
                goto label_12;
            }
            
            val_2.Add(item:  val_10);
            goto label_12;
            label_8:
            val_12 = val_12 + 1;
            mem2[0] = 102;
            val_16 = val_15;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_12 == 1) || ((1152921560234799728 + ((0 + 1)) << 2) != 102))
            {
                goto label_18;
            }
            
            var val_13 = 0;
            val_13 = val_13 ^ (val_12 >> 31);
            val_12 = val_12 + val_13;
            goto label_21;
            label_18:
            if( == 0)
            {
                goto label_21;
            }
            
            goto label_21;
            label_2:
            val_13 = 0;
            return (System.Collections.Generic.List<System.String>)val_13;
            label_3:
            val_12 = val_12 + 1;
            mem2[0] = 127;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_12 != 1)
            {
                    if( == 0)
            {
                    return (System.Collections.Generic.List<System.String>)val_13;
            }
            
                if((1152921560234799728 + ((0 + 1)) << 2) == 127)
            {
                    return (System.Collections.Generic.List<System.String>)val_13;
            }
            
                return (System.Collections.Generic.List<System.String>)val_13;
            }
            
            if( != 0)
            {
                    return (System.Collections.Generic.List<System.String>)val_13;
            }
            
            return (System.Collections.Generic.List<System.String>)val_13;
        }
        internal static void 丑下丗专丐丑丅专丑(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            val_4 = null;
            if((PGCompany.Analytics.一业丗丆世世上丁且.丆与丛丅丂三万一丑.ContainsKey(key:  下上丐丆丝丟丝丒不)) != false)
            {
                    val_5 = null;
                PGCompany.Analytics.一业丗丆世世上丁且.丆与丛丅丂三万一丑.set_Item(key:  下上丐丆丝丟丝丒不, value:  丙业与丙丗丝不丈东);
                return;
            }
            
            val_6 = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丆与丛丅丂三万一丑.Add(key:  下上丐丆丝丟丝丒不, value:  丙业与丙丗丝不丈东);
        }
        internal static void 且丙且丛丅业丐丝一(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_3 = null;
            val_3 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  PGCompany.Analytics.一业丗丆世世上丁且.丆与丛丅丂三万一丑);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  233, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丆与丛丅丂三万一丑.Clear();
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 下万丌丐世丘下丑且(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丘专丈与三专丈丈专, string 万丂且丕三丛一专与, float 万世丛丄丘丙丂万丟, string 专丄丒丘丅七丂丟丙, bool 万丅丏丈七丂丛一上, InappRememberedBonus 丂丈丗丄不丅丅丙丒, string 专丝东丕丝丈三丗丂, int 丂业丛丕专丏丁丆东, string 业丘丛专丗丛万专业)
        {
            object val_38;
            object val_39;
            object val_40;
            System.Object[] val_41;
            string val_42;
            var val_43;
            string val_44;
            string val_45;
            string val_46;
            var val_47;
            var val_48;
            int val_49;
            var val_50;
            var val_51;
            int val_52;
            var val_53;
            var val_54;
            var val_57;
            var val_58;
            string val_59;
            var val_61;
            decimal val_62;
            var val_63;
            var val_64;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_65;
            val_38 = 专丝东丕丝丈三丗丂;
            val_39 = 丂丈丗丄不丅丅丙丒;
            val_40 = 万丂且丕三丛一专与;
            object[] val_1 = new object[9];
            val_41 = val_1;
            val_41[0] = 丘专丈与三专丈丈专;
            val_41[1] = val_40;
            val_41[2] = 万世丛丄丘丙丂万丟;
            val_41[3] = 专丄丒丘丅七丂丟丙;
            val_41[4] = 万丅丏丈七丂丛一上;
            val_41[5] = val_39;
            val_41[6] = val_38;
            val_42 = 业丘丛专丗丛万专业;
            val_41[7] = 丂业丛丕专丏丁丆东;
            val_41[8] = val_42;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "[TEST] EnqueuePurchase() inappId:\'{0}\' fullpurchaseId:\'{1}\' parsedPrice:\'{2}\' currencyCode:\'{3}\' isFirst:\'{4}\' bonus:\'{5}\' currtype:\'{6}\' currCount:\'{7}\' transactionId:\'{8}\'", args:  val_1));
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            int val_6 = StoreKitEventListener.丁且丘丅丌丛下一丆(丘专丈与三专丈丈专:  丘专丈与三专丈丈专);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_6);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  万丅丏丈七丂丛一上);
            val_43 = null;
            val_44 = 丘专丈与三专丈丈专;
            val_45 = val_38;
            val_41 = 专丄丒丘丅七丂丟丙;
            val_46 = val_40;
            if(val_46 == 0)
            {
                    val_46 = System.String.alignConst;
            }
            
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_46);
            val_47 = null;
            val_47 = null;
            if( == null)
            {
                    val_41 = System.String.alignConst;
            }
            
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_41);
            val_48 = null;
            val_48 = null;
            if(val_42 == null)
            {
                    val_49 = System.String.alignConst;
            }
            
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_49);
            Rilisoft.丗下丙丅且丐丞丙世 val_8 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
            if(val_8.丘与丈世不丕丕丅丑 == null)
            {
                goto label_61;
            }
            
            val_50 = null;
            val_50 = null;
            if((val_8.丘与丈世不丕丕丅丑.东一丌丙丕丐丞上且(丌世丛业丛一丘丈丝:  PGCompany.丐三丛丒三一三三丆.丕丙上丟与丒丄丕三)) == null)
            {
                goto label_61;
            }
            
            val_51 = 0;
            goto label_62;
            label_61:
            val_51 = 0;
            label_62:
            if(((-206072360) & 1) != 0)
            {
                    val_52 = val_51.丙东专丂世丈丏丁丂();
            }
            else
            {
                    System.TimeSpan val_11 = System.TimeSpan.FromDays(value:  30);
                val_52 = (int)val_11._ticks.TotalSeconds;
            }
            
            val_53 = null;
            val_53 = null;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑, value:  PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().一与不丙丝万丐丂七(丏丄专业丞世丏丙丈:  val_52).ToString());
            System.Collections.Generic.List<Rilisoft.OfferItem> val_16 = InappRememberedBonus.丆丅东世专一丞丏且(丂丈丗丄不丅丅丙丒:  val_39);
            val_54 = 1152921504689381376;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_17 = null;
            val_40 = 1152921516595667312;
            val_39 = val_17;
            val_17 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_16.Count < 1)
            {
                goto label_113;
            }
            
            List.Enumerator<T> val_19 = val_16.GetEnumerator();
            val_41 = 1152921516630043280;
            label_93:
            if(((-206072400) & 1) == 0)
            {
                goto label_78;
            }
            
            string val_21 = 0.丐丏七丌丕丗业且上();
            if((val_17.ContainsKey(key:  val_21.Id)) == false)
            {
                goto label_81;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_17.Item[val_21.Id]);
            val_17.set_Item(key:  val_21.Id, value:  val_21.Count + 1152921504628731904);
            goto label_93;
            label_81:
            val_17.Add(key:  val_21.Id, value:  val_21.Count);
            goto label_93;
            label_78:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_54 = 1152921504689381376;
            val_40 = 1152921516595667312;
            goto label_116;
            label_113:
            if((StoreKitEventListener.丞丈丞不不丕丗丗业(丘专丈与三专丈丈专:  null)) != true)
            {
                    val_17.Add(key:  null, value:  丂业丛丕专丏丁丆东);
            }
            
            label_116:
            val_57 = null;
            val_57 = null;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_17);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_32 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Rilisoft.与丗丌丑专业丝丛丏 val_33 = Rilisoft.Offers.丁且丕专万丈丒丏丗.万世万丝下专丆丏世(世丈三丐丞一丒丛不:  val_6, 丞丂业丅丟丙丏七丗:  31);
            val_59 = "domestic_total";
            if(val_33 == null)
            {
                goto label_124;
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            goto label_128;
            label_124:
            val_61 = null;
            val_61 = null;
            val_58 = val_32;
            val_62 = System.Decimal.Zero;
            goto label_131;
            label_128:
            val_63 = public System.Decimal Rilisoft.与丗丌丑专业丝丛丏::丈业且丆七三丛丙丙();
            decimal val_37 = val_33.丈业且丆七三丛丙丙();
            val_62 = val_37.flags;
            val_59 = (val_33 == 0) ? 0 : (val_59);
            val_61 = null;
            label_131:
            (val_33 == 0) ? 0 : (val_32).set_Item(key:  val_59, value:  val_37);
            val_64 = null;
            val_64 = null;
            val_38 = val_5;
            val_38.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅, value:  val_32);
            val_65 = 丆丛丑世下一丐且丕;
            val_65.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  51, 丗丟上上丒丐丗丞丙:  val_38);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_5);
        }
        internal static void 丛丛丈世丅丘丙丆丄(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丁丅丈丌丟世丗丗丟, string 丟丛丑丒丆丛东下丌, System.Collections.Generic.Dictionary<string, object> 丗七丟丈三不丕一三, int 丝丟专丒丅丁丝丘丅 = 0)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
            object val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = 丁丅丈丌丟世丗丗丟;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_5 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_7 = null;
            val_7 = null;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丝丟专丒丅丁丝丘丅);
            if(val_6 == null)
            {
                goto label_9;
            }
            
            label_27:
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_6);
            val_8 = null;
            val_8 = null;
            if(丟丛丑丒丆丛东下丌 == null)
            {
                goto label_13;
            }
            
            label_29:
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丟丛丑丒丆丛东下丌);
            val_9 = null;
            val_9 = null;
            val_6 = UnityEngine.SystemInfo.deviceModel;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_6);
            if(丗七丟丈三不丕一三 != null)
            {
                    if(丗七丟丈三不丕一三.Count >= 1)
            {
                    val_10 = null;
                val_10 = null;
                val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  丗七丟丈三不丕一三);
            }
            
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  50, 丗丟上上丒丐丗丞丙:  val_5);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_5);
            return;
            label_9:
            if(val_5 != null)
            {
                goto label_27;
            }
            
            goto label_27;
            label_13:
            if(val_5 != null)
            {
                goto label_29;
            }
            
            goto label_29;
        }
        internal static void 丛万丕丒上丌丂丝七(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, long 丑丅丂丞丞丙丐丁丌, string 丂丄丕一不世且丏丏, string 丟丒丞丐丐丘丒丄东)
        {
            object val_3;
            long val_4;
            var val_5;
            val_3 = 丂丄丕一不世且丏丏;
            val_4 = 丑丅丂丞丞丙丐丁丌;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_3, value:  丟丒丞丐丐丘丒丄东);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  66, 丗丟上上丒丐丗丞丙:  val_2);
        }
        internal static void 丗丄七丒专东丏丟三(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 下七丆上一丏丌丟丈, string 丞丅上丏丂且下丅与)
        {
            int val_3;
            var val_4;
            val_3 = 下七丆上一丏丌丟丈;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_4 = null;
            val_4 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_3, value:  丞丅上丏丂且下丅与);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  67, 丗丟上上丒丐丗丞丙:  val_2);
        }
        internal static void 丌丂一万业丌丘专丛(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丏丈丕世丝丆东丆丑, int 丈丘丝一丗下丈丐不)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3;
            var val_4;
            var val_5;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_4 = null;
            val_4 = null;
            if(丏丈丕世丝丆东丆丑 == null)
            {
                goto label_8;
            }
            
            label_17:
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丏丈丕世丝丆东丆丑);
            val_5 = null;
            val_5 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丈丘丝一丗下丈丐不);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  58, 丗丟上上丒丐丗丞丙:  val_3);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_3);
            return;
            label_8:
            if(val_3 != null)
            {
                goto label_17;
            }
            
            goto label_17;
        }
        internal static void 丘上专丐丙丆丅丕下(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 且丒丛与丞世丙丕丌, int 一丟下丝且丈丆业上, string 丈丘丙丛丗不七专丟, string 丈丐丒丐丕丛东丑业, TournamentReward 上业丟世三与七七三, int 且丐丐丁丐丒丌丗丙)
        {
            var val_7;
            object val_8;
            string val_9;
            int val_10;
            var val_11;
            var val_12;
            var val_13;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.String> val_15;
            var val_17;
            val_8 = 上业丟世三与七七三;
            val_9 = 丈丐丒丐丕丛东丑业;
            val_10 = 一丟下丝且丈丆业上;
            val_11 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            丁丁丒丆不丒下丟三 val_2 = new 丁丁丒丆不丒下丟三();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_12 = null;
            val_12 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  且丒丛与丞世丙丕丌);
            val_11 = 1152921505690869760;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_10);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  且丐丐丁丐丒丌丗丙);
            val_7 = 1152921505690550272;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丈丘丙丛丗不七专丟);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_9);
            val_10 = 1152921505690710016;
            val_13 = null;
            val_13 = null;
            val_15 = 一业丗丆世世上丁且.<>c.<>9__53_0;
            if(val_15 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.String> val_4 = null;
                val_15 = val_4;
                val_4 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.String>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一业丗丆世世上丁且.<>c::丆不上不丝丕丈丈丄(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                val_13 = null;
                一业丗丆世世上丁且.<>c.<>9__53_0 = val_15;
            }
            
            val_13 = null;
            val_9 = 一业丗丆世世上丁且.<>c.<>9__53_1;
            if(val_9 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Int32> val_5 = null;
                val_9 = val_5;
                val_5 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Int32>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 一业丗丆世世上丁且.<>c::丑不丙丏丐丕丒丗下(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                一业丗丆世世上丁且.<>c.<>9__53_1 = val_9;
            }
            
            val_17 = null;
            val_8 = System.Linq.Enumerable.ToDictionary<PGCompany.三东丏不丗世丅丌丄, System.String, System.Int32>(source:  上业丟世三与七七三.reward, keySelector:  val_4, elementSelector:  val_5);
            val_17 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_8);
            val_11.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  56, 丗丟上上丒丐丗丞丙:  val_3);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_3);
        }
        internal static void 丛丌万丐丕丆三丏业(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丅上三丏万丛七丐东, System.Nullable<丝上丑丏与丟丗丄丒> 业业丅丕业丞业丗丗)
        {
            int val_3;
            var val_4;
            val_3 = 丅上三丏万丛七丐东;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_4 = null;
            val_4 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_3, value:  业业丅丕业丞业丗丗.HasValue);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  237, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丒丏丈丟丗与丈丗丗(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)
        {
            var val_5;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_5 = null;
            val_5 = null;
            PGCompany.丑丝丟与丘丐丏上三 val_3 = Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  三万万丒丏丒不丐丙.DataId);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_3.丝丗东与不丂业专丛.ToString());
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  81, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丟下上万丕丆丙丐不(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙, System.Collections.Generic.Dictionary<string, int> 丞丄丂丁丁丑丐丕丌, PGCompany.丝不丅丗丄丄与丌丘 世不丈万丛世且下三)
        {
            var val_7;
            var val_8;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9;
            var val_10;
            var val_11;
            var val_12;
            val_7 = 世不丈万丛世且下三.专丈丟上丈丁丛七丒;
            val_8 = 三万万丒丏丒不丐丙;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_9 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_10 = null;
            val_10 = null;
            PGCompany.丑丝丟与丘丐丏上三 val_3 = Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  三万万丒丏丒不丐丙.DataId);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_8 = 1152921516595668352;
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_3.丝丗东与不丂业专丛.ToString());
            if(丞丄丂丁丁丑丐丕丌 != null)
            {
                    val_11 = null;
                val_11 = null;
                val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  丞丄丂丁丁丑丐丕丌);
            }
            
            if(世不丈万丛世且下三.丌万丑丟上七丐丐丕 == 1)
            {
                    val_12 = null;
                val_12 = null;
                val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_7.丂丁丏一丙丛业且丌());
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  82, 丗丟上上丒丐丗丞丙:  val_9);
            val_7 = 0;
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_9);
            if(val_7 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(145 == 145)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        internal static void 丅丞丏且丌三丝下万(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6;
            var val_7;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_6 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_7 = null;
            val_7 = null;
            PGCompany.丑丝丟与丘丐丏上三 val_3 = Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  三万万丒丏丒不丐丙.DataId);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_3.丝丗东与不丂业专丛.ToString());
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  0);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  85, 丗丟上上丒丐丗丞丙:  val_6);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_6);
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(111 == 111)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        internal static void 丕丂丗丒三丙丄丏业(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙, PGCompany.丝不丅丗丄丄与丌丘 世不丈万丛世且下三)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
            var val_8;
            object val_9;
            var val_10;
            val_8 = 世不丈万丛世且下三.专丈丟上丈丁丛七丒;
            val_9 = 三万万丒丏丒不丐丙;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_7 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_10 = null;
            val_10 = null;
            PGCompany.丑丝丟与丘丐丏上三 val_3 = Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  三万万丒丏丒不丐丙.DataId);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_3.丝丗东与不丂业专丛.ToString());
            val_9 = 1;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  1);
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_8.丂丁丏一丙丛业且丌());
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  85, 丗丟上上丒丐丗丞丙:  val_7);
            val_8 = 0;
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_7);
            if(val_8 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(138 == 138)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        internal static void 丛丈且世世业世丘丄(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)
        {
            var val_6;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
            var val_8;
            var val_9;
            object val_10;
            var val_11;
            var val_12;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                goto label_19;
            }
            
            val_7 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_9 = null;
            val_9 = null;
            PGCompany.丑丝丟与丘丐丏上三 val_3 = Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  三万万丒丏丒不丐丙.DataId);
            val_10 = val_3.丝丗东与不丂业专丛.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_10);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  84, 丗丟上上丒丐丗丞丙:  val_7);
            val_11 = 0;
            val_12 = 0;
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_7);
            if(val_11 == 1)
            {
                goto label_17;
            }
            
            if((val_12 == 0) || (94 == 94))
            {
                goto label_19;
            }
            
            label_20:
            val_6 = ???;
            val_12 = ???;
            val_7 = ???;
            val_11 = ???;
            val_10 = ???;
            val_8 = ???;
            label_17:
            if(val_12 != 0)
            {
                goto label_20;
            }
            
            label_19:
            var val_5 = val_6 - 64;
        }
        internal static void 丝七丑东与专专丑七(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, 丈丞丕丘丕丗与上一 丗下一不丘丑丅业且, int 丝丈三丐丏丐且一三, string 上丒业丗专丐七东东)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
            object val_6;
            var val_7;
            val_6 = 上丒业丗专丐七东东;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_5 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_7 = null;
            val_7 = null;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_6);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丗下一不丘丑丅业且.东与三丌丅三丒丏业());
            val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘;
            val_5.set_Item(key:  val_6, value:  丗下一不丘丑丅业且.丟丂丞不专丆万丒世());
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  丝丈三丐丏丐且一三);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  83, 丗丟上上丒丐丗丞丙:  val_5);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_5);
        }
        internal static void 且丁专业丙丌丌丝七(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丄丒且丙三丆丟与丏)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_3 = null;
            val_3 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丄丒且丙三丆丟与丏);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  65, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丛丄丟丟下丘丏专东(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 专丝且丟且丐丏丈丑, int 丈丘丝一丗下丈丐不, int 丝丈三丐丏丐且一三, int 世不下丟世一丝丐丗, int 丏丐丕丛下丒丏下七)
        {
            PGCompany.Analytics.一业丗丆世世上丁且.不七且丅丘丑三丗丄(丆丛丑世下一丐且丕:  丆丛丑世下一丐且丕, 专丝且丟且丐丏丈丑:  专丝且丟且丐丏丈丑, 丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不, 丝丈三丐丏丐且一三:  丝丈三丐丏丐且一三, 世不下丟世一丝丐丗:  世不下丟世一丝丐丗, 丏丐丕丛下丒丏下七:  丏丐丕丛下丒丏下七);
        }
        internal static void 上东业七丟丅丗丕丆(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 七丐一丙下丌丙丞丝, bool 丛丅丗丐丘丛丙丈丁, int 世不下丟世一丝丐丗, int 丏丐丕丛下丒丏下七)
        {
            PGCompany.Analytics.一业丗丆世世上丁且.三丕与丄一七业丅丐(丆丛丑世下一丐且丕:  丆丛丑世下一丐且丕, 七丐一丙下丌丙丞丝:  七丐一丙下丌丙丞丝, 万丗下丙世丞丞东丘:  (丛丅丗丐丘丛丙丈丁 != true) ? (1 + 1) : 1, 丏丛丏上丐丐丁丐世:  0, 丁丒上不丘业丂上丕:  0, 丈且东丁业丈丈东上:  System.String.alignConst, 且专丝丟丈上丆丟且:  System.String.alignConst, 世不下丟世一丝丐丗:  世不下丟世一丝丐丗, 丏丐丕丛下丒丏下七:  丏丐丕丛下丒丏下七);
        }
        internal static void 丞且一丕丒世丄与与(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丅丈丌丟世丗丗丟, int 丈丘丝一丗下丈丐不, string 丂三丗丑丕丛丝业丌, int 丄东世不与不丐不专, int 世不下丟世一丝丐丗, int 丏丐丕丛下丒丏下七)
        {
            PGCompany.Analytics.一业丗丆世世上丁且.丅上万丌丌丈三丘丕(丆丛丑世下一丐且丕:  丆丛丑世下一丐且丕, 丒丁丒下丏丙丅丁与:  丁丅丈丌丟世丗丗丟, 丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不, 丂三丗丑丕丛丝业丌:  丂三丗丑丕丛丝业丌, 丄东世不与不丐不专:  丄东世不与不丐不专, 世不下丟世一丝丐丗:  世不下丟世一丝丐丗, 丏丐丕丛下丒丏下七:  丏丐丕丛下丒丏下七);
        }
        internal static void 丞丌一丘专丌东上丘(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丙不丐业万七丟万下, int 丞丈不万东丌丆丙三, PGCompany.PixelPass.丙业丝丗丟丛丘丁与 世丁丙世丄一万丆三)
        {
            int val_5;
            var val_6;
            val_5 = 丞丈不万东丌丆丙三;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_6 = null;
            val_6 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5 - 丙不丐业万七丟万下);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  val_5, value:  世丁丙世丄一万丆三.ToString());
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  28, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丙丄丌万上丑丐丐不(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丂不与丈丞丁一东丒, int 世不下丟世一丝丐丗, int 丐七丈丄丒世上专丏, int 丑丂丆与丄丙丒丗丂, int 丅业世丈丅丁上丅丅, bool 东丏丂丙丑丁丞丞万, Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, PGCompany.PixelPass.丒且丏万业业七业万 丌丏与丐东丘东丕不, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_8;
            int val_9;
            int val_10;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_11;
            var val_12;
            val_9 = 丅业世丈丅丁上丅丅;
            val_10 = 丐七丈丄丒世上专丏;
            val_11 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_12 = null;
            val_12 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  世不下丟世一丝丐丗);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_10);
            val_10 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_2.set_Item(key:  val_10, value:  丑丂丆与丄丙丒丗丂);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_9);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  东丏丂丙丑丁丞丞万));
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丂不与丈丞丁一东丒);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  上且丗一丏丏万丅丌.ToString());
            val_9 = 丌丏与丐东丘东丕不;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  丌丏与丐东丘东丕不.ToString());
            val_11 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_11, value:  PGCompany.Analytics.一业丗丆世世上丁且.与丆专且且丐丈专上(丈丂丗丈世专丁丟丑:  上业丟世三与七七三));
            val_8 = val_11;
            val_8.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  29, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丁世丆丒丌三丄丒丌(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丆丛丆丄丑丛一与与, string 不丅世下丗丄丛三下, int 世不下丟世一丝丐丗, int 丐七丈丄丒世上专丏, int 丑丂丆与丄丙丒丗丂, int 丅业世丈丅丁上丅丅)
        {
            int val_3;
            int val_4;
            string val_5;
            var val_6;
            val_3 = 丅业世丈丅丁上丅丅;
            val_4 = 丐七丈丄丒世上专丏;
            val_5 = 不丅世下丗丄丛三下;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_6 = null;
            val_6 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  世不下丟世一丝丐丗);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_2.set_Item(key:  val_4, value:  丑丂丆与丄丙丒丗丂);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_3, value:  丆丛丆丄丑丛一与与);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_5, value:  val_5);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  30, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 不七且丅丘丑三丗丄(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 专丝且丟且丐丏丈丑, int 丈丘丝一丗下丈丐不, int 丝丈三丐丏丐且一三, int 世不下丟世一丝丐丗, int 丏丐丕丛下丒丏下七)
        {
            var val_3;
            int val_4;
            int val_5;
            var val_6;
            var val_7;
            val_4 = 丝丈三丐丏丐且一三;
            val_5 = 专丝且丟且丐丏丈丑;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_6 = null;
            val_7 = 丆丛丑世下一丐且丕;
            val_3 = 1152921516595668352;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  丈丘丝一丗下丈丐不);
            val_5 = ;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东;
            val_2.set_Item(key:  val_4, value:  世不下丟世一丝丐丗);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  丏丐丕丛下丒丏下七);
            val_5.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  10, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 三丕与丄一七业丅丐(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 七丐一丙下丌丙丞丝, int 万丗下丙世丞丞东丘, int 丏丛丏上丐丐丁丐世, int 丁丒上不丘业丂上丕, string 丈且东丁业丈丈东上, string 且专丝丟丈上丆丟且, int 世不下丟世一丝丐丗, int 丏丐丕丛下丒丏下七)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_3;
            int val_4;
            string val_5;
            int val_6;
            string val_7;
            var val_8;
            var val_9;
            var val_10;
            val_4 = 世不下丟世一丝丐丗;
            val_5 = 丈且东丁业丈丈东上;
            val_6 = 万丗下丙世丞丞东丘;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_7 = 1152921505690550272;
            val_5 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  7);
            val_8 = null;
            val_8 = null;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_6);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  七丐一丙下丌丙丞丝);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗;
            val_5.set_Item(key:  val_4, value:  丏丐丕丛下丒丏下七);
            val_6 = 丁丒上不丘业丂上丕;
            if(丏丛丏上丐丐丁丐世 >= 1)
            {
                    val_9 = null;
                val_9 = null;
                val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
                val_5.set_Item(key:  val_4, value:  丏丛丏上丐丐丁丐世);
                val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_5);
            }
            
            if(val_6 >= 1)
            {
                    val_10 = null;
                val_10 = null;
                val_7 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东;
                val_5.set_Item(key:  val_7, value:  val_6);
                val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  且专丝丟丈上丆丟且);
            }
            
            val_3 = 丆丛丑世下一丐且丕;
            val_3.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  11, 丗丟上上丒丐丗丞丙:  val_5);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_5);
        }
        internal static void 丅上万丌丌丈三丘丕(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丒丁丒下丏丙丅丁与, int 丈丘丝一丗下丈丐不, string 丂三丗丑丕丛丝业丌, int 丄东世不与不丐不专, int 世不下丟世一丝丐丗, int 丏丐丕丛下丒丏下七)
        {
            int val_3;
            string val_4;
            int val_5;
            var val_6;
            val_3 = 世不下丟世一丝丐丗;
            val_4 = 丂三丗丑丕丛丝业丌;
            val_5 = 丈丘丝一丗下丈丐不;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_6 = null;
            val_6 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丒丁丒下丏丙丅丁与);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_2.set_Item(key:  val_5, value:  丄东世不与不丐不专);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄;
            val_2.set_Item(key:  val_3, value:  丏丐丕丛下丒丏下七);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_4, value:  val_4);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  13, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 业丙丝且丐丁且七上(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丞丅上丏丂且下丅与, float 丗与丘不且万丟丙丑, int 丟丒业且万上丁三丆, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三, string 丂丛丑东不丅丈一东, string 万丒丑且丈丂丘东丑)
        {
            string val_10;
            object val_11;
            int val_12;
            object val_13;
            var val_14;
            val_10 = 万丒丑且丈丂丘东丑;
            val_11 = 丂丛丑东不丅丈一东;
            val_12 = 丞丅上丏丂且下丅与;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            if(((上业丟世三与七七三 != null) && (上业丟世三与七七三.Count >= 1)) && (上业丟世三与七七三.Count >= 1))
            {
                    val_13 = 0;
                var val_10 = 0;
                do
            {
                if(上业丟世三与七七三.Item[0].Type == 1100)
            {
                    val_13 = 上业丟世三与七七三.Item[0].Count;
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < 上业丟世三与七七三.Count);
            
            }
            else
            {
                    val_13 = 0;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_14 = null;
            val_14 = null;
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_12);
            val_10 = val_13;
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_13);
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  丟丒业且万上丁三丆);
            val_12 = 丗与丘不且万丟丙丑;
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  丗与丘不且万丟丙丑);
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_11);
            val_11 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_9.set_Item(key:  val_11, value:  val_10);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  12, 丗丟上上丒丐丗丞丙:  val_9);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_9);
        }
        internal static void 万丘三世业丈丁专世(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丈丁丄丘丛世七丙丝, int 七丐丅专且专七三丆, int 丌丒丝东丌下丕丁丅, int 丁丂丕与丁丒丕丟丞, string 丈丆丕与丒丌丘丕且)
        {
            var val_3;
            int val_4;
            int val_5;
            var val_6;
            var val_7;
            var val_8;
            val_4 = 丁丂丕与丁丒丕丟丞;
            val_5 = 七丐丅专且专七三丆;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_6 = null;
            val_7 = 丆丛丑世下一丐且丕;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_5, value:  丌丒丝东丌下丕丁丅);
            val_3 = ;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            if(丈丁丄丘丛世七丙丝 == null)
            {
                goto label_12;
            }
            
            label_22:
            val_2.set_Item(key:  val_4, value:  丈丁丄丘丛世七丙丝);
            val_8 = null;
            val_8 = null;
            if(丈丆丕与丒丌丘丕且 == 0)
            {
                goto label_16;
            }
            
            label_24:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丈丆丕与丒丌丘丕且);
            val_3.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  40, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_12:
            if(val_2 != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_16:
            if(val_2 != null)
            {
                goto label_24;
            }
            
            goto label_24;
        }
        internal static void 七丆下丈上业一七一(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丈丁丄丘丛世七丙丝, int 丌丒丝东丌下丕丁丅)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3;
            var val_4;
            var val_5;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_4 = null;
            val_4 = null;
            if(丈丁丄丘丛世七丙丝 == null)
            {
                goto label_8;
            }
            
            label_17:
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丈丁丄丘丛世七丙丝);
            val_5 = null;
            val_5 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丌丒丝东丌下丕丁丅);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  41, 丗丟上上丒丐丗丞丙:  val_3);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_3);
            return;
            label_8:
            if(val_3 != null)
            {
                goto label_17;
            }
            
            goto label_17;
        }
        internal static void 丝万丂与且丂东丘丁(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丈丁丄丘丛世七丙丝, string 上万一丈丅丏业丂不)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_3 = null;
            val_3 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丈丁丄丘丛世七丙丝);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  上万一丈丅丏业丂不);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  42, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 业与丕丞丅丟下丈丝(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丄丒下业一不丈丝丘, string 丆丙业丟丐万不丈上, string 丌丘丌与不丝丒丈丁, string 七丆世且七丗世丕丌, int 丅丁丄丒丗上丑七丏)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4;
            int val_5;
            object val_6;
            var val_7;
            var val_8;
            var val_9;
            val_5 = 丅丁丄丒丗上丑七丏;
            val_6 = 丆丙业丟丐万不丈上;
            val_7 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_4 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丄丒下业一不丈丝丘);
            val_5 = 1152921505690550272;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_6);
            val_7 = val_7;
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丌丘丌与不丝丒丈丁)) != false)
            {
                    val_8 = null;
                val_8 = null;
                val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
                val_4.set_Item(key:  val_6, value:  丌丘丌与不丝丒丈丁);
            }
            
            val_9 = null;
            val_9 = null;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑, value:  七丆世且七丗世丕丌);
            val_7.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  201, 丗丟上上丒丐丗丞丙:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_4);
        }
        internal static void 三一丅丂丙丈丈三且(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, 专一东丂不丌不丛丏 丟丒丞丐丐丘丒丄东)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
            var val_8;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_7 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            string val_3 = I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业();
            val_8 = null;
            val_8 = null;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丟丒丞丐丐丘丒丄东.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  (val_3 == null) ? "null" : (val_3));
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  17, 丗丟上上丒丐丗丞丙:  val_7);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_7);
        }
        internal static void 丝世丄不丏东丘丈丐(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, System.Nullable<丞丂丘丒丟丞丑下丄.丏丆丘丌且丒丏丄丏> 丅丆丌丈丐丆下且专, System.Nullable<丞丂丘丒丟丞丑下丄.丏丆丘丌且丒丏丄丏> 下丞业丂丂丟且丘丆, string 丏不上丟丑丕业上丄, string 丄丅丏七丅七丆丏三)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
            var val_8;
            string val_9;
            var val_10;
            var val_11;
            var val_12;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_7 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            if(((-201099400) & 1) != 0)
            {
                    val_8 = null;
                val_8 = null;
                val_9 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
                val_7.set_Item(key:  val_9, value:  ((-201099400) == 1) ? "free" : "closed");
            }
            
            if(( & 1) != 0)
            {
                    val_10 = null;
                val_10 = null;
                val_9 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
                val_7.set_Item(key:  val_9, value:  ( == 1) ? "free" : "closed");
            }
            
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丏不上丟丑丕业上丄)) != false)
            {
                    val_11 = null;
                val_11 = null;
                val_9 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
                val_7.set_Item(key:  val_9, value:  丏不上丟丑丕业上丄);
            }
            
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丄丅丏七丅七丆丏三)) != false)
            {
                    val_12 = null;
                val_12 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑, value:  丄丅丏七丅七丆丏三);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  221, 丗丟上上丒丐丗丞丙:  val_7);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_7);
        }
        internal static void 不丘丌丘业万丐上上(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_3 = null;
            val_3 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丄丒下业一不丈丝丘);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  202, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 七丁专丙丘三不丑丐(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.七东万三万丒丏一丁 专业丗丛不丕七丐东, int 丄丛丟世丒丑与丑丌, string 丑东与丅丐丅丂丞业, string 丏丂不专上丘丂不丅, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三)
        {
            int val_6;
            int val_1 = PGCompany.丁丑上丞业丞丟丛上.丂丘丒丕丑七丙丈丑(与丁专世丈且东丌丅:  专业丗丛不丕七丐东);
            if(专业丗丛不丕七丐东 != null)
            {
                    val_6 = 专业丗丛不丕七丐东.丂万丞与丈丙丅丝七();
            }
            else
            {
                    val_6 = 0.丂万丞与丈丙丅丝七();
            }
            
            val_6 = val_6 + val_1;
            PGCompany.ClanLootBoxData val_4 = 专业丗丛不丕七丐东.丁专丗万三上丟三丆();
            PGCompany.Analytics.一业丗丆世世上丁且.七丁专丙丘三不丑丐(丆丛丑世下一丐且丕:  丆丛丑世下一丐且丕, 丞不下丄且丄丄丅丝:  val_4.Id, 东上业丐丄专七丑业:  val_6, 丏丕丁丟丑世且丐丌:  (val_1 > 0) ? 1 : 0, 丏丌不业且丄丗丒丄:  丄丛丟世丒丑与丑丌, 丑东与丅丐丅丂丞业:  丑东与丅丐丅丂丞业, 丏丂不专上丘丂不丅:  丏丂不专上丘丂不丅, 上业丟世三与七七三:  上业丟世三与七七三);
        }
        private static void 七丁专丙丘三不丑丐(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丞不下丄且丄丄丅丝, int 东上业丐丄专七丑业, bool 丏丕丁丟丑世且丐丌, int 丏丌不业且丄丗丒丄, string 丑东与丅丐丅丂丞业, string 丏丂不专上丘丂不丅, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三)
        {
            System.Object[] val_111;
            string val_112;
            var val_113;
            string val_114;
            var val_115;
            var val_116;
            var val_117;
            System.Collections.Generic.Dictionary<TKey, TValue> val_118;
            var val_119;
            System.Collections.Generic.Dictionary<TKey, TValue> val_120;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_121;
            var val_122;
            var val_123;
            var val_124;
            var val_125;
            var val_126;
            var val_129;
            PGCompany.Analytics.丂与丏丕一丒与丁丙 val_130;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞不下丄且丄丄丅丝)) == false)
            {
                goto label_6;
            }
            
            val_111 = System.Array.Empty<System.Object>();
            val_112 = "Enque_ueClanC_hest chest_type null or empty";
            goto label_15;
            label_6:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丑东与丅丐丅丂丞业)) == false)
            {
                goto label_12;
            }
            
            val_111 = System.Array.Empty<System.Object>();
            val_112 = "Enque_ueClanC_hest source null or empty";
            goto label_15;
            label_12:
            if(上业丟世三与七七三 == null)
            {
                goto label_16;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  7);
            var val_113 = 0;
            label_77:
            if(val_113 >= 上业丟世三与七七三.Count)
            {
                goto label_19;
            }
            
            if(上业丟世三与七七三.Item[0] == null)
            {
                goto label_138;
            }
            
            Rilisoft.OfferItemType val_10 = 上业丟世三与七七三.Item[0].不业丙丒丂丞下丆丙();
            if(val_10 == 1000)
            {
                goto label_22;
            }
            
            if(val_10 == 1010)
            {
                goto label_23;
            }
            
            if(val_10 != 1200)
            {
                goto label_27;
            }
            
            int val_12 = 上业丟世三与七七三.Item[0].业东丅东丌上丗丑不();
            if(val_12 == 1015)
            {
                goto label_26;
            }
            
            if(val_12 != 2015)
            {
                goto label_27;
            }
            
            val_113 = 上业丟世三与七七三.Item[0];
            int val_14 = val_113.丂丁丏一丙丛业且丌();
            goto label_29;
            label_27:
            if((PGCompany.万丞丘与丕丞下万丌.丏丟下丐丝丙三且东(丁丅丈丌丟世丗丗丟:  val_10)) == false)
            {
                goto label_32;
            }
            
            if(0 == 0)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_16 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            val_114 = "";
            if(val_10 == 1150)
            {
                goto label_34;
            }
            
            if(val_10 != 1155)
            {
                goto label_39;
            }
            
            PGCompany.丝丟丅丏丟丞不丌七 val_20 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丝丟丅丏丟丞不丌七>(丞世不丒下上上丝丑:  上业丟世三与七七三.Item[0].业东丅东丌上丗丑不());
            if(val_20 == null)
            {
                goto label_38;
            }
            
            PGCompany.ModulePointData val_21 = val_20.丁专丗万三上丟三丆();
            val_114 = val_114;
            if(val_21 == null)
            {
                goto label_39;
            }
            
            PGCompany.丏丂一丗丙世丏丐三 val_24 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丏丂一丗丙世丏丐三>(丞世不丒下上上丝丑:  val_21.IndexItemModule);
            val_114 = val_114;
            if(val_24 == null)
            {
                goto label_87;
            }
            
            string val_27 = val_24.万丕丅下上丄丗万丞().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            ModuleType val_28 = val_24.与丝丅丘且丐上丅世();
            val_114 = val_28.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            val_115 = val_28;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_87;
            label_23:
            val_116 = 上业丟世三与七七三.Item[0];
            int val_32 = val_116.丂丁丏一丙丛业且丌();
            goto label_50;
            label_22:
            val_113 = 上业丟世三与七七三.Item[0];
            label_29:
            int val_111 = 0;
            val_111 = val_113.丂丁丏一丙丛业且丌() + val_111;
            goto label_138;
            label_32:
            if(val_10 > 1249)
            {
                goto label_53;
            }
            
            if(val_10 == 1070)
            {
                goto label_54;
            }
            
            if(val_10 != 1240)
            {
                goto label_138;
            }
            
            PGCompany.万丛下丐与丅与丅专 val_38 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.万丛下丐与丅与丅专>(丞世不丒下上上丝丑:  上业丟世三与七七三.Item[0].业东丅东丌上丗丑不());
            if(val_38 == null)
            {
                goto label_138;
            }
            
            val_117 = val_38.丈丏专三世七丒丘丑();
            goto label_59;
            label_53:
            if(val_10 == 1250)
            {
                goto label_60;
            }
            
            if(val_10 != 1300)
            {
                goto label_138;
            }
            
            PGCompany.七丟丘不下万丙丄下 val_43 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.七丟丘不下万丙丄下>(丞世不丒下上上丝丑:  上业丟世三与七七三.Item[0].业东丅东丌上丗丑不());
            if((val_43 == null) || (val_43.不一丆丑业且丆丙三() == null))
            {
                goto label_138;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_45 = val_43.不一丆丑业且丆丙三();
            if((val_45 == null) || (null != null))
            {
                goto label_138;
            }
            
            if(0 == 0)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_46 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            string val_47 = val_45.业上丙丞丐丄丆丅七();
            if((null.ContainsKey(key:  val_47)) != true)
            {
                    null.set_Item(key:  val_47, value:  0);
            }
            
            null.set_Item(key:  val_47, value:  上业丟世三与七七三.Item[0].丂丁丏一丙丛业且丌() + null.Item[val_47]);
            goto label_138;
            label_26:
            val_116 = 上业丟世三与七七三.Item[0];
            label_50:
            int val_112 = 0;
            val_112 = val_116.丂丁丏一丙丛业且丌() + val_112;
            label_138:
            val_113 = val_113 + 1;
            goto label_77;
            label_34:
            PGCompany.丏丂一丗丙世丏丐三 val_58 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丏丂一丗丙世丏丐三>(丞世不丒下上上丝丑:  上业丟世三与七七三.Item[0].业东丅东丌上丗丑不());
            if(val_58 == null)
            {
                goto label_87;
            }
            
            string val_61 = val_58.万丕丅下上丄丗万丞().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            ModuleType val_62 = val_58.与丝丅丘且丐上丅世();
            val_114 = val_62.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            val_115 = val_62;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_87;
            label_54:
            三丅丁丗丗丝丂万且 val_67 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  上业丟世三与七七三.Item[0].业上丙丞丐丄丆丅七());
            if(val_67 == null)
            {
                goto label_138;
            }
            
            val_118 = 0;
            if(val_118 == 0)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_68 = null;
                val_118 = val_68;
                val_68 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            string val_69 = val_67.与不丞丑七丘丁丂丛();
            if((val_68.ContainsKey(key:  val_69)) != true)
            {
                    val_68.set_Item(key:  val_69, value:  0);
            }
            
            val_68.set_Item(key:  val_69, value:  上业丟世三与七七三.Item[0].丂丁丏一丙丛业且丌() + val_68.Item[val_69]);
            goto label_138;
            label_60:
            PGCompany.三丙业丆上丏三丈丌 val_78 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.三丙业丆上丏三丈丌>(丞世不丒下上上丝丑:  上业丟世三与七七三.Item[0].业东丅东丌上丗丑不());
            if(val_78 == null)
            {
                goto label_138;
            }
            
            val_117 = val_78.丈丏专三世七丒丘丑();
            label_59:
            if(val_117 == null)
            {
                goto label_138;
            }
            
            val_119 = null;
            val_119 = null;
            val_120 = 0;
            if((System.String.op_Equality(a:  val_79.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄)) == false)
            {
                goto label_106;
            }
            
            if(val_120 == 0)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_82 = null;
                val_120 = val_82;
                val_82 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            string val_84 = 上业丟世三与七七三.Item[0].业上丙丞丐丄丆丅七();
            if((val_82.ContainsKey(key:  val_84)) != true)
            {
                    val_82.set_Item(key:  val_84, value:  0);
            }
            
            val_82.set_Item(key:  val_84, value:  上业丟世三与七七三.Item[0].丂丁丏一丙丛业且丌() + val_82.Item[val_84]);
            goto label_138;
            label_38:
            val_114 = val_114;
            label_39:
            label_87:
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_114)) == true) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_114)) == true))
            {
                goto label_138;
            }
            
            string val_92 = System.String.Format(format:  "{0}_{1}", arg0:  val_114, arg1:  val_114);
            if((null.ContainsKey(key:  val_92)) != true)
            {
                    null.set_Item(key:  val_92, value:  0);
            }
            
            null.set_Item(key:  val_92, value:  上业丟世三与七七三.Item[0].丂丁丏一丙丛业且丌() + null.Item[val_92]);
            goto label_138;
            label_106:
            if((System.String.op_Equality(a:  val_79.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛)) == false)
            {
                goto label_138;
            }
            
            if(0 == 0)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_98 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            string val_100 = 上业丟世三与七七三.Item[0].业上丙丞丐丄丆丅七();
            if((null.ContainsKey(key:  val_100)) != true)
            {
                    null.set_Item(key:  val_100, value:  0);
            }
            
            null.set_Item(key:  val_100, value:  上业丟世三与七七三.Item[0].丂丁丏一丙丛业且丌() + null.Item[val_100]);
            goto label_138;
            label_16:
            val_111 = System.Array.Empty<System.Object>();
            val_112 = "Enque_ueClanC_hest rewards null";
            label_15:
            UnityEngine.Debug.LogErrorFormat(format:  val_112, args:  val_111);
            return;
            label_19:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_107 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.set_Item(key:  "coins", value:  val_112);
            null.set_Item(key:  "gems", value:  val_111);
            if(null != 0)
            {
                    null.set_Item(key:  "Modules", value:  null);
            }
            
            if(val_118 != 0)
            {
                    null.set_Item(key:  "Guns", value:  val_68);
            }
            
            if(null != 0)
            {
                    null.set_Item(key:  "Gadgets", value:  null);
            }
            
            if(val_120 != 0)
            {
                    null.set_Item(key:  "Fort", value:  val_82);
            }
            
            if(null != 0)
            {
                    null.set_Item(key:  "Tank", value:  null);
            }
            
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丞不下丄且丄丄丅丝);
            val_121 = val_6;
            val_121.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丑东与丅丐丅丂丞业);
            val_122 = 1152921505690550272;
            val_123 = 1152921505690869760;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丏丂不专上丘丂不丅)) != true)
            {
                    val_121.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丏丌不业且丄丗丒丄);
                val_121.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  丏丂不专上丘丂不丅);
                val_122 = val_122;
                val_123 = 1152921505690869760;
            }
            
            val_124 = null;
            val_121.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  东上业丐丄专七丑业);
            val_121.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  丏丕丁丟丑世且丐丌);
            val_125 = null;
            val_126 = val_122;
            val_121.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  null);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  100, 丗丟上上丒丐丗丞丙:  val_121);
            val_129 = 0;
            val_130 = 0;
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  null);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(1587 != 1587)
            {
                    return;
            }
            
                return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        internal static void 专丝且丄世东与且丗(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丄丒下业一不丈丝丘)
        {
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  200, 丗丟上上丒丐丗丞丙:  0);
        }
        internal static void 丑东下上丏丄万丈上(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丞一丁业丄一一业且, int 下丒专丅丝丄丑不丏, int 丙丒世丂下三丑丛丝, string 丟下丟丈万一丙东丄, string 丑东与丅丐丅丂丞业, string 下丗丁丒丘东丂不丑)
        {
            var val_3;
            int val_4;
            int val_5;
            var val_6;
            var val_7;
            var val_8;
            val_4 = 丙丒世丂下三丑丛丝;
            val_5 = 丞一丁业丄一一业且;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_6 = null;
            val_7 = 丆丛丑世下一丐且丕;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_5, value:  下丒专丅丝丄丑不丏);
            val_3 = ;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            if(丟下丟丈万一丙东丄 == null)
            {
                goto label_12;
            }
            
            label_22:
            val_2.set_Item(key:  val_4, value:  丟下丟丈万一丙东丄);
            val_8 = null;
            val_8 = null;
            if(下丗丁丒丘东丂不丑 == 0)
            {
                goto label_16;
            }
            
            label_24:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  下丗丁丒丘东丂不丑);
            val_3.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  21, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_12:
            if(val_2 != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_16:
            if(val_2 != null)
            {
                goto label_24;
            }
            
            goto label_24;
        }
        internal static void 东一不东业与下世丆(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丅丈丌丟世丗丗丟, int 七丐丅专且专七三丆, int 东丝丅专丝丈一丘下, int 上丕丟丌上丐丝上上, string 丒丘丏上丙丟丑丕丈, string 下丗丁丒丘东丂不丑, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞, 丈丞丕丘丕丗与上一 丂下丛丝丆丂七丏丘)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_7;
            PGCompany.三东丏不丗世丅丌丄 val_8;
            string val_9;
            int val_10;
            int val_11;
            var val_12;
            string val_13;
            var val_15;
            val_8 = 丒世丘丘上丆丝东丞;
            val_9 = 丒丘丏上丙丟丑丕丈;
            val_10 = 东丝丅专丝丈一丘下;
            val_11 = 丁丅丈丌丟世丗丗丟;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_11);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  七丐丅专且专七三丆);
            val_11 = 1152921516595668352;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_10);
            val_10 = PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄;
            val_2.set_Item(key:  val_10, value:  上丕丟丌上丐丝上上);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_9);
            val_9 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_9, value:  下丗丁丒丘东丂不丑);
            if(val_8 == 0)
            {
                goto label_14;
            }
            
            val_12 = null;
            val_12 = null;
            int val_3 = val_8.丂丁丏一丙丛业且丌();
            val_9 = val_3;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_3);
            val_13 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
            string val_4 = val_8.业上丙丞丐丄丆丅七();
            goto label_18;
            label_14:
            val_8 = 丂下丛丝丆丂七丏丘;
            if(val_8 == null)
            {
                goto label_19;
            }
            
            val_15 = null;
            val_15 = null;
            int val_5 = val_8.丟丂丞不专丆万丒世();
            val_9 = val_5;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_5);
            val_13 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
            label_18:
            val_8 = val_8.东与三丌丅三丒丏业();
            val_2.set_Item(key:  val_13, value:  val_8);
            label_19:
            val_7 = 丆丛丑世下一丐且丕;
            val_7.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  20, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丄专丕丑丗三丅七丄(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, Rilisoft.丏丘七丞丄丙丌丞丁 丞丙上一丁丐丌与丝, 丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞)
        {
            object val_10;
            var val_11;
            var val_12;
            string val_13;
            var val_14;
            val_10 = 丒世丘丘上丆丝东丞;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_11 = null;
            val_11 = null;
            string val_4 = 丞丙上一丁丐丌与丝.丘专上世与丟丝丟丛().ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_4 == null)
            {
                goto label_11;
            }
            
            label_31:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_4);
            val_12 = null;
            val_12 = null;
            val_13 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            string val_7 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  丞丙上一丁丐丌与丝.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐());
            if(val_7 == null)
            {
                goto label_19;
            }
            
            label_33:
            val_2.set_Item(key:  val_13, value:  val_7);
            if(val_10 == null)
            {
                goto label_21;
            }
            
            val_14 = null;
            val_14 = null;
            int val_8 = val_10.丟丂丞不专丆万丒世();
            val_13 = val_8;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_8);
            val_10 = val_10.东与三丌丅三丒丏业();
            if(val_10 == null)
            {
                goto label_25;
            }
            
            label_35:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_10);
            label_21:
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  22, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_11:
            if(val_2 != null)
            {
                goto label_31;
            }
            
            goto label_31;
            label_19:
            if(val_2 != null)
            {
                goto label_33;
            }
            
            goto label_33;
            label_25:
            if(val_2 != null)
            {
                goto label_35;
            }
            
            goto label_35;
        }
        internal static void 丞丙丅专与万丕三且(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丄丒且丙三丆丟与丏)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_3 = null;
            val_3 = null;
            if(丄丒且丙三丆丟与丏 == null)
            {
                goto label_8;
            }
            
            label_14:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丄丒且丙三丆丟与丏);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  62, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_8:
            if(val_2 != null)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        internal static void 丅丁丄丐丘丕下世万(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丄丒且丙三丆丟与丏)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_3 = null;
            val_3 = null;
            if(丄丒且丙三丆丟与丏 == null)
            {
                goto label_8;
            }
            
            label_14:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丄丒且丙三丆丟与丏);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  63, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_8:
            if(val_2 != null)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        internal static void 世七万丏丅丅上与丞(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丑专七丕上世一丌业)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_3 = null;
            val_3 = null;
            if(丑专七丕上世一丌业 == null)
            {
                goto label_8;
            }
            
            label_14:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丑专七丕上世一丌业);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  30, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_8:
            if(val_2 != null)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        internal static void 一丛东丆丟丘世东三(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丄丞丈东三丟丂丐三, string 三丟专专丞丅七东业)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_3 = null;
            val_3 = null;
            if(三丟专专丞丅七东业 == null)
            {
                goto label_9;
            }
            
            label_15:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  三丟专专丞丅七东业);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  31, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_9:
            if(val_2 != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        internal static void 丆丛丑专与业丈不丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.丟丒丅丐万丈七且万 万不且且丛丆东丒业, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丗七丟丈三不丕一三)
        {
            PGCompany.丟丒丅丐万丈七且万 val_12;
            var val_13;
            val_12 = 万不且且丛丆东丒业;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_13 = null;
            val_13 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丗七丟丈三不丕一三.Item[0].丂丁丏一丙丛业且丌());
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丐丄七丙丁丆丁专丏.丂丞世丐丌丑丕下三(丕丗丘丑丛与丑业丒:  new PGCompany.世丐下丕专东丘丏且(上世丏丁世丟世丆业:  val_12)));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丗七丟丈三不丕一三.Item[0].不业丙丒丂丞下丆丙().ToString());
            PGCompany.GameTaskActionSettings val_10 = val_12.万丆丄上七丒专且世();
            val_12 = val_10.Type;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_12.ToString());
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  54, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丘万与丗下丒世丛丛(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丞丅上丏丂且下丅与, string 万不且且丛丆东丒业, string 丂丛丑东不丅丈一东, string 丞丁丑丏丄丏七丂不, System.Collections.Generic.List<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗> 丗七丟丈三不丕一三)
        {
            object val_14;
            object val_15;
            int val_16;
            var val_17;
            var val_18;
            val_14 = 丞丁丑丏丄丏七丂不;
            val_15 = 丂丛丑东不丅丈一东;
            val_16 = 丞丅上丏丂且下丅与;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_17 = null;
            val_17 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_16);
            val_16 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_16, value:  万不且且丛丆东丒业);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_15);
            val_15 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
            val_2.set_Item(key:  val_15, value:  val_14);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = null;
            val_14 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if((丗七丟丈三不丕一三 == null) || (丗七丟丈三不丕一三.Count < 1))
            {
                goto label_32;
            }
            
            List.Enumerator<T> val_5 = 丗七丟丈三不丕一三.GetEnumerator();
            val_16 = 1152921531029706448;
            label_22:
            if(((-198068912) & 1) == 0)
            {
                goto label_14;
            }
            
            string val_7 = val_16.丐丏七丌丕丗业且上();
            if(val_7.丂丑丞丝且万丐万丟() == null)
            {
                goto label_22;
            }
            
            val_3.Add(key:  val_7.丂丑丞丝且万丐万丟().NameDefault, value:  val_7.丂丑丞丝且万丐万丟().Count);
            goto label_22;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_32:
            val_18 = null;
            val_18 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_3);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  61, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丑万丟丙专丆且专丂(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丅丈丌丟世丗丗丟, string 丄丙丑丕不业丂丒丂)
        {
            object val_4;
            var val_5;
            val_4 = 丄丙丑丕不业丂丒丂;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丁丅丈丌丟世丗丗丟);
            val_4 = val_4.Replace(oldValue:  ",", newValue:  System.String.alignConst);
            if(val_4 == null)
            {
                goto label_10;
            }
            
            label_16:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_4);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  236, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_10:
            if(val_2 != null)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        internal static void 丁丑三与业丏万丌丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, 世丕丑七且丝七不不 且三丟七下丂专丈丈, CategoryNames 七丆丒与丗丌丄且丂, 丙且上东下丏丏丟下 丑丝丏丂且不下一东, string 七丐丅专且专七三丆, string 与上世丗丞丐万东丌)
        {
            string val_6;
            var val_7;
            CategoryNames val_8;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_9;
            string val_10;
            string val_11;
            丈丞丕丘丕丗与上一 val_12;
            if(丑丝丏丂且不下一东 == null)
            {
                goto label_1;
            }
            
            val_6 = 丑丝丏丂且不下一东.业上丙丞丐丄丆丅七();
            if(七丆丒与丗丌丄且丂 != 8)
            {
                goto label_8;
            }
            
            val_7 = null;
            val_7 = null;
            if((SkinsController.丑丝七丒丅丙东丞万.ContainsKey(key:  val_6)) != false)
            {
                    if((System.String.op_Equality(a:  val_6, b:  "20")) != true)
            {
                    if((System.String.op_Equality(a:  val_6, b:  "6")) == false)
            {
                goto label_8;
            }
            
            }
            
            }
            
            val_8 = 8;
            val_9 = 丆丛丑世下一丐且丕;
            val_10 = val_6;
            goto label_11;
            label_1:
            val_9 = 丆丛丑世下一丐且丕;
            val_8 = 七丆丒与丗丌丄且丂;
            val_10 = 0;
            label_11:
            val_11 = 七丐丅专且专七三丆;
            val_12 = 0;
            goto label_14;
            label_8:
            val_12 = PGCompany.Analytics.一业丗丆世世上丁且.丑丌丞丞专下丞世丞(丑丝丏丂且不下一东:  丑丝丏丂且不下一东, 七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
            val_9 = 丆丛丑世下一丐且丕;
            val_8 = 七丆丒与丗丌丄且丂;
            val_10 = val_6;
            val_11 = 七丐丅专且专七三丆;
            label_14:
            PGCompany.Analytics.一业丗丆世世上丁且.一丁七丂且丁丗万丏(丆丛丑世下一丐且丕:  val_9, 七丆丒与丗丌丄且丂:  val_8, 丞一丁业丄一一业且:  val_10, 七丐丅专且专七三丆:  val_11, 万丐丏丐丒万不丟三:  val_12, 与上世丗丞丐万东丌:  与上世丗丞丐万东丌, 与丙丆世丘丑丒丌丄:  new System.Nullable<Rilisoft.OfferItemType>() {HasValue = false}, 丞业丛世丛丘丝不丌:  false, 丈丄不七三万丄丁不:  0);
        }
        internal static void 一丁七丂且丁丗万丏(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, CategoryNames 七丆丒与丗丌丄且丂, string 丞一丁业丄一一业且, string 七丐丅专且专七三丆, 丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三, string 与上世丗丞丐万东丌, System.Nullable<Rilisoft.OfferItemType> 与丙丆世丘丑丒丌丄, bool 丞业丛世丛丘丝不丌 = False, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            var val_94;
            string val_95;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_96;
            var val_97;
            var val_98;
            var val_99;
            三丅丁丗丗丝丂万且 val_100;
            ItemRarity val_101;
            var val_102;
            var val_103;
            var val_104;
            object val_105;
            string val_106;
            var val_107;
            int val_108;
            var val_109;
            var val_110;
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            var val_115;
            var val_117;
            val_95 = 与上世丗丞丐万东丌;
            val_96 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  七丐丅专且专七三丆, b:  "unequip")) == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  七丐丅专且专七三丆, b:  "speedup")) == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  七丐丅专且专七三丆, b:  "upgrade")) != false)
            {
                    val_97 = 60;
            }
            else
            {
                    val_97 = 59;
                if((System.String.op_Equality(a:  七丐丅专且专七三丆, b:  "buy")) != true)
            {
                    int val_7 = ((System.String.op_Equality(a:  七丐丅专且专七三丆, b:  "equip")) != true) ? 64 : 59;
            }
            
            }
            
            string val_8 = 七丆丒与丗丌丄且丂.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(null == 240000)
            {
                goto label_11;
            }
            
            if(null != 8)
            {
                goto label_12;
            }
            
            val_98 = null;
            val_98 = null;
            if((TryGetValue(key:  丞一丁业丄一一业且, value: out  0)) == false)
            {
                goto label_142;
            }
            
            string val_11 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  4194311);
            val_99 = null;
            val_99 = null;
            bool val_13 = SkinsController.丈丁业下丕上丐与丈.TryGetValue(下上丐丆丝丟丝丒不:  丞一丁业丄一一业且, 丙业与丙丗丝不丈东: out  0);
            goto label_142;
            label_11:
            PGCompany.丟丝世万东万丆丟上 val_16 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.丟丝世万东万丆丟上>(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  丞一丁业丄一一业且));
            if(val_16 == null)
            {
                goto label_26;
            }
            
            int val_17 = val_16.业东丅东丌上丗丑不();
            goto label_27;
            label_12:
            if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  1152921505294970880)) == false)
            {
                goto label_30;
            }
            
            val_100 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丞一丁业丄一一业且);
            if(val_100 == null)
            {
                goto label_33;
            }
            
            int val_20 = val_100.业东丅东丌上丗丑不();
            goto label_34;
            label_30:
            if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  null)) == false)
            {
                goto label_37;
            }
            
            丕丈丏丝丗下丟丅丂 val_23 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丞一丁业丄一一业且];
            if(val_23 == null)
            {
                goto label_41;
            }
            
            int val_24 = val_23.业东丅东丌上丗丑不();
            goto label_42;
            label_26:
            int val_25 = 0.业东丅东丌上丗丑不();
            label_27:
            string val_26 = val_16.不丁上上且三丑七丂();
            label_165:
            label_142:
            val_101 = 0;
            goto label_180;
            label_37:
            if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  null)) == false)
            {
                goto label_46;
            }
            
            val_100 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丞一丁业丄一一业且);
            if(val_100 == null)
            {
                goto label_49;
            }
            
            int val_29 = val_100.业东丅东丌上丗丑不();
            string val_31 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_100.丗丗与丅丈且与丟丏());
            goto label_52;
            label_33:
            int val_32 = 0.业东丅东丌上丗丑不();
            label_34:
            string val_35 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_100.丗丗与丅丈且与丟丏()).Replace(oldValue:  "\"", newValue:  "");
            if((((-197290232) & 1) != 0) && ((-197290232) != 10))
            {
                    string val_36 = 与丙丆世丘丑丒丌丄.HasValue.ToString();
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            }
            
            if(val_100 == null)
            {
                goto label_60;
            }
            
            if(val_100.七丑丌专丒上丒丙七() == null)
            {
                goto label_61;
            }
            
            label_64:
            val_102 = val_100.七丑丌专丒上丒丙七();
            val_103 = 0;
            int val_39 = val_102.丈一下下丞世三丑丄();
            goto label_63;
            label_60:
            if(0.七丑丌专丒上丒丙七() != null)
            {
                goto label_64;
            }
            
            label_61:
            val_102 = val_100;
            val_103 = 0;
            int val_41 = val_102.七丙丛与万且专三三();
            label_63:
            label_52:
            val_104 = val_100;
            goto label_163;
            label_46:
            if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  null)) == false)
            {
                goto label_69;
            }
            
            if((1152921505294970874 > 6) || ((0 & 1) == 0))
            {
                goto label_142;
            }
            
            int val_45 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  mem[-1436432360], 丞一丁业丄一一业且:  丞一丁业丄一一业且);
            if(1152921505294970874 != 1)
            {
                goto label_75;
            }
            
            string val_47 = 七丌丞万七万丁丐丙.丕与东丞丕丒丘不丂(七丆丒与丗丌丄且丂:  7, 丝丒丞丙丐一一丅三:  丞一丁业丄一一业且).与业丕与丑丈丈丝专();
            PGCompany.且万丅丙丛丌丞与丈 val_49 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.且万丅丙丛丌丞与丈>(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  丞一丁业丄一一业且);
            int val_50 = val_49.丁丕丁三丁丗不三丟();
            val_101 = val_49;
            val_105 = 1;
            goto label_166;
            label_41:
            label_42:
            string val_53 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_23.丛丈丅丞丏丅丛丛丐());
            int val_56 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_23.业东丅东丌上丗丑不());
            label_163:
            val_101 = val_23.七东与丄丕丁丛世三();
            label_180:
            val_105 = 1;
            label_166:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_58 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_106 = 1152921505690869760;
            val_107 = null;
            val_107 = null;
            val_94 = 1152921504622075904;
            val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_23.业东丅东丌上丗丑不());
            val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_56);
            val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_101);
            val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  val_105);
            val_96 = val_96;
            val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_53);
            val_108 = val_95;
            if(val_95 == null)
            {
                    val_108 = System.String.alignConst;
            }
            
            val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_108);
            val_109 = null;
            val_109 = null;
            val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑, value:  val_36);
            if(万丐丏丐丒万不丟三 == null)
            {
                goto label_110;
            }
            
            val_110 = null;
            val_110 = null;
            if(丞业丛世丛丘丝不丌 != false)
            {
                    val_111 = 0;
            }
            else
            {
                    val_111 = 万丐丏丐丒万不丟三;
            }
            
            val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_111.丟丂丞不专丆万丒世());
            if((System.String.IsNullOrEmpty(value:  万丐丏丐丒万不丟三.东与三丌丅三丒丏业())) == true)
            {
                goto label_110;
            }
            
            val_112 = null;
            val_112 = null;
            if(丞业丛世丛丘丝不丌 == false)
            {
                goto label_113;
            }
            
            if(val_58 != null)
            {
                goto label_134;
            }
            
            label_135:
            label_134:
            val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  "free");
            label_110:
            if(val_7 == 64)
            {
                    val_58.Clear();
                val_113 = null;
                val_113 = null;
                val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_56);
                val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_53);
                val_58.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_36);
            }
            
            if((System.String.op_Equality(a:  val_95, b:  "trader")) != false)
            {
                    val_95 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.上一丈丏三丒三丙不>(丗与丟上上丑专世丗:  40);
                if(val_95 != null)
            {
                    val_114 = null;
                val_114 = null;
                val_106 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
                System.Collections.Generic.Dictionary<System.String, System.Object> val_65 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                val_65.Add(key:  "trader_season_id", value:  val_95.万上丁一丞业业万东());
                val_58.set_Item(key:  val_106, value:  val_65);
            }
            
            }
            
            val_96.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  val_7, 丗丟上上丒丐丗丞丙:  val_58);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_58);
            return;
            label_113:
            string val_67 = 万丐丏丐丒万不丟三.东与三丌丅三丒丏业();
            if(val_58 != null)
            {
                goto label_134;
            }
            
            goto label_135;
            label_69:
            if((上丑三丁丄丛丁万丑.丗丟丝下上业上丘且(七丆丒与丗丌丄且丂:  null)) == false)
            {
                goto label_138;
            }
            
            PetInfo val_70 = 0;
            if((丟下七丘下下丙丗丅.一三专丞丒丅上业上().TryGetValue(key:  丞一丁业丄一一业且, value: out  val_70)) == false)
            {
                goto label_142;
            }
            
            int val_72 = val_70.Index;
            int val_73 = val_70.CurrentLevel;
            val_115 = val_70;
            if(val_70 != 0)
            {
                goto label_166;
            }
            
            val_115 = val_70;
            if(val_115 == 0)
            {
                goto label_170;
            }
            
            goto label_166;
            label_49:
            丟丄七万东与上丒丟 val_75 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[丞一丁业丄一一业且];
            if(val_75 == null)
            {
                goto label_151;
            }
            
            int val_76 = val_75.业东丅东丌上丗丑不();
            goto label_152;
            label_138:
            if(丈丄不七三万丄丁不 == null)
            {
                goto label_180;
            }
            
            int val_77 = 丈丄不七三万丄丁不.业东丅东丌上丗丑不();
            string val_78 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
            int val_79 = 丈丄不七三万丄丁不.丂丁丏一丙丛业且丌();
            PGCompany.丗丟丄丈东丝丕丄世 val_81 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if(val_81 == null)
            {
                goto label_166;
            }
            
            if(null == null)
            {
                goto label_156;
            }
            
            if(null != null)
            {
                goto label_166;
            }
            
            ModuleCategory val_82 = val_81.万丕丅下上丄丗万丞();
            goto label_158;
            label_151:
            int val_83 = val_75.业东丅东丌上丗丑不();
            label_152:
            string val_85 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_75.丛丈丅丞丏丅丛丛丐());
            if(val_75 != null)
            {
                    int val_86 = val_75.丈丒丟下丂丒东与丑();
            }
            else
            {
                    int val_87 = val_75.丈丒丟下丂丒东与丑();
            }
            
            ItemRarity val_88 = val_75.七东与丄丕丁丛世三();
            goto label_163;
            label_75:
            string val_89 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  mem[-1436432360], 丞一丁业丄一一业且:  丞一丁业丄一一业且, 丂丕丂丏专丂丄丕且:  1).Id;
            goto label_165;
            label_156:
            label_158:
            string val_92 = System.String.Format(format:  "{0}_{1}", arg0:  val_81.万丕丅下上丄丗万丞(), arg1:  val_81.不业丙丒丂丞下丆丙());
            goto label_166;
            label_170:
            val_117 = 0;
            if(0 != 1)
            {
                goto label_172;
            }
            
            if((null & 1) == 0)
            {
                goto label_173;
            }
            
            object[] val_93 = new object[1];
            val_93[0] = 1179403647;
            UnityEngine.Debug.LogErrorFormat(format:  "Exception in preparing armor info : {0}", args:  val_93);
            goto label_180;
            label_173:
            mem[8] = 1179403647;
            val_117 = 8;
            label_172:
        }
        private static void 丁丑三与业丏万丌丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, 世丕丑七且丝七不不 且三丟七下丂专丈丈, CategoryNames 七丆丒与丗丌丄且丂, string 丞一丁业丄一一业且, string 七丐丅专且专七三丆, 丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三)
        {
            object val_9;
            object val_10;
            val_9 = 万丐丏丐丒万不丟三;
            val_10 = 七丐丅专且专七三丆;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  6);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  "tab", value:  且三丟七下丂专丈丈.ToString());
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  "subtab", value:  七丆丒与丗丌丄且丂.ToString());
            if(丞一丁业丄一一业且 == null)
            {
                goto label_12;
            }
            
            label_23:
            val_2.set_Item(key:  "itemId", value:  丞一丁业丄一一业且);
            if(val_10 == null)
            {
                goto label_14;
            }
            
            label_25:
            val_2.set_Item(key:  "action", value:  val_10);
            if(val_9 != null)
            {
                    int val_5 = val_9.丟丂丞不专丆万丒世();
                val_10 = val_5;
                val_2.set_Item(key:  "price", value:  val_5);
                if((System.String.IsNullOrEmpty(value:  val_9.东与三丌丅三丒丏业())) != true)
            {
                    val_9 = val_9.东与三丌丅三丒丏业();
                val_2.set_Item(key:  "currency", value:  val_9);
            }
            
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_12:
            if(val_2 != null)
            {
                goto label_23;
            }
            
            goto label_23;
            label_14:
            if(val_2 != null)
            {
                goto label_25;
            }
            
            goto label_25;
        }
        internal static void 丝丂丘与丂丙丅上丆(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 上且丗一丏丏万丅丌, string 丏丈丗世丙万丆丐丅)
        {
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            if(上且丗一丏丏万丅丌 == null)
            {
                goto label_6;
            }
            
            label_13:
            val_2.set_Item(key:  "mode", value:  上且丗一丏丏万丅丌);
            if(丏丈丗世丙万丆丐丅 == null)
            {
                goto label_8;
            }
            
            label_15:
            val_2.set_Item(key:  "scene", value:  丏丈丗世丙万丆丐丅);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_6:
            if(val_2 != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_8:
            if(val_2 != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        internal static void 丐丌与丐丙一不上丌(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 上且丗一丏丏万丅丌, string 丏丈丗世丙万丆丐丅, bool 万丟丗丏专丆丌上三, bool 下丁丝丗专丝世丒丂)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9;
            string val_10 = 上且丗一丏丏万丅丌;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_9 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            if(val_10 == null)
            {
                goto label_6;
            }
            
            label_17:
            val_9.set_Item(key:  "mode", value:  val_10 = 上且丗一丏丏万丅丌);
            val_10 = "scene";
            if(丏丈丗世丙万丆丐丅 == null)
            {
                goto label_8;
            }
            
            label_19:
            val_9.set_Item(key:  val_10, value:  丏丈丗世丙万丆丐丅);
            val_9.set_Item(key:  "isSquad", value:  万丟丗丏专丆丌上三.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
            val_9.set_Item(key:  "isSquadBR", value:  下丁丝丗专丝世丒丂.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_9);
            return;
            label_6:
            if(val_9 != null)
            {
                goto label_17;
            }
            
            goto label_17;
            label_8:
            if(val_9 != null)
            {
                goto label_19;
            }
            
            goto label_19;
        }
        internal static void 丘丑丝丌七东丄丙与(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 上且丗一丏丏万丅丌, string 丏丈丗世丙万丆丐丅, double 丂三丟丂丈丐丆丗丟, int 万丏丒与丈七世与丘)
        {
            int val_12;
            object val_13;
            var val_14;
            var val_15;
            var val_16;
            val_12 = 万丏丒与丈七世与丘;
            val_13 = 上且丗一丏丏万丅丌;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_14 = null;
            val_14 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_13);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丏丈丗世丙万丆丐丅);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  (int)丂三丟丂丈丐丆丗丟);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(PGCompany.GameModeLowDeviceWarningBanner.丕丂万与与丛丈丆丈 != false)
            {
                    val_3.set_Item(key:  "bad_device", value:  UnityEngine.SystemInfo.deviceModel);
            }
            
            val_15 = null;
            val_15 = null;
            if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                val_5.set_Item(key:  "t_b", value:  RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅() - val_12);
                val_5.set_Item(key:  "t_c", value:  val_12);
                RatingLeague val_10 = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
                val_12 = val_10;
                val_5.set_Item(key:  "l", value:  val_10);
                val_3.set_Item(key:  "competition_stats", value:  val_5);
            }
            
            val_13 = 1152921505690550272;
            if(val_3.Count >= 1)
            {
                    val_16 = null;
                val_16 = null;
                val_12 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅;
                val_2.set_Item(key:  val_12, value:  val_3);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  55, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 世专丆与丝丁东三丌(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丛丁三世世丆七不业, int 且丒丛与丞世丙丕丌, string 丏丂不专上丘丂不丅)
        {
            int val_3;
            int val_4;
            var val_5;
            val_3 = 且丒丛与丞世丙丕丌;
            val_4 = 丛丁三世世丆七不业;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_3, value:  丏丂不专上丘丂不丅);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  8, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丆丐不一世丑丘七上(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 上且丗一丏丏万丅丌, string 丏丈丗世丙万丆丐丅)
        {
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            if(上且丗一丏丏万丅丌 == null)
            {
                goto label_6;
            }
            
            label_13:
            val_2.set_Item(key:  "mode", value:  上且丗一丏丏万丅丌);
            if(丏丈丗世丙万丆丐丅 == null)
            {
                goto label_8;
            }
            
            label_15:
            val_2.set_Item(key:  "scene", value:  丏丈丗世丙万丆丐丅);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_6:
            if(val_2 != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_8:
            if(val_2 != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        private static System.Collections.Generic.Dictionary<string, object> 东东丈七丑丗丌一丅(System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> 七万丄七丅丅丕丝丑)
        {
            int val_4;
            List.Enumerator<T> val_2 = 七万丄七丅丅丕丝丑.GetEnumerator();
            goto label_59;
            label_71:
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if((val_5 == null) || ((val_5.不业丙丒丂丞下丆丙() - 1) > 24))
            {
                goto label_59;
            }
            
            var val_82 = 106039232 + ((val_6 - 1)) << 2;
            val_82 = val_82 + 106039232;
            goto (106039232 + ((val_6 - 1)) << 2 + 106039232);
            label_59:
            if(((-195493952) & 1) != 0)
            {
                goto label_71;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
        }
        internal static void 丘丒丑业一丗丞丁丛(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 上且丗一丏丏万丅丌, string 丏丈丗世丙万丆丐丅, bool 丌三丒丌丆东万丆一, int 专世专丟丝丌与丘上, double 与丈业丛丝丒丙一丏, int 丝丐丐丟丙丆一丄丗, int 下丝丘丁专丐丅丛丝 = 0, int 丞丗丄七专丈丕丕业 = 0, RatingSystem.丁上且上一丆丘与业 丕丈一丐丛世丆上万, ImposterFinalUI.丌一七丑七丟三丏丐 万三丟世三一不专丛 = 4)
        {
            object val_49;
            int val_50;
            bool val_51;
            object val_52;
            object val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            string val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            object val_66;
            var val_67;
            string val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_77;
            var val_78;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_85;
            var val_86;
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_87;
            Rilisoft.丝丑丂丛万丐丈丘且 val_88;
            val_50 = 丞丗丄七专丈丕丕业;
            val_51 = 丌三丒丌丆东万丆一;
            val_52 = 丏丈丗世丙万丆丐丅;
            val_53 = 上且丗一丏丏万丅丌;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  6);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            decimal val_6 = Rilisoft.Singleton<KillrateController>.Instance.丙丝与丝万丞七丌与(一丑丗三一丛一丄业:  7);
            val_4.Add(key:  "match_7", value:  val_6);
            decimal val_8 = Rilisoft.Singleton<KillrateController>.Instance.丙丝与丝万丞七丌与(一丑丗三一丛一丄业:  30);
            val_4.Add(key:  "match_30", value:  val_8);
            val_3.Add(key:  "Killrates", value:  val_4);
            val_54 = null;
            val_54 = null;
            if(val_53 == null)
            {
                goto label_13;
            }
            
            label_69:
            val_50 = 1152921516595668352;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_53);
            val_55 = null;
            val_55 = null;
            if(val_52 == null)
            {
                goto label_17;
            }
            
            label_71:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_52);
            val_56 = null;
            val_56 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  Newtonsoft.Json.JsonConvert.SerializeObject(value:  val_3, formatting:  0));
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  与丈业丛丝丒丙一丏);
            val_53 = 1152921504622075904;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  丝丐丐丟丙丆一丄丗);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  专世专丟丝丌与丘上);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_51);
            世丁与丕丗丟丒丆上 val_11 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            if((val_11 != null) && ((ConnectScene.丌丌一丅丂丐不丆丛(东七上世万下丗丄丛:  val_11)) != false))
            {
                    val_57 = null;
                val_57 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  2);
                System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                val_58 = null;
                val_58 = null;
                System.Collections.Generic.Dictionary<System.String, System.Object> val_17 = PGCompany.Analytics.一业丗丆世世上丁且.东东丈七丑丗丌一丅(七万丄七丅丅丕丝丑:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丝与业丘丌业丄东万(丏丛与丅丛丌万专丌:  val_11.丂丂丁丕专丂丏与丌().Item[GameConnect.不丕丂三丙与丈且三]));
                val_60 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丂丄不世丁丞丛丁一;
            }
            else
            {
                    val_61 = null;
                val_61 = null;
                val_62 = null;
                val_60 = PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗;
                val_62 = null;
            }
            
            val_2.set_Item(key:  val_60, value:  (GameConnect.丈丝丂丐丟万丙丑丕 != 0) ? 1 : 0);
            val_63 = null;
            val_63 = null;
            val_52 = 1152921504848912384;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
            {
                goto label_74;
            }
            
            if(GameConnect.丑丌丛丈丅丅与不业() != 30)
            {
                goto label_59;
            }
            
            val_64 = null;
            val_64 = null;
            val_65 = null;
            val_65 = null;
            val_66 = mem[val_21 != true ? "imposter" : "peaceful"];
            val_66 = (丟东丘丏上世且上丕() != true) ? "imposter" : "peaceful";
            val_67 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            val_68 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑;
            goto label_67;
            label_13:
            if(val_2 != null)
            {
                goto label_69;
            }
            
            goto label_69;
            label_17:
            if(val_2 != null)
            {
                goto label_71;
            }
            
            goto label_71;
            label_59:
            if(GameConnect.丆丁上丟丛业丄丅丝() == false)
            {
                goto label_74;
            }
            
            val_69 = null;
            val_69 = null;
            val_70 = null;
            if(丘丑丅三丆丑丌且丝() != 1)
            {
                    val_71 = null;
                val_72 = 丘丑丅三丆丑丌且丝();
            }
            else
            {
                    val_73 = null;
            }
            
            val_74 = null;
            val_74 = null;
            val_66 = NetworkStartTable.__il2cppRuntimeField_methods;
            val_67 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            val_68 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑;
            label_67:
            val_2.set_Item(key:  val_68, value:  NetworkStartTable.__il2cppRuntimeField_methods);
            label_74:
            val_75 = 1152921504689381376;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_26 = null;
            val_51 = val_26;
            val_26 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_26.set_Item(key:  "points", value:  下丝丘丁专丐丅丛丝);
            val_26.set_Item(key:  "kills", value:  val_50);
            val_76 = null;
            val_76 = null;
            val_77 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_77 != null)
            {
                    val_77 = GameConnect.丈丝丂丐丟万丙丑丕;
                if(val_77 == null)
            {
                    val_77 = 0;
            }
            
                val_26.set_Item(key:  "brawlId", value:  val_77.业上丙丞丐丄丆丅七());
            }
            
            val_78 = null;
            val_78 = null;
            if(GameController.丆丘丂丈世丏丟丑丏 != 0)
            {
                    val_80 = null;
                val_80 = null;
                if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_29 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                val_29.set_Item(key:  "t_b", value:  丕丈一丐丛世丆上万.丗丛世世丙丝丌与丑);
                int val_48 = 丕丈一丐丛世丆上万.丗丛世世丙丝丌与丑;
                val_48 = 丕丈一丐丛世丆上万.丙东与与万丌丟专丛 - val_48;
                val_29.set_Item(key:  "t_c", value:  val_48);
                val_29.set_Item(key:  "l", value:  268435468);
                val_26.set_Item(key:  "competition_stats", value:  val_29);
            }
            
            }
            
            val_81 = null;
            val_81 = null;
            if(SquadController.丄丘七三上丕世丞业 == 0)
            {
                goto label_118;
            }
            
            val_82 = null;
            val_82 = null;
            if(SquadController.丄丘七三上丕世丞业.丛丟万丅与丐万东丆() >= 2)
            {
                goto label_122;
            }
            
            label_118:
            val_26.set_Item(key:  "in_squad", value:  null);
            val_26.set_Item(key:  "in_clan_squad", value:  null);
            val_83 = null;
            goto label_125;
            label_122:
            val_26.set_Item(key:  "in_squad", value:  true);
            val_85 = null;
            val_85 = null;
            val_26.set_Item(key:  "in_clan_squad", value:  SquadController.丄丘七三上丕世丞业.IsClanSquad);
            val_75 = 1152921504689381376;
            val_83 = null;
            label_125:
            val_26.set_Item(key:  "squad_size", value:  SquadController.丄丘七三上丕世丞业.丛丟万丅与丐万东丆());
            if(GameConnect.丑丌丛丈丅丅与不业() == 30)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_36 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                val_52 = 万三丟世三一不专丛;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                val_36.set_Item(key:  "ending", value:  万三丟世三一不专丛.ToString());
                val_26.set_Item(key:  "among_stats", value:  val_36);
            }
            
            val_86 = null;
            val_86 = null;
            val_87 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_87 != null)
            {
                    val_87 = GameConnect.丈丝丂丐丟万丙丑丕;
                if(val_87 == null)
            {
                    val_87 = 0;
            }
            
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_38 = val_87.丌不丅不丞东万专专();
                if((val_38.HasValue.丙东专丂世丈丏丁丂() == 4) && (((-194827768) & 1) != 0))
            {
                    val_26.set_Item(key:  "isCompetition", value:  true);
            }
            
            }
            
            if(PGCompany.GameModeLowDeviceWarningBanner.丕丂万与与丛丈丆丈 != false)
            {
                    val_26.set_Item(key:  "bad_device", value:  UnityEngine.SystemInfo.deviceModel);
            }
            
            val_26.set_Item(key:  "v_ProgressRoad", value:  ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丙东丛丈东丑丈东一());
            PGCompany.丗三万丁三丗上专丟 val_43 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_43 != null)
            {
                    PGCompany.丅七丗世三丙丂丑丙 val_44 = val_43.世丈丁业丛上丘丗丐();
                val_88 = val_44.Version;
            }
            
            val_26.set_Item(key:  "v_Tutorial", value:  val_88);
            int val_47 = (Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  78)) + 1;
            val_49 = val_47;
            val_26.set_Item(key:  "countMatches", value:  val_47);
            PGCompany.Analytics.一业丗丆世世上丁且.丞不业万丕丞东东业(七丏丄丅丌业与且丙:  new 专不世七世三且丏丌());
        }
        internal static void 丝丟且丟三丘丟丛丗(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, ref System.Nullable<丟与丁丑丗下丐丛一> 丙七七丈丐且一丟业)
        {
            object val_8;
            var val_9;
            string val_11;
            string val_19;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            int val_27;
            var val_28;
            var val_29;
            var val_30;
            val_20 = 丆丛丑世下一丐且丕;
            if((PGCompany.Analytics.一业丗丆世世上丁且.丘丂上丞下丞丕丛万(七丏丄丅丌业与且丙: out  new 专不世七世三且丏丌())) == false)
            {
                    return;
            }
            
            PGCompany.七下丐丂丙丑东专丂 val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_4 != null)
            {
                    if(val_4.丂丁丏一丙丛业且丌() >= 1)
            {
                    val_21 = null;
                val_21 = null;
                int val_6 = val_4.丂丁丏一丙丛业且丌();
                0.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  val_6);
            }
            
            }
            
            if((1152921560247077312 & 1) != 0)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                if(val_6 >= 1)
            {
                    val_22 = null;
                val_22 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丅专世世丒丈万与, value:  val_6);
            }
            
                if(0 >= 1)
            {
                    val_23 = null;
                val_23 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丕丁丙与丙丝丞上丄, value:  0);
            }
            
                if(0 >= 1)
            {
                    val_24 = null;
                val_24 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐世丑丈丟丏专专丝, value:  0);
            }
            
                if(0 >= 1)
            {
                    val_25 = null;
                val_25 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丕世七丂丗专丝上丕, value:  0);
            }
            
                if(0 >= 1)
            {
                    val_7.set_Item(key:  "sniperMiniGameCurrency", value:  0);
            }
            
                if(0 >= 1)
            {
                    val_7.set_Item(key:  "clanMedals", value:  0);
            }
            
                if(val_8 >= 1)
            {
                    val_26 = null;
                val_26 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丏不丆世丐上与七, value:  val_8);
            }
            
                if(val_9 != 0)
            {
                    val_27 = val_9.Id;
                if(val_27 == null)
            {
                    val_27 = System.String.alignConst;
            }
            
                val_7.set_Item(key:  "rewardItem", value:  val_27);
            }
            
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) != true)
            {
                    val_7.set_Item(key:  "moduleChests", value:  val_11);
            }
            
                val_7.set_Item(key:  "trophies", value:  0);
                val_28 = null;
                val_28 = null;
                0.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_7);
            }
            
            if(丆丛丑世下一丐且丕.且三丛与丄丈三东丞 >= 1)
            {
                    val_29 = null;
                val_29 = null;
                0.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三专丞丄东丂丟七与, value:  丆丛丑世下一丐且丕.且三丛与丄丈三东丞);
            }
            
            if(GameConnect.丌不不丑业业丌业下() == 3)
            {
                    GameConnect.丘丕丈丄丛业东丈丝(丙业与丙丗丝不丈东:  2);
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            0.丐丏七丌丕丗业且上().set_Item(key:  "start_fight_type", value:  GameConnect.丌不不丑业业丌业下().ToString());
            val_30 = null;
            val_30 = null;
            val_19 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅;
            0.set_Item(key:  val_19, value:  0.丐丏七丌丕丗业且上());
            val_20.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  53, 丗丟上上丒丐丗丞丙:  0);
            val_20;
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  0);
        }
        internal static void 丆丛业上丛丒三丆丗(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅 三丂丞丒一与且丈丆, int 下丝丘丁专丐丅丛丝 = 0, int 丞丗丄七专丈丕丕业 = 0)
        {
            var val_24;
            int val_25;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_26;
            var val_27;
            var val_28;
            var val_29;
            int val_30;
            var val_31;
            var val_32;
            int val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            val_25 = 下丝丘丁专丐丅丛丝;
            val_26 = 丆丛丑世下一丐且丕;
            if((PGCompany.Analytics.一业丗丆世世上丁且.丘丂上丞下丞丕丛万(七丏丄丅丌业与且丙: out  new 专不世七世三且丏丌())) == false)
            {
                    return;
            }
            
            PGCompany.七下丐丂丙丑东专丂 val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_4 != null)
            {
                    if(val_4.丂丁丏一丙丛业且丌() >= 1)
            {
                    val_27 = null;
                val_27 = null;
                0.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  val_4.丂丁丏一丙丛业且丌());
            }
            
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(三丂丞丒一与且丈丆.下丅丌丌丆不东专丁.丆丒丘丐下丞丛上丈() >= 1)
            {
                    val_28 = null;
                val_28 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丅专世世丒丈万与, value:  三丂丞丒一与且丈丆.下丅丌丌丆不东专丁.丆丒丘丐下丞丛上丈());
            }
            
            if(1152921560247436096 >= 1)
            {
                    val_29 = null;
                val_29 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丕丁丙与丙丝丞上丄, value:  1152921560247436096);
            }
            
            val_30 = 三丂丞丒一与且丈丆.下丅丌丌丆不东专丁;
            if(val_30 >= 1)
            {
                    val_31 = null;
                val_31 = null;
                val_30 = 三丂丞丒一与且丈丆.下丅丌丌丆不东专丁;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐世丑丈丟丏专专丝, value:  val_30);
            }
            
            if(1152921560247436096 >= 1)
            {
                    val_32 = null;
                val_32 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丕世七丂丗专丝上丕, value:  1152921560247436096);
            }
            
            if(三丂丞丒一与且丈丆.丌丙专丗丏不丐丗丅 >= 1)
            {
                    val_7.set_Item(key:  "clanMedals", value:  三丂丞丒一与且丈丆.丌丙专丗丏不丐丗丅);
            }
            
            val_33 = 三丂丞丒一与且丈丆.上丛丕丙三丁专下丂;
            if(val_33 >= 1)
            {
                    val_34 = null;
                val_34 = null;
                val_33 = 三丂丞丒一与且丈丆.上丛丕丙三丁专下丂;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丏不丆世丐上与七, value:  val_33);
            }
            
            if(三丂丞丒一与且丈丆.丏且丕丄丁丟丆丏丁 == null)
            {
                goto label_32;
            }
            
            string val_10 = 三丂丞丒一与且丈丆.丏且丕丄丁丟丆丏丁.Id;
            if(val_10 == null)
            {
                goto label_33;
            }
            
            label_75:
            val_7.set_Item(key:  "rewardItem", value:  val_10);
            label_32:
            if((三丂丞丒一与且丈丆.上丁丗丐丝丛丝世丂 != null) && (三丂丞丒一与且丈丆.上丁丗丐丝丛丝世丂.丈丄丈丛世丈专与丘 != null))
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  三丂丞丒一与且丈丆.上丁丗丐丝丛丝世丂.丈丄丈丛世丈专与丘.业上丙丞丐丄丆丅七())) != true)
            {
                    val_7.set_Item(key:  "moduleChests", value:  三丂丞丒一与且丈丆.上丁丗丐丝丛丝世丂.丈丄丈丛世丈专与丘.业上丙丞丐丄丆丅七());
            }
            
            }
            
            val_7.set_Item(key:  "trophies", value:  0);
            val_35 = null;
            val_35 = null;
            0.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_7);
            0.丐丏七丌丕丗业且上().set_Item(key:  "points", value:  val_25);
            0.丐丏七丌丕丗业且上().set_Item(key:  "kills", value:  丞丗丄七专丈丕丕业);
            val_24 = 1152921505066536960;
            if(GameConnect.丌不不丑业业丌业下() == 3)
            {
                    GameConnect.丘丕丈丄丛业东丈丝(丙业与丙丗丝不丈东:  2);
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            0.丐丏七丌丕丗业且上().set_Item(key:  "start_fight_type", value:  GameConnect.丌不不丑业业丌业下().ToString());
            if(GameConnect.丈丝丂丐丟万丙丑丕 != null)
            {
                    val_36 = null;
                val_36 = null;
                0.丐丏七丌丕丗业且上().set_Item(key:  "brawlId", value:  GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七());
            }
            
            val_37 = null;
            val_37 = null;
            val_25 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅;
            0.set_Item(key:  val_25, value:  0.丐丏七丌丕丗业且上());
            if(丆丛丑世下一丐且丕.且三丛与丄丈三东丞 >= 1)
            {
                    val_38 = null;
                val_38 = null;
                val_25 = PGCompany.Analytics.丂与丏丕一丒与丁丙.三专丞丄东丂丟七与;
                0.set_Item(key:  val_25, value:  丆丛丑世下一丐且丕.且三丛与丄丈三东丞);
            }
            
            val_26.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  53, 丗丟上上丒丐丗丞丙:  0);
            val_26;
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  0);
            return;
            label_33:
            if(val_7 != null)
            {
                goto label_75;
            }
            
            goto label_75;
        }
        internal static void 丏丆丘丑丕丙丏丙丐(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, System.ValueTuple<int, int> 丐丙丛丐丑与丏丂上)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4;
            var val_5;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_4 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
            val_5 = null;
            val_5 = null;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丐丙丛丐丑与丏丂上.Item2);
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  丐丙丛丐丑与丏丂上.Item2 >> 32);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  52, 丗丟上上丒丐丗丞丙:  val_4);
        }
        internal static void 丘丘世丕专专丞丁丆(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.Analytics.与丌丛一丆丈丂业丂 与丂丒丄丟丌丆丁丕)
        {
            null = null;
            if((与丂丒丄丟丌丆丁丕 == 3) && (PGCompany.Analytics.一业丗丆世世上丁且.丕丂丒丁丆丈万丈丘 == 2))
            {
                    return;
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丗丝丑丐上丘与业七(与丂丒丄丟丌丆丁丕:  与丂丒丄丟丌丆丁丕);
        }
        internal static void 丐丞一丆丕丈七丄丄(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.Analytics.与丌丛一丆丈丂业丂 与丂丒丄丟丌丆丁丕)
        {
            PGCompany.Analytics.一业丗丆世世上丁且.万丒业丄且丝丂丘万(与丂丒丄丟丌丆丁丕:  与丂丒丄丟丌丆丁丕);
        }
        internal static void 三丗丑丑且丕丌三丄(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, System.Collections.Generic.List<Rilisoft.DroppedItemData> 丑七不与丛丆一丂丞, int 丐东业丕丕丂丗丅丙, 丈丞丕丘丕丗与上一 丏业丂七丈丆丛丏上, bool 丄世不下专七丂丘丝, bool 丌丈世丘与丘丆丌丗)
        {
            bool val_19;
            string val_20;
            int val_21;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_29;
            val_19 = 丌丈世丘与丘丆丌丗;
            val_20 = 丏业丂七丈丆丛丏上;
            val_21 = 丐东业丕丕丂丗丅丙;
            val_22 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_23 = null;
            val_23 = null;
            val_21 = val_21;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_21);
            if(丄世不下专七丂丘丝 != true)
            {
                    val_24 = null;
                val_24 = null;
                int val_3 = val_20.丟丂丞不专丆万丒世();
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_3);
            }
            
            val_25 = null;
            val_25 = null;
            val_20 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_2.set_Item(key:  val_20, value:  val_19);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = null;
            val_19 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            List.Enumerator<T> val_6 = 丑七不与丛丆一丂丞.GetEnumerator();
            val_26 = 1152921516630043280;
            label_34:
            if(((-193307360) & 1) == 0)
            {
                goto label_18;
            }
            
            string val_8 = val_3.丐丏七丌丕丗业且上();
            string val_9 = val_20.Id;
            if((val_5.ContainsKey(key:  val_9)) == false)
            {
                goto label_22;
            }
            
            object val_12 = val_5.Item[val_9.Id];
            val_21 = 1152921542706367968;
            val_26 = 1152921516595677584;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_12);
            val_5.set_Item(key:  val_8.Id, value:  val_12.Count + 1152921504628731904);
            goto label_34;
            label_22:
            val_5.Add(key:  val_9.Id, value:  val_8.Count);
            goto label_34;
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_27 = 1152921505690869760;
            val_22 = val_22;
            val_29 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_5);
            丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  101, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丗丌丒且万万丁专丞(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, System.Collections.Generic.List<Rilisoft.DroppedItemData> 丑七不与丛丆一丂丞, int 丐东业丕丕丂丗丅丙, 丈丞丕丘丕丗与上一 丏业丂七丈丆丛丏上)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_19;
            int val_20;
            var val_21;
            var val_22;
            object val_23;
            string val_24;
            object val_25;
            val_20 = 丑七不与丛丆一丂丞;
            val_21 = 丆丛丑世下一丐且丕;
            PGCompany.Analytics.与丌丛一丆丈丂业丂 val_12 = 0;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_22 = 1152921504622075904;
            val_19 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_19.set_Item(key:  "chestId", value:  丐东业丕丕丂丗丅丙);
            if((val_20 == null) || (val_20.Count < 1))
            {
                goto label_8;
            }
            
            int val_5 = val_20.Count;
            val_23 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            List.Enumerator<T> val_6 = val_20.GetEnumerator();
            label_18:
            if(((-193034208) & 1) == 0)
            {
                goto label_12;
            }
            
            string val_8 = 丐东业丕丕丂丗丅丙.丐丏七丌丕丗业且上();
            if(((val_8 == null) || (val_8 == null)) || (val_8.Id == null))
            {
                goto label_18;
            }
            
            val_23.Add(item:  val_8.Id);
            goto label_18;
            label_8:
            val_19.set_Item(key:  "reward", value:  PGCompany.东丑丒丗一丞下丙丙<System.String>.丐与丐下丅丙丕丘丄());
            val_23 = 0;
            goto label_22;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_22 = 1152921504622075904;
            val_19.set_Item(key:  "reward", value:  val_23);
            label_22:
            if((PGCompany.Analytics.一业丗丆世世上丁且.专丕丂三一丁不一丄(与丂丒丄丟丌丆丁丕: out  val_12)) == false)
            {
                goto label_33;
            }
            
            if(val_12 == 3)
            {
                goto label_34;
            }
            
            if(val_12 == 2)
            {
                goto label_35;
            }
            
            if(val_12 != 1)
            {
                goto label_36;
            }
            
            val_24 = "kind";
            val_25 = "free";
            goto label_53;
            label_33:
            val_24 = "kind";
            val_25 = "unknown";
            label_53:
            label_55:
            val_19.set_Item(key:  val_24, value:  val_25);
            if(丏业丂七丈丆丛丏上 != null)
            {
                    int val_14 = 丏业丂七丈丆丛丏上.丟丂丞不专丆万丒世();
                val_20 = val_14;
                val_19.set_Item(key:  "priceAmount", value:  val_14);
                val_19.set_Item(key:  "priceCurrency", value:  丏业丂七丈丆丛丏上.东与三丌丅三丒丏业());
            }
            
            val_21.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  101, 丗丟上上丒丐丗丞丙:  val_19);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_19);
            if(val_23 == null)
            {
                    return;
            }
            
            val_21 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            return;
            label_34:
            if(val_19 != null)
            {
                goto label_53;
            }
            
            goto label_53;
            label_35:
            if(val_19 != null)
            {
                goto label_53;
            }
            
            goto label_53;
            label_36:
            string val_17 = "unexpected-"("unexpected-") + val_12;
            if(val_19 != null)
            {
                goto label_55;
            }
            
            goto label_55;
        }
        internal static void 专丅丑且业丂专不丌(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, System.Collections.Generic.List<Rilisoft.DroppedItemData> 丑七不与丛丆一丂丞, int 丐东业丕丕丂丗丅丙, 丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三, Rilisoft.与专丒丞丐一丒丂东 丐下丝丘丑丟丟丗丌, int 丅且三万丘丙业丙丗)
        {
            int val_13;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_27;
            int val_28;
            string val_29;
            int val_30;
            var val_31;
            var val_32;
            val_28 = 丅且三万丘丙业丙丗;
            val_29 = 丐下丝丘丑丟丟丗丌;
            val_30 = 丐东业丕丕丂丗丅丙;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_31 = null;
            val_31 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_30);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  万丐丏丐丒万不丟三.丟丂丞不专丆万丒世());
            Rilisoft.DroppedItemData val_4 = 丑七不与丛丆一丂丞.Item[0];
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_4.ItemData.Count);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_28);
            Rilisoft.DroppedItemData val_6 = 丑七不与丛丆一丂丞.Item[0];
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_6.ItemData.Id);
            Rilisoft.DroppedItemData val_8 = 丑七不与丛丆一丂丞.Item[0];
            val_30 = val_8.DropCategory.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            mem2[0] = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_30);
            System.Collections.Generic.List<System.String> val_10 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_11 = val_29.GetEnumerator();
            label_40:
            if(((-192717408) & 1) == 0)
            {
                goto label_27;
            }
            
            string val_14 = val_13.丐丏七丌丕丗业且上();
            if(((val_29.万丐丘丟丂丛丂丈万().Contains(item:  val_14.Id)) == false) || (val_14.AvailableToDropItems.Count < 1))
            {
                goto label_40;
            }
            
            Rilisoft.GameEventItemData val_22 = val_14.AvailableToDropItems.Item[0].Data;
            if(val_22 == null)
            {
                goto label_40;
            }
            
            val_13 = val_22.Count;
            val_10.Add(item:  System.String.Format(format:  "{0}_{1}", arg0:  val_22.Id, arg1:  val_13));
            goto label_40;
            label_27:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_28 = 1152921516595668352;
            val_32 = null;
            val_32 = null;
            val_27 = 丆丛丑世下一丐且丕;
            val_29 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_29, value:  val_10);
            val_27.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  102, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 七一丐东丘丏丌丗一(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, System.Collections.Generic.List<Rilisoft.DroppedItemData> 丑七不与丛丆一丂丞, int 丐东业丕丕丂丗丅丙, 丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_18;
            object val_19;
            var val_20;
            var val_21;
            var val_22;
            object val_23;
            string val_24;
            object val_25;
            var val_26;
            val_19 = 丑七不与丛丆一丂丞;
            val_20 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_21 = 1152921505690550272;
            val_22 = 1152921504622075904;
            val_18 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_18.set_Item(key:  "id", value:  丐东业丕丕丂丗丅丙);
            if((val_19 == null) || (val_19.Count < 1))
            {
                goto label_8;
            }
            
            int val_5 = val_19.Count;
            val_23 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            List.Enumerator<T> val_6 = val_19.GetEnumerator();
            label_18:
            if(((-192404704) & 1) == 0)
            {
                goto label_12;
            }
            
            string val_8 = 丐东业丕丕丂丗丅丙.丐丏七丌丕丗业且上();
            if(((val_8 == null) || (val_8 == null)) || (val_8.Id == null))
            {
                goto label_18;
            }
            
            val_23.Add(item:  val_8.Id);
            goto label_18;
            label_8:
            val_18.set_Item(key:  "reward", value:  PGCompany.东丑丒丗一丞下丙丙<System.String>.丐与丐下丅丙丕丘丄());
            val_23 = 0;
            goto label_22;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_22 = 1152921504622075904;
            val_18.set_Item(key:  "reward", value:  val_23);
            val_21 = 1152921505690550272;
            label_22:
            if(val_19 != null)
            {
                    if(val_19.Count >= 1)
            {
                    val_19 = val_19.Item[0];
            }
            
            }
            
            if(((-192404676) & 1) == 0)
            {
                goto label_34;
            }
            
            val_19;
            val_24 = "kind";
            if((val_19 & 1) == 0)
            {
                goto label_36;
            }
            
            val_25 = "free";
            goto label_37;
            label_34:
            val_24 = "kind";
            val_26 = "unknown";
            goto label_39;
            label_36:
            val_25 = "paid";
            label_37:
            label_39:
            val_18.set_Item(key:  val_24, value:  val_25);
            if(万丐丏丐丒万不丟三 != null)
            {
                    int val_14 = 万丐丏丐丒万不丟三.丟丂丞不专丆万丒世();
                val_19 = val_14;
                val_18.set_Item(key:  "priceAmount", value:  val_14);
                val_18.set_Item(key:  "priceCurrency", value:  万丐丏丐丒万不丟三.东与三丌丅三丒丏业());
            }
            
            val_20.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  102, 丗丟上上丒丐丗丞丙:  val_18);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_18);
            if(val_23 == null)
            {
                    return;
            }
            
            val_20 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
        }
        internal static void 丏专上丗业丒丅丏丕(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, GiftController.丆三丄且下丏丐丒丝 与丄不丌一世东丁丙, int 丏业丂七丈丆丛丏上, string 丁丅丈丌丟世丗丗丟)
        {
            int val_7;
            string val_8;
            var val_9;
            val_7 = 丏业丂七丈丆丛丏上;
            val_8 = 与丄不丌一世东丁丙;
            PGCompany.Analytics.与丌丛一丆丈丂业丂 val_2 = 0;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            bool val_7 = PGCompany.Analytics.一业丗丆世世上丁且.与丙丙丘七丕且专丐(与丂丒丄丟丌丆丁丕: out  val_2);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_9 = null;
            val_9 = null;
            val_7 = val_7 & ((val_2 == 2) ? 1 : 0);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_7);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_7);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_8.丂丁丏一丙丛业且丌());
            val_7 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_5.set_Item(key:  val_7, value:  与丄不丌一世东丁丙.下丄丈不与世丐业专);
            val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_5.set_Item(key:  val_8, value:  丁丅丈丌丟世丗丗丟);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  105, 丗丟上上丒丐丗丞丙:  val_5);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_5);
        }
        internal static void 丕上业与丗且丐下万(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, SlotInfo 与丄不丌一世东丁丙, bool 与丛丘上丛丝下丟丏, int 丏业丂七丈丆丛丏上)
        {
            int val_7;
            object val_8;
            var val_9;
            var val_10;
            var val_11;
            string val_12;
            object val_13;
            val_7 = 丏业丂七丈丆丛丏上;
            val_8 = 与丛丘上丛丝下丟丏;
            PGCompany.Analytics.与丌丛一丆丈丂业丂 val_3 = 0;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_7 = val_7;
            val_2.set_Item(key:  "spinPrice", value:  val_7);
            if((与丄不丌一世东丁丙 != null) && (与丄不丌一世东丁丙.gift != null))
            {
                    val_2.set_Item(key:  "reward", value:  与丄不丌一世东丁丙.gift.Id);
            }
            
            if((PGCompany.Analytics.一业丗丆世世上丁且.与丙丙丘七丕且专丐(与丂丒丄丟丌丆丁丕: out  val_3)) == false)
            {
                goto label_12;
            }
            
            if(val_3 == 3)
            {
                goto label_13;
            }
            
            if(val_3 == 2)
            {
                goto label_14;
            }
            
            if(val_3 != 1)
            {
                goto label_15;
            }
            
            val_9 = "kind";
            val_10 = "free";
            goto label_21;
            label_12:
            val_8 = "kind";
            val_11 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            val_12 = val_8;
            val_13 = (val_8 != true) ? "paid" : "free";
            goto label_23;
            label_13:
            val_9 = "kind";
            val_10 = "paid";
            goto label_21;
            label_14:
            val_9 = "kind";
            val_10 = "rewardedVideo";
            label_21:
            val_11 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            goto label_23;
            label_15:
            val_8 = "unexpected-"("unexpected-") + val_3;
            val_11 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            val_13 = val_8;
            val_12 = "kind";
            label_23:
            val_2.set_Item(key:  val_12, value:  val_13);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  105, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丈上丑丗丆丆丞丐万(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 世专丑与丞丞与丙丂, int 丄东世不与不丐不专, int 与丕丒丗一万丒丆丑, string 丏七丙不丁丁丒丒丗, int 丅且三万丘丙业丙丗)
        {
            int val_3;
            int val_4;
            var val_5;
            val_3 = 丅且三万丘丙业丙丗;
            val_4 = 丄东世不与不丐不专;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  世专丑与丞丞与丙丂);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_3, value:  丏七丙不丁丁丒丒丗);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  106, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丛丏丞丏丑丞丅万七(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丞丅上丏丂且下丅与, int 丅且三万丘丙业丙丗, 丈丞丕丘丕丗与上一 三丝专与万丟上丘下, int 世专丑与丞丞与丙丂, System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 丑七不与丛丆一丂丞)
        {
            object val_17;
            int val_18;
            int val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_17 = 三丝专与万丟上丘下;
            val_18 = 丅且三万丘丙业丙丗;
            val_19 = 丞丅上丏丂且下丅与;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_20 = null;
            val_20 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_19);
            val_19 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_2.set_Item(key:  val_19, value:  世专丑与丞丞与丙丂);
            val_18 = val_18;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_18);
            if(val_17 != null)
            {
                    val_21 = null;
                val_21 = null;
                val_18 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
                int val_3 = val_17.丟丂丞不专丆万丒世();
                val_17 = val_3;
                val_2.set_Item(key:  val_18, value:  val_3);
            }
            
            if(丑七不与丛丆一丂丞.Count < 1)
            {
                goto label_16;
            }
            
            System.Collections.Generic.List<System.String> val_5 = null;
            val_17 = val_5;
            val_5 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_6 = 丑七不与丛丆一丂丞.GetEnumerator();
            val_19 = 1152921542835047760;
            label_26:
            if(((-191616640) & 1) == 0)
            {
                goto label_18;
            }
            
            string val_8 = val_3.丐丏七丌丕丗业且上();
            val_5.Add(item:  System.String.Format(format:  "{0}_{1}", arg0:  val_8.丙业丈专万下丄丙丏().Data.Id, arg1:  val_8.丙业丈专万下丄丙丏().Data.Count));
            goto label_26;
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_18 = 1152921516595668352;
            val_22 = 1152921505690869760;
            val_23 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_5);
            label_16:
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  104, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丁丗丈丞丒世下丟丑(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丞丅上丏丂且下丅与, 丈丞丕丘丕丗与上一 三丝专与万丟上丘下)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_5 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_5.set_Item(key:  "id", value:  丞丅上丏丂且下丅与);
            if(三丝专与万丟上丘下 != null)
            {
                    val_5.set_Item(key:  "resetPriceAmount", value:  三丝专与万丟上丘下.丟丂丞不专丆万丒世());
                val_5.set_Item(key:  "resetPriceCurrency", value:  三丝专与万丟上丘下.东与三丌丅三丒丏业());
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  104, 丗丟上上丒丐丗丞丙:  val_5);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_5);
        }
        internal static void 丙东丗丏丏丑丗丄丁(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, System.Collections.Generic.List<int> 丒业七丒丞丁万丝丐)
        {
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            if(丒业七丒丞丁万丝丐 == null)
            {
                goto label_6;
            }
            
            label_13:
            val_2.set_Item(key:  "excludedItems", value:  丒业七丒丞丁万丝丐);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
            return;
            label_6:
            T[] val_3 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.丐与丐下丅丙丕丘丄();
            if(val_2 != null)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        internal static void 一万丂不专业丑丛丞(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, bool 下万丒专一与且丈丞, int 一丌与丅丈万丁业万, int 丆业三丂丞且丙七丒, System.Collections.Generic.Dictionary<string, int> 丝不下丏丞且上丒丆)
        {
            bool val_6;
            int val_12;
            bool val_13;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_14;
            var val_15;
            var val_16;
            int val_17;
            int val_18;
            var val_19;
            val_12 = 丆业三丂丞且丙七丒;
            val_13 = 下万丒专一与且丈丞;
            val_14 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = null;
            val_12 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            Dictionary.Enumerator<TKey, TValue> val_3 = 丝不下丏丞且上丒丆.GetEnumerator();
            label_7:
            if(((-191029456) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            val_2.set_Item(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  -191029472);
            goto label_7;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_15 = null;
            val_15 = null;
            val_6 = val_13;
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_6);
            val_16 = null;
            val_17 = 一丌与丅丈万丁业万;
            val_18 = val_12;
            val_19 = 1152921505690550272;
            val_14 = val_14;
            val_13 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_9.set_Item(key:  val_13, value:  null);
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  null);
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_2);
            val_14.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  1016, 丗丟上上丒丐丗丞丙:  val_9);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_9);
        }
        internal static void 万丈丂丝丕丅丝下丑(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 与不东丐丘且丒世丁, int 三丞一专不丘与一三, int 三世丞丆下丑丈丂丟)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
            int val_8;
            var val_9;
            val_8 = 与不东丐丘且丒世丁;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_7 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_9 = null;
            val_9 = null;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_8);
            val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_7.set_Item(key:  val_8, value:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  丌丅且丗七丘丅丛丑.丕丅丒世丑丅丈七七(专世专丟丝丌与丘上:  三丞一专不丘与一三)));
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  丌丅且丗七丘丅丛丑.丕丅丒世丑丅丈七七(专世专丟丝丌与丘上:  三世丞丆下丑丈丂丟)));
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  249, 丗丟上上丒丐丗丞丙:  val_7);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_7);
        }
        internal static void 万业丑丌与丙丅下丆(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丅丈丌丟世丗丗丟, string 且下丕七丙丗丄不七, string 下丗丁丒丘东丂不丑, string 丟下丟丈万一丙东丄)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3;
            object val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_4 = 且下丕七丙丗丄不七;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_5 = null;
            val_5 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丁丅丈丌丟世丗丗丟);
            if(val_4 != null)
            {
                    val_6 = null;
                val_6 = null;
                val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_4);
            }
            
            if(下丗丁丒丘东丂不丑 != null)
            {
                    val_7 = null;
                val_7 = null;
                val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
                val_3.set_Item(key:  val_4, value:  下丗丁丒丘东丂不丑);
            }
            
            if(丟下丟丈万一丙东丄 != null)
            {
                    val_8 = null;
                val_8 = null;
                val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  丟下丟丈万一丙东丄);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  239, 丗丟上上丒丐丗丞丙:  val_3);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_3);
        }
        internal static void 东上丗东不丈东丑丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 世丁丙世丄一万丆三, PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
        {
            object val_9;
            object val_12;
            var val_13;
            string val_14;
            var val_15;
            var val_16;
            val_12 = 世丁丙世丄一万丆三;
            if(丐丆丝业丙丈下世丁 == null)
            {
                    return;
            }
            
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            TagSystem.三与下丘七丘丌丏丄 val_2 = 丐丆丝业丙丈下世丁.与不丞丑七丘丁丂丛();
            if(val_2 == null)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            val_14 = val_2.丘下丗丘业且七七丞(丆万一不丌且东丐丐:  PGCompany.MainStore.丆丝且丙世丕且世丈.下丒七世丝业一丒丁);
            if(val_14 == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_15 = null;
            val_15 = null;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丐丆丝业丙丈下世丁.丂丁丏一丙丛业且丌());
            TagSystem.且丝一丙丂七丂专丑 val_7 = 丐丆丝业丙丈下世丁.与不丞丑七丘丁丂丛().万丞丁且丕丅丅丐丆(丆万一不丌且东丐丐:  val_14);
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_9);
            val_14 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_4.set_Item(key:  val_14, value:  val_12);
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_10 = PGCompany.Analytics.一业丗丆世世上丁且.丏丁一丒下丝丄丛丄(丈丄不七三万丄丁不:  丐丆丝业丙丈下世丁);
            if(val_10 != null)
            {
                    val_16 = null;
                val_16 = null;
                val_12 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
                val_4.set_Item(key:  val_12, value:  val_10);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  1008, 丗丟上上丒丐丗丞丙:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_4);
        }
        internal static void 七丄且丐丅世丂丘丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕)
        {
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  5, 丗丟上上丒丐丗丞丙:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        }
        internal static void 丐丆一不万丑业丝不(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丂丕与丁丒丕丟丞)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3;
            var val_4;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_4 = null;
            val_4 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丁丂丕与丁丒丕丟丞);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  4, 丗丟上上丒丐丗丞丙:  val_3);
        }
        internal static void 丌丙丛丛丆东丙丁丛(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 七与东丙专丕丏丅丛, string 丏世丐丄东丂丛下世, string 丞与业丝丟丒与丞专, string 丗万不丁且上与丏万)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3;
            object val_4;
            var val_5;
            val_4 = 丞与业丝丟丒与丞专;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_5 = null;
            val_5 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  七与东丙专丕丏丅丛);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丏世丐丄东丂丛下世);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
            val_3.set_Item(key:  val_4, value:  丗万不丁且上与丏万);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  251, 丗丟上上丒丐丗丞丙:  val_3);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_3);
        }
        internal static void 丙丄世丄万丂一丒世(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 专世专丟丝丌与丘上, int 丙丑七万丆万丆且丌, string 世丁丙世丄一万丆三)
        {
            var val_2;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_2 = null;
            val_2 = null;
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  专世专丟丝丌与丘上);
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  丙丑七万丆万丆且丌);
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  世丁丙世丄一万丆三);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  226, 丗丟上上丒丐丗丞丙:  val_1);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_1);
        }
        internal static void 丗丞丘丆丝丐丘不丞(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 与不东丐丘且丒世丁, int 三世丞丆下丑丈丂丟, System.Collections.Generic.Dictionary<string, int> 上业丟世三与七七三)
        {
            int val_9;
            int val_10;
            var val_11;
            var val_12;
            var val_13;
            val_9 = 三世丞丆下丑丈丂丟;
            val_10 = 与不东丐丘且丒世丁;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_11 = null;
            val_11 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_10);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  丌丅且丗七丘丅丛丑.丕丅丒世丑丅丈七七(专世专丟丝丌与丘上:  val_9)));
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_5 = null;
            val_9 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            Dictionary.Enumerator<TKey, TValue> val_6 = 上业丟世三与七七三.GetEnumerator();
            label_17:
            if(((-189592904) & 1) == 0)
            {
                goto label_15;
            }
            
            ConfiguredValueTaskAwaiter val_7 = 0.GetAwaiter();
            val_5.set_Item(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  -189592920);
            goto label_17;
            label_15:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_10 = 1152921505690869760;
            val_12 = 1152921516595668352;
            val_13 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_5);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  250, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丅世丑不丛东丙东丐(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丏丏与丗一专上丆丆, int 上丕丈丞丌丘丅不与, int 不丝三丗东丞万下丞, string 丙下不丏丅丅专丂丗, string 丁丅丈丌丟世丗丗丟, System.Collections.Generic.Dictionary<string, int> 上业丟世三与七七三)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_7;
            string val_8;
            object val_9;
            int val_10;
            var val_11;
            var val_12;
            var val_13;
            val_8 = 上业丟世三与七七三;
            val_9 = 丙下不丏丅丅专丂丗;
            val_10 = 上丕丈丞丌丘丅不与;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_11 = null;
            val_11 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丏丏与丗一专上丆丆);
            val_12 = 1152921505690869760;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_10);
            val_10 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_2.set_Item(key:  val_10, value:  不丝三丗东丞万下丞);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_9);
            val_9 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_9, value:  丁丅丈丌丟世丗丗丟);
            if(val_8 == null)
            {
                goto label_13;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            Dictionary.Enumerator<TKey, TValue> val_4 = val_8.GetEnumerator();
            val_10 = 1152921525587527728;
            val_12 = 1152921524529904288;
            label_16:
            if(((-189407176) & 1) == 0)
            {
                goto label_14;
            }
            
            ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
            val_3.set_Item(key:  val_5._value._obj.丐丏七丌丕丗业且上(), value:  -189407192);
            goto label_16;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_9 = 1152921505690869760;
            val_13 = null;
            val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_8, value:  val_3);
            label_13:
            val_7 = 丆丛丑世下一丐且丕;
            val_7.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  33, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丌丅丅丘丟丁丟丐业(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丒世丘丘上丆丝东丞, int 东丒丙丞丘万世丏下, string 专丁丅专丙丙下丂不, string 世丟万一丘丐丙丝与)
        {
            object val_3;
            int val_4;
            var val_5;
            val_3 = 专丁丅专丙丙下丂不;
            val_4 = 东丒丙丞丘万世丏下;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  4);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丒世丘丘上丆丝东丞);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_3, value:  世丟万一丘丐丙丝与);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  34, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丟丈丑丒丂丁万七上(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.BM.世丘丈丑丘万丆丞丈 丗丈丒丐丌丙丏丆世, int 不一丈丒丒丁丝三三, int 丑丄且三一东专丒世, PGCompany.三东丏不丗世丅丌丄 丟丐丟丄与丄丟丄丗, System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> 丞丕丐丛不世丟东丆)
        {
            PGCompany.三东丏不丗世丅丌丄 val_18;
            int val_19;
            int val_20;
            string val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            val_19 = 丑丄且三一东专丒世;
            val_20 = 不一丈丒丒丁丝三三;
            val_21 = 丗丈丒丐丌丙丏丆世;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_18 = val_21.丒丒与丑丏世且丂业();
            PGCompany.丗丟丄丈东丝丕丄世 val_3 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_18);
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_21.丄丏丒丞世东丗上专());
            if((val_3 == null) || (val_5 == null))
            {
                goto label_8;
            }
            
            val_19 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_22 = null;
            val_22 = null;
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_3);
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_5);
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_5);
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_20);
            if(val_21.业东丗丈丙世丟丘丟() != null)
            {
                    val_23 = null;
                val_23 = null;
                val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  val_21.业东丗丈丙世丟丘丟().丂丁丏一丙丛业且丌());
            }
            
            val_24 = null;
            val_24 = null;
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  val_19);
            val_20 = 1152921505690869760;
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_3.业上丙丞丐丄丆丅七());
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_21.业上丙丞丐丄丆丅七().ToString());
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_5.业上丙丞丐丄丆丅七());
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑, value:  val_5.不业丙丒丂丞下丆丙());
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  PGCompany.Analytics.一业丗丆世世上丁且.下东丒万丛丒三业下(三丄七丆丟下世丗丐:  丞丕丐丛不世丟东丆));
            System.Collections.Generic.Dictionary<System.String, System.Object> val_16 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_21 = "current_set";
            if(丟丐丟丄与丄丟丄丗 == 0)
            {
                goto label_32;
            }
            
            if(val_16 != null)
            {
                goto label_43;
            }
            
            label_44:
            label_43:
            val_16.Add(key:  val_21, value:  丟丐丟丄与丄丟丄丗.业上丙丞丐丄丆丅七());
            val_25 = null;
            val_25 = null;
            val_19.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅, value:  val_16);
            val_18 = 丆丛丑世下一丐且丕;
            val_18.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  212, 丗丟上上丒丐丗丞丙:  val_19);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_19);
            return;
            label_8:
            UnityEngine.Debug.LogError(message:  "fail send BM analytics for nullable item or price");
            return;
            label_32:
            if(val_16 != null)
            {
                goto label_43;
            }
            
            goto label_44;
        }
        internal static void 丞下丞丑丛丂丌丛丟(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.三东丏不丗世丅丌丄 三丝专与万丟上丘下, int 不一丈丒丒丁丝三三, System.Collections.Generic.Dictionary<string, object> 三丐万丗丏世丆三丒, System.Collections.Generic.Dictionary<string, object> 丙不丛丟丟与丂丌丌)
        {
            object val_5;
            int val_6;
            var val_7;
            var val_8;
            val_5 = 三丐万丗丏世丆三丒;
            val_6 = 不一丈丒丒丁丝三三;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            if(三丝专与万丟上丘下.业东丅东丌上丗丑不() == 2015)
            {
                    val_7 = null;
                val_7 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  三丝专与万丟上丘下.丂丁丏一丙丛业且丌());
            }
            
            val_8 = null;
            val_8 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_6);
            val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_6, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅;
            val_2.set_Item(key:  val_5, value:  丙不丛丟丟与丂丌丌);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  213, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 下七上丈与且丛与丛(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丝丛上丞七上丂丏丏, ItemRarity 丈下丑丆上丏丗丈专, int 丏丆三丗丏下丆丐下, PGCompany.一丄丗与一丗丐丙一 七丆丒与丗丌丄且丂, PGCompany.丒丘且上丟专东不丐 丅上三丏万丛七丐东, System.Collections.Generic.Dictionary<string, object> 丞丗上不丂一丘且丙, System.Collections.Generic.Dictionary<string, object> 丂丗丏丈万业丅丕且)
        {
            object val_5;
            int val_6;
            int val_7;
            var val_8;
            val_5 = 丞丗上不丂一丘且丙;
            val_6 = 丏丆三丗丏下丆丐下;
            val_7 = 丝丛上丞七上丂丏丏;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_8 = null;
            val_8 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_7);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  丈下丑丆上丏丗丈专);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_6);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  七丆丒与丗丌丄且丂.ToString());
            val_7 = 丅上三丏万丛七丐东.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_7);
            val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_6, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅;
            val_2.set_Item(key:  val_5, value:  丂丗丏丈万业丅丕且);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  214, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 东不丗丐东下一万七(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丝丛上丞七上丂丏丏, ItemRarity 丈下丑丆上丏丗丈专, int 丏丆三丗丏下丆丐下, int 丝下丗丏三丕丕下丁, PGCompany.一丄丗与一丗丐丙一 七丆丒与丗丌丄且丂, PGCompany.丒丘且上丟专东不丐 丅上三丏万丛七丐东, PGCompany.丏丌丝丕丐七丈且丒 丅丝丕专一丑三与万)
        {
            PGCompany.丏丌丝丕丐七丈且丒 val_5;
            int val_6;
            int val_7;
            var val_8;
            var val_9;
            int val_10;
            val_6 = 丏丆三丗丏下丆丐下;
            val_7 = 丝丛上丞七上丂丏丏;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_8 = null;
            val_9 = 丆丛丑世下一丐且丕;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_7);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  丈下丑丆上丏丗丈专);
            val_7 = ;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_6);
            val_5 = 丅丝丕专一丑三与万;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  丝下丗丏三丕丕下丁);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  七丆丒与丗丌丄且丂.ToString());
            val_6 = 丅上三丏万丛七丐东;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丅上三丏万丛七丐东.ToString());
            if(val_5 == 0)
            {
                goto label_19;
            }
            
            val_10 = val_5;
            if(val_10 != 0)
            {
                goto label_20;
            }
            
            label_19:
            val_10 = System.String.alignConst;
            label_20:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_10);
            val_7.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  215, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 下业丒丑七丐丂三丑(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丝丛上丞七上丂丏丏, ItemRarity 丈下丑丆上丏丗丈专, int 丏丆三丗丏下丆丐下, int 丏上丆丒与专与丐七, int 业丆丘丈丙专丂东丏, PGCompany.一丄丗与一丗丐丙一 七丆丒与丗丌丄且丂, PGCompany.丒丘且上丟专东不丐 丅上三丏万丛七丐东, string 丐丐业三丈专与丄且, System.Collections.Generic.Dictionary<string, object> 丞丗上不丂一丘且丙)
        {
            var val_5;
            int val_6;
            int val_7;
            int val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = 业丆丘丈丙专丂东丏;
            val_7 = 丏丆三丗丏下丆丐下;
            val_8 = 丝丛上丞七上丂丏丏;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_9 = null;
            val_9 = null;
            val_6 = 1152921516595668352;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_8);
            val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_8, value:  丈下丑丆上丏丗丈专);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_7);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  丏上丆丒与专与丐七);
            if(val_6 >= 1)
            {
                    val_10 = null;
                val_10 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万且丆上丝丂丁丏丄, value:  val_6);
            }
            
            val_11 = null;
            val_5 = 1152921505690550272;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  七丆丒与丗丌丄且丂.ToString());
            val_7 = 丐丐业三丈专与丄且;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丅上三丏万丛七丐东.ToString());
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_7);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  丞丗上不丂一丘且丙);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  216, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丞丏丕丅丗万丟丝丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丝丈三丐丏丐且一三, string 丈丟且丐上不世专丁)
        {
            int val_3;
            var val_4;
            val_3 = 丝丈三丐丏丐且一三;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_4 = null;
            val_4 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_3, value:  丈丟且丐上不世专丁);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  217, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 东丙丙丌业丁东东丒(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丞丒世世丁丐业与丆, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丑丟上一三业万万丏)
        {
            var val_3;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  6);
            val_3 = null;
            val_3 = null;
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丞丒世世丁丐业与丆);
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  PGCompany.Analytics.一业丗丆世世上丁且.丄专丅世万东丂丒丟(丈丄不七三万丄丁不:  丑丟上一三业万万丏));
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  229, 丗丟上上丒丐丗丞丙:  val_1);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_1);
        }
        internal static void 下丕丟丁上下丒不丛(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丛丁三世世丆七不业, int 上丕不丞丁下丛丞业, int 丗下丙丐丂世丌上与, string 丈丟且丐上不世专丁, string 丏丂不专上丘丂不丅)
        {
            object val_3;
            int val_4;
            int val_5;
            var val_6;
            val_3 = 丈丟且丐上不世专丁;
            val_4 = 丗下丙丐丂世丌上与;
            val_5 = 丛丁三世世丆七不业;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_6 = null;
            val_6 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_5, value:  上丕不丞丁下丛丞业);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_3, value:  丏丂不专上丘丂不丅);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  218, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 不丑丄东丗丏丒丂丑(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丅丈丌丟世丗丗丟, int 东丏上东丆丕丂丗不, System.Nullable<int> 丞丐丟三丌与丞上一, string 丝丏业丅丈东业丝丒, string 丄丒且丙三丆丟与丏, int 丅东下万丐丐丌丂丞, string 丒丆丘丅丁丘丐丞丈, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, string 丘丞与万丕丞丌且丝, string 东丙丒丂丈不三一丞, string 丐丅丐丐丌丅丒丛一, string 与业丒东丛世三丞世)
        {
            var val_4;
            object val_5;
            int val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_5 = 丒丆丘丅丁丘丐丞丈;
            val_6 = 东丏上东丆丕丂丗不;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丁丅丈丌丟世丗丗丟);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_6);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  丅东下万丐丐丌丂丞);
            val_5 = 丝丏业丅丈东业丝丒;
            if(((-187377560) & 1) != 0)
            {
                    val_7 = null;
                val_7 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  丞丐丟三丌与丞上一.HasValue);
            }
            
            val_8 = null;
            val_8 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丄丒且丙三丆丟与丏);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  与业丒东丛世三丞世);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_5);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  东丞丒丙世丏三下丟);
            if(丑与丂丌世丕丆一丗 != null)
            {
                    val_9 = null;
                val_9 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅, value:  丑与丂丌世丕丆一丗);
            }
            
            val_10 = null;
            val_10 = null;
            val_6 = 东丙丒丂丈不三一丞;
            System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_3 != null)
            {
                    val_3.Add(key:  "country", value:  丘丞与万丕丞丌且丝);
            }
            else
            {
                    val_3.Add(key:  "country", value:  丘丞与万丕丞丌且丝);
            }
            
            val_3.Add(key:  "send_date", value:  val_5);
            if(val_3 != null)
            {
                    val_3.Add(key:  "time_desc", value:  val_6);
            }
            else
            {
                    val_3.Add(key:  "time_desc", value:  val_6);
            }
            
            val_3.Add(key:  "ip", value:  丐丅丐丐丌丅丒丛一);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丂丄不世丁丞丛丁一, value:  val_3);
            val_4 = 1152921505690550272;
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  139, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丏丗丗丈丄丞丑东丛(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丅丈丌丟世丗丗丟, int 东丏上东丆丕丂丗不, string 丄丒且丙三丆丟与丏, int 丅东下万丐丐丌丂丞, string 丒丆丘丅丁丘丐丞丈, System.Collections.Generic.Dictionary<string, string> 东丞丒丙世丏三下丟, string 丈上丆世丘丙一三上, string 丘丞与万丕丞丌且丝, string 东丙丒丂丈不三一丞, string 丐丅丐丐丌丅丒丛一, string 与业丒东丛世三丞世)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_4;
            object val_5;
            int val_6;
            int val_7;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_8;
            var val_9;
            object val_10;
            var val_11;
            val_5 = 丈上丆世丘丙一三上;
            val_6 = 丅东下万丐丐丌丂丞;
            val_7 = 丁丅丈丌丟世丗丗丟;
            val_8 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  8);
            val_9 = null;
            val_10 = 东丞丒丙世丏三下丟;
            val_8 = 1152921516595668352;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_7);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  东丏上东丆丕丂丗不);
            val_7 = val_6;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_6);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丄丒且丙三丆丟与丏);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  与业丒东丛世三丞世);
            if(val_5 == null)
            {
                goto label_14;
            }
            
            label_22:
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_5);
            val_11 = null;
            val_11 = null;
            val_6 = 东丙丒丂丈不三一丞;
            val_5 = 丐丅丐丐丌丅丒丛一;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  null);
            System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_3 == null)
            {
                goto label_19;
            }
            
            val_3.Add(key:  "country", value:  丘丞与万丕丞丌且丝);
            goto label_20;
            label_14:
            if(val_2 != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_19:
            val_3.Add(key:  "country", value:  丘丞与万丕丞丌且丝);
            label_20:
            val_3.Add(key:  "send_date", value:  丒丆丘丅丁丘丐丞丈);
            if(val_3 != null)
            {
                    val_3.Add(key:  "time_desc", value:  val_6);
            }
            else
            {
                    val_3.Add(key:  "time_desc", value:  val_6);
            }
            
            val_3.Add(key:  "ip", value:  val_5);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丂丄不世丁丞丛丁一, value:  val_3);
            val_4 = val_8;
            val_4.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  140, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 三丑七七丅丘上丐且(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丏丌七且丆丛丁丌丑, int 东丏上东丆丕丂丗不, string 丄丒且丙三丆丟与丏, int 丅东下万丐丐丌丂丞, string 丒丆丘丅丁丘丐丞丈, string 丘丞与万丕丞丌且丝, string 东丙丒丂丈不三一丞, string 丐丅丐丐丌丅丒丛一, string 与业丒东丛世三丞世)
        {
            string val_4;
            string val_5;
            int val_6;
            int val_7;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_8;
            var val_9;
            string val_10;
            val_4 = 东丙丒丂丈不三一丞;
            val_5 = 丘丞与万丕丞丌且丝;
            val_6 = 丅东下万丐丐丌丂丞;
            val_7 = 丏丌七且丆丛丁丌丑;
            val_8 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_4 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  6);
            val_9 = null;
            val_10 = val_5;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_7);
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  东丏上东丆丕丂丗不);
            val_7 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_4.set_Item(key:  val_7, value:  val_6);
            val_5 = ;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丄丒且丙三丆丟与丏);
            val_8 = val_8;
            val_6 = 丐丅丐丐丌丅丒丛一;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  与业丒东丛世三丞世);
            System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_3 != null)
            {
                    val_3.Add(key:  "country", value:  val_5);
            }
            else
            {
                    val_3.Add(key:  "country", value:  val_5);
            }
            
            val_3.Add(key:  "send_date", value:  丒丆丘丅丁丘丐丞丈);
            if(val_3 != null)
            {
                    val_3.Add(key:  "time_desc", value:  val_4);
            }
            else
            {
                    val_3.Add(key:  "time_desc", value:  val_4);
            }
            
            val_3.Add(key:  "ip", value:  val_6);
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丂丄不世丁丞丛丁一, value:  val_3);
            val_8.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  141, 丗丟上上丒丐丗丞丙:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_4);
        }
        internal static void 万专丐丄丗丐万专丘(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, bool 丐万丗丒下七丟丁三, int 丅上丏丈专万万丘丗, int 不丟丈与世一丂东丟, string 丄丙下丝丛丒七丂丘)
        {
            bool val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = 丐万丗丒下七丟丁三;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  6);
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_5 = null;
            val_5 = null;
            val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  丅上丏丈专万万丘丗);
            if(val_4 != true)
            {
                    val_6 = null;
                val_6 = null;
                val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
                val_1.set_Item(key:  val_4, value:  不丟丈与世一丂东丟);
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄丙下丝丛丒七丂丘)) != true)
            {
                    val_7 = null;
                val_7 = null;
                val_1.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丄丙下丝丛丒七丂丘);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  142, 丗丟上上丒丐丗丞丙:  val_1);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_1);
        }
        internal static void 丆七业丐丝丘东业丈(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丟丕丐不丙七万丛三, string 丙三丅丛万七丒丏丙, string 下下丂三下丘三丞一)
        {
            string val_6;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_6 = 丟丕丐不丙七万丛三;
            val_7 = 1152921505690124288;
            val_8 = null;
            val_8 = null;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.万业与丕丂丆且东七 == false)
            {
                    return;
            }
            
            val_7 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_9 = null;
            val_9 = null;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  3);
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.上丛丛丒丌东七丕丗, value:  PixelTime.丙丅丅业丟丁世丁丗());
            if(val_6 != null)
            {
                    val_10 = null;
                val_10 = null;
                val_6 = "_" + val_6;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_6);
            }
            
            if(丙三丅丛万七丒丏丙 != null)
            {
                    val_11 = null;
                val_11 = null;
                val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
                val_7.set_Item(key:  val_6, value:  "_" + 丙三丅丛万七丒丏丙);
            }
            
            if(下下丂三下丘三丞一 != null)
            {
                    val_12 = null;
                val_12 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  "_" + 下下丂三下丘三丞一);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  142, 丗丟上上丒丐丗丞丙:  val_7);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_7);
        }
        internal static void 丂下丈丁丈丕下丑丟(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丗下一不丘丑丅业且, bool 丒丕丈丛且丕丗东丛, string 丒丘丏上丙丟丑丕丈, string 一丑丑丝丏且丂丏丘)
        {
            object val_4;
            bool val_5;
            var val_6;
            var val_7;
            val_4 = 丒丘丏上丙丟丑丕丈;
            val_5 = 丒丕丈丛且丕丗东丛;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_6 = null;
            val_6 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丗下一不丘丑丅业且);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_5);
            val_7 = null;
            val_7 = null;
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_5, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_4, value:  一丑丑丝丏且丂丏丘);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  224, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丛丄业丞与丆下丛丐(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 丗丛丙丟一丒一与丈)
        {
            object val_11;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_17;
            var val_18;
            var val_19;
            var val_20;
            System.Func<Rilisoft.OfferItem, System.String> val_22;
            var val_23;
            var val_24;
            object val_25;
            var val_26;
            var val_27;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_28;
            val_18 = 丙业丞丑七丗下丟丌;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_19 = null;
            val_19 = null;
            val_20 = null;
            val_20 = null;
            val_22 = 一业丗丆世世上丁且.<>c.<>9__142_0;
            if(val_22 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_4 = null;
                val_22 = val_4;
                val_4 = new System.Func<Rilisoft.OfferItem, System.String>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一业丗丆世世上丁且.<>c::世丌丁不丏丝且丟丄(Rilisoft.OfferItem 丄三丅七丆丛与与上));
                一业丗丆世世上丁且.<>c.<>9__142_0 = val_22;
            }
            
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  val_18.丏与丅专三丙与丘丒(), selector:  val_4))));
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_8 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            List.Enumerator<T> val_9 = 丗丛丙丟一丒一与丈.GetEnumerator();
            val_23 = 0;
            val_24 = 0;
            val_25 = 0;
            var val_16 = 0;
            label_32:
            if(((-186155696) & 1) == 0)
            {
                goto label_16;
            }
            
            List.Enumerator<T> val_14 = val_11.丐丏七丌丕丗业且上().丏与丅专三丙与丘丒().GetEnumerator();
            goto label_19;
            label_22:
            val_11 = val_25;
            val_8.set_Item(key:  val_11, value:  val_11.丐丏七丌丕丗业且上());
            label_19:
            if(((-186155728) & 1) != 0)
            {
                goto label_22;
            }
            
            val_16 = val_16 + 1;
            val_26 = val_24;
            mem2[0] = 179;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_16 == 1) || ((-186155792 + ((0 + 1)) << 2) != 179))
            {
                goto label_29;
            }
            
            var val_17 = 0;
            val_17 = val_17 ^ (val_16 >> 31);
            val_16 = val_16 + val_17;
            goto label_32;
            label_29:
            if( == 0)
            {
                goto label_32;
            }
            
            goto label_32;
            label_16:
            val_16 = val_16 + 1;
            mem2[0] = 204;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_16 == 1)
            {
                goto label_38;
            }
            
            if(( == 0) || ((-186155792 + ((0 + 1)) << 2) == 204))
            {
                goto label_49;
            }
            
            label_48:
            label_49:
            val_27 = null;
            val_28 = val_2;
            val_18 = 1152921516595668352;
            set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_8);
            val_17 = 丆丛丑世下一丐且丕;
            val_17.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  220, 丗丟上上丒丐丗丞丙:  null);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  null);
            return;
            label_38:
            if( != 0)
            {
                goto label_48;
            }
            
            goto label_49;
        }
        internal static void 丛丄业丞与丆下丛丐(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丁东丙上一丛东丛丝, System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> 且丅与业东与丈丞世)
        {
            object val_10;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_16;
            System.Collections.Generic.IEnumerable<TSource> val_17;
            var val_18;
            var val_19;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.String> val_21;
            var val_22;
            var val_23;
            object val_24;
            var val_25;
            var val_26;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_27;
            val_17 = 丁东丙上一丛东丛丝;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_18 = null;
            val_18 = null;
            val_19 = null;
            val_19 = null;
            val_21 = 一业丗丆世世上丁且.<>c.<>9__143_0;
            if(val_21 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.String> val_3 = null;
                val_21 = val_3;
                val_3 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.String>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一业丗丆世世上丁且.<>c::丐丟丆一且丟下丅一(PGCompany.三东丏不丗世丅丌丄 与丛丗丈七专上丕丏));
                一业丗丆世世上丁且.<>c.<>9__143_0 = val_21;
            }
            
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<PGCompany.三东丏不丗世丅丌丄, System.String>(source:  val_17, selector:  val_3))));
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            List.Enumerator<T> val_8 = 且丅与业东与丈丞世.GetEnumerator();
            val_22 = 0;
            val_23 = 0;
            val_24 = 0;
            var val_15 = 0;
            label_33:
            if(((-185866544) & 1) == 0)
            {
                goto label_16;
            }
            
            List.Enumerator<T> val_12 = val_10.丐丏七丌丕丗业且上().GetEnumerator();
            goto label_19;
            label_23:
            val_10 = val_24;
            val_7.set_Item(key:  val_10, value:  PGCompany.万丞丘与丕丞下万丌.七丗业万丌专七七世(丈丄不七三万丄丁不:  val_10.丐丏七丌丕丗业且上()));
            label_19:
            if(((-185866576) & 1) != 0)
            {
                goto label_23;
            }
            
            val_15 = val_15 + 1;
            val_25 = val_23;
            mem2[0] = 179;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_15 == 1) || ((-185866640 + ((0 + 1)) << 2) != 179))
            {
                goto label_30;
            }
            
            var val_16 = 0;
            val_16 = val_16 ^ (val_15 >> 31);
            val_15 = val_15 + val_16;
            goto label_33;
            label_30:
            if( == 0)
            {
                goto label_33;
            }
            
            goto label_33;
            label_16:
            val_15 = val_15 + 1;
            mem2[0] = 204;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_15 == 1)
            {
                goto label_39;
            }
            
            if(( == 0) || ((-185866640 + ((0 + 1)) << 2) == 204))
            {
                goto label_50;
            }
            
            label_49:
            label_50:
            val_26 = null;
            val_27 = val_2;
            val_17 = 1152921516595668352;
            set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_7);
            val_16 = 丆丛丑世下一丐且丕;
            val_16.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  220, 丗丟上上丒丐丗丞丙:  null);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  null);
            return;
            label_39:
            if( != 0)
            {
                goto label_49;
            }
            
            goto label_50;
        }
        internal static System.Collections.Generic.Dictionary<string, object> 下东丒万丛丒三业下(System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> 三丄七丆丟下世丗丐)
        {
            int val_4;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(三丄七丆丟下世丗丐 == null)
            {
                    return val_1;
            }
            
            List.Enumerator<T> val_2 = 三丄七丆丟下世丗丐.GetEnumerator();
            label_18:
            if(((-185611104) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "item", value:  val_5.丄丏丒丞世东丗上专().业上丙丞丐丄丆丅七());
            val_4 = val_5.丄丏丒丞世东丗上专().丂丁丏一丙丛业且丌();
            null.Add(key:  "qty", value:  val_4);
            null.Add(key:  "type", value:  val_5.丄丏丒丞世东丗上专().不业丙丒丂丞下丆丙());
            null.Add(key:  "price", value:  val_5.丂丁丏一丙丛业且丌());
            null.Add(key:  "currency", value:  val_5.业上丙丞丐丄丆丅七());
            val_1.Add(key:  val_5.业上丙丞丐丄丆丅七().ToString(), value:  null);
            goto label_18;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal static void 丐丛丒丑丄丏与丄东(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丅上三丏万丛七丐东, int 丐与丟丛丑不丆丟丞, int 丒世丘丘上丆丝东丞, int 丌丒丝东丌下丕丁丅, string 丑丅丁专丅丛丁丑且, string 丟下丟丈万一丙东丄, Rilisoft.PlayerPaymentType 七与东丙专丕丏丅丛, PGCompany.世丞上丏丗不丛上东 丙业丞丑七丗下丟丌)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_5;
            int val_6;
            int val_7;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_8;
            var val_9;
            val_6 = 丌丒丝东丌下丕丁丅;
            val_7 = 丐与丟丛丑不丆丟丞;
            val_8 = 丆丛丑世下一丐且丕;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_9 = null;
            val_9 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丅上三丏万丛七丐东);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_7);
            val_7 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_2.set_Item(key:  val_7, value:  丒世丘丘上丆丝东丞);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丐丛丑专丁下丑丙东, value:  val_6);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丑丅丁专丅丛丁丑且);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丟下丟丈万一丙东丄);
            val_6 = 七与东丙专丕丏丅丛.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_6);
            val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_8, value:  PGCompany.七丂专七丆丗不丌专.且丞丟世丁丌东丒丙(丄丘七三上丕世丞业:  丙业丞丑七丗下丟丌));
            val_5 = val_8;
            val_5.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  1, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 与丞东专丒三一专不(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 世不下丟世一丝丐丗, string 丕丆丟丘上丆丒丘不)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_3 = null;
            val_3 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丕丆丟丘上丆丒丘不);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  世不下丟世一丝丐丗);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  3, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丆丒世专丙世下丗下(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丅上三丏万丛七丐东, int 丒世丘丘上丆丝东丞, Rilisoft.PlayerPaymentType 七与东丙专丕丏丅丛, PGCompany.世丞上丏丗不丛上东 丙业丞丑七丗下丟丌)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
            int val_6;
            var val_7;
            val_6 = 丅上三丏万丛七丐东;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_5 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_7 = null;
            val_7 = null;
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_6);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  丒世丘丘上丆丝东丞);
            val_6 = 七与东丙专丕丏丅丛;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  七与东丙专丕丏丅丛.ToString());
            val_5.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  PGCompany.七丂专七丆丗不丌专.且丞丟世丁丌东丒丙(丄丘七三上丕世丞业:  丙业丞丑七丗下丟丌));
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  1, 丗丟上上丒丐丗丞丙:  val_5);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_5);
        }
        internal static void 丕万万丁专万丞世且(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丈丘丝一丗下丈丐不, int 丗与丘不且万丟丙丑, string 世丁丙世丄一万丆三)
        {
            int val_3;
            int val_4;
            var val_5;
            val_3 = 丗与丘不且万丟丙丑;
            val_4 = 丈丘丝一丗下丈丐不;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_3, value:  世丁丙世丄一万丆三);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  9, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丐丙万三丑上丞丌万(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞, PGCompany.丝丗丁丞丒且丙丑丙 万上丂丕一丆一丘丞)
        {
            string val_5;
            var val_6;
            val_5 = 丒世丘丘上丆丝东丞;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_6 = null;
            val_6 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5.丂丁丏一丙丛业且丌());
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  val_5, value:  万上丂丕一丆一丘丞.ToString());
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  11, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 上丙丄七丒七丁丝丕(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.VIP20.上丆丝专丞丂且东七 世丁丙世丄一万丆三, int 丝下一东万下丗丝丈)
        {
            int val_4;
            var val_5;
            val_4 = 丝下一东万下丗丝丈;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            val_2.set_Item(key:  val_4, value:  世丁丙世丄一万丆三.ToString());
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  10, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丗丏业丕丈上世丆不(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 上丕丈丞丌丘丅不与, int 丈丘丝一丗下丈丐不, string 丁丅丈丌丟世丗丗丟, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
        {
            object val_4;
            int val_5;
            var val_6;
            val_4 = 丁丅丈丌丟世丗丗丟;
            val_5 = 丈丘丝一丗下丈丐不;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_6 = null;
            val_6 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  上丕丈丞丌丘丅不与);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_5, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_4, value:  PGCompany.Analytics.一业丗丆世世上丁且.丄专丅世万东丂丒丟(丈丄不七三万丄丁不:  丈丄不七三万丄丁不));
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  21, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丅三丄丙不丒专丄丂(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丈与世丗七丐丑丆丌, int 万丗世专专丒一丕下, int 不丞丞丞丁丂丑三万, string 丌三与丅万丑业东丒, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈七丟三丈丈与丗丏, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丆一丂下丟丙丟且与)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_5;
            System.Collections.Generic.ICollection<PGCompany.三东丏不丗世丅丌丄> val_6;
            object val_7;
            int val_8;
            var val_9;
            val_6 = 丈七丟三丈丈与丗丏;
            val_7 = 丌三与丅万丑业东丒;
            val_8 = 万丗世专专丒一丕下;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_9 = null;
            val_9 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  丈与世丗七丐丑丆丌);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_8);
            val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下;
            val_2.set_Item(key:  val_8, value:  不丞丞丞丁丂丑三万);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_7);
            val_7 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_7, value:  PGCompany.Analytics.一业丗丆世世上丁且.丄专丅世万东丂丒丟(丈丄不七三万丄丁不:  val_6));
            val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅;
            val_2.set_Item(key:  val_6, value:  PGCompany.Analytics.一业丗丆世世上丁且.丄专丅世万东丂丒丟(丈丄不七三万丄丁不:  丆一丂下丟丙丟且与));
            val_5 = 丆丛丑世下一丐且丕;
            val_5.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  231, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丁世与七下且丅丈丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丌丒丝东丌下丕丁丅, 丆丐丙一丄业丑丘万 三上丁下与丞丟丟丙, Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, CategoryNames 七丆丒与丗丌丄且丂, string 丟下丟丈万一丙东丄, 丈下专丂丑不丑丗丁 丟不丄一丄丅一世丗)
        {
            object val_6;
            int val_7;
            var val_8;
            val_6 = 丟下丟丈万一丙东丄;
            val_7 = 丌丒丝东丌下丕丁丅;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_8 = null;
            val_8 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_7);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  三上丁下与丞丟丟丙);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丁丅丈丌丟世丗丗丟.ToString());
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  七丆丒与丗丌丄且丂.ToString());
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  val_6);
            val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑;
            val_7 = 丟不丄一丄丅一世丗.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  val_6, value:  val_7);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  7, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丂丒下丙丘七上下丄(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.Analytics.丞丗丞丆丘三丙丘丒 世丁丙世丄一万丆三, System.Exception 世丝丒丙下东丗丙上)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3;
            var val_4;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_4 = null;
            val_4 = null;
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  世丁丙世丄一万丆三);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  世丝丒丙下东丗丙上);
            val_3.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  世丝丒丙下东丗丙上);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  137, 丗丟上上丒丐丗丞丙:  val_3);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_3);
        }
        internal static void 丂上下与丁丟专且丈(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 世不下丟世一丝丐丗, int 丟丒业且万上丁三丆, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丐丂上丈上丁三下与, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丗下丁丅且丝丌丑丐)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
            int val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = 丟丒业且万上丁三丆;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_7 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  15);
            val_9 = null;
            val_9 = null;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  世不下丟世一丝丐丗);
            val_8 = val_8;
            val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_8);
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<PGCompany.三东丏不丗世丅丌丄>(丈丆丕与丒丌丘丕且:  丐丂上丈上丁三下与)) != true)
            {
                    val_10 = null;
                val_10 = null;
                val_8 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
                val_7.set_Item(key:  val_8, value:  PGCompany.Analytics.一业丗丆世世上丁且.与丆专且且丐丈专上(丈丂丗丈世专丁丟丑:  丐丂上丈上丁三下与));
            }
            
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<PGCompany.三东丏不丗世丅丌丄>(丈丆丕与丒丌丘丕且:  丗下丁丅且丝丌丑丐)) != true)
            {
                    val_11 = null;
                val_11 = null;
                val_7.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅, value:  PGCompany.Analytics.一业丗丆世世上丁且.与丆专且且丐丈专上(丈丂丗丈世专丁丟丑:  丗下丁丅且丝丌丑丐));
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  6, 丗丟上上丒丐丗丞丙:  val_7);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_7);
        }
        private static System.Collections.Generic.Dictionary<string, int> 与丆专且且丐丈专上(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丂丗丈世专丁丟丑)
        {
            Rilisoft.OfferItemType val_5;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            if(丈丂丗丈世专丁丟丑 == null)
            {
                    return val_1;
            }
            
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  丈丂丗丈世专丁丟丑);
            专且丝丄丙丗丈不丞.丂丝三丏丞七万七东(丈丄不七三万丄丁不:  val_2);
            List.Enumerator<T> val_3 = val_2.GetEnumerator();
            label_11:
            if(((-183447904) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            val_5 = val_6.不业丙丒丂丞下丆丙();
            val_1.Add(key:  System.String.Format(format:  "{0}:{1}", arg0:  val_5, arg1:  val_6.业上丙丞丐丄丆丅七()), value:  PGCompany.丁丑上丞业丞丟丛上.不丑不与丟丛丏丘丅(丈丄不七三万丄丁不:  val_6));
            goto label_11;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal static void 一东七丕丌一丈丄一(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丁丅丈丌丟世丗丗丟, string 上丏万丕丆七不与万, string 丙丁丞世丟万下丞丑)
        {
            System.Collections.Generic.Dictionary<K, V> val_4;
            int val_5;
            var val_6;
            var val_7;
            val_5 = 丁丅丈丌丟世丗丗丟;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_4 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_6 = null;
            val_6 = null;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            if(上丏万丕丆七不与万 == null)
            {
                goto label_9;
            }
            
            label_19:
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  上丏万丕丆七不与万);
            val_7 = null;
            val_7 = null;
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            丞东丑专丛丆丄丝世.丌丁世丙丕丆丗丗世<System.String, System.Object>(丏丂万业丙专丏丒丒:  val_4, 丞三丕世业三丒丅三:  new System.Func<System.Boolean>(object:  丙丁丞世丟万下丞丑, method:  static System.Boolean 丞东丑专丛丆丄丝世::上丌丐丘丑丗丄丆丒(string 下业七不丑丂丏丟东)), 下上丐丆丝丟丝丒不:  val_5, 丙业与丙丗丝不丈东:  丙丁丞世丟万下丞丑);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  219, 丗丟上上丒丐丗丞丙:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_4);
            return;
            label_9:
            if(val_4 != null)
            {
                goto label_19;
            }
            
            goto label_19;
        }
        internal static void 丌不专三丑丟丁丗丒(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丑丄丌丑东丏丕丒丂, System.Collections.Generic.IDictionary<string, object> 上且丛丁一丝丛丛丏)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9;
            object val_10;
            var val_11;
            string val_12;
            var val_14;
            object val_15;
            var val_16;
            var val_18;
            object val_19;
            var val_20;
            object val_22;
            var val_23;
            var val_24;
            val_10 = 上且丛丁一丝丛丛丏;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_9 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  5);
            val_11 = null;
            val_11 = null;
            val_12 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_9.set_Item(key:  val_12, value:  丑丄丌丑东丏丕丒丂);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_14 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::TryGetValue(TKey key, out TValue value);
            val_15 = 0;
            if(val_15 != 0)
            {
                    if(((val_10.TryGetValue(key:  null, value: out  TValue val_4 = null)) ^ 1) != true)
            {
                    val_16 = null;
                val_16 = null;
                val_15 = 0;
                val_12 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
                val_14 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
                val_9.set_Item(key:  val_12, value:  val_15);
            }
            
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_18 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::TryGetValue(TKey key, out TValue value);
            val_19 = 0;
            if(val_19 != 0)
            {
                    if(((val_10.TryGetValue(key:  null, value: out  TValue val_8 = null)) ^ 1) != true)
            {
                    val_20 = null;
                val_20 = null;
                val_19 = 0;
                val_12 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁;
                val_18 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
                val_9.set_Item(key:  val_12, value:  val_19);
            }
            
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_22 = 0;
            if(val_22 != 0)
            {
                    if(((val_10.TryGetValue(key:  null, value: out  TValue val_12 = null)) ^ 1) != true)
            {
                    val_23 = null;
                val_23 = null;
                val_22 = 0;
                val_12 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑;
                val_9.set_Item(key:  val_12, value:  val_22);
            }
            
            }
            
            val_24 = null;
            val_24 = null;
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_10);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  1024, 丗丟上上丒丐丗丞丙:  val_9);
            val_10 = 0;
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_9);
            if(val_10 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(172 == 172)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        internal static void 丒专丕东万业丆专东(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, bool 丝三丄专丗丞丄丄丌, string 丁丅丈丌丟世丗丗丟, string 丑东与丅丐丅丂丞业)
        {
            object val_4;
            bool val_5;
            var val_6;
            var val_7;
            val_4 = 丁丅丈丌丟世丗丗丟;
            val_5 = 丝三丄专丗丞丄丄丌;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_6 = null;
            val_6 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            val_7 = null;
            val_7 = null;
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_5, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            val_2.set_Item(key:  val_4, value:  丑东与丅丐丅丂丞业);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  13, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丙丛业世丞上丘世下(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 下且与丐上丟七丑丏, Progress.下丁下丂七丆丙七一.七专丁丕世丏丁丘丛 世丙与专七丟丒丆世)
        {
            int val_4;
            var val_5;
            val_4 = 下且与丐上丟七丑丏;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.set_Item(key:  val_4, value:  世丙与专七丟丒丆世.ToString());
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  15, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丞不世丒丛丂万丒丘(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丞丁丑丏丄丏七丂不, string 丂丛丑东不丅丈一东, System.Collections.Generic.List<三丈丟与丏丘丈丐万> 专万丏丝丟丈丝丄丕)
        {
            var val_6;
            var val_7;
            var val_8;
            System.Func<三丈丟与丏丘丈丐万, System.String> val_10;
            System.Func<三丈丟与丏丘丈丐万, System.String> val_12;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_6 = 1152921505690869760;
            val_7 = null;
            val_7 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丂丛丑东不丅丈一东);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丞丁丑丏丄丏七丂不);
            val_8 = null;
            val_8 = null;
            val_10 = 一业丗丆世世上丁且.<>c.<>9__161_0;
            if(val_10 == null)
            {
                    System.Func<三丈丟与丏丘丈丐万, System.String> val_3 = null;
                val_10 = val_3;
                val_3 = new System.Func<三丈丟与丏丘丈丐万, System.String>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一业丗丆世世上丁且.<>c::丏丘丗三上丆丙三丟(三丈丟与丏丘丈丐万 三丟东丕丄丄下下丑));
                val_8 = null;
                一业丗丆世世上丁且.<>c.<>9__161_0 = val_10;
            }
            
            val_8 = null;
            val_12 = 一业丗丆世世上丁且.<>c.<>9__161_1;
            if(val_12 == null)
            {
                    System.Func<三丈丟与丏丘丈丐万, System.String> val_4 = null;
                val_12 = val_4;
                val_4 = new System.Func<三丈丟与丏丘丈丐万, System.String>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一业丗丆世世上丁且.<>c::东东丙世下业丐丟丈(三丈丟与丏丘丈丐万 三丟东丕丄丄下下丑));
                一业丗丆世世上丁且.<>c.<>9__161_1 = val_12;
            }
            
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  System.Linq.Enumerable.ToDictionary<三丈丟与丏丘丈丐万, System.String, System.String>(source:  专万丏丝丟丈丝丄丕, keySelector:  val_3, elementSelector:  val_4));
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  14, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 下丑七不丝下七不上(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丅丁且丕丕丁丅下丁, int 万丛丅丝丂三丆丏下, string 业万丐丒且丈丙一专)
        {
            int val_3;
            int val_4;
            var val_5;
            val_3 = 万丛丅丝丂三丆丏下;
            val_4 = 丅丁且丕丕丁丅下丁;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_3, value:  业万丐丒且丈丙一专);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  20, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 专丕丝一丘丒一且丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, Progress.丛下丄专下万丒专丂 丑丆与丟且丏专丆万)
        {
            Progress.丛下丄专下万丒专丂 val_68 = 丑丆与丟且丏专丆万;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_68.一丗专丅丐丝业万丒() + 1);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  23);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  0.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丂丕丄上三东丆丌丟()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  1.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.业丞丄七丞丒丐丒丐()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  2.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丐万一丁专下专东丞()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  3.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丕上下丌与丆丝丛丄()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  4.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丒丕丕一丙丒丅丑丞()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  5.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丗不且东丌丙三丆业()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  7.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丟丆丝上且丌丞丈丘()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  6.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.世丑七丙丈丐丅丕业()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  12.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丛丝与丄丝下丅三三()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  9.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丗不丂丛丗丄丕世世()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  10.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丕丞丕丗七丒丗东丒()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  8.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丏世上东一丌丙世七()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  210000.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丙万三丗丘丌业且丕()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  25000.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.业万丝丟七丝丈不丌()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  12500.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丈丞下丄丌丕丆丞且()));
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.set_Item(key:  13000.ToString(), value:  Progress.丛下丄专下万丒专丂.专丏丛业丒丞丛丄东(丆专且丕专丗与一丏:  val_68.丆下丟丁丝丁一丕业()));
            val_5.set_Item(key:  "ArmorModules", value:  PGCompany.Analytics.一业丗丆世世上丁且.与万万业丆三丆丆世(且丁上丟丗丙丏丐三:  val_68.与丐丅丆丝不东丌丐()));
            val_5.set_Item(key:  "PrimaryModules", value:  PGCompany.Analytics.一业丗丆世世上丁且.与万万业丆三丆丆世(且丁上丟丗丙丏丐三:  val_68.丆上丒与丌七丐下世()));
            val_5.set_Item(key:  "BackupModules", value:  PGCompany.Analytics.一业丗丆世世上丁且.与万万业丆三丆丆世(且丁上丟丗丙丏丐三:  val_68.专丕丒世丟丘丛丘丟()));
            val_5.set_Item(key:  "MeleeModules", value:  PGCompany.Analytics.一业丗丆世世上丁且.与万万业丆三丆丆世(且丁上丟丗丙丏丐三:  val_68.丗丟丒丆与丄丙三丌()));
            val_5.set_Item(key:  "SpecialModules", value:  PGCompany.Analytics.一业丗丆世世上丁且.与万万业丆三丆丆世(且丁上丟丗丙丏丐三:  val_68.业丅一丄上下丂丑丗()));
            val_5.set_Item(key:  "SniperModules", value:  PGCompany.Analytics.一业丗丆世世上丁且.与万万业丆三丆丆世(且丁上丟丗丙丏丐三:  val_68.丑三下丞丘一丏且世()));
            val_5.set_Item(key:  "PremiumModules", value:  PGCompany.Analytics.一业丗丆世世上丁且.与万万业丆三丆丆世(且丁上丟丗丙丏丐三:  val_68.丟丙下丛丈丅三专丛()));
            val_68 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_68, value:  val_5);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  12, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丝东下与下丞丘丈丝(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, long 丆丐七丅丆丗丛上与, System.Version 丌丈不丄丝七丕万专, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4;
            long val_5;
            var val_6;
            var val_7;
            val_5 = 丆丐七丅丆丗丛上与;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_4 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_6 = null;
            val_6 = null;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_5);
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_4.set_Item(key:  val_5, value:  丌丈不丄丝七丕万专);
            if(上业丟世三与七七三 != null)
            {
                    val_7 = null;
                val_7 = null;
                val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  PGCompany.Analytics.一业丗丆世世上丁且.丏丁一丒下丝丄丛丄(丈丄不七三万丄丁不:  上业丟世三与七七三));
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  22, 丗丟上上丒丐丗丞丙:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_4);
        }
        internal static void 不丙丝丑丆丐丂专专(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 不七丆万丁一丞七下, int 万丙丄七丂一丅丑业, string 丗下丙丗一丕且且丂, int 专东丄丁丛下丝丛丅, object 丄万下丝丕丝丁万不)
        {
            int val_4;
            object val_5;
            int val_6;
            var val_7;
            val_4 = 专东丄丁丛下丝丛丅;
            val_5 = 丗下丙丗一丕且且丂;
            val_6 = 不七丆万丁一丞七下;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_4 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_7 = null;
            val_7 = null;
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_6);
            val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_4.set_Item(key:  val_6, value:  万丙丄七丂一丅丑业);
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_5);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = null;
            val_5 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_3.set_Item(key:  "v_ProgressRoad", value:  丄万下丝丕丝丁万不);
            val_3.set_Item(key:  "v_Tutorial", value:  val_4);
            val_4.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_3);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  26, 丗丟上上丒丐丗丞丙:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_4);
        }
        internal static void 七世丁丅丏且专专丞(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.与万丝丞下丒丗丏丙 东七世业上丆丕丁丅, string 丅上三丏万丛七丐东)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_13;
            var val_14;
            var val_15;
            object val_16;
            var val_17;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_13 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_14 = null;
            val_14 = null;
            val_13.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  东七世业上丆丕丁丅.业东丅东丌上丗丑不());
            PGCompany.东丑丆丗丏丐丟下丄 val_4 = 东七世业上丆丕丁丅.丂下丏且一丈与下三();
            if((val_4 != null) && (val_4 != null))
            {
                    int val_5 = val_4.丂丁丏一丙丛业且丌();
                val_15 = 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            if(((-181290728) & 1) != 0)
            {
                    int val_6 = val_15.丙东专丂世丈丏丁丂();
            }
            else
            {
                    val_16 = 0;
            }
            
            val_13.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_16);
            val_17 = null;
            val_17 = null;
            val_13.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丅上三丏万丛七丐东);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_13.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  东七世业上丆丕丁丅.不业丙丒丂丞下丆丙().ToString());
            val_13.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  PGCompany.Analytics.一业丗丆世世上丁且.丏丁一丒下丝丄丛丄(丈丄不七三万丄丁不:  东七世业上丆丕丁丅.丈丏丁东上与东丙丕()));
            val_13.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅, value:  PGCompany.Analytics.一业丗丆世世上丁且.丏丁一丒下丝丄丛丄(丈丄不七三万丄丁不:  东七世业上丆丕丁丅.丟丂丞不专丆万丒世()));
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  27, 丗丟上上丒丐丗丞丙:  val_13);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_13);
        }
        internal static void 丂专丐丞丁一丐与上(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 上丁丙丛丘丁丙业丆, string 丒丄丆专下丘下丈丂, System.Collections.Generic.Dictionary<int, int> 丒丂丄三丆丐下且丄, System.Collections.Generic.Dictionary<int, int> 丑三丒丆业丆丁丟七)
        {
            var val_13;
            var val_14;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_16;
            var val_17;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_19;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_21;
            var val_22;
            var val_23;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_25;
            var val_26;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_28;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_30;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_13 = null;
            val_13 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  上丁丙丛丘丁丙业丆);
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丒丄丆专下丘下丈丂);
            val_14 = null;
            val_14 = null;
            val_16 = 一业丗丆世世上丁且.<>c.<>9__167_0;
            if(val_16 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_3 = null;
                val_16 = val_3;
                val_3 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 一业丗丆世世上丁且.<>c::丐七丐东丟丑丘丙丑(System.Collections.Generic.KeyValuePair<int, int> 丐丏东世不丅丌且万));
                一业丗丆世世上丁且.<>c.<>9__167_0 = val_16;
            }
            
            val_17 = null;
            val_17 = null;
            val_19 = 一业丗丆世世上丁且.<>c.<>9__167_1;
            if(val_19 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_5 = null;
                val_19 = val_5;
                val_5 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 一业丗丆世世上丁且.<>c::万丌专与丟丗丕丟丞(System.Collections.Generic.KeyValuePair<int, int> 丐丏东世不丅丌且万));
                val_17 = null;
                一业丗丆世世上丁且.<>c.<>9__167_1 = val_19;
            }
            
            val_17 = null;
            val_21 = 一业丗丆世世上丁且.<>c.<>9__167_2;
            if(val_21 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_6 = null;
                val_21 = val_6;
                val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 一业丗丆世世上丁且.<>c::下丆丄下丈丅丕丏丙(System.Collections.Generic.KeyValuePair<int, int> 丐丏东世不丅丌且万));
                一业丗丆世世上丁且.<>c.<>9__167_2 = val_21;
            }
            
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32, System.Int32>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(source:  丒丂丄三丆丐下且丄, keySelector:  val_3), keySelector:  val_5, elementSelector:  val_6));
            val_22 = null;
            val_22 = null;
            val_23 = null;
            val_23 = null;
            val_25 = 一业丗丆世世上丁且.<>c.<>9__167_3;
            if(val_25 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_8 = null;
                val_25 = val_8;
                val_8 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 一业丗丆世世上丁且.<>c::且丏丏丟丁丟丕七不(System.Collections.Generic.KeyValuePair<int, int> 丐丏东世不丅丌且万));
                一业丗丆世世上丁且.<>c.<>9__167_3 = val_25;
            }
            
            val_26 = null;
            val_26 = null;
            val_28 = 一业丗丆世世上丁且.<>c.<>9__167_4;
            if(val_28 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_10 = null;
                val_28 = val_10;
                val_10 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 一业丗丆世世上丁且.<>c::丒万不丁且世丅丝三(System.Collections.Generic.KeyValuePair<int, int> 丐丏东世不丅丌且万));
                val_26 = null;
                一业丗丆世世上丁且.<>c.<>9__167_4 = val_28;
            }
            
            val_26 = null;
            val_30 = 一业丗丆世世上丁且.<>c.<>9__167_5;
            if(val_30 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_11 = null;
                val_30 = val_11;
                val_11 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  一业丗丆世世上丁且.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 一业丗丆世世上丁且.<>c::丄业丟丒不丗丄丁丅(System.Collections.Generic.KeyValuePair<int, int> 丐丏东世不丅丌且万));
                一业丗丆世世上丁且.<>c.<>9__167_5 = val_30;
            }
            
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅, value:  System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32, System.Int32>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(source:  丑三丒丆业丆丁丟七, keySelector:  val_8), keySelector:  val_10, elementSelector:  val_11));
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  23, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丞丁丙丙丅丞丌丟丂(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.三东丏不丗世丅丌丄 不且丐一丆丛丙丙丒, PGCompany.丏丈丈且东丅上丄丙 不东一丆且丒且上丅)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9;
            var val_10;
            object val_11;
            var val_12;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_9 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_10 = null;
            val_10 = null;
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  不且丐一丆丛丙丙丒.业东丅东丌上丗丑不());
            if((PGCompany.丁丑上丞业丞丟丛上.丛七丈丄不丟下丑丈(丈丄不七三万丄丁不:  不且丐一丆丛丙丙丒)) != false)
            {
                    val_11 = 不且丐一丆丛丙丙丒;
                int val_5 = val_11.丂丁丏一丙丛业且丌();
            }
            else
            {
                    val_11 = 1;
            }
            
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  val_11);
            val_12 = null;
            val_12 = null;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  不东一丆且丒且上丅.不业丙丒丂丞下丆丙().ToString());
            val_9.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  不东一丆且丒且上丅.业上丙丞丐丄丆丅七());
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  24, 丗丟上上丒丐丗丞丙:  val_9);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_9);
        }
        internal static void 丄丅丆丛业业不下三(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, PGCompany.一三丛丅丌丒丙丆一 专业丗丛不丕七丐东, System.Collections.Generic.List<PGCompany.LootBoxSystem.丞万下丒丒且丁丒三.七丘丟专世丅丂丙丑> 丐丐丆丌东丐丒丝丂)
        {
            var val_8;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_28;
            string val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_36;
            var val_37;
            var val_38;
            System.Collections.Generic.Dictionary<TKey, TValue> val_39;
            var val_40;
            var val_41;
            val_29 = 丐丐丆丌东丐丒丝丂;
            val_30 = 专业丗丛不丕七丐东;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_31 = null;
            val_31 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_30.业东丅东丌上丗丑不());
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, System.Int32>> val_5 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>();
            List.Enumerator<T> val_6 = val_29.GetEnumerator();
            val_29 = 0;
            val_32 = 0;
            var val_27 = 0;
            label_47:
            if(((-180631184) & 1) == 0)
            {
                goto label_11;
            }
            
            ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
            if(((-180631200) & 1) != 0)
            {
                    if((val_4.ContainsKey(key:  val_9._value._obj)) != true)
            {
                    val_4.set_Item(key:  val_9._value._obj, value:  1);
            }
            
            }
            
            if((val_5.ContainsKey(key:  val_9._value._obj)) != true)
            {
                    System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_12 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
                val_5.Add(key:  val_9._value._obj, value:  null);
            }
            
            List.Enumerator<T> val_13 = val_9._value._token.GetEnumerator();
            label_29:
            if(((-180631232) & 1) == 0)
            {
                goto label_20;
            }
            
            string val_14 = val_8.丐丏七丌丕丗业且上();
            if(val_14 == null)
            {
                goto label_29;
            }
            
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_15 = val_5.Item[val_9._value._obj];
            if((val_15.ContainsKey(key:  val_14.业东丅东丌上丗丑不())) == false)
            {
                goto label_24;
            }
            
            val_15.set_Item(key:  val_14.业东丅东丌上丗丑不(), value:  val_14.丂丁丏一丙丛业且丌() + val_15.Item[val_14.业东丅东丌上丗丑不()]);
            goto label_29;
            label_24:
            val_15.Add(key:  val_14.业东丅东丌上丗丑不(), value:  val_14.丂丁丏一丙丛业且丌());
            goto label_29;
            label_20:
            val_27 = val_27 + 1;
            val_33 = val_32;
            mem2[0] = 286;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_27 == 1) || ((-180631328 + ((0 + 1)) << 2) != 286))
            {
                goto label_44;
            }
            
            var val_28 = 0;
            val_28 = val_28 ^ (val_27 >> 31);
            val_27 = val_27 + val_28;
            goto label_47;
            label_44:
            if( == 0)
            {
                goto label_47;
            }
            
            goto label_47;
            label_11:
            val_27 = val_27 + 1;
            mem2[0] = 314;
            val_36 = 丆丛丑世下一丐且丕;
            val_37 = 1152921505690550272;
            val_38 = 1152921505690869760;
            val_39 = val_4;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_27 == 1)
            {
                goto label_58;
            }
            
            if(( == 0) || ((-180631328 + ((0 + 1)) << 2) == 314))
            {
                goto label_75;
            }
            
            label_74:
            label_75:
            val_28 = val_2;
            val_30 = 1152921516595668352;
            if(val_5.Count >= 1)
            {
                    val_40 = null;
                val_29 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
                val_28.set_Item(key:  val_29, value:  val_5);
            }
            
            if(val_4.Count >= 1)
            {
                    val_41 = null;
                val_41 = null;
                val_28.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅, value:  val_4);
            }
            
            丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  25, 丗丟上上丒丐丗丞丙:  val_28);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_28);
            return;
            label_58:
            if( != 0)
            {
                goto label_74;
            }
            
            goto label_75;
        }
        internal static void 丗丐上世三专不世丒(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丞丅上丏丂且下丅与, System.Collections.Generic.List<string> 丆丗丞上丞丂丗东丂)
        {
            var val_5;
            var val_6;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  ((System.String.IsNullOrEmpty(value:  丞丅上丏丂且下丅与)) != true) ? "user_open" : 丞丅上丏丂且下丅与);
            val_6 = null;
            val_6 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  丆丗丞上丞丂丗东丂);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  18, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 三七世丅上丐丐丒丛(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 下万丗三丛丒丆且丌, int 上丕专上且上丕万丘, int 丕与丑七与万丄丂丂, int 专东丄丁丛下丝丛丅, int 丄万下丝丕丝丁万不, 丝不丘丞丈万丈一上 世丁丙世丄一万丆三)
        {
            int val_6;
            int val_7;
            object val_8;
            var val_9;
            val_6 = 专东丄丁丛下丝丛丅;
            val_7 = 丕与丑七与万丄丂丂;
            val_8 = 上丕专上且上丕万丘;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_6 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_9 = null;
            val_9 = null;
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_7 - val_8);
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且, value:  下万丗三丛丒丆且丌);
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐不丞丐不三丈下, value:  val_7);
            val_8 = 世丁丙世丄一万丆三.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  val_8);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = null;
            val_7 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_5.set_Item(key:  "v_ProgressRoad", value:  丄万下丝丕丝丁万不);
            val_5.set_Item(key:  "v_Tutorial", value:  val_6);
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  val_5);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  19, 丗丟上上丒丐丗丞丙:  val_6);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_6);
        }
        internal static void 东丆丐世丕丞万丟上(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 七丆丒与丗丌丄且丂, string 丂丛丑东不丅丈一东)
        {
            var val_4;
            var val_5;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  2);
            val_4 = null;
            val_4 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  七丆丒与丗丌丄且丂);
            if((System.String.IsNullOrEmpty(value:  丂丛丑东不丅丈一东)) != true)
            {
                    val_5 = null;
                val_5 = null;
                val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  丂丛丑东不丅丈一东);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  35, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 丄且丏丏丏三丗万丙(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, string 丐丁不丆丘丂丐丈丆, string 丑东与丅丐丅丂丞业, Rilisoft.一丟专且三万丞丁丂.不且世丘下丞丏丄丁 丅上三丏万丛七丐东, string 丁丑丑丟丄丙不丘丙)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6;
            string val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_7 = 丑东与丅丐丅丂丞业;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            val_6 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  10);
            val_8 = null;
            val_8 = null;
            val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑, value:  丐丁不丆丘丂丐丈丆);
            if((System.String.IsNullOrEmpty(value:  val_7)) != true)
            {
                    val_9 = null;
                val_9 = null;
                val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业东丆上丒与下世七, value:  val_7);
            }
            
            if(丅上三丏万丛七丐东 >= 1)
            {
                    val_10 = null;
                val_10 = null;
                val_7 = 丅上三丏万丛七丐东;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丂一丐丝业万丂丑, value:  丅上三丏万丛七丐东.ToString());
            }
            
            if((System.String.IsNullOrEmpty(value:  丁丑丑丟丄丙不丘丙)) != true)
            {
                    val_11 = null;
                val_11 = null;
                val_6.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈且丛丘丏丝丁丝丁, value:  丁丑丑丟丄丙不丘丙);
            }
            
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  36, 丗丟上上丒丐丗丞丙:  val_6);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_6);
        }
        internal static void 七丘且丞三业东丁丆(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 丗丟丁丐与下丙丕丛, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丒世丘丘上丆丝东丞)
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5;
            int val_6;
            var val_7;
            val_5 = 上业丟世三与七七三;
            val_6 = 丗丟丁丐与下丙丕丛;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_7 = null;
            val_7 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_6);
            val_6 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万;
            val_2.set_Item(key:  val_6, value:  PGCompany.Analytics.一业丗丆世世上丁且.丒丑丈丏丂丌专万丅(不丞丘丆丆丒丁丂丗:  val_5));
            val_5 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丘丛丙且世与与丁丅;
            val_2.set_Item(key:  val_5, value:  PGCompany.Analytics.一业丗丆世世上丁且.丒丑丈丏丂丌专万丅(不丞丘丆丆丒丁丂丗:  丒世丘丘上丆丝东丞));
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  31, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        internal static void 七万且丂丝丛一丘丄(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, int 且东丝丏下万丒丘下, int 丐业不不丂丐丄七丙, string 丒三丅业丝丟三丒丅)
        {
            int val_3;
            int val_4;
            var val_5;
            val_3 = 丐业不不丂丐丄七丙;
            val_4 = 且东丝丏下万丒丘下;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  3);
            val_5 = null;
            val_5 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丄丝丐丘业丟丘, value:  val_4);
            val_4 = PGCompany.Analytics.丂与丏丕一丒与丁丙.世丒丝丄丌下丏丂且;
            val_2.set_Item(key:  val_4, value:  val_3);
            val_3 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丁万丞丘丌世丝丑;
            val_2.set_Item(key:  val_3, value:  丒三丅业丝丟三丒丅);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  37, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        private static System.Collections.Generic.Dictionary<string, int> 丒丑丈丏丂丌专万丅(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 不丞丘丆丆丒丁丂丗)
        {
            var val_4;
            System.Collections.Generic.Dictionary<UnityEngine.UI.IClipper, System.Int32> val_1 = new System.Collections.Generic.Dictionary<UnityEngine.UI.IClipper, System.Int32>();
            if(不丞丘丆丆丒丁丂丗 == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Int32>)val_1;
            }
            
            List.Enumerator<T> val_2 = 不丞丘丆丆丒丁丂丗.GetEnumerator();
            label_12:
            if(((-179470240) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            string val_7 = val_5.业东丅东丌上丗丑不().ToString();
            if((val_1.ContainsKey(key:  val_7)) == false)
            {
                goto label_5;
            }
            
            val_1.set_Item(key:  val_7, value:  val_5.丂丁丏一丙丛业且丌() + val_1.Item[val_7]);
            goto label_12;
            label_5:
            val_1.Add(key:  val_7, value:  val_5.丂丁丏一丙丛业且丌());
            goto label_12;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)val_1;
        }
        internal static 丈丞丕丘丕丗与上一 丑丌丞丞专下丞世丞(丙且上东下丏丏丟下 丑丝丏丂且不下一东, CategoryNames 七丆丒与丗丌丄且丂)
        {
            var val_6;
            if(丑丝丏丂且不下一东 == null)
            {
                    return 0;
            }
            
            string val_1 = 丑丝丏丂且不下一东.业上丙丞丐丄丆丅七();
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                    return 0;
            }
            
            val_6 = val_1;
            if(七丆丒与丗丌丄且丂 != 7)
            {
                    if(七丆丒与丗丌丄且丂 == 140000)
            {
                    return 0;
            }
            
                val_6 = val_1;
            }
            
            if((WeaponManager.一丅丅万丄丅丘丆专(丒东业不丐丑丕丄丆:  val_1)) == null)
            {
                    return 0;
            }
            
            if((PGCompany.GameplayLoop.丕与七丐丞丕丑业世.万下丝东七丙万丒业(丞一丁业丄一一业且:  val_1)) == false)
            {
                    return 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  七丆丒与丗丌丄且丂, 丞一丁业丄一一业且:  val_1, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            }
            
            return PGCompany.GameplayLoop.丕与七丐丞丕丑业世.与丒一且丛丙丞丂专(丞一丁业丄一一业且:  val_1);
        }
        internal static void 丘丑一东下下东丂七(PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丛丑世下一丐且丕, System.Collections.Generic.Dictionary<string, int> 一丏丌丆东丟丗不与)
        {
            var val_3;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丗丈万东丝专丘丌丞(丕专七丙丂丅丕与丘:  1);
            val_3 = null;
            val_3 = null;
            val_2.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.与丐下三丑专专丅万, value:  一丏丌丆东丟丗不与);
            丆丛丑世下一丐且丕.丝丒丈丟万不丘丂丑(丗丆业三丝丗丆丑丛:  32, 丗丟上上丒丐丗丞丙:  val_2);
            PGCompany.Analytics.一业丗丆世世上丁且.丟下丌丂丈丕且丒丞(万丝且丘不丑丝下丑:  val_2);
        }
        private static void 丞不业万丕丞东东业(PGCompany.Analytics.一业丗丆世世上丁且.专不世七世三且丏丌 七丏丄丅丌业与且丙)
        {
            null = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丘丘上丑与不丙丌世.__il2cppRuntimeField_10 = 七丏丄丅丌业与且丙.丄丕丙丕丌三下丁业;
            PGCompany.Analytics.一业丗丆世世上丁且.丘丘上丑与不丙丌世 = 七丏丄丅丌业与且丙.丆万丄三且丒丝世丟;
        }
        private static bool 丘丂上丞下丞丕丛万(out PGCompany.Analytics.一业丗丆世世上丁且.专不世七世三且丏丌 七丏丄丅丌业与且丙)
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = 0;
            七丏丄丅丌业与且丙.丑丗下且且丈丞丌丝 = 0;
            七丏丄丅丌业与且丙.丄丕丙丕丌三下丁业 = 0;
            七丏丄丅丌业与且丙.丆万丄三且丒丝世丟 = 0;
            七丏丄丅丌业与且丙.丟丌丒业三丆丌丒万 = 0;
            return (bool);
        }
        private static void 丗丝丑丐上丘与业七(PGCompany.Analytics.与丌丛一丆丈丂业丂 与丂丒丄丟丌丆丁丕)
        {
            null = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丕丂丒丁丆丈万丈丘 = 与丂丒丄丟丌丆丁丕;
        }
        private static void 万丒业丄且丝丂丘万(PGCompany.Analytics.与丌丛一丆丈丂业丂 与丂丒丄丟丌丆丁丕)
        {
            null = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丟丒万丐东丝丟业一 = 与丂丒丄丟丌丆丁丕;
        }
        private static bool 专丕丂三一丁不一丄(out PGCompany.Analytics.与丌丛一丆丈丂业丂 与丂丒丄丟丌丆丁丕)
        {
            var val_1;
            PGCompany.Analytics.与丌丛一丆丈丂业丂 val_2;
            var val_3;
            val_1 = null;
            val_1 = null;
            val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丕丂丒丁丆丈万丈丘;
            if(val_2 != 0)
            {
                    val_2 = PGCompany.Analytics.一业丗丆世世上丁且.丕丂丒丁丆丈万丈丘;
                与丂丒丄丟丌丆丁丕 = val_2;
                val_3 = 1;
                PGCompany.Analytics.一业丗丆世世上丁且.丕丂丒丁丆丈万丈丘 = 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            与丂丒丄丟丌丆丁丕 = 0;
            return (bool)val_3;
        }
        private static bool 与丙丙丘七丕且专丐(out PGCompany.Analytics.与丌丛一丆丈丂业丂 与丂丒丄丟丌丆丁丕)
        {
            var val_1;
            var val_2;
            PGCompany.Analytics.与丌丛一丆丈丂业丂 val_3;
            var val_4;
            val_1 = 1152921560263042832;
            val_2 = null;
            val_2 = null;
            val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丟丒万丐东丝丟业一;
            if(val_3 != 0)
            {
                    val_3 = PGCompany.Analytics.一业丗丆世世上丁且.丟丒万丐东丝丟业一;
                与丂丒丄丟丌丆丁丕 = val_3;
                val_4 = 1;
                val_1 = 1152921505690554396;
            }
            else
            {
                    val_4 = 0;
            }
            
            与丂丒丄丟丌丆丁丕 = 0;
            return (bool)val_4;
        }
        private static 一业丗丆世世上丁且()
        {
            PGCompany.Analytics.一业丗丆世世上丁且.丆与丛丅丂三万一丑 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        }
        internal static string 与万万业丆三丆丆世(System.Collections.Generic.List<int> 且丁上丟丗丙丏丐三)
        {
            return System.String.Join(separator:  ",", values:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  且丁上丟丗丙丏丐三, selector:  new System.Func<System.Int32, System.String>(object:  0, method:  static System.String Progress.丛下丄专下万丒专丂::专丏丛业丒丞丛丄东(int 丆专且丕专丗与一丏))));
        }
    
    }

}
