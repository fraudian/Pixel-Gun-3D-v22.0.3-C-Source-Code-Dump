using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 世丆丏下丆专与丂不 : 丛丝下且丟丈丞丈丗
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丕丞东七丆专丕丈丙;
        private System.Collections.Generic.List<int> 丕业万三专世丁且丛;
        private decimal 万上丏丐丌与一丒丂;
        
        // Properties
        internal override Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丒三丝一上丙专丗丒 { get; }
        internal override System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丁丛丁丗丙万丐丈丁 { get; }
        internal override System.Collections.Generic.List<int> 丘丄世丅丄丕与丛丂 { get; }
        
        // Methods
        internal override Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 不业丙丒丂丞下丆丙()
        {
            return 70;
        }
        internal override System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丞丏上丘丈上万一七()
        {
            return (System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem>)this.丕丞东七丆专丕丈丙;
        }
        internal override System.Collections.Generic.List<int> 且一专丅丞丏七丙丟()
        {
            return (System.Collections.Generic.List<System.Int32>)this.丕业万三专世丁且丛;
        }
        internal override void 丐世丑与丏世丗丑上(bool 下丕丆世专丅丕丘世)
        {
            object val_4;
            var val_44;
            var val_46;
            decimal val_47;
            var val_48;
            var val_52;
            丂丘丛下丆一丕丂丅 val_53;
            var val_54;
            var val_55;
            if(下丕丆世专丅丕丘世 != true)
            {
                    val_44 = null;
                val_44 = null;
                if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = this.万上丏丐丌与一丒丂, hi = this.万上丏丐丌与一丒丂, lo = 下丕丆世专丅丕丘世, mid = 下丕丆世专丅丕丘世}, d2:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_20>>32&0x0})) != true)
            {
                    if(this != null)
            {
                goto label_5;
            }
            
            }
            
            }
            
            this.丐丅万与东丞丁丛丘();
            label_5:
            List.Enumerator<T> val_2 = this.丕丞东七丆专丕丈丙.GetEnumerator();
            label_9:
            if((486394272 & 1) == 0)
            {
                goto label_7;
            }
            
            val_4.丐丏七丌丕丗业且上().Dispose();
            goto label_9;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丕丞东七丆专丕丈丙.Clear();
            val_47 = this.万上丏丐丌与一丒丂;
            val_48 = null;
            val_48 = null;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_47, hi = val_47, lo = this.丕丞东七丆专丕丈丙, mid = this.丕丞东七丆专丕丈丙}, d2:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_20>>32&0x0})) == true)
            {
                    return;
            }
            
            if(this == null)
            {
                    return;
            }
            
            val_46 = this;
            if(this.Count == 0)
            {
                    return;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_8 = System.Linq.Enumerable.Distinct<System.Int32>(source:  this);
            System.Collections.Generic.Dictionary<System.Int32, 丂丘丛下丆一丕丂丅> val_9 = Rilisoft.Offers.丛丝下且丟丈丞丈丗.业下丈丘万丗丟丒丑(丏丅东丙东业三丈丗:  val_8);
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_46 = val_8.GetEnumerator();
            label_67:
            var val_47 = 0;
            val_47 = val_47 + 1;
            if(val_46.MoveNext() == false)
            {
                goto label_31;
            }
            
            new 世丆丏下丆专与丂不.丌万一一业丝丁丈丝() = new System.Object();
            var val_48 = 0;
            val_48 = val_48 + 1;
            .世丈三丐丞一丒丛不 = val_46.Current;
            new 世丆丏下丆专与丂不.丂七一丐丄丆丁东丟() = new System.Object();
            val_4 = 70;
            Progress.AdaptiveProgress val_19 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            if((val_19.IgnoreOffers.Contains(item:  System.String.Format(format:  "{0}:{1}", arg0:  val_4, arg1:  (世丆丏下丆专与丂不.丌万一一业丝丁丈丝)[1152921543748015648].世丈三丐丞一丒丛不))) == true)
            {
                goto label_67;
            }
            
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_21 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 世丆丏下丆专与丂不.丌万一一业丝丁丈丝(), method:  System.Boolean 世丆丏下丆专与丂不.丌万一一业丝丁丈丝::丈丏丙丞丁丞丞东不(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟));
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  this.丕丞东七丆专丕丈丙, predicate:  null)) == true)
            {
                goto label_67;
            }
            
            val_52 = null;
            val_52 = null;
            decimal val_24 = System.Decimal.op_Implicit(value:  ExperienceController.丞丞丘业东丙丏七丌());
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_25 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            decimal val_26 = System.Decimal.op_Explicit(value:  val_25.丗业丐丒丂东业丛与);
            decimal val_27 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_24.flags, hi = val_24.hi, lo = val_24.lo, mid = val_24.mid}, d2:  new System.Decimal() {flags = val_26.flags, hi = val_26.hi, lo = val_26.lo, mid = val_26.mid});
            decimal val_28 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, d2:  new System.Decimal() {flags = val_27.flags, hi = val_27.hi, lo = val_27.lo, mid = val_27.mid});
            decimal val_29 = Rilisoft.Offers.丁且丕专万丈丒丏丗.上丏丆丑丒一丝业且(丏丂不专上丘丂不丅:  223, 世丈三丐丞一丒丛不:  (世丆丏下丆专与丂不.丌万一一业丝丁丈丝)[1152921543748015648].世丈三丐丞一丒丛不, 世丛下丗丝七下丈丆:  false);
            val_4 = 0;
            decimal val_30 = System.Decimal.op_Multiply(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = this.万上丏丐丌与一丒丂, hi = this.万上丏丐丌与一丒丂});
            decimal val_31 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_30.flags, hi = val_30.hi, lo = val_30.lo, mid = val_30.mid}, d2:  new System.Decimal() {flags = val_28.flags, hi = val_28.hi, lo = val_28.lo, mid = val_28.mid});
            decimal val_32 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_29.flags, hi = val_29.hi, lo = val_29.lo, mid = val_29.mid}, d2:  new System.Decimal() {flags = val_31.flags, hi = val_31.hi, lo = val_31.lo, mid = val_31.mid});
            .世丁丞丟丛丛且业丝 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_32.flags, hi = val_32.hi, lo = val_32.lo, mid = val_32.mid});
            decimal val_34 = Rilisoft.Offers.丁且丕专万丈丒丏丗.上丏丆丑丒一丝业且(丏丂不专上丘丂不丅:  247, 世丈三丐丞一丒丛不:  (世丆丏下丆专与丂不.丌万一一业丝丁丈丝)[1152921543748015648].世丈三丐丞一丒丛不, 世丛下丗丝七下丈丆:  false);
            decimal val_35 = System.Decimal.op_Multiply(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = this.万上丏丐丌与一丒丂, hi = this.万上丏丐丌与一丒丂});
            decimal val_36 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_35.flags, hi = val_35.hi, lo = val_35.lo, mid = val_35.mid}, d2:  new System.Decimal() {flags = val_28.flags, hi = val_28.hi, lo = val_28.lo, mid = val_28.mid});
            decimal val_37 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_34.flags, hi = val_34.hi, lo = val_34.lo, mid = val_34.mid}, d2:  new System.Decimal() {flags = val_36.flags, hi = val_36.hi, lo = val_36.lo, mid = val_36.mid});
            .丈丂专丕丝世丁丘与 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_37.flags, hi = val_37.hi, lo = val_37.lo, mid = val_37.mid});
            Progress.AdaptiveProgress val_39 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            System.Func<SkippedItem, System.Boolean> val_40 = new System.Func<SkippedItem, System.Boolean>(object:  new 世丆丏下丆专与丂不.丂七一丐丄丆丁东丟(), method:  System.Boolean 世丆丏下丆专与丂不.丂七一丐丄丆丁东丟::丁丙丌丙且下丆丝世(Progress.AdaptiveProgress.SkippedItem 七丞丙丒三丕且丌丟));
            if((System.Linq.Enumerable.Any<SkippedItem>(source:  val_39.SkippedItems, predicate:  null)) == true)
            {
                goto label_67;
            }
            
            if((val_9.ContainsKey(key:  (世丆丏下丆专与丂不.丌万一一业丝丁丈丝)[1152921543748015648].世丈三丐丞一丒丛不)) != false)
            {
                    val_53 = val_9.Item[(世丆丏下丆专与丂不.丌万一一业丝丁丈丝)[1152921543748015648].世丈三丐丞一丒丛不];
            }
            else
            {
                    val_53 = 0;
            }
            
            Rilisoft.Offers.AdaptiveOfferItem val_44 = Rilisoft.Offers.AdaptiveOfferItem.丂丈世不七丆一丛下(丕上业丕丘上丘七一:  70, 世丈三丐丞一丒丛不:  (世丆丏下丆专与丂不.丌万一一业丝丁丈丝)[1152921543748015648].世丈三丐丞一丒丛不, 与丝丙丝万丑丞丄一:  0, 丟丒且一专丟丙下一:  val_53, 丆且丁丒丒丆丁三丆:  0);
            val_54 = null;
            val_54 = null;
            val_44.丑与东丙丑丘丁丂丒(丁丅丈丌丟世丗丗丟:  232, 丞丅上丏丂且下丅与:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丌丒丝东丌下丕丁丅:  (世丆丏下丆专与丂不.丂七一丐丄丆丁东丟)[1152921543748019760].世丁丞丟丛丛且业丝);
            val_44.丑与东丙丑丘丁丂丒(丁丅丈丌丟世丗丗丟:  242, 丞丅上丏丂且下丅与:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丌丒丝东丌下丕丁丅:  (世丆丏下丆专与丂不.丂七一丐丄丆丁东丟)[1152921543748019760].丈丂专丕丝世丁丘与);
            this.丕丞东七丆专丕丈丙.Add(item:  val_44);
            goto label_67;
            label_31:
            val_47 = 0;
            val_55 = 0;
            if(val_46 == null)
            {
                
            }
            else
            {
                    var val_49 = 0;
                val_49 = val_49 + 1;
                val_46.Dispose();
            }
            
            if( != 1)
            {
                    if( == false)
            {
                    return;
            }
            
                if(617 == 617)
            {
                    return;
            }
            
                return;
            }
            
            if( == true)
            {
                    return;
            }
        
        }
        private void 丐丅万与东丞丁丛丘()
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            this.丕业万三专世丁且丛 = this;
            System.Collections.Generic.List<System.Decimal> val_1 = this.丗下丐专丛丕专世丝(下丕丆世专丅丕丘世:  true);
            System.Collections.Generic.List<Rilisoft.OfferItem> val_2 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            val_23 = null;
            val_23 = null;
            val_2.Add(item:  Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  System.String.Format(format:  "{0}::{1}", arg0:  1000, arg1:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false))));
            val_2.Add(item:  Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  System.String.Format(format:  "{0}::{1}", arg0:  1010, arg1:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false))));
            decimal val_9 = Rilisoft.Offers.丁且丕专万丈丒丏丗.且丄丗东丌业下东丐(丑七不与丛丆一丂丞:  val_2, 世丈三丐丞一丒丛不:  1);
            this.上丏丄且丅一东丐丕(丅丄丆丞下丄丒专丕: out  new System.Decimal(), 上专丅业三丏丈丈丗: out  0);
            val_24 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Collections.Generic.List<System.Single>>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "currency_mult");
            if(val_24 != null)
            {
                    if(val_24.Count > 3)
            {
                goto label_14;
            }
            
            }
            
            System.Collections.Generic.List<System.Single> val_13 = null;
            val_24 = val_13;
            val_13 = new System.Collections.Generic.List<System.Single>();
            if(val_24 != null)
            {
                    val_13.Add(item:  5f);
                val_13.Add(item:  10f);
                val_13.Add(item:  1.5f);
            }
            else
            {
                    val_13.Add(item:  5f);
                val_13.Add(item:  10f);
                val_13.Add(item:  1.5f);
            }
            
            val_13.Add(item:  2f);
            label_14:
            if(val_1 != null)
            {
                    var val_17 = (val_1.Count == 0) ? 1 : 0;
            }
            else
            {
                    val_25 = 1;
            }
            
            val_25 = val_25 & ((Rilisoft.一丟专且三万丞丁丂.丌丌与丙上丘七丕丒() > (Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "check_registration_days"))) ? 1 : 0);
            if(val_25 == 0)
            {
                goto label_23;
            }
            
            val_26 = public System.Single System.Collections.Generic.List<System.Single>::get_Item(int index);
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_27;
            }
            
            val_27 = 1;
            goto label_33;
            label_23:
            val_26 = public System.Single System.Collections.Generic.List<System.Single>::get_Item(int index);
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_32;
            }
            
            val_27 = 3;
            goto label_33;
            label_27:
            val_27 = 0;
            goto label_34;
            label_32:
            val_27 = 2;
            label_33:
            label_34:
            decimal val_22 = System.Decimal.op_Explicit(value:  val_13.Item[2]);
            this.万上丏丐丌与一丒丂 = val_22;
            mem[1152921543748211664] = val_22.lo;
            mem[1152921543748211668] = val_22.mid;
        }
        protected override System.Collections.Generic.List<int> 下丁丞丈丌丐丂丞丕()
        {
            var val_24;
            var val_25;
            decimal val_26;
            var val_27;
            var val_28;
            var val_29;
            int val_30;
            decimal val_31;
            var val_32;
            var val_33;
            int val_34;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            int val_2 = 0;
            this.上丏丄且丅一东丐丕(丅丄丆丞下丄丒专丕: out  new System.Decimal(), 上专丅业三丏丈丈丗: out  val_2);
            val_24 = 1152921504618881024;
            val_25 = null;
            val_25 = null;
            if(((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false) && (val_2 > 0))
            {
                    decimal val_4 = System.Decimal.op_Implicit(value:  0);
                decimal val_5 = System.Decimal.op_Division(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
                val_26 = val_5.flags;
                val_27 = val_5.lo;
            }
            else
            {
                    val_28 = null;
                val_28 = null;
                val_26 = System.Decimal.Zero;
            }
            
            val_29 = null;
            val_29 = null;
            var val_27 = 0;
            label_17:
            if(val_27 >= 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_13;
            }
            
            val_30 = mem[丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32];
            val_30 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32;
            decimal val_6 = System.Decimal.op_Implicit(value:  val_30);
            val_27 = val_27 + 1;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, d2:  new System.Decimal() {flags = val_26, hi = val_26, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
            {
                goto label_17;
            }
            
            goto label_18;
            label_13:
            val_30 = 0;
            label_18:
            System.Collections.Generic.List<System.Decimal> val_8 = this.丗下丐专丛丕专世丝(下丕丆世专丅丕丘世:  false);
            if(val_8.Count > 0)
            {
                    decimal val_10 = System.Linq.Enumerable.Sum(source:  val_8);
                decimal val_12 = System.Decimal.op_Implicit(value:  val_8.Count);
                decimal val_13 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid}, d2:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid});
                val_31 = val_13.flags;
                val_32 = val_13.lo;
            }
            else
            {
                    val_33 = null;
                val_33 = null;
                val_31 = System.Decimal.Zero;
            }
            
            if(丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length < 1)
            {
                goto label_27;
            }
            
            label_32:
            val_34 = mem[丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32];
            val_34 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32;
            decimal val_14 = System.Decimal.op_Implicit(value:  val_34);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_14.flags, hi = val_14.hi, lo = val_14.lo, mid = val_14.mid}, d2:  new System.Decimal() {flags = val_31, hi = val_31, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
            {
                goto label_31;
            }
            
            if((0 + 1) < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_32;
            }
            
            label_27:
            val_34 = 0;
            label_31:
            if((val_30 | val_34) == 0)
            {
                    return val_1;
            }
            
            val_32 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
            if(丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length >= 1)
            {
                    val_32 = 1152921516995548064;
                do
            {
                val_24 = 0;
                val_34 = mem[丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32];
                val_34 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32;
                if((val_34 >= (System.Math.Max(val1:  System.Math.Min(val1:  0, val2:  0), val2:  val_19.MaxBuyReal))) && (val_34 <= (System.Math.Max(val1:  0, val2:  0))))
            {
                    val_1.Add(item:  val_34);
            }
            
            }
            while((val_24 + 1) < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length);
            
            }
            
            int val_24 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().世丁上丛万世不丞丂();
            if(val_24 < 1)
            {
                    return val_1;
            }
            
            val_32 = 1152921516995559328;
            val_34 = 0;
            goto label_49;
            label_54:
            if(val_1.Item[0] == val_24)
            {
                    val_1.RemoveAt(index:  0);
            }
            
            val_34 = 0;
            label_49:
            if(val_34 < val_1.Count)
            {
                goto label_54;
            }
            
            return val_1;
        }
        public 世丆丏下丆专与丂不()
        {
            this.丕丞东七丆专丕丈丙 = new System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem>();
            this.万上丏丐丌与一丒丂 = 0m;
            mem[1152921543748522704] = 0;
        }
    
    }

}
