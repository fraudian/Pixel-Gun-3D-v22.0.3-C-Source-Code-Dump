using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 丒丑下丙丅丂丁丈不 : 丑丝上世丄丂丛丛丕, IDisposable
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 且丑不丛丏丏丐丄丐;
        private Rilisoft.Offers.七丞丄丘七丌上下丘 世丂上丌丞且丁七丏;
        private System.Collections.Generic.List<System.Decimal> 丂丁丒一丅丄丏丐丁;
        private static Progress.DailyTierProgress 丈丄丂下丒专丌丛丄;
        private UnityEngine.Coroutine 上丈丁丛丕丅丄丌丂;
        
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
            return 90;
        }
        public bool 丁世东三丂丒不七丆()
        {
            return true;
        }
        internal 丒丑下丙丅丂丁丈不()
        {
            this.且丑不丛丏丏丐丄丐 = new System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>();
            Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄 = Progress.七七世万专丕丁上业.丑丙丏东丘丏专丐丕().下东丕业丛丝不万丏();
            Rilisoft.业丙丘丆东丈丕丂丄.丁丗一丅三上丟丗世(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.业丙丘丆东丈丕丂丄>(object:  this, method:  System.Void Rilisoft.Offers.丒丑下丙丅丂丁丈不::丁丒丟丈世且丆丂丒(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)));
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 上丑下专丄下丟丏丆(string 丗丟丁丐与下丙丕丛)
        {
            .丗丟丁丐与下丙丕丛 = 丗丟丁丐与下丙丕丛;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  new 丒丑下丙丅丂丁丈不.丗丛丘丑丐不丌丑丙(), method:  System.Boolean 丒丑下丙丅丂丁丈不.丗丛丘丑丐不丌丑丙::万上下上与丅专丑丗(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上)));
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 丅世业丂丝丁丌七丗(string 业丒丌东丈丏丈一不)
        {
            int val_4;
            string val_5 = 业丒丌东丈丏丈一不;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5 = 业丒丌东丈丏丈一不)) != false)
            {
                    return 0;
            }
            
            if((val_5.IndexOf(value:  "offer-", comparisonType:  4)) != 0)
            {
                    return this.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_5 = val_5.Replace(oldValue:  "offer-", newValue:  val_4 = System.String.alignConst));
            }
            
            return this.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_5);
        }
        public System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 东东丛一丄丅丌丗且()
        {
            return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐);
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 丐上丙世丂丅丝不丈()
        {
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.丙丈丈东丟丟丒丄三());
        }
        public System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 丙丈丈东丟丟丒丄三()
        {
            var val_3;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = 丒丑下丙丅丂丁丈不.<>c.<>9__15_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丒丑下丙丅丂丁丈不.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丒丑下丙丅丂丁丈不.<>c::丛丙丏世丌专丈丅丟(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丒丑下丙丅丂丁丈不.<>c.<>9__15_0 = val_5;
            return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1));
        }
        public bool 且丟丌丑丘丕七专三()
        {
            return System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.丙丈丈东丟丟丒丄三());
        }
        public void 且丛丕业丞万东七丒(bool 丆丄丘丂业丛七丁且 = False)
        {
            this.下丌下且三丏丂丐下(业丒丒专丞丒丘丌丗:  0);
        }
        public void 丁东丐丄丞丌丘业上()
        {
        
        }
        public void 丁丆丕丏东丟丐丄丂()
        {
            List.Enumerator<T> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_4:
            if((504287624 & 1) == 0)
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
            if(this.且丑不丛丏丏丐丄丐 != null)
            {
                    this.且丑不丛丏丏丐丄丐.Clear();
            }
            
            if(this.丂丁丒一丅丄丏丐丁 != null)
            {
                    this.丂丁丒一丅丄丏丐丁.Clear();
            }
            
            Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄 = new Progress.DailyTierProgress();
        }
        public void 丑七丂丌世与七丏与(string 丅业丙丞且丐一丙丆)
        {
            object val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丅业丙丞且丐一丙丆);
            object[] val_2 = new object[1];
            val_2[0] = 90;
            UnityEngine.Debug.LogErrorFormat(format:  "parse offers config fail: unknown format in \'{0}\'", args:  val_2);
            this.世丂上丌丞且丁七丏 = 0;
        }
        public void 丟一丏与丈丅丗丅丈()
        {
            bool val_2 = Progress.丆丆丐下万丙丄丆上.丑七不且上丗丁一世().丘七三丏丟丝下上东(丕上业丕丘上丘七一:  90, 丗丛丙丟一丒一与丈:  this.且丑不丛丏丏丐丄丐);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().上万丌东业且下丈丏(上丕丈丞丌丘丅不与:  Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄);
        }
        private void 下丌下且三丏丂丐下(System.Action 业丒丒专丞丒丘丌丗)
        {
            if(this.上丈丁丛丕丅丄丌丂 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.上丈丁丛丕丅丄丌丂);
            }
            
            this.上丈丁丛丕丅丄丌丂 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丝丙且不丒丂一丟丞(业丒丒专丞丒丘丌丗:  业丒丒专丞丒丘丌丗));
        }
        private System.Collections.IEnumerator 丝丙且不丒丂一丟丞(System.Action 业丒丒专丞丒丘丌丗)
        {
            丒丑下丙丅丂丁丈不.三丈丒丄丒丆丏一丘 val_1 = new 丒丑下丙丅丂丁丈不.三丈丒丄丒丆丏一丘();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .业丒丒专丞丒丘丌丗 = 业丒丒专丞丒丘丌丗;
            return (System.Collections.IEnumerator)val_1;
        }
        private string 不丌丁丙七专丁世不()
        {
            object val_11;
            System.Collections.Generic.List<System.Decimal> val_19;
            object val_20;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_3 = val_1.dateData.AddDays(value:  (double)-(System.Math.Max(val1:  1, val2:  this.世丂上丌丞且丁七丏.PaymentPeriod)));
            val_19 = this.丂丁丒一丅丄丏丐丁;
            if(val_19 == null)
            {
                    val_19 = System.Linq.Enumerable.ToList<System.Decimal>(source:  PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_3.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_1.dateData}));
                this.丂丁丒一丅丄丏丐丁 = val_19;
            }
            
            decimal val_7 = System.Linq.Enumerable.Sum(source:  val_19);
            Dictionary.Enumerator<TKey, TValue> val_8 = this.世丂上丌丞且丁七丏.PaymentConfig.GetEnumerator();
            goto label_16;
            label_17:
            ConfiguredValueTaskAwaiter val_12 = val_11.GetAwaiter();
            val_20 = val_12._value._obj.丐丏七丌丕丗业且上();
            if((val_20.IndexOf(value:  "-")) == 1)
            {
                    val_11 = 2147483647;
                val_20 = System.String.Format(format:  "{0}-{1}", arg0:  val_20, arg1:  val_11);
            }
            
            label_16:
            if((505054432 & 1) != 0)
            {
                goto label_17;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)val_12._value._obj.丐丏七丌丕丗业且上();
        }
        private System.Collections.Generic.List<Progress.DailyTierProgress.DailyTierOffersSettingKey> 丟丄丒七三七丅万业()
        {
            var val_26;
            var val_39;
            var val_40;
            string val_41;
            var val_42;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_44;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_46;
            int val_47;
            var val_48;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Collections.Generic.List<System.Int32>>, System.Collections.Generic.List<System.Int32>> val_51;
            var val_52;
            var val_53;
            System.Func<System.Int32, System.Single> val_54;
            val_39 = this;
            System.Collections.Generic.List<DailyTierOffersSettingKey> val_2 = new System.Collections.Generic.List<DailyTierOffersSettingKey>();
            val_40 = 1152921505505034240;
            Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄.TierKey = this.不丌丁丙七专丁世不();
            val_41 = mem[Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄 + 48];
            val_41 = Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄.TierKey;
            if((this.世丂上丌丞且丁七丏.PaymentConfig.ContainsKey(key:  val_41)) == false)
            {
                    return val_2;
            }
            
            val_42 = null;
            val_42 = null;
            val_44 = 丒丑下丙丅丂丁丈不.<>c.<>9__26_0;
            if(val_44 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_6 = null;
                val_44 = val_6;
                val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  丒丑下丙丅丂丁丈不.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丒丑下丙丅丂丁丈不.<>c::丐丒丌且世丑丈三丁(System.Collections.Generic.KeyValuePair<int, int> 丅三丄丕丁丘丘业三));
                val_42 = null;
                丒丑下丙丅丂丁丈不.<>c.<>9__26_0 = val_44;
            }
            
            val_42 = null;
            val_46 = 丒丑下丙丅丂丁丈不.<>c.<>9__26_1;
            if(val_46 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_7 = null;
                val_46 = val_7;
                val_7 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  丒丑下丙丅丂丁丈不.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丒丑下丙丅丂丁丈不.<>c::丗丂丂丅上万三丞与(System.Collections.Generic.KeyValuePair<int, int> 丅三丄丕丁丘丘业三));
                丒丑下丙丅丂丁丈不.<>c.<>9__26_1 = val_46;
            }
            
            .一丏丛一上世三七丙 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32, System.Int32>(source:  this.世丂上丌丞且丁七丏.PaymentConfig.Item[Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄.TierKey], keySelector:  val_6, elementSelector:  val_7);
            val_48 = null;
            val_48 = null;
            val_41 = 丒丑下丙丅丂丁丈不.<>c.<>9__26_2;
            if(val_41 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Collections.Generic.List<System.Int32>>, System.Int32> val_9 = null;
                val_41 = val_9;
                val_9 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Collections.Generic.List<System.Int32>>, System.Int32>(object:  丒丑下丙丅丂丁丈不.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丒丑下丙丅丂丁丈不.<>c::丈丞丈万三丗丄丒丑(System.Collections.Generic.KeyValuePair<int, System.Collections.Generic.List<int>> 丅丂且丞不丗丈与丝));
                val_48 = null;
                丒丑下丙丅丂丁丈不.<>c.<>9__26_2 = val_41;
            }
            
            val_48 = null;
            val_51 = 丒丑下丙丅丂丁丈不.<>c.<>9__26_3;
            if(val_51 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Collections.Generic.List<System.Int32>>, System.Collections.Generic.List<System.Int32>> val_10 = null;
                val_51 = val_10;
                val_10 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Collections.Generic.List<System.Int32>>, System.Collections.Generic.List<System.Int32>>(object:  丒丑下丙丅丂丁丈不.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.List<System.Int32> 丒丑下丙丅丂丁丈不.<>c::丏世丐丁万丆丈且下(System.Collections.Generic.KeyValuePair<int, System.Collections.Generic.List<int>> 丅丂且丞不丗丈与丝));
                丒丑下丙丅丂丁丈不.<>c.<>9__26_3 = val_51;
            }
            
            System.Collections.Generic.Dictionary<TKey, TElement> val_11 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Collections.Generic.List<System.Int32>>, System.Int32, System.Collections.Generic.List<System.Int32>>(source:  this.世丂上丌丞且丁七丏.TierConfig, keySelector:  val_9, elementSelector:  val_10);
            val_52 = 1152921530841808352;
            val_40 = 1152921505284374528;
            val_53 = 0;
            goto label_31;
            label_76:
            val_54 = (丒丑下丙丅丂丁丈不.丒丂万丒丂一上丞一)[1152921543766974160].丗三丝不且丏丒丟且;
            if(val_54 == null)
            {
                    System.Func<System.Int32, System.Single> val_14 = null;
                val_54 = val_14;
                val_14 = new System.Func<System.Int32, System.Single>(object:  new 丒丑下丙丅丂丁丈不.丒丂万丒丂一上丞一(), method:  System.Single 丒丑下丙丅丂丁丈不.丒丂万丒丂一上丞一::丄丑下丐丅万丅万七(int 三丟东丕丄丄下下丑));
                .丗三丝不且丏丒丟且 = val_54;
            }
            
            val_47 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<System.Int32>(丑东与丅丐丅丂丞业:  System.Linq.Enumerable.ToList<System.Int32>(source:  (丒丑下丙丅丂丁丈不.丒丂万丒丂一上丞一)[1152921543766974160].一丏丛一上世三七丙.Keys), 丆万丒下万下业且丑:  val_14);
            if((((val_11.ContainsKey(key:  val_47)) == false) || (val_11.Item[val_47] == null)) || ((System.Linq.Enumerable.Any<System.Int32>(source:  val_11.Item[val_47])) == false))
            {
                goto label_70;
            }
            
            int val_21 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<System.Int32>(丑东与丅丐丅丂丞业:  val_11.Item[val_47]);
            List.Enumerator<T> val_24 = System.Linq.Enumerable.ToList<System.Int32>(source:  val_11.Keys).GetEnumerator();
            label_56:
            if((505377392 & 1) == 0)
            {
                goto label_48;
            }
            
            int val_27 = val_26.丙东专丂世丈丏丁丂();
            bool val_29 = val_11.Item[val_27].Remove(item:  val_21);
            if(val_11.Item[val_27].Count != 0)
            {
                goto label_56;
            }
            
            bool val_32 = (丒丑下丙丅丂丁丈不.丒丂万丒丂一上丞一)[1152921543766974160].一丏丛一上世三七丙.Remove(key:  val_47);
            goto label_56;
            label_48:
            var val_38 = 0;
            val_38 = val_38 + 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_38 != 1)
            {
                    var val_40 = val_38;
                var val_39 = 0;
                val_39 = val_39 ^ (val_40 >> 31);
                val_40 = val_40 + val_39;
            }
            
            val_47 = this.世丂上丌丞且丁七丏.OffersConfig;
            if((val_47.ContainsKey(key:  val_21)) != false)
            {
                    DailyTierProgress.DailyTierOffersSettingKey val_37 = null;
                val_47 = val_37;
                val_37 = new DailyTierProgress.DailyTierOffersSettingKey(丗下一不丘丑丅业且:  val_21, 丞世不丒下上上丝丑:  UnityEngine.Random.Range(min:  0, max:  this.世丂上丌丞且丁七丏.OffersConfig.Item[val_21].Count));
                val_2.Add(item:  val_37);
            }
            
            label_70:
            val_53 = 1;
            label_31:
            if(val_53 < this.世丂上丌丞且丁七丏.Count)
            {
                goto label_76;
            }
            
            return val_2;
        }
        private Rilisoft.业丙丘丆东丈丕丂丄 丁与且丅丏下丌且与(Progress.DailyTierProgress.DailyTierOffersSettingKey 东丅丌丟丗丌世下丙)
        {
            object val_44;
            世丕三丙七丆丁丂丒 val_45;
            var val_46;
            int val_47;
            int val_48;
            int val_49;
            System.Collections.Generic.List<OfferCommonItemSetting> val_50;
            System.Collections.Generic.List<OfferCommonItemSetting> val_51;
            System.Collections.Generic.List<OfferCommonItemSetting> val_52;
            System.Collections.Generic.List<OfferWeaponSetting> val_53;
            var val_54;
            val_44 = 东丅丌丟丗丌世下丙;
            if(val_44 == null)
            {
                goto label_1;
            }
            
            if((this.世丂上丌丞且丁七丏.OffersConfig.ContainsKey(key:  val_44.Cost)) == false)
            {
                goto label_4;
            }
            
            val_45 = 1152921543766903824;
            if(this.世丂上丌丞且丁七丏.OffersConfig.Item[val_44.Cost].Count >= val_44.Index)
            {
                goto label_8;
            }
            
            label_4:
            object[] val_7 = new object[1];
            val_7[0] = val_44;
            UnityEngine.Debug.LogErrorFormat(format:  "tier offer create fail: invalid settingKey: \'{0}\'", args:  val_7);
            val_46 = 0;
            return (Rilisoft.业丙丘丆东丈丕丂丄)val_46;
            label_1:
            UnityEngine.Debug.LogError(message:  "tier offer create fail: nullable settingKey");
            val_46 = 0;
            return (Rilisoft.业丙丘丆东丈丕丂丄)val_46;
            label_8:
            string val_14 = System.String.Format(format:  "dt_{0}_{1}_{2}", arg0:  this.世丂上丌丞且丁七丏.SeasonId, arg1:  val_44.Raw, arg2:  Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄.GenerateIndex);
            if((ExperienceController.丞丞丘业东丙丏七丌() == 65) && (this.世丂上丌丞且丁七丏.LifeTimeForCapPlayers > 0))
            {
                    val_47 = this.世丂上丌丞且丁七丏.LifeTimeForCapPlayers;
            }
            else
            {
                    val_47 = this.世丂上丌丞且丁七丏.LifeTime;
            }
            
            val_44 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丈丒且丗七丗丄下丐(丗丟丁丐与下丙丕丛:  val_14);
            if(val_44 == null)
            {
                goto label_34;
            }
            
            if((val_17.FirstShowDate + val_47) <= Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛())
            {
                goto label_38;
            }
            
            goto label_39;
            label_34:
            Progress.OfferProgress val_21 = null;
            val_44 = val_21;
            val_21 = new Progress.OfferProgress();
            .Id = val_14;
            label_38:
            .FirstShowDate = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛() - 1;
            label_39:
            Rilisoft.七丈业与与不七丈丟 val_25 = new Rilisoft.七丈业与与不七丈丟();
            System.Type val_26 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_25 != null)
            {
                    .万丈丘丏丅世万丝丄 = val_26;
            }
            else
            {
                    mem[24] = val_26;
            }
            
            .下丄丈不与世丐业专 = val_14;
            七丈业与与不七丈丟.丏一丄丐专丟丂丟丏 val_27 = new 七丈业与与不七丈丟.丏一丄丐专丟丂丟丏();
            if(val_27 != null)
            {
                    .三丌丄丆下丑丛七不 = (Progress.OfferProgress)[1152921543767517728].FirstShowDate;
                val_48 = (Progress.OfferProgress)[1152921543767517728].FirstShowDate;
            }
            else
            {
                    mem[48] = (Progress.OfferProgress)[1152921543767517728].FirstShowDate;
                val_48 = (Progress.OfferProgress)[1152921543767517728].FirstShowDate;
            }
            
            .丗专丒丕丄下丘丁丛 = val_48 + val_47;
            .丁丑丅丐丌不世丁下 = val_27;
            七丈业与与不七丈丟.世丕三丙七丆丁丂丒 val_29 = null;
            val_45 = val_29;
            val_29 = new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒();
            丈丞丕丘丕丗与上一 val_30 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_11.Price, 丏丂不专上丘丂不丅:  "Real");
            if(val_45 != null)
            {
                    .丒丆丕丁丟业上七丅 = val_30;
                .业且东丒丕丕丛专丛 = val_11.Armor;
                .丈与丄丞丆丛丐专三 = val_11.Boots;
                .下丑东东且丞丏世下 = val_11.Cape;
                .丒丙丘丙丒不业丂丏 = val_11.Hat;
                .一丌丌丟丟丐世万丏 = val_11.Mask;
                .与丂三世丛丗且丘丛 = val_11.Glider;
                .丅丈一东东丑丆丟丛 = val_11.Transport;
                val_49 = val_11.Vip;
            }
            else
            {
                    mem[112] = val_30;
                mem[16] = val_11.Armor;
                mem[24] = val_11.Boots;
                .下丑东东且丞丏世下 = val_11.Cape;
                .丒丙丘丙丒不业丂丏 = val_11.Hat;
                mem[80] = val_11.Mask;
                mem[64] = val_11.Glider;
                .丅丈一东东丑丆丟丛 = val_11.Transport;
                val_49 = val_11.Vip;
            }
            
            .丅与丛丘丁丈业丆业 = val_49;
            val_50 = val_11.Gadgets;
            .丕丝丛七丂世不且丒 = PGCompany.上丕丐万下丙丆丄一.丈丐丘丄丄三世且丟(丈丕三丆丟且丆一上:  Rilisoft.Offers.丟丕丟丌三丏丘丄丒.丁丄丅丄丟东丐丑不(业丝丆不万丕下丒不:  val_50));
            val_51 = val_11.LobbyItems;
            .丁丞丘丏丘丐丟丒三 = PGCompany.上丕丐万下丙丆丄一.丗丁上专丟丑丙丒丕(与业不下丐一丕丒七:  Rilisoft.Offers.丟丕丟丌三丏丘丄丒.丁丄丅丄丟东丐丑不(业丝丆不万丕下丒不:  val_51));
            val_52 = val_11.Pets;
            .一丗丁且不丒丗丁且 = PGCompany.上丕丐万下丙丆丄一.丈丐丘丄丄三世且丟(丈丕三丆丟且丆一上:  Rilisoft.Offers.丟丕丟丌三丏丘丄丒.丁丄丅丄丟东丐丑不(业丝丆不万丕下丒不:  val_52));
            val_53 = val_11.Weapons;
            .丛一业丆下丒丏一丝 = PGCompany.上丕丐万下丙丆丄一.丈丐丘丄丄三世且丟(丈丕三丆丟且丆一上:  Rilisoft.Offers.丟丕丟丌三丏丘丄丒.丁丄丅丄丟东丐丑不(业丝丆不万丕下丒不:  val_53));
            .且东丌丏丐丝丕万业 = this.世丂上丌丞且丁七丏.OffersConfig.Item[val_44.Cost].Item[val_44.Index].OfferItems;
            if((this.世丂上丌丞且丁七丏.SalesAmount.ContainsKey(key:  val_11.Price)) != false)
            {
                    val_54 = this.世丂上丌丞且丁七丏.SalesAmount.Item[val_11.Price];
            }
            else
            {
                    val_54 = 0;
            }
            
            decimal val_42 = System.Decimal.op_Implicit(value:  0);
            .丂世丙丗丁丝丝丛业 = val_42;
            mem[1152921543767538360] = val_42.lo;
            mem[1152921543767538364] = val_42.mid;
            .丒上一丁丆丛东专丙 = val_45;
            Rilisoft.业丙丘丆东丈丕丂丄 val_43 = null;
            val_46 = val_43;
            val_43 = new Rilisoft.业丙丘丆东丈丕丂丄(丁丅丈丌丟世丗丗丟:  90, 一丐丗丁丞丆丅丟丄:  val_25, 上丕丈丞丌丘丅不与:  val_21, 丑丒丛与下专且丗不:  new System.Nullable<AdaptiveModuleType>() {HasValue = false}, 东一丁世丑丞业丄丐:  0);
            return (Rilisoft.业丙丘丆东丈丕丂丄)val_46;
        }
        private void 丁丒丟丈世且丆丂丒(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            if(丙业丞丑七丗下丟丌 == null)
            {
                    return;
            }
            
            if((this.且丑不丛丏丏丐丄丐.Contains(item:  丙业丞丑七丗下丟丌)) == false)
            {
                    return;
            }
            
            bool val_2 = this.且丑不丛丏丏丐丄丐.Remove(item:  丙业丞丑七丗下丟丌);
            if(this.且丑不丛丏丏丐丄丐.Count == 0)
            {
                    Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄.SelectedSettings = new System.Collections.Generic.List<DailyTierOffersSettingKey>();
            }
            
            this.下丌下且三丏丂丐下(业丒丒专丞丒丘丌丗:  0);
        }
        public void Dispose()
        {
            Rilisoft.业丙丘丆东丈丕丂丄.丐丅丕丑专万丌丈东(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.业丙丘丆东丈丕丂丄>(object:  this, method:  System.Void Rilisoft.Offers.丒丑下丙丅丂丁丈不::丁丒丟丈世且丆丂丒(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)));
            if(this.且丑不丛丏丏丐丄丐 == null)
            {
                goto label_3;
            }
            
            List.Enumerator<T> val_2 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_6:
            if((506308856 & 1) == 0)
            {
                goto label_4;
            }
            
            if(0.丐丏七丌丕丗业且上() == null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.且丑不丛丏丏丐丄丐.Clear();
            label_3:
            if(this.丂丁丒一丅丄丏丐丁 == null)
            {
                    return;
            }
            
            this.丂丁丒一丅丄丏丐丁.Clear();
        }
        private void 专下业与丑丛丁业下()
        {
            if(this.世丂上丌丞且丁七丏 == null)
            {
                    return;
            }
            
            Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄.SeasonId = this.世丂上丌丞且丁七丏.SeasonId;
        }
    
    }

}
