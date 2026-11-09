using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 丒三丐丗业丟一与丗 : 丅三丑丂丝丈专不一
    {
        // Properties
        internal override string 丐丞七下万丆丄丈业 { get; }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 三万丐专丆丆丕丝一 { get; }
        
        // Methods
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.offers.adaptive";
        }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丑且一丐东三不丈丝()
        {
            return 60;
        }
        protected override PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            var val_8;
            var val_36;
            var val_37;
            var val_38;
            string val_39;
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_1 = this.丝与丘丘丅业一业丘(丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌);
            if(val_1 == null)
            {
                    return val_1;
            }
            
            PGCompany.StorePromotionConfig val_2 = val_1.丘丑下丆上业丛一丄();
            if((val_1.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "enough-to-craft")) == true)
            {
                goto label_30;
            }
            
            List.Enumerator<T> val_6 = val_1.丝世丑七丂丄丅专不().GetEnumerator();
            label_13:
            if(((-647217904) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_9 = val_8.丐丏七丌丕丗业且上();
            if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丅且丟丅丙丘上丁丏(丞世不丒下上上丝丑:  val_9.m_stringLength.业东丅东丌上丗丑不())) == false)
            {
                goto label_13;
            }
            
            val_37 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().下丞丝丂万丙三丏上(世且丐丐丑丛东专丟:  val_9.m_stringLength.业东丅东丌上丗丑不());
            if(val_37 < val_9.m_stringLength.丂丁丏一丙丛业且丌())
            {
                goto label_13;
            }
            
            PGCompany.StorePromotionSettings val_17 = val_2.Settings;
            bool val_18 = val_17.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "enough-to-craft");
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(丙业丞丑七丗下丟丌 != null)
            {
                goto label_31;
            }
            
            goto label_18;
            label_30:
            if(丙业丞丑七丗下丟丌 != null)
            {
                goto label_31;
            }
            
            label_18:
            label_31:
            Rilisoft.OfferItem val_20 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  丙业丞丑七丗下丟丌.丏与丅专三丙与丘丒());
            if(val_20 != null)
            {
                    val_37 = val_2.Settings;
                OfferModule val_22 = 丙业丞丑七丗下丟丌.丑且一丐东三不丈丝();
                val_8 = 0;
                System.Nullable<AdaptiveModuleType> val_23 = 丙业丞丑七丗下丟丌.下丐丝万丞丙丁丂丑();
                val_21.TitleLocKey = PGCompany.MainStore.丒三丐丗业丟一与丗.三东一上丛丒丆东与(下丅丙一丂丗丅丝七:  val_20, 丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丑丒丛与下专且丗不:  new System.Nullable<AdaptiveModuleType>() {HasValue = val_23.HasValue});
            }
            
            if(丙业丞丑七丗下丟丌.丑且一丐东三不丈丝() != 60)
            {
                goto label_47;
            }
            
            System.Nullable<AdaptiveModuleType> val_26 = 丙业丞丑七丗下丟丌.下丐丝万丞丙丁丂丑();
            if(((-647217864) & 1) == 0)
            {
                goto label_47;
            }
            
            System.Nullable<AdaptiveModuleType> val_27 = 丙业丞丑七丗下丟丌.下丐丝万丞丙丁丂丑();
            if((-647217864) != 70)
            {
                goto label_42;
            }
            
            val_38 = val_2.Settings;
            val_39 = "Key_5575";
            goto label_45;
            label_42:
            System.Nullable<AdaptiveModuleType> val_29 = 丙业丞丑七丗下丟丌.下丐丝万丞丙丁丂丑();
            if((-647217864) != 90)
            {
                goto label_47;
            }
            
            val_38 = val_2.Settings;
            val_39 = "Key_5586";
            label_45:
            val_30.DescriptionLocKey = val_39;
            label_47:
            val_1.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_2);
            val_36 = val_1.与不丞丑七丘丁丂丛();
            System.Nullable<AdaptiveModuleType> val_32 = 丙业丞丑七丗下丟丌.下丐丝万丞丙丁丂丑();
            bool val_34 = val_36.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  PGCompany.MainStore.丒三丐丗业丟一与丗.丈丞丈且丝丁丆世业(业丂丙丛丗丙丑丁下:  new System.Nullable<AdaptiveModuleType>() {HasValue = val_32.HasValue}));
            return val_1;
        }
        private static string 丈丞丈且丝丁丆世业(System.Nullable<Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType> 业丂丙丛丗丙丑丁下)
        {
            var val_2;
            if((((-647023096) & 1) == 0) || (((-647023112) & 1) == 0))
            {
                goto label_10;
            }
            
            int val_1 = 业丂丙丛丗丙丑丁下.HasValue.丙东专丂世丈丏丁丂();
            if(val_1 <= 40)
            {
                goto label_3;
            }
            
            if(val_1 == 70)
            {
                    return (string)val_2;
            }
            
            if(val_1 == 80)
            {
                    return (string)val_2;
            }
            
            if(val_1 != 90)
            {
                goto label_10;
            }
            
            val_2 = "source.offers.adaptive.gadgets";
            return (string)val_2;
            label_3:
            if(val_1 == 10)
            {
                    return (string)val_2;
            }
            
            if(val_1 == 30)
            {
                    return (string)val_2;
            }
            
            if(val_1 == 40)
            {
                    val_2 = "source.offers.adaptive.royale";
                return (string)val_2;
            }
            
            label_10:
            val_2 = "source.offers.adaptive";
            return (string)val_2;
        }
        internal static string 三东一上丛丒丆东与(Rilisoft.OfferItem 下丅丙一丂丗丅丝七, System.Nullable<Rilisoft.业丙丘丆东丈丕丂丄.OfferModule> 丕上业丕丘上丘七一, System.Nullable<Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType> 丑丒丛与下专且丗不)
        {
            var val_16;
            int val_30;
            var val_31;
            var val_32;
            val_30 = System.String.alignConst;
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return (string)val_31;
            }
            
            if(((((-646825144) & 1) != 0) && (((-646825160) & 1) != 0)) && ((-646825144) == 60))
            {
                    if((-646825160) == 70)
            {
                    val_31 = "Key_2875";
                return (string)val_31;
            }
            
                if((-646825160) == 30)
            {
                    val_31 = "Key_4950";
                return (string)val_31;
            }
            
                if((-646825160) == 80)
            {
                    val_31 = "Key_7035";
                return (string)val_31;
            }
            
                if((-646825160) == 90)
            {
                    val_31 = "Key_5574";
                return (string)val_31;
            }
            
            }
            
            if(下丅丙一丂丗丅丝七.Type != 10)
            {
                goto label_13;
            }
            
            if((((-646825144) & 1) == 0) || ((-646825144) != 40))
            {
                goto label_15;
            }
            
            label_66:
            val_32 = PGCompany.MainStore.丒三丐丗业丟一与丗.丐丞丐丝下上上丐丂(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
            return (string)val_31;
            label_13:
            if(((下丅丙一丂丗丅丝七.Type != 20) && (下丅丙一丂丗丅丝七.Type != 30)) && (下丅丙一丂丗丅丝七.Type != 40))
            {
                    if(下丅丙一丂丗丅丝七.Type != 50)
            {
                    if(下丅丙一丂丗丅丝七.Type != 60)
            {
                goto label_21;
            }
            
            }
            
            }
            
            val_31 = "Key_6247";
            return (string)val_31;
            label_15:
            val_31 = "Key_6246";
            return (string)val_31;
            label_21:
            if(下丅丙一丂丗丅丝七.Type == 70)
            {
                    return (string)val_31;
            }
            
            if(下丅丙一丂丗丅丝七.Type == 85)
            {
                    return (string)val_31;
            }
            
            if(下丅丙一丂丗丅丝七.Type == 1080)
            {
                    return (string)val_31;
            }
            
            if(下丅丙一丂丗丅丝七.Type != 1070)
            {
                    return (string)val_31;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_14 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values.GetEnumerator();
            label_45:
            if(((-646825184) & 1) == 0)
            {
                goto label_33;
            }
            
            string val_17 = val_16.丐丏七丌丕丗业且上();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  X22)) == true)
            {
                goto label_37;
            }
            
            bool val_20 = System.String.op_Equality(a:  X22, b:  下丅丙一丂丗丅丝七.Id);
            if(val_20 == true)
            {
                goto label_42;
            }
            
            label_37:
            if(val_20 != false)
            {
                    if((System.Linq.Enumerable.Contains<System.String>(source:  val_20.Values, value:  下丅丙一丂丗丅丝七.Id)) == true)
            {
                goto label_42;
            }
            
            }
            
            if((System.String.op_Equality(a:  丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished + 64, b:  下丅丙一丂丗丅丝七.Id)) != true)
            {
                    if((System.Linq.Enumerable.Contains<System.String>(source:  丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished + 64 + 72.Values, value:  下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_45;
            }
            
            }
            
            label_42:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_63;
            label_33:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_63:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_30)) == true)
            {
                goto label_66;
            }
            
            return (string)val_31;
        }
        internal static string 丐丞丐丝下上上丐丂(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            int val_9;
            var val_11;
            val_9 = System.String.alignConst;
            if(下丅丙一丂丗丅丝七 != null)
            {
                    System.Nullable<ItemRarity> val_1 = 下丅丙一丂丗丅丝七.Rarity;
            }
            else
            {
                    System.Nullable<ItemRarity> val_2 = 0.Rarity;
            }
            
            if(下丅丙一丂丗丅丝七.Type != 1070)
            {
                goto label_3;
            }
            
            if(((-646614792) & 1) == 0)
            {
                    return (string)((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  null)) != true) ? (val_9) : ();
            }
            
            if((-646614792) > 5)
            {
                goto label_12;
            }
            
            var val_9 = mem[4611686239285273460];
            val_9 = val_9 + 106045332;
            goto (mem[4611686239285273460] + 106045332);
            label_3:
            if(下丅丙一丂丗丅丝七.Type != 10)
            {
                    return (string)((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  null)) != true) ? (val_9) : ();
            }
            
            System.Nullable<CategoryNames> val_5 = 下丅丙一丂丗丅丝七.Category;
            if(( & 1) == 0)
            {
                    return (string)((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  null)) != true) ? (val_9) : ();
            }
            
            System.Nullable<CategoryNames> val_6 = 下丅丙一丂丗丅丝七.Category;
            if( > 5)
            {
                goto label_12;
            }
            
            var val_10 = mem[4611686239285273404];
            val_10 = val_10 + 106045308;
            goto (mem[4611686239285273404] + 106045308);
            label_12:
            val_11 = 0;
            return (string)((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  null)) != true) ? (val_9) : ();
        }
        public 丒三丐丗业丟一与丗()
        {
        
        }
    
    }

}
