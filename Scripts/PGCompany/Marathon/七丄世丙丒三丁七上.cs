using UnityEngine;

namespace PGCompany.Marathon
{
    internal class 七丄世丙丒三丁七上 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private PGCompany.Marathon.业丏丏丏丞且丘下与 丈丄丂下丒专丌丛丄;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        internal PGCompany.Marathon.业丏丏丏丞且丘下与 不丆丟与丙丏业丛丗 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)PGCompany.Marathon.七丄世丙丒三丁七上.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)PGCompany.Marathon.七丄世丙丒三丁七上.丐丌丞上世丛丐丏丛;
        }
        internal PGCompany.Marathon.业丏丏丏丞且丘下与 业丑丁丆丕丆丂丅万()
        {
            return (PGCompany.Marathon.业丏丏丏丞且丘下与)this.丈丄丂下丒专丌丛丄;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 61;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            string val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄);
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.丈丄丂下丒专丌丛丄 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            int val_13;
            var val_14;
            var val_16;
            System.Collections.Generic.List<System.String> val_17;
            val_13 = this;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_14 = 1152921516595677584;
            val_1.Add(key:  "i", value:  this.丈丄丂下丒专丌丛丄.Initialized);
            val_1.Add(key:  "t", value:  this.丈丄丂下丒专丌丛丄.LastGettedTime);
            System.Collections.Generic.Dictionary<System.Int32, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Object>();
            if(this.丈丄丂下丒专丌丛丄.GettedRewards == null)
            {
                goto label_43;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = this.丈丄丂下丒专丌丛丄.GettedRewards.GetEnumerator();
            val_13 = 0;
            val_16 = 0;
            var val_12 = 0;
            label_29:
            if(((-819449104) & 1) == 0)
            {
                goto label_9;
            }
            
            ConfiguredValueTaskAwaiter val_6 = this.丈丄丂下丒专丌丛丄.Initialized.GetAwaiter();
            if(val_6._value._obj == 0)
            {
                goto label_10;
            }
            
            val_17 = null;
            val_17 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_8 = val_6._value._obj.GetEnumerator();
            label_17:
            if(((-819449152) & 1) == 0)
            {
                goto label_12;
            }
            
            string val_9 = this.丈丄丂下丒专丌丛丄.Initialized.丐丏七丌丕丗业且上();
            if(val_9 == null)
            {
                goto label_17;
            }
            
            null.Add(item:  PGCompany.万丞丘与丕丞下万丌.丙业不丝丗丌丗世下(丈丄不七三万丄丁不:  val_9));
            goto label_17;
            label_10:
            val_17 = 0;
            goto label_27;
            label_12:
            val_12 = val_12 + 1;
            mem2[0] = 196;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_12 != 1) && ((-819449232 + ((0 + 1)) << 2) == 196))
            {
                    var val_13 = 0;
                val_13 = val_13 ^ (val_12 >> 31);
                val_12 = val_12 + val_13;
            }
            else
            {
                    if( != 0)
            {
                
            }
            
            }
            
            label_27:
            val_2.Add(key:  val_6._value._obj.丙东专丂世丈丏丁丂(), value:  null);
            goto label_29;
            label_9:
            val_12 = val_12 + 1;
            mem2[0] = 236;
            val_14 = 1152921516595677584;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_12 == 1)
            {
                goto label_38;
            }
            
            if(( == 0) || ((-819449232 + ((0 + 1)) << 2) == 236))
            {
                goto label_43;
            }
            
            label_42:
            label_43:
            val_1.Add(key:  "r", value:  val_2);
            return (object)val_1;
            label_38:
            if( != 0)
            {
                goto label_42;
            }
            
            goto label_43;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丈丄丂下丒专丌丛丄 = new PGCompany.Marathon.业丏丏丏丞且丘下与();
        }
        public 七丄世丙丒三丁七上()
        {
        
        }
        private static 七丄世丙丒三丁七上()
        {
            PGCompany.Marathon.七丄世丙丒三丁七上.丕丟一七丑丙丂丆丙 = "MarathonSlot_slot";
            PGCompany.Marathon.七丄世丙丒三丁七上.丐丌丞上世丛丐丏丛 = "MarathonSlot_slot";
        }
    
    }

}
