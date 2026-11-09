using UnityEngine;

namespace PGCompany
{
    internal static class 七丂专七丆丗不丌专
    {
        // Fields
        internal static System.Collections.Generic.Dictionary<int, string> 丏丈丛丅七且丁丆丙;
        
        // Methods
        internal static bool 不丄丙一七丌业下丌(PGCompany.丅丝丂丕上业与丐丏.丝丕专世丙丆丛丝丝 丁万丝丄丌丒丁三丆)
        {
            var val_12;
            System.Predicate<专七丙丅丙东七万万> val_13;
            var val_14;
            var val_15;
            var val_17;
            System.Func<专七丙丅丙东七万万, ItemRarity> val_19;
            var val_20;
            val_12 = null;
            val_12 = null;
            val_13 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count;
            val_14 = null;
            val_14 = null;
            if(val_13 < 上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.Count)
            {
                    return true;
            }
            
            val_15 = null;
            val_15 = null;
            val_13 = 七丂专七丆丗不丌专.<>c.<>9__0_0;
            if(val_13 == null)
            {
                goto label_12;
            }
            
            label_29:
            System.Collections.Generic.List<T> val_5 = 丁万丝丄丌丒丁三丆.RegularSlotsSettings.FindAll(match:  val_13);
            if(val_5.Count == 0)
            {
                    return true;
            }
            
            val_17 = null;
            val_17 = null;
            val_19 = 七丂专七丆丗不丌专.<>c.<>9__0_1;
            if(val_19 == null)
            {
                    System.Func<专七丙丅丙东七万万, ItemRarity> val_7 = null;
                val_19 = val_7;
                val_7 = new System.Func<专七丙丅丙东七万万, ItemRarity>(object:  七丂专七丆丗不丌专.<>c.__il2cppRuntimeField_static_fields, method:  ItemRarity 七丂专七丆丗不丌专.<>c::上下丈丒万丆七丈丌(PGCompany.丅丝丂丕上业与丐丏.专七丙丅丙东七万万 丛丟三丘丛且业丈丏));
                七丂专七丆丗不丌专.<>c.<>9__0_1 = val_19;
            }
            
            .七且七丄丝丝丗丄丙 = System.Linq.Enumerable.Min<专七丙丅丙东七万万, ItemRarity>(source:  val_5, selector:  val_7);
            val_20 = null;
            val_20 = null;
            System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_9 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
            if(val_9 != null)
            {
                    return val_9.Exists(match:  new System.Predicate<三丈丟与丏丘丈丐万>(object:  new 七丂专七丆丗不丌专.丞上丕丈丒丘丆三丈(), method:  System.Boolean 七丂专七丆丗不丌专.丞上丕丈丒丘丆三丈::东世丕上东丂三东万(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)));
            }
            
            return val_9.Exists(match:  new System.Predicate<三丈丟与丏丘丈丐万>(object:  new 七丂专七丆丗不丌专.丞上丕丈丒丘丆三丈(), method:  System.Boolean 七丂专七丆丗不丌专.丞上丕丈丒丘丆三丈::东世丕上东丂三东万(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)));
            label_12:
            七丂专七丆丗不丌专.<>c.<>9__0_0 = new System.Predicate<专七丙丅丙东七万万>(object:  七丂专七丆丗不丌专.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 七丂专七丆丗不丌专.<>c::一丞丟丟丛丕丑丒与(PGCompany.丅丝丂丕上业与丐丏.专七丙丅丙东七万万 一一丅丕东七丕丛丈));
            if(丁万丝丄丌丒丁三丆.RegularSlotsSettings != null)
            {
                goto label_29;
            }
            
            goto label_29;
        }
        internal static System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丄东且丂一上丈与丈(PGCompany.与丂丈三三东丕七丕.世丕上丞与业丂丞丞 丒专上万丂七专七丛, ItemRarity 丈下丑丆上丏丗丈专, int 与丙专丆万丟专七丞)
        {
            var val_9;
            var val_18;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_18 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世();
            if(val_18.世丈丁业丛上丘丗丐() == null)
            {
                    return val_1;
            }
            
            val_18 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().世丈丁业丛上丘丗丐();
            List.Enumerator<T> val_7 = val_18.丄三丂丕丘丞丘丕丗(丒专上万丂七专七丛:  丒专上万丂七专七丛).GetEnumerator();
            label_13:
            if(((-893823536) & 1) == 0)
            {
                goto label_6;
            }
            
            string val_10 = val_9.丐丏七丌丕丗业且上();
            PGCompany.丗丟丄丈东丝丕丄世 val_12 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_10);
            if(((val_12 == null) || (val_12 != 丈下丑丆上丏丗丈专)) || ((PGCompany.ItemSystem.丂丟丁丗丘与丞丂丟.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_10, 丆丗丝丄丄万丂丂且:  new PGCompany.ItemSystem.三三丌丞丘不且丗业[5])) == false))
            {
                goto label_13;
            }
            
            val_1.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_10.业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  与丙专丆万丟专七丞));
            goto label_13;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal static PGCompany.丞丞丒下三三丘丈丗 丞专丛丏丘丁丕丕丘(PGCompany.世丞上丏丗不丛上东 丙业丞丑七丗下丟丌)
        {
            var val_22;
            var val_23;
            var val_41;
            System.Func<PGCompany.世丞上丏丗不丛上东, System.Int32> val_43;
            var val_44;
            var val_45;
            PGCompany.不三丄丆丄丛万丁且 val_1 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世();
            val_41 = null;
            val_41 = null;
            val_43 = 七丂专七丆丗不丌专.<>c.<>9__3_0;
            if(val_43 == null)
            {
                    System.Func<PGCompany.世丞上丏丗不丛上东, System.Int32> val_2 = null;
                val_43 = val_2;
                val_2 = new System.Func<PGCompany.世丞上丏丗不丛上东, System.Int32>(object:  七丂专七丆丗不丌专.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 七丂专七丆丗不丌专.<>c::且丄丈世丄世且丘万(PGCompany.世丞上丏丗不丛上东 丄三丅七丆丛与与上));
                七丂专七丆丗不丌专.<>c.<>9__3_0 = val_43;
            }
            
            PGCompany.StorePromotionSettings val_4 = PGCompany.MainStore.不丄且一丌与上不专.且一丕丒丌世丄丂七();
            PGCompany.StorePromotionPurchaseSettings val_5 = new PGCompany.StorePromotionPurchaseSettings();
            .Type = 14;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_6 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_6.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  31, 丂丕丂丏专丂丄丕且:  丙业丞丑七丗下丟丌.丆丘世丈丏七世丈不()));
            val_5.Price = val_6;
            val_44 = null;
            val_44 = null;
            string val_10 = PGCompany.七丂专七丆丗不丌专.丏丈丛丅七且丁丆丙.Item[丙业丞丑七丗下丟丌.丆丘世丈丏七世丈不()];
            if(val_4 != null)
            {
                    val_4.TitleLocKey = val_10;
                val_45 = val_4;
                val_4.PurchaseSettings = val_5;
                mem2[0] = "Key_9796";
                mem2[0] = "StorePromotion/ConstructableOfferStorePromotionView";
                mem2[0] = "StorePromotion/ConstructableOfferInfo";
            }
            else
            {
                    mem[16] = val_10;
                mem[24] = "Key_9796";
                val_45 = 96;
                mem[96] = val_5;
                mem[56] = "StorePromotion/ConstructableOfferStorePromotionView";
                mem[64] = "StorePromotion/ConstructableOfferInfo";
            }
            
            val_4.ObtainCurrencyCause = 77;
            if(丙业丞丑七丗下丟丌 != null)
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_12 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业丞丑七丗下丟丌.不七丝丏丑丑与七丈());
                val_4.PresentationTime = val_12;
                mem2[0] = val_12.上万三丆专丏丒丗业;
            }
            else
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_14 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0.不七丝丏丑丑与七丈());
                val_4.PresentationTime = val_14;
                mem2[0] = val_14.上万三丆专丏丒丗业;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_16 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业丞丑七丗下丟丌.上丟丄与丁三丌丘专());
            val_4.StartTime = val_16;
            mem2[0] = val_16.上万三丆专丏丒丗业;
            Rilisoft.丝丑丂丛万丐丈丘且 val_18 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业丞丑七丗下丟丌.下丒丗丄丌丘不丑丘());
            val_4.EndTime = val_18;
            mem2[0] = val_18.上万三丆专丏丒丗业;
            decimal val_20 = System.Decimal.op_Implicit(value:  丙业丞丑七丗下丟丌.丆丞上丛丂一业丟丕());
            Rilisoft.丂上丐丄丛一一丒七 val_21 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_20.flags, hi = val_20.hi, lo = val_20.lo, mid = val_20.mid});
            mem[1152921555252950712] = val_22;
            mem[1152921555252950696] = val_23;
            val_4.TexturePath = ((System.Linq.Enumerable.Max<PGCompany.世丞上丏丗不丛上东>(source:  val_1.且丐丏专业业东不丁, selector:  val_2)) == 丙业丞丑七丗下丟丌.丆丘世丈丏七世丈不()) ? "OfferIcons/constructable_offer_512" : "OfferIcons/constructable_offer_256";
            val_4.Tag = new TagSystem.三与下丘七丘丌丏丄(丆万一不丌且东丐丐:  "show_purchase_confirmation");
            val_4.ObtainWeaponCause = 26;
            List.Enumerator<T> val_31 = 丙业丞丑七丗下丟丌.三丕丂丝丙丆丅三丞().GetEnumerator();
            label_34:
            if(((-893568472) & 1) == 0)
            {
                goto label_31;
            }
            
            val_4.ItemsParams.Add(item:  0.丐丏七丌丕丗业且上().与下不与丐丈丁丈万());
            goto label_34;
            label_31:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.丞丞丒下三三丘丈丗 val_36 = new PGCompany.丞丞丒下三三丘丈丗(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  13, 与不丕丆丈不丙丟丛:  val_4, 一丗与一专丙丙丅丄:  PGCompany.七丂专七丆丗不丌专.丘丌万一下丁丌丌丞(丞世不丒下上上丝丑:  丙业丞丑七丗下丟丌.业东丅东丌上丗丑不())), 丗丟丁丐与下丙丕丛:  丙业丞丑七丗下丟丌.业东丅东丌上丗丑不().ToString());
            if((val_36.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "notifications.enabled")) == true)
            {
                    return val_36;
            }
            
            bool val_40 = val_36.与不丞丑七丘丁丂丛().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "notifications.enabled");
            return val_36;
        }
        internal static System.Collections.Generic.Dictionary<object, object> 且丞丟世丁丌东丒丙(PGCompany.世丞上丏丗不丛上东 丄丘七三上丕世丞业)
        {
            int val_5;
            int val_19;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            List.Enumerator<T> val_3 = 丄丘七三上丕世丞业.丂丘业丐丕三上七且().GetEnumerator();
            label_24:
            if(((-893317184) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            null.set_Item(key:  "type", value:  PGCompany.七丂专七丆丗不丌专.东丒东下丞万与七三(丌丝万上丅丒一丈丘:  val_6));
            PGCompany.三东丏不丗世丅丌丄 val_12 = val_6.丒丈与东丂丕一且丄().丛丞三丒丌且丝三与().丟丄丂三丑三七丕不(业丌丆业丘丟丆丁丛:  val_6.业东丅东丌上丗丑不());
            if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_12)) == false)
            {
                goto label_13;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_12);
            val_5 = val_12.丂丁丏一丙丛业且丌();
            null.set_Item(key:  "quantity", value:  val_5);
            if(val_15 == null)
            {
                goto label_18;
            }
            
            val_19 = val_15;
            if(val_19 == null)
            {
                goto label_18;
            }
            
            if(null != null)
            {
                goto label_21;
            }
            
            goto label_20;
            label_18:
            val_19 = System.String.alignConst;
            if(null != null)
            {
                goto label_21;
            }
            
            label_20:
            label_21:
            null.set_Item(key:  "item", value:  val_19);
            label_13:
            val_5 = val_6.业东丅东丌上丗丑不() + 1;
            val_1.set_Item(key:  val_5, value:  null);
            goto label_24;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal static string 东丒东下丞万与七三(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘)
        {
            var val_7;
            var val_8;
            val_7 = 丌丝万上丅丒一丈丘;
            if(val_7.不业丙丒丂丞下丆丙() != 1)
            {
                goto label_2;
            }
            
            if(val_7 == null)
            {
                goto label_3;
            }
            
            if(null == null)
            {
                goto label_6;
            }
            
            val_7 = 0;
            goto label_6;
            label_2:
            val_8 = val_7.不业丙丒丂丞下丆丙().ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)val_8;
            label_3:
            label_6:
            val_8 = val_7.丕丌丐丙丑丙丌世下().ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)val_8;
        }
        internal static bool 专业丈且丆专万不丁(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄, out int 丞世不丒下上上丝丑)
        {
            return PGCompany.三丛丗丆七丁丆上丌.专业丈且丆专万不丁(一丗与一专丙丙丅丄:  一丗与一专丙丙丅丄, 丂业丕业丂丅丙一丛:  "constructable", 丞世不丒下上上丝丑: out  1152921555253536464);
        }
        internal static PGCompany.丙一丟与且丞丏丈一 丘丌万一下丁丌丌丞(int 丞世不丒下上上丝丑)
        {
            return PGCompany.三丛丗丆七丁丆上丌.丘丌万一下丁丌丌丞(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 丂业丕业丂丅丙一丛:  "constructable");
        }
        private static 七丂专七丆丗不丌专()
        {
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  3, value:  "Key_9789");
            }
            else
            {
                    val_1.Add(key:  3, value:  "Key_9789");
            }
            
            val_1.Add(key:  5, value:  "Key_9790");
            if(val_1 != null)
            {
                    val_1.Add(key:  10, value:  "Key_9791");
            }
            else
            {
                    val_1.Add(key:  10, value:  "Key_9791");
            }
            
            val_1.Add(key:  20, value:  "Key_9792");
            if(val_1 != null)
            {
                    val_1.Add(key:  50, value:  "Key_9793");
            }
            else
            {
                    val_1.Add(key:  50, value:  "Key_9793");
            }
            
            val_1.Add(key:  100, value:  "Key_9794");
            PGCompany.七丂专七丆丗不丌专.丏丈丛丅七且丁丆丙 = val_1;
        }
    
    }

}
