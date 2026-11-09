using UnityEngine;

namespace Progress
{
    internal sealed class 丅丈丅丛丌万丅丁一 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private PGCompany.且丟一七万东丁三上<System.Collections.Generic.Dictionary<string, Rilisoft.丅丌丌丐丘丕丟丏丝>> 东丁丌丑专丆丛世下;
        private PGCompany.且丟一七万东丁三上<PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>> <三丑丌丒丗上与丐世>k__BackingField;
        private PGCompany.且丟一七万东丁三上<System.Collections.Generic.Dictionary<string, PGCompany.丌丐下丌丘下丝丞业>> 下丗丌丞丘丑下上丛;
        
        // Properties
        internal PGCompany.且丟一七万东丁三上<PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>> 业下三三与丄丕专下 { get; set; }
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal PGCompany.且丟一七万东丁三上<PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>> 丈丐丈丑丌丙丒丐丂()
        {
            return (PGCompany.且丟一七万东丁三上<PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>)this.<三丑丌丒丗上与丐世>k__BackingField;
        }
        private void 一丂丝下丒丈与专丛(PGCompany.且丟一七万东丁三上<PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>> 丙业与丙丗丝不丈东)
        {
            this.<三丑丌丒丗上与丐世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.丌丐下丌丘下丝丞业 丁且万丞与一与东不(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, long 丑专丛丅丞下丄丈丞)
        {
            var val_46;
            System.Collections.Generic.Dictionary<System.String, PGCompany.丌丐下丌丘下丝丞业> val_47;
            string val_48;
            Rilisoft.OfferItemType val_49;
            string val_50;
            var val_51;
            Rilisoft.OfferItemType val_52;
            PGCompany.丌丐下丌丘下丝丞业 val_53;
            val_46 = 丑专丛丅丞下丄丈丞;
            long val_1 = this.丙丏丄上七丁丟丂丏(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if((this.下丗丌丞丘丑下上丛.ContainsKey(下上丐丆丝丟丝丒不:  丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与())) != true)
            {
                    System.Collections.Generic.Dictionary<System.String, PGCompany.丌丐下丌丘下丝丞业> val_5 = null;
                val_47 = val_5;
                val_5 = new System.Collections.Generic.Dictionary<System.String, PGCompany.丌丐下丌丘下丝丞业>();
                this.下丗丌丞丘丑下上丛.set_Item(下上丐丆丝丟丝丒不:  丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与(), 丙业与丙丗丝不丈东:  val_5);
            }
            
            if((this.下丗丌丞丘丑下上丛.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()].ContainsKey(key:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七())) == true)
            {
                goto label_10;
            }
            
            System.Collections.Generic.Dictionary<System.String, PGCompany.丌丐下丌丘下丝丞业> val_11 = this.下丗丌丞丘丑下上丛.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()];
            if(丈丄不七三万丄丁不 != null)
            {
                    val_48 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
                val_49 = 丈丄不七三万丄丁不.不业丙丒丂丞下丆丙();
            }
            else
            {
                    val_48 = 0.业上丙丞丐丄丆丅七();
                val_49 = 0.不业丙丒丂丞下丆丙();
            }
            
            val_50 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
            PGCompany.三东丏不丗世丅丌丄 val_17 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  val_49, 丞丅上丏丂且下丅与:  val_50);
            val_17.丒上七丐三业丅丈一(丙业与丙丗丝不丈东:  val_1);
            val_46 = val_46;
            val_47 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_17);
            if(val_11 == null)
            {
                goto label_18;
            }
            
            if(val_47 != null)
            {
                goto label_19;
            }
            
            goto label_23;
            label_18:
            if(val_47 == null)
            {
                goto label_23;
            }
            
            label_19:
            val_47 = 0;
            label_23:
            val_11.set_Item(key:  val_48, value:  val_47);
            label_10:
            val_51 = this.下丗丌丞丘丑下上丛.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()];
            if(val_51.Item[丈丄不七三万丄丁不.业上丙丞丐丄丆丅七()] == null)
            {
                goto label_34;
            }
            
            val_51 = this.下丗丌丞丘丑下上丛.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()].Item[丈丄不七三万丄丁不.业上丙丞丐丄丆丅七()];
            if(val_51.丕不丐专丒专下下丗() == val_1)
            {
                goto label_34;
            }
            
            val_51 = this.下丗丌丞丘丑下上丛.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()];
            if(丈丄不七三万丄丁不 != null)
            {
                    string val_32 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
                val_52 = 丈丄不七三万丄丁不.不业丙丒丂丞下丆丙();
            }
            else
            {
                    val_52 = 0.不业丙丒丂丞下丆丙();
            }
            
            val_50 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
            PGCompany.三东丏不丗世丅丌丄 val_37 = null;
            val_47 = val_37;
            val_37 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  val_52, 丞丅上丏丂且下丅与:  val_50);
            val_37.丒上七丐三业丅丈一(丙业与丙丗丝不丈东:  val_1);
            val_46 = val_46;
            val_53 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_37);
            if(val_51 == null)
            {
                goto label_42;
            }
            
            if(val_53 != null)
            {
                goto label_43;
            }
            
            goto label_47;
            label_42:
            if(val_53 == null)
            {
                goto label_47;
            }
            
            label_43:
            val_53 = 0;
            label_47:
            val_51.set_Item(key:  0.业上丙丞丐丄丆丅七(), value:  val_53);
            label_34:
            PGCompany.丌丐下丌丘下丝丞业 val_43 = this.下丗丌丞丘丑下上丛.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()].Item[丈丄不七三万丄丁不.业上丙丞丐丄丆丅七()];
            return (PGCompany.丌丐下丌丘下丝丞业)(val_43.丕不丐专丒专下下丗() > val_46) ? (val_43) : 0;
        }
        internal void 丂丕业丕三丛下丗丘(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, long 丑专丛丅丞下丄丈丞)
        {
            if((this.丙丏丄上七丁丟丂丏(丈丄不七三万丄丁不:  丈丄不七三万丄丁不)) <= 0)
            {
                    if((this.东丁丌丑专丆丛世下.ContainsKey(下上丐丆丝丟丝丒不:  丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与())) != true)
            {
                    this.东丁丌丑专丆丛世下.Add(下上丐丆丝丟丝丒不:  丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与(), 丙业与丙丗丝不丈东:  new System.Collections.Generic.Dictionary<System.String, Rilisoft.丅丌丌丐丘丕丟丏丝>());
            }
            
                if((this.东丁丌丑专丆丛世下.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()].ContainsKey(key:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七())) != true)
            {
                    Rilisoft.丅丌丌丐丘丕丟丏丝 val_13 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
                this.东丁丌丑专丆丛世下.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()].Add(key:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七(), value:  new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_13.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_13.丑丒丄下丁丐专丄丞});
            }
            
            }
            
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_17 = this.东丁丌丑专丆丛世下.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()].Item[丈丄不七三万丄丁不.业上丙丞丐丄丆丅七()];
            int val_23 = 丈丄不七三万丄丁不.丙丑丁专一专世万丕();
            val_23 = (System.Math.Max(val1:  val_17.七丄不丐丗三丝丑一.世三丞丅丑丌丈丈一(), val2:  丑专丛丅丞下丄丈丞)) + (val_23 << );
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_24 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  val_23);
            this.东丁丌丑专丆丛世下.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()].set_Item(key:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七(), value:  new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_24.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_24.丑丒丄下丁丐专丄丞});
        }
        internal System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 七丆一丌丕不万丌丌(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, long 丑专丛丅丞下丄丈丞)
        {
            PGCompany.且丟一七万东丁三上<System.Collections.Generic.Dictionary<System.String, Rilisoft.丅丌丌丐丘丕丟丏丝>> val_9;
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_1 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            val_9 = this.东丁丌丑专丆丛世下;
            if((val_9.ContainsKey(下上丐丆丝丟丝丒不:  丁丅丈丌丟世丗丗丟)) == false)
            {
                    return val_1;
            }
            
            val_9 = this.东丁丌丑专丆丛世下.Item[丁丅丈丌丟世丗丗丟].Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = val_9.GetEnumerator();
            label_9:
            if((2075528280 & 1) == 0)
            {
                goto label_6;
            }
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丞丅上丏丂且下丅与:  0.丐丏七丌丕丗业且上());
            PGCompany.丌丐下丌丘下丝丞业 val_8 = this.丁且万丞与一与东不(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丑专丛丅丞下丄丈丞:  丑专丛丅丞下丄丈丞);
            if(val_8 == null)
            {
                goto label_9;
            }
            
            val_1.Add(item:  val_8);
            goto label_9;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal bool 丞七丐丞丐丂丗丘丛(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            if((this.东丁丌丑专丆丛世下.ContainsKey(下上丐丆丝丟丝丒不:  丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与())) == false)
            {
                    return false;
            }
            
            System.Collections.Generic.Dictionary<System.String, Rilisoft.丅丌丌丐丘丕丟丏丝> val_4 = this.东丁丌丑专丆丛世下.Item[丈丄不七三万丄丁不.与丄丁丆丂丒丅丆与()];
            if(val_4 != null)
            {
                    return val_4.Remove(key:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七());
            }
            
            return val_4.Remove(key:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七());
        }
        private bool 丁丝世丌丛丕万丛丂(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            return (bool)((this.丙丏丄上七丁丟丂丏(丈丄不七三万丄丁不:  丈丄不七三万丄丁不)) > 0) ? 1 : 0;
        }
        private long 丙丏丄上七丁丟丂丏(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            string val_12;
            PGCompany.且丟一七万东丁三上<System.Collections.Generic.Dictionary<System.String, Rilisoft.丅丌丌丐丘丕丟丏丝>> val_13;
            var val_14;
            val_12 = 丈丄不七三万丄丁不;
            val_13 = this.东丁丌丑专丆丛世下;
            if((val_13.ContainsKey(下上丐丆丝丟丝丒不:  val_12.与丄丁丆丂丒丅丆与())) != false)
            {
                    val_13 = this.东丁丌丑专丆丛世下.Item[val_12.与丄丁丆丂丒丅丆与()];
                if((val_13.ContainsKey(key:  val_12.业上丙丞丐丄丆丅七())) != false)
            {
                    val_13 = val_12.与丄丁丆丂丒丅丆与();
                val_12 = val_12.业上丙丞丐丄丆丅七();
                Rilisoft.丅丌丌丐丘丕丟丏丝 val_10 = this.东丁丌丑专丆丛世下.Item[val_13].Item[val_12];
                long val_11 = val_10.七丄不丐丗三丝丑一.世三丞丅丑丌丈丈一();
                return (long)val_14;
            }
            
            }
            
            val_14 = 0;
            return (long)val_14;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 41;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丅丈丅丛丌万丅丁一.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丅丈丅丛丌万丅丁一.丐丌丞上世丛丐丏丛;
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_7;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            long val_37;
            var val_38;
            val_30 = this;
            this.东丁丌丑专丆丛世下 = new PGCompany.且丟一七万东丁三上<System.Collections.Generic.Dictionary<System.String, Rilisoft.丅丌丌丐丘丕丟丏丝>>();
            this.<三丑丌丒丗上与丐世>k__BackingField = new PGCompany.且丟一七万东丁三上<PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>();
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0.GetEnumerator();
            val_31 = 0;
            val_32 = 0;
            label_52:
            if((2076770752 & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
            if(val_8._value._obj == 0)
            {
                goto label_52;
            }
            
            int val_10 = 0;
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_8._value._obj.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  val_10)) == false)
            {
                goto label_52;
            }
            
            val_33 = val_10;
            if(this.东丁丌丑专丆丛世下 == null)
            {
                    val_33 = val_33;
            }
            
            if((this.东丁丌丑专丆丛世下.ContainsKey(下上丐丆丝丟丝丒不:  0)) != true)
            {
                    System.Collections.Generic.Dictionary<System.String, Rilisoft.丅丌丌丐丘丕丟丏丝> val_13 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.丅丌丌丐丘丕丟丏丝>();
                this.东丁丌丑专丆丛世下.set_Item(下上丐丆丝丟丝丒不:  0, 丙业与丙丗丝不丈东:  null);
            }
            
            val_34 = val_10;
            if((this.<三丑丌丒丗上与丐世>k__BackingField) == null)
            {
                    val_34 = val_34;
            }
            
            if((this.<三丑丌丒丗上与丐世>k__BackingField.ContainsKey(下上丐丆丝丟丝丒不:  0)) != true)
            {
                    PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝> val_15 = new PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>();
                this.<三丑丌丒丗上与丐世>k__BackingField.set_Item(下上丐丆丝丟丝丒不:  0, 丙业与丙丗丝不丈东:  null);
            }
            
            Dictionary.Enumerator<TKey, TValue> val_16 = val_8._value._obj.GetEnumerator();
            label_33:
            if((2076770688 & 1) == 0)
            {
                goto label_18;
            }
            
            ConfiguredValueTaskAwaiter val_17 = val_7.GetAwaiter();
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_17._value._obj.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  0)) == false)
            {
                goto label_33;
            }
            
            PGCompany.丙万丙下三下丄丌丄 val_22 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  0);
            long val_23 = System.Convert.ToInt64(value:  val_17._value._obj);
            if(val_22 == null)
            {
                goto label_27;
            }
            
            val_35 = val_10;
            if(this.东丁丌丑专丆丛世下 == null)
            {
                    val_35 = val_35;
            }
            
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_26 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  val_23);
            this.东丁丌丑专丆丛世下.Item[0].set_Item(key:  val_22.业上丙丞丐丄丆丅七(), value:  new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_26.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_26.丑丒丄下丁丐专丄丞});
            goto label_33;
            label_27:
            val_36 = val_10;
            if((this.<三丑丌丒丗上与丐世>k__BackingField) == null)
            {
                    val_36 = val_36;
            }
            
            PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝> val_27 = this.<三丑丌丒丗上与丐世>k__BackingField.Item[0];
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_28 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  val_23);
            val_37 = val_28.丑丒丄下丁丐专丄丞;
            if(val_27 == null)
            {
                    val_37 = val_37;
            }
            
            val_27.set_Item(下上丐丆丝丟丝丒不:  0, 丙业与丙丗丝不丈东:  new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_28.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_37});
            goto label_33;
            label_18:
            val_38 = val_32;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((1 == 1) || (319 != 319))
            {
                goto label_49;
            }
            
            goto label_52;
            label_49:
            if( == 0)
            {
                goto label_52;
            }
            
            goto label_52;
            label_5:
            val_30 = 2;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(319 == 347)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            var val_16;
            var val_19;
            var val_26;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>, System.Int32> val_28;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>, System.Collections.Generic.Dictionary<System.Int32, System.Int64>> val_30;
            var val_31;
            var val_32;
            var val_35;
            var val_36;
            val_26 = null;
            val_26 = null;
            val_28 = 丅丈丅丛丌万丅丁一.<>c.<>9__22_0;
            if(val_28 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>, System.Int32> val_1 = null;
                val_28 = val_1;
                val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>, System.Int32>(object:  丅丈丅丛丌万丅丁一.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丅丈丅丛丌万丅丁一.<>c::丆三丟不专丝万三丗(System.Collections.Generic.KeyValuePair<int, PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>> 丙丁上东且七丂世丗));
                val_26 = null;
                丅丈丅丛丌万丅丁一.<>c.<>9__22_0 = val_28;
            }
            
            val_26 = null;
            val_30 = 丅丈丅丛丌万丅丁一.<>c.<>9__22_1;
            if(val_30 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>, System.Collections.Generic.Dictionary<System.Int32, System.Int64>> val_2 = null;
                val_30 = val_2;
                val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>, System.Collections.Generic.Dictionary<System.Int32, System.Int64>>(object:  丅丈丅丛丌万丅丁一.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.Int32, System.Int64> 丅丈丅丛丌万丅丁一.<>c::丕且丒丙七丗业与丅(System.Collections.Generic.KeyValuePair<int, PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>> 丙丁上东且七丂世丗));
                丅丈丅丛丌万丅丁一.<>c.<>9__22_1 = val_30;
            }
            
            System.Collections.Generic.Dictionary<TKey, TElement> val_3 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>, System.Int32, System.Collections.Generic.Dictionary<System.Int32, System.Int64>>(source:  this.<三丑丌丒丗上与丐世>k__BackingField, keySelector:  val_1, elementSelector:  val_2);
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32, TValue>> val_4 = this.东丁丌丑专丆丛世下.GetEnumerator();
            val_31 = 0;
            val_32 = 0;
            var val_30 = 0;
            label_54:
            if(val_4 != null)
            {
                goto label_51;
            }
            
            label_52:
            label_51:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            T val_8 = val_4.Current;
            if((val_3.ContainsKey(key:  val_8.丙东专丂世丈丏丁丂())) != true)
            {
                    System.Collections.Generic.Dictionary<System.Int32, System.Int64> val_12 = new System.Collections.Generic.Dictionary<System.Int32, System.Int64>();
                val_3.set_Item(key:  val_8.丙东专丂世丈丏丁丂(), value:  null);
            }
            
            Dictionary.Enumerator<TKey, TValue> val_13 = val_8.GetEnumerator();
            label_36:
            if((2077027088 & 1) == 0)
            {
                goto label_27;
            }
            
            GooglePlayGames.BasicApi.Nearby.EndpointDetails val_17 = val_16.RemoteEndpoint;
            int val_23 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  val_8.丙东专丂世丈丏丁丂(), 丞一丁业丄一一业且:  val_19.丐丏七丌丕丗业且上());
            val_35 = null;
            val_35 = null;
            if(val_23 == 丐丏七丈且丌丄三丏.丛七丞丂下丘丘丘东)
            {
                goto label_36;
            }
            
            val_3.Item[val_8.丙东专丂世丈丏丁丂()].set_Item(key:  val_23, value:  val_19.世三丞丅丑丌丈丈一());
            goto label_36;
            label_27:
            val_30 = val_30 + 1;
            val_36 = val_32;
            mem2[0] = 251;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_30 == 1) || ((2077026944 + ((0 + 1)) << 2) != 251))
            {
                goto label_50;
            }
            
            var val_31 = 0;
            val_31 = val_31 ^ (val_30 >> 31);
            val_30 = val_30 + val_31;
            if(val_4 != null)
            {
                goto label_51;
            }
            
            goto label_52;
            label_50:
            if( == 0)
            {
                goto label_54;
            }
            
            goto label_54;
            label_17:
            val_30 = val_30 + 1;
            mem2[0] = 274;
            if(val_4 == null)
            {
                
            }
            else
            {
                    var val_32 = 0;
                val_32 = val_32 + 1;
                val_4.Dispose();
            }
            
            if(val_30 != 1)
            {
                    if( == false)
            {
                    return (object)val_3;
            }
            
                if((2077026944 + ((0 + 1)) << 2) == 274)
            {
                    return (object)val_3;
            }
            
                return (object)val_3;
            }
            
            if( == true)
            {
                    return (object)val_3;
            }
            
            return (object)val_3;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.东丁丌丑专丆丛世下.Clear();
            this.<三丑丌丒丗上与丐世>k__BackingField.Clear();
            this.下丗丌丞丘丑下上丛.Clear();
        }
        public 丅丈丅丛丌万丅丁一()
        {
            this.东丁丌丑专丆丛世下 = new PGCompany.且丟一七万东丁三上<System.Collections.Generic.Dictionary<System.String, Rilisoft.丅丌丌丐丘丕丟丏丝>>();
            this.<三丑丌丒丗上与丐世>k__BackingField = new PGCompany.且丟一七万东丁三上<PGCompany.且丟一七万东丁三上<Rilisoft.丅丌丌丐丘丕丟丏丝>>();
            this.下丗丌丞丘丑下上丛 = new PGCompany.且丟一七万东丁三上<System.Collections.Generic.Dictionary<System.String, PGCompany.丌丐下丌丘下丝丞业>>();
        }
        private static 丅丈丅丛丌万丅丁一()
        {
            Progress.丅丈丅丛丌万丅丁一.丕丟一七丑丙丂丆丙 = "Inventory_Expiry_slot";
            Progress.丅丈丅丛丌万丅丁一.丐丌丞上世丛丐丏丛 = "Inventory_Expiry_Slot_Key_JUN_2020";
        }
    
    }

}
