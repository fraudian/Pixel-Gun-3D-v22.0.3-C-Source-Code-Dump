using UnityEngine;

namespace PGCompany
{
    internal class 丕下丆丑万世业丈丟 : 丅丄不丛东丝一七丞
    {
        // Fields
        private CategoryNames <丄上丞不三与一丅丒>k__BackingField;
        private PGCompany.丑丝丟与丘丐丏上三 丁丘丄丕下专东七不;
        private static System.Collections.Generic.List<bool> 下丛业东丂上业丕丛;
        
        // Properties
        internal CategoryNames 七丌丌丏丗东丕且丅 { get; set; }
        internal PGCompany.丑丝丟与丘丐丏上三 丞丑且东丌与丏丏丁 { get; }
        internal PGCompany.EggRarity 丄世丂专丝丌上上下 { get; }
        internal bool 丒丆丁丘丈丏丆丌丘 { get; }
        internal PGCompany.EggIncubatorProgress 丞丁丒丟丑丙丈七且 { get; }
        internal PGCompany.三东丏不丗世丅丌丄 丑与丆丅丗丅丟上丂 { get; }
        internal int 丘七丕业世丅丁丆上 { get; }
        internal int 丙丄丘丌丕丆丒七丅 { get; }
        internal PGCompany.三东丏不丗世丅丌丄 丌丞丈丑丕不且丒丌 { get; }
        internal System.Collections.Generic.List<丑丛丗丗丕不丘三丆> 丁丘丏三丙上专丕丗 { get; }
        internal int 与东专丐丗且丂七丗 { get; }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丂世不丁下万业专丕 { get; }
        internal PGCompany.专丛且丌丒丘业专万 上下丅丈丈下业专上 { get; }
        internal PGCompany.专丛且丌丒丘业专万 下丑不七丈丝丌丛与 { get; }
        
        // Methods
        public 丕下丆丑万世业丈丟(PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  80, 丞丅上丏丂且下丅与:  三万万丒丏丒不丐丙.DataId);
            .不丌七丆丏丂丐万丂 = 三万万丒丏丒不丐丙.Id;
            this.<丄上丞不三与一丅丒>k__BackingField = 30000;
        }
        public 丕下丆丑万世业丈丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.<丄上丞不三与一丅丒>k__BackingField = 30000;
        }
        internal CategoryNames 丒万丕七专不丏丞丌()
        {
            return (CategoryNames)this.<丄上丞不三与一丅丒>k__BackingField;
        }
        private void 与丘丑丒丅丕丞七丈(CategoryNames 丙业与丙丗丝不丈东)
        {
            this.<丄上丞不三与一丅丒>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.丑丝丟与丘丐丏上三 丁专丗万三上丟三丆()
        {
            if(this.丁丘丄丕下专东七不 != null)
            {
                    return val_3;
            }
            
            PGCompany.丑丝丟与丘丐丏上三 val_3 = PGCompany.专一丄丆丈专丆丕丟.丙丕丞且丕不丘丙丑().Item[this.业上丙丞丐丄丆丅七()];
            this.丁丘丄丕下专东七不 = val_3;
            return val_3;
        }
        internal PGCompany.EggRarity 丞世下丙丌丙三东丁()
        {
            if(PGCompany.专一丄丆丈专丆丕丟.丙丕丞且丕不丘丙丑().Item[this.丁专丗万三上丟三丆().业上丙丞丐丄丆丅七()] != null)
            {
                    return (PGCompany.EggRarity)val_4.丝丗东与不丂业专丛;
            }
            
            return (PGCompany.EggRarity)val_4.丝丗东与不丂业专丛;
        }
        internal override string 七业丑不七丐业丟丂()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丁专丗万三上丟三丆().丄丁下丑丛丗丁不丛());
        }
        internal override string 东且丏丆万与东丙万()
        {
            return (string)System.String.alignConst;
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  48, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        }
        internal override bool 丞丟丑丆丁丟丁丒万()
        {
            System.Collections.Generic.Dictionary<System.String, PGCompany.丑丝丟与丘丐丏上三> val_1 = PGCompany.专一丄丆丈专丆丕丟.丙丕丞且丕不丘丙丑();
            if(val_1 != null)
            {
                    return val_1.ContainsKey(key:  this.业上丙丞丐丄丆丅七());
            }
            
            return val_1.ContainsKey(key:  this.业上丙丞丐丄丆丅七());
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/egg");
        }
        internal override bool 七丄与不丁丙丑丞不()
        {
            return false;
        }
        internal bool 七丄业丅专上丌丅丙()
        {
            Rilisoft.EggsManager val_1 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance;
            if(val_1 != null)
            {
                    return val_1.丒丆丁丘丈丏丆丌丘(世丕丘丈丙世业东丕:  this);
            }
            
            return val_1.丒丆丁丘丈丏丆丌丘(世丕丘丈丙世业东丕:  this);
        }
        internal PGCompany.EggIncubatorProgress 三七世丌专丆与丄世()
        {
            return (PGCompany.EggIncubatorProgress)Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  this.丅丙丛丑丌丆丌丕丒().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
        }
        internal PGCompany.三东丏不丗世丅丌丄 丈下丂丆不丕丐丌丂()
        {
            var val_16;
            var val_17;
            float val_18;
            bool val_7 = false;
            if(this.丅丙丛丑丌丆丌丕丒() <= 0)
            {
                goto label_7;
            }
            
            if((System.String.op_Equality(a:  this.业上丙丞丐丄丆丅七(), b:  "egg_Training")) != false)
            {
                    val_16 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  247);
                val_17 = 0;
                return (PGCompany.三东丏不丗世丅丌丄)val_16.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  100);
            }
            
            if(val_7 == 0)
            {
                goto label_7;
            }
            
            int val_9 = this.丂丞东与专丂丅丁丏();
            if(val_9 <= 0)
            {
                goto label_7;
            }
            
            if((BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  this.业上丙丞丐丄丆丅七())) == null)
            {
                goto label_10;
            }
            
            val_18 = (float)val_11.丞与丏万业丙丒丝丙;
            goto label_11;
            label_7:
            val_16 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  247);
            val_17 = 100;
            return (PGCompany.三东丏不丗世丅丌丄)val_16.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  100);
            label_10:
            val_18 = 100f;
            label_11:
            float val_16 = (float)Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丁业丐丐丆一丙丕丙(上丕丈丞丌丘丅不与:  this.三七世丌专丆与丄世(), 丕且七业丙万丕丛丞: out  val_7);
            val_16 = val_16 / (float)val_9;
            val_18 = val_16 * val_18;
            int val_14 = UnityEngine.Mathf.Max(a:  (int)val_18, b:  1);
            if((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  247)) != null)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_16.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  100);
            }
            
            return (PGCompany.三东丏不丗世丅丌丄)val_16.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  100);
        }
        internal int 丂丞东与专丂丅丁丏()
        {
            var val_3;
            if((BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  this.业上丙丞丐丄丆丅七())) != null)
            {
                    val_3 = val_2.与丐丄丑上丌丑丅丘 * 60;
                return 86400;
            }
            
            val_3 = 65536;
            val_3 = 1;
            return 86400;
        }
        internal int 丛与丏丏七丟与世专()
        {
            Rilisoft.EggsManager val_1 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance;
            if(val_1 != null)
            {
                    return val_1.丁业丐丐丆一丙丕丙(上丕丈丞丌丘丅不与:  this.三七世丌专丆与丄世());
            }
            
            return val_1.丁业丐丐丆一丙丕丙(上丕丈丞丌丘丅不与:  this.三七世丌专丆与丄世());
        }
        internal PGCompany.三东丏不丗世丅丌丄 三丌世丕下丌业丕一()
        {
            var val_4;
            if((BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  this.业上丙丞丐丄丆丅七())) != null)
            {
                    val_4 = val_2.专上丛丒三三三丄丘;
            }
            else
            {
                    val_4 = 100;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_3 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  223);
            if(val_3 != null)
            {
                    return val_3.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  100);
            }
            
            return val_3.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  100);
        }
        internal System.Collections.Generic.List<丑丛丗丗丕不丘三丆> 丏丙万丄丛东丗丄丏()
        {
            System.Collections.Generic.List<丑丛丗丗丕不丘三丆> val_4;
            if((BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  this.业上丙丞丐丄丆丅七())) != null)
            {
                    val_4 = val_2.丂丅丘丕一世丐丑丆;
                if(val_4 != null)
            {
                    return (System.Collections.Generic.List<丑丛丗丗丕不丘三丆>)val_4;
            }
            
            }
            
            System.Collections.Generic.List<丑丛丗丗丕不丘三丆> val_3 = null;
            val_4 = val_3;
            val_3 = new System.Collections.Generic.List<丑丛丗丗丕不丘三丆>();
            return (System.Collections.Generic.List<丑丛丗丗丕不丘三丆>)val_4;
        }
        internal int 丆丛丆专丘一世丗丞()
        {
            string val_7 = this.业上丙丞丐丄丆丅七();
            if((BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  val_7 = this.业上丙丞丐丄丆丅七())) == null)
            {
                    return 60;
            }
            
            val_7 = ???;
            return 60;
        }
        internal void 丞丝下丄丆且丌丈丐()
        {
            if(this.丅丙丛丑丌丆丌丕丒() < 1)
            {
                    return;
            }
            
            Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丞丝下丄丆且丌丈丐(世丕丘丈丙世业东丕:  this);
        }
        internal PGCompany.上丕一与丕丏丟丂东 业专丌业七丐丞一专(PGCompany.丝不丅丗丄丄与丌丘 世不丈万丛世且下三)
        {
            PGCompany.丟丌专丘下丘七丈东 val_5;
            var val_6;
            val_5 = 世不丈万丛世且下三.丌万丑丟上七丐丐丕;
            if(this.丅丙丛丑丌丆丌丕丒() >= 1)
            {
                    val_5 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.业专丌业七丐丞一专(世丕丘丈丙世业东丕:  this, 世不丈万丛世且下三:  new PGCompany.丝不丅丗丄丄与丌丘() {丌万丑丟上七丐丐丕 = val_5, 专丈丟上丈丁丛七丒 = 世不丈万丛世且下三.专丈丟上丈丁丛七丒});
                PGCompany.上丕一与丕丏丟丂东 val_4 = null;
                val_6 = val_4;
                val_4 = new PGCompany.上丕一与丕丏丟丂东(世丕丘丈丙世业东丕:  this, 丂业七丕丗世上东下:  val_5);
                return (PGCompany.上丕一与丕丏丟丂东)val_6;
            }
            
            val_6 = 0;
            return (PGCompany.上丕一与丕丏丟丂东)val_6;
        }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丗三与丁丝万三丄业()
        {
            var val_12;
            var val_15;
            System.Collections.Generic.List<丑丛丗丗丕不丘三丆> val_21;
            var val_22;
            var val_23;
            var val_24;
            System.Collections.Generic.List<System.Boolean> val_25;
            var val_26;
            var val_27;
            PGCompany.丕下丆丑万世业丈丟.丒丐丌丈丘东丂丘丌();
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            if((BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  this.业上丙丞丐丄丆丅七())) == null)
            {
                goto label_5;
            }
            
            val_21 = val_3.丂丅丘丕一世丐丑丆;
            if(val_21 != null)
            {
                goto label_6;
            }
            
            label_5:
            System.Collections.Generic.List<丑丛丗丗丕不丘三丆> val_4 = null;
            val_21 = val_4;
            val_4 = new System.Collections.Generic.List<丑丛丗丗丕不丘三丆>();
            label_6:
            val_22 = 0;
            val_23 = 0;
            goto label_7;
            label_42:
            val_24 = null;
            val_24 = null;
            val_25 = PGCompany.丕下丆丑万世业丈丟.下丛业东丂上业丕丛;
            丑丛丗丗丕不丘三丆 val_5 = val_4.Item[0];
            if(val_25.Item[val_5.丈下丑丆上丏丗丈专] == true)
            {
                goto label_39;
            }
            
            val_26 = null;
            val_26 = null;
            丑丛丗丗丕不丘三丆 val_7 = val_4.Item[0];
            PGCompany.丕下丆丑万世业丈丟.下丛业东丂上业丕丛.set_Item(index:  val_7.丈下丑丆上丏丗丈专, value:  true);
            val_25 = 丟下七丘下下丙丗丅.一三专丞丒丅上业上();
            Dictionary.Enumerator<TKey, TValue> val_9 = val_25.GetEnumerator();
            do
            {
                label_28:
                if(((-534178592) & 1) == 0)
            {
                goto label_29;
            }
            
                ConfiguredValueTaskAwaiter val_13 = val_12.GetAwaiter();
                丑丛丗丗丕不丘三丆 val_14 = val_4.Item[0];
            }
            while(val_14.丈下丑丆上丏丗丈专 != val_15);
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  80, 丞丅上丏丂且下丅与:  val_13._value._obj.丐丏七丌丕丗业且上());
            val_1.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
            goto label_28;
            label_29:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(1 != 1)
            {
                    var val_20 = 0;
                val_20 = val_20 ^ 0;
                val_23 = 1 + val_20;
            }
            else
            {
                    val_23 = 0;
            }
            
            label_39:
            val_22 = 1;
            label_7:
            if(val_22 < val_4.Count)
            {
                goto label_42;
            }
            
            val_27 = null;
            val_27 = null;
            if((丕下丆丑万世业丈丟.<>c.<>9__36_0) == null)
            {
                goto label_45;
            }
            
            label_50:
            val_1.Sort(comparison:  丕下丆丑万世业丈丟.<>c.<>9__36_0);
            return val_1;
            label_45:
            丕下丆丑万世业丈丟.<>c.<>9__36_0 = new System.Comparison<PGCompany.三东丏不丗世丅丌丄>(object:  丕下丆丑万世业丈丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丕下丆丑万世业丈丟.<>c::七与与三丆丝世丁丗(PGCompany.三东丏不丗世丅丌丄 丛三七丟丗与专丙丂, PGCompany.三东丏不丗世丅丌丄 三丂丑丁丞丞丅东三));
            if(val_1 != null)
            {
                goto label_50;
            }
            
            goto label_50;
        }
        private static void 丒丐丌丈丘东丂丘丌()
        {
            var val_3;
            System.Collections.Generic.List<System.Boolean> val_4;
            int val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            PGCompany.丕下丆丑万世业丈丟.下丛业东丂上业丕丛.Clear();
            val_4 = System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_5 = val_2.Length;
            if(val_5 < 1)
            {
                    return;
            }
            
            do
            {
                val_6 = null;
                val_6 = null;
                val_4 = PGCompany.丕下丆丑万世业丈丟.下丛业东丂上业丕丛;
                val_4.Add(item:  false);
                val_5 = val_5 - 1;
            }
            while(val_5 != 0);
        
        }
        internal PGCompany.专丛且丌丒丘业专万 丏丝丆丆丆丏丗上丛()
        {
            return this.七丞业与丙丘不丏丗(世丁丛丛丅万上丝且:  true);
        }
        internal PGCompany.专丛且丌丒丘业专万 上丂丌业与丘世丌丕()
        {
            return this.七丞业与丙丘不丏丗(世丁丛丛丅万上丝且:  false);
        }
        private PGCompany.专丛且丌丒丘业专万 七丞业与丙丘不丏丗(bool 世丁丛丛丅万上丝且)
        {
            System.Collections.Generic.List<丑丛丗丗丕不丘三丆> val_18;
            var val_19;
            var val_20;
            var val_21;
            PGCompany.专丛且丌丒丘业专万 val_0;
            System.Collections.Generic.List<ItemRarity> val_1 = new System.Collections.Generic.List<ItemRarity>();
            if((BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  this.业上丙丞丐丄丆丅七())) == null)
            {
                goto label_3;
            }
            
            val_18 = val_3.丂丅丘丕一世丐丑丆;
            if(val_18 != null)
            {
                goto label_4;
            }
            
            label_3:
            System.Collections.Generic.List<丑丛丗丗丕不丘三丆> val_4 = null;
            val_18 = val_4;
            val_4 = new System.Collections.Generic.List<丑丛丗丗丕不丘三丆>();
            label_4:
            val_19 = 0;
            goto label_5;
            label_23:
            if(val_4.Item[0] != null)
            {
                    val_20 = val_4.Item[0];
                var val_7 = (val_6.且世东丝七不丞丐丌 == 0) ? 1 : 0;
                val_7 = val_7 ^ 世丁丛丛丅万上丝且;
                if(val_7 != true)
            {
                    丑丛丗丗丕不丘三丆 val_8 = val_4.Item[0];
                if((val_1.Contains(item:  val_8.丈下丑丆上丏丗丈专)) != true)
            {
                    丑丛丗丗丕不丘三丆 val_10 = val_4.Item[0];
                val_1.Add(item:  val_10.丈下丑丆上丏丗丈专);
            }
            
                int val_11 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
                丑丛丗丗丕不丘三丆 val_12 = val_4.Item[0];
                val_20 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
                丑丛丗丗丕不丘三丆 val_14 = val_4.Item[0];
                val_14 = val_14 + 40;
                丑丛丗丗丕不丘三丆 val_15 = val_14 + ;
            }
            
            }
            
            val_19 = 1;
            label_5:
            if(val_19 < val_4.Count)
            {
                goto label_23;
            }
            
            val_21 = null;
            val_21 = null;
            if((丕下丆丑万世业丈丟.<>c.<>9__42_0) == null)
            {
                goto label_26;
            }
            
            label_31:
            val_1.Sort(comparison:  丕下丆丑万世业丈丟.<>c.<>9__42_0);
            mem[1152921555613034896] = 0;
            val_0.一三丘世丘上丘且与 = val_1;
            val_0.丘不丈丏世丗一丂万.Item2.上万三丆专丏丒丗业 = 0;
            return val_0;
            label_26:
            丕下丆丑万世业丈丟.<>c.<>9__42_0 = new System.Comparison<ItemRarity>(object:  丕下丆丑万世业丈丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丕下丆丑万世业丈丟.<>c::三专丞丄世业丘丕丁(ItemRarity 与丄丑丗且丗东丗一, ItemRarity 丕丏丌丕下丁丂丁丆));
            if(val_1 != 0)
            {
                goto label_31;
            }
            
            goto label_31;
        }
        internal void 丒专丏丈万丈丒丒丁(int 丏专且丟丗丘丂丌丘)
        {
            Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丒专丏丈万丈丒丒丁(世丕丘丈丙世业东丕:  this, 丏专且丟丗丘丂丌丘:  丏专且丟丗丘丂丌丘);
        }
        internal bool 丙丗一丅一丗丒丝万()
        {
            return false;
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            .<丄上丞不三与一丅丒>k__BackingField = 30000;
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丕下丆丑万世业丈丟(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        private static 丕下丆丑万世业丈丟()
        {
            PGCompany.丕下丆丑万世业丈丟.下丛业东丂上业丕丛 = new System.Collections.Generic.List<System.Boolean>();
        }
    
    }

}
