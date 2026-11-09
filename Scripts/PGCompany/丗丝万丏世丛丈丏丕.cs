using UnityEngine;

namespace PGCompany
{
    internal sealed class 丗丝万丏世丛丈丏丕
    {
        // Fields
        private static readonly PGCompany.丗丝万丏世丛丈丏丕 世丒丞七专三与万丕;
        private System.WeakReference 一丗丗不丞丟丌丂丘;
        private static System.Action<System.DateTime, System.Decimal> 上丆丒三三丑专与与;
        private static System.Action 东丙专丈丘丑七一丁;
        private decimal 三丁丝丐丝一丂世东;
        private System.Collections.Generic.Dictionary<System.DateTime, System.Decimal> 丘丏专丂丁丐丈丛丂;
        private System.Collections.Generic.List<System.Decimal> 丌丝丞丞丞丒下下丙;
        private Rilisoft.不丅且丝丁丁与不丒<PGCompany.ItemsPurchasesContainer> 丛丌丑下专丛业丝世;
        
        // Properties
        internal static PGCompany.丗丝万丏世丛丈丏丕 丆丕丝丒不丙且丐丗 { get; }
        private string 丛业丐丈三丏丘世丆 { get; }
        internal decimal 丅丈世丅丙专丝丅丗 { get; set; }
        
        // Methods
        private 丗丝万丏世丛丈丏丕()
        {
            null = null;
            this.三丁丝丐丝一丂世东 = System.Decimal.MinusOne;
            mem[1152921555889648912] = System.Decimal.Powers10.__il2cppRuntimeField_30;
            this.丘丏专丂丁丐丈丛丂 = new System.Collections.Generic.Dictionary<System.DateTime, System.Decimal>(capacity:  10);
            this.丌丝丞丞丞丒下下丙 = new System.Collections.Generic.List<System.Decimal>(capacity:  10);
            this.丛丌丑下专丛业丝世 = new Rilisoft.不丅且丝丁丁与不丒<PGCompany.ItemsPurchasesContainer>(丟东丟丑丕丄丂丟丙:  "player-purchases");
        }
        internal static PGCompany.丗丝万丏世丛丈丏丕 丑七不且上丗丁一世()
        {
            null = null;
            return (PGCompany.丗丝万丏世丛丈丏丕)PGCompany.丗丝万丏世丛丈丏丕.世丒丞七专三与万丕;
        }
        private string 三丄丈丞一专丝丛丛()
        {
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == true)
            {
                    return (string)(UnityEngine.Application.isEditor != true) ? ("Statistics.Dev.Purchases") : "Statistics.Purchases";
            }
            
            return (string)(UnityEngine.Application.isEditor != true) ? ("Statistics.Dev.Purchases") : "Statistics.Purchases";
        }
        internal static void 不七专丙丘丌七丗丂(System.Action<System.DateTime, System.Decimal> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.丗丝万丏世丛丈丏丕.上丆丒三三丑专与与, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丗丝万丏世丛丈丏丕.上丆丒三三丑专与与 != 1152921505630490632);
        
        }
        internal static void 丗世丑丏三丛丌一丂(System.Action<System.DateTime, System.Decimal> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.丗丝万丏世丛丈丏丕.上丆丒三三丑专与与, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丗丝万丏世丛丈丏丕.上丆丒三三丑专与与 != 1152921505630490632);
        
        }
        internal static void 丟丂丁专不世东丈丆(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.丗丝万丏世丛丈丏丕.东丙专丈丘丑七一丁, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丗丝万丏世丛丈丏丕.东丙专丈丘丑七一丁 != 1152921505630490640);
        
        }
        internal static void 丝专丁丘丛丝丄业七(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.丗丝万丏世丛丈丏丕.东丙专丈丘丑七一丁, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丗丝万丏世丛丈丏丕.东丙专丈丘丑七一丁 != 1152921505630490640);
        
        }
        internal decimal 丌丅业专丑专专万丑()
        {
            var val_6;
            System.Collections.Generic.IEnumerable<System.Decimal> val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = this.三丁丝丐丝一丂世东, hi = this.三丁丝丐丝一丂世东, lo = X21, mid = X21}, d2:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.MinusOne, lo = System.Decimal.Powers10.__il2cppRuntimeField_30>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_30>>32&0x0})) == false)
            {
                goto label_3;
            }
            
            System.DateTime val_2 = System.DateTime.UtcNow;
            System.Collections.Generic.List<System.Decimal> val_3 = this.专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_2.dateData});
            if((val_3 == null) || ((System.Linq.Enumerable.Any<System.Decimal>(source:  val_3)) == false))
            {
                goto label_7;
            }
            
            val_7 = val_3;
            val_8 = 0;
            decimal val_5 = System.Linq.Enumerable.Sum(source:  val_7);
            this.三丁丝丐丝一丂世东 = val_5;
            mem[1152921555890516096] = val_5.lo;
            mem[1152921555890516100] = val_5.mid;
            return new System.Decimal();
            label_3:
            val_7 = this.三丁丝丐丝一丂世东;
            return new System.Decimal();
            label_7:
            val_8 = 0;
            val_7 = 0;
            this.三丁丝丐丝一丂世东 = 0m;
            mem[1152921555890516096] = 0;
            return new System.Decimal();
        }
        private void 不丑专丛丏万下丙丈(decimal 丙业与丙丗丝不丈东)
        {
            this.三丁丝丐丝一丂世东 = 丙业与丙丗丝不丈东;
            mem[1152921555890632192] = 丙业与丙丗丝不丈东.lo;
            mem[1152921555890632196] = 丙业与丙丗丝不丈东.mid;
        }
        internal void 业丏丗丐丂业东丂丗(System.DateTime 下上丐丆丝丟丝丒不, decimal 丙业与丙丗丝不丈东)
        {
            System.Action<System.DateTime, System.Decimal> val_8;
            var val_9;
            var val_11;
            val_8 = this;
            val_9 = null;
            val_9 = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = 丙业与丙丗丝不丈东.flags, hi = 丙业与丙丗丝不丈东.hi, lo = 丙业与丙丗丝不丈东.lo, mid = 丙业与丙丗丝不丈东.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == true)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = this.丘丟丏丞丟世世丏丐();
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_2.set_Item(key:  丙业与丙丗丝不丈东.flags, value:  丙业与丙丗丝不丈东.lo);
            string val_4 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_2);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_4.三丄丈丞一专丝丛丛(), 下下丏一丙不丘丌丞:  val_4);
            decimal val_6 = this.丌丅业专丑专专万丑();
            decimal val_7 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, d2:  new System.Decimal() {flags = 丙业与丙丗丝不丈东.flags, hi = 丙业与丙丗丝不丈东.hi, lo = 丙业与丙丗丝不丈东.lo, mid = 丙业与丙丗丝不丈东.mid});
            this.三丁丝丐丝一丂世东 = val_7;
            mem[1152921555890762640] = val_7.lo;
            mem[1152921555890762644] = val_7.mid;
            val_11 = null;
            val_11 = null;
            if(PGCompany.丗丝万丏世丛丈丏丕.上丆丒三三丑专与与 != null)
            {
                    val_8 = PGCompany.丗丝万丏世丛丈丏丕.上丆丒三三丑专与与;
                val_8.Invoke(arg1:  new System.DateTime() {dateData = 下上丐丆丝丟丝丒不.dateData}, arg2:  new System.Decimal() {flags = 丙业与丙丗丝不丈东.flags, hi = 丙业与丙丗丝不丈东.hi, lo = 丙业与丙丗丝不丈东.lo, mid = 丙业与丙丗丝不丈东.mid});
                val_11 = null;
            }
            
            val_11 = null;
            if(PGCompany.丗丝万丏世丛丈丏丕.东丙专丈丘丑七一丁 != null)
            {
                    PGCompany.丗丝万丏世丛丈丏丕.东丙专丈丘丑七一丁.Invoke();
            }
            
            BalanceController.丙丏丂下丂上七不一();
        }
        internal void 业丏丗丐丂业东丂丗(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.DateTime, System.Decimal>> 丌业丗丛丄与与丄业)
        {
            TKey val_4;
            string val_12;
            var val_13;
            var val_15;
            var val_16;
            val_12 = 丌业丗丛丄与与丄业;
            val_13 = this;
            if(val_12 == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.丘丟丏丞丟世世丏丐();
            List.Enumerator<T> val_2 = val_12.GetEnumerator();
            label_8:
            if(((-255527584) & 1) == 0)
            {
                goto label_2;
            }
            
            GooglePlayGames.BasicApi.Nearby.EndpointDetails val_6 = val_4.RemoteEndpoint;
            string val_7 = val_4.丐丏七丌丕丗业且上();
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_1.set_Item(key:  val_4, value:  public System.Decimal System.Collections.Generic.KeyValuePair<System.DateTime, System.Decimal>::get_Value());
            goto label_8;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            string val_9 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1);
            val_12 = val_9.三丄丈丞一专丝丛丛();
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_12, 下下丏一丙不丘丌丞:  val_9);
            val_15 = null;
            val_15 = null;
            this.三丁丝丐丝一丂世东 = System.Decimal.MinusOne;
            mem[1152921555890939120] = System.Decimal.Powers10.__il2cppRuntimeField_30;
            val_13 = 1152921505630486528;
            val_16 = null;
            val_16 = null;
            if(PGCompany.丗丝万丏世丛丈丏丕.东丙专丈丘丑七一丁 != null)
            {
                    PGCompany.丗丝万丏世丛丈丏丕.东丙专丈丘丑七一丁.Invoke();
            }
            
            BalanceController.丙丏丂下丂上七不一();
        }
        internal void 丏丛不下一丝专丕丙()
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            this.一丗丗不丞丟丌丂丘 = new System.WeakReference(target:  val_1, trackResurrection:  false);
            string val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_3.三丄丈丞一专丝丛丛(), 下下丏一丙不丘丌丞:  val_3);
            PGCompany.ItemsPurchasesContainer val_5 = new PGCompany.ItemsPurchasesContainer();
            .Purchases = new System.Collections.Generic.List<PGCompany.ItemsPurchase>();
            val_7 = null;
            val_7 = null;
            this.三丁丝丐丝一丂世东 = System.Decimal.MinusOne;
            mem[1152921555891121728] = System.Decimal.Powers10.__il2cppRuntimeField_30;
        }
        internal Rilisoft.PlayerPaymentType 一与不丙丝万丐丂七()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            return (Rilisoft.PlayerPaymentType)this.一与不丙丝万丐丂七(世丘一东世丛丕丑七:  new System.DateTime() {}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_1.dateData}, 丏世万专丗丙上丐且:  Rilisoft.丗下丙丅且丐丞丙世.不丑不且七三丛丌丞());
        }
        internal Rilisoft.PlayerPaymentType 一与不丙丝万丐丂七(int 丏丄专业丞世丏丙丈)
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_3 = val_1.dateData.AddSeconds(value:  (double)-(System.Math.Max(val1:  0, val2:  丏丄专业丞世丏丙丈)));
            return (Rilisoft.PlayerPaymentType)this.一与不丙丝万丐丂七(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_3.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_1.dateData}, 丏世万专丗丙上丐且:  Rilisoft.丗下丙丅且丐丞丙世.不丑不且七三丛丌丞());
        }
        internal Rilisoft.PlayerPaymentType 一与不丙丝万丐丂七(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, PGCompany.DataObjects.IntInterval> 丏世万专丗丙上丐且)
        {
            var val_6;
            var val_7;
            var val_8;
            val_7 = 丏世万专丗丙上丐且;
            if(val_7 == null)
            {
                goto label_1;
            }
            
            decimal val_1 = this.丘丁丈万丗丑丈东七(世丘一东世丛丕丑七:  new System.DateTime() {dateData = 世丘一东世丛丕丑七.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = 丈丝世且万世丈丌万.dateData});
            Dictionary.Enumerator<TKey, TValue> val_2 = val_7.GetEnumerator();
            val_6 = 1152921543257624688;
            label_4:
            if(((-254943400) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            val_7;
            if((val_3._value._obj.上丗不丘上丘丕丟丞(下下丏一丙不丘丌丞:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid})) == false)
            {
                goto label_4;
            }
            
            val_8 = val_3._value._obj.丙东专丂世丈丏丁丂();
            goto label_5;
            label_2:
            val_8 = 0;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (Rilisoft.PlayerPaymentType)val_8;
            label_1:
            val_8 = 0;
            return (Rilisoft.PlayerPaymentType)val_8;
        }
        internal Rilisoft.PlayerPaymentType 丅丏丘丅丕丌丛世不(int 丏丄专业丞世丏丙丈, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, PGCompany.DataObjects.IntInterval> 丏世万专丗丙上丐且)
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_3 = val_1.dateData.AddSeconds(value:  (double)-(System.Math.Max(val1:  0, val2:  丏丄专业丞世丏丙丈)));
            return (Rilisoft.PlayerPaymentType)this.丅丏丘丅丕丌丛世不(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_3.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_1.dateData}, 丏世万专丗丙上丐且:  丏世万专丗丙上丐且);
        }
        internal Rilisoft.PlayerPaymentType 丅丏丘丅丕丌丛世不(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万, System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, PGCompany.DataObjects.IntInterval> 丏世万专丗丙上丐且)
        {
            var val_8;
            var val_9;
            var val_10;
            val_9 = 丏世万专丗丙上丐且;
            System.Collections.Generic.List<System.Decimal> val_1 = this.专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = 世丘一东世丛丕丑七.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = 丈丝世且万世丈丌万.dateData});
            int val_2 = val_1.Count;
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            decimal val_3 = val_2.丗丅丑丑丅丐下丞一(一丛丂丘丝业且丞三:  val_1);
            Dictionary.Enumerator<TKey, TValue> val_4 = val_9.GetEnumerator();
            val_8 = 1152921543257624688;
            label_6:
            if(((-254690728) & 1) == 0)
            {
                goto label_4;
            }
            
            ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
            val_9;
            if((val_5._value._obj.上丗不丘上丘丕丟丞(下下丏一丙不丘丌丞:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid})) == false)
            {
                goto label_6;
            }
            
            val_10 = val_5._value._obj.丙东专丂世丈丏丁丂();
            goto label_7;
            label_4:
            val_10 = 0;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (Rilisoft.PlayerPaymentType)val_10;
            label_2:
            val_10 = 0;
            return (Rilisoft.PlayerPaymentType)val_10;
        }
        internal decimal 与丐丒与丁丄专丆丙()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.Collections.Generic.List<System.Decimal> val_2 = this.专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_1.dateData});
            decimal val_3 = val_2.丗丅丑丑丅丐下丞一(一丛丂丘丝业且丞三:  val_2);
            return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
        }
        internal decimal 一丆专丅世丅丈丙丗(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万)
        {
            System.Collections.Generic.List<System.Decimal> val_1 = this.专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = 世丘一东世丛丕丑七.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = 丈丝世且万世丈丌万.dateData});
            return val_1.丗丅丑丑丅丐下丞一(一丛丂丘丝业且丞三:  val_1);
        }
        private decimal 丗丅丑丑丅丐下丞一(System.Collections.Generic.List<System.Decimal> 一丛丂丘丝业且丞三)
        {
            int val_18;
            int val_19;
            var val_20;
            int val_21;
            int val_22;
            val_18 = 一丛丂丘丝业且丞三;
            if(val_18 != null)
            {
                    val_18.Sort();
            }
            else
            {
                    0.Sort();
            }
            
            if(val_18.Count == 0)
            {
                goto label_3;
            }
            
            val_19 = val_18.Count;
            int val_3 = val_18.Count;
            if((val_19 & 1) != 0)
            {
                goto label_6;
            }
            
            int val_4 = val_3 - 1;
            decimal val_7 = val_18.Item[((val_4 < 0) ? (val_3) : (val_4)) >> 1];
            val_19 = val_7.lo;
            if(val_18 == null)
            {
                goto label_8;
            }
            
            val_20 = val_18.Count;
            goto label_9;
            label_3:
            val_21 = 0;
            val_22 = 0;
            return new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid};
            label_6:
            float val_18 = (float)val_3 - 1;
            val_18 = val_18 * 0.5f;
            val_22 = val_18;
            val_21 = UnityEngine.Mathf.CeilToInt(f:  val_18);
            decimal val_11 = val_22.Item[val_21];
            return new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid};
            label_8:
            val_20 = 0.Count;
            label_9:
            decimal val_15 = val_18.Item[((val_20 < 0) ? (val_20 + 1) : (val_20)) >> 1];
            decimal val_16 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_19, mid = val_7.mid}, d2:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.mid});
            val_18 = val_16.flags;
            val_22 = val_18;
            val_21 = val_16.lo;
            decimal val_17 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_22, hi = val_16.hi, lo = val_21, mid = val_16.mid}, d2:  new System.Decimal());
            return new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid};
        }
        internal decimal 三业且丁丌丂一七丌()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            decimal val_2 = this.世丅丘丈三且三丘万(世丘一东世丛丕丑七:  new System.DateTime() {}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_1.dateData});
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        internal decimal 世丅丘丈三且三丘万(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万)
        {
            var val_3;
            int val_11;
            int val_12;
            int val_13;
            int val_14;
            int val_15;
            var val_16;
            val_11 = this.专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = 世丘一东世丛丕丑七.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = 丈丝世且万世丈丌万.dateData});
            List.Enumerator<T> val_2 = val_11.GetEnumerator();
            val_12 = 0;
            val_13 = 0;
            goto label_2;
            label_5:
            ConfiguredValueTaskAwaiter val_5 = val_3.GetAwaiter();
            decimal val_6 = System.Decimal.op_Addition(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_5._value._obj, hi = val_5._value._obj, lo = val_5._value._token, mid = val_5._value._token});
            val_12 = val_6.flags;
            val_13 = val_6.lo;
            label_2:
            if(((-254087728) & 1) != 0)
            {
                goto label_5;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_11.Count > 0)
            {
                    val_11 = val_11.Count;
                decimal val_9 = System.Decimal.op_Implicit(value:  val_11);
                val_14 = val_12;
                val_15 = val_13;
                decimal val_10 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_14, hi = val_6.hi, lo = val_15, mid = val_6.mid}, d2:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid});
                return new System.Decimal() {flags = val_14, hi = val_14, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0};
            }
            
            val_16 = null;
            val_16 = null;
            val_14 = System.Decimal.Zero;
            return new System.Decimal() {flags = val_14, hi = val_14, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0};
        }
        internal decimal 不上丆丅丕丂专丘业()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            decimal val_2 = this.丘丁丈万丗丑丈东七(世丘一东世丛丕丑七:  new System.DateTime() {}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_1.dateData});
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        internal decimal 丘丁丈万丗丑丈东七(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万)
        {
            var val_3;
            int val_8;
            var val_9;
            var val_10;
            val_8 = this;
            System.Collections.Generic.List<System.Decimal> val_1 = this.专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = 世丘一东世丛丕丑七.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = 丈丝世且万世丈丌万.dateData});
            if(val_1 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_2 = val_1.GetEnumerator();
            val_9 = 0;
            val_10 = 0;
            goto label_2;
            label_5:
            ConfiguredValueTaskAwaiter val_5 = val_3.GetAwaiter();
            val_8 = val_5._value._obj;
            decimal val_6 = System.Decimal.op_Addition(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_8, hi = val_8, lo = val_5._value._token, mid = val_5._value._token});
            val_9 = val_6.flags;
            val_10 = val_6.lo;
            label_2:
            if(((-253855536) & 1) != 0)
            {
                goto label_5;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return new System.Decimal();
            label_1:
            val_9 = 0;
            val_10 = 0;
            return new System.Decimal();
        }
        internal decimal 丕丝丌七丗丘丛丌业()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            decimal val_2 = this.一丄丄七丅世丘丆丒(世丘一东世丛丕丑七:  new System.DateTime() {}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_1.dateData});
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        internal decimal 一丄丄七丅世丘丆丒(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万)
        {
            var val_3;
            int val_10;
            var val_11;
            var val_12;
            val_10 = this;
            System.Collections.Generic.List<System.Decimal> val_1 = this.专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = 世丘一东世丛丕丑七.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = 丈丝世且万世丈丌万.dateData});
            if(val_1 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_2 = val_1.GetEnumerator();
            val_11 = 0;
            val_12 = 0;
            goto label_2;
            label_5:
            ConfiguredValueTaskAwaiter val_5 = val_3.GetAwaiter();
            val_10 = val_5._value._token;
            bool val_6 = System.Decimal.op_LessThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_5._value._obj, hi = val_5._value._obj, lo = val_10, mid = val_10});
            var val_7 = (val_6 != true) ? val_5._value._obj : (val_11);
            var val_8 = (val_6 != true) ? (val_10) : (val_12);
            label_2:
            if(((-253623344) & 1) != 0)
            {
                goto label_5;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return new System.Decimal();
            label_1:
            val_11 = 0;
            val_12 = 0;
            return new System.Decimal();
        }
        internal int 丒丐丈丌丑丝丌丙专()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.丘丟丏丞丟世世丏丐();
            if(val_1 == null)
            {
                    return (int)val_1;
            }
            
            return val_1.Count;
        }
        internal System.Collections.Generic.Dictionary<System.DateTime, System.Decimal> 一丑丛上一丏丟丛丕(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万)
        {
            var val_5;
            System.Collections.Generic.Dictionary<System.DateTime, System.Decimal> val_14;
            var val_15;
            System.StringComparer val_2 = System.StringComparer.Ordinal;
            val_14 = this.丘丏专丂丁丐丈丛丂;
            val_14.Clear();
            Dictionary.Enumerator<TKey, TValue> val_3 = this.丘丟丏丞丟世世丏丐().GetEnumerator();
            label_31:
            if(((-253360464) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_5.GetAwaiter();
            if((((System.DateTime.TryParse(s:  val_7._value._obj.丐丏七丌丕丗业且上(), result: out  new System.DateTime())) == false) || ((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = 世丘一东世丛丕丑七.dateData}, t2:  new System.DateTime())) == true)) || ((System.DateTime.op_GreaterThan(t1:  new System.DateTime(), t2:  new System.DateTime() {dateData = 丈丝世且万世丈丌万.dateData})) == true))
            {
                goto label_31;
            }
            
            decimal val_12 = System.Convert.ToDecimal(value:  val_7._value._obj);
            val_15 = null;
            val_15 = null;
            if((System.Decimal.op_Inequality(d1:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
            {
                goto label_31;
            }
            
            this.丘丏专丂丁丐丈丛丂.Add(key:  new System.DateTime(), value:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid});
            goto label_31;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.Dictionary<System.DateTime, System.Decimal>)this.丘丏专丂丁丐丈丛丂;
        }
        internal System.Collections.Generic.List<System.Decimal> 专不丂业丅丄万丝丈(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万)
        {
            this.丌丝丞丞丞丒下下丙.Clear();
            this.丌丝丞丞丞丒下下丙.AddRange(collection:  this.一丑丛上一丏丟丛丕(世丘一东世丛丕丑七:  new System.DateTime() {dateData = 世丘一东世丛丕丑七.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = 丈丝世且万世丈丌万.dateData}).Values);
            return (System.Collections.Generic.List<System.Decimal>)this.丌丝丞丞丞丒下下丙;
        }
        private System.Collections.Generic.Dictionary<string, object> 丘丟丏丞丟世世丏丐()
        {
            System.WeakReference val_7;
            object val_8;
            val_7 = this;
            if(((this.一丗丗不丞丟丌丂丘 != null) && ((this.一丗丗不丞丟丌丂丘 & 1) != 0)) && (this.一丗丗不丞丟丌丂丘 != null))
            {
                    val_7 = this.一丗丗不丞丟丌丂丘;
                val_8 = 0;
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_8;
            }
            
            val_8 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this.一丗丗不丞丟丌丂丘.三丄丈丞一专丝丛丛()));
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = null;
            val_8 = val_4;
            val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(this.一丗丗不丞丟丌丂丘 != null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_8;
            }
            
            this.一丗丗不丞丟丌丂丘 = new System.WeakReference(target:  val_4, trackResurrection:  false);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_8;
        }
        internal void 丅丅丙丝丆丏丐与丞(System.DateTime 下上丐丆丝丟丝丒不, int 世丈三丐丞一丒丛不, System.Collections.Generic.ICollection<string> 丈丕三丆丟且丆一上)
        {
            var val_12;
            var val_16;
            var val_17;
            if(this.丛丌丑下专丛业丝世 == null)
            {
                    val_12 = new PGCompany.ItemsPurchasesContainer();
            }
            
            if(null == null)
            {
                    mem2[0] = new System.Collections.Generic.List<PGCompany.ItemsPurchase>();
            }
            
            long val_3 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = 下上丐丆丝丟丝丒不.dateData});
            System.Collections.Generic.List<Rilisoft.CuttedOfferItem> val_4 = new System.Collections.Generic.List<Rilisoft.CuttedOfferItem>();
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = 丈丕三丆丟且丆一上.GetEnumerator();
            label_35:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_21;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            Rilisoft.CuttedOfferItem val_11 = Rilisoft.CuttedOfferItem.东丝七业丄丑丒世七(丞丕丒专一下丙业上:  val_6.Current);
            if(val_11 == null)
            {
                goto label_35;
            }
            
            val_4.Add(item:  val_11);
            object[] val_12 = new object[1];
            val_12[0] = val_11;
            UnityEngine.Debug.LogFormat(format:  ">>> Add item purchase info: for \'{0}\'", args:  val_12);
            goto label_35;
            label_21:
            val_16 = 0;
            val_17 = 0;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_6.Dispose();
            }
            
            PGCompany.ItemsPurchase val_14 = new PGCompany.ItemsPurchase();
            if(val_14 != null)
            {
                    .Date = val_3;
                .Real = 世丈三丐丞一丒丛不;
            }
            else
            {
                    mem[16] = val_3;
                .Real = 世丈三丐丞一丒丛不;
            }
            
            .Items = val_4;
            this.丛丌丑下专丛业丝世.Add(item:  val_14);
            this.丛丌丑下专丛业丝世.丂且不业丂专丛丆东();
        }
        internal System.Collections.Generic.List<Rilisoft.CuttedOfferItem> 与七丈丄一丂丁世上(System.DateTime 世丘一东世丛丕丑七, System.DateTime 丈丝世且万世丈丌万)
        {
            ulong val_8;
            Rilisoft.不丅且丝丁丁与不丒<PGCompany.ItemsPurchasesContainer> val_9;
            var val_10;
            System.Collections.Generic.List<Rilisoft.CuttedOfferItem> val_11;
            var val_12;
            val_8 = 丈丝世且万世丈丌万.dateData;
            System.Collections.Generic.List<Rilisoft.CuttedOfferItem> val_3 = new System.Collections.Generic.List<Rilisoft.CuttedOfferItem>();
            val_9 = this.丛丌丑下专丛业丝世;
            if(val_9 == null)
            {
                    return val_3;
            }
            
            val_9 = this.丛丌丑下专丛业丝世;
            if(null == null)
            {
                    return val_3;
            }
            
            val_8 = 1152921555893803936;
            val_9 = 0;
            goto label_8;
            label_25:
            val_10 = val_9;
            PGCompany.ItemsPurchase val_4 = this.丛丌丑下专丛业丝世.Item[0];
            val_11 = val_4.Items;
            if(((val_11 == null) || (val_4.Date < (专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = 世丘一东世丛丕丑七.dateData})))) || (val_4.Date > (专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_8}))))
            {
                goto label_15;
            }
            
            val_12 = 0;
            goto label_16;
            label_21:
            Rilisoft.CuttedOfferItem val_5 = val_4.Items.Item[0];
            if(val_5 != null)
            {
                    val_3.Add(item:  val_5);
            }
            
            val_11 = val_4.Items;
            val_12 = 1;
            label_16:
            val_10 = public System.Int32 System.Collections.Generic.List<Rilisoft.CuttedOfferItem>::get_Count();
            if(val_12 < val_11.Count)
            {
                goto label_21;
            }
            
            label_15:
            val_9 = 1;
            label_8:
            if(val_9 < this.丛丌丑下专丛业丝世.Count)
            {
                goto label_25;
            }
            
            return val_3;
        }
        private static 丗丝万丏世丛丈丏丕()
        {
            PGCompany.丗丝万丏世丛丈丏丕.世丒丞七专三与万丕 = new PGCompany.丗丝万丏世丛丈丏丕();
        }
    
    }

}
