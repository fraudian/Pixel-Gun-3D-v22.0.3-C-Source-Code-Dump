using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 丌丒且丑丐丐丒丗且 : 丑丝上世丄丂丛丛丕, IDisposable
    {
        // Fields
        private Rilisoft.Offers.丘专丏丙丏与丘丕丘 丈且丑丑丌丅丄专世;
        private System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 且丑不丛丏丏丐丄丐;
        private Rilisoft.且丈丞一丞丟与上七 丞专丟七丈万丅且丙;
        private bool 不东下世世丈与丕与;
        private decimal 东丁丄一丛丌不不丆;
        private Rilisoft.Offers.丘专丏丙丏与丘丕丘.丕丂丒丟丆不丗丞与 与丌丛且丐丙丗专万;
        
        // Properties
        public int 业不一丒丁专丝丛丑 { get; }
        public Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丗丑不丁丐丄丑丑东 { get; }
        public bool 七七世丅东丈丛丞丕 { get; }
        
        // Methods
        public int 丕丞世一丟丞丞丗丐()
        {
            return 1;
        }
        public Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 与丝丅丘且丐上丅世()
        {
            return 80;
        }
        public bool 丁世东三丂丒不七丆()
        {
            return true;
        }
        internal 丌丒且丑丐丐丒丗且()
        {
            var val_4;
            this.且丑不丛丏丏丐丄丐 = new System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>();
            this.丞专丟七丈万丅且丙 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "ModulesOffersModule_lastSeason");
            this.不东下世世丈与丕与 = true;
            val_4 = null;
            val_4 = null;
            this.东丁丄一丛丌不不丆 = System.Decimal.MinusOne;
            mem[1152921543787895780] = System.Decimal.Powers10.__il2cppRuntimeField_30;
            ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.Offers.丌丒且丑丐丐丒丗且::一丛专丄丁丄三丝丅()));
        }
        private void 一丛专丄丁丄三丝丅()
        {
            this.不东下世世丈与丕与 = true;
        }
        public void Dispose()
        {
            ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.Offers.丌丒且丑丐丐丒丗且::一丛专丄丁丄三丝丅()));
            List.Enumerator<T> val_2 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_6:
            if((526583688 & 1) == 0)
            {
                goto label_4;
            }
            
            if(0.丐丏七丌丕丗业且上() != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.且丑不丛丏丏丐丄丐.Clear();
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 丐上丙世丂丅丝不丈()
        {
            var val_2;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = 丌丒且丑丐丐丒丗且.<>c.<>9__12_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丌丒且丑丐丐丒丗且.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丒且丑丐丐丒丗且.<>c::与丏丌丟不与丒丅丂(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丌丒且丑丐丐丒丗且.<>c.<>9__12_0 = val_4;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1);
        }
        public System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 丙丈丈东丟丟丒丄三()
        {
            var val_3;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = 丌丒且丑丐丐丒丗且.<>c.<>9__13_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丌丒且丑丐丐丒丗且.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丒且丑丐丐丒丗且.<>c::世丛丅丝七丛丘丛业(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丌丒且丑丐丐丒丗且.<>c.<>9__13_0 = val_5;
            return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1));
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 上丑下专丄下丟丏丆(string 丗丟丁丐与下丙丕丛)
        {
            .丗丟丁丐与下丙丕丛 = 丗丟丁丐与下丙丕丛;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  new 丌丒且丑丐丐丒丗且.丌丟丘丏丕丅七万丕(), method:  System.Boolean 丌丒且丑丐丐丒丗且.丌丟丘丏丕丅七万丕::万上下上与丅专丑丗(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上)));
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 丅世业丂丝丁丌七丗(string 业丒丌东丈丏丈一不)
        {
            string val_5 = 业丒丌东丈丏丈一不;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5 = 业丒丌东丈丏丈一不)) != false)
            {
                    return 0;
            }
            
            int val_2 = val_5.LastIndexOf(value:  '-');
            if((val_2 & 2147483648) != 0)
            {
                    return this.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_5 = val_5.Substring(startIndex:  val_2 + 1));
            }
            
            return this.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_5);
        }
        public System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 东东丛一丄丅丌丗且()
        {
            return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐);
        }
        public bool 且丟丌丑丘丕七专三()
        {
            var val_2;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = 丌丒且丑丐丐丒丗且.<>c.<>9__17_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丌丒且丑丐丐丒丗且.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丒且丑丐丐丒丗且.<>c::业丐不丝丑一与七且(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丌丒且丑丐丐丒丗且.<>c.<>9__17_0 = val_4;
            return System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1);
        }
        public void 丁东丐丄丞丌丘业上()
        {
            List.Enumerator<T> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_4:
            if((527511048 & 1) == 0)
            {
                goto label_2;
            }
            
            0.丐丏七丌丕丗业且上().丁东丐丄丞丌丘业上();
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public void 丁丆丕丏东丟丐丄丂()
        {
            List.Enumerator<T> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_4:
            if((527643528 & 1) == 0)
            {
                goto label_2;
            }
            
            if(0.丐丏七丌丕丗业且上() != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.且丑不丛丏丏丐丄丐.Clear();
            this.不东下世世丈与丕与 = true;
        }
        public void 丑七丂丌世与七丏与(string 丅业丙丞且丐一丙丆)
        {
            DataSystem.丈且丈上不下且丝丒 val_5 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.丈且丑丑丌丅丄专世 = val_5;
            if(val_5 == null)
            {
                goto label_16;
            }
            
            if(this.丞专丟七丈万丅且丙.世三丞丅丑丌丈丈一() <= 0)
            {
                goto label_10;
            }
            
            val_5 = this.丈且丑丑丌丅丄专世;
            if(this.丞专丟七丈万丅且丙.世三丞丅丑丌丈丈一() >= this.丈且丑丑丌丅丄专世.SeasonId)
            {
                goto label_16;
            }
            
            val_5 = this.丈且丑丑丌丅丄专世.SeasonId;
            this.丞专丟七丈万丅且丙.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  val_5);
            goto label_16;
            label_10:
            val_5 = this.丈且丑丑丌丅丄专世.SeasonId;
            this.丞专丟七丈万丅且丙.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  val_5);
            label_16:
            this.丐丅万与东丞丁丛丘();
        }
        public void 丟一丏与丈丅丗丅丈()
        {
        
        }
        public void 且丛丕业丞万东七丒(bool 丆丄丘丂业丛七丁且 = False)
        {
            if((this.丈且丑丑丌丅丄专世 != null) && (this.丈且丑丑丌丅丄专世.Level >= 1))
            {
                    if(this.丈且丑丑丌丅丄专世.Level <= ExperienceController.丞丞丘业东丙丏七丌())
            {
                goto label_5;
            }
            
            }
            
            this.且丑不丛丏丏丐丄丐.Clear();
            this.与丌丛且丐丙丗专万 = 0;
            return;
            label_5:
            if(丆丄丘丂业丛七丁且 != true)
            {
                    if(this.不东下世世丈与丕与 == false)
            {
                    return;
            }
            
            }
            
            this.不东下世世丈与丕与 = false;
            this.丐丅万与东丞丁丛丘();
        }
        private void 丐丅万与东丞丁丛丘()
        {
            丌丒且丑丐丐丒丗且.丛东丟丅丙丗世丗不 val_1 = new 丌丒且丑丐丐丒丗且.丛东丟丅丙丗世丗不();
            .丝且与丝丒丟万丁专 = this;
            this.且丑不丛丏丏丐丄丐.Clear();
            this.与丌丛且丐丙丗专万 = 0;
            System.DateTime val_2 = System.DateTime.UtcNow;
            System.DateTime val_4 = val_2.dateData.AddDays(value:  (double)-(System.Math.Max(val1:  1, val2:  this.丈且丑丑丌丅丄专世.CheckPaymentGroupInterval)));
            decimal val_7 = System.Linq.Enumerable.Sum(source:  PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_4.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_2.dateData}));
            this.东丁丄一丛丌不不丆 = val_7;
            mem[1152921543789815012] = val_7.lo;
            mem[1152921543789815016] = val_7.mid;
            .丙丂丏丛丌丏下丝不 = ExperienceController.丞丞丘业东丙丏七丌();
            丕丂丒丟丆不丗丞与 val_10 = System.Linq.Enumerable.FirstOrDefault<丕丂丒丟丆不丗丞与>(source:  this.丈且丑丑丌丅丄专世.Levels, predicate:  new System.Func<丕丂丒丟丆不丗丞与, System.Boolean>(object:  val_1, method:  System.Boolean 丌丒且丑丐丐丒丗且.丛东丟丅丙丗世丗不::且丄七丄专丒业业丗(Rilisoft.Offers.丘专丏丙丏与丘丕丘.丕丂丒丟丆不丗丞与 丐三丞七丝丅不万丛)));
            if(val_10 == null)
            {
                    return;
            }
            
            丐丒丏不专丟丅丘丐 val_12 = System.Linq.Enumerable.FirstOrDefault<丐丒丏不专丟丅丘丐>(source:  val_10.Contents, predicate:  new System.Func<丐丒丏不专丟丅丘丐, System.Boolean>(object:  val_1, method:  System.Boolean 丌丒且丑丐丐丒丗且.丛东丟丅丙丗世丗不::丆丕丛丏丌丌丙丌业(Rilisoft.Offers.丘专丏丙丏与丘丕丘.丐丒丏不专丟丅丘丐 丁丂专业丁丅丅丈丙)));
            if(val_12 == null)
            {
                    return;
            }
            
            Rilisoft.业丙丘丆东丈丕丂丄 val_13 = this.丁与且丅丏下丌且与(三丏丑不业丏不丂丈:  val_12);
            if(val_13 == null)
            {
                    return;
            }
            
            this.且丑不丛丏丏丐丄丐.Add(item:  val_13);
            this.与丌丛且丐丙丗专万 = val_10;
        }
        private Rilisoft.业丙丘丆东丈丕丂丄 丁与且丅丏下丌且与(Rilisoft.Offers.丘专丏丙丏与丘丕丘.丐丒丏不专丟丅丘丐 三丏丑不业丏不丂丈)
        {
            string val_24;
            Progress.OfferProgress val_25;
            var val_26;
            System.Func<Rilisoft.OfferItem, System.String> val_28;
            var val_29;
            System.Func<System.String, System.String, System.String> val_31;
            var val_32;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_34;
            var val_35;
            丈丞丕丘丕丗与上一 val_36;
            val_25 = 三丏丑不业丏不丂丈;
            if((val_25 == null) || (三丏丑不业丏不丂丈.Items == null))
            {
                goto label_2;
            }
            
            val_26 = null;
            val_26 = null;
            val_28 = 丌丒且丑丐丐丒丗且.<>c.<>9__25_0;
            if(val_28 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_1 = null;
                val_28 = val_1;
                val_1 = new System.Func<Rilisoft.OfferItem, System.String>(object:  丌丒且丑丐丐丒丗且.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丒且丑丐丐丒丗且.<>c::丄上丛丕丁世丛丛世(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                丌丒且丑丐丐丒丗且.<>c.<>9__25_0 = val_28;
            }
            
            val_29 = null;
            val_29 = null;
            val_31 = 丌丒且丑丐丐丒丗且.<>c.<>9__25_1;
            if(val_31 == null)
            {
                    System.Func<System.String, System.String, System.String> val_3 = null;
                val_31 = val_3;
                val_3 = new System.Func<System.String, System.String, System.String>(object:  丌丒且丑丐丐丒丗且.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丒且丑丐丐丒丗且.<>c::丝且丈一东丒丐一丘(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
                丌丒且丑丐丐丒丗且.<>c.<>9__25_1 = val_31;
            }
            
            val_32 = null;
            val_24 = System.String.Format(format:  "md_{0}_{1}_[{2}]", arg0:  this.丈且丑丑丌丅丄专世.SeasonId, arg1:  三丏丑不业丏不丂丈.Price, arg2:  System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  三丏丑不业丏不丂丈.Items, selector:  val_1), func:  val_3));
            val_32 = null;
            val_34 = 丌丒且丑丐丐丒丗且.<>c.<>9__25_2;
            if(val_34 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_6 = null;
                val_34 = val_6;
                val_6 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丌丒且丑丐丐丒丗且.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌丒且丑丐丐丒丗且.<>c::丂丅丝丅业丗丁丑丛(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                丌丒且丑丐丐丒丗且.<>c.<>9__25_2 = val_34;
            }
            
            System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  三丏丑不业丏不丂丈.Items, predicate:  val_6));
            Rilisoft.七丈业与与不七丈丟 val_9 = new Rilisoft.七丈业与与不七丈丟();
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_9 == null)
            {
                goto label_21;
            }
            
            .万丈丘丏丅世万丝丄 = val_10;
            goto label_22;
            label_2:
            val_35 = 0;
            return (Rilisoft.业丙丘丆东丈丕丂丄)val_35;
            label_21:
            mem[24] = val_10;
            label_22:
            .下丄丈不与世丐业专 = val_24;
            .三丌丄丆下丑丛七不 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = this.丈且丑丑丌丅丄专世.Start});
            .丗专丒丕丄下丘丁丛 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = this.丈且丑丑丌丅丄专世.End});
            .丁丑丅丐丌不世丁下 = new 七丈业与与不七丈丟.丏一丄丐专丟丂丟丏();
            .丆东丂丄丁丛丑与七 = new System.Collections.Generic.List<丂七丄不专下丘丂丟>();
            .且东丌丏丐丝丕万业 = val_8;
            if((三丏丑不业丏不丂丈.Price.Clone() != null) && (null != null))
            {
                    val_36 = 0;
            }
            
            .丒丆丕丁丟业上七丅 = val_36;
            .丒上一丁丆丛东专丙 = new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒();
            val_25 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丈丒且丗七丗丄下丐(丗丟丁丐与下丙丕丛:  val_24);
            if(val_25 == null)
            {
                    Progress.OfferProgress val_20 = null;
                val_25 = val_20;
                val_20 = new Progress.OfferProgress();
                if(val_25 != null)
            {
                    .Id = val_24;
            }
            else
            {
                    mem[16] = val_24;
            }
            
                .PreparedItems = val_8;
                .FirstShowDate = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            }
            
            Rilisoft.业丙丘丆东丈丕丂丄 val_23 = null;
            val_35 = val_23;
            val_23 = new Rilisoft.业丙丘丆东丈丕丂丄(丁丅丈丌丟世丗丗丟:  80, 一丐丗丁丞丆丅丟丄:  val_9, 上丕丈丞丌丘丅不与:  val_20, 丑丒丛与下专且丗不:  new System.Nullable<AdaptiveModuleType>() {HasValue = false}, 东一丁世丑丞业丄丐:  0);
            return (Rilisoft.业丙丘丆东丈丕丂丄)val_35;
        }
        internal string 不世下丘丑丘丛丂世()
        {
            string val_1;
            if(this.与丌丛且丐丙丗专万 == null)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_1 = this.与丌丛且丐丙丗专万.Raid;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
    
    }

}
