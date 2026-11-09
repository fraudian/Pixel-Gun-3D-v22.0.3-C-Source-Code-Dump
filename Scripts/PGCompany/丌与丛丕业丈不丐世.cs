using UnityEngine;

namespace PGCompany
{
    public static class 丌与丛丕业丈不丐世
    {
        // Fields
        private static int 且丑丑丟丄丘世一丐;
        private static System.Action<string> 丙丌丄丌丕丅一丁丑;
        private static System.Action<InappRememberedBonus> 丘丈丈万丟丛丄丏丟;
        private static System.Action<InappRememberedBonus> 丛丐且下世丕上丟丅;
        
        // Methods
        public static bool 丒丛丐丐丑丈世专丑(string 丘专丈与三专丈丈专)
        {
            var val_6;
            System.Object[] val_7;
            string val_8;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丘专丈与三专丈丈专)) == false)
            {
                goto label_3;
            }
            
            UnityEngine.Debug.LogError(message:  "AddContent: inappId.IsNullOrEmpty()");
            goto label_6;
            label_3:
            InappRememberedBonus val_2 = 一下丛与丛丛万万丏.丌七丑世世丛丑丛丕(丘专丈与三专丈丈专:  丘专丈与三专丈丈专);
            if(val_2 == null)
            {
                goto label_9;
            }
            
            if((PGCompany.丌与丛丕业丈不丐世.丒丛丐丐丑丈世专丑(丄上专丄七丘丕万东:  val_2)) == false)
            {
                goto label_12;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_9:
            val_7 = new object[1];
            val_7[0] = 丘专丈与三专丈丈专;
            val_8 = "SendAnalytics: bonus with id \'{0}\' not found";
            goto label_20;
            label_12:
            object[] val_5 = new object[1];
            val_7 = val_5;
            val_7[0] = 丘专丈与三专丈丈专;
            val_8 = "SendAnalytics fail, bonus with id \'{0}\'";
            label_20:
            UnityEngine.Debug.LogErrorFormat(format:  val_8, args:  val_5);
            label_6:
            val_6 = 0;
            return (bool)val_6;
        }
        public static bool 丒丛丐丐丑丈世专丑(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            object val_14;
            var val_148;
            var val_160;
            var val_161;
            var val_162;
            var val_163;
            System.Object[] val_164;
            var val_165;
            var val_166;
            var val_167;
            var val_168;
            InappRememberedBonus val_169;
            string val_170;
            var val_171;
            var val_172;
            var val_173;
            var val_174;
            System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_176;
            string val_177;
            var val_178;
            System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_180;
            string val_181;
            System.Func<Rilisoft.GameCurrencyData, System.Boolean> val_182;
            int val_183;
            var val_184;
            var val_188;
            var val_189;
            var val_190;
            var val_191;
            InappRememberedBonus val_192;
            string val_193;
            InappRememberedBonus val_194;
            string val_195;
            InappRememberedBonus val_196;
            string val_197;
            InappRememberedBonus val_198;
            InappRememberedBonus val_199;
            var val_200;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_202;
            InappRememberedBonus val_203;
            InappRememberedBonus val_204;
            InappRememberedBonus val_205;
            object val_206;
            var val_207;
            InappRememberedBonus val_208;
            var val_209;
            var val_210;
            int val_211;
            var val_212;
            var val_213;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_215;
            InappRememberedBonus val_217;
            string val_218;
            if(丄上专丄七丘丕万东 == null)
            {
                goto label_1;
            }
            
            new 丌与丛丕业丈不丐世.七世丅不丅且三丄丕() = new System.Object();
            .世丈三丐丞一丒丛不 = 0;
            val_160 = null;
            val_160 = null;
            int val_2 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丄上专丄七丘丕万东 + 192);
            if(((System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丄上专丄七丘丕万东 + 192)) & val_2) == 1)
            {
                goto label_7;
            }
            
            PGCompany.丌与丛丕业丈不丐世.丅丈一丏不丁且且下(: ref  new 丛与丒丞丁丛上丄丆() {丄上专丄七丘丕万东 = 丄上专丄七丘丕万东});
            val_161 = null;
            if(val_2 == 1)
            {
                goto label_10;
            }
            
            val_162 = null;
            val_163 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(val_2)) << 2);
            goto label_15;
            label_1:
            val_164 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "SendAnalytics: inappId.IsNullOrEmpty()", args:  val_164);
            goto label_805;
            label_7:
            val_165 = 0;
            goto label_19;
            label_29:
            val_166 = null;
            val_166 = null;
            if((System.String.op_Equality(a:  StoreKitEventListener.业万专三一丟且丘业.Length + 32, b:  丄上专丄七丘丕万东 + 192)) == true)
            {
                goto label_25;
            }
            
            val_165 = 1;
            label_19:
            val_167 = null;
            val_167 = null;
            if(val_165 < StoreKitEventListener.业万专三一丟且丘业.Length)
            {
                goto label_29;
            }
            
            if(new 丌与丛丕业丈不丐世.七世丅不丅且三丄丕() != null)
            {
                goto label_61;
            }
            
            goto label_31;
            label_10:
            val_168 = null;
            val_163 = 丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + (((long)(int)(val_3)) << 2);
            label_15:
            .世丈三丐丞一丒丛不 = ;
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_8 = System.DateTime.UtcNow;
            decimal val_9 = System.Decimal.op_Implicit(value:  (丌与丛丕业丈不丐世.七世丅不丅且三丄丕)[1152921555504137136].世丈三丐丞一丒丛不);
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_8.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid});
            val_169 = 丄上专丄七丘丕万东;
            if(val_169 == 0)
            {
                goto label_45;
            }
            
            val_170 = mem[丄上专丄七丘丕万东 + 192];
            val_170 = 丄上专丄七丘丕万东 + 192;
            goto label_46;
            label_45:
            val_170 = mem[丄上专丄七丘丕万东 + 192];
            val_170 = 丄上专丄七丘丕万东 + 192;
            if(丄上专丄七丘丕万东 == 0)
            {
                goto label_47;
            }
            
            val_169 = 丄上专丄七丘丕万东;
            label_46:
            label_55:
            StoreKitEventListener.丘万万丅丘丟丛丈业(丅丞丂丟丟且丅丆丅:  val_170, 世丕丅与丆丄丗丐万:  丄上专丄七丘丕万东 + 168, 丑丁丐丏业丗一丏丈:  丄上专丄七丘丕万东 + 96);
            Rilisoft.一丟专且三万丞丁丂.丒丌万丏世丌与丒丅(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            val_164 = mem[丄上专丄七丘丕万东 + 192];
            val_164 = 丄上专丄七丘丕万东 + 192;
            Rilisoft.一丟专且三万丞丁丂.万丘不丟丒下丌丞丒(丘专丈与三专丈丈专:  val_164, 丐上不丁七丐丂下丂:  X10Manager.丑七不且上丗丁一世().上丏丐下上专丄不丛());
            label_877:
            val_171 = 1;
            return (bool)val_171;
            label_47:
            if(丄上专丄七丘丕万东 != 0)
            {
                goto label_55;
            }
            
            goto label_55;
            label_25:
            val_172 = null;
            val_172 = null;
            .世丈三丐丞一丒丛不 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32;
            if(new 丌与丛丕业丈不丐世.七世丅不丅且三丄丕() != null)
            {
                goto label_61;
            }
            
            label_31:
            label_61:
            val_173 = null;
            val_173 = null;
            PGCompany.丌与丛丕业丈不丐世.且丑丑丟丄丘世一丐 = (丌与丛丕业丈不丐世.七世丅不丅且三丄丕)[1152921555504137136].世丈三丐丞一丒丛不;
            if((丄上专丄七丘丕万东 + 128) == 0)
            {
                goto label_65;
            }
            
            List.Enumerator<T> val_12 = 丄上专丄七丘丕万东 + 128.GetEnumerator();
            label_126:
            if(((-642365632) & 1) == 0)
            {
                goto label_68;
            }
            
            if(val_14.丐丏七丌丕丗业且上() == null)
            {
                goto label_69;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  0)) == false)
            {
                goto label_72;
            }
            
            val_174 = null;
            val_174 = null;
            val_176 = 丌与丛丕业丈不丐世.<>c.<>9__2_3;
            if(val_176 == null)
            {
                    val_176 = null;
                val_176 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  丌与丛丕业丈不丐世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌与丛丕业丈不丐世.<>c::世丑业不世与丅丞业(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
                丌与丛丕业丈不丐世.<>c.<>9__2_3 = val_176;
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_20 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丟丛上丅七丂七丛下(), predicate:  null);
            if(val_20 == null)
            {
                goto label_81;
            }
            
            val_177 = val_20.业上丙丞丐丄丆丅七();
            goto label_82;
            label_69:
            UnityEngine.Debug.LogError(message:  "nullable EventCurrencies bonus");
            goto label_126;
            label_72:
            val_177 = 0;
            goto label_98;
            label_81:
            val_177 = 0;
            label_82:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_177)) != false)
            {
                    val_178 = null;
                val_178 = null;
                val_180 = 丌与丛丕业丈不丐世.<>c.<>9__2_4;
                if(val_180 == null)
            {
                    val_180 = null;
                val_180 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  丌与丛丕业丈不丐世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌与丛丕业丈不丐世.<>c::东与丌丘业下丄丙丁(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
                丌与丛丕业丈不丐世.<>c.<>9__2_4 = val_180;
            }
            
                Rilisoft.丛且世丐丆上七业丁 val_26 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丟丛上丅七丂七丛下(), predicate:  null);
                if(val_26 != null)
            {
                    val_177 = val_26.业上丙丞丐丄丆丅七();
            }
            
            }
            
            label_98:
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_177)) == true) || ((丄上专丄七丘丕万东 + 200) == 0))
            {
                goto label_126;
            }
            
            Rilisoft.一丟专且三万丞丁丂.丘丂专丌丁世不丆丑(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            bool val_29 = System.String.op_Equality(a:  丄上专丄七丘丕万东 + 192, b:  "sniper_tournament");
            if(val_29 != true)
            {
                    if((System.String.op_Equality(a:  val_29, b:  "sniper2_roulette")) == false)
            {
                goto label_108;
            }
            
            }
            
            val_181 = "Sniper_";
            goto label_109;
            label_108:
            val_181 = 0;
            label_109:
            Rilisoft.一丟专且三万丞丁丂.丗与丁丑丗世丛专丝(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192, 丂业丕业丂丅丙一丛:  val_181);
            Rilisoft.丛且世丐丆上七业丁 val_32 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丈专丄与丟丄下丙丏();
            if(((val_32 == null) || (val_32.业丈丂丏上丄丘丐丞() == null)) || (val_32.业丈丂丏上丄丘丐丞().Count < 1))
            {
                goto label_126;
            }
            
            val_182 = (丌与丛丕业丈不丐世.七世丅不丅且三丄丕)[1152921555504137136].丟丕丁与丝丝丂下丕;
            if(val_182 == null)
            {
                    val_182 = null;
                val_182 = new System.Func<Rilisoft.GameCurrencyData, System.Boolean>(object:  new 丌与丛丕业丈不丐世.七世丅不丅且三丄丕(), method:  System.Boolean 丌与丛丕业丈不丐世.七世丅不丅且三丄丕::丌丛丒丘下丗东丑丑(Rilisoft.GameCurrencyData 七丏丄丅丌业与且丙));
                .丟丕丁与丝丝丂下丕 = val_182;
            }
            
            Rilisoft.GameCurrencyData val_38 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameCurrencyData>(source:  val_32.业丈丂丏上丄丘丐丞(), predicate:  null);
            if(val_38 == null)
            {
                goto label_126;
            }
            
            Rilisoft.一丟专且三万丞丁丂.丘丂专丌丁世不丆丑(东业七丒专丌丘丏丛:  val_32.业丈丂丏上丄丘丐丞().IndexOf(item:  val_38));
            goto label_126;
            label_65:
            val_183 = 0;
            goto label_127;
            label_68:
            val_184 = 0;
            val_183 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (848 != 848))
            {
                goto label_215;
            }
            
            label_127:
            val_184 = 0;
            goto label_217;
            label_215:
            if( != 0)
            {
                    val_183 = 0;
            }
            
            label_217:
            val_188 = null;
            val_188 = null;
            if((System.String.op_Equality(a:  丄上专丄七丘丕万东 + 16, b:  与丂丏丛丞丞丒丟丄.丐上丆三丛不业丌丆)) == false)
            {
                goto label_221;
            }
            
            val_189 = null;
            val_189 = null;
            Rilisoft.一丟专且三万丞丁丂.与世丞丘丒丄一业丑 = true;
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_45 = System.DateTime.UtcNow;
            decimal val_46 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_45.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_46.flags, hi = val_46.hi, lo = val_46.lo, mid = val_46.mid});
            val_190 = null;
            val_190 = null;
            Rilisoft.一丟专且三万丞丁丂.与世丞丘丒丄一业丑 = false;
            goto label_877;
            label_221:
            if((丄上专丄七丘丕万东 + 268) >= 1)
            {
                    Rilisoft.一丟专且三万丞丁丂.丗一下丈上下丐丐且(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
                Rilisoft.一丟专且三万丞丁丂.且世丌三世七丂丒丏();
            }
            
            if(((丄上专丄七丘丕万东 + 56) >= 1) && ((丄上专丄七丘丕万东 + 152) == 0))
            {
                    StoreKitEventListener.丏丐丛上三东丛丑丟();
                StoreKitEventListener.丛三一丞与专东丘一();
                System.DateTime val_48 = System.DateTime.UtcNow;
                decimal val_49 = System.Decimal.op_Implicit(value:  "fa-IR");
                PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_48.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_49.flags, hi = val_49.hi, lo = val_49.lo, mid = val_49.mid});
                Rilisoft.一丟专且三万丞丁丂.下丈丏专丟三丕下专(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            }
            
            if((丄上专丄七丘丕万东 + 200) == 0)
            {
                    if((丄上专丄七丘丕万东 + 201) == 0)
            {
                goto label_262;
            }
            
            }
            
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_51 = System.DateTime.UtcNow;
            decimal val_52 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_51.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_52.flags, hi = val_52.hi, lo = val_52.lo, mid = val_52.mid});
            goto label_877;
            label_262:
            if((丄上专丄七丘丕万东 + 88) < 1)
            {
                goto label_275;
            }
            
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_54 = System.DateTime.UtcNow;
            decimal val_55 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_54.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_55.flags, hi = val_55.hi, lo = val_55.lo, mid = val_55.mid});
            Rilisoft.一丟专且三万丞丁丂.一丙丏丂一丌丌丏丗(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            Rilisoft.一丟专且三万丞丁丂.丌丅三且万丄丁万丄(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            goto label_877;
            label_275:
            if(((丄上专丄七丘丕万东 + 56) < 1) || ((丄上专丄七丘丕万东 + 152) == 0))
            {
                goto label_294;
            }
            
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_57 = System.DateTime.UtcNow;
            decimal val_58 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_57.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_58.flags, hi = val_58.hi, lo = val_58.lo, mid = val_58.mid});
            val_14 = "fa-IR";
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_61 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_61 == null)
            {
                goto label_306;
            }
            
            var val_63 = (val_61.专丟专一丒且丘与丌() == 100) ? 1 : 0;
            goto label_307;
            label_294:
            if((丄上专丄七丘丕万东 + 356) < 1)
            {
                goto label_309;
            }
            
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_65 = System.DateTime.UtcNow;
            decimal val_66 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_65.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_66.flags, hi = val_66.hi, lo = val_66.lo, mid = val_66.mid});
            goto label_877;
            label_309:
            if((丄上专丄七丘丕万东 + 84) < 1)
            {
                goto label_322;
            }
            
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_68 = System.DateTime.UtcNow;
            decimal val_69 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_68.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_69.flags, hi = val_69.hi, lo = val_69.lo, mid = val_69.mid});
            goto label_877;
            label_306:
            val_191 = 0;
            label_307:
            Rilisoft.一丟专且三万丞丁丂.上丕丁专三丗丝万丆(丞丙丕不丕丆丁下万:  false, 丆且丁丒丒丆丁三丆:  "Currency Bought", 丙业与丙丗丝不丈东:  System.String.Format(format:  "bp_currency_{0}", arg0:  val_14));
            Rilisoft.一丟专且三万丞丁丂.下丈丏专丟三丕下专(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            goto label_877;
            label_322:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 64)) == false)
            {
                goto label_373;
            }
            
            if((丄上专丄七丘丕万东 + 272) < 1)
            {
                goto label_343;
            }
            
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_72 = System.DateTime.UtcNow;
            decimal val_73 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_72.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_73.flags, hi = val_73.hi, lo = val_73.lo, mid = val_73.mid});
            val_192 = 丄上专丄七丘丕万东;
            if(val_192 == 0)
            {
                goto label_354;
            }
            
            val_193 = mem[丄上专丄七丘丕万东 + 192];
            val_193 = 丄上专丄七丘丕万东 + 192;
            goto label_371;
            label_343:
            if((丄上专丄七丘丕万东 + 244) < 1)
            {
                goto label_357;
            }
            
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_75 = System.DateTime.UtcNow;
            decimal val_76 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_75.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_76.flags, hi = val_76.hi, lo = val_76.lo, mid = val_76.mid});
            val_194 = 丄上专丄七丘丕万东;
            if(val_194 == 0)
            {
                goto label_368;
            }
            
            val_195 = mem[丄上专丄七丘丕万东 + 192];
            val_195 = 丄上专丄七丘丕万东 + 192;
            goto label_428;
            label_354:
            val_193 = mem[丄上专丄七丘丕万东 + 192];
            val_193 = 丄上专丄七丘丕万东 + 192;
            if(丄上专丄七丘丕万东 == 0)
            {
                goto label_370;
            }
            
            val_192 = 丄上专丄七丘丕万东;
            goto label_371;
            label_357:
            if((丄上专丄七丘丕万东 + 136) < 1)
            {
                goto label_373;
            }
            
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            System.DateTime val_78 = System.DateTime.UtcNow;
            decimal val_79 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_78.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_79.flags, hi = val_79.hi, lo = val_79.lo, mid = val_79.mid});
            val_196 = 丄上专丄七丘丕万东;
            if(val_196 == 0)
            {
                goto label_384;
            }
            
            val_197 = mem[丄上专丄七丘丕万东 + 192];
            val_197 = 丄上专丄七丘丕万东 + 192;
            goto label_473;
            label_373:
            Rilisoft.一丟专且三万丞丁丂.一丂丌丏丟与七万业(丄丒丌上丁丂不万东:  "fa-IR", 丘丘丕丄丑丗丕一世:  Rilisoft.OfferPackWindow.业丙丕丘东丒东丆丙());
            Rilisoft.一丟专且三万丞丁丂.丏丆与丗专丒丞丛丞(丄丒丌上丁丂不万东:  "fa-IR", 万丌丐专一丑一丟上:  Rilisoft.OfferPackWindow.丏丘丐丄与丛业东世());
            val_198 = 丄上专丄七丘丕万东;
            if(丄上专丄七丘丕万东 == 0)
            {
                    val_198 = 丄上专丄七丘丕万东;
            }
            
            if((丄上专丄七丘丕万东 + 76) == 0)
            {
                goto label_392;
            }
            
            val_199 = val_198;
            if(val_198 == 0)
            {
                    val_199 = 丄上专丄七丘丕万东;
            }
            
            if((丄上专丄七丘丕万东 + 76) != 40)
            {
                goto label_394;
            }
            
            Rilisoft.一丟专且三万丞丁丂.丄丌丂万丂丌与丞丂(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            if(((丄上专丄七丘丕万东 + 344) != 0) && ((System.Linq.Enumerable.Any<System.String>(source:  丄上专丄七丘丕万东 + 344)) != false))
            {
                    System.Func<System.String, Rilisoft.OfferItem> val_83 = new System.Func<System.String, Rilisoft.OfferItem>(object:  0, method:  static Rilisoft.OfferItem Rilisoft.OfferItem::东丝丄丈丆三丘与丈(string 丞丕丒专一下丙业上));
                val_200 = null;
                val_200 = null;
                val_202 = 丌与丛丕业丈不丐世.<>c.<>9__2_6;
                if(val_202 == null)
            {
                    val_202 = null;
                val_202 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丌与丛丕业丈不丐世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌与丛丕业丈不丐世.<>c::丄丟丏丂东丒丞丒丁(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                丌与丛丕业丈不丐世.<>c.<>9__2_6 = val_202;
            }
            
                System.Collections.Generic.List<TSource> val_87 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.String, Rilisoft.OfferItem>(source:  丄上专丄七丘丕万东 + 344, selector:  null), predicate:  null));
                if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_87)) != false)
            {
                    Rilisoft.OfferItem val_89 = System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  val_87);
                if(val_89 != null)
            {
                    val_14 = "fa-IR";
                Rilisoft.一丟专且三万丞丁丂.且丐业一不丄丟丅与(丞一丁业丄一一业且:  val_89.Id, 丏丂不专上丘丂不丅:  System.String.Format(format:  "{0}_{1}", arg0:  "Real", arg1:  val_14));
            }
            
            }
            
            }
            
            Rilisoft.一丟专且三万丞丁丂.丆专丛下东丌丛与丅(且丗丅上丄丕且下上:  "Event Shop");
            goto label_461;
            label_392:
            if(val_198 == 0)
            {
                goto label_415;
            }
            
            goto label_426;
            label_394:
            val_203 = val_199;
            if(val_199 == 0)
            {
                    val_203 = 丄上专丄七丘丕万东;
            }
            
            if((丄上专丄七丘丕万东 + 76) != 10)
            {
                goto label_418;
            }
            
            if(val_203 == 0)
            {
                goto label_419;
            }
            
            goto label_445;
            label_418:
            val_204 = val_203;
            if(val_203 == 0)
            {
                    val_204 = 丄上专丄七丘丕万东;
            }
            
            if((丄上专丄七丘丕万东 + 76) != 60)
            {
                goto label_422;
            }
            
            if(val_204 == 0)
            {
                goto label_423;
            }
            
            goto label_478;
            label_415:
            if(丄上专丄七丘丕万东 == 0)
            {
                goto label_425;
            }
            
            val_198 = 丄上专丄七丘丕万东;
            goto label_426;
            label_368:
            val_195 = mem[丄上专丄七丘丕万东 + 192];
            val_195 = 丄上专丄七丘丕万东 + 192;
            if(丄上专丄七丘丕万东 == 0)
            {
                goto label_427;
            }
            
            val_194 = 丄上专丄七丘丕万东;
            goto label_428;
            label_370:
            val_192 = 0;
            label_371:
            Rilisoft.一丟专且三万丞丁丂.与一丐丕丝丁丝丂下(丘专丈与三专丈丈专:  val_193, 三不三丟专丘东东丂:  4);
            System.Collections.Generic.List<System.String> val_92 = new System.Collections.Generic.List<System.String>();
            val_14 = 1070;
            val_205 = 丄上专丄七丘丕万东;
            if(val_205 != 0)
            {
                    val_206 = mem[丄上专丄七丘丕万东 + 280];
                val_206 = 丄上专丄七丘丕万东 + 280;
            }
            else
            {
                    val_206 = mem[丄上专丄七丘丕万东 + 280];
                val_206 = 丄上专丄七丘丕万东 + 280;
                if(丄上专丄七丘丕万东 != 0)
            {
                    val_205 = 丄上专丄七丘丕万东;
            }
            else
            {
                    val_205 = 0;
            }
            
            }
            
            null.Add(item:  System.String.Format(format:  "{0}:{1}:{2}", arg0:  val_14, arg1:  val_206, arg2:  36));
            System.DateTime val_95 = System.DateTime.UtcNow;
            val_207 = null;
            val_207 = null;
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().丅丅丙丝丆丏丐与丞(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_95.dateData}, 世丈三丐丞一丒丛不:  PGCompany.丌与丛丕业丈不丐世.且丑丑丟丄丘世一丐, 丈丕三丆丟且丆一上:  null);
            goto label_877;
            label_422:
            val_208 = val_204;
            if(val_204 == 0)
            {
                    val_208 = 丄上专丄七丘丕万东;
            }
            
            if((丄上专丄七丘丕万东 + 76) != 80)
            {
                goto label_441;
            }
            
            if(val_208 == 0)
            {
                goto label_442;
            }
            
            goto label_553;
            label_419:
            if(丄上专丄七丘丕万东 == 0)
            {
                goto label_444;
            }
            
            val_203 = 丄上专丄七丘丕万东;
            goto label_445;
            label_425:
            val_198 = 0;
            label_426:
            if((((System.String.op_Inequality(a:  11993091, b:  "lobby-item")) != false) && ((丄上专丄七丘丕万东 + 404) == 0)) && ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 368)) != false))
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 392)) != false)
            {
                    Rilisoft.一丟专且三万丞丁丂.丅业不丐丞丟丂丐丝(丄丒丌上丁丂不万东:  丄上专丄七丘丕万东);
            }
            
            }
            
            Rilisoft.一丟专且三万丞丁丂.丛丟世专丞下丞丝丞(丂丈丗丄不丅丅丙丒:  丄上专丄七丘丕万东);
            goto label_461;
            label_441:
            if((丄上专丄七丘丕万东 + 76) != 100)
            {
                goto label_461;
            }
            
            decimal val_101 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().丌丅业专丑专专万丑();
            Rilisoft.一丟专且三万丞丁丂.专丙世与三一丌三丞(丙丂丏丛丌丏下丝不:  ExperienceController.丞丞丘业东丙丏七丌(), 丒丐丟丌丂上不专丟:  new System.Decimal() {flags = val_101.flags, hi = val_101.hi, lo = val_101.lo, mid = val_101.mid});
            goto label_461;
            label_384:
            val_197 = mem[丄上专丄七丘丕万东 + 192];
            val_197 = 丄上专丄七丘丕万东 + 192;
            if(丄上专丄七丘丕万东 == 0)
            {
                goto label_472;
            }
            
            val_196 = 丄上专丄七丘丕万东;
            goto label_473;
            label_427:
            val_194 = 0;
            label_428:
            Rilisoft.一丟专且三万丞丁丂.丄丈丞丒与丐且万世(丘专丈与三专丈丈专:  val_195, 世三丆丞东丟丞丏丅:  456);
            goto label_877;
            label_423:
            if(丄上专丄七丘丕万东 == 0)
            {
                goto label_477;
            }
            
            val_204 = 丄上专丄七丘丕万东;
            goto label_478;
            label_444:
            val_203 = 0;
            label_445:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            Rilisoft.一丟专且三万丞丁丂.一上东丝丅丒丕丟上(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            label_584:
            label_461:
            Rilisoft.一丟专且三万丞丁丂.丝丄专丕丒专丄下丝(丝东万丌东丂与丏丄:  0 ^ 1, 一不丟上丙丌七丆丙:  Rilisoft.OfferPackWindow.丘丛丏业丑上下丗丝());
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 64)) != false)
            {
                    Rilisoft.PlayerPaymentType val_108 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丛丄丈不丁丈丝不丛();
            }
            
            new System.Action() = new System.Action(object:  123444064, method:  System.Void 丌与丛丕业丈不丐世.七世丅不丅且三丄丕::丘三一丄丝丑丟不丏());
            Rilisoft.丗下丙丅且丐丞丙世.一且业丑下三东三业(丙业与丙丗丝不丈东:  new System.Action());
            System.DateTime val_113 = System.DateTime.UtcNow;
            decimal val_114 = System.Decimal.op_Implicit(value:  "fa-IR");
            PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_113.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_114.flags, hi = val_114.hi, lo = val_114.lo, mid = val_114.mid});
            new System.Action() = new System.Action(object:  123444064, method:  System.Void 丌与丛丕业丈不丐世.七世丅不丅且三丄丕::丘三一丄丝丑丟不丏());
            Rilisoft.丗下丙丅且丐丞丙世.且丒丅丟丈东丐七业(丙业与丙丗丝不丈东:  new System.Action());
            Rilisoft.一丟专且三万丞丁丂.丌丟丗丝世与丁三丞(丈且丟丗丈专丒与丁:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丘七丒丕丏东丈与七(), 三丗丘丏丗丒丗东丅:  (static_value_075B9B74 == true) ? 1 : 0, 丗丟丁丐与下丙丕丛:  丄上专丄七丘丕万东 + 64, 丐丞丏丞丟且丑七丟:  val_203 + 72.ToString(), 世丈三丐丞一丒丛不:  "fa-IR", 上世且丌丏丌三丞丆:  false);
            PGCompany.丌与丛丕业丈不丐世.丅丈一丏不丁且且下(: ref  new 丛与丒丞丁丛上丄丆() {丄上专丄七丘丕万东 = 丄上专丄七丘丕万东});
            val_209 = null;
            val_209 = null;
            if((BalanceController.一万丌丄丟丛丑丌七.ContainsKey(key:  丄上专丄七丘丕万东 + 176)) != false)
            {
                    val_210 = null;
                val_210 = null;
                if((BalanceController.一万丌丄丟丛丑丌七.Item[丄上专丄七丘丕万东 + 176]) != null)
            {
                    val_211 = val_118.currentIndex;
            }
            else
            {
                    val_211 = val_118.currentIndex;
            }
            
                mem2[0] = val_211 + 1;
            }
            
            if((丄上专丄七丘丕万东 + 208) != 0)
            {
                    if((丄上专丄七丘丕万东 + 208.Count) == 1)
            {
                    bool val_123 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丒丟丝丑丏丒丅丞一(丞一丁业丄一一业且:  丄上专丄七丘丕万东 + 208.Item[0]);
            }
            
            }
            
            if(((丄上专丄七丘丕万东 + 336) == 0) || ((丄上专丄七丘丕万东 + 336.Count) < 1))
            {
                goto label_819;
            }
            
            List.Enumerator<T> val_125 = 丄上专丄七丘丕万东 + 336.GetEnumerator();
            label_550:
            if(((-642365664) & 1) == 0)
            {
                goto label_537;
            }
            
            Rilisoft.OfferItem val_128 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  36.丐丏七丌丕丗业且上());
            if(val_128 == null)
            {
                goto label_550;
            }
            
            if(val_128.Type == 1010)
            {
                    val_212 = null;
                val_212 = null;
                Rilisoft.一丟专且三万丞丁丂.丄丌专三丅下丞丄且 = 1;
            }
            
            if((val_128.Type != 1140) || ((丄上专丄七丘丕万东 + 76) == 80))
            {
                goto label_550;
            }
            
            Rilisoft.一丟专且三万丞丁丂.不三丆丟丟三丌丈上(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            goto label_550;
            label_537:
            val_184 = 0 + 1;
            mem2[0] = 3133;
            goto label_551;
            label_442:
            if(丄上专丄七丘丕万东 == 0)
            {
                goto label_552;
            }
            
            val_208 = 丄上专丄七丘丕万东;
            goto label_553;
            label_472:
            val_196 = 0;
            label_473:
            Rilisoft.一丟专且三万丞丁丂.丞丘东丂丌丅业丆与(丘专丈与三专丈丈专:  val_197, 丕丁下丌不万丅丞丛:  123438416);
            goto label_877;
            label_477:
            val_204 = 0;
            label_478:
            string val_132 = val_204 + 72.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            if(((丄上专丄七丘丕万东 + 344) != 0) && ((System.Linq.Enumerable.Any<System.String>(source:  丄上专丄七丘丕万东 + 344)) != false))
            {
                    System.Func<System.String, Rilisoft.OfferItem> val_134 = new System.Func<System.String, Rilisoft.OfferItem>(object:  0, method:  static Rilisoft.OfferItem Rilisoft.OfferItem::东丝丄丈丆三丘与丈(string 丞丕丒专一下丙业上));
                val_213 = null;
                val_213 = null;
                val_215 = 丌与丛丕业丈不丐世.<>c.<>9__2_7;
                if(val_215 == null)
            {
                    val_215 = null;
                val_215 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丌与丛丕业丈不丐世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌与丛丕业丈不丐世.<>c::丐丅东丗业丂丘丘丆(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                丌与丛丕业丈不丐世.<>c.<>9__2_7 = val_215;
            }
            
                Rilisoft.一丟专且三万丞丁丂.丟丅不丙万丌丏七丞(丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192, 丑七不与丛丆一丂丞:  System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.String, Rilisoft.OfferItem>(source:  丄上专丄七丘丕万东 + 344, selector:  null), predicate:  null)));
            }
            
            if((丄上专丄七丘丕万东 + 80) != 70)
            {
                goto label_584;
            }
            
            Rilisoft.一丟专且三万丞丁丂.丒一丗七丆业丝丞丟(丙丂丏丛丌丏下丝不:  ExperienceController.丞丞丘业东丙丏七丌(), 世丈三丐丞一丒丛不:  "fa-IR");
            goto label_584;
            label_552:
            val_208 = 0;
            label_553:
            string val_141 = val_208 + 72.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            Rilisoft.一丟专且三万丞丁丂.丟丒丆丛丈不丆且丈(丙丂丏丛丌丏下丝不:  ExperienceController.丞丞丘业东丙丏七丌(), 丘专丈与三专丈丈专:  丄上专丄七丘丕万东 + 192);
            goto label_584;
            label_551:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (848 == 3133))
            {
                    var val_162 = 0;
                val_162 = val_162 ^ 0;
                val_184 =  + val_162;
            }
            else
            {
                    if( != 0)
            {
                    val_183 = 0;
            }
            
            }
            
            label_819:
            if(((丄上专丄七丘丕万东 + 208) == 0) || ((System.Linq.Enumerable.Any<System.String>(source:  丄上专丄七丘丕万东 + 208)) == false))
            {
                goto label_862;
            }
            
            List.Enumerator<T> val_146 = 丄上专丄七丘丕万东 + 208.GetEnumerator();
            label_841:
            if(((-642365664) & 1) == 0)
            {
                goto label_826;
            }
            
            string val_149 = val_148.丐丏七丌丕丗业且上();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_149)) == true)
            {
                goto label_841;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_152 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_149);
            if(val_152 == null)
            {
                goto label_841;
            }
            
            Rilisoft.LobbyItemsBundle val_155 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丝一丗丄与丛丏丘丛(丞丅上丏丂且下丅与:  val_152.业上丙丞丐丄丆丅七());
            if(val_155 == null)
            {
                goto label_841;
            }
            
            var val_163 = 0;
            val_163 = val_163 + 1;
            Rilisoft.一丟专且三万丞丁丂.万丁七业丈上丛且丛(丘专丈与三专丈丈专:  val_155.MarketProduct.业上丙丞丐丄丆丅七(), 且丛丏丄丟丐丝三一:  val_155.Id);
            goto label_841;
            label_826:
             =  + 1;
            mem2[0] = 3298;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_858;
            }
            
            if( == 0)
            {
                goto label_862;
            }
            
            if((1152921555504088656 + ((val_184 + 1)) << 2) != 3298)
            {
                goto label_860;
            }
            
            goto label_862;
            label_858:
            if( == 0)
            {
                goto label_862;
            }
            
            label_860:
            label_862:
            if(((丄上专丄七丘丕万东 + 116) >= 1) && ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 120)) != false))
            {
                    val_217 = 丄上专丄七丘丕万东;
                if(val_217 != 0)
            {
                    val_218 = mem[丄上专丄七丘丕万东 + 192];
                val_218 = 丄上专丄七丘丕万东 + 192;
            }
            else
            {
                    val_218 = mem[丄上专丄七丘丕万东 + 192];
                val_218 = 丄上专丄七丘丕万东 + 192;
                if(丄上专丄七丘丕万东 != 0)
            {
                    val_217 = 丄上专丄七丘丕万东;
            }
            else
            {
                    val_217 = 0;
            }
            
            }
            
                Rilisoft.一丟专且三万丞丁丂.丈丛一一丛一丆一丐(丘专丈与三专丈丈专:  val_218, 丕丁下丌不万丅丞丛:  1);
            }
            
            PGCompany.丌与丛丕业丈不丐世.丕丛丈丛丄丒上上丏(丂丈丗丄不丅丅丙丒:  丄上专丄七丘丕万东);
            PGCompany.丌与丛丕业丈不丐世.且丑丑丟丄丘世一丐 = 0;
            goto label_877;
            label_805:
            val_171 = 0;
            return (bool)val_171;
        }
        internal static void 丟丙丒三丛上丙一世(System.Action<string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.丌与丛丕业丈不丐世.丙丌丄丌丕丅一丁丑, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丌与丛丕业丈不丐世.丙丌丄丌丕丅一丁丑 != 1152921505607434248);
        
        }
        internal static void 丌丗丞丑丗丑世世七(System.Action<string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.丌与丛丕业丈不丐世.丙丌丄丌丕丅一丁丑, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丌与丛丕业丈不丐世.丙丌丄丌丕丅一丁丑 != 1152921505607434248);
        
        }
        internal static void 丅丂且三丂丟丒业丕(System.Action<InappRememberedBonus> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.丌与丛丕业丈不丐世.丘丈丈万丟丛丄丏丟, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丌与丛丕业丈不丐世.丘丈丈万丟丛丄丏丟 != 1152921505607434256);
        
        }
        internal static void 丟丗丄丟东丆丈与丑(System.Action<InappRememberedBonus> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.丌与丛丕业丈不丐世.丘丈丈万丟丛丄丏丟, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丌与丛丕业丈不丐世.丘丈丈万丟丛丄丏丟 != 1152921505607434256);
        
        }
        internal static void 且东丞三丄丕丑世丐(System.Action<InappRememberedBonus> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.丌与丛丕业丈不丐世.丛丐且下世丕上丟丅, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丌与丛丕业丈不丐世.丛丐且下世丕上丟丅 != 1152921505607434264);
        
        }
        internal static void 丕上世丗业丆丟丕丏(System.Action<InappRememberedBonus> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.丌与丛丕业丈不丐世.丛丐且下世丕上丟丅, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.丌与丛丕业丈不丐世.丛丐且下世丕上丟丅 != 1152921505607434264);
        
        }
        public static InappRememberedBonus 丟丐丘且东丂丅业丆(string 丘专丈与三专丈丈专)
        {
            InappRememberedBonus val_13;
            string val_14;
            var val_15;
            var val_16;
            var val_17;
            val_14 = 丘专丈与三专丈丈专;
            UnityEngine.Debug.Log(message:  "[TEST] call InAppProvider.InappRememberedBonus()");
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_14)) == false)
            {
                goto label_5;
            }
            
            label_29:
            丌与丛丕业丈不丐世.丏丐丙丆与与丟丂丈.丆丟丟三丗东一丆三(丄丙下丝丛丒七丂丘:  "AddContent: inappId.IsNullOrEmpty()");
            val_15 = 0;
            return (InappRememberedBonus)(val_5 != true) ? (val_13) : 0;
            label_5:
            if((AbstractBankView.一丄丂丛业丘东丌东(丄丒丌上丁丂不万东:  val_14)) <= 1)
            {
                    丅且东丙业丏丛东丛 val_3 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世();
                val_16 = null;
                val_16 = null;
                if(PGCompany.丌与丛丕业丈不丐世.丙丌丄丌丕丅一丁丑 != null)
            {
                    PGCompany.丌与丛丕业丈不丐世.丙丌丄丌丕丅一丁丑.Invoke(obj:  val_14);
            }
            
            }
            
            val_13 = 一下丛与丛丛万万丏.丌七丑世世丛丑丛丕(丘专丈与三专丈丈专:  val_14);
            if(val_13 == null)
            {
                goto label_17;
            }
            
            bool val_5 = PGCompany.丌与丛丕业丈不丐世.丟丐丘且东丂丅业丆(丄上专丄七丘丕万东:  val_13);
            if(val_5 == false)
            {
                goto label_20;
            }
            
            UnityEngine.Debug.Log(message:  "[TEST] call StoreKitEventListener.CheckIfFirstTimePayment()");
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            goto label_25;
            label_17:
            一丅丌丁丙丈丙上丙 val_6 = AbstractBankView.一丄丂丛业丘东丌东(丄丒丌上丁丂不万东:  val_14);
            val_15 = 0;
            if(val_6 < 2)
            {
                    return (InappRememberedBonus)(val_5 != true) ? (val_13) : 0;
            }
            
            string val_7 = System.String.Format(format:  "AddContent: bonus with id \'{0}\' not found, bonus type: {1}", arg0:  val_14, arg1:  val_6);
            goto label_29;
            label_20:
            丌与丛丕业丈不丐世.丏丐丙丆与与丟丂丈.丆丟丟三丗东一丆三(丄丙下丝丛丒七丂丘:  "AddContent fail, bonus id \'" + val_14 + "\'");
            label_25:
            val_17 = null;
            val_17 = null;
            if(PGCompany.丌与丛丕业丈不丐世.丘丈丈万丟丛丄丏丟 != null)
            {
                    PGCompany.丌与丛丕业丈不丐世.丘丈丈万丟丛丄丏丟.Invoke(obj:  val_13);
            }
            
            val_14 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_4.OfferId);
            if(val_14 == null)
            {
                    return (InappRememberedBonus)(val_5 != true) ? (val_13) : 0;
            }
            
            Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丁万丝与丝丘东丆丝(丙业丞丑七丗下丟丌:  val_14, 丟与丗丙丐下且丄业:  0);
            return (InappRememberedBonus)(val_5 != true) ? (val_13) : 0;
        }
        public static bool 丟丐丘且东丂丅业丆(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  43);
            if(PGCompany.丌与丛丕业丈不丐世.丛丐且下世丕上丟丅 != null)
            {
                    PGCompany.丌与丛丕业丈不丐世.丛丐且下世丕上丟丅.Invoke(obj:  丄上专丄七丘丕万东);
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return (bool)PGCompany.丌与丛丕业丈不丐世.丞一丐丞丗丞东丆业(丄上专丄七丘丕万东:  丄上专丄七丘丕万东);
        }
        private static bool 丞一丐丞丗丞东丆业(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            丌丟丐丞三丘三丏丈 val_9;
            var val_35;
            var val_46;
            var val_55;
            var val_59;
            var val_69;
            string val_70;
            InappRememberedBonus val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_81;
            var val_82;
            InappRememberedBonus val_83;
            var val_84;
            InappRememberedBonus val_85;
            InappRememberedBonus val_86;
            var val_87;
            InappRememberedBonus val_88;
            var val_90;
            var val_91;
            var val_92;
            PGCompany.丏丈丈且东丅上丄丙 val_93;
            InappRememberedBonus val_94;
            丘丙且丏丌世丗上丁 val_95;
            val_69;
            val_71 = 丄上专丄七丘丕万东;
            if(val_71 == null)
            {
                    return (bool)val_71;
            }
            
            val_72 = 1152921516416995536;
            int val_1 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丄上专丄七丘丕万东.InappId);
            if((((System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丄上专丄七丘丕万东 + 192)) & val_1) == 1) || ((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.String>(丈丆丕与丒丌丘丕且:  丄上专丄七丘丕万东 + 376)) == false))
            {
                goto label_7;
            }
            
            PGCompany.丌与丛丕业丈不丐世.丗丒丟万丒丅一且丙(: ref  new 丕丛业丁丏下一七丘() {丄上专丄七丘丕万东 = val_71});
            val_73 = null;
            if(val_1 == 1)
            {
                goto label_10;
            }
            
            val_74 = null;
            System.Int32[] val_5 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(val_1)) << 2);
            val_70 = X10Manager.丑七不且上丗丁一世();
            val_70.上丟七丅丐与且丁东(世丈三丐丞一丒丛不:  (丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(val_1)) << 2) + 32);
            goto label_344;
            label_7:
            if((丄上专丄七丘丕万东 + 128) == 0)
            {
                goto label_18;
            }
            
            List.Enumerator<T> val_7 = 丄上专丄七丘丕万东 + 128.GetEnumerator();
            val_72 = 1152921538029493904;
            label_28:
            if(((-640610032) & 1) == 0)
            {
                goto label_21;
            }
            
            if(val_9.丐丏七丌丕丗业且上() == null)
            {
                goto label_22;
            }
            
            bool val_11 = PGCompany.丌与丛丕业丈不丐世.上且丅专丟丄且丅上(丟丟丄专上丟丁丐丝:  丄上专丄七丘丕万东 + 128, 丌丒丝东丌下丕丁丅:  val_10.m_stringLength);
            goto label_28;
            label_22:
            UnityEngine.Debug.LogError(message:  "nullable EventCurrencies bonus");
            goto label_28;
            label_18:
            val_75 = 0;
            goto label_29;
            label_10:
            val_76 = null;
            System.Int32[] val_12 = 丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + (((long)(int)(val_2)) << 2);
            val_70 = X10Manager.丑七不且上丗丁一世();
            val_70.万一不丒上下丟丏一(世丈三丐丞一丒丛不:  (丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + ((long)(int)(val_2)) << 2) + 32);
            goto label_344;
            label_21:
            val_77 = 0;
            val_75 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (289 != 289))
            {
                goto label_62;
            }
            
            label_29:
            val_77 = 0;
            goto label_64;
            label_62:
            if( != 0)
            {
                    val_75 = 0;
            }
            
            label_64:
            val_70 = mem[丄上专丄七丘丕万东 + 16];
            val_70 = 丄上专丄七丘丕万东 + 16;
            val_81 = null;
            val_81 = null;
            if((System.String.op_Equality(a:  val_70, b:  与丂丏丛丞丞丒丟丄.丐上丆三丛不业丌丆)) == false)
            {
                goto label_68;
            }
            
            val_82 = null;
            val_82 = null;
            Rilisoft.一丟专且三万丞丁丂.与世丞丘丒丄一业丑 = true;
            PGCompany.丌与丛丕业丈不丐世.丁丁丐丙丙世万七丂(丈丁丄丘丛世七丙丝:  丄上专丄七丘丕万东 + 288, 丝丗不东丙不三丄专:  true, 三万东丏一丛丐丛与:  false);
            PersConfigurator.与与丑丂丛上七上丗();
            goto label_344;
            label_68:
            if((丄上专丄七丘丕万东 + 268) >= 1)
            {
                    Rilisoft.Singleton<Rilisoft.VIPController>.Instance.丏与丑专下不下丗丁(与丈业丛丝丒丙一丏:  丄上专丄七丘丕万东 + 268);
            }
            
            if(((丄上专丄七丘丕万东 + 56) >= 1) && ((丄上专丄七丘丕万东 + 152) == 0))
            {
                    bool val_16 = BankController.东一且丝万一丆七丘(丌丒丝东丌下丕丁丅:  丄上专丄七丘丕万东 + 56, 三上丆世丞丏丁一上:  null, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0);
            }
            
            val_70 = val_71;
            if((丄上专丄七丘丕万东 + 200) != 0)
            {
                goto label_344;
            }
            
            val_70 = val_71;
            if((丄上专丄七丘丕万东 + 201) != 0)
            {
                goto label_344;
            }
            
            val_70 = val_71;
            if((丄上专丄七丘丕万东 + 88) < 1)
            {
                goto label_91;
            }
            
            label_344:
            val_71 = 1;
            return (bool)val_71;
            label_91:
            if(((丄上专丄七丘丕万东 + 56) >= 1) && ((丄上专丄七丘丕万东 + 152) != 0))
            {
                    bool val_17 = BankController.东一且丝万一丆七丘(丌丒丝东丌下丕丁丅:  丄上专丄七丘丕万东 + 56, 三上丆世丞丏丁一上:  null, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0);
                return (bool)val_71;
            }
            
            val_83 = val_71;
            if(val_71 == 0)
            {
                    val_83 = val_71;
            }
            
            if((丄上专丄七丘丕万东 + 356) < 1)
            {
                goto label_101;
            }
            
            丑丝丞丒丅丄万丒三.丕丆丁一万丗不世下(丌丒丝东丌下丕丁丅:  丄上专丄七丘丕万东 + 356);
            goto label_344;
            label_101:
            if((丄上专丄七丘丕万东 + 84) >= 1)
            {
                goto label_344;
            }
            
            val_84 = 1152921505284374528;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 64)) == false)
            {
                goto label_123;
            }
            
            val_85 = val_71;
            if(val_71 == 0)
            {
                    val_85 = val_71;
            }
            
            if((丄上专丄七丘丕万东 + 272) < 1)
            {
                goto label_113;
            }
            
            PGCompany.丌与丛丕业丈不丐世.丟丁业丄丅下七世且(丂丈丗丄不丅丅丙丒:  val_85, 下丐丐丂丗丁丂丈丝:  false);
            goto label_344;
            label_113:
            val_86 = val_85;
            if(val_85 == 0)
            {
                    val_86 = val_71;
            }
            
            if((丄上专丄七丘丕万东 + 244) < 1)
            {
                goto label_118;
            }
            
            PGCompany.丌与丛丕业丈不丐世.丂七丟丗下丘丒丞不(丂丈丗丄不丅丅丙丒:  val_86);
            goto label_344;
            label_118:
            val_84 = 1152921505284374528;
            if((丄上专丄七丘丕万东 + 136) < 1)
            {
                goto label_123;
            }
            
            PGCompany.丌与丛丕业丈不丐世.万且丏丂丙丅丝丛东(丂丈丗丄不丅丅丙丒:  val_71);
            goto label_344;
            label_123:
            if(((丄上专丄七丘丕万东 + 76) != 0) && ((丄上专丄七丘丕万东 + 76) == 120))
            {
                    if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) != 0)
            {
                    val_84 = 1152921505284374528;
                Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.东专丘丑上且丟丒一(世丅丈东丘丐丕丟丐:  丄上专丄七丘丕万东 + 208);
            }
            
            }
            
            PGCompany.丌与丛丕业丈不丐世.丗丒丟万丒丅一且丙(: ref  new 丕丛业丁丏下一七丘() {丄上专丄七丘丕万东 = val_71});
            PGCompany.丌与丛丕业丈不丐世.丁七丌万丝丙丘丂丏(丄上专丄七丘丕万东:  val_71);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 424)) == false)
            {
                goto label_141;
            }
            
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 64)) == false) || ((丄上专丄七丘丕万东 + 352) != 0))
            {
                goto label_196;
            }
            
            val_84 = 1152921505284374528;
            if((丄上专丄七丘丕万东 + 353) != 0)
            {
                goto label_196;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 32)) == false)
            {
                goto label_153;
            }
            
            object[] val_25 = new object[1];
            val_84 = 1152921505284374528;
            val_25[0] = ((丄上专丄七丘丕万东 + 192) == 0) ? "null" : (丄上专丄七丘丕万东 + 192);
            UnityEngine.Debug.LogWarningFormat(format:  "GiveBonusForInapp: bonusForThisInapp.ActionStartTime.IsNullOrEmpty(), inappId = {0}", args:  val_25);
            goto label_196;
            label_141:
            BalanceController.下丆丌丌上丗丟上与(丝世业丅与三丂丗丕:  丄上专丄七丘丕万东 + 424);
            label_196:
            val_87 = mem[丄上专丄七丘丕万东 + 208];
            val_87 = 丄上专丄七丘丕万东 + 208;
            if(val_87 != 0)
            {
                    if((丄上专丄七丘丕万东 + 208.Count) == 1)
            {
                    val_84 = 1152921505284374528;
                val_87 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丒丟丝丑丏丒丅丞一(丞一丁业丄一一业且:  丄上专丄七丘丕万东 + 208.Item[0]);
            }
            else
            {
                    val_87 = 0;
            }
            
            }
            
            var val_31 = (val_87 != 0) ? 1 : 0;
            if(((丄上专丄七丘丕万东 + 336) == 0) || ((丄上专丄七丘丕万东 + 336.Count) < 1))
            {
                goto label_279;
            }
            
            List.Enumerator<T> val_33 = 丄上专丄七丘丕万东 + 336.GetEnumerator();
            label_191:
            if(((-640610064) & 1) == 0)
            {
                goto label_181;
            }
            
            Rilisoft.OfferItem val_37 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  val_35.丐丏七丌丕丗业且上());
            if(val_37 == null)
            {
                goto label_191;
            }
            
            val_88 = val_71;
            if(val_88 != 0)
            {
                    var val_38 = ((丄上专丄七丘丕万东 + 404) != 0) ? 58 : 0;
            }
            else
            {
                    val_88 = val_71;
            }
            
            if((丄上专丄七丘丕万东 + 352) != 0)
            {
                    val_90 = 1;
            }
            else
            {
                    val_90 = mem[丄上专丄七丘丕万东 + 404];
                val_90 = 丄上专丄七丘丕万东 + 404;
            }
            
            丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  val_37, 丁且丟不七下丆丒丟:  true, 丂丅丑七丌不丄上丞:  (val_90 != 0) ? 1 : 0, 丗东丗万丘丄丆丏东:  true, 丏丏七丘丈丌上且专:  true, 丄东三丕丟丅不丌丄:  ((丄上专丄七丘丕万东 + 404) != 0) ? 58 : 0, 不丐丅丁丂七丐丘丛:  0, 丁七丐丁丙丄丙不东:  false);
            goto label_191;
            label_181:
            val_77 = 0 + 1;
            mem2[0] = 1217;
            goto label_192;
            label_153:
            BalanceController.下丆丌丌上丗丟上与(丝世业丅与三丂丗丕:  丄上专丄七丘丕万东 + 32);
            goto label_196;
            label_192:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (289 == 1217))
            {
                    var val_68 = 0;
                val_68 = val_68 ^ 0;
                val_77 =  + val_68;
            }
            else
            {
                    if( != 0)
            {
                    val_75 = 0;
            }
            
            }
            
            label_279:
            if(((丄上专丄七丘丕万东 + 376) == 0) || ((丄上专丄七丘丕万东 + 376.Count) < 1))
            {
                goto label_311;
            }
            
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_43 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            List.Enumerator<T> val_44 = 丄上专丄七丘丕万东 + 376.GetEnumerator();
            label_292:
            if(((-640610064) & 1) == 0)
            {
                goto label_287;
            }
            
            Rilisoft.OfferItem val_48 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  val_46.丐丏七丌丕丗业且上());
            if(val_48 == null)
            {
                goto label_292;
            }
            
            null.Add(item:  val_48.ItemParams);
            goto label_292;
            label_287:
             =  + 1;
            mem2[0] = 1339;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_305;
            }
            
            if( == 0)
            {
                goto label_309;
            }
            
            if((1152921555505843984 + ((val_77 + 1)) << 2) != 1339)
            {
                goto label_307;
            }
            
            goto label_309;
            label_305:
            if( == 0)
            {
                goto label_309;
            }
            
            label_307:
            label_309:
            val_84 = 1152921505284374528;
            if(null.Count >= 1)
            {
                    var val_52 = ((丄上专丄七丘丕万东 + 420) == 0) ? 8 : (丄上专丄七丘丕万东 + 420);
                val_92 = val_55;
                val_93 = val_59;
                if((丄上专丄七丘丕万东 + 420) >= 1)
            {
                    val_91 = mem[丄上专丄七丘丕万东 + 420];
                val_91 = 丄上专丄七丘丕万东 + 420;
            }
            
                if((丄上专丄七丘丕万东 + 432) >= 1)
            {
                    val_92 = mem[丄上专丄七丘丕万东 + 432];
                val_92 = 丄上专丄七丘丕万东 + 432;
            }
            
                if((丄上专丄七丘丕万东 + 436) >= 1)
            {
                    val_94 = val_71;
                if(val_94 != 0)
            {
                    val_95 = mem[丄上专丄七丘丕万东 + 436];
                val_95 = 丄上专丄七丘丕万东 + 436;
            }
            else
            {
                    val_95 = mem[丄上专丄七丘丕万东 + 436];
                val_95 = 丄上专丄七丘丕万东 + 436;
                if(val_71 != 0)
            {
                    val_94 = val_71;
            }
            else
            {
                    val_94 = 0;
            }
            
            }
            
                val_93 = new PGCompany.丏丈丈且东丅上丄丙();
                val_93 = new PGCompany.丏丈丈且东丅上丄丙(丁丅丈丌丟世丗丗丟:  val_95, 丞丅上丏丂且下丅与:  0);
            }
            
                System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_62 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  null, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
                val_84 = 1152921505284374528;
            }
            
            label_311:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东 + 392)) != true)
            {
                    var val_69 = 0;
                val_69 = val_69 + 1;
                new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  31);
                new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  丄上专丄七丘丕万东 + 400);
                PGCompany.GiftSystem.业三东上与丁丁专三.丑七不且上丗丁一世().丞丈丞三上丆上丌丆(与专丁丈七丞三与丕:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝(), 丈丗下七且丏三专丛:  new PGCompany.三东丏不丗世丅丌丄());
            }
            
            PGCompany.丌与丛丕业丈不丐世.且与丝丕丏丒丟上丒(丄上专丄七丘丕万东:  val_71, 丝丗不东丙不三丄专:  false, 下丐丐丂丗丁丂丈丝:  false);
            PGCompany.丌与丛丕业丈不丐世.三不业丂不丁丘专上(丄上专丄七丘丕万东:  val_71);
            PGCompany.丌与丛丕业丈不丐世.七三丘丐一丘丁丗丙(丄上专丄七丘丕万东:  val_71);
            PGCompany.丌与丛丕业丈不丐世.一丂丕丅丑丘世丕丙(丄上专丄七丘丕万东:  val_71);
            PGCompany.丌与丛丕业丈不丐世.丏丑丛丂一与且不与(丄上专丄七丘丕万东:  val_71);
            PGCompany.丌与丛丕业丈不丐世.丏专丆丛三七下丞一(丄上专丄七丘丕万东:  val_71);
            PGCompany.丌与丛丕业丈不丐世.丂丑万与上下一不丈(丄上专丄七丘丕万东:  val_71);
            PGCompany.丌与丛丕业丈不丐世.专丁万丟丘丝丑世丛(丄上专丄七丘丕万东:  val_71);
            PGCompany.丌与丛丕业丈不丐世.丈丛专上不三丐丙丝(丄上专丄七丘丕万东:  val_71);
            PGCompany.丌与丛丕业丈不丐世.丟丈丗七不下丁上丈(丄上专丄七丘丕万东:  val_71);
            PGCompany.丌与丛丕业丈不丐世.丟丁业丄丅下七世且(丂丈丗丄不丅丅丙丒:  val_71, 下丐丐丂丗丁丂丈丝:  false);
            PGCompany.丌与丛丕业丈不丐世.丂七丟丗下丘丒丞不(丂丈丗丄不丅丅丙丒:  val_71);
            PGCompany.丌与丛丕业丈不丐世.万且丏丂丙丅丝丛东(丂丈丗丄不丅丅丙丒:  val_71);
            goto label_344;
        }
        private static void 丁七丌万丝丙丘丂丏(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            var val_3;
            string val_4;
            int val_5;
            val_3 = 丄上专丄七丘丕万东;
            if(val_3 != null)
            {
                    val_4 = 丄上专丄七丘丕万东.PetId;
            }
            else
            {
                    val_4 = 8;
            }
            
            val_5 = 丄上专丄七丘丕万东.Quantity;
            PGCompany.丌与丛丕业丈不丐世.丌丆丆万东丑丙丅业(世丐丗专丅三丝丑丆:  val_4, 丟丄丈丁丄丆七丙丙:  val_5);
            if(丄上专丄七丘丕万东.PetsIds == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = 丄上专丄七丘丕万东.PetsIds.GetEnumerator();
            val_5 = 1152921519126359200;
            label_9:
            if(((-640383192) & 1) == 0)
            {
                goto label_6;
            }
            
            PGCompany.丌与丛丕业丈不丐世.丌丆丆万东丑丙丅业(世丐丗专丅三丝丑丆:  0.丐丏七丌丕丗业且上(), 丟丄丈丁丄丆七丙丙:  1);
            goto label_9;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal static void 丌丆丆万东丑丙丅业(string 世丐丗专丅三丝丑丆, int 丟丄丈丁丄丆七丙丙)
        {
            string val_16;
            var val_18;
            val_16 = 世丐丗专丅三丝丑丆;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) == true)
            {
                    return;
            }
            
            if(丟丄丈丁丄丆七丙丙 <= 0)
            {
                    UnityEngine.Debug.LogErrorFormat(format:  "GiveBonusForInapp: giving pet, quantity <= 0", args:  System.Array.Empty<System.Object>());
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丏专丟丒万丑丐不丞(世丐丗专丅三丝丑丆:  val_16, 丒七且一东丂丐丛丒:  丟丄丈丁丄丆七丙丙)) != false)
            {
                    ShopNGUIController.丈丅丌丙丝丘一丝且(世丐丗专丅三丝丑丆:  val_16);
            }
            else
            {
                    val_16 = System.Array.Empty<System.Object>();
                UnityEngine.Debug.LogErrorFormat(format:  "GiveBonusForInapp petUpdateInfo == null", args:  val_16);
            }
            
            if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
            {
                    return;
            }
            
            val_18 = null;
            val_18 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丌与专丗丂丄丌上不();
            if(PetInfoController.Instance != 0)
            {
                    PetInfoController.Instance.UpdateState();
            }
            
            if(Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟() != 0)
            {
                    bool val_14 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().UpdateView();
            }
            
            val_16 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
            if(val_16 == 0)
            {
                    return;
            }
            
            val_16 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
            val_16.丞丏世丆丄上丆一七();
        }
        internal static bool 上且丅专丟丄且丅上(string 丟丟丄专上丟丁丐丝, int 丌丒丝东丌下丕丁丅)
        {
            string val_15;
            var val_16;
            System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_18;
            var val_20;
            System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_22;
            var val_23;
            val_15 = 丟丟丄专上丟丁丐丝;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_15)) != false)
            {
                    val_16 = null;
                val_16 = null;
                val_18 = 丌与丛丕业丈不丐世.<>c.<>9__18_0;
                if(val_18 == null)
            {
                    System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_4 = null;
                val_18 = val_4;
                val_4 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  丌与丛丕业丈不丐世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌与丛丕业丈不丐世.<>c::丈丌丕丟业丛丟丈上(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
                丌与丛丕业丈不丐世.<>c.<>9__18_0 = val_18;
            }
            
                Rilisoft.丛且世丐丆上七业丁 val_5 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丟丛上丅七丂七丛下(), predicate:  val_4);
                if(val_5 != null)
            {
                    val_15 = val_5.业上丙丞丐丄丆丅七();
            }
            
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_15)) != false)
            {
                    val_20 = null;
                val_20 = null;
                val_22 = 丌与丛丕业丈不丐世.<>c.<>9__18_1;
                if(val_22 == null)
            {
                    System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_10 = null;
                val_22 = val_10;
                val_10 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  丌与丛丕业丈不丐世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丌与丛丕业丈不丐世.<>c::丘且丅丝丛丐东丌丛(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
                丌与丛丕业丈不丐世.<>c.<>9__18_1 = val_22;
            }
            
                Rilisoft.丛且世丐丆上七业丁 val_11 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丟丛上丅七丂七丛下(), predicate:  val_10);
                if(val_11 != null)
            {
                    val_15 = val_11.业上丙丞丐丄丆丅七();
            }
            
            }
            
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_15)) != false)
            {
                    丌与丛丕业丈不丐世.丏丐丙丆与与丟丂丈.丆丟丟三丗东一丆三(丄丙下丝丛丒七丂丘:  "game event not found");
                val_23 = 0;
                return (bool)val_23;
            }
            
            val_23 = 1;
            bool val_14 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丟丟丄专上丟丁丐丝:  val_15);
            return (bool)val_23;
        }
        private static void 且与丝丕丏丒丟上丒(InappRememberedBonus 丄上专丄七丘丕万东, bool 丝丗不东丙不三丄专, bool 下丐丐丂丗丁丂丈丝)
        {
            System.Exception val_5;
            bool val_9;
            var val_10;
            var val_11;
            val_9 = 丝丗不东丙不三丄专;
            val_10 = 1;
            OfferModule val_1 = 丄上专丄七丘丕万东.OfferModule - 90;
            if(val_1 > 40)
            {
                goto label_2;
            }
            
            val_1 = 1 << val_1;
            val_1 = val_1 & 1099511629057;
            if(val_1 != 0)
            {
                goto label_5;
            }
            
            label_2:
            if((丄上专丄七丘丕万东.OfferModule != 10) && (丄上专丄七丘丕万东.OfferModule != 60))
            {
                    bool val_2 = (丄上专丄七丘丕万东.OfferModule == 140) ? 1 : 0;
            }
            
            label_5:
            丝丗不东丙不三丄专 = val_9;
            PGCompany.丌与丛丕业丈不丐世.丁丁丐丙丙世万七丂(丈丁丄丘丛世七丙丝:  丄上专丄七丘丕万东.WeaponId, 丝丗不东丙不三丄专:  丝丗不东丙不三丄专, 三万东丏一丛丐丛与:  val_2);
            if(丄上专丄七丘丕万东.WeaponsIds == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_3 = 丄上专丄七丘丕万东.WeaponsIds.GetEnumerator();
            label_12:
            if(((-639713376) & 1) == 0)
            {
                goto label_9;
            }
            
            PGCompany.丌与丛丕业丈不丐世.丁丁丐丙丙世万七丂(丈丁丄丘丛世七丙丝:  val_5.丐丏七丌丕丗业且上(), 丝丗不东丙不三丄专:  val_9, 三万东丏一丛丐丛与:  val_2);
            goto label_12;
            label_9:
            val_11 = 0;
            val_9 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(144 != 144)
            {
                    return;
            }
            
                return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        internal static void 丁丁丐丙丙世万七丂(string 丈丁丄丘丛世七丙丝, bool 丝丗不东丙不三丄专, bool 三万东丏一丛丐丛与)
        {
            object val_26;
            string val_27;
            三丅丁丗丗丝丂万且 val_28;
            三丅丁丗丗丝丂万且 val_29;
            丕丑丙丑丙东丌丘丕 val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            CategoryNames val_36;
            三丅丁丗丗丝丂万且 val_37;
            val_27 = 丈丁丄丘丛世七丙丝;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_27)) == true)
            {
                    return;
            }
            
            丌与丛丕业丈不丐世.丒业丛丟专丛丒与东 val_2 = null;
            val_26 = val_2;
            val_2 = new 丌与丛丕业丈不丐世.丒业丛丟专丛丒与东();
            val_28 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_27);
            if(val_26 == null)
            {
                goto label_6;
            }
            
            .丆丐七世世且丏丐业 = val_28;
            if(val_28 == null)
            {
                goto label_7;
            }
            
            label_62:
            if(val_26 == null)
            {
                    val_29 = .丆丐七世世且丏丐业;
            }
            
            val_30 = 0;
            val_29 = val_29.万上丄下业丛丌不丈() - 1;
            if(三万东丏一丛丐丛与 != false)
            {
                    val_30 = WeaponManager.丝丒丂丂丏丞一与丆(丈下丑丆上丏丗丈专:  .丆丐七世世且丏丐业);
            }
            
            丐一且丝丂丟丞三丅.丂七丗丒丅世丒丌下(七丆丒与丗丌丄且丂:  val_29, 丞一丁业丄一一业且:  val_27, 七丝下七下丗三且丟:  new System.Action<System.String>(object:  val_2, method:  System.Void 丌与丛丕业丈不丐世.丒业丛丟专丛丒与东::丟专七丌丛丐丐下专(string 下丅丙一丂丗丅丝七)), 丁丌业丂丐与丌丑丂:  0, 丁且丟不七下丆丒丟:  true, 丝丗不东丙不三丄专:  丝丗不东丙不三丄专, 万丐丏丐丒万不丟三:  0, 丄下丁东丘业丆丝上:  val_30, 不丐丅丁丂七丐丘丛:  21);
            val_31 = null;
            val_31 = null;
            val_27 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_27 != 0)
            {
                    val_27 = 1152921505066536960;
                if(GameConnect.世丐丄三三上丅七三() != true)
            {
                    if(GameConnect.万不丒丌丙万丗东不() == false)
            {
                goto label_25;
            }
            
            }
            
                if(ConnectScene.丈丘丂丙不丛业丟三() != false)
            {
                    label_25:
                if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() != true)
            {
                    val_32 = null;
                val_32 = null;
                val_27 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
                val_26 = ShopNGUIController.丛世丛与丌不丈丐丐();
                WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  val_26, 专丆丌丛东一不丑丙:  WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐());
                WeaponManager.丟丗丄业丘丗业丗七.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  val_27);
                if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
            {
                    val_27 = ShopNGUIController.丛丐丛专丟丞万三七();
                val_33 = null;
                val_33 = null;
                if(val_27 != WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐())
            {
                    val_34 = null;
                val_34 = null;
                val_27 = WeaponManager.丟丗丄业丘丗业丗七;
                val_27.下东与丌丁丝丁丘专(专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
            }
            
            }
            
            }
            
            }
            
            }
            
            if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
            {
                    return;
            }
            
            val_35 = null;
            val_35 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
            {
                goto label_60;
            }
            
            val_36 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且();
            goto label_61;
            label_6:
            mem[16] = val_28;
            val_37 = mem[16];
            if(val_37 != 0)
            {
                goto label_62;
            }
            
            label_7:
            object[] val_23 = new object[1];
            val_23[0] = val_27;
            UnityEngine.Debug.LogErrorFormat(format:  "rec == null, weaponId = {0}", args:  val_23);
            return;
            label_60:
            val_36 = 0.丗丛丐丑丛丅丞七且();
            label_61:
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_36, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
            val_27 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
            if(val_27 == 0)
            {
                    return;
            }
            
            ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丞丏世丆丄上丆一七();
        }
        private static void 三不业丂不丁丘专上(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            PGCompany.丌与丛丕业丈不丐世.丈丌万万丌一丛与业(丙丄不丈专丕与万万:  丄上专丄七丘丕万东.ArmorId);
        }
        internal static void 丈丌万万丌一丛与业(string 丙丄不丈专丕与万万)
        {
            string val_24;
            System.Object[] val_25;
            var val_26;
            val_24 = 丙丄不丈专丕与万万;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_24)) == true)
            {
                    return;
            }
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_24);
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != true)
            {
                    PGCompany.丗丟丄丈东丝丕丄世 val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            }
            
            PGCompany.且万丅丙丛丌丞与丈 val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.且万丅丙丛丌丞与丈>(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_8 == null)
            {
                    object[] val_9 = new object[1];
                val_9[0] = val_24;
                UnityEngine.Debug.LogErrorFormat(format:  "newArmor == null give armor {0}", args:  val_9);
            }
            
            val_25 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().丂专下丌丈丙专丁东(丙丄不丈专丕与万万:  val_24);
            if(val_25 < ExperienceController.丞丞丘业东丙丏七丌())
            {
                    val_25 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
                if((val_25.丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  val_8, 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = true})) != true)
            {
                    object[] val_15 = new object[1];
                val_25 = val_15;
                val_25[0] = val_24;
                UnityEngine.Debug.LogErrorFormat(format:  "!upgradeResult give armor {0}", args:  val_15);
            }
            
            }
            
            丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_8);
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
            {
                    val_26 = null;
                val_26 = null;
                ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
                ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且(), 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
                if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0)
            {
                    ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丞丏世丆丄上丆一七();
            }
            
            }
            
            val_24 = PersConfigurator.下一丁七丅丕七万丑();
            if(val_24 == 0)
            {
                    return;
            }
            
            val_24 = PersConfigurator.下一丁七丅丕七万丑();
            val_24.UpdateWear();
        }
        private static void 丏丑丛丂一与且不与(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            System.Exception val_3;
            var val_6;
            var val_7;
            val_6 = 丄上专丄七丘丕万东;
            if(丄上专丄七丘丕万东.WearIds == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = 丄上专丄七丘丕万东.WearIds.GetEnumerator();
            label_6:
            if(((-638992608) & 1) == 0)
            {
                goto label_3;
            }
            
            PGCompany.丌与丛丕业丈不丐世.丏丗丅丁丞丂丗不丄(丆三丑专丂且一三业:  val_3.丐丏七丌丕丗业且上());
            goto label_6;
            label_3:
            val_7 = 0;
            val_6 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(59 != 59)
            {
                    return;
            }
            
                return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        internal static void 丏丗丅丁丞丂丗不丄(string 丆三丑专丂且一三业)
        {
            string val_12;
            var val_13;
            System.Action<System.String> val_15;
            var val_16;
            var val_17;
            CategoryNames val_18;
            val_12 = 丆三丑专丂且一三业;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_12)) == true)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            val_15 = 丌与丛丕业丈不丐世.<>c.<>9__24_0;
            if(val_15 == null)
            {
                    System.Action<System.String> val_3 = null;
                val_15 = val_3;
                val_3 = new System.Action<System.String>(object:  丌与丛丕业丈不丐世.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丌与丛丕业丈不丐世.<>c::业万丘丕丂世丕丐丙(string 下丅丙一丂丗丅丝七));
                丌与丛丕业丈不丐世.<>c.<>9__24_0 = val_15;
            }
            
            丐一且丝丂丟丞三丅.丂七丗丒丅世丒丌下(七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_12), 丞一丁业丄一一业且:  val_12, 七丝下七下丗三且丟:  val_3, 丁丌业丂丐与丌丑丂:  0, 丁且丟不七下丆丒丟:  true, 丝丗不东丙不三丄专:  false, 万丐丏丐丒万不丟三:  0, 丄下丁东丘业丆丝上:  0, 不丐丅丁丂七丐丘丛:  0);
            val_16 = null;
            val_16 = null;
            if((ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0) && (ShopNGUIController.丛世丛与丌不丈丐丐() != false))
            {
                    val_17 = null;
                val_17 = null;
                ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
                if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
            {
                    val_18 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且();
            }
            else
            {
                    val_18 = 0.丗丛丐丑丛丅丞七且();
            }
            
                ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_18, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
                if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0)
            {
                    ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丞丏世丆丄上丆一七();
            }
            
            }
            
            val_12 = PersConfigurator.下一丁七丅丕七万丑();
            if(val_12 == 0)
            {
                    return;
            }
            
            PersConfigurator.下一丁七丅丕七万丑().UpdateWear();
        }
        private static void 丏专丆丛三七下丞一(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            System.Exception val_3;
            var val_6;
            var val_7;
            val_6 = 丄上专丄七丘丕万东;
            if(丄上专丄七丘丕万东.LobbyItemsIds == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = 丄上专丄七丘丕万东.LobbyItemsIds.GetEnumerator();
            label_6:
            if(((-638693856) & 1) == 0)
            {
                goto label_3;
            }
            
            PGCompany.丌与丛丕业丈不丐世.丏一丙丏丟丌上丐丘(万专万世丂丌丌下万:  val_3.丐丏七丌丕丗业且上());
            goto label_6;
            label_3:
            val_7 = 0;
            val_6 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(59 != 59)
            {
                    return;
            }
            
                return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        internal static void 丏一丙丏丟丌上丐丘(string 万专万世丂丌丌下万)
        {
            string val_8 = 万专万世丂丌丌下万;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8 = 万专万世丂丌丌下万)) == true)
            {
                    return;
            }
            
            val_8 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_8);
            if(val_8 == null)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  val_8)) != false)
            {
                    return;
            }
            
            bool val_7 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_8, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  true);
        }
        private static void 一丂丕丅丑丘世丕丙(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            int val_3;
            var val_4;
            var val_5;
            val_3 = 丄上专丄七丘丕万东;
            if(val_3 == null)
            {
                    return;
            }
            
            if(丄上专丄七丘丕万东.DaysLeprechaun < 1)
            {
                    return;
            }
            
            if(丄上专丄七丘丕万东.PerDayLeprechaun < 1)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((System.String.op_Equality(a:  丄上专丄七丘丕万东.CurrencyLeprechaun, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true)
            {
                    val_5 = null;
                val_5 = null;
                if((System.String.op_Equality(a:  丄上专丄七丘丕万东.CurrencyLeprechaun, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                    return;
            }
            
            }
            
            val_3 = 丄上专丄七丘丕万东.PerDayLeprechaun;
            PGCompany.丌与丛丕业丈不丐世.丗丄丝万丄万丆丟丘(三丘丑丏不万丟与丘:  丄上专丄七丘丕万东.DaysLeprechaun, 丏丂不专上丘丂不丅:  丄上专丄七丘丕万东.CurrencyLeprechaun, 丝三丟丈与丛丂七丑:  val_3);
        }
        internal static void 丗丄丝万丄万丆丟丘(int 三丘丑丏不万丟与丘, string 丏丂不专上丘丂不丅, int 丝三丟丈与丛丂七丑)
        {
            Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.SetLeprechaunt(不与万丕一丌世丛一:  三丘丑丏不万丟与丘 * 86400, 丘东丈不与专专且丗:  丏丂不专上丘丂不丅, 丄东世不与不丐不专:  丝三丟丈与丛丂七丑, 丕万且丞丘丕丄丗世:  86400);
        }
        private static void 七三丘丐一丘丁丗丙(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            InappRememberedBonus val_3 = 丄上专丄七丘丕万东;
            if(val_3 == null)
            {
                    return;
            }
            
            if(丄上专丄七丘丕万东.GadgetIds == null)
            {
                    return;
            }
            
            if(丄上专丄七丘丕万东.GadgetIds.Count <= 0)
            {
                    return;
            }
            
            if(丄上专丄七丘丕万东.OfferModule == 60)
            {
                    var val_2 = (丄上专丄七丘丕万东.OfferSubModule == 90) ? 1 : 0;
            }
            else
            {
                    val_3 = 0;
            }
            
            PGCompany.丌与丛丕业丈不丐世.丒丞丟丌丞专丙业不(业丐丟七丘丘三业三:  丄上专丄七丘丕万东.GadgetIds, 丑丗三丏丑不丝七一:  false);
        }
        internal static void 丒丞丟丌丞专丙业不(System.Collections.Generic.List<string> 业丐丟七丘丘三业三, bool 丑丗三丏丑不丝七一 = False)
        {
            ArmoryInfoScreenController val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            int val_28;
            int val_29;
            var val_30;
            CategoryNames val_31;
            val_23 = 丑丗三丏丑不丝七一;
            val_24 = null;
            val_24 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
            {
                    val_25 = null;
                val_25 = null;
                val_26 = (UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  0)) ^ 1;
            }
            else
            {
                    val_26 = 1;
            }
            
            val_27 = 0;
            goto label_12;
            label_41:
            string val_3 = 业丐丟七丘丘三业三.Item[0];
            val_28 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = val_28.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  70, 丞丅上丏丂且下丅与:  val_3);
            if(val_5 == null)
            {
                goto label_15;
            }
            
            if(val_23 == false)
            {
                goto label_16;
            }
            
            val_29 = val_5.业东丅东丌上丗丑不();
            int val_10 = BalanceController.与丗万世丅下丈万丁(丞世不丒下上上丝丑:  val_29, 丈丘丝一丗下丈丐不:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_3].丈丒丟下丂丒东与丑(), 丐丏上业丈丂与万丞:  true);
            goto label_23;
            label_15:
            UnityEngine.Debug.LogError(message:  "unknown gadget:"("unknown gadget:") + val_3);
            goto label_33;
            label_16:
            val_29 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_3];
            label_23:
            val_28 = val_29.丈丒丟下丂丒东与丑();
            丁下万丟且丟丛下业.丅丕丆丒丒业丑世东(丗丑丐丕丟丝且下丕:  val_3, 丈丘丝一丗下丈丐不:  val_28);
            if((val_26 & 1) != 0)
            {
                    val_28 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_3);
                丆丟七丌丞东丆丕丌.丏下丕丏丘丅与丂丐(丗丑丐丕丟丝且下丕:  val_3, 七丆丒与丗丌丄且丂:  val_28, 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七(), 且丙丄且丐上与丈丆:  false);
            }
            
            label_33:
            val_27 = 1;
            label_12:
            if(val_27 < 业丐丟七丘丘三业三.Count)
            {
                goto label_41;
            }
            
            if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
            {
                    return;
            }
            
            val_30 = null;
            val_30 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
            {
                    val_31 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且();
            }
            else
            {
                    val_31 = 0.丗丛丐丑丛丅丞七且();
            }
            
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_31, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
            val_23 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
            if(val_23 == 0)
            {
                    return;
            }
            
            ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丞丏世丆丄上丆一七();
        }
        private static void 丂丑万与上下一不丈(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            if(丄上专丄七丘丕万东 == null)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东.WeaponUpgrade)) == true)
            {
                    return;
            }
            
            System.Nullable<T> val_2 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  丄上专丄七丘丕万东.WeaponUpgrade, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if(((-637767736) & 1) == 0)
            {
                    return;
            }
            
            if(丄上专丄七丘丕万东.Quantity < 1)
            {
                    return;
            }
        
        }
        internal static void 万丏且丒下三三三丄(CategoryNames 七丆丒与丗丌丄且丂, int 丌丒丝东丌下丕丁丅)
        {
        
        }
        private static void 专丁万丟丘丝丑世丛(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            InappRememberedBonus val_1 = 丄上专丄七丘丕万东;
            if(val_1 == null)
            {
                    return;
            }
            
            val_1 = 丄上专丄七丘丕万东.GachaFreeSpins;
            if(val_1 < 1)
            {
                    return;
            }
            
            GiftController.丅丆丆丏万丅丑丝世(丌丒丝东丌下丕丁丅:  val_1);
        }
        private static void 丈丛专上不三丐丙丝(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            InappRememberedBonus val_5 = 丄上专丄七丘丕万东;
            if(丄上专丄七丘丕万东.DetailsCount < 1)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丄上专丄七丘丕万东.DetailsItemId)) == false)
            {
                    return;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  丄上专丄七丘丕万东.DetailsItemId)) != false)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
                val_5 = 丄上专丄七丘丕万东.DetailsCount;
                null.Add(key:  丄上专丄七丘丕万东.DetailsItemId, value:  val_5);
                Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丗且且丘丐三丙丆丁(丌丄万上丙万丄丒七:  null);
                return;
            }
            
            val_5 = 丄上专丄七丘丕万东.DetailsCount;
            Rilisoft.丕七东丗丁丐丂三下.丆东上且丟丌业丗与(丒东业不丐丑丕丄丆:  丄上专丄七丘丕万东.DetailsItemId, 丌丒丝东丌下丕丁丅:  val_5, 与丘万三东一丄丄丙:  true);
        }
        private static void 丟丈丗七不下丁上丈(InappRememberedBonus 丄上专丄七丘丕万东)
        {
            System.Exception val_4;
            var val_15;
            var val_16;
            val_15 = 丄上专丄七丘丕万东;
            if(丄上专丄七丘丕万东.RoyaleIds == null)
            {
                    return;
            }
            
            if(丄上专丄七丘丕万东.RoyaleIds.Count < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = 丄上专丄七丘丕万东.RoyaleIds.GetEnumerator();
            label_28:
            if(((-637201040) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) == true) || ((丛且丗丌丏下七下丈.丞丈丐丈丂丕丐丌丂(丞一丁业丄一一业且:  val_5)) == true))
            {
                goto label_28;
            }
            
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_5)) == false)
            {
                goto label_15;
            }
            
            丛且丗丌丏下七下丈.丂七丗丒丅世丒丌下(丞一丁业丄一一业且:  val_5, 丌业丈丙丙丈且丕丞:  true);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东.OfferId)) == true)
            {
                goto label_28;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_11 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  val_5);
            if(val_11.丕丐一丙专丛丒丑万() == false)
            {
                goto label_28;
            }
            
            丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(丈丄不七三万丄丁不:  val_11);
            goto label_28;
            label_15:
            PGCompany.丌与丛丕业丈不丐世.丁丁丐丙丙世万七丂(丈丁丄丘丛世七丙丝:  val_5, 丝丗不东丙不三丄专:  false, 三万东丏一丛丐丛与:  false);
            goto label_28;
            label_5:
            val_16 = 0;
            val_15 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(165 != 165)
            {
                    return;
            }
            
                return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private static void 丟丁业丄丅下七世且(InappRememberedBonus 丂丈丗丄不丅丅丙丒, bool 下丐丐丂丗丁丂丈丝)
        {
            ArmoryInfoScreenController val_29;
            int val_30;
            string val_31;
            val_29 = 丂丈丗丄不丅丅丙丒;
            val_30 = 丂丈丗丄不丅丅丙丒.WeaponDetails;
            if(val_30 < 1)
            {
                    return;
            }
            
            Rilisoft.丕七东丗丁丐丂三下.丆东上且丟丌业丗与(丒东业不丐丑丕丄丆:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag, 丌丒丝东丌下丕丁丅:  val_30, 与丘万三东一丄丄丙:  true);
            if(下丐丐丂丗丁丂丈丝 != false)
            {
                    WeaponManager.专丗丏三丘上一丒丈(丒东业不丐丑丕丄丆:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag);
            }
            
            PGCompany.丌与丛丕业丈不丐世.上丑丗丂且丘丒丙万();
            if((Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟() != 0) && (Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().gameObject.activeInHierarchy != false))
            {
                    PGCompany.丌与丛丕业丈不丐世.三不东上丞丙丕丐专();
                if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag)) != true) && ((System.String.op_Equality(a:  Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().ItemTag, b:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag)) != false))
            {
                    val_31 = 丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag;
                三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_31);
                if(val_10 != null)
            {
                    val_31 = val_10.三与丛丑且丐丈业丌();
            }
            
                if((Rilisoft.丕七东丗丁丐丂三下.丏丐下丌东不上丂丑(上与丕专世专上万三:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag, 东丒不专丞丙三丘丄:  val_31)) != false)
            {
                    Rilisoft.BuyCraftDetailsWindow val_13 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟();
            }
            
            }
            
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_16 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd/Buy"));
            }
            
            if(Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世() != 0)
            {
                    Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世().万且丂丑丂丏丘丒七();
            }
            
            val_30 = 1152921505035919360;
            if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三() == null)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag)) == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三().业上丙丞丐丄丆丅七(), b:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag)) == false)
            {
                    return;
            }
            
            val_29 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
            val_29.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_29.丈丒丛东上丘丅世三(), 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
        }
        private static void 三不东上丞丙丕丐专()
        {
            UnityEngine.Object val_9;
            var val_10;
            System.Action<Rilisoft.CraftDetailsView> val_12;
            val_9 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟();
            if(val_9 == 0)
            {
                    return;
            }
            
            val_9 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().gameObject;
            if(val_9.activeInHierarchy == false)
            {
                    return;
            }
            
            val_9 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().Views;
            val_10 = null;
            val_10 = null;
            val_12 = 丌与丛丕业丈不丐世.<>c.<>9__37_0;
            if(val_12 == null)
            {
                goto label_16;
            }
            
            if(val_9 != null)
            {
                goto label_21;
            }
            
            goto label_18;
            label_16:
            val_12 = null;
            val_12 = new System.Action<Rilisoft.CraftDetailsView>(object:  丌与丛丕业丈不丐世.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丌与丛丕业丈不丐世.<>c::丁东上丄丁丛专且丆(Rilisoft.CraftDetailsView 丁世丛业丟下丕三丟));
            丌与丛丕业丈不丐世.<>c.<>9__37_0 = val_12;
            if(val_9 != null)
            {
                goto label_21;
            }
            
            label_18:
            label_21:
            val_9.ForEach(action:  null);
        }
        private static void 上丑丗丂且丘丒丙万()
        {
            ShopNGUIController val_4;
            var val_5;
            if(上丑三丁丄丛丁万丑.丆丒丘丙丒丝丙丗丈() == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            val_4.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_4.丗丛丐丑丛丅丞七且(), 与丝丕与丙不与丗丆:  ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑(), 七丑业业丒七一丂丆:  false);
        }
        private static void 丂七丟丗下丘丒丞不(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
        {
            ArmoryInfoScreenController val_26;
            string val_27;
            val_26 = 丂丈丗丄不丅丅丙丒;
            if(丂丈丗丄不丅丅丙丒.RoyaleDetails < 1)
            {
                    return;
            }
            
            Rilisoft.丕七东丗丁丐丂三下.丆东上且丟丌业丗与(丒东业不丐丑丕丄丆:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag, 丌丒丝东丌下丕丁丅:  丂丈丗丄不丅丅丙丒.RoyaleDetails, 与丘万三东一丄丄丙:  true);
            PGCompany.丌与丛丕业丈不丐世.上丑丗丂且丘丒丙万();
            if((Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟() != 0) && (Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().gameObject.activeInHierarchy != false))
            {
                    PGCompany.丌与丛丕业丈不丐世.三不东上丞丙丕丐专();
                if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag)) != true) && ((System.String.op_Equality(a:  Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().ItemTag, b:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag)) != false))
            {
                    val_27 = 丂丈丗丄不丅丅丙丒.RoyaleDetailsTag;
                三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_27);
                if(val_10 != null)
            {
                    val_27 = val_10.三与丛丑且丐丈业丌();
            }
            
                if((Rilisoft.丕七东丗丁丐丂三下.丏丐下丌东不上丂丑(上与丕专世专上万三:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag, 东丒不专丞丙三丘丄:  val_27)) != false)
            {
                    Rilisoft.BuyCraftDetailsWindow val_13 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟();
            }
            
            }
            
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_16 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd/Buy"));
            }
            
            if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三() == null)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag)) == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三().业上丙丞丐丄丆丅七(), b:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag)) == false)
            {
                    return;
            }
            
            val_26 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
            val_26.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_26.丈丒丛东上丘丅世三(), 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
        }
        private static void 万且丏丂丙丅丝丛东(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
        {
            var val_14;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_15;
            val_14 = 丂丈丗丄不丅丅丙丒;
            if(丂丈丗丄不丅丅丙丒.FortItemDetails < 1)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = null;
            val_15 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_2.Add(key:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag, value:  丂丈丗丄不丅丅丙丒.FortItemDetails);
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丗且且丘丐三丙丆丁(丌丄万上丙万丄丒七:  val_2);
            PGCompany.丌与丛丕业丈不丐世.三不东上丞丙丕丐专();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag)) == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().ItemTag, b:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag)) == false)
            {
                    return;
            }
            
            val_14 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag);
            val_15 = val_14.三丐丟丒业丞东三丕();
            if(val_14.丗三三丐丁东丘丌一() < (val_14.丄且丞且且且世丂丅() * val_15))
            {
                    return;
            }
            
            val_14 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟();
        }
        private static 丌与丛丕业丈不丐世()
        {
            PGCompany.丌与丛丕业丈不丐世.且丑丑丟丄丘世一丐 = 0;
        }
        internal static void 丕丛丈丛丄丒上上丏(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
        {
            InappRememberedBonus val_3 = 丂丈丗丄不丅丅丙丒;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "[TEST] InAppProvider.SendAnalytics(), bonus: {0}", arg0:  (val_3 != 0) ? 1 : 0));
            if(val_3 == null)
            {
                    return;
            }
            
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            if(丂丈丗丄不丅丅丙丒.Gems <= 0)
            {
                    if(丂丈丗丄不丅丅丙丒.Coins < 1)
            {
                goto label_7;
            }
            
            }
            
            StoreKitEventListener.丘万万丅丘丟丛丈业(丅丞丂丟丟且丅丆丅:  丂丈丗丄不丅丅丙丒.InappId, 世丕丅与丆丄丗丐万:  丂丈丗丄不丅丅丙丒.Gems, 丑丁丐丏业丗一丏丈:  丂丈丗丄不丅丅丙丒.Coins);
            label_7:
            val_3 = 丂丈丗丄不丅丅丙丒.InappId;
            Rilisoft.一丟专且三万丞丁丂.丛丒丆三业丆丅丛丐(丘专丈与三专丈丈专:  val_3);
        }
        internal static void 丅丈一丏不丁且且下(ref PGCompany.丌与丛丕业丈不丐世.丛与丒丞丁丛上丄丆 )
        {
            InappRememberedBonus val_1;
            var val_2;
            val_1 = .丄上专丄七丘丕万东;
            if(.丄上专丄七丘丕万东.Coins < 1)
            {
                    return;
            }
            
            val_1 = 1152921505429315584;
            val_2 = null;
            val_2 = null;
            Rilisoft.一丟专且三万丞丁丂.丄丌专三丅下丞丄且 = 1;
        }
        internal static void 丗丒丟万丒丅一且丙(ref PGCompany.丌与丛丕业丈不丐世.丕丛业丁丏下一七丘 )
        {
            var val_9;
            var val_10;
            var val_11;
            val_9 = null;
            val_9 = null;
            int val_9 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业万专三一丟且丘业, value:  .丄上专丄七丘丕万东.InappId);
            if(.丄上专丄七丘丕万东.Coins >= 1)
            {
                    int val_4 = val_9 >> 31;
                val_4 = val_4 & 4294967283;
                BankController.丒丘上丟下丅丑丅丄(丌丒丝东丌下丕丁丅:  .丄上专丄七丘丕万东.Coins, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  (val_9 < 0) ? (val_9 >> 31) : (0 + 1), 丄东三丕丟丅不丌丄:  val_4 + 29, 丟世且丕丂丁万丒万:  0);
                val_10 = null;
                val_10 = null;
                coinsShop.丙丝东下世丟丙丆七(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
            }
            
            if(.丄上专丄七丘丕万东.Gems < 1)
            {
                    return;
            }
            
            int val_8 = val_9 >> 31;
            val_8 = val_8 & 4294967283;
            val_9 = val_8 + 29;
            BankController.丐丙东东不丛丂上丛(丌丒丝东丌下丕丁丅:  .丄上专丄七丘丕万东.Gems, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  (val_9 < 0) ? (val_9 >> 31) : (0 + 1), 丄东三丕丟丅不丌丄:  val_9, 丟世且丕丂丁万丒万:  0);
            val_11 = null;
            val_11 = null;
            coinsShop.丙丝东下世丟丙丆七(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        }
    
    }

}
