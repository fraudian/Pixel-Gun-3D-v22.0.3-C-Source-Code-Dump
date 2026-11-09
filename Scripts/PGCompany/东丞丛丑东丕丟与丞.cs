using UnityEngine;

namespace PGCompany
{
    internal sealed class 东丞丛丑东丕丟与丞 : 丑丑丒不丝三丅丂丝
    {
        // Methods
        internal override bool 东丌七七丕丟丅专丈()
        {
            东丞丛丑东丕丟与丞.丞上丕丈丒丘丆三丈 val_1 = new 东丞丛丑东丕丟与丞.丞上丕丈丒丘丆三丈();
            .丝且与丝丒丟万丁专 = this;
            if((PGCompany.业专丐丐丘丌丕世丅<PGCompany.七三丌丙下丅不丕丞>.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  137)) == null)
            {
                    return false;
            }
            
            三丏业丘七世一丅不 val_4 = System.Linq.Enumerable.FirstOrDefault<三丏业丘七世一丅不>(source:  val_2.GameOffersSettings, predicate:  new System.Func<三丏业丘七世一丅不, System.Boolean>(object:  val_1, method:  System.Boolean 东丞丛丑东丕丟与丞.丞上丕丈丒丘丆三丈::丐丙丌专丅东丕三丄(PGCompany.七三丌丙下丅不丕丞.三丏业丘七世一丅不 与不丕丆丈不丙丟丛)));
            .丐丙七且丛世丝下专 = val_4;
            if(val_4 == null)
            {
                    return false;
            }
            
            .业万下万丄丕丟丞丙 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
            if(val_2.AllowedItems != null)
            {
                    return val_2.AllowedItems.Exists(match:  new System.Predicate<丙下东丛且七丑丁丁>(object:  val_1, method:  System.Boolean 东丞丛丑东丕丟与丞.丞上丕丈丒丘丆三丈::丛丐丘丙且七丅世丕(PGCompany.七三丌丙下丅不丕丞.丙下东丛且七丑丁丁 丗丛丂且丕丆上世丛)));
            }
            
            return val_2.AllowedItems.Exists(match:  new System.Predicate<丙下东丛且七丑丁丁>(object:  val_1, method:  System.Boolean 东丞丛丑东丕丟与丞.丞上丕丈丒丘丆三丈::丛丐丘丙且七丅世丕(PGCompany.七三丌丙下丅不丕丞.丙下东丛且七丑丁丁 丗丛丂且丕丆上世丛)));
        }
        internal override PGCompany.且丑丒丏丐七丞丞丈 丛上丈丐丗丙下东丁()
        {
            var val_13;
            System.Collections.Generic.IEnumerable<TSource> val_43;
            var val_44;
            System.Func<TSource, System.Boolean> val_45;
            int val_46;
            System.Collections.Generic.IEnumerable<TSource> val_47;
            var val_48;
            System.Func<丄下三丞万丐一丆丏, System.Int32> val_50;
            东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄 val_1 = new 东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄();
            .丝且与丝丒丟万丁专 = this;
            val_43 = PGCompany.业专丐丐丘丌丕世丅<PGCompany.七三丌丙下丅不丕丞>.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  137);
            PGCompany.且丑丒丏丐七丞丞丈 val_3 = null;
            val_44 = val_3;
            val_3 = new PGCompany.且丑丒丏丐七丞丞丈();
            if(val_43 == null)
            {
                    return (PGCompany.且丑丒丏丐七丞丞丈)val_44;
            }
            
            System.Func<三丏业丘七世一丅不, System.Boolean> val_4 = null;
            val_45 = val_4;
            val_4 = new System.Func<三丏业丘七世一丅不, System.Boolean>(object:  val_1, method:  System.Boolean 东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄::丘丁丘丞丙丐一丗丘(PGCompany.七三丌丙下丅不丕丞.三丏业丘七世一丅不 与不丕丆丈不丙丟丛));
            三丏业丘七世一丅不 val_5 = System.Linq.Enumerable.FirstOrDefault<三丏业丘七世一丅不>(source:  val_2.GameOffersSettings, predicate:  val_4);
            .丐丙七且丛世丝下专 = val_5;
            if(val_5 == null)
            {
                    return (PGCompany.且丑丒丏丐七丞丞丈)val_44;
            }
            
            .业万下万丄丕丟丞丙 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
            val_45 = val_2.AllowedItems.FindAll(match:  new System.Predicate<丙下东丛且七丑丁丁>(object:  val_1, method:  System.Boolean 东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄::与丑丕世下业一上上(PGCompany.七三丌丙下丅不丕丞.丙下东丛且七丑丁丁 丗丛丂且丕丆上世丛)));
            if(val_45.Count == 0)
            {
                    return (PGCompany.且丑丒丏丐七丞丞丈)val_44;
            }
            
            System.Collections.Generic.Dictionary<丙下东丛且七丑丁丁, System.Single> val_10 = new System.Collections.Generic.Dictionary<丙下东丛且七丑丁丁, System.Single>();
            List.Enumerator<T> val_11 = val_45.GetEnumerator();
            label_13:
            if(((-41226064) & 1) == 0)
            {
                goto label_8;
            }
            
            string val_14 = val_13.丐丏七丌丕丗业且上();
            val_10.set_Item(key:  val_14, value:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_14 + 32, hi = val_14 + 32}));
            goto label_13;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            丙下东丛且七丑丁丁 val_17 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<丙下东丛且七丑丁丁>(丑东与丅丐丅丂丞业:  val_10);
            val_45 = val_17.Index;
            .丗丁与世丝丟丆丒上 = (东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄)[1152921556105272608].业万下万丄丕丟丞丙.下丞丝丂万丙三丏上(世且丐丐丑丛东专丟:  val_45);
            .丅丐业与丛世丐丐丞 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_45);
            val_46 = 1152921504616751104;
            val_47 = val_2.PricesSettings.FindAll(match:  new System.Predicate<丄下三丞万丐一丆丏>(object:  val_1, method:  System.Boolean 东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄::下一丒丄下丗丅丁丁(PGCompany.七三丌丙下丅不丕丞.丄下三丞万丐一丆丏 与不丕丆丈不丙丟丛)));
            if(val_47.Count == 0)
            {
                goto label_35;
            }
            
            label_55:
            if(val_47.Count == 0)
            {
                    return (PGCompany.且丑丒丏丐七丞丞丈)val_44;
            }
            
            val_46 = 1152921505643266048;
            val_48 = null;
            val_48 = null;
            val_50 = 东丞丛丑东丕丟与丞.<>c.<>9__1_4;
            if(val_50 == null)
            {
                    System.Func<丄下三丞万丐一丆丏, System.Int32> val_26 = null;
                val_50 = val_26;
                val_26 = new System.Func<丄下三丞万丐一丆丏, System.Int32>(object:  东丞丛丑东丕丟与丞.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 东丞丛丑东丕丟与丞.<>c::东丒丆专丂丟丝丂丁(PGCompany.七三丌丙下丅不丕丞.丄下三丞万丐一丆丏 与不丕丆丈不丙丟丛));
                东丞丛丑东丕丟与丞.<>c.<>9__1_4 = val_50;
            }
            
            val_43 = System.Linq.Enumerable.ToList<丄下三丞万丐一丆丏>(source:  System.Linq.Enumerable.OrderBy<丄下三丞万丐一丆丏, System.Int32>(source:  val_47, keySelector:  val_26));
            System.Func<丄下三丞万丐一丆丏, System.Boolean> val_29 = null;
            val_47 = val_29;
            val_29 = new System.Func<丄下三丞万丐一丆丏, System.Boolean>(object:  val_1, method:  System.Boolean 东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄::三下丌丐丄与丐与丌(PGCompany.七三丌丙下丅不丕丞.丄下三丞万丐一丆丏 与不丕丆丈不丙丟丛));
            if((System.Linq.Enumerable.FirstOrDefault<丄下三丞万丐一丆丏>(source:  val_43, predicate:  val_29)) == null)
            {
                goto label_43;
            }
            
            val_46 = UnityEngine.Mathf.Min(a:  专且丝丄丙丗丈不丞.丈丐且丐丆丑丂丄丘(东丏丕丗丕丞丁三丌:  (东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄)[1152921556105272608].丐丙七且丛世丝下专.LackAmountMin, 世万丈与丑专丝一丞:  (东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄)[1152921556105272608].丐丙七且丛世丝下专.LackAmountMax), b:  (东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄)[1152921556105272608].丗丁与世丝丟丆丒上);
            float val_42 = (float)val_46;
            val_42 = (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_30.PriceValue, hi = val_30.PriceValue})) * val_42;
            val_42 = (UnityEngine.Random.Range(min:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_30.PriceModifyMin, hi = val_30.PriceModifyMin}), max:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_30.PriceModifyMax, hi = val_30.PriceModifyMax}))) * val_42;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_36 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_47 = 1152921536284343488;
            val_36.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_30.PriceItemIndex, 丂丕丂丏专丂丄丕且:  UnityEngine.Mathf.CeilToInt(f:  val_42)));
            .丒丆丕丁丟业上七丅 = val_36;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_38 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_43 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_45, 丂丕丂丏专丂丄丕且:  val_46);
            val_38.Add(item:  val_43);
            .下丐丐丁与丂下世七 = val_38;
            return (PGCompany.且丑丒丏丐七丞丞丈)val_44;
            label_35:
            if((val_2.PricesSettings.FindAll(match:  new System.Predicate<丄下三丞万丐一丆丏>(object:  val_1, method:  System.Boolean 东丞丛丑东丕丟与丞.丝丂下丂丐丄丁丑丄::丞七业丙丁业丌丒丐(PGCompany.七三丌丙下丅不丕丞.丄下三丞万丐一丆丏 与不丕丆丈不丙丟丛)))) != null)
            {
                goto label_55;
            }
            
            goto label_55;
            label_43:
            val_44 = 0;
            return (PGCompany.且丑丒丏丐七丞丞丈)val_44;
        }
        private bool 丂业丙丟七业丐与丝(int 丆专且丕专丗与一丏)
        {
            .丆专且丕专丗与一丏 = 丆专且丕专丗与一丏;
            System.Collections.Generic.List<PGCompany.与万丝丞下丒丗丏丙> val_3 = PGCompany.丕一业万丂丟丄丘丙.丑七不且上丗丁一世().下下丐一不丅不丒下();
            if(val_3 != null)
            {
                    return val_3.Exists(match:  new System.Predicate<PGCompany.与万丝丞下丒丗丏丙>(object:  new 东丞丛丑东丕丟与丞.丛与丒丞丁丛上丄丆(), method:  System.Boolean 东丞丛丑东丕丟与丞.丛与丒丞丁丛上丄丆::丏三业丆专丂丈丛丂(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万)));
            }
            
            return val_3.Exists(match:  new System.Predicate<PGCompany.与万丝丞下丒丗丏丙>(object:  new 东丞丛丑东丕丟与丞.丛与丒丞丁丛上丄丆(), method:  System.Boolean 东丞丛丑东丕丟与丞.丛与丒丞丁丛上丄丆::丏三业丆专丂丈丛丂(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万)));
        }
        public 东丞丛丑东丕丟与丞()
        {
        
        }
    
    }

}
