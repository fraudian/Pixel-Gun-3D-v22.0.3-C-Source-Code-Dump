using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 不丒上丄业三与下丟 : 丛丝下且丟丈丞丈丗
    {
        // Fields
        private readonly System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丕丞东七丆专丕丈丙;
        private int 上丏丈下不丂丅丛丌;
        private System.Collections.Generic.List<int> 丕业万三专世丁且丛;
        private System.Collections.Generic.List<Rilisoft.Offers.不丒上丄业三与下丟.丒丘丞世丏丝万丑上> 东上丅七七不丑七业;
        internal static readonly System.Collections.Generic.List<Rilisoft.Offers.不丒上丄业三与下丟.丒丘丞世丏丝万丑上.七下专丌丐丛丙丝不> 丟丟下丙丈丁下丐三;
        
        // Properties
        internal override Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丒三丝一上丙专丗丒 { get; }
        internal override System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丁丛丁丗丙万丐丈丁 { get; }
        internal override System.Collections.Generic.List<int> 丘丄世丅丄丕与丛丂 { get; }
        
        // Methods
        internal override Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 不业丙丒丂丞下丆丙()
        {
            return 80;
        }
        internal override System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> 丞丏上丘丈上万一七()
        {
            return (System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem>)this.丕丞东七丆专丕丈丙;
        }
        internal override System.Collections.Generic.List<int> 且一专丅丞丏七丙丟()
        {
            return (System.Collections.Generic.List<System.Int32>)this.丕业万三专世丁且丛;
        }
        internal 不丒上丄业三与下丟()
        {
            this.丕丞东七丆专丕丈丙 = new System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem>();
            this.东上丅七七不丑七业 = new System.Collections.Generic.List<丒丘丞世丏丝万丑上>();
            Rilisoft.PetsManager.且丛七丟丄丈丑丏丐(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String>(object:  this, method:  System.Void Rilisoft.Offers.不丒上丄业三与下丟::丌丌丁丛丄上丞专一(string 丛丆东与丑丞丅丝专, string 不丁丌丐业丑丟且不)));
            Rilisoft.PetsManager.丂丅丌一万丞丕不东(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.Offers.不丒上丄业三与下丟::丂丗丌丈丟丌丏丗业(string 万且万且丑丗且丌丆)));
            Rilisoft.PetsManager.东丘三与丙下一丐丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.Offers.不丒上丄业三与下丟::丌丈丂丛三丂丆七上()));
        }
        private decimal 上专且丒丗丞丞丆丟(string 世丐丗专丅三丝丑丆)
        {
            int val_11;
            System.Collections.Generic.IEnumerable<TSource> val_12;
            var val_13;
            System.Func<Rilisoft.GameCurrencyData, System.Int32> val_15;
            int val_16;
            int val_17;
            val_12 = BalanceController.丕丙丛且丏三上不丛(丆万一不丌且东丐丐:  世丐丗专丅三丝丑丆, 万业丁七与丟丁东与:  false);
            if(val_12 == null)
            {
                goto label_3;
            }
            
            val_13 = null;
            val_13 = null;
            val_15 = 不丒上丄业三与下丟.<>c.<>9__11_0;
            if(val_15 == null)
            {
                    System.Func<Rilisoft.GameCurrencyData, System.Int32> val_2 = null;
                val_15 = val_2;
                val_2 = new System.Func<Rilisoft.GameCurrencyData, System.Int32>(object:  不丒上丄业三与下丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 不丒上丄业三与下丟.<>c::上丒丞丝丗丈丞与业(Rilisoft.GameCurrencyData 七丏丄丅丌业与且丙));
                不丒上丄业三与下丟.<>c.<>9__11_0 = val_15;
            }
            
            val_12 = System.Linq.Enumerable.Last<Rilisoft.GameCurrencyData>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.GameCurrencyData, System.Int32>(source:  val_12, keySelector:  val_2));
            if(val_12.CurrencyCount == 0)
            {
                goto label_10;
            }
            
            decimal val_7 = System.Decimal.op_Implicit(value:  val_12.RealPrice);
            val_16 = val_7.lo;
            decimal val_9 = System.Decimal.op_Implicit(value:  val_12.CurrencyCount);
            val_11 = val_7.flags;
            val_17 = val_16;
            decimal val_10 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_11, hi = val_7.hi, lo = val_17, mid = val_7.mid}, d2:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid});
            return new System.Decimal();
            label_3:
            val_17 = 0;
            return new System.Decimal();
            label_10:
            val_17 = 0;
            val_11 = 0;
            return new System.Decimal();
        }
        internal override void 丐世丑与丏世丗丑上(bool 下丕丆世专丅丕丘世)
        {
            var val_15;
            System.Collections.Generic.IEnumerable<System.Int32> val_52;
            var val_53;
            System.Collections.Generic.List<丒丘丞世丏丝万丑上> val_54;
            var val_55;
            int val_56;
            var val_57;
            var val_58;
            var val_59;
            不丒上丄业三与下丟.丒丘丞世丏丝万丑上 val_60;
            string val_61;
            var val_62;
            val_52 = this;
            if(this.丕业万三专世丁且丛 == null)
            {
                goto label_1;
            }
            
            if(下丕丆世专丅丕丘世 == false)
            {
                goto label_2;
            }
            
            label_17:
            val_53 = 1152921505501892608;
            var val_4 = (((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏())) & true) != 0) ? (2 + 1) : 2;
            Rilisoft.Offers.东下上东丅丂丘丗丙 val_5 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
            if(val_5.业与三万丁丗七一丅.Count >= val_4)
            {
                    Rilisoft.Offers.东下上东丅丂丘丗丙 val_7 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丏丘下丞丘不丑万丏();
                this.上丏丈下不丂丅丛丌 = val_7.业与三万丁丗七一丅.Item[val_4 - 1];
            }
            
            val_54 = val_52;
            this.东上丅七七不丑七业.Clear();
            goto label_16;
            label_1:
            this.丕业万三专世丁且丛 = this.下丁丞丈丌丐丂丞丕();
            if(下丕丆世专丅丕丘世 == true)
            {
                goto label_17;
            }
            
            label_2:
            val_54 = this.东上丅七七不丑七业;
            label_16:
            if(this.东上丅七七不丑七业.SyncRoot.Count > 0)
            {
                    return;
            }
            
            this.业与下世世东与丈业();
            System.Collections.Generic.Dictionary<System.Int32, 丂丘丛下丆一丕丂丅> val_12 = Rilisoft.Offers.丛丝下且丟丈丞丈丗.业下丈丘万丗丟丒丑(丏丅东丙东业三丈丗:  this);
            List.Enumerator<T> val_13 = this.东上丅七七不丑七业.GetEnumerator();
            label_57:
            if((493722704 & 1) == 0)
            {
                goto label_21;
            }
            
            new 不丒上丄业三与下丟.丒丛丁与丅东丒不七() = new System.Object();
            .不下丗丙七丈丐丘万 = val_15.丐丏七丌丕丗业且上();
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  (不丒上丄业三与下丟.丒丛丁与丅东丒不七)[1152921543755364528].不下丗丙七丈丐丘万.下丄丈不与世丐业专)) == null)
            {
                    val_55 = 0;
            }
            
            decimal val_20 = this.上专且丒丗丞丞丆丟(世丐丗专丅三丝丑丆:  val_19.Id);
            decimal val_21 = System.Decimal.op_Implicit(value:  (不丒上丄业三与下丟.丒丛丁与丅东丒不七)[1152921543755364528].不下丗丙七丈丐丘万.专下与丑三丏丂不丆);
            decimal val_22 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_20.flags, hi = val_20.hi, lo = val_20.lo, mid = val_20.mid}, d2:  new System.Decimal() {flags = val_21.flags, hi = val_21.hi, lo = val_21.lo, mid = val_21.mid});
            val_15 = 0;
            decimal val_23 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_22.flags, hi = val_22.hi, lo = val_22.lo, mid = val_22.mid}, d2:  new System.Decimal());
            decimal val_24 = System.Decimal.op_Implicit(value:  this.上丏丈下不丂丅丛丌);
            decimal val_25 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_23.flags, hi = val_23.hi, lo = val_23.lo, mid = val_23.mid}, d2:  new System.Decimal() {flags = val_24.flags, hi = val_24.hi, lo = val_24.lo, mid = val_24.mid});
            val_56 = val_22.lo;
            decimal val_26 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = val_22.flags, hi = val_22.hi, lo = val_56, mid = val_22.mid}, d2:  new System.Decimal() {flags = val_25.flags, hi = val_25.hi, lo = val_25.lo, mid = val_25.mid});
            val_57 = 0;
            val_58 = 0;
            goto label_29;
            label_34:
            int val_27 = this.Item[0];
            val_59 = null;
            val_59 = null;
            decimal val_28 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = val_26.flags, hi = val_26.hi, lo = val_26.lo, mid = val_26.mid}, d2:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_20>>32&0x0});
            decimal val_29 = System.Decimal.op_Implicit(value:  val_27);
            val_56 = val_28.lo;
            int val_31 = ((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_28.flags, hi = val_28.hi, lo = val_56, mid = val_28.mid}, d2:  new System.Decimal() {flags = val_29.flags, hi = val_29.hi, lo = val_29.lo, mid = val_29.mid})) != true) ? (val_27) : (val_58);
            val_57 = 1;
            label_29:
            if(val_57 < this.Count)
            {
                goto label_34;
            }
            
            if((val_31 < 1) || ((val_12.ContainsKey(key:  val_31)) == false))
            {
                goto label_57;
            }
            
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_34 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 不丒上丄业三与下丟.丒丛丁与丅东丒不七(), method:  System.Boolean 不丒上丄业三与下丟.丒丛丁与丅东丒不七::丈丏丙丞丁丞丞东不(Rilisoft.Offers.AdaptiveOfferItem 丑三丁丘丅丞丒下丑));
            if((System.Linq.Enumerable.Any<Rilisoft.Offers.AdaptiveOfferItem>(source:  mem[1152921543755287496], predicate:  null)) == true)
            {
                goto label_57;
            }
            
            Rilisoft.Offers.AdaptiveOfferItem val_37 = Rilisoft.Offers.AdaptiveOfferItem.丂丈世不七丆一丛下(丕上业丕丘上丘七一:  80, 世丈三丐丞一丒丛不:  val_31, 与丝丙丝万丑丞丄一:  0, 丟丒且一专丟丙下一:  val_12.Item[val_31], 丆且丁丒丒丆丁三丆:  (不丒上丄业三与下丟.丒丛丁与丅东丒不七)[1152921543755364528].不下丗丙七丈丐丘万.丗业丛业丂丆丕丈一);
            val_60 = (不丒上丄业三与下丟.丒丛丁与丅东丒不七)[1152921543755364528].不下丗丙七丈丐丘万;
            if(val_60 != null)
            {
                    val_61 = (不丒上丄业三与下丟.丒丛丁与丅东丒不七)[1152921543755364528].不下丗丙七丈丐丘万.下丄丈不与世丐业专;
            }
            else
            {
                    val_61 = (不丒上丄业三与下丟.丒丛丁与丅东丒不七)[1152921543755364528].不下丗丙七丈丐丘万.下丄丈不与世丐业专;
                if((不丒上丄业三与下丟.丒丛丁与丅东丒不七)[1152921543755364528].不下丗丙七丈丐丘万 != null)
            {
                    val_60 = (不丒上丄业三与下丟.丒丛丁与丅东丒不七)[1152921543755364528].不下丗丙七丈丐丘万;
            }
            else
            {
                    val_60 = 0;
            }
            
            }
            
            val_37.丑与东丙丑丘丁丂丒(下丅丙一丂丗丅丝七:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  80, 丞丅上丏丂且下丅与:  val_61, 丌丒丝东丌下丕丁丅:  28563616));
            System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean> val_39 = new System.Func<Rilisoft.Offers.AdaptiveOfferItem, System.Boolean>(object:  new 不丒上丄业三与下丟.丒丛丁与丅东丒不七(), method:  System.Boolean 不丒上丄业三与下丟.丒丛丁与丅东丒不七::丁丙丌丙且下丆丝世(Rilisoft.Offers.AdaptiveOfferItem 丑三丁丘丅丞丒下丑));
            Rilisoft.Offers.AdaptiveOfferItem val_40 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.Offers.AdaptiveOfferItem>(source:  mem[1152921543755287496], predicate:  null);
            if(val_40 == null)
            {
                goto label_51;
            }
            
            bool val_42 = mem[1152921543755287496].Remove(item:  val_40);
            mem[1152921543755287496].Insert(index:  mem[1152921543755287496].IndexOf(item:  val_40), item:  val_37);
            goto label_57;
            label_51:
            mem[1152921543755287496].Add(item:  val_37);
            goto label_57;
            label_21:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_54 = 1152921504616005632;
            val_62 = 0;
            goto label_100;
            label_110:
            Rilisoft.Offers.AdaptiveOfferItem val_44 = mem[1152921543755287496].Item[0];
            .下丅丙一丂丗丅丝七 = val_44.Items.Item[0];
            if((System.Linq.Enumerable.All<丒丘丞世丏丝万丑上>(source:  val_54, predicate:  new System.Func<丒丘丞世丏丝万丑上, System.Boolean>(object:  new 不丒上丄业三与下丟.丈世万上专丛丗专丆(), method:  System.Boolean 不丒上丄业三与下丟.丈世万上专丛丗专丆::丐丒不丝丒丐丄丐丏(Rilisoft.Offers.不丒上丄业三与下丟.丒丘丞世丏丝万丑上 不下丗丙七丈丐丘万)))) != false)
            {
                    val_52 = val_52;
                val_44.Dispose();
                bool val_49 = mem[1152921543755287496].Remove(item:  val_44);
            }
            else
            {
                    val_52 = val_52;
            }
            
            val_62 = val_62 + 1;
            label_100:
            val_53 = mem[1152921543755287496];
            if(val_62 < val_53.Count)
            {
                goto label_110;
            }
        
        }
        private void 业与下世世东与丈业()
        {
            object val_41;
            var val_42;
            var val_43;
            var val_44;
            System.Func<PetInfo, System.Boolean> val_46;
            var val_47;
            System.Func<七下下业三丞专丈丛, System.Boolean> val_49;
            var val_50;
            var val_51;
            var val_52;
            string val_53;
            var val_54;
            val_41 = 1152921543755137520;
            val_42 = 1152921543755524976;
            val_43 = 0;
            goto label_1;
            label_5:
            PGCompany.一世丟丅丕丐且丆丏<丒丘丞世丏丝万丑上>.万世丅七一专丕丞不().丁丟丞丗丆七丙丐丌(万且万且丑丗且丌丆:  X21.Item[0]);
            val_43 = 1;
            label_1:
            if(val_43 < this.东上丅七七不丑七业.Count)
            {
                goto label_5;
            }
            
            this.东上丅七七不丑七业.Clear();
            val_44 = null;
            val_44 = null;
            val_46 = 不丒上丄业三与下丟.<>c.<>9__14_0;
            if(val_46 == null)
            {
                    val_46 = null;
                val_46 = new System.Func<PetInfo, System.Boolean>(object:  不丒上丄业三与下丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 不丒上丄业三与下丟.<>c::下专丅丝丅三丙万丌(PetInfo 七丏丄丅丌业与且丙));
                不丒上丄业三与下丟.<>c.<>9__14_0 = val_46;
            }
            
            System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<PetInfo>(source:  System.Linq.Enumerable.Where<PetInfo>(source:  丟下七丘下下丙丗丅.一三专丞丒丅上业上().Values, predicate:  null));
            val_47 = null;
            val_47 = null;
            val_49 = 不丒上丄业三与下丟.<>c.<>9__14_1;
            if(val_49 == null)
            {
                    val_49 = null;
                val_49 = new System.Func<七下下业三丞专丈丛, System.Boolean>(object:  不丒上丄业三与下丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 不丒上丄业三与下丟.<>c::丌与丆业与丘丗丑丗(七下下业三丞专丈丛 七丏丄丅丌业与且丙));
                不丒上丄业三与下丟.<>c.<>9__14_1 = val_49;
            }
            
            val_50 = 1152921543755596656;
            val_51 = 1152921505504288768;
            val_52 = 0;
            goto label_22;
            label_62:
            val_41 = new 不丒上丄业三与下丟.丌丟丘丏丕丅七万丕();
            val_41 = new System.Object();
            .不下丗丙七丈丐丘万 = 0;
            .上东丞世三世且丈丌 = val_8.Item[0];
            System.Func<七下下业三丞专丈丛, System.Boolean> val_17 = new System.Func<七下下业三丞专丈丛, System.Boolean>(object:  new 不丒上丄业三与下丟.丌丟丘丏丕丅七万丕(), method:  System.Boolean 不丒上丄业三与下丟.丌丟丘丏丕丅七万丕::丝不世丑丗丐丝丏七(七下下业三丞专丈丛 七丏丄丅丌业与且丙));
            if((System.Linq.Enumerable.FirstOrDefault<七下下业三丞专丈丛>(source:  System.Linq.Enumerable.ToList<七下下业三丞专丈丛>(source:  System.Linq.Enumerable.Where<七下下业三丞专丈丛>(source:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈().Values, predicate:  null)), predicate:  null)) == null)
            {
                goto label_25;
            }
            
            val_53 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏();
            val_54 = val_50;
            if((Rilisoft.PetsManager.丌丝丄丟丅业且丗丂(世丐丗专丅三丝丑丆:  (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].上东丞世三世且丈丌.Id)) == true)
            {
                goto label_47;
            }
            
            val_42 = 1152921543755524976;
            if(ExperienceController.丞丞丘业东丙丏七丌() < (BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].上东丞世三世且丈丌.Index, 且万丛丒丁丏七丅东:  (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].上东丞世三世且丈丌.CurrentLevel, 丐丏上业丈丂与万丞:  false)))
            {
                goto label_47;
            }
            
            .不下丗丙七丈丐丘万 = PGCompany.一世丟丅丕丐且丆丏<丒丘丞世丏丝万丑上>.万世丅七一专丕丞不().丂丈世不七丆一丛下();
            val_27.下丄丈不与世丐业专 = (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].上东丞世三世且丈丌.Id;
            (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].不下丗丙七丈丐丘万.丗业丛业丂丆丕丈一 = (((System.String.op_Equality(a:  (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].不下丗丙七丈丐丘万.下丄丈不与世丐业专, b:  val_53)) & true) != 0) ? (1 + 1) : 1;
            val_53 = BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].上东丞世三世且丈丌.Index, 且万丛丒丁丏七丅东:  (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].上东丞世三世且丈丌.CurrentLevel, 丐丏上业丈丂与万丞:  false);
            (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].不下丗丙七丈丐丘万.专下与丑三丏丂不丆 = val_53 - val_18.专下与丑三丏丂不丆;
            val_42 = 1152921543755524976;
            goto label_47;
            label_25:
            .不下丗丙七丈丐丘万 = PGCompany.一世丟丅丕丐且丆丏<丒丘丞世丏丝万丑上>.万世丅七一专丕丞不().丂丈世不七丆一丛下();
            val_53 = (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].上东丞世三世且丈丌.Id;
            val_35.下丄丈不与世丐业专 = val_53;
            (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].不下丗丙七丈丐丘万.丗业丛业丂丆丕丈一 = 0;
            val_54 = val_50;
            (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].不下丗丙七丈丐丘万.专下与丑三丏丂不丆 = 1;
            label_47:
            val_50 = val_54;
            val_51 = 1152921505504288768;
            if((不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].不下丗丙七丈丐丘万 != null)
            {
                    Progress.AdaptiveProgress val_36 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
                val_53 = null;
                val_53 = new System.Func<SkippedItem, System.Boolean>(object:  new 不丒上丄业三与下丟.丌丟丘丏丕丅七万丕(), method:  System.Boolean 不丒上丄业三与下丟.丌丟丘丏丕丅七万丕::不丆且万丞丙丘丘业(Progress.AdaptiveProgress.SkippedItem 专上丘丈丁世一丐且));
                if((System.Linq.Enumerable.Any<SkippedItem>(source:  val_36.SkippedItems, predicate:  null)) != false)
            {
                    val_41 = (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].不下丗丙七丈丐丘万;
                PGCompany.一世丟丅丕丐且丆丏<丒丘丞世丏丝万丑上>.万世丅七一专丕丞不().丁丟丞丗丆七丙丐丌(万且万且丑丗且丌丆:  val_41);
            }
            else
            {
                    val_41 = (不丒上丄业三与下丟.丌丟丘丏丕丅七万丕)[1152921543755855408].不下丗丙七丈丐丘万;
                this.东上丅七七不丑七业.Add(item:  val_41);
            }
            
            }
            
            val_52 = 1;
            label_22:
            if(val_52 < val_8.Count)
            {
                goto label_62;
            }
        
        }
        public override void Dispose()
        {
            this.Dispose();
            Rilisoft.PetsManager.丝丅丑丆三与丛丟丞(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String>(object:  this, method:  System.Void Rilisoft.Offers.不丒上丄业三与下丟::丌丌丁丛丄上丞专一(string 丛丆东与丑丞丅丝专, string 不丁丌丐业丑丟且不)));
            Rilisoft.PetsManager.丗丞七上专三丟丘丐(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.Offers.不丒上丄业三与下丟::丂丗丌丈丟丌丏丗业(string 万且万且丑丗且丌丆)));
            Rilisoft.PetsManager.上丈专业丐丅世上丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.Offers.不丒上丄业三与下丟::丌丈丂丛三丂丆七上()));
        }
        private void 丌丌丁丛丄上丞专一(string 丛丆东与丑丞丅丝专, string 不丁丌丐业丑丟且不)
        {
            goto typeof(Rilisoft.Offers.不丒上丄业三与下丟).__il2cppRuntimeField_198;
        }
        private void 丌丈丂丛三丂丆七上()
        {
            goto typeof(Rilisoft.Offers.不丒上丄业三与下丟).__il2cppRuntimeField_198;
        }
        private void 丂丗丌丈丟丌丏丗业(string 万且万且丑丗且丌丆)
        {
            goto typeof(Rilisoft.Offers.不丒上丄业三与下丟).__il2cppRuntimeField_198;
        }
        private static 不丒上丄业三与下丟()
        {
            System.Collections.Generic.List<七下专丌丐丛丙丝不> val_1 = new System.Collections.Generic.List<七下专丌丐丛丙丝不>();
            if(val_1 != null)
            {
                    val_1.Add(item:  1);
                val_1.Add(item:  2);
            }
            else
            {
                    val_1.Add(item:  1);
                val_1.Add(item:  2);
            }
            
            val_1.Add(item:  0);
            Rilisoft.Offers.不丒上丄业三与下丟.丟丟下丙丈丁下丐三 = val_1;
        }
    
    }

}
