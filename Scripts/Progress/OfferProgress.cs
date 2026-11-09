using UnityEngine;

namespace Progress
{
    [Serializable]
    internal class OfferProgress : ICloneable
    {
        // Fields
        internal string Id;
        internal int FirstShowDate;
        internal bool IsBought;
        internal System.Collections.Generic.Dictionary<string, int> ConditionsProgress;
        internal System.Collections.Generic.List<Rilisoft.OfferItem> BoughtItems;
        internal System.Collections.Generic.List<Rilisoft.OfferItem> PreparedItems;
        internal int PreparedItemsForPlayerPayment;
        internal System.Collections.Generic.List<Rilisoft.OfferItem> IgnoreItems;
        
        // Methods
        internal OfferProgress()
        {
            this.Id = System.String.alignConst;
            this.ConditionsProgress = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.BoughtItems = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this.PreparedItems = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this.IgnoreItems = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        }
        internal OfferProgress(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
        {
            this.Id = System.String.alignConst;
            this.ConditionsProgress = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.BoughtItems = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this.PreparedItems = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this.IgnoreItems = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this.丅丐丂丑丆丌丟万丌(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒);
        }
        internal void 丅丐丂丑丆丌丟万丌(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
        {
            int val_41;
            int val_42;
            var val_43;
            var val_44;
            System.Func<System.String, Rilisoft.OfferItem> val_45;
            System.Collections.Generic.IEnumerable<TSource> val_46;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_47;
            var val_48;
            System.Collections.Generic.IDictionary<TKey, TValue> val_49;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_50;
            var val_51;
            var val_52;
            System.Func<System.String, Rilisoft.OfferItem> val_53;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_54;
            var val_55;
            int val_56;
            OfferProgress.<>c val_57;
            var val_58;
            System.Func<System.String, Rilisoft.OfferItem> val_59;
            System.Collections.Generic.IEnumerable<TSource> val_60;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_61;
            var val_62;
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "id")) == false)
            {
                goto label_2;
            }
            
            object val_2 = 丏丂万业丙专丏丒丒.Item["id"];
            if(val_2 == null)
            {
                goto label_4;
            }
            
            var val_3 = (null == null) ? (val_2) : 0;
            if(this != null)
            {
                goto label_26;
            }
            
            goto label_27;
            label_2:
            val_41 = System.String.alignConst;
            if(this != null)
            {
                goto label_26;
            }
            
            label_27:
            label_26:
            this.Id = val_41;
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "fs")) != false)
            {
                    object val_5 = 丏丂万业丙专丏丒丒.Item["fs"];
            }
            else
            {
                    val_42 = 0;
            }
            
            this.FirstShowDate = val_42;
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "bi")) == false)
            {
                goto label_13;
            }
            
            object val_7 = 丏丂万业丙专丏丒丒.Item["bi"];
            val_43 = 1152921505358282752;
            val_44 = null;
            val_44 = null;
            val_45 = OfferProgress.<>c.<>9__10_0;
            val_46 = 0;
            if(val_45 == null)
            {
                goto label_20;
            }
            
            val_46 = 0;
            goto label_77;
            label_13:
            System.Collections.Generic.List<Rilisoft.OfferItem> val_11 = null;
            val_47 = val_11;
            val_11 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            goto label_25;
            label_4:
            if(this != null)
            {
                goto label_26;
            }
            
            goto label_27;
            label_20:
            val_48 = null;
            val_48 = null;
            System.Func<System.String, Rilisoft.OfferItem> val_12 = null;
            val_45 = val_12;
            val_12 = new System.Func<System.String, Rilisoft.OfferItem>(object:  OfferProgress.<>c.<>9, method:  Rilisoft.OfferItem OfferProgress.<>c::丝业且万丐丐丏丘丌(string 七丞丙丒三丕且丌丟));
            OfferProgress.<>c.<>9__10_0 = val_45;
            label_77:
            val_47 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.String, Rilisoft.OfferItem>(source:  val_46, selector:  val_12));
            label_25:
            this.BoughtItems = val_47;
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "cp")) != false)
            {
                    val_46 = 1152921504689381376;
                val_49 = 丏丂万业丙专丏丒丒.Item["cp"];
                val_50 = null;
                if(val_49 != null)
            {
                    val_49 = 0;
            }
            
                val_50 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(dictionary:  val_49);
            }
            else
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_19 = null;
                val_50 = val_19;
                val_19 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            this.ConditionsProgress = val_50;
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "b")) != false)
            {
                    object val_21 = 丏丂万业丙专丏丒丒.Item["b"];
            }
            else
            {
                    val_51 = 0;
            }
            
            this.IsBought = (val_51 != 0) ? 1 : 0;
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "pi")) == false)
            {
                goto label_42;
            }
            
            object val_24 = 丏丂万业丙专丏丒丒.Item["pi"];
            val_43 = 1152921505358282752;
            val_52 = null;
            val_52 = null;
            val_53 = OfferProgress.<>c.<>9__10_1;
            val_46 = 0;
            if(val_53 == null)
            {
                goto label_49;
            }
            
            val_46 = 0;
            goto label_78;
            label_42:
            System.Collections.Generic.List<Rilisoft.OfferItem> val_27 = null;
            val_54 = val_27;
            val_27 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            goto label_54;
            label_49:
            val_55 = null;
            val_55 = null;
            System.Func<System.String, Rilisoft.OfferItem> val_28 = null;
            val_53 = val_28;
            val_28 = new System.Func<System.String, Rilisoft.OfferItem>(object:  OfferProgress.<>c.<>9, method:  Rilisoft.OfferItem OfferProgress.<>c::三丁丝丒丈丌丅丘丑(string 七丞丙丒三丕且丌丟));
            OfferProgress.<>c.<>9__10_1 = val_53;
            label_78:
            val_54 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.String, Rilisoft.OfferItem>(source:  val_46, selector:  val_28));
            label_54:
            this.PreparedItems = val_54;
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "pp")) != false)
            {
                    object val_32 = 丏丂万业丙专丏丒丒.Item["pp"];
            }
            else
            {
                    val_56 = 0;
            }
            
            this.PreparedItemsForPlayerPayment = val_56;
            val_57 = "ii";
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "ii")) == false)
            {
                goto label_62;
            }
            
            val_46 = 1152921505358282752;
            val_57 = 丏丂万业丙专丏丒丒.Item["ii"];
            val_58 = null;
            val_58 = null;
            val_59 = OfferProgress.<>c.<>9__10_2;
            val_60 = 0;
            if(val_59 == null)
            {
                goto label_69;
            }
            
            val_60 = 0;
            goto label_79;
            label_62:
            System.Collections.Generic.List<Rilisoft.OfferItem> val_37 = null;
            val_61 = val_37;
            val_37 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            goto label_74;
            label_69:
            val_62 = null;
            val_62 = null;
            val_57 = OfferProgress.<>c.<>9;
            System.Func<System.String, Rilisoft.OfferItem> val_38 = null;
            val_59 = val_38;
            val_38 = new System.Func<System.String, Rilisoft.OfferItem>(object:  val_57, method:  Rilisoft.OfferItem OfferProgress.<>c::下丂丅丕东东且丄丕(string 七丞丙丒三丕且丌丟));
            OfferProgress.<>c.<>9__10_2 = val_59;
            label_79:
            val_61 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.String, Rilisoft.OfferItem>(source:  val_60, selector:  val_38));
            label_74:
            this.IgnoreItems = val_61;
        }
        internal void 丂丗丞丞且万丛万不(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
        {
            string val_36;
            var val_37;
            var val_38;
            System.Func<System.String, Rilisoft.OfferItem> val_39;
            System.Collections.Generic.IEnumerable<TSource> val_40;
            var val_41;
            System.Collections.Generic.IDictionary<TKey, TValue> val_42;
            var val_43;
            System.Func<System.String, Rilisoft.OfferItem> val_44;
            var val_45;
            OfferProgress.<>c val_46;
            var val_47;
            System.Func<System.String, Rilisoft.OfferItem> val_48;
            System.Collections.Generic.IEnumerable<TSource> val_49;
            var val_50;
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "id")) != false)
            {
                    object val_2 = 丏丂万业丙专丏丒丒.Item["id"];
                if(val_2 != null)
            {
                    var val_3 = (null == null) ? (val_2) : 0;
            }
            else
            {
                    val_36 = 0;
            }
            
                this.Id = val_36;
            }
            
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "fs")) != false)
            {
                    object val_5 = 丏丂万业丙专丏丒丒.Item["fs"];
                this.FirstShowDate = null;
            }
            
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "bi")) != false)
            {
                    object val_7 = 丏丂万业丙专丏丒丒.Item["bi"];
                val_37 = 1152921505358282752;
                val_38 = null;
                val_38 = null;
                val_39 = OfferProgress.<>c.<>9__11_0;
                val_40 = 0;
                if(val_39 != null)
            {
                    val_40 = 0;
            }
            else
            {
                    val_41 = null;
                val_41 = null;
                System.Func<System.String, Rilisoft.OfferItem> val_11 = null;
                val_39 = val_11;
                val_11 = new System.Func<System.String, Rilisoft.OfferItem>(object:  OfferProgress.<>c.<>9, method:  Rilisoft.OfferItem OfferProgress.<>c::且丂丞丗专丁丙丟不(string 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__11_0 = val_39;
            }
            
                this.BoughtItems = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.String, Rilisoft.OfferItem>(source:  val_40, selector:  val_11));
            }
            
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "cp")) != false)
            {
                    val_40 = 1152921504689381376;
                val_42 = 丏丂万业丙专丏丒丒.Item["cp"];
                if(val_42 != null)
            {
                    val_42 = 0;
            }
            
                System.Collections.Generic.Dictionary<System.String, System.Int32> val_17 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(dictionary:  val_42);
                this.ConditionsProgress = null;
            }
            
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "b")) != false)
            {
                    object val_19 = 丏丂万业丙专丏丒丒.Item["b"];
                this.IsBought = null;
            }
            
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "pi")) != false)
            {
                    object val_21 = 丏丂万业丙专丏丒丒.Item["pi"];
                val_37 = 1152921505358282752;
                val_43 = null;
                val_43 = null;
                val_44 = OfferProgress.<>c.<>9__11_1;
                val_40 = 0;
                if(val_44 != null)
            {
                    val_40 = 0;
            }
            else
            {
                    val_45 = null;
                val_45 = null;
                System.Func<System.String, Rilisoft.OfferItem> val_24 = null;
                val_44 = val_24;
                val_24 = new System.Func<System.String, Rilisoft.OfferItem>(object:  OfferProgress.<>c.<>9, method:  Rilisoft.OfferItem OfferProgress.<>c::且丞世丞丙丏七下丁(string 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__11_1 = val_44;
            }
            
                this.PreparedItems = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.String, Rilisoft.OfferItem>(source:  val_40, selector:  val_24));
            }
            
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "pp")) != false)
            {
                    object val_28 = 丏丂万业丙专丏丒丒.Item["pp"];
                this.PreparedItemsForPlayerPayment = null;
            }
            
            val_46 = "ii";
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "ii")) == false)
            {
                    return;
            }
            
            val_40 = 1152921505358282752;
            val_46 = 丏丂万业丙专丏丒丒.Item["ii"];
            val_47 = null;
            val_47 = null;
            val_48 = OfferProgress.<>c.<>9__11_2;
            val_49 = 0;
            if(val_48 != null)
            {
                    val_49 = 0;
            }
            else
            {
                    val_50 = null;
                val_50 = null;
                val_46 = OfferProgress.<>c.<>9;
                System.Func<System.String, Rilisoft.OfferItem> val_33 = null;
                val_48 = val_33;
                val_33 = new System.Func<System.String, Rilisoft.OfferItem>(object:  val_46, method:  Rilisoft.OfferItem OfferProgress.<>c::丛丆三丄丒丘上丁丈(string 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__11_2 = val_48;
            }
            
            this.IgnoreItems = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.String, Rilisoft.OfferItem>(source:  val_49, selector:  val_33));
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙(Progress.OfferProgress 七丏丄丅丌业与且丙)
        {
            var val_16;
            System.Func<Rilisoft.OfferItem, System.String> val_18;
            var val_19;
            System.Func<Rilisoft.OfferItem, System.String> val_21;
            var val_22;
            System.Func<Rilisoft.OfferItem, System.String> val_24;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "id", value:  七丏丄丅丌业与且丙.Id);
            val_1.set_Item(key:  "fs", value:  七丏丄丅丌业与且丙.FirstShowDate);
            if(七丏丄丅丌业与且丙.BoughtItems == null)
            {
                goto label_4;
            }
            
            val_16 = null;
            val_16 = null;
            val_18 = OfferProgress.<>c.<>9__12_0;
            if(val_18 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_2 = null;
                val_18 = val_2;
                val_2 = new System.Func<Rilisoft.OfferItem, System.String>(object:  OfferProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String OfferProgress.<>c::丁丞且丘丙万三且上(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__12_0 = val_18;
            }
            
            if(val_1 != null)
            {
                goto label_29;
            }
            
            label_30:
            label_29:
            val_1.set_Item(key:  "bi", value:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  七丏丄丅丌业与且丙.BoughtItems, selector:  val_2)));
            if(七丏丄丅丌业与且丙.ConditionsProgress == null)
            {
                goto label_11;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(dictionary:  七丏丄丅丌业与且丙.ConditionsProgress);
            if(val_1 != null)
            {
                goto label_31;
            }
            
            label_32:
            label_31:
            val_1.set_Item(key:  "cp", value:  null);
            val_1.set_Item(key:  "b", value:  七丏丄丅丌业与且丙.IsBought);
            if(七丏丄丅丌业与且丙.PreparedItems == null)
            {
                goto label_14;
            }
            
            val_19 = null;
            val_19 = null;
            val_21 = OfferProgress.<>c.<>9__12_1;
            if(val_21 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_6 = null;
                val_21 = val_6;
                val_6 = new System.Func<Rilisoft.OfferItem, System.String>(object:  OfferProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String OfferProgress.<>c::丛一丏丈丆不丙三业(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__12_1 = val_21;
            }
            
            if(val_1 != null)
            {
                goto label_33;
            }
            
            label_34:
            label_33:
            val_1.set_Item(key:  "pi", value:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  七丏丄丅丌业与且丙.PreparedItems, selector:  val_6)));
            val_1.set_Item(key:  "pp", value:  七丏丄丅丌业与且丙.PreparedItemsForPlayerPayment);
            if(七丏丄丅丌业与且丙.IgnoreItems == null)
            {
                goto label_22;
            }
            
            val_22 = null;
            val_22 = null;
            val_24 = OfferProgress.<>c.<>9__12_2;
            if(val_24 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_9 = null;
                val_24 = val_9;
                val_9 = new System.Func<Rilisoft.OfferItem, System.String>(object:  OfferProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String OfferProgress.<>c::丁丑丏丙丆丅丞丅丞(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__12_2 = val_24;
            }
            
            if(val_1 != null)
            {
                goto label_35;
            }
            
            label_36:
            label_35:
            val_1.set_Item(key:  "ii", value:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  七丏丄丅丌业与且丙.IgnoreItems, selector:  val_9)));
            return val_1;
            label_4:
            System.Collections.Generic.List<System.String> val_12 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                goto label_29;
            }
            
            goto label_30;
            label_11:
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_13 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            if(val_1 != null)
            {
                goto label_31;
            }
            
            goto label_32;
            label_14:
            System.Collections.Generic.List<System.String> val_14 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                goto label_33;
            }
            
            goto label_34;
            label_22:
            System.Collections.Generic.List<System.String> val_15 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                goto label_35;
            }
            
            goto label_36;
        }
        internal static Progress.OfferProgress 且丘万丙丝丈丆专与(System.Collections.Generic.Dictionary<string, object> 七丏丄丅丌业与且丙)
        {
            Progress.OfferProgress val_1 = new Progress.OfferProgress();
            val_1.丅丐丂丑丆丌丟万丌(丏丂万业丙专丏丒丒:  七丏丄丅丌业与且丙);
            return val_1;
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丝丟丛丘一一且上三(Progress.OfferProgress 丛三七丟丗与专丙丂, Progress.OfferProgress 三丂丑丁丞丞丅东三)
        {
            System.Collections.Generic.List<Rilisoft.OfferItem> val_25;
            var val_26;
            System.Func<Rilisoft.OfferItem, System.String> val_28;
            object val_29;
            string val_30;
            var val_31;
            Progress.OfferProgress val_32;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_33;
            var val_34;
            System.Func<Rilisoft.OfferItem, System.String> val_36;
            object val_37;
            string val_38;
            var val_39;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_40;
            var val_41;
            System.Func<Rilisoft.OfferItem, System.String> val_43;
            object val_44;
            string val_45;
            var val_46;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_47;
            if((三丂丑丁丞丞丅东三 | 丛三七丟丗与专丙丂) == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            if(丛三七丟丗与专丙丂 == null)
            {
                goto label_2;
            }
            
            if(三丂丑丁丞丞丅东三 == null)
            {
                goto label_3;
            }
            
            if((System.String.op_Inequality(a:  丛三七丟丗与专丙丂.Id, b:  三丂丑丁丞丞丅东三.Id)) == true)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(三丂丑丁丞丞丅东三.FirstShowDate != 丛三七丟丗与专丙丂.FirstShowDate)
            {
                    val_4.Add(key:  "fs", value:  三丂丑丁丞丞丅东三.FirstShowDate);
            }
            
            if(((三丂丑丁丞丞丅东三.IsBought == true) ? 1 : 0) != ((丛三七丟丗与专丙丂.IsBought == true) ? 1 : 0))
            {
                    val_4.Add(key:  "b", value:  三丂丑丁丞丞丅东三.IsBought);
            }
            
            if(三丂丑丁丞丞丅东三.PreparedItemsForPlayerPayment != 丛三七丟丗与专丙丂.PreparedItemsForPlayerPayment)
            {
                    val_4.Add(key:  "pp", value:  三丂丑丁丞丞丅东三.PreparedItemsForPlayerPayment);
            }
            
            val_25 = 三丂丑丁丞丞丅东三.BoughtItems;
            if(val_25 == null)
            {
                goto label_11;
            }
            
            if(丛三七丟丗与专丙丂.BoughtItems == null)
            {
                goto label_12;
            }
            
            if((System.Linq.Enumerable.SequenceEqual<Rilisoft.OfferItem>(first:  val_25, second:  丛三七丟丗与专丙丂.BoughtItems)) == true)
            {
                goto label_13;
            }
            
            val_25 = 三丂丑丁丞丞丅东三.BoughtItems;
            label_12:
            val_26 = null;
            val_26 = null;
            val_28 = OfferProgress.<>c.<>9__14_0;
            if(val_28 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_8 = null;
                val_28 = val_8;
                val_8 = new System.Func<Rilisoft.OfferItem, System.String>(object:  OfferProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String OfferProgress.<>c::世业丐一丌丅业不上(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__14_0 = val_28;
            }
            
            val_29 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  val_25, selector:  val_8));
            val_30 = "bi";
            val_31 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            goto label_20;
            label_2:
            val_32 = 三丂丑丁丞丞丅东三;
            return Progress.OfferProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_32 = 丛三七丟丗与专丙丂);
            label_3:
            return Progress.OfferProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_32);
            label_11:
            System.Collections.Generic.List<System.String> val_11 = null;
            val_29 = val_11;
            val_11 = new System.Collections.Generic.List<System.String>();
            val_30 = "bi";
            val_31 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            label_20:
            val_4.Add(key:  val_30, value:  val_11);
            label_13:
            val_33 = 三丂丑丁丞丞丅东三.PreparedItems;
            if(val_33 == null)
            {
                goto label_23;
            }
            
            if(丛三七丟丗与专丙丂.PreparedItems == null)
            {
                goto label_24;
            }
            
            if((System.Linq.Enumerable.SequenceEqual<Rilisoft.OfferItem>(first:  val_33, second:  丛三七丟丗与专丙丂.PreparedItems)) == true)
            {
                goto label_25;
            }
            
            val_33 = 三丂丑丁丞丞丅东三.PreparedItems;
            label_24:
            val_34 = null;
            val_34 = null;
            val_36 = OfferProgress.<>c.<>9__14_1;
            if(val_36 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_13 = null;
                val_36 = val_13;
                val_13 = new System.Func<Rilisoft.OfferItem, System.String>(object:  OfferProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String OfferProgress.<>c::且丝且丄丑丙丒与上(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__14_1 = val_36;
            }
            
            val_37 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  val_33, selector:  val_13));
            val_38 = "pi";
            val_39 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            goto label_32;
            label_23:
            System.Collections.Generic.List<System.String> val_16 = null;
            val_37 = val_16;
            val_16 = new System.Collections.Generic.List<System.String>();
            val_38 = "pi";
            val_39 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            label_32:
            val_4.Add(key:  val_38, value:  val_16);
            label_25:
            val_40 = 三丂丑丁丞丞丅东三.IgnoreItems;
            if(val_40 == null)
            {
                goto label_34;
            }
            
            if(丛三七丟丗与专丙丂.IgnoreItems == null)
            {
                goto label_35;
            }
            
            if((System.Linq.Enumerable.SequenceEqual<Rilisoft.OfferItem>(first:  val_40, second:  丛三七丟丗与专丙丂.IgnoreItems)) == true)
            {
                goto label_36;
            }
            
            val_40 = 三丂丑丁丞丞丅东三.IgnoreItems;
            label_35:
            val_41 = null;
            val_41 = null;
            val_43 = OfferProgress.<>c.<>9__14_2;
            if(val_43 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_18 = null;
                val_43 = val_18;
                val_18 = new System.Func<Rilisoft.OfferItem, System.String>(object:  OfferProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.String OfferProgress.<>c::丅不不七丕且丂丘一(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__14_2 = val_43;
            }
            
            val_44 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  val_40, selector:  val_18));
            val_45 = "ii";
            val_46 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            goto label_43;
            label_34:
            System.Collections.Generic.List<System.String> val_21 = null;
            val_44 = val_21;
            val_21 = new System.Collections.Generic.List<System.String>();
            val_45 = "ii";
            val_46 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            label_43:
            val_4.Add(key:  val_45, value:  val_21);
            label_36:
            val_47 = 三丂丑丁丞丞丅东三.ConditionsProgress;
            if(val_47 == null)
            {
                goto label_45;
            }
            
            if(丛三七丟丗与专丙丂.ConditionsProgress != null)
            {
                    if((System.Linq.Enumerable.SequenceEqual<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>(first:  val_47, second:  丛三七丟丗与专丙丂.ConditionsProgress)) == true)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
                val_47 = 三丂丑丁丞丞丅东三.ConditionsProgress;
            }
            
            if(val_4 != null)
            {
                goto label_50;
            }
            
            label_51:
            label_50:
            val_4.Add(key:  "cp", value:  new System.Collections.Generic.Dictionary<System.String, System.Int32>(dictionary:  val_47));
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            label_45:
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_24 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            if(val_4 != null)
            {
                goto label_50;
            }
            
            goto label_51;
        }
        public object Clone()
        {
            int val_16;
            var val_17;
            System.Func<Rilisoft.OfferItem, Rilisoft.OfferItem> val_19;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_20;
            var val_21;
            System.Func<Rilisoft.OfferItem, Rilisoft.OfferItem> val_23;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_24;
            var val_25;
            System.Func<Rilisoft.OfferItem, Rilisoft.OfferItem> val_27;
            Progress.OfferProgress val_1 = new Progress.OfferProgress();
            if(val_1 != null)
            {
                    .Id = this.Id;
                val_16 = this.FirstShowDate;
            }
            else
            {
                    mem[16] = this.Id;
                val_16 = this.FirstShowDate;
            }
            
            .FirstShowDate = val_16;
            if(this.BoughtItems != null)
            {
                    val_17 = null;
                val_17 = null;
                val_19 = OfferProgress.<>c.<>9__15_0;
                if(val_19 == null)
            {
                    System.Func<Rilisoft.OfferItem, Rilisoft.OfferItem> val_2 = null;
                val_19 = val_2;
                val_2 = new System.Func<Rilisoft.OfferItem, Rilisoft.OfferItem>(object:  OfferProgress.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem OfferProgress.<>c::丂丌丑与丛丆丌丕与(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__15_0 = val_19;
            }
            
                val_20 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, Rilisoft.OfferItem>(source:  this.BoughtItems, selector:  val_2));
            }
            else
            {
                    System.Collections.Generic.List<Rilisoft.OfferItem> val_5 = null;
                val_20 = val_5;
                val_5 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            }
            
            .BoughtItems = val_20;
            if(this.ConditionsProgress != null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(dictionary:  this.ConditionsProgress);
            }
            else
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            .ConditionsProgress = null;
            .IsBought = this.IsBought;
            if(this.PreparedItems != null)
            {
                    val_21 = null;
                val_21 = null;
                val_23 = OfferProgress.<>c.<>9__15_1;
                if(val_23 == null)
            {
                    System.Func<Rilisoft.OfferItem, Rilisoft.OfferItem> val_8 = null;
                val_23 = val_8;
                val_8 = new System.Func<Rilisoft.OfferItem, Rilisoft.OfferItem>(object:  OfferProgress.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem OfferProgress.<>c::下丟下丙丏上丈丛丒(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__15_1 = val_23;
            }
            
                val_24 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, Rilisoft.OfferItem>(source:  this.PreparedItems, selector:  val_8));
            }
            else
            {
                    System.Collections.Generic.List<Rilisoft.OfferItem> val_11 = null;
                val_24 = val_11;
                val_11 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            }
            
            .PreparedItems = val_24;
            .PreparedItemsForPlayerPayment = this.PreparedItemsForPlayerPayment;
            if(this.IgnoreItems == null)
            {
                goto label_19;
            }
            
            val_25 = null;
            val_25 = null;
            val_27 = OfferProgress.<>c.<>9__15_2;
            if(val_27 == null)
            {
                    System.Func<Rilisoft.OfferItem, Rilisoft.OfferItem> val_12 = null;
                val_27 = val_12;
                val_12 = new System.Func<Rilisoft.OfferItem, Rilisoft.OfferItem>(object:  OfferProgress.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem OfferProgress.<>c::一七丛丝一上丑三丈(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                OfferProgress.<>c.<>9__15_2 = val_27;
            }
            
            if(val_1 != null)
            {
                goto label_26;
            }
            
            label_27:
            label_26:
            .IgnoreItems = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, Rilisoft.OfferItem>(source:  this.IgnoreItems, selector:  val_12));
            return (object)val_1;
            label_19:
            System.Collections.Generic.List<Rilisoft.OfferItem> val_15 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            if(val_1 != null)
            {
                goto label_26;
            }
            
            goto label_27;
        }
    
    }

}
