using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 丙东丄万万丑东丘丅 : 丛丝下且丟丈丞丈丗
    {
        // Fields
        private readonly System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丕丞东七丆专丕丈丙;
        private System.Collections.Generic.List<int> 丕业万三专世丁且丛;
        private System.Collections.Generic.List<Rilisoft.CuttedOfferItem> 与丏丒世不丞三业丂;
        private System.Collections.Generic.List<Rilisoft.OfferItem> 丝丌丝丁上上丅丐万;
        private Rilisoft.Offers.东下上东丅丂丘丗丙.丂七丄不专下丘丂丟 七东下丅丙世与丐丒;
        private System.Collections.Generic.IDictionary<int, Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅> 下业丌丟丗丅且丁丏;
        private static Rilisoft.且丈丞一丞丟与上七 七丞丏世专丌丐丟上;
        private System.Collections.Generic.List<Rilisoft.Offers.东下上东丅丂丘丗丙.丂七丄不专下丘丂丟> 丄丞三丑上丒丈丞东;
        private static Rilisoft.且丈丞一丞丟与上七 丅丞丗且丞丏丏丐与;
        internal static readonly System.Collections.Generic.List<CategoryNames> 业丁丂丐下万丅三丅;
        
        // Properties
        internal override Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丒三丝一上丙专丗丒 { get; }
        internal override System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丁丛丁丗丙万丐丈丁 { get; }
        internal override System.Collections.Generic.List<int> 丘丄世丅丄丕与丛丂 { get; }
        internal static System.Nullable<CategoryNames> 丂与万丘丕一丌丘丛 { get; set; }
        internal static int 东专一丝东丟丛丆丑 { get; set; }
        
        // Methods
        internal override Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 不业丙丒丂丞下丆丙()
        {
            return 30;
        }
        internal override System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丞丏上丘丈上万一七()
        {
            return (System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem>)this.丕丞东七丆专丕丈丙;
        }
        internal override System.Collections.Generic.List<int> 且一专丅丞丏七丙丟()
        {
            return (System.Collections.Generic.List<System.Int32>)this.丕业万三专世丁且丛;
        }
        internal static System.Nullable<CategoryNames> 丏上丐丘七丙下丑业()
        {
            var val_4;
            Rilisoft.且丈丞一丞丟与上七 val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = Rilisoft.Offers.丙东丄万万丑东丘丅.七丞丏世专丌丐丟上;
            if(val_5.世三丞丅丑丌丈丈一() >= 1)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = Rilisoft.Offers.丙东丄万万丑东丘丅.七丞丏世专丌丐丟上;
                int val_3 = val_5.世三丞丅丑丌丈丈一() - 1;
                val_7 = 0;
                return (System.Nullable<CategoryNames>)val_7;
            }
            
            val_7 = 0;
            return (System.Nullable<CategoryNames>)val_7;
        }
        internal static void 专七丂丘丄世丘不丒(System.Nullable<CategoryNames> 丙业与丙丗丝不丈东)
        {
            var val_1;
            var val_2;
            Rilisoft.且丈丞一丞丟与上七 val_3;
            var val_4;
            var val_5;
            var val_6;
            val_1 = null;
            if((488051992 & 1) != 0)
            {
                    val_2 = null;
                val_3 = Rilisoft.Offers.丙东丄万万丑东丘丅.七丞丏世专丌丐丟上;
                val_4 = 1152921531052698208;
            }
            else
            {
                    val_6 = null;
                val_3 = Rilisoft.Offers.丙东丄万万丑东丘丅.七丞丏世专丌丐丟上;
                val_4 = 1152921531052698208;
                val_5 = 0;
            }
            
            val_3.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  0);
        }
        private void 丐丅万与东丞丁丛丘()
        {
            var val_6;
            var val_22;
            ulong val_23;
            var val_24;
            System.Collections.Generic.IDictionary<System.Int32, 丂丘丛下丆一丕丂丅> val_26;
            if(this.丝丌丝丁上上丅丐万 != null)
            {
                    this.丝丌丝丁上上丅丐万.Clear();
            }
            else
            {
                    this.丝丌丝丁上上丅丐万 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            }
            
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_2 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            if(val_2.丌万丟上丟七东万丘 == null)
            {
                goto label_19;
            }
            
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_3 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            List.Enumerator<T> val_4 = val_3.丌万丟上丟七东万丘.GetEnumerator();
            val_22 = 1152921519126359200;
            label_13:
            if((488240720 & 1) == 0)
            {
                goto label_11;
            }
            
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  46, 丞一丁业丄一一业且:  val_6.丐丏七丌丕丗业且上(), 丂丕丂丏专丂丄丕且:  1);
            this.丝丌丝丁上上丅丐万.Add(item:  new Rilisoft.OfferItem());
            goto label_13;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_19:
            this.丕业万三专世丁且丛 = this.下丁丞丈丌丐丂丞丕();
            System.DateTime val_10 = System.DateTime.UtcNow;
            val_6 = 0;
            int val_11 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "pci");
            System.DateTime val_13 = val_10.dateData.AddDays(value:  (val_11 > 0) ? ((double)-val_11) : -365);
            val_23 = val_10.dateData;
            this.与丏丒世不丞三业丂 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().与七丈丄一丂丁世上(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_13.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_23});
            丂七丄不专下丘丂丟 val_16 = this.与丐丅丛丗东世世丑();
            this.七东下丅丙世与丐丒 = val_16;
            if(val_16 != null)
            {
                    val_22 = 1152921505503649792;
                val_24 = null;
                val_24 = null;
                val_23 = 丙东丄万万丑东丘丅.<>c.<>9__16_0;
                if(val_23 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.DataObjects.IntInterval>, System.Int32> val_17 = null;
                val_23 = val_17;
                val_17 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.DataObjects.IntInterval>, System.Int32>(object:  丙东丄万万丑东丘丅.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丙东丄万万丑东丘丅.<>c::丄丁下丛三丑丒不不(System.Collections.Generic.KeyValuePair<int, PGCompany.DataObjects.IntInterval> 丅三丄丕丁丘丘业三));
                丙东丄万万丑东丘丅.<>c.<>9__16_0 = val_23;
            }
            
                val_26 = Rilisoft.Offers.丛丝下且丟丈丞丈丗.业下丈丘万丗丟丒丑(丏丅东丙东业三丈丗:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.DataObjects.IntInterval>, System.Int32>(source:  val_16.丏丆丂丘丆世丘下丅, selector:  val_17));
            }
            else
            {
                    System.Collections.Generic.Dictionary<System.Int32, 丂丘丛下丆一丕丂丅> val_20 = null;
                val_26 = val_20;
                val_20 = new System.Collections.Generic.Dictionary<System.Int32, 丂丘丛下丆一丕丂丅>();
            }
            
            this.下业丌丟丗丅且丁丏 = val_26;
        }
        internal override void 丐世丑与丏世丗丑上(bool 下丕丆世专丅丕丘世)
        {
            var val_3;
            var val_25;
            var val_26;
            var val_27;
            var val_29;
            var val_31;
            var val_32;
            var val_36;
            if(下丕丆世专丅丕丘世 != false)
            {
                    this.丐丅万与东丞丁丛丘();
            }
            
            List.Enumerator<T> val_1 = this.丕丞东七丆专丕丈丙.GetEnumerator();
            label_5:
            if((488488912 & 1) == 0)
            {
                goto label_3;
            }
            
            val_3.丐丏七丌丕丗业且上().Dispose();
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丕丞东七丆专丕丈丙.Clear();
            if(this.七东下丅丙世与丐丒 == null)
            {
                    return;
            }
            
            if(this.七东下丅丙世与丐丒.一丞东丅一上丒万且 == null)
            {
                    return;
            }
            
            if(this.七东下丅丙世与丐丒.丏丆丂丘丆世丘下丅 == null)
            {
                    return;
            }
            
            if(this.七东下丅丙世与丐丒.丏丆丂丘丆世丘下丅.Count == 0)
            {
                    return;
            }
            
            if(this.丝丌丝丁上上丅丐万 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_6 = this.丝丌丝丁上上丅丐万.GetEnumerator();
            val_26 = 0;
            val_27 = 0;
            label_66:
            if((488488880 & 1) == 0)
            {
                goto label_16;
            }
            
            string val_7 = val_3.丐丏七丌丕丗业且上();
            System.Nullable<CategoryNames> val_8 = val_7.Category;
            if(((488488872 & 1) == 0) || (val_7.IsExists == true))
            {
                goto label_66;
            }
            
            int val_10 = val_7.PartsLeft;
            if((val_10 & 2147483648) != 0)
            {
                goto label_66;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_11 = this.七东下丅丙世与丐丒.丏丆丂丘丆世丘下丅.GetEnumerator();
            label_47:
            if((488488832 & 1) == 0)
            {
                goto label_25;
            }
            
            ConfiguredValueTaskAwaiter val_13 = val_3.GetAwaiter();
            if(val_10 < val_13._value._obj.From)
            {
                goto label_47;
            }
            
            if(val_10 > val_13._value._obj.To)
            {
                goto label_47;
            }
            
            int val_16 = val_13._value._obj.丙东专丂世丈丏丁丂();
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_25 = 4;
            val_29 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
            if((this.下业丌丟丗丅且丁丏.ContainsKey(key:  60)) != false)
            {
                    int val_19 = val_13._value._obj.丙东专丂世丈丏丁丂();
                var val_26 = 0;
                val_26 = val_26 + 1;
                val_29 = 0;
            }
            
            Rilisoft.Offers.AdaptiveOfferItem val_23 = Rilisoft.Offers.AdaptiveOfferItem.丂丈世不七丆一丛下(丕上业丕丘上丘七一:  30, 世丈三丐丞一丒丛不:  val_13._value._obj.丙东专丂世丈丏丁丂(), 与丝丙丝万丑丞丄一:  0, 丟丒且一专丟丙下一:  this.下业丌丟丗丅且丁丏.Item[60], 丆且丁丒丒丆丁三丆:  0);
            val_23.丑与东丙丑丘丁丂丒(丁丅丈丌丟世丗丗丟:  46, 丞丅上丏丂且下丅与:  val_7.Id, 丌丒丝东丌下丕丁丅:  val_10);
            this.丕丞东七丆专丕丈丙.Add(item:  val_23);
            goto label_47;
            label_25:
            val_31 = val_27;
            val_32 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (60 != 387))
            {
                goto label_63;
            }
            
            var val_27 = 0;
            val_27 = val_27 ^ 0;
             =  + val_27;
            goto label_66;
            label_63:
            if( == 0)
            {
                goto label_66;
            }
            
            goto label_66;
            label_16:
            val_36 = 0 + 1;
            mem2[0] = 415;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_36 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((1152921543750041376 + ((0 + 1)) << 2) == 415)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        private Rilisoft.Offers.东下上东丅丂丘丗丙.丂七丄不专下丘丂丟 与丐丅丛丗东世世丑()
        {
            System.Collections.Generic.List<丂七丄不专下丘丂丟> val_28;
            var val_29;
            System.Func<Rilisoft.CuttedOfferItem, System.Boolean> val_31;
            丂七丄不专下丘丂丟 val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            System.Func<丂七丄不专下丘丂丟, System.Int32> val_38;
            int val_39;
            var val_40;
            var val_41;
            val_28 = this.丄丞三丑上丒丈丞东;
            if(val_28 != null)
            {
                goto label_1;
            }
            
            this.丄丞三丑上丒丈丞东 = new System.Collections.Generic.List<丂七丄不专下丘丂丟>();
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_2 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            if(this.与丏丒世不丞三业丂 == null)
            {
                goto label_11;
            }
            
            val_29 = null;
            val_29 = null;
            val_31 = 丙东丄万万丑东丘丅.<>c.<>9__19_0;
            if(val_31 == null)
            {
                    System.Func<Rilisoft.CuttedOfferItem, System.Boolean> val_3 = null;
                val_31 = val_3;
                val_3 = new System.Func<Rilisoft.CuttedOfferItem, System.Boolean>(object:  丙东丄万万丑东丘丅.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙东丄万万丑东丘丅.<>c::七丁丐三丆业丄七丁(Rilisoft.CuttedOfferItem 七丏丄丅丌业与且丙));
                丙东丄万万丑东丘丅.<>c.<>9__19_0 = val_31;
            }
            
            if((System.Linq.Enumerable.Any<Rilisoft.CuttedOfferItem>(source:  this.与丏丒世不丞三业丂, predicate:  val_3)) == false)
            {
                goto label_11;
            }
            
            val_33 = 1152921543750231840;
            val_34 = 0;
            goto label_12;
            label_17:
            if((val_34 & 1) != 0)
            {
                    val_32 = val_2.丐且丐不丒丐丘三丅.Item[0];
                this.丄丞三丑上丒丈丞东.Add(item:  val_32);
            }
            
            val_34 = 1;
            label_12:
            if(val_34 < val_2.丐且丐不丒丐丘三丅.Count)
            {
                goto label_17;
            }
            
            goto label_18;
            label_11:
            val_33 = 1152921543750231840;
            val_35 = 0;
            goto label_19;
            label_24:
            if((val_35 & 1) == 0)
            {
                    val_32 = val_2.丐且丐不丒丐丘三丅.Item[0];
                this.丄丞三丑上丒丈丞东.Add(item:  val_32);
            }
            
            val_35 = 1;
            label_19:
            if(val_35 < val_2.丐且丐不丒丐丘三丅.Count)
            {
                goto label_24;
            }
            
            label_18:
            val_28 = this.丄丞三丑上丒丈丞东;
            if(val_28 == null)
            {
                goto label_26;
            }
            
            label_1:
            val_33 = 1152921543750230816;
            if(val_28.Count == 0)
            {
                goto label_26;
            }
            
            System.Collections.Generic.List<System.Decimal> val_10 = this.丗下丐专丛丕专世丝(下丕丆世专丅丕丘世:  false);
            if(val_10 == null)
            {
                goto label_41;
            }
            
            if(val_10.Count >= 1)
            {
                    decimal val_12 = System.Linq.Enumerable.Max(source:  val_10);
                if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid}, d2:  new System.Decimal())) != false)
            {
                    丙东丄万万丑东丘丅.业丂七丏丟丕丌丂世 val_14 = new 丙东丄万万丑东丘丅.业丂七丏丟丕丌丂世();
                val_36 = null;
                val_36 = null;
                val_38 = 丙东丄万万丑东丘丅.<>c.<>9__19_1;
                if(val_38 == null)
            {
                    System.Func<丂七丄不专下丘丂丟, System.Int32> val_15 = null;
                val_38 = val_15;
                val_15 = new System.Func<丂七丄不专下丘丂丟, System.Int32>(object:  丙东丄万万丑东丘丅.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丙东丄万万丑东丘丅.<>c::丏丒丛丒专丂三不上(Rilisoft.Offers.东下上东丅丂丘丗丙.丂七丄不专下丘丂丟 丙丒七丄上与丏丙丙));
                丙东丄万万丑东丘丅.<>c.<>9__19_1 = val_38;
            }
            
                val_39 = System.Linq.Enumerable.Max<丂七丄不专下丘丂丟>(source:  this.丄丞三丑上丒丈丞东, selector:  val_15);
                if(val_14 != null)
            {
                    .业万丁三专一丙与丐 = val_39;
            }
            else
            {
                    .业万丁三专一丙与丐 = val_39;
                val_39 = (丙东丄万万丑东丘丅.业丂七丏丟丕丌丂世)[1152921543750409696].业万丁三专一丙与丐;
            }
            
                if(val_39 >= 1)
            {
                    System.Func<丂七丄不专下丘丂丟, System.Boolean> val_17 = null;
                val_32 = val_17;
                val_17 = new System.Func<丂七丄不专下丘丂丟, System.Boolean>(object:  val_14, method:  System.Boolean 丙东丄万万丑东丘丅.业丂七丏丟丕丌丂世::一丏丌丆丛且专业丕(Rilisoft.Offers.东下上东丅丂丘丗丙.丂七丄不专下丘丂丟 丙丒七丄上与丏丙丙));
                val_40 = System.Linq.Enumerable.FirstOrDefault<丂七丄不专下丘丂丟>(source:  this.丄丞三丑上丒丈丞东, predicate:  val_17);
                if(val_40 != null)
            {
                    return (丂七丄不专下丘丂丟)val_40;
            }
            
            }
            
            }
            
            }
            
            if(val_10.Count < 1)
            {
                goto label_41;
            }
            
            decimal val_20 = System.Linq.Enumerable.Sum(source:  val_10);
            val_32 = (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_20.flags, hi = val_20.hi, lo = val_20.lo, mid = val_20.mid})) / val_10.Count;
            goto label_44;
            label_41:
            val_32 = 0;
            label_44:
            val_41 = 0;
            goto label_45;
            label_52:
            val_40 = this.丄丞三丑上丒丈丞东.Item[0];
            if(val_23.一丞东丅一上丒万且 != null)
            {
                    if(val_32 >= val_23.一丞东丅一上丒万且.From)
            {
                    if(val_32 <= val_23.一丞东丅一上丒万且.To)
            {
                    return (丂七丄不专下丘丂丟)val_40;
            }
            
            }
            
            }
            
            val_41 = 1;
            label_45:
            if(val_41 < this.丄丞三丑上丒丈丞东.Count)
            {
                goto label_52;
            }
            
            label_26:
            val_40 = 0;
            return (丂七丄不专下丘丂丟)val_40;
        }
        internal static int 丗世丄丛丁丏丅丟上()
        {
            null = null;
            int val_1 = Rilisoft.Offers.丙东丄万万丑东丘丅.丅丞丗且丞丏丏丐与.世三丞丅丑丌丈丈一();
            val_1 = val_1 - 1;
            return (int)val_1;
        }
        internal static void 丕丕丅业丁丘万三丅(int 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.Offers.丙东丄万万丑东丘丅.丅丞丗且丞丏丏丐与.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东 + 1);
        }
        internal static int 丗丂丝丝丕丆与丙万(Rilisoft.OfferItem 下丅丙一丂丗丅丝七, System.Collections.Generic.IList<CategoryNames> 丂丅丈丛丗丌丞丅上)
        {
            var val_8;
            var val_9;
            var val_10;
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return 999;
            }
            
            System.Nullable<CategoryNames> val_1 = 下丅丙一丂丗丅丝七.Category;
            if((489198200 & 1) == 0)
            {
                    return 999;
            }
            
            System.Nullable<CategoryNames> val_2 = 下丅丙一丂丗丅丝七.Category;
            if(丂丅丈丛丗丌丞丅上 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
            }
            else
            {
                    val_8 = null;
                val_8 = null;
                if((Rilisoft.Offers.丙东丄万万丑东丘丅.业丁丂丐下万丅三丅.Contains(item:  val_2.HasValue)) == false)
            {
                    return 999;
            }
            
                val_9 = null;
                val_9 = null;
                int val_4 = Rilisoft.Offers.丙东丄万万丑东丘丅.业丁丂丐下万丅三丅.IndexOf(item:  val_2.HasValue);
                return 999;
            }
            
            val_10 = public System.Boolean System.Collections.Generic.ICollection<T>::Contains(T item);
            if((丂丅丈丛丗丌丞丅上.Contains(item:  ???)) == false)
            {
                    return 999;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = 2;
            int val_8 = 丂丅丈丛丗丌丞丅上.IndexOf(item:  ???);
            return 999;
        }
        public 丙东丄万万丑东丘丅()
        {
            this.丕丞东七丆专丕丈丙 = new System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem>();
            this = new System.Object();
        }
        private static 丙东丄万万丑东丘丅()
        {
            Rilisoft.Offers.丙东丄万万丑东丘丅.七丞丏世专丌丐丟上 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "DetailsAdaptiveSubModule_lastViewedCategory");
            Rilisoft.Offers.丙东丄万万丑东丘丅.丅丞丗且丞丏丏丐与 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "target-offers-_lastBoughtCategory");
            System.Collections.Generic.List<CategoryNames> val_3 = new System.Collections.Generic.List<CategoryNames>();
            if(val_3 != null)
            {
                    val_3.Add(item:  0);
                val_3.Add(item:  4);
                val_3.Add(item:  5);
                val_3.Add(item:  3);
                val_3.Add(item:  1);
                val_3.Add(item:  2);
            }
            else
            {
                    val_3.Add(item:  0);
                val_3.Add(item:  4);
                val_3.Add(item:  5);
                val_3.Add(item:  3);
                val_3.Add(item:  1);
                val_3.Add(item:  2);
            }
            
            val_3.Add(item:  240);
            Rilisoft.Offers.丙东丄万万丑东丘丅.业丁丂丐下万丅三丅 = val_3;
        }
    
    }

}
