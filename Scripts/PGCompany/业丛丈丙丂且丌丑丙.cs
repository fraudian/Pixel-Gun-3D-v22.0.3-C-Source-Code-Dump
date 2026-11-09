using UnityEngine;

namespace PGCompany
{
    internal class 业丛丈丙丂且丌丑丙
    {
        // Fields
        private static bool 下下丕丙丐丄七世丏;
        private static bool 丗丟东丁不丞不丟丁;
        private static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, float>> 三丁丄丆三与上丁七;
        
        // Methods
        internal static System.Collections.Generic.List<Rilisoft.OfferItem> 东丂丝丘业丂丛丁丁(PGCompany.业丛丈丙丂且丌丑丙.GenerationPropertyes 丑下丞上丈丌下丄下, System.Collections.Generic.List<PGCompany.ModuleData> 不丏下万下下万下世)
        {
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_1 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            return PGCompany.业丛丈丙丂且丌丑丙.丒丒丝三丟丌丕与一(丑下丞上丈丌下丄下:  丑下丞上丈丌下丄下, 不丏下万下下万下世:  不丏下万下下万下世);
        }
        private static System.Collections.Generic.List<Rilisoft.OfferItem> 丒丒丝三丟丌丕与一(PGCompany.业丛丈丙丂且丌丑丙.GenerationPropertyes 丑下丞上丈丌下丄下, System.Collections.Generic.List<PGCompany.ModuleData> 不丏下万下下万下世)
        {
            var val_8;
            System.Collections.Generic.List<GenerationRule> val_15;
            var val_16;
            var val_17;
            val_15 = 丑下丞上丈丌下丄下;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            val_16 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
            if(val_16.丗业丝万业一与三且() == 0)
            {
                goto label_2;
            }
            
            val_17 = ExperienceController.丞丞丘业东丙丏七丌();
            if(val_15 != null)
            {
                goto label_5;
            }
            
            return val_1;
            label_2:
            val_17 = 999;
            if(val_15 == null)
            {
                    return val_1;
            }
            
            label_5:
            if(丑下丞上丈丌下丄下.Rules == null)
            {
                    return val_1;
            }
            
            System.Collections.Generic.List<GenerationRule> val_5 = null;
            val_16 = val_5;
            val_5 = new System.Collections.Generic.List<GenerationRule>();
            val_15 = 丑下丞上丈丌下丄下.Rules;
            List.Enumerator<T> val_6 = val_15.GetEnumerator();
            label_15:
            if(((-343755040) & 1) == 0)
            {
                goto label_10;
            }
            
            if((999 < val_9.m_stringLength) || ('ϧ' > val_9.m_firstChar))
            {
                goto label_15;
            }
            
            val_5.Add(item:  val_8.丐丏七丌丕丗业且上());
            goto label_15;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_5.Count == 0)
            {
                    return val_1;
            }
            
            List.Enumerator<T> val_11 = val_5.GetEnumerator();
            val_15 = 1152921537932660432;
            label_30:
            if(((-343755040) & 1) == 0)
            {
                goto label_25;
            }
            
            System.Collections.Generic.List<Rilisoft.OfferItem> val_13 = PGCompany.业丛丈丙丂且丌丑丙.丆丛丛丏丘专不丄丂(丒专丑丒丁丞三丆业:  val_8.丐丏七丌丕丗业且上(), 不丏下万下下万下世:  不丏下万下下万下世);
            if(val_13 == null)
            {
                goto label_30;
            }
            
            val_1.AddRange(collection:  val_13);
            goto label_30;
            label_25:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        private static System.Collections.Generic.List<Rilisoft.OfferItem> 丆丛丛丏丘专不丄丂(PGCompany.业丛丈丙丂且丌丑丙.GenerationRule 丒专丑丒丁丞三丆业, System.Collections.Generic.List<PGCompany.ModuleData> 不丏下万下下万下世)
        {
            var val_15;
            业丛丈丙丂且丌丑丙.一丁丞丘专世丞业丆 val_16;
            int val_17;
            Rilisoft.OfferItem val_18;
            var val_19;
            int val_20;
            string val_21;
            var val_22;
            System.Collections.Generic.List<ModuleCategory> val_23;
            业丛丈丙丂且丌丑丙.万下下丒丅七丕丛一 val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            if(丒专丑丒丁丞三丆业 == null)
            {
                goto label_1;
            }
            
            val_15 = 丒专丑丒丁丞三丆业;
            val_16 = 丒专丑丒丁丞三丆业.Category;
            if(val_16 == 5)
            {
                goto label_2;
            }
            
            goto label_3;
            label_1:
            if(0 != 5)
            {
                goto label_4;
            }
            
            label_2:
            val_17 = 丒专丑丒丁丞三丆业.Count;
            val_18 = new Rilisoft.OfferItem();
            val_19 = 1140;
            val_20 = val_17;
            val_21 = "CraftCurrency";
            goto label_5;
            label_4:
            val_15 = 36;
            val_16 = 0;
            label_3:
            if(val_16 != 6)
            {
                goto label_6;
            }
            
            val_22 = null;
            val_22 = null;
            val_17 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            Rilisoft.OfferItem val_2 = null;
            val_18 = val_2;
            val_19 = 1010;
            val_21 = val_17;
            val_20 = 丒专丑丒丁丞三丆业.Count;
            label_5:
            val_2 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  242, 丞一丁业丄一一业且:  val_21, 丂丕丂丏专丂丄丕且:  val_20);
            val_1.Add(item:  val_2);
            return val_1;
            label_6:
            业丛丈丙丂且丌丑丙.世丞丒丅一专丌丐丏 val_3 = new 业丛丈丙丂且丌丑丙.世丞丒丅一专丌丐丏();
            val_23 = PGCompany.业丛丈丙丂且丌丑丙.丄丟丙丛丁不丏丕丂(东丕丙丘且丈丆丈一:  0);
            if(val_3 != null)
            {
                    .丂丗不丑三丞丟丒丙 = val_23;
            }
            else
            {
                    mem[16] = val_23;
                val_23 = mem[16];
            }
            
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<ModuleCategory>(丈丆丕与丒丌丘丕且:  val_23)) == true)
            {
                    return val_1;
            }
            
            .丒丄丕下三与七丆且 = 0;
            val_24 = 丒专丑丒丁丞三丆业.RandomType;
            if(val_24 != 1)
            {
                goto label_29;
            }
            
            val_25 = 0;
            if(val_25 != 2)
            {
                goto label_20;
            }
            
            val_26 = null;
            val_26 = null;
            if(PGCompany.业丛丈丙丂且丌丑丙.下下丕丙丐丄七世丏 == false)
            {
                goto label_23;
            }
            
            val_24 = 丒专丑丒丁丞三丆业.RandomType;
            if(val_24 != 1)
            {
                goto label_29;
            }
            
            val_25 = 0;
            label_20:
            if(val_25 != 4)
            {
                goto label_25;
            }
            
            val_27 = null;
            val_27 = null;
            if(PGCompany.业丛丈丙丂且丌丑丙.丗丟东丁不丞不丟丁 == false)
            {
                goto label_28;
            }
            
            val_24 = 丒专丑丒丁丞三丆业.RandomType;
            goto label_29;
            label_25:
            val_24 = 1;
            label_29:
            System.Collections.Generic.List<ModuleType> val_6 = PGCompany.业丛丈丙丂且丌丑丙.丄且丛一丑世丌丒丁(丛丒不世丏专丗丁丄:  val_24);
            .丒丄丕下三与七丆且 = val_6;
            if(val_6 == null)
            {
                    return val_1;
            }
            
            label_52:
            System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<PGCompany.ModuleData>(source:  System.Linq.Enumerable.Where<PGCompany.ModuleData>(source:  不丏下万下下万下世, predicate:  new System.Func<PGCompany.ModuleData, System.Boolean>(object:  val_3, method:  System.Boolean 业丛丈丙丂且丌丑丙.世丞丒丅一专丌丐丏::丂且丛东丂丄丒丌丙(PGCompany.ModuleData 东丝丄丝丙专丘三丏))));
            if(val_9.Count < 1)
            {
                    return val_1;
            }
            
            if(丒专丑丒丁丞三丆业.Count < 1)
            {
                    return val_1;
            }
            
            var val_15 = 0;
            do
            {
                if((丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.ModuleData>(丑东与丅丐丅丂丞业:  val_9)) != null)
            {
                    Rilisoft.OfferItem val_12 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  126, 丞丅上丏丂且下丅与:  val_11.Id, 丌丒丝东丌下丕丁丅:  1);
                if(val_12 != null)
            {
                    val_1.Add(item:  val_12);
            }
            
            }
            
                val_15 = val_15 + 1;
            }
            while(val_15 < 丒专丑丒丁丞三丆业.Count);
            
            return val_1;
            label_23:
            System.Collections.Generic.List<ModuleType> val_13 = new System.Collections.Generic.List<ModuleType>();
            val_13.Add(item:  1);
            .丒丄丕下三与七丆且 = val_13;
            val_28 = null;
            val_28 = null;
            PGCompany.业丛丈丙丂且丌丑丙.下下丕丙丐丄七世丏 = true;
            goto label_48;
            label_28:
            System.Collections.Generic.List<ModuleType> val_14 = new System.Collections.Generic.List<ModuleType>();
            val_14.Add(item:  1);
            .丒丄丕下三与七丆且 = val_14;
            val_29 = null;
            val_29 = null;
            PGCompany.业丛丈丙丂且丌丑丙.丗丟东丁不丞不丟丁 = true;
            label_48:
            if((业丛丈丙丂且丌丑丙.世丞丒丅一专丌丐丏)[1152921555803020480].丒丄丕下三与七丆且 != null)
            {
                goto label_52;
            }
            
            return val_1;
        }
        private static System.Collections.Generic.List<PGCompany.ModuleData.ModuleType> 丄且丛一丑世丌丒丁(PGCompany.业丛丈丙丂且丌丑丙.万下下丒丅七丕丛一 丛丒不世丏专丗丁丄)
        {
            System.Collections.Generic.List<ModuleType> val_5;
            if(丛丒不世丏专丗丁丄 == 2)
            {
                goto label_1;
            }
            
            if(丛丒不世丏专丗丁丄 != 1)
            {
                goto label_2;
            }
            
            System.Collections.Generic.List<ModuleType> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Collections.Generic.List<ModuleType>();
            if(val_5 == null)
            {
                goto label_3;
            }
            
            val_1.Add(item:  1);
            val_1.Add(item:  3);
            goto label_4;
            label_1:
            .东且丁丆丛丁丏丘且 = new System.Collections.Generic.List<ModuleType>();
            丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<ModuleType>(七丐丅专且专七三丆:  new System.Action<ModuleType>(object:  new 业丛丈丙丂且丌丑丙.丞丂万丅不丒丘丟丗(), method:  System.Void 业丛丈丙丂且丌丑丙.丞丂万丅不丒丘丟丗::丏丒丏万一下丟万丟(PGCompany.ModuleData.ModuleType 丙丒七丄上与丏丙丙)));
            val_5 = (业丛丈丙丂且丌丑丙.丞丂万丅不丒丘丟丗)[1152921555803229760].东且丁丆丛丁丏丘且;
            return (System.Collections.Generic.List<ModuleType>)val_5;
            label_2:
            val_5 = 0;
            return (System.Collections.Generic.List<ModuleType>)val_5;
            label_3:
            val_1.Add(item:  1);
            val_1.Add(item:  3);
            label_4:
            val_1.Add(item:  2);
            return (System.Collections.Generic.List<ModuleType>)val_5;
        }
        private static System.Collections.Generic.List<PGCompany.ModuleData.ModuleCategory> 丄丟丙丛丁不丏丕丂(PGCompany.业丛丈丙丂且丌丑丙.一丁丞丘专世丞业丆 东丕丙丘且丈丆丈一)
        {
            var val_11;
            ModuleCategory val_12;
            var val_13;
            var val_14;
            System.Collections.Generic.List<ModuleCategory> val_1 = new System.Collections.Generic.List<ModuleCategory>();
            if((东丕丙丘且丈丆丈一 - 2) < 2)
            {
                goto label_1;
            }
            
            if(东丕丙丘且丈丆丈一 == 1)
            {
                goto label_2;
            }
            
            if(东丕丙丘且丈丆丈一 != 4)
            {
                    return val_1;
            }
            
            val_11 = 1152921555803311360;
            val_12 = 7;
            goto label_5;
            label_1:
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>> val_3 = PGCompany.业丛丈丙丂且丌丑丙.丘业七丕丂丈丟不丅();
            if(val_3.Count < 1)
            {
                    return val_1;
            }
            
            if(东丕丙丘且丈丆丈一 != 2)
            {
                goto label_10;
            }
            
            val_13 = val_3;
            System.Collections.Generic.KeyValuePair<CategoryNames, System.Single> val_5 = val_13.Item[0];
            goto label_12;
            label_2:
            if(val_1 == null)
            {
                goto label_13;
            }
            
            val_1.Add(item:  6);
            val_1.Add(item:  1);
            val_1.Add(item:  2);
            val_1.Add(item:  5);
            goto label_14;
            label_10:
            if(val_3.Count < 2)
            {
                    return val_1;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Skip<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>>(source:  val_3, count:  1);
            System.Collections.Generic.KeyValuePair<CategoryNames, System.Single> val_8 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>>(source:  val_7);
            label_12:
            val_12 = PGCompany.七丆丆丕丂丙丕丐丂.丌丐丐丑丈一丛丗丕(七丆丒与丗丌丄且丂:  val_7.丙东专丂世丈丏丁丂());
            val_14 = public System.Void System.Collections.Generic.List<ModuleCategory>::Add(ModuleCategory item);
            goto label_18;
            label_13:
            val_1.Add(item:  6);
            val_1.Add(item:  1);
            val_1.Add(item:  2);
            val_1.Add(item:  5);
            label_14:
            val_11 = 1152921555803311360;
            val_12 = 4;
            label_5:
            label_18:
            val_1.Add(item:  val_12);
            return val_1;
        }
        internal static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, float>> 丘业七丕丂丈丟不丅()
        {
            var val_11;
            var val_26;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>> val_27;
            var val_28;
            var val_29;
            var val_30;
            System.Func<三丈丟与丏丘丈丐万, 三丅丁丗丗丝丂万且> val_32;
            var val_34;
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_36;
            var val_37;
            System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>, System.Single> val_39;
            val_26 = null;
            val_26 = null;
            val_27 = PGCompany.业丛丈丙丂且丌丑丙.三丁丄丆三与上丁七;
            if(val_27.Count >= 1)
            {
                    val_28 = null;
                val_28 = null;
                return (System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>>)PGCompany.业丛丈丙丂且丌丑丙.三丁丄丆三与上丁七;
            }
            
            val_29 = null;
            val_29 = null;
            val_30 = null;
            val_30 = null;
            val_32 = 业丛丈丙丂且丌丑丙.<>c.<>9__8_0;
            if(val_32 == null)
            {
                    System.Func<三丈丟与丏丘丈丐万, 三丅丁丗丗丝丂万且> val_3 = null;
                val_32 = val_3;
                val_3 = new System.Func<三丈丟与丏丘丈丐万, 三丅丁丗丗丝丂万且>(object:  业丛丈丙丂且丌丑丙.<>c.__il2cppRuntimeField_static_fields, method:  三丅丁丗丗丝丂万且 业丛丈丙丂且丌丑丙.<>c::丝丌东丘丌业与丞专(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
                业丛丈丙丂且丌丑丙.<>c.<>9__8_0 = val_32;
            }
            
            val_34 = null;
            val_34 = null;
            val_36 = 业丛丈丙丂且丌丑丙.<>c.<>9__8_1;
            if(val_36 == null)
            {
                    System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_5 = null;
                val_36 = val_5;
                val_5 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  业丛丈丙丂且丌丑丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 业丛丈丙丂且丌丑丙.<>c::丙丐丏专丗丏丐丆业(三丅丁丗丗丝丂万且 与丘东下丈东丛丂万));
                业丛丈丙丂且丌丑丙.<>c.<>9__8_1 = val_36;
            }
            
            System.Collections.Generic.Dictionary<CategoryNames, System.Single> val_8 = new System.Collections.Generic.Dictionary<CategoryNames, System.Single>();
            List.Enumerator<T> val_9 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Select<三丈丟与丏丘丈丐万, 三丅丁丗丗丝丂万且>(source:  WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与(), selector:  val_3), predicate:  val_5)).GetEnumerator();
            label_39:
            if(((-342901552) & 1) == 0)
            {
                goto label_22;
            }
            
            string val_12 = val_11.丐丏七丌丕丗业且上();
            float val_14 = BalanceController.且下丒丞丕丙丝一上(丞丌东丟且丒丐丑丂:  val_12.丐七丐丝与丒七丈丐(), 专东丑丑丁丞丛三丗:  false);
            if(val_12.丒万丕七专不丏丞丌() == 2)
            {
                goto label_39;
            }
            
            if((val_8.ContainsKey(key:  val_12.丒万丕七专不丏丞丌())) == false)
            {
                goto label_30;
            }
            
            if(val_8.Item[val_12.丒万丕七专不丏丞丌()] >= 0)
            {
                goto label_39;
            }
            
            val_8.set_Item(key:  val_12.丒万丕七专不丏丞丌(), value:  val_14);
            goto label_39;
            label_30:
            val_8.Add(key:  val_12.丒万丕七专不丏丞丌(), value:  val_14);
            goto label_39;
            label_22:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_37 = null;
            val_37 = null;
            val_39 = 业丛丈丙丂且丌丑丙.<>c.<>9__8_2;
            if(val_39 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>, System.Single> val_22 = null;
                val_39 = val_22;
                val_22 = new System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>, System.Single>(object:  业丛丈丙丂且丌丑丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Single 业丛丈丙丂且丌丑丙.<>c::丅丈专丝七且丘不丅(System.Collections.Generic.KeyValuePair<CategoryNames, float> 丅三丄丕丁丘丘业三));
                业丛丈丙丂且丌丑丙.<>c.<>9__8_2 = val_39;
            }
            
            val_28 = null;
            val_27 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>>(source:  System.Linq.Enumerable.OrderByDescending<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>, System.Single>(source:  val_8, keySelector:  val_22));
            val_28 = null;
            PGCompany.业丛丈丙丂且丌丑丙.三丁丄丆三与上丁七 = val_27;
            return (System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>>)PGCompany.业丛丈丙丂且丌丑丙.三丁丄丆三与上丁七;
        }
        public 业丛丈丙丂且丌丑丙()
        {
        
        }
        private static 业丛丈丙丂且丌丑丙()
        {
            PGCompany.业丛丈丙丂且丌丑丙.下下丕丙丐丄七世丏 = false;
            PGCompany.业丛丈丙丂且丌丑丙.丗丟东丁不丞不丟丁 = false;
            PGCompany.业丛丈丙丂且丌丑丙.三丁丄丆三与上丁七 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>>();
        }
    
    }

}
