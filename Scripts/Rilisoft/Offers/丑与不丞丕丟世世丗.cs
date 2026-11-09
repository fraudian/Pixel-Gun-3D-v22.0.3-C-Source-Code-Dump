using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 丑与不丞丕丟世世丗 : 丑丝上世丄丂丛丛丕, IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 且丑不丛丏丏丐丄丐;
        private readonly System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> 三丒丕丙丅一与丙下;
        private Rilisoft.Offers.丘丕丏七丛下丑上丄 世丂上丌丞且丁七丏;
        private readonly Rilisoft.丅丂丛丒不专丈业丘<Rilisoft.Offers.上丝下一业丈七专丘> 且丞丏东一丛不丙且;
        private readonly Rilisoft.Offers.丛丛与丕不丒与丘丑 丟不业丐丟丐丙丈丒;
        private Rilisoft.PlayerPaymentType 丞业丟东世丏丅丘丌;
        
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
            return 140;
        }
        public bool 丁世东三丂丒不七丆()
        {
            return true;
        }
        internal 丑与不丞丕丟世世丗()
        {
            string val_8;
            Rilisoft.丅丂丛丒不专丈业丘<Rilisoft.Offers.上丝下一业丈七专丘> val_9;
            this.且丑不丛丏丏丐丄丐 = new System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>();
            this.三丒丕丙丅一与丙下 = new System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专>();
            Rilisoft.Offers.丛丛与丕不丒与丘丑 val_3 = null;
            val_8 = 0;
            val_3 = new Rilisoft.Offers.丛丛与丕不丒与丘丑();
            val_9 = this.且丞丏东一丛不丙且;
            this.丟不业丐丟丐丙丈丒 = val_3;
            if(val_9 != null)
            {
                goto label_1;
            }
            
            Rilisoft.丅丂丛丒不专丈业丘<Rilisoft.Offers.上丝下一业丈七专丘> val_6 = null;
            val_8 = "TierBundleOffersModule-"("TierBundleOffersModule-") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            val_9 = val_6;
            val_6 = new Rilisoft.丅丂丛丒不专丈业丘<Rilisoft.Offers.上丝下一业丈七专丘>(丟东丟丑丕丄丂丟丙:  val_8);
            this.且丞丏东一丛不丙且 = val_9;
            if(val_9 == null)
            {
                goto label_2;
            }
            
            label_1:
            if(val_9 != null)
            {
                    return;
            }
            
            Rilisoft.Offers.上丝下一业丈七专丘 val_7 = new Rilisoft.Offers.上丝下一业丈七专丘();
            if(this.且丞丏东一丛不丙且 != null)
            {
                goto typeof(Rilisoft.丅丂丛丒不专丈业丘<T>).__il2cppRuntimeField_198;
            }
            
            goto typeof(Rilisoft.丅丂丛丒不专丈业丘<T>).__il2cppRuntimeField_198;
            label_2:
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 上丑下专丄下丟丏丆(string 丗丟丁丐与下丙丕丛)
        {
            .丗丟丁丐与下丙丕丛 = 丗丟丁丐与下丙丕丛;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  new 丑与不丞丕丟世世丗.丒丛丁与丅东丒不七(), method:  System.Boolean 丑与不丞丕丟世世丗.丒丛丁与丅东丒不七::万上下上与丅专丑丗(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上)));
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
        public Rilisoft.业丙丘丆东丈丕丂丄 丐上丙世丂丅丝不丈()
        {
            var val_2;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = 丑与不丞丕丟世世丗.<>c.<>9__15_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丑与不丞丕丟世世丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丑与不丞丕丟世世丗.<>c::万丄与专丏丒专丅世(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丑与不丞丕丟世世丗.<>c.<>9__15_0 = val_4;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1);
        }
        public System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 丙丈丈东丟丟丒丄三()
        {
            var val_3;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = 丑与不丞丕丟世世丗.<>c.<>9__16_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丑与不丞丕丟世世丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丑与不丞丕丟世世丗.<>c::下丗丘七丐丞七丕丁(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丑与不丞丕丟世世丗.<>c.<>9__16_0 = val_5;
            return System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1));
        }
        public bool 且丟丌丑丘丕七专三()
        {
            var val_2;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = 丑与不丞丕丟世世丗.<>c.<>9__17_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丑与不丞丕丟世世丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丑与不丞丕丟世世丗.<>c::业丐不丝丑一与七且(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丑与不丞丕丟世世丗.<>c.<>9__17_0 = val_4;
            return System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  this.且丑不丛丏丏丐丄丐, predicate:  val_1);
        }
        internal System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> 丗不丞一且丟丈丈丗()
        {
            return System.Linq.Enumerable.ToList<PGCompany.丒丌业一丕丘丐世专>(source:  this.三丒丕丙丅一与丙下);
        }
        internal PGCompany.丒丌业一丕丘丐世专 丅专上东下丕丄丗丅(int 丞丅上丏丂且下丅与)
        {
            .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
            System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_2 = this.丗不丞一且丟丈丈丗();
            if(val_2 == null)
            {
                    return (PGCompany.丒丌业一丕丘丐世专)System.Linq.Enumerable.FirstOrDefault<PGCompany.丒丌业一丕丘丐世专>(source:  val_2, predicate:  new System.Func<PGCompany.丒丌业一丕丘丐世专, System.Boolean>(object:  new 丑与不丞丕丟世世丗.业丂七丏丟丕丌丂世(), method:  System.Boolean 丑与不丞丕丟世世丗.业丂七丏丟丕丌丂世::上丕业丝万专丒一专(PGCompany.丒丌业一丕丘丐世专 三丟东丕丄丄下下丑)));
            }
            
            return (PGCompany.丒丌业一丕丘丐世专)System.Linq.Enumerable.FirstOrDefault<PGCompany.丒丌业一丕丘丐世专>(source:  val_2, predicate:  new System.Func<PGCompany.丒丌业一丕丘丐世专, System.Boolean>(object:  new 丑与不丞丕丟世世丗.业丂七丏丟丕丌丂世(), method:  System.Boolean 丑与不丞丕丟世世丗.业丂七丏丟丕丌丂世::上丕业丝万专丒一专(PGCompany.丒丌业一丕丘丐世专 三丟东丕丄丄下下丑)));
        }
        public void 丑七丂丌世与七丏与(string 丅业丙丞且丐一丙丆)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.世丂上丌丞且丁七丏 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        }
        public void 且丛丕业丞万东七丒(bool 丆丄丘丂业丛七丁且 = False)
        {
            System.Collections.Generic.List<System.Int32> val_39;
            var val_40;
            var val_41;
            int val_42;
            string val_43;
            Rilisoft.业丙丘丆东丈丕丂丄 val_44;
            int val_45;
            int val_46;
            Rilisoft.业丙丘丆东丈丕丂丄 val_47;
            Rilisoft.Offers.丘丕丏七丛下丑上丄 val_48;
            var val_49;
            Progress.OfferProgress val_50;
            var val_51;
            var val_52;
            this.世业丒万丘丆专丘丐();
            if(this.世丂上丌丞且丁七丏 == null)
            {
                    return;
            }
            
            if(this.世丂上丌丞且丁七丏.Version != 1)
            {
                    return;
            }
            
            if(丆丄丘丂业丛七丁且 == false)
            {
                goto label_3;
            }
            
            Rilisoft.丗下丙丅且丐丞丙世 val_1 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
            if(val_1.丘与丈世不丕丕丅丑 == null)
            {
                goto label_10;
            }
            
            val_40 = null;
            val_40 = null;
            if((val_1.丘与丈世不丕丕丅丑.东一丌丙丕丐丞上且(丌世丛业丛一丘丈丝:  PGCompany.丐三丛丒三一三三丆.丕丙上丟与丒丄丕三)) == null)
            {
                goto label_10;
            }
            
            val_41 = 0;
            goto label_11;
            label_10:
            val_41 = 0;
            label_11:
            if((551897840 & 1) != 0)
            {
                    val_42 = val_41.丙东专丂世丈丏丁丂();
            }
            else
            {
                    System.TimeSpan val_4 = System.TimeSpan.FromDays(value:  30);
                val_42 = (int)val_4._ticks.TotalSeconds;
            }
            
            this.丞业丟东世丏丅丘丌 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().一与不丙丝万丐丂七(丏丄专业丞世丏丙丈:  val_42);
            label_3:
            if(null < 1)
            {
                goto label_30;
            }
            
            丕丐丞专上丗三七三 val_9 = System.Linq.Enumerable.FirstOrDefault<丕丐丞专上丗三七三>(source:  this.世丂上丌丞且丁七丏.Bundles, predicate:  new System.Func<丕丐丞专上丗三七三, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.Offers.丑与不丞丕丟世世丗::且丅业下丗专世专与(Rilisoft.Offers.丘丕丏七丛下丑上丄.丕丐丞专上丗三七三 丌丗丏丏丛东专丁且)));
            val_43 = this.且丞丏东一丛不丙且.上丑丕丅与丟上丘业(且丛丏丄丟丐丝三一:  typeof(Rilisoft.丅丂丛丒不专丈业丘<T>).__il2cppRuntimeField_190>>0&0xFFFFFFFF);
            Progress.OfferProgress val_12 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丈丒且丗七丗丄下丐(丗丟丁丐与下丙丕丛:  val_43);
            if(((val_9 == null) || (val_12 == null)) || (val_12.IsBought == true))
            {
                goto label_30;
            }
            
            val_39 = this.丁与且丅丏下丌且与(丗一丘丅丅丒丙丏丁:  val_9, 上丕丈丞丌丘丅不与:  val_12);
            if(val_39.一业丟丁上丑丘丕丄() == false)
            {
                goto label_32;
            }
            
            val_44 = val_39;
            goto label_33;
            label_32:
            val_45 = val_9.Id;
            val_46 = val_45;
            if((this.且丞丏东一丛不丙且.Contains(item:  val_46)) != true)
            {
                    this.且丞丏东一丛不丙且.Add(item:  val_9.Id);
                val_46 = public System.Void Rilisoft.丅丂丛丒不专丈业丘<Rilisoft.Offers.上丝下一业丈七专丘>::丂且不业丂专丛丆东();
                this.且丞丏东一丛不丙且.丂且不业丂专丛丆东();
            }
            
            label_30:
            int val_16 = ExperienceController.丞丞丘业东丙丏七丌();
            if(val_16 <= 64)
            {
                goto label_45;
            }
            
            val_39 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            val_47 = this.且丞丏东一丛不丙且;
            val_45 = this.世丂上丌丞且丁七丏;
            val_48 = val_45;
            if(val_45 == null)
            {
                    val_48 = this.世丂上丌丞且丁七丏;
                if(val_48 == null)
            {
                goto label_108;
            }
            
            }
            
            int val_38 = this.世丂上丌丞且丁七丏.LifeTime;
            int val_39 = this.世丂上丌丞且丁七丏.MaxPlayerLevelCooldown;
            val_38 = val_38 + this.且丞丏东一丛不丙且;
            val_39 = val_38 + val_39;
            if(val_39 >= (val_39 << ))
            {
                goto label_53;
            }
            
            return;
            label_45:
            if(null >= 1)
            {
                    val_39 = this.且丞丏东一丛不丙且;
                if(null == val_16)
            {
                    return;
            }
            
            }
            
            val_39 = this.世丂上丌丞且丁七丏.AvailableForLevels;
            if((val_39.Contains(item:  val_16)) == false)
            {
                    return;
            }
            
            label_53:
            val_39 = this.世丂上丌丞且丁七丏.InappsForCohorts;
            if((val_39.TryGetValue(key:  this.丞业丟东世丏丅丘丌, value: out  0)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_22 = val_20.GetEnumerator();
            val_39 = 0;
            val_49 = 0;
            val_47 = 0;
            var val_40 = 0;
            label_104:
            if((551897808 & 1) == 0)
            {
                goto label_69;
            }
            
            val_45 = 0.丙东专丂世丈丏丁丂();
            if(val_47 != 0)
            {
                goto label_69;
            }
            
            List.Enumerator<T> val_25 = this.世丂上丌丞且丁七丏.Bundles.GetEnumerator();
            label_85:
            if((551897776 & 1) == 0)
            {
                goto label_72;
            }
            
            if(val_26.m_firstChar != val_45)
            {
                goto label_85;
            }
            
            bool val_27 = this.且丞丏东一丛不丙且.Contains(item:  val_26.m_stringLength);
            if((val_27 == true) || ((PGCompany.ItemSystem.丂丟丁丗丘与丞丂丟.东一三一万且丕世不(丑东与丅丐丅丂丞业:  val_27, 丑上丈丞丗丄丒丈丕:  this.丟不业丐丟丐丙丈丒)) == false))
            {
                goto label_85;
            }
            
            Rilisoft.丗下丙丅且丐丞丙世 val_29 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
            val_50 = val_29.丈丒且丗七丗丄下丐(丗丟丁丐与下丙丕丛:  val_29.上丑丕丅与丟上丘业(且丛丏丄丟丐丝三一:  val_26.m_stringLength));
            if(val_50 == null)
            {
                    val_50 = new Progress.OfferProgress();
                val_50 = new Progress.OfferProgress();
                .Id = val_50.上丑丕丅与丟上丘业(且丛丏丄丟丐丝三一:  val_26.m_stringLength);
            }
            
            if((this.丁与且丅丏下丌且与(丗一丘丅丅丒丙丏丁:  0.丐丏七丌丕丗业且上(), 上丕丈丞丌丘丅不与:  new Progress.OfferProgress())) == null)
            {
                goto label_85;
            }
            
            goto label_86;
            label_72:
            label_86:
            val_40 = val_40 + 1;
            mem2[0] = 744;
            val_51 = val_49;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_40 == 1) || ((1152921543813450368 + ((0 + 1)) << 2) != 744))
            {
                goto label_101;
            }
            
            var val_41 = 0;
            val_41 = val_41 ^ (val_40 >> 31);
            val_40 = val_40 + val_41;
            goto label_104;
            label_101:
            if( == 0)
            {
                goto label_104;
            }
            
            goto label_104;
            label_69:
            val_40 = val_40 + 1;
            mem2[0] = 772;
            goto label_105;
            label_108:
            val_39 = 1179403647;
            val_49 = val_39;
            label_105:
            val_52 = public System.Void List.Enumerator<System.Int32>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(W28 == 1)
            {
                goto label_110;
            }
            
            if((val_49 == 0) || ((1152921543813450368 + (W28) << 2) == 772))
            {
                goto label_125;
            }
            
            label_124:
            val_52 = 0;
            label_125:
            if(val_47 == null)
            {
                    return;
            }
            
            val_45 = val_47.丏不丁丛丕丒丏丆丂();
            mem2[0] = val_45;
            mem2[0] = val_16;
            val_39 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            mem2[0] = val_39;
            this.且丞丏东一丛不丙且.丂且不业丂专丛丆东();
            val_44 = val_47;
            label_33:
            this.不丂世丏万且专丅上(丙业丞丑七丗下丟丌:  val_44);
            return;
            label_110:
            if(val_49 != 0)
            {
                goto label_124;
            }
            
            goto label_125;
        }
        private void 不丂世丏万且专丅上(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            if(丙业丞丑七丗下丟丌 == null)
            {
                    return;
            }
            
            this.且丑不丛丏丏丐丄丐.Add(item:  丙业丞丑七丗下丟丌);
            世丕三丙七丆丁丂丒 val_3 = 丙业丞丑七丗下丟丌.丛丗丑丞丟丄且丘七();
            decimal val_5 = System.Decimal.op_Implicit(value:  val_3.丑七万上丛与不丟七.丟丂丞不专丆万丒世());
            this.三丒丕丙丅一与丙下.Add(item:  Rilisoft.Offers.丁且丕专万丈丒丏丗.丅丈丞丒丝丙丟且丄(丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 东丐丘丟丐一下丛丕:  "Key_9348", 万丐丘丘下丒丝丙三:  "Key_9349", 与丝丙丝万丑丞丄一:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_1.丂世丙丗丁丝丝丛业, hi = val_1.丂世丙丗丁丝丝丛业, lo = 丙业丞丑七丗下丟丌.丛丗丑丞丟丄且丘七(), mid = 丙业丞丑七丗下丟丌.丛丗丑丞丟丄且丘七()}), 丂上丙丅三专丌丘丂:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, 丟不丄一丄丅一世丗:  5, 丐上丐丂丆上世丝丆:  74));
        }
        private Rilisoft.业丙丘丆东丈丕丂丄 丁与且丅丏下丌且与(Rilisoft.Offers.丘丕丏七丛下丑上丄.丕丐丞专上丗三七三 丗一丘丅丅丒丙丏丁, Progress.OfferProgress 上丕丈丞丌丘丅不与)
        {
            var val_16;
            System.Func<PGCompany.三东丏不丗世丅丌丄, Rilisoft.OfferItem> val_18;
            Rilisoft.Offers.丛丛与丕不丒与丘丑 val_19;
            val_16 = null;
            val_16 = null;
            val_18 = 丑与不丞丕丟世世丗.<>c.<>9__24_0;
            if(val_18 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, Rilisoft.OfferItem> val_2 = null;
                val_18 = val_2;
                val_2 = new System.Func<PGCompany.三东丏不丗世丅丌丄, Rilisoft.OfferItem>(object:  丑与不丞丕丟世世丗.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem 丑与不丞丕丟世世丗.<>c::丄万丕上丕丑丕丄丕(PGCompany.三东丏不丗世丅丌丄 与丛丗丈七专上丕丏));
                丑与不丞丕丟世世丗.<>c.<>9__24_0 = val_18;
            }
            
            .且东丌丏丐丝丕万业 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<PGCompany.三东丏不丗世丅丌丄, Rilisoft.OfferItem>(source:  丗一丘丅丅丒丙丏丁.Content, selector:  val_2));
            .丒丆丕丁丟业上七丅 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  丗一丘丅丅丒丙丏丁.Price, 丏丂不专上丘丂不丅:  PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  31).业上丙丞丐丄丆丅七());
            decimal val_9 = System.Decimal.op_Implicit(value:  丗一丘丅丅丒丙丏丁.Sale);
            .丂世丙丗丁丝丝丛业 = val_9;
            mem[1152921543814055832] = val_9.lo;
            mem[1152921543814055836] = val_9.mid;
            .丑七万上丛与不丟七 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  丗一丘丅丅丒丙丏丁.BasePrice, 丏丂不专上丘丂不丅:  "Real");
            Rilisoft.七丈业与与不七丈丟 val_11 = new Rilisoft.七丈业与与不七丈丟();
            string val_12 = val_11.上丑丕丅与丟上丘业(且丛丏丄丟丐丝三一:  丗一丘丅丅丒丙丏丁.Id);
            if(val_11 != null)
            {
                    .下丄丈不与世丐业专 = val_12;
                .丘世丐丞与丌世丄丏 = 丗一丘丅丅丒丙丏丁.Id;
            }
            else
            {
                    mem[40] = val_12;
                mem[32] = 丗一丘丅丅丒丙丏丁.Id;
            }
            
            .丒上一丁丆丛东专丙 = new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒();
            .万丈丘丏丅世万丝丄 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            .丒丌丑丟丄上世丅专 = false;
            七丈业与与不七丈丟.丏一丄丐专丟丂丟丏 val_14 = new 七丈业与与不七丈丟.丏一丄丐专丟丂丟丏();
            if(val_14 != null)
            {
                    .丂万丟丘丆丞丅丕丗 = 1;
                val_19 = this.丟不业丐丟丐丙丈丒;
            }
            else
            {
                    mem[32] = 1;
                val_19 = this.丟不业丐丟丐丙丈丒;
            }
            
            .与不丂丁丅丑丏丏丒 = val_19;
            .丁丑丅丐丌不世丁下 = val_14;
            .且与丙丑丕专七丈专 = this.世丂上丌丞且丁七丏.LifeTime;
            return (Rilisoft.业丙丘丆东丈丕丂丄)new Rilisoft.业丙丘丆东丈丕丂丄(丁丅丈丌丟世丗丗丟:  140, 一丐丗丁丞丆丅丟丄:  val_11, 上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与, 丑丒丛与下专且丗不:  new System.Nullable<AdaptiveModuleType>() {HasValue = false}, 东一丁世丑丞业丄丐:  0);
        }
        private string 上丑丕丅与丟上丘业(int 且丛丏丄丟丐丝三一)
        {
            return (string)System.String.Format(format:  "tb_{0}", arg0:  且丛丏丄丟丐丝三一);
        }
        public void 丁东丐丄丞丌丘业上()
        {
        
        }
        public void 丁丆丕丏东丟丐丄丂()
        {
            this.世业丒万丘丆专丘丐();
            Rilisoft.Offers.上丝下一业丈七专丘 val_1 = new Rilisoft.Offers.上丝下一业丈七专丘();
            if(this.且丞丏东一丛不丙且 == null)
            {
                
            }
        
        }
        public void 丟一丏与丈丅丗丅丈()
        {
            bool val_2 = Progress.丆丆丐下万丙丄丆上.丑七不且上丗丁一世().丘七三丏丟丝下上东(丕上业丕丘上丘七一:  140, 丗丛丙丟一丒一与丈:  this.且丑不丛丏丏丐丄丐);
        }
        internal void 丛丗业丞上丂丏东丑()
        {
            var val_3;
            var val_17;
            int val_18;
            val_17 = this;
            List.Enumerator<T> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_22:
            if((553178736 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            Progress.OfferProgress val_5 = val_4.业丑丁丆丕丆丂丅万();
            if(val_5.FirstShowDate <= 0)
            {
                goto label_5;
            }
            
            if(val_4 != null)
            {
                goto label_21;
            }
            
            goto label_7;
            label_5:
            val_18 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            if(val_18 <= 0)
            {
                    UnityEngine.Debug.LogError(message:  "server time not setted");
                System.DateTime val_8 = System.DateTime.Now;
                val_18 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_8.dateData});
            }
            
            Progress.OfferProgress val_10 = val_4.业丑丁丆丕丆丂丅万();
            val_10.FirstShowDate = val_18;
            this.世丅万丛与万万七万(万丏丗丗丅丄丌业一:  val_4.丏不丁丛丕丒丏丆丂());
            if(val_4 != null)
            {
                goto label_21;
            }
            
            label_7:
            label_21:
            this.丆三东丒一丝丑丝丘(万丏丗丗丅丄丌业一:  val_4.丏不丁丛丕丒丏丆丂());
            goto label_22;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((0 & 1) == 0)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  205);
            this.丟一丏与丈丅丗丅丈();
            Progress.丆丆丐下万丙丄丆上.丑七不且上丗丁一世().丂丗丞丞且万丛万不();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            val_17 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
            val_3 = 0;
            val_17.且丛丕业丞万东七丒(丁丅丈丌丟世丗丗丟:  new System.Nullable<OfferModule>() {HasValue = false}, 丙三丈与东三东世丏:  false, 丆丄丘丂业丛七丁且:  true);
            BalanceController.丏丝丆东上丙丑丅不(丆丄丘丂业丛七丁且:  false);
        }
        internal bool 丟世丙丛业丏东与七()
        {
            var val_4;
            var val_15;
            int val_9 = 0;
            if((PixelTime.丝业丁丌丘东丏世与() == false) || (this.世丂上丌丞且丁七丏 == null))
            {
                goto label_4;
            }
            
            List.Enumerator<T> val_2 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_20:
            if((553352192 & 1) == 0)
            {
                goto label_6;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(val_5.一业丟丁上丑丘丕丄() == false)
            {
                goto label_20;
            }
            
            if(val_5.丟专丘丘丕丈丅丗丙() == false)
            {
                goto label_10;
            }
            
            bool val_10 = this.且丞丏东一丛不丙且.TryGetValue(key:  val_5.丏不丁丛丕丒丏丆丂(), value: out  val_9);
            long val_12 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            if((val_12 < 1) || ((val_12 - val_9) <= this.世丂上丌丞且丁七丏.AutomaticallyShowCooldown))
            {
                goto label_20;
            }
            
            label_10:
            val_15 = 1;
            goto label_21;
            label_6:
            val_15 = 0;
            label_21:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            return (bool)val_15;
            label_4:
            val_15 = 0;
            return (bool)val_15;
        }
        internal System.Collections.Generic.List<int> 丑丆丛业丞下丆业丁()
        {
            var val_5;
            int val_10 = 0;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                    return val_1;
            }
            
            if(this.世丂上丌丞且丁七丏 == null)
            {
                    return val_1;
            }
            
            List.Enumerator<T> val_3 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_26:
            if((553517424 & 1) == 0)
            {
                goto label_6;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            if(val_6.一业丟丁上丑丘丕丄() == false)
            {
                goto label_26;
            }
            
            if(val_6.丟专丘丘丕丈丅丗丙() == false)
            {
                goto label_10;
            }
            
            bool val_11 = this.且丞丏东一丛不丙且.TryGetValue(key:  val_6.丏不丁丛丕丒丏丆丂(), value: out  val_10);
            long val_13 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            if((val_13 < 1) || ((val_13 - val_10) <= this.世丂上丌丞且丁七丏.AutomaticallyShowCooldown))
            {
                goto label_26;
            }
            
            val_1.Add(item:  val_6.丏不丁丛丕丒丏丆丂());
            goto label_26;
            label_10:
            val_1.Add(item:  val_6.丏不丁丛丕丒丏丆丂());
            goto label_26;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal void 丆三东丒一丝丑丝丘(int 万丏丗丗丅丄丌业一)
        {
            if((this.且丞丏东一丛不丙且.ContainsKey(key:  万丏丗丗丅丄丌业一)) != false)
            {
                    return;
            }
            
            this.世丅万丛与万万七万(万丏丗丗丅丄丌业一:  万丏丗丗丅丄丌业一);
        }
        internal void 世丅万丛与万万七万(int 万丏丗丗丅丄丌业一)
        {
            int val_9;
            if((this.且丞丏东一丛不丙且.ContainsKey(key:  万丏丗丗丅丄丌业一)) != false)
            {
                    val_9 = 万丏丗丗丅丄丌业一;
                this.且丞丏东一丛不丙且.set_Item(key:  val_9, value:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛());
            }
            else
            {
                    val_9 = 万丏丗丗丅丄丌业一;
                this.且丞丏东一丛不丙且.Add(key:  val_9, value:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛());
            }
            
            if((this.且丞丏东一丛不丙且.ContainsKey(key:  万丏丗丗丅丄丌业一)) != false)
            {
                    this.且丞丏东一丛不丙且.set_Item(key:  万丏丗丗丅丄丌业一, value:  this.且丞丏东一丛不丙且.Item[万丏丗丗丅丄丌业一] + 1);
            }
            else
            {
                    this.且丞丏东一丛不丙且.Add(key:  万丏丗丗丅丄丌业一, value:  1);
            }
            
            this.且丞丏东一丛不丙且.丂且不业丂专丛丆东();
        }
        internal int 丁丕丄丈丅七业丗丝(int 万丏丗丗丅丄丌业一)
        {
            if((this.且丞丏东一丛不丙且.ContainsKey(key:  万丏丗丗丅丄丌业一)) == false)
            {
                    return 0;
            }
            
            if(this.且丞丏东一丛不丙且 != null)
            {
                    return this.且丞丏东一丛不丙且.Item[万丏丗丗丅丄丌业一];
            }
            
            return this.且丞丏东一丛不丙且.Item[万丏丗丗丅丄丌业一];
        }
        private void 世业丒万丘丆专丘丐()
        {
            var val_3;
            var val_6;
            List.Enumerator<T> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_4:
            if((554109840 & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_3.丐丏七丌丕丗业且上() == null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.且丑不丛丏丏丐丄丐.Clear();
            val_6 = null;
            val_6 = null;
            if((丑与不丞丕丟世世丗.<>c.<>9__35_0) == null)
            {
                goto label_12;
            }
            
            label_18:
            this.三丒丕丙丅一与丙下.ForEach(action:  丑与不丞丕丟世世丗.<>c.<>9__35_0);
            this.三丒丕丙丅一与丙下.Clear();
            return;
            label_12:
            丑与不丞丕丟世世丗.<>c.<>9__35_0 = new System.Action<PGCompany.丒丌业一丕丘丐世专>(object:  丑与不丞丕丟世世丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丑与不丞丕丟世世丗.<>c::丑业且丕专丐丑一世(PGCompany.丒丌业一丕丘丐世专 三且丑上丕上丅丁万));
            if(this.三丒丕丙丅一与丙下 != null)
            {
                goto label_18;
            }
            
            goto label_18;
        }
        public void Dispose()
        {
            this.世业丒万丘丆专丘丐();
        }
        private bool 且丅业下丗专世专与(Rilisoft.Offers.丘丕丏七丛下丑上丄.丕丐丞专上丗三七三 丌丗丏丏丛东专丁且)
        {
            return (bool)(丌丗丏丏丛东专丁且.Id == null) ? 1 : 0;
        }
    
    }

}
