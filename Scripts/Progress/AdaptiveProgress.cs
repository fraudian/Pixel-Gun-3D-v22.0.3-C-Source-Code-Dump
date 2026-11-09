using UnityEngine;

namespace Progress
{
    [Serializable]
    internal class AdaptiveProgress : ICloneable
    {
        // Fields
        internal int SeasonId;
        internal int SeasonStartAt;
        internal System.Collections.Generic.List<Progress.AdaptiveProgress.SkippedItem> SkippedItems;
        internal System.Collections.Generic.List<int> Weapons_BoughtCategoryes;
        internal System.Collections.Generic.List<int> Weapons_LastViewedCategoryes;
        internal System.Collections.Generic.List<string> IgnoreOffers;
        internal int PetsLastViewedOfferType;
        internal string PreviousViewedPet;
        internal int MaxBuyReal;
        internal System.Collections.Generic.Dictionary<string, int> OffersShowCounter;
        internal System.Collections.Generic.List<string> GadgetsLastViewed;
        
        // Methods
        internal static System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙(Progress.AdaptiveProgress 七丏丄丅丌业与且丙)
        {
            var val_19;
            System.Func<SkippedItem, System.String> val_21;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_22;
            object val_23;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "s", value:  七丏丄丅丌业与且丙.SeasonId);
            val_1.set_Item(key:  "ss", value:  七丏丄丅丌业与且丙.SeasonStartAt);
            if(七丏丄丅丌业与且丙.Weapons_BoughtCategoryes == null)
            {
                goto label_4;
            }
            
            if(val_1 != null)
            {
                goto label_32;
            }
            
            label_33:
            label_32:
            val_1.set_Item(key:  "wbc", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  七丏丄丅丌业与且丙.Weapons_BoughtCategoryes));
            if(七丏丄丅丌业与且丙.Weapons_LastViewedCategoryes == null)
            {
                goto label_6;
            }
            
            if(val_1 != null)
            {
                goto label_34;
            }
            
            label_35:
            label_34:
            val_1.set_Item(key:  "wlc", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  七丏丄丅丌业与且丙.Weapons_LastViewedCategoryes));
            if(七丏丄丅丌业与且丙.IgnoreOffers == null)
            {
                goto label_8;
            }
            
            if(val_1 != null)
            {
                goto label_36;
            }
            
            label_37:
            label_36:
            val_1.set_Item(key:  "io", value:  System.Linq.Enumerable.ToList<System.String>(source:  七丏丄丅丌业与且丙.IgnoreOffers));
            val_1.set_Item(key:  "pvt", value:  七丏丄丅丌业与且丙.PetsLastViewedOfferType);
            val_1.set_Item(key:  "pvp", value:  七丏丄丅丌业与且丙.PreviousViewedPet);
            val_1.set_Item(key:  "mr", value:  七丏丄丅丌业与且丙.MaxBuyReal);
            if(七丏丄丅丌业与且丙.SkippedItems == null)
            {
                goto label_13;
            }
            
            val_19 = null;
            val_19 = null;
            val_21 = AdaptiveProgress.<>c.<>9__12_0;
            if(val_21 == null)
            {
                    System.Func<SkippedItem, System.String> val_5 = null;
                val_21 = val_5;
                val_5 = new System.Func<SkippedItem, System.String>(object:  AdaptiveProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String AdaptiveProgress.<>c::丁丞且丘丙万三且上(Progress.AdaptiveProgress.SkippedItem 七丞丙丒三丕且丌丟));
                AdaptiveProgress.<>c.<>9__12_0 = val_21;
            }
            
            if(val_1 != null)
            {
                goto label_38;
            }
            
            label_39:
            label_38:
            val_1.set_Item(key:  "si", value:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<SkippedItem, System.String>(source:  七丏丄丅丌业与且丙.SkippedItems, selector:  val_5)));
            val_22 = 七丏丄丅丌业与且丙.OffersShowCounter;
            if(val_22 == null)
            {
                goto label_20;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_8 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(dictionary:  val_22);
            if(val_1 != null)
            {
                goto label_40;
            }
            
            label_41:
            label_40:
            val_1.set_Item(key:  "sh", value:  null);
            if((七丏丄丅丌业与且丙.GadgetsLastViewed == null) || ((System.Linq.Enumerable.Any<System.String>(source:  七丏丄丅丌业与且丙.GadgetsLastViewed)) == false))
            {
                goto label_23;
            }
            
            val_23 = System.Linq.Enumerable.ToList<System.String>(source:  七丏丄丅丌业与且丙.GadgetsLastViewed);
            if(val_1 != null)
            {
                goto label_26;
            }
            
            goto label_25;
            label_23:
            val_23 = 0;
            if(val_1 != null)
            {
                goto label_26;
            }
            
            label_25:
            label_26:
            val_1.set_Item(key:  "glv", value:  val_23);
            System.Collections.Generic.List<System.String> val_11 = new System.Collections.Generic.List<System.String>();
            if(七丏丄丅丌业与且丙.SkippedItems == null)
            {
                goto label_47;
            }
            
            List.Enumerator<T> val_12 = 七丏丄丅丌业与且丙.SkippedItems.GetEnumerator();
            val_22 = 1152921541059179184;
            label_31:
            if((2092628248 & 1) == 0)
            {
                goto label_28;
            }
            
            val_11.Add(item:  0.丐丏七丌丕丗业且上());
            goto label_31;
            label_4:
            System.Collections.Generic.List<System.Int32> val_14 = new System.Collections.Generic.List<System.Int32>();
            if(val_1 != null)
            {
                goto label_32;
            }
            
            goto label_33;
            label_6:
            System.Collections.Generic.List<System.Int32> val_15 = new System.Collections.Generic.List<System.Int32>();
            if(val_1 != null)
            {
                goto label_34;
            }
            
            goto label_35;
            label_8:
            System.Collections.Generic.List<System.String> val_16 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                goto label_36;
            }
            
            goto label_37;
            label_13:
            System.Collections.Generic.List<System.String> val_17 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                goto label_38;
            }
            
            goto label_39;
            label_20:
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_18 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            if(val_1 != null)
            {
                goto label_40;
            }
            
            goto label_41;
            label_28:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_1 != null)
            {
                goto label_48;
            }
            
            goto label_43;
            label_47:
            if(val_1 != null)
            {
                goto label_48;
            }
            
            label_43:
            label_48:
            val_1.set_Item(key:  "si", value:  val_11);
            return val_1;
        }
        public object Clone()
        {
            int val_15;
            System.Collections.Generic.List<System.Int32> val_16;
            System.Collections.Generic.List<System.Int32> val_17;
            System.Collections.Generic.List<System.String> val_18;
            var val_19;
            System.Func<SkippedItem, SkippedItem> val_21;
            System.Collections.Generic.List<SkippedItem> val_22;
            System.Collections.Generic.List<System.String> val_23;
            Progress.AdaptiveProgress val_1 = new Progress.AdaptiveProgress();
            if(val_1 != null)
            {
                    .SeasonId = this.SeasonId;
                val_15 = this.SeasonStartAt;
            }
            else
            {
                    mem[16] = this.SeasonId;
                val_15 = this.SeasonStartAt;
            }
            
            .SeasonStartAt = val_15;
            if(this.Weapons_BoughtCategoryes != null)
            {
                    val_16 = System.Linq.Enumerable.ToList<System.Int32>(source:  this.Weapons_BoughtCategoryes);
            }
            else
            {
                    System.Collections.Generic.List<System.Int32> val_3 = null;
                val_16 = val_3;
                val_3 = new System.Collections.Generic.List<System.Int32>();
            }
            
            .Weapons_BoughtCategoryes = val_16;
            if(this.Weapons_LastViewedCategoryes != null)
            {
                    val_17 = System.Linq.Enumerable.ToList<System.Int32>(source:  this.Weapons_LastViewedCategoryes);
            }
            else
            {
                    System.Collections.Generic.List<System.Int32> val_5 = null;
                val_17 = val_5;
                val_5 = new System.Collections.Generic.List<System.Int32>();
            }
            
            .Weapons_LastViewedCategoryes = val_17;
            if(this.IgnoreOffers != null)
            {
                    val_18 = System.Linq.Enumerable.ToList<System.String>(source:  this.IgnoreOffers);
            }
            else
            {
                    System.Collections.Generic.List<System.String> val_7 = null;
                val_18 = val_7;
                val_7 = new System.Collections.Generic.List<System.String>();
            }
            
            .IgnoreOffers = val_18;
            .PetsLastViewedOfferType = this.PetsLastViewedOfferType;
            .PreviousViewedPet = this.PreviousViewedPet;
            .MaxBuyReal = this.MaxBuyReal;
            if(this.SkippedItems != null)
            {
                    val_19 = null;
                val_19 = null;
                val_21 = AdaptiveProgress.<>c.<>9__13_0;
                if(val_21 == null)
            {
                    System.Func<SkippedItem, SkippedItem> val_8 = null;
                val_21 = val_8;
                val_8 = new System.Func<SkippedItem, SkippedItem>(object:  AdaptiveProgress.<>c.__il2cppRuntimeField_static_fields, method:  SkippedItem AdaptiveProgress.<>c::与东丑且丒丗业世丐(Progress.AdaptiveProgress.SkippedItem 七丞丙丒三丕且丌丟));
                AdaptiveProgress.<>c.<>9__13_0 = val_21;
            }
            
                val_22 = System.Linq.Enumerable.ToList<SkippedItem>(source:  System.Linq.Enumerable.Select<SkippedItem, SkippedItem>(source:  this.SkippedItems, selector:  val_8));
            }
            else
            {
                    System.Collections.Generic.List<SkippedItem> val_11 = null;
                val_22 = val_11;
                val_11 = new System.Collections.Generic.List<SkippedItem>();
            }
            
            .SkippedItems = val_22;
            if(this.OffersShowCounter != null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_12 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(dictionary:  this.OffersShowCounter);
            }
            else
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_13 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            .OffersShowCounter = null;
            val_23 = this.GadgetsLastViewed;
            .GadgetsLastViewed = System.Linq.Enumerable.ToList<System.String>(source:  val_23);
            return (object)val_1;
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丝丟丛丘一一且上三(Progress.AdaptiveProgress 丛三七丟丗与专丙丂, Progress.AdaptiveProgress 三丂丑丁丞丞丅东三)
        {
            var val_28;
            System.Collections.Generic.List<System.Int32> val_29;
            System.Collections.Generic.List<System.Int32> val_30;
            System.Collections.Generic.List<System.String> val_31;
            System.Collections.Generic.List<SkippedItem> val_32;
            var val_33;
            System.Func<SkippedItem, System.String> val_35;
            var val_36;
            System.Collections.Generic.List<SkippedItem> val_37;
            System.Func<SkippedItem, System.String> val_39;
            var val_41;
            System.Func<SkippedItem, System.String> val_43;
            object val_44;
            string val_45;
            var val_46;
            Progress.AdaptiveProgress val_47;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_48;
            string val_49;
            var val_50;
            object val_51;
            System.Collections.Generic.List<System.String> val_52;
            string val_53;
            var val_54;
            object val_55;
            if((三丂丑丁丞丞丅东三 | 丛三七丟丗与专丙丂) == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = null;
                val_28 = val_2;
                val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_28;
            }
            
            if(丛三七丟丗与专丙丂 == null)
            {
                goto label_3;
            }
            
            if(三丂丑丁丞丞丅东三 == null)
            {
                goto label_4;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = null;
            val_28 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(三丂丑丁丞丞丅东三.SeasonId != 丛三七丟丗与专丙丂.SeasonId)
            {
                    val_3.Add(key:  "s", value:  三丂丑丁丞丞丅东三.SeasonId);
            }
            
            if(三丂丑丁丞丞丅东三.SeasonStartAt != 丛三七丟丗与专丙丂.SeasonStartAt)
            {
                    val_3.Add(key:  "ss", value:  三丂丑丁丞丞丅东三.SeasonStartAt);
            }
            
            if(三丂丑丁丞丞丅东三.PetsLastViewedOfferType != 丛三七丟丗与专丙丂.PetsLastViewedOfferType)
            {
                    val_3.Add(key:  "pvt", value:  三丂丑丁丞丞丅东三.PetsLastViewedOfferType);
            }
            
            if((System.String.op_Inequality(a:  三丂丑丁丞丞丅东三.PreviousViewedPet, b:  丛三七丟丗与专丙丂.PreviousViewedPet)) != false)
            {
                    val_3.Add(key:  "pvp", value:  三丂丑丁丞丞丅东三.PreviousViewedPet);
            }
            
            if(三丂丑丁丞丞丅东三.MaxBuyReal != 丛三七丟丗与专丙丂.MaxBuyReal)
            {
                    val_3.Add(key:  "mr", value:  三丂丑丁丞丞丅东三.MaxBuyReal);
            }
            
            val_29 = 三丂丑丁丞丞丅东三.Weapons_BoughtCategoryes;
            if(val_29 == null)
            {
                goto label_15;
            }
            
            if(丛三七丟丗与专丙丂.Weapons_BoughtCategoryes == null)
            {
                goto label_16;
            }
            
            if((System.Linq.Enumerable.SequenceEqual<System.Int32>(first:  val_29, second:  丛三七丟丗与专丙丂.Weapons_BoughtCategoryes)) == true)
            {
                goto label_17;
            }
            
            val_29 = 三丂丑丁丞丞丅东三.Weapons_BoughtCategoryes;
            label_16:
            if(val_28 != null)
            {
                goto label_48;
            }
            
            label_49:
            label_48:
            val_3.Add(key:  "wbc", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  val_29));
            label_17:
            val_30 = 三丂丑丁丞丞丅东三.Weapons_LastViewedCategoryes;
            if(val_30 == null)
            {
                goto label_19;
            }
            
            if(丛三七丟丗与专丙丂.Weapons_LastViewedCategoryes == null)
            {
                goto label_20;
            }
            
            if((System.Linq.Enumerable.SequenceEqual<System.Int32>(first:  val_30, second:  丛三七丟丗与专丙丂.Weapons_LastViewedCategoryes)) == true)
            {
                goto label_21;
            }
            
            val_30 = 三丂丑丁丞丞丅东三.Weapons_LastViewedCategoryes;
            label_20:
            if(val_28 != null)
            {
                goto label_50;
            }
            
            label_51:
            label_50:
            val_3.Add(key:  "wlc", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  val_30));
            label_21:
            val_31 = 三丂丑丁丞丞丅东三.IgnoreOffers;
            if(val_31 == null)
            {
                goto label_23;
            }
            
            if(丛三七丟丗与专丙丂.IgnoreOffers == null)
            {
                goto label_24;
            }
            
            if((System.Linq.Enumerable.SequenceEqual<System.String>(first:  val_31, second:  丛三七丟丗与专丙丂.IgnoreOffers)) == true)
            {
                goto label_25;
            }
            
            val_31 = 三丂丑丁丞丞丅东三.IgnoreOffers;
            label_24:
            if(val_28 != null)
            {
                goto label_52;
            }
            
            label_53:
            label_52:
            val_3.Add(key:  "io", value:  System.Linq.Enumerable.ToList<System.String>(source:  val_31));
            label_25:
            val_32 = 三丂丑丁丞丞丅东三.SkippedItems;
            if(val_32 == null)
            {
                goto label_27;
            }
            
            if(丛三七丟丗与专丙丂.SkippedItems == null)
            {
                goto label_28;
            }
            
            val_33 = null;
            val_33 = null;
            val_35 = AdaptiveProgress.<>c.<>9__14_0;
            if(val_35 == null)
            {
                    System.Func<SkippedItem, System.String> val_11 = null;
                val_35 = val_11;
                val_11 = new System.Func<SkippedItem, System.String>(object:  AdaptiveProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String AdaptiveProgress.<>c::世业丐一丌丅业不上(Progress.AdaptiveProgress.SkippedItem 七丞丙丒三丕且丌丟));
                AdaptiveProgress.<>c.<>9__14_0 = val_35;
            }
            
            val_36 = null;
            val_37 = 丛三七丟丗与专丙丂.SkippedItems;
            val_36 = null;
            val_39 = AdaptiveProgress.<>c.<>9__14_1;
            if(val_39 == null)
            {
                    System.Func<SkippedItem, System.String> val_13 = null;
                val_39 = val_13;
                val_13 = new System.Func<SkippedItem, System.String>(object:  AdaptiveProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String AdaptiveProgress.<>c::且丝且丄丑丙丒与上(Progress.AdaptiveProgress.SkippedItem 七丞丙丒三丕且丌丟));
                AdaptiveProgress.<>c.<>9__14_1 = val_39;
            }
            
            if((System.Linq.Enumerable.SequenceEqual<System.String>(first:  System.Linq.Enumerable.Select<SkippedItem, System.String>(source:  val_32, selector:  val_11), second:  System.Linq.Enumerable.Select<SkippedItem, System.String>(source:  val_37, selector:  val_13))) == true)
            {
                goto label_39;
            }
            
            val_32 = 三丂丑丁丞丞丅东三.SkippedItems;
            label_28:
            val_41 = null;
            val_41 = null;
            val_43 = AdaptiveProgress.<>c.<>9__14_2;
            val_37 = "si";
            if(val_43 == null)
            {
                    System.Func<SkippedItem, System.String> val_16 = null;
                val_43 = val_16;
                val_16 = new System.Func<SkippedItem, System.String>(object:  AdaptiveProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String AdaptiveProgress.<>c::丅不不七丕且丂丘一(Progress.AdaptiveProgress.SkippedItem 七丞丙丒三丕且丌丟));
                AdaptiveProgress.<>c.<>9__14_2 = val_43;
            }
            
            val_44 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<SkippedItem, System.String>(source:  val_32, selector:  val_16));
            val_45 = val_37;
            val_46 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            goto label_46;
            label_3:
            val_47 = 三丂丑丁丞丞丅东三;
            return Progress.AdaptiveProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_47 = 丛三七丟丗与专丙丂);
            label_4:
            return Progress.AdaptiveProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_47);
            label_15:
            System.Collections.Generic.List<System.Int32> val_19 = new System.Collections.Generic.List<System.Int32>();
            if(val_28 != null)
            {
                goto label_48;
            }
            
            goto label_49;
            label_19:
            System.Collections.Generic.List<System.Int32> val_20 = new System.Collections.Generic.List<System.Int32>();
            if(val_28 != null)
            {
                goto label_50;
            }
            
            goto label_51;
            label_23:
            System.Collections.Generic.List<System.String> val_21 = new System.Collections.Generic.List<System.String>();
            if(val_28 != null)
            {
                goto label_52;
            }
            
            goto label_53;
            label_27:
            System.Collections.Generic.List<System.String> val_22 = null;
            val_44 = val_22;
            val_22 = new System.Collections.Generic.List<System.String>();
            val_45 = "si";
            val_46 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            label_46:
            val_3.Add(key:  val_45, value:  val_22);
            label_39:
            val_48 = 三丂丑丁丞丞丅东三.OffersShowCounter;
            if(val_48 == null)
            {
                goto label_55;
            }
            
            if(丛三七丟丗与专丙丂.OffersShowCounter == null)
            {
                goto label_56;
            }
            
            if((System.Linq.Enumerable.SequenceEqual<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>(first:  val_48, second:  丛三七丟丗与专丙丂.OffersShowCounter)) == true)
            {
                goto label_57;
            }
            
            val_48 = 三丂丑丁丞丞丅东三.OffersShowCounter;
            label_56:
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_24 = null;
            val_37 = val_24;
            val_24 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(dictionary:  val_48);
            val_49 = "sh";
            val_50 = 1152921516595677584;
            val_51 = val_37;
            goto label_59;
            label_55:
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_25 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_49 = "sh";
            val_50 = 1152921516595677584;
            val_51 = val_25;
            label_59:
            val_3.Add(key:  val_49, value:  val_25);
            label_57:
            val_52 = 三丂丑丁丞丞丅东三.GadgetsLastViewed;
            if(val_52 != null)
            {
                    if(丛三七丟丗与专丙丂.GadgetsLastViewed != null)
            {
                    if((System.Linq.Enumerable.SequenceEqual<System.String>(first:  val_52, second:  丛三七丟丗与专丙丂.GadgetsLastViewed)) == true)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_28;
            }
            
                val_52 = 三丂丑丁丞丞丅东三.GadgetsLastViewed;
            }
            
                val_53 = "glv";
                val_54 = 1152921516595677584;
                val_55 = System.Linq.Enumerable.ToList<System.String>(source:  val_52);
            }
            else
            {
                    if(丛三七丟丗与专丙丂.GadgetsLastViewed == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_28;
            }
            
                val_53 = "glv";
                val_54 = 1152921516595677584;
                val_55 = 0;
            }
            
            val_3.Add(key:  val_53, value:  val_55);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_28;
        }
        public AdaptiveProgress()
        {
            this.SkippedItems = new System.Collections.Generic.List<SkippedItem>();
            this.Weapons_BoughtCategoryes = new System.Collections.Generic.List<System.Int32>();
            this.Weapons_LastViewedCategoryes = new System.Collections.Generic.List<System.Int32>();
            this.IgnoreOffers = new System.Collections.Generic.List<System.String>();
            this.PreviousViewedPet = System.String.alignConst;
            this.OffersShowCounter = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        }
    
    }

}
