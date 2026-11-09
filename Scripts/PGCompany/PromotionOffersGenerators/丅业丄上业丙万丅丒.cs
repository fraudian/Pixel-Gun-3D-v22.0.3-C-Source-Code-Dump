using UnityEngine;

namespace PGCompany.PromotionOffersGenerators
{
    internal abstract class 丅业丄上业丙万丅丒 : 丟丅丞丂丂世丄丐东
    {
        // Fields
        private const int 丟丆一丄下丙不丏丕 = 1;
        private const int 丈下丈丄丝丆丁丞万 = 25;
        
        // Properties
        protected abstract string 不丝丐东丙上丗丅丑 { get; }
        
        // Methods
        protected abstract string 丗丞丄丕丝丂上东丁(); // 0
        internal override PGCompany.东丑丆丗丏丐丟下丄 丛上丈丐丗丙下东丁(PGCompany.下七业丄丐世丘丘不 丞丈丛丛丙丑业丗专, PGCompany.下七业丄丐世丘丘不.丝丕专世丙丆丛丝丝 丙专丗一丈丛丌丛且, PGCompany.丅丘丈丞丐专丑且三 丆万上丝丅丙丙丝丒)
        {
            PGCompany.三丌上丁一丟丐丟丈 val_78;
            PGCompany.下七业丄丐世丘丘不 val_79;
            var val_81;
            var val_82;
            PGCompany.下七业丄丐世丘丘不 val_83;
            var val_85;
            PGCompany.三丙业丆上丏三丈丌 val_86;
            var val_89;
            string val_90;
            System.Predicate<T> val_91;
            var val_92;
            var val_93;
            var val_94;
            var val_96;
            var val_97;
            var val_99;
            var val_100;
            var val_102;
            var val_103;
            PGCompany.下七业丄丐世丘丘不 val_105;
            var val_106;
            val_78 = 1152921559851932320;
            val_79 = 丞丈丛丛丙丑业丗专;
            丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏 val_1 = new 丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_81 = val_1;
            .丞丈丛丛丙丑业丗专 = val_79;
            mem[1152921559851961040] = 丆万上丝丅丙丙丝丒.业专丁七丆丏丝丙丙;
            mem[1152921559851961056] = 丆万上丝丅丙丙丝丒.业业七丛一丒丑丌三.lo;
            mem[1152921559851961064] = this;
            if(val_79 != null)
            {
                goto label_2;
            }
            
            goto label_138;
            label_1:
            mem[32] = 丆万上丝丅丙丙丝丒.业业七丛一丒丑丌三.lo;
            mem[16] = 丆万上丝丅丙丙丝丒.业专丁七丆丏丝丙丙;
            mem[40] = this;
            val_81 = 48;
            mem[48] = val_79;
            val_79 = mem[48];
            if(val_79 == 0)
            {
                goto label_138;
            }
            
            label_2:
            丞丂丘丒丟丞丑下丄 val_3 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_3 == null)
            {
                goto label_6;
            }
            
            一一万丒与专丙丁丛 val_4 = val_3.世丝丌一且丝专丑丛();
            if(val_1 == null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            if(val_1 != null)
            {
                goto label_8;
            }
            
            label_7:
            val_83 = mem[48];
            val_82 = 0;
            label_8:
            val_79 = val_82.且丈丙不丝七丕三丄(丞丈丛丛丙丑业丗专:  val_83, 与丄不丌一世东丁丙:  new 丝丕专世丙丆丛丝丝() {_id = new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = 丙专丗一丈丛丌丛且._id.七丄不丐丗三丝丑一}, OfferType = 丙专丗一丈丛丌丛且.OfferType, PriceCurrency = 丙专丗一丈丛丌丛且.OfferType, Algorithm = 丙专丗一丈丛丌丛且._id.七丄不丐丗三丝丑一}, 丘丏万且丅下丕丌丈:  new System.Decimal() {flags = -589469008, hi = 268435468});
            if(val_1 != null)
            {
                    .丅丄丆丞下丄丒专丕 = val_79;
                val_85 = val_78;
                val_78 = 268435468;
            }
            else
            {
                    .丅丄丆丞下丄丒专丕 = val_79;
                val_85 = val_78;
                val_78 = 268435468;
                val_79 = .丅丄丆丞下丄丒专丕;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_6 = 0.东丐丅不丏丑丑且丝(丌丕丝丒万丅丛丕丞:  val_78, 丅丄丆丞下丄丒专丕:  val_79, 丏丝一丘世世丗丅丒:  1);
            if(val_6 == null)
            {
                goto label_138;
            }
            
            System.Collections.Generic.List<PGCompany.三丙业丆上丏三丈丌> val_9 = null;
            val_78 = val_9;
            val_9 = new System.Collections.Generic.List<PGCompany.三丙业丆上丏三丈丌>();
            List.Enumerator<T> val_10 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一上丄与丌七业丈不<PGCompany.万丛下丐与丅与丅专>(丁丅丈丌丟世丗丗丟:  216).GetEnumerator();
            label_27:
            if(((-589537760) & 1) == 0)
            {
                goto label_15;
            }
            
            string val_11 = 丙专丗一丈丛丌丛且._id.七丄不丐丗三丝丑一.丐丏七丌丕丗业且上();
            if(((val_11 & 1) == 0) || (val_11.丈丏专三世七丒丘丑().IsDecoration == true))
            {
                goto label_27;
            }
            
            PlaceableItemSettings val_14 = val_11.丈丏专三世七丒丘丑();
            if(((System.String.op_Equality(a:  val_14.supercategory, b:  this)) == false) || (val_11.丈丏专三世七丒丘丑().ClanDivision > 0))
            {
                goto label_27;
            }
            
            val_86 = val_11;
            if((val_86 != null) && (null != null))
            {
                    val_86 = 0;
            }
            
            val_9.Add(item:  val_86);
            goto label_27;
            label_15:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_89 = 1152921559851728864;
            int val_20 = val_9.RemoveAll(match:  new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  val_1, method:  System.Boolean 丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏::丘丁丘丞丙丐一丗丘(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛)));
            int val_22 = val_9.RemoveAll(match:  new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  val_1, method:  System.Boolean 丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏::与丑丕世下业一上上(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛)));
            val_79 = 1152921505369411584;
            val_90 = PGCompany.三丛丗丆七丁丆上丌.丘丐丕世下丟丁丛三(丁丅丈丌丟世丗丗丟:  2, 丞丅上丏丂且下丅与:  PGCompany.三丛丗丆七丁丆上丌.东一丂丛丞与丁丙业(世七七丟丑丁丂与丞:  -589481296, 三丐丘万上下上丛七:  丙专丗一丈丛丌丛且._id.七丄不丐丗三丝丑一.丅丕丁与丆丆丑丆丝()));
            val_91 = Progress.七七世万专丕丁上业.丂丂丁丑不丙丌万上().丂丄不丟丆丑丈世世(丙下不丏丅丅专丂丗:  val_90);
            .丈七丅丝丒一三世东 = 0;
            val_92 = null;
            val_92 = null;
            if(val_91 != 丐丏七丈且丌丄三丏.丛七丞丂下丘丘丘东)
            {
                goto label_54;
            }
            
            if((丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏)[1152921559851961024].丈七丅丝丒一三世东 == null)
            {
                goto label_59;
            }
            
            label_68:
            if(val_9.Count < 2)
            {
                goto label_59;
            }
            
            System.Predicate<PGCompany.三丙业丆上丏三丈丌> val_29 = null;
            val_91 = val_29;
            val_29 = new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  val_1, method:  System.Boolean 丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏::下一丒丄下丗丅丁丁(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛));
            int val_30 = val_9.RemoveAll(match:  val_29);
            goto label_59;
            label_54:
            val_79 = val_89;
            PGCompany.三东丏不丗世丅丌丄 val_33 = null;
            val_91 = val_33;
            val_33 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  Progress.七七世万专丕丁上业.丂丂丁丑不丙丌万上().丂丄不丟丆丑丈世世(丙下不丏丅丅专丂丗:  val_90));
            val_93 = 0;
            if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_33)) != false)
            {
                    val_91 = val_33.业东丅东丌上丗丑不();
                PGCompany.三丙业丆上丏三丈丌 val_37 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.三丙业丆上丏三丈丌>(丞世不丒下上上丝丑:  val_91);
            }
            
            val_89 = val_79;
            .丈七丅丝丒一三世东 = val_37;
            if(val_37 != null)
            {
                goto label_68;
            }
            
            label_59:
            if((-589477200) == 1)
            {
                goto label_69;
            }
            
            if((-589477200) != 3)
            {
                goto label_91;
            }
            
            val_79 = 1152921505668079616;
            val_94 = null;
            val_94 = null;
            val_91 = 丅业丄上业丙万丅丒.<>c.<>9__4_7;
            if(val_91 != null)
            {
                goto label_73;
            }
            
            val_96 = val_89;
            goto label_81;
            label_69:
            val_79 = 1152921505668079616;
            val_97 = null;
            val_97 = null;
            val_91 = 丅业丄上业丙万丅丒.<>c.<>9__4_9;
            if(val_91 != null)
            {
                goto label_78;
            }
            
            val_99 = val_89;
            goto label_89;
            label_81:
            System.Predicate<PGCompany.三丙业丆上丏三丈丌> val_38 = null;
            val_91 = val_38;
            val_38 = new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  丅业丄上业丙万丅丒.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丅业丄上业丙万丅丒.<>c::丑与一丅丁丞丏丗专(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛));
            val_89 = ;
            丅业丄上业丙万丅丒.<>c.<>9__4_7 = val_91;
            label_73:
            if((val_9.Exists(match:  val_38)) == false)
            {
                goto label_91;
            }
            
            val_100 = null;
            val_100 = null;
            val_91 = 丅业丄上业丙万丅丒.<>c.<>9__4_8;
            if(val_91 != null)
            {
                goto label_94;
            }
            
            val_102 = val_89;
            goto label_97;
            label_89:
            System.Predicate<PGCompany.三丙业丆上丏三丈丌> val_40 = null;
            val_91 = val_40;
            val_40 = new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  丅业丄上业丙万丅丒.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丅业丄上业丙万丅丒.<>c::下丄三东且丛丏三丒(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛));
            val_89 = ;
            丅业丄上业丙万丅丒.<>c.<>9__4_9 = val_91;
            label_78:
            if((val_9.Exists(match:  val_40)) == false)
            {
                goto label_91;
            }
            
            val_103 = null;
            val_103 = null;
            val_91 = 丅业丄上业丙万丅丒.<>c.<>9__4_10;
            if(val_91 != null)
            {
                goto label_94;
            }
            
            val_102 = val_89;
            goto label_99;
            label_97:
            System.Predicate<PGCompany.三丙业丆上丏三丈丌> val_42 = null;
            val_91 = val_42;
            val_42 = new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  丅业丄上业丙万丅丒.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丅业丄上业丙万丅丒.<>c::丌丛丌丟东三丈上丏(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛));
            丅业丄上业丙万丅丒.<>c.<>9__4_8 = val_91;
            goto label_98;
            label_99:
            System.Predicate<PGCompany.三丙业丆上丏三丈丌> val_43 = null;
            val_91 = val_43;
            val_43 = new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  丅业丄上业丙万丅丒.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丅业丄上业丙万丅丒.<>c::丁丐东丄专丄七万丙(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛));
            丅业丄上业丙万丅丒.<>c.<>9__4_10 = val_91;
            label_98:
            val_89 = ;
            label_94:
            int val_44 = val_9.RemoveAll(match:  val_43);
            label_91:
            if((丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏)[1152921559851961024].丈七丅丝丒一三世东 != null)
            {
                    System.Predicate<PGCompany.三丙业丆上丏三丈丌> val_45 = null;
                val_91 = val_45;
                val_45 = new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  val_1, method:  System.Boolean 丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏::丞七业丙丁业丌丒丐(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛));
                val_79 = 1152921559851774944;
                if((val_9.Exists(match:  val_45)) != false)
            {
                    System.Predicate<PGCompany.三丙业丆上丏三丈丌> val_47 = null;
                val_91 = val_47;
                val_47 = new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  val_1, method:  System.Boolean 丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏::且东与万七丘丟丆且(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛));
                int val_48 = val_9.RemoveAll(match:  val_47);
            }
            
                if((丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏)[1152921559851961024].丈七丅丝丒一三世东 != null)
            {
                    System.Predicate<PGCompany.三丙业丆上丏三丈丌> val_49 = null;
                val_91 = val_49;
                val_49 = new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  val_1, method:  System.Boolean 丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏::三下丌丐丄与丐与丌(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛));
                if((val_9.Exists(match:  val_49)) != false)
            {
                    System.Predicate<PGCompany.三丙业丆上丏三丈丌> val_51 = null;
                val_91 = val_51;
                val_51 = new System.Predicate<PGCompany.三丙业丆上丏三丈丌>(object:  val_1, method:  System.Boolean 丅业丄上业丙万丅丒.世丞丒丅一专丌丐丏::万一丝丁七世世丗丞(PGCompany.三丙业丆上丏三丈丌 丗丛丂且丕丆上世丛));
                int val_52 = val_9.RemoveAll(match:  val_51);
            }
            
            }
            
            }
            
            if(val_9.Count < 1)
            {
                goto label_138;
            }
            
            System.Collections.Generic.Dictionary<PGCompany.三丙业丆上丏三丈丌, System.Single> val_54 = null;
            val_91 = val_54;
            val_54 = new System.Collections.Generic.Dictionary<PGCompany.三丙业丆上丏三丈丌, System.Single>();
            List.Enumerator<T> val_55 = val_9.GetEnumerator();
            label_121:
            if(((-589537792) & 1) == 0)
            {
                goto label_112;
            }
            
            string val_56 = 丙专丗一丈丛丌丛且._id.七丄不丐丗三丝丑一.丐丏七丌丕丗业且上();
            int val_65 = val_56.丝丝丌丟丆丂丂丞业().丟不一丌丘万丛东业() / val_56.丝丝丌丟丆丂丂丞业().丏丈丁专专丘丒丂丂();
            val_65 = 1 - val_65;
            float val_78 = (float)val_65;
            val_78 = val_78 * 100f;
            val_78 = val_78 + 100f;
            val_78 = val_78 + ((0 < val_56.丝丝丌丟丆丂丂丞业().丈丏专三世七丒丘丑().ClanDivision) ? 25f : 0f);
            val_54.Add(key:  val_56, value:  val_78);
            goto label_121;
            label_112:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            val_79 = .丅丄丆丞下丄丒专丕;
            PGCompany.三丙业丆上丏三丈丌 val_66 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.三丙业丆上丏三丈丌>(丑东与丅丐丅丂丞业:  val_54);
            if(val_1 != null)
            {
                    val_105 = mem[48];
            }
            else
            {
                    val_105 = mem[48];
            }
            
            decimal val_67 = val_66.丑丙丟与一丝丐世丕(丞丈丛丛丙丑业丗专:  val_105, 丈下丑丆上丏丗丈专:  val_66);
            val_78 = val_67.flags.世丐丁丐一丕丒丏丒(丞丈丛丛丙丑业丗专:  val_105, 丅丄丆丞下丄丒专丕:  null, 万业丛世丈下万东丕:  new System.Decimal() {flags = val_67.flags, hi = val_67.hi, lo = val_67.lo, mid = val_67.mid});
            if(val_78 >= 1)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_70 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_66.业东丅东丌上丗丑不());
                val_70.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_78);
                decimal val_71 = val_66.丑丙丟与一丝丐世丕(丞丈丛丛丙丑业丗专:  mem[48], 丈下丑丆上丏丗丈专:  val_66);
                int val_72 = val_70.丂丁丏一丙丛业且丌();
                val_91 = val_72.丞专丝业丌丆专丑丙(丅丄丆丞下丄丒专丕:  null, 万业丛世丈下万东丕:  new System.Decimal() {flags = val_71.flags, hi = val_71.hi, lo = val_71.lo, mid = val_71.mid}, 丗且丒丞不上丏丏丂:  val_72);
                val_78 = -589481296;
                int val_74 = 丙专丗一丈丛丌丛且._id.七丄不丐丗三丝丑一.丅丕丁与丆丆丑丆丝();
                val_106 = val_74.丝与丘丘丅业一业丘(世七七丟丑丁丂与丞:  val_78, 三丐丘万上下上丛七:  val_74, 下丅丙一丂丗丅丝七:  val_70, 丒世丘丘上丆丝东丞:  val_6, 与丝丙丝万丑丞丄一:  val_91);
                val_79 = val_66.业东丅东丌上丗丑不();
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丙与东丗丘丁丗七丈(丙下不丏丅丅专丂丗:  val_90, 丆专且丕专丗与一丏:  val_79);
                return (PGCompany.东丑丆丗丏丐丟下丄)val_106;
            }
            
            label_138:
            val_106 = 0;
            return (PGCompany.东丑丆丗丏丐丟下丄)val_106;
        }
        protected int 与丄丏世东丟与丐丕(PGCompany.下七业丄丐世丘丘不 丞丈丛丛丙丑业丗专, int 丅丄丆丞下丄丒专丕, ItemRarity 丈下丑丆上丏丗丈专)
        {
            decimal val_1 = this.丑丙丟与一丝丐世丕(丞丈丛丛丙丑业丗专:  丞丈丛丛丙丑业丗专, 丈下丑丆上丏丗丈专:  丈下丑丆上丏丗丈专);
            return val_1.flags.世丐丁丐一丕丒丏丒(丞丈丛丛丙丑业丗专:  丞丈丛丛丙丑业丗专, 丅丄丆丞下丄丒专丕:  丅丄丆丞下丄丒专丕, 万业丛世丈下万东丕:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid});
        }
        protected decimal 丑丙丟与一丝丐世丕(PGCompany.下七业丄丐世丘丘不 丞丈丛丛丙丑业丗专, ItemRarity 丈下丑丆上丏丗丈专)
        {
            var val_9;
            int val_10;
            if(丈下丑丆上丏丗丈专 <= 5)
            {
                    var val_1 = 106042464 + (丈下丑丆上丏丗丈专) << 2;
                val_1 = val_1 + 106042464;
            }
            else
            {
                    val_9 = 0;
                val_10 = 0;
                return new System.Decimal() {lo = 971403264, mid = 268435456};
            }
        
        }
        protected 丅业丄上业丙万丅丒()
        {
            this = new System.Object();
        }
    
    }

}
