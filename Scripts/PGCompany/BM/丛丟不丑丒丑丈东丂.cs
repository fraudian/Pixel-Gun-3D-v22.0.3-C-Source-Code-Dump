using UnityEngine;

namespace PGCompany.BM
{
    internal class 丛丟不丑丒丑丈东丂 : 丏丈丁与丑一丝下丒
    {
        // Fields
        private PGCompany.BM.丝七丙下丈丌丈丞丘 世丂上丌丞且丁七丏;
        private readonly System.Collections.Generic.List<Rilisoft.OfferItemType> 丞丑丈与且与业七世;
        private System.Collections.Generic.List<int> 业与三丐丟丕专丝丆;
        
        // Methods
        internal override bool 丏丑业丛丂万上专丘(PGCompany.BM.丝七丙下丈丌丈丞丘 上世丏丁世丟世丆业, System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 丁丕丁丞下丗丏三丞, PGCompany.BM.丁七上一三丁上丑丑 丌丝万上丅丒一丈丘, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丄丗丂丟丛丂丆丏丗, out System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丑七不与丛丆一丂丞, out PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞)
        {
            var val_24;
            object val_25;
            System.Collections.Generic.Dictionary<T1, T2> val_26;
            System.Collections.Generic.Dictionary<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且> val_27;
            System.Func<ItemRarity, System.Single> val_28;
            System.Collections.Generic.List<Rilisoft.OfferItemType> val_29;
            ItemRarity val_30;
            PGCompany.七丑一上且三世丝三<K, V> val_31;
            var val_32;
            val_24 = 丌丝万上丅丒一丈丘;
            int val_11 = 0;
            丛丟不丑丒丑丈东丂.丛与丒丞丁丛上丄丆 val_1 = null;
            val_25 = val_1;
            val_1 = new 丛丟不丑丒丑丈东丂.丛与丒丞丁丛上丄丆();
            this.世丂上丌丞且丁七丏 = 上世丏丁世丟世丆业;
            丑七不与丛丆一丂丞 = 0;
            丒世丘丘上丆丝东丞 = 0;
            PGCompany.七丑一上且三世丝三<K, V> val_2 = PGCompany.七丑一上且三世丝三<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且>.万世丅七一专丕丞不();
            if(val_25 != null)
            {
                    val_26 = val_25;
                .丄丅七万丌丟丄丘丛 = val_2;
            }
            else
            {
                    val_26 = 16;
                mem[16] = val_2;
            }
            
            val_27 = 丌丝万上丅丒一丈丘._dropWeight;
            专且丝丄丙丗丈不丞.丝丐丝丛上丙丕丟一<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且>(万丝且丘不丑丝下丑:  val_26, 下丈丌三且三丝丄与:  val_27, 丘丁丙丐丆不丕丟丂:  false);
            label_20:
            if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且>>(source:  mem[16])) == false)
            {
                goto label_10;
            }
            
            val_28 = (丛丟不丑丒丑丈东丂.丛与丒丞丁丛上丄丆)[1152921560538459264].上丌丘丑一且丆且丏;
            if(val_28 == null)
            {
                    System.Func<ItemRarity, System.Single> val_7 = null;
                val_28 = val_7;
                val_7 = new System.Func<ItemRarity, System.Single>(object:  val_1, method:  System.Single 丛丟不丑丒丑丈东丂.丛与丒丞丁丛上丄丆::丙丈丟丟丈业一丄丌(ItemRarity 业下丌下三丕丙丌下));
                .上丌丘丑一且丆且丏 = val_28;
            }
            
            ItemRarity val_8 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<ItemRarity>(丑东与丅丐丅丂丞业:  System.Linq.Enumerable.ToList<ItemRarity>(source:  mem[16].Keys), 丆万丒下万下业且丑:  val_7);
            bool val_9 = mem[16].Remove(key:  val_8);
            val_29 = 0;
            if(丌丝万上丅丒一丈丘._id <= 3)
            {
                    val_29 = this.丞丑丈与且与业七世;
            }
            
            if((this.丈世世万丕丁世丁一(丁丕丁丞下丗丏三丞:  丁丕丁丞下丗丏三丞, 业丙丌丕专丅专与丑:  val_29, 丈下丑丆上丏丗丈专:  val_8, 丑丅丁专丅丛丁丑且:  丌丝万上丅丒一丈丘._slotType, 丄丗丂丟丛丂丆丏丗:  丄丗丂丟丛丂丆丏丗, 丒专丑丒丁丞三丆业: out  0, 世丈三丐丞一丒丛不: out  val_11, 专丅丐丝业丐丅丅下: out  (丛丟不丑丒丑丈东丂.七世丅不丅且三丄丕)[1152921560538471552].丕丐丗世丌三上丌世)) == false)
            {
                goto label_20;
            }
            
            val_24 = val_11;
            丒世丘丘上丆丝东丞 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.世丂上丌丞且丁七丏._currencyConvertation.Item[0], predicate:  new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  new 丛丟不丑丒丑丈东丂.七世丅不丅且三丄丕(), method:  System.Boolean 丛丟不丑丒丑丈东丂.七世丅不丅且三丄丕::丛一丌丗丆世丆丟丈(PGCompany.三东丏不丗世丅丌丄 七丞丙丒三丕且丌丟)));
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_17 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            丑七不与丛丆一丂丞 = val_17;
            val_27 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  16).与下不与丐丈丁丈万();
            丝丆丁丒丌丂上丑丏 val_20 = 0.Item[0];
            val_27.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_20._count);
            val_25 = 1152921536284343488;
            val_17.Add(item:  val_27);
            val_30 = 64;
            PGCompany.三东丏不丗世丅丌丄 val_21 = val_17.专丂丘世三世不丞下(上世丏丁世丟世丆业:  this.世丂上丌丞且丁七丏, 丈下丑丆上丏丗丈专:  val_30, 世丈三丐丞一丒丛不:  0);
            if(val_21 != null)
            {
                    val_30 = public System.Void System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>::Add(PGCompany.三东丏不丗世丅丌丄 item);
                val_17.Add(item:  val_21);
            }
            
            PGCompany.七丑一上且三世丝三<K, V> val_22 = PGCompany.七丑一上且三世丝三<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且>.万世丅七一专丕丞不();
            val_31 = mem[16];
            val_32 = 1;
            return (bool)val_32;
            label_10:
            val_31 = PGCompany.七丑一上且三世丝三<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且>.万世丅七一专丕丞不();
            val_32 = 0;
            return (bool)val_32;
        }
        private bool 丈世世万丕丁世丁一(System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 丁丕丁丞下丗丏三丞, System.Collections.Generic.List<Rilisoft.OfferItemType> 业丙丌丕专丅专与丑, ItemRarity 丈下丑丆上丏丗丈专, PGCompany.BM.世业丈丑七丁东上东 丑丅丁专丅丛丁丑且, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丄丗丂丟丛丂丆丏丗, out PGCompany.BM.丒万丗丏一丝丅丌世 丒专丑丒丁丞三丆业, out int 世丈三丐丞一丒丛不, out PGCompany.三丌上丁一丟丐丟丈 专丅丐丝业丐丅丅下)
        {
            var val_5;
            System.Collections.Generic.IEnumerable<TSource> val_36;
            System.Collections.Generic.IList<T> val_37;
            PGCompany.BM.丒万丗丏一丝丅丌世 val_38;
            PGCompany.BM.丟三东丒与万上且东 val_39;
            var val_40;
            PGCompany.BM.丒万丗丏一丝丅丌世 val_41;
            var val_42;
            var val_43;
            var val_44;
            System.Func<PGCompany.BM.丘丆丆丁丝且不丄东, System.Single> val_46;
            var val_47;
            丛丟不丑丒丑丈东丂.上丌专丄丘丂东且丒 val_1 = new 丛丟不丑丒丑丈东丂.上丌专丄丘丂东且丒();
            丒专丑丒丁丞三丆业 = 0;
            世丈三丐丞一丒丛不 = 0;
            专丅丐丝业丐丅丅下 = 0;
            val_36 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.BM.丘丆丆丁丝且不丄东>.万世丅七一专丕丞不();
            List.Enumerator<T> val_3 = 丁丕丁丞下丗丏三丞.GetEnumerator();
            val_37 = 1152921560526242016;
            label_57:
            if((97367360 & 1) == 0)
            {
                goto label_5;
            }
            
            new 丛丟不丑丒丑丈东丂.七丝丈万丄丕七专专() = new System.Object();
            val_38 = val_5.丐丏七丌丕丗业且上();
            if(new 丛丟不丑丒丑丈东丂.七丝丈万丄丕七专专() == null)
            {
                goto label_6;
            }
            
            .东七上世万下丗丄丛 = val_38;
            if(val_38 == null)
            {
                goto label_57;
            }
            
            label_12:
            if(new 丛丟不丑丒丑丈东丂.七丝丈万丄丕七专专() == null)
            {
                goto label_8;
            }
            
            if(val_38 != null)
            {
                goto label_13;
            }
            
            goto label_10;
            label_6:
            mem[16] = val_38;
            if(mem[16] == 0)
            {
                goto label_57;
            }
            
            goto label_12;
            label_8:
            val_38 = .东七上世万下丗丄丛;
            if(val_38 != null)
            {
                goto label_13;
            }
            
            label_10:
            label_13:
            if(((((val_7._rarity != 丈下丑丆上丏丗丈专) || (val_7._forSlotType != 丑丅丁专丅丛丁丑且)) || ((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.Collections.Generic.KeyValuePair<System.Int32, 丝丆丁丒丌丂上丑丏>>(丈丆丕与丒丌丘丕且:  val_7._reals)) == true)) || ((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<PGCompany.三丌上丁一丟丐丟丈>(丈丆丕与丒丌丘丕且:  val_7._currencies)) == true)) || ((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_7._itemIndex>>0&0xFFFFFFFF)) == null))
            {
                goto label_57;
            }
            
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_11 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  new 丛丟不丑丒丑丈东丂.七丝丈万丄丕七专专(), method:  System.Boolean 丛丟不丑丒丑丈东丂.七丝丈万丄丕七专专::下上丈东三七丄丂业(PGCompany.三东丏不丗世丅丌丄 七丞丙丒三丕且丌丟));
            if((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  丄丗丂丟丛丂丆丏丗, predicate:  null)) == true)
            {
                goto label_57;
            }
            
            if(业丙丌丕专丅专与丑 != 0)
            {
                    if((业丙丌丕专丅专与丑.Contains(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_7._itemIndex>>0&0xFFFFFFFF).不业丙丒丂丞下丆丙())) == false)
            {
                goto label_57;
            }
            
            }
            
            PGCompany.BM.丟三东丒与万上且东 val_16 = PGCompany.BM.丟三东丒与万上且东.丑七不且上丗丁一世();
            val_39 = val_16;
            if(val_39 == 0)
            {
                    val_39 = val_16;
            }
            
            if((val_39.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_7._itemIndex>>0&0xFFFFFFFF))) == false)
            {
                goto label_57;
            }
            
            PGCompany.BM.丘丆丆丁丝且不丄东 val_19 = PGCompany.BM.丘丆丆丁丝且不丄东.丐下下丅与上东丙丑();
            if(new 丛丟不丑丒丑丈东丂.七丝丈万丄丕七专专() == null)
            {
                goto label_41;
            }
            
            val_41 = .东七上世万下丗丄丛;
            if(val_41 != null)
            {
                goto label_44;
            }
            
            goto label_43;
            label_41:
            val_40 = 0;
            val_41 = .东七上世万下丗丄丛;
            if(val_41 != null)
            {
                goto label_44;
            }
            
            label_43:
            val_40 = 0;
            label_44:
            if(new 丛丟不丑丒丑丈东丂.七丝丈万丄丕七专专() == null)
            {
                    val_40 = 0;
            }
            
            if(.东七上世万下丗丄丛 == null)
            {
                    val_40 = 0;
            }
            
            if(val_19 == 0)
            {
                    val_40 = 0;
            }
            
            PGCompany.BM.丘丆丆丁丝且不丄东 val_20 = val_19.丈且东丑丂且万丒丅(丒专丑丒丁丞三丆业:  .东七上世万下丗丄丛, 业三世丁一万且丄专:  val_7._currencies, 丏丅东丙东业三丈丗:  val_7._reals);
            System.Collections.Generic.List<System.Int32> val_22 = this.世三丗丛丏不丂丑东();
            if(((PGCompany.BM.东丂丟丄上专丘丛丏.丞丈丏七丅丏丕丌丞(丒专丑丒丁丞三丆业:  .东七上世万下丗丄丛)) & 1) == 0)
            {
                goto label_52;
            }
            
            val_36.Add(item:  val_19);
            goto label_57;
            label_52:
            PGCompany.BM.丘丆丆丁丝且不丄东.丁丟丞丗丆七丙丐丌(丏东丁丂七丟不丒丅:  val_19);
            goto label_57;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_42 = 1152921560538650336;
            val_43 = 1152921505630273536;
            if((System.Linq.Enumerable.Any<PGCompany.BM.丘丆丆丁丝且不丄东>(source:  val_36)) == false)
            {
                goto label_98;
            }
            
            val_44 = null;
            val_44 = null;
            val_46 = 丛丟不丑丒丑丈东丂.<>c.<>9__3_0;
            if(val_46 == null)
            {
                    System.Func<PGCompany.BM.丘丆丆丁丝且不丄东, System.Single> val_24 = null;
                val_46 = val_24;
                val_24 = new System.Func<PGCompany.BM.丘丆丆丁丝且不丄东, System.Single>(object:  丛丟不丑丒丑丈东丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Single 丛丟不丑丒丑丈东丂.<>c::丞且丙丞丆丗丙丄上(PGCompany.BM.丘丆丆丁丝且不丄东 东七上世万下丗丄丛));
                丛丟不丑丒丑丈东丂.<>c.<>9__3_0 = val_46;
            }
            
            PGCompany.BM.丘丆丆丁丝且不丄东 val_25 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.BM.丘丆丆丁丝且不丄东>(丑东与丅丐丅丂丞业:  val_36, 丆万丒下万下业且丑:  val_24);
            if(val_1 == null)
            {
                goto label_106;
            }
            
            .丆丆丆丂丌丄丕丟丘 = val_25;
            if(val_25 != null)
            {
                goto label_123;
            }
            
            label_124:
            label_123:
            val_37 = System.Linq.Enumerable.ToList<System.Int32>(source:  val_25.<丑丌三万万丙且丄丕>k__BackingField.Keys);
            世丈三丐丞一丒丛不 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<System.Int32>(丑东与丅丐丅丂丞业:  val_37, 丆万丒下万下业且丑:  new System.Func<System.Int32, System.Single>(object:  val_1, method:  System.Single 丛丟不丑丒丑丈东丂.上丌专丄丘丂东且丒::万丄丝丙三丗与丒丘(int 东七上世万下丗丄丛)));
            丒专丑丒丁丞三丆业 = (丛丟不丑丒丑丈东丂.上丌专丄丘丂东且丒)[1152921560538865984].丆丆丆丂丌丄丕丟丘.<东七丐丈一丌万丈世>k__BackingField;
            专丅丐丝业丐丅丅下 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.三丌上丁一丟丐丟丈>(丑东与丅丐丅丂丞业:  (丛丟不丑丒丑丈东丂.上丌专丄丘丂东且丒)[1152921560538865984].丆丆丆丂丌丄丕丟丘.<东七丐丈一丌万丈世>k__BackingField._currencies);
            PGCompany.东丑丒丗一丞下丙丙<T> val_31 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.BM.丘丆丆丁丝且不丄东>.万世丅七一专丕丞不();
            List.Enumerator<T> val_32 = val_36.GetEnumerator();
            val_42 = 1152921560538762976;
            label_118:
            if((97367336 & 1) == 0)
            {
                goto label_115;
            }
            
            PGCompany.BM.丘丆丆丁丝且不丄东.丁丟丞丗丆七丙丐丌(丏东丁丂七丟不丒丅:  0.丐丏七丌丕丗业且上());
            goto label_118;
            label_98:
            PGCompany.东丑丒丗一丞下丙丙<T> val_34 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.BM.丘丆丆丁丝且不丄东>.万世丅七一专丕丞不();
            val_47 = 0;
            return (bool)val_47;
            label_106:
            .丆丆丆丂丌丄丕丟丘 = val_25;
            if((丛丟不丑丒丑丈东丂.上丌专丄丘丂东且丒)[1152921560538865984].丆丆丆丂丌丄丕丟丘 != null)
            {
                goto label_123;
            }
            
            goto label_124;
            label_115:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_47 = 1;
            return (bool)val_47;
        }
        private System.Collections.Generic.List<int> 世三丗丛丏不丂丑东()
        {
            int val_14;
            System.Collections.Generic.List<System.Int32> val_15;
            if((System.Linq.Enumerable.Any<System.Int32>(source:  this.业与三丐丟丕专丝丆)) == true)
            {
                    return (System.Collections.Generic.List<System.Int32>)this.业与三丐丟丕专丝丆;
            }
            
            System.DateTime val_2 = System.DateTime.UtcNow;
            System.DateTime val_4 = val_2.dateData.AddDays(value:  (double)-(System.Math.Max(val1:  1, val2:  this.世丂上丌丞且丁七丏._checkPurchasesInterval)));
            System.Collections.Generic.List<System.Decimal> val_6 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_4.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_2.dateData});
            this.业与三丐丟丕专丝丆 = Rilisoft.Offers.丁且丕专万丈丒丏丗.不与东丌一丘专丈丘();
            if((System.Linq.Enumerable.Any<System.Decimal>(source:  val_6)) != false)
            {
                    decimal val_9 = System.Linq.Enumerable.Max(source:  val_6);
                val_14 = val_9.lo;
                if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_14, mid = val_9.mid}, d2:  new System.Decimal())) == false)
            {
                    return (System.Collections.Generic.List<System.Int32>)this.业与三丐丟丕专丝丆;
            }
            
                val_15 = this.业与三丐丟丕专丝丆;
                val_14 = 1152921525515998256;
            }
            else
            {
                    val_14 = 1152921525515998256;
                bool val_11 = this.业与三丐丟丕专丝丆.Remove(item:  20);
                val_15 = this.业与三丐丟丕专丝丆;
            }
            
            bool val_12 = val_15.Remove(item:  50);
            bool val_13 = this.业与三丐丟丕专丝丆.Remove(item:  100);
            return (System.Collections.Generic.List<System.Int32>)this.业与三丐丟丕专丝丆;
        }
        public 丛丟不丑丒丑丈东丂()
        {
            System.Collections.Generic.List<Rilisoft.OfferItemType> val_1 = new System.Collections.Generic.List<Rilisoft.OfferItemType>();
            if(val_1 != null)
            {
                    val_1.Add(item:  10);
                val_1.Add(item:  70);
                val_1.Add(item:  176);
                val_1.Add(item:  242);
            }
            else
            {
                    val_1.Add(item:  10);
                val_1.Add(item:  70);
                val_1.Add(item:  176);
                val_1.Add(item:  242);
            }
            
            val_1.Add(item:  232);
            this.丞丑丈与且与业七世 = val_1;
            this.业与三丐丟丕专丝丆 = new System.Collections.Generic.List<System.Int32>();
            this = new System.Object();
        }
    
    }

}
