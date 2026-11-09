using UnityEngine;

namespace PGCompany
{
    internal sealed class 丏且丘一丁丆丐一丐 : 一丞且丑丁丆一世三
    {
        // Fields
        private const int 丏丄丄丞专丅丁东专 = 1;
        private readonly System.Collections.Generic.List<PGCompany.丅丘丒丒丒丌丅三丏> 下丏丄上丛专丏丏丝;
        
        // Methods
        internal override System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 丛上丈丐丗丙下东丁()
        {
            PGCompany.丅丘丒丒丒丌丅三丏 val_36;
            int val_38;
            string val_51;
            一一万丒与专丙丁丛 val_52;
            var val_53;
            System.Collections.Generic.IEnumerable<TSource> val_54;
            var val_55;
            System.Func<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.IEnumerable<System.Int32>> val_57;
            var val_58;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Int32> val_60;
            System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_1 = new System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>();
            PGCompany.下七业丄丐世丘丘不 val_3 = PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世().与丕丞丑丅丌上且丝(丐丅丒专丛丏上与业:  2);
            if(val_3 == null)
            {
                    return val_1;
            }
            
            if(val_3.Version != 1)
            {
                    return val_1;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return val_1;
            }
            
            丞丂丘丒丟丞丑下丄 val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_7 != null)
            {
                    val_51 = val_7.业丐丐三丕一丗丛丁();
            }
            else
            {
                    val_51 = 0;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
            {
                    val_52 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛();
            }
            else
            {
                    val_52 = 0;
            }
            
            if(PGCompany.丕丅丁且丝且丙东业.丑七不且上丗丁一世().万上丁一丞业业万东() == val_3.SeasonId)
            {
                    if(val_52 == PGCompany.丕丅丁且丝且丙东业.丑七不且上丗丁一世().上丛一丝丟丂丐丗丙())
            {
                goto label_23;
            }
            
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丒丝世与丗丟丈丅不(世不下丟世一丝丐丗:  val_3.SeasonId, 丄丒下业一不丈丝丘:  val_51, 丅丅下丟丑专下与一:  val_52);
            label_23:
            System.DateTime val_19 = System.DateTime.UtcNow;
            System.DateTime val_21 = val_19.dateData.AddDays(value:  (double)-(System.Math.Max(val1:  1, val2:  val_3.PaymentCalculationPeriod)));
            System.Collections.Generic.List<System.Decimal> val_23 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_21.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_19.dateData});
            if(val_23.Count > 0)
            {
                    decimal val_25 = System.Linq.Enumerable.Sum(source:  val_23);
                decimal val_27 = System.Decimal.op_Implicit(value:  val_23.Count);
                decimal val_28 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_25.flags, hi = val_25.hi, lo = val_25.lo, mid = val_25.mid}, d2:  new System.Decimal() {flags = val_27.flags, hi = val_27.hi, lo = val_27.lo, mid = val_27.mid});
            }
            else
            {
                    val_53 = null;
                val_53 = null;
            }
            
            val_54 = PGCompany.丕丅丁且丝且丙东业.丑七不且上丗丁一世().Load(丐丅丒专丛丏上与业:  2);
            if(val_54 == null)
            {
                    System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_31 = null;
                val_54 = val_31;
                val_31 = new System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>();
            }
            
            val_55 = null;
            val_55 = null;
            val_57 = 丏且丘一丁丆丐一丐.<>c.<>9__2_0;
            if(val_57 == null)
            {
                    System.Func<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.IEnumerable<System.Int32>> val_32 = null;
                val_57 = val_32;
                val_32 = new System.Func<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.IEnumerable<System.Int32>>(object:  丏且丘一丁丆丐一丐.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.Int32> 丏且丘一丁丆丐一丐.<>c::丑丛不东一丈丝丒不(PGCompany.东丑丆丗丏丐丟下丄 七丏丄丅丌业与且丙));
                丏且丘一丁丆丐一丐.<>c.<>9__2_0 = val_57;
            }
            
            System.Collections.Generic.List<TSource> val_34 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.SelectMany<PGCompany.东丑丆丗丏丐丟下丄, System.Int32>(source:  val_31, selector:  val_32));
            List.Enumerator<T> val_35 = val_3.SlotsSettings.GetEnumerator();
            label_70:
            if(((-2004381424) & 1) == 0)
            {
                goto label_52;
            }
            
            new 丏且丘一丁丆丐一丐.丛与丒丞丁丛上丄丆() = new System.Object();
            if((this.下丏丄上丛专丏丏丝.Contains(item:  val_36)) == false)
            {
                goto label_70;
            }
            
            new PGCompany.丙一丟与且丞丏丈一() = new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  PGCompany.三丛丗丆七丁丆上丌.丘丐丕世下丟丁丛三(丁丅丈丌丟世丗丗丟:  2, 丞丅上丏丂且下丅与:  PGCompany.三丛丗丆七丁丆上丌.东一丂丛丞与丁丙业(世七七丟丑丁丂与丞:  val_36, 三丐丘万上下上丛七:  val_38.丅丕丁与丆丆丑丆丝())));
            .丙下不丏丅丅专丂丗 = new PGCompany.丙一丟与且丞丏丈一();
            System.Func<PGCompany.东丑丆丗丏丐丟下丄, System.Boolean> val_45 = new System.Func<PGCompany.东丑丆丗丏丐丟下丄, System.Boolean>(object:  new 丏且丘一丁丆丐一丐.丛与丒丞丁丛上丄丆(), method:  System.Boolean 丏且丘一丁丆丐一丐.丛与丒丞丁丛上丄丆::下一丒丄下丗丅丁丁(PGCompany.东丑丆丗丏丐丟下丄 七丏丄丅丌业与且丙));
            PGCompany.东丑丆丗丏丐丟下丄 val_46 = System.Linq.Enumerable.FirstOrDefault<PGCompany.东丑丆丗丏丐丟下丄>(source:  val_31, predicate:  null);
            if((val_46 == null) || ((val_46 & 1) == 0))
            {
                goto label_59;
            }
            
            val_1.Add(item:  val_46);
            goto label_70;
            label_59:
            PGCompany.东丑丆丗丏丐丟下丄 val_47 = val_46.丛上丈丐丗丙下东丁(丞丈丛丛丙丑业丗专:  val_3, 丁万丝丄丌丒丁三丆:  new 丝丕专世丙丆丛丝丝() {_id = new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_38, 丑丒丄下丁丐专丄丞 = val_38, 上万三丆专丏丒丗业 = val_38}, OfferType = val_36, PriceCurrency = val_36}, 丆万上丝丅丙丙丝丒:  new PGCompany.丅丘丈丞丐专丑且三() {业专丁七丆丏丝丙丙 = val_34, 业业七丛一丒丑丌三 = new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}});
            if(val_47 == null)
            {
                goto label_70;
            }
            
            val_1.Add(item:  val_47);
            val_58 = null;
            val_58 = null;
            val_60 = 丏且丘一丁丆丐一丐.<>c.<>9__2_3;
            if(val_60 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Int32> val_48 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Int32>(object:  丏且丘一丁丆丐一丐.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丏且丘一丁丆丐一丐.<>c::丁丘不丁丝业丘世三(PGCompany.三东丏不丗世丅丌丄 七丏丄丅丌业与且丙));
                val_60 = val_48;
                丏且丘一丁丆丐一丐.<>c.<>9__2_3 = val_60;
            }
            
            val_34.AddRange(collection:  System.Linq.Enumerable.Select<PGCompany.三东丏不丗世丅丌丄, System.Int32>(source:  val_47, selector:  val_48));
            goto label_70;
            label_52:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        private PGCompany.东丑丆丗丏丐丟下丄 丛上丈丐丗丙下东丁(PGCompany.下七业丄丐世丘丘不 丞丈丛丛丙丑业丗专, PGCompany.下七业丄丐世丘丘不.丝丕专世丙丆丛丝丝 丁万丝丄丌丒丁三丆, PGCompany.丅丘丈丞丐专丑且三 丆万上丝丅丙丙丝丒)
        {
            var val_3 = 1152921554142413616;
            PGCompany.PromotionOffersGenerators.丟丅丞丂丂世丄丐东 val_1 = PGCompany.PromotionOffers.不业丐丑丈丟不专丝.丗丘上一不下丙与万(丐丅丒专丛丏上与业:  -2004032704);
            if(val_1 == null)
            {
                    return (PGCompany.东丑丆丗丏丐丟下丄)val_1;
            }
            
            return (PGCompany.东丑丆丗丏丐丟下丄)val_1;
        }
        public 丏且丘一丁丆丐一丐()
        {
            System.Collections.Generic.List<PGCompany.丅丘丒丒丒丌丅三丏> val_1 = new System.Collections.Generic.List<PGCompany.丅丘丒丒丒丌丅三丏>();
            if(val_1 != null)
            {
                    val_1.Add(item:  2);
                val_1.Add(item:  3);
            }
            else
            {
                    val_1.Add(item:  2);
                val_1.Add(item:  3);
            }
            
            val_1.Add(item:  4);
            this.下丏丄上丛专丏丏丝 = val_1;
        }
    
    }

}
