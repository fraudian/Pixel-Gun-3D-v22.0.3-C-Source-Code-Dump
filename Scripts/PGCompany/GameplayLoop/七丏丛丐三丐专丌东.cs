using UnityEngine;

namespace PGCompany.GameplayLoop
{
    internal class 七丏丛丐三丐专丌东 : 业丒丅丂丗丁业上且
    {
        // Fields
        private System.Collections.Generic.List<string> 丁不丝丂丅下丁丈与;
        private System.Collections.Generic.Dictionary<int, PGCompany.三东丏不丗世丅丌丄> 丙丕下丑丟丂上丙丐;
        private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丟东丏丏丘专丝丟万;
        
        // Methods
        public 七丏丛丐三丐专丌东()
        {
            this.丁不丝丂丅下丁丈与 = new System.Collections.Generic.List<System.String>();
            this.丙丕下丑丟丂上丙丐 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.三东丏不丗世丅丌丄>();
            this.丟东丏丏丘专丝丟万 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            mem[1152921560167387856] = 4;
            this.丂且丗万丁下丞万丁();
            BattlePassController.万且丟丘丐丑丏且专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameplayLoop.七丏丛丐三丐专丌东::丂且丗万丁下丞万丁()));
            BattlePassController.丙七一丄下专丏不丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameplayLoop.七丏丛丐三丐专丌东::丂且丗万丁下丞万丁()));
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.东丄与丘丏专七世与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameplayLoop.七丏丛丐三丐专丌东::丂且丗万丁下丞万丁()));
        }
        internal override bool 丑丏丙丑且丞丈丝业(bool 丘丄一丘丁丞丘丆且)
        {
            bool val_2 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏();
            if(val_2 == false)
            {
                    return val_2.丗丑丞丌丆一丙丛七(丘丄一丘丁丞丘丆且:  false);
            }
            
            return val_2.丆丞丅三下丙丙丁丕(丘丄一丘丁丞丘丆且:  false);
        }
        private bool 丗丑丞丌丆一丙丛七(bool 丘丄一丘丁丞丘丆且)
        {
            object val_10;
            var val_11;
            if(((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) == 0) && (PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false))
            {
                    val_10 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
                if(((val_10 != null) && (val_10.专丁丟丏丁丏不丗三() != false)) && (val_10.丑丙丆东丁丌一一下() != false))
            {
                    val_11 = val_10.丗丄上丑丑丅丐丒丌() ^ 1;
                return (bool)val_11 & 1;
            }
            
            }
            
            val_11 = 0;
            return (bool)val_11 & 1;
        }
        private bool 丆丞丅三下丙丙丁丕(bool 丘丄一丘丁丞丘丆且)
        {
            object val_5;
            var val_6;
            val_5 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世();
            if(val_5.丈万丙东东丒丏丆丝() != false)
            {
                    val_6 = 0;
                bool val_3 = PGCompany.PixelPass.丁且七丅丞丐丌丌世.丟丂下七且七东丛丞();
            }
            else
            {
                    val_6 = 0;
            }
            
            val_6 = val_6 & 1;
            return (bool)val_6;
        }
        private void 丂且丗万丁下丞万丁()
        {
            if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏() != false)
            {
                    this.丝专丐丄东丄丘丅且();
                return;
            }
            
            this.丁丐东丌丑丛丝丈丁();
        }
        private void 丁丐东丌丑丛丝丈丁()
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            System.Func<System.String, System.Boolean> val_28;
            var val_29;
            System.Func<System.String, System.String> val_31;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            this.丁不丝丂丅下丁丈与 = new System.Collections.Generic.List<System.String>();
            if(val_2 == null)
            {
                    return;
            }
            
            val_23 = 1152921536401730448;
            val_24 = 0;
            goto label_3;
            label_9:
            this.丁不丝丂丅下丁丈与.Add(item:  val_2.丈丏丁东上与东丙丕().Item[0].Item.Id);
            val_24 = 1;
            label_3:
            if(val_24 < val_2.丈丏丁东上与东丙丕().Count)
            {
                goto label_9;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_10 = PGCompany.BattlePass.万丈上下三丅丘丛丒.丌丐与丂丗丒丙三七(丞世不丒下上上丝丑:  2);
            if(val_10 == null)
            {
                goto label_12;
            }
            
            val_23 = 1152921525530181280;
            val_25 = val_10.丈丏丁东上与东丙丕();
            if(val_25.Count < 1)
            {
                goto label_12;
            }
            
            val_26 = 0;
            goto label_13;
            label_18:
            this.丁不丝丂丅下丁丈与.Add(item:  val_10.丈丏丁东上与东丙丕().Item[0].Id);
            val_26 = 1;
            label_13:
            val_25 = val_10.丈丏丁东上与东丙丕();
            if(val_26 < val_25.Count)
            {
                goto label_18;
            }
            
            label_12:
            if((((val_17 + 295) & 2) != 0) && ((val_17 + 216) == 0))
            {
                    val_25 = null;
            }
            
            val_28 = 七丏丛丐三丐专丌东.<>c.<>9__8_0;
            if(val_28 == null)
            {
                    System.Func<System.String, System.Boolean> val_18 = null;
                val_28 = val_18;
                val_18 = new System.Func<System.String, System.Boolean>(object:  七丏丛丐三丐专丌东.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 七丏丛丐三丐专丌东.<>c::三丑丘丐上丄世丅七(string 三丟东丕丄丄下下丑));
                七丏丛丐三丐专丌东.<>c.<>9__8_0 = val_28;
            }
            
            val_29 = null;
            val_29 = null;
            val_31 = 七丏丛丐三丐专丌东.<>c.<>9__8_1;
            if(val_31 == null)
            {
                    System.Func<System.String, System.String> val_20 = null;
                val_31 = val_20;
                val_20 = new System.Func<System.String, System.String>(object:  七丏丛丐三丐专丌东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 七丏丛丐三丐专丌东.<>c::上七丟丛七丅丁丙丌(string 三丟东丕丄丄下下丑));
                七丏丛丐三丐专丌东.<>c.<>9__8_1 = val_31;
            }
            
            this.丁不丝丂丅下丁丈与.AddRange(collection:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.String, System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  this.丁不丝丂丅下丁丈与, predicate:  val_18), selector:  val_20)));
        }
        private void 丝专丐丄东丄丘丅且()
        {
            var val_11;
            var val_34;
            System.Collections.Generic.IEnumerable<T> val_48;
            System.Func<PGCompany.三东丏不丗世丅丌丄, PGCompany.三东丏不丗世丅丌丄> val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_56;
            var val_57;
            val_48 = this;
            if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丈万丙东东丒丏丆丝() == false)
            {
                    return;
            }
            
            PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_4 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
            if(val_4 == null)
            {
                    return;
            }
            
            if(val_4.丒东丒上世丘一丗丈() == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_9 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙().丒东丒上世丘一丗丈().GetEnumerator();
            val_50 = 0;
            val_51 = 0;
            label_53:
            if(((-272935616) & 1) == 0)
            {
                goto label_9;
            }
            
            List.Enumerator<T> val_14 = val_11.丐丏七丌丕丗业且上().丈丏丁东上与东丙丕().GetEnumerator();
            label_31:
            if(((-272935648) & 1) == 0)
            {
                goto label_12;
            }
            
            string val_15 = val_11.丐丏七丌丕丗业且上();
            if((val_15 == null) || ((this.丙丕下丑丟丂上丙丐.ContainsKey(key:  val_15.业东丅东丌上丗丑不())) == true))
            {
                goto label_31;
            }
            
            if(val_15.不业丙丒丂丞下丆丙() != 1460)
            {
                goto label_16;
            }
            
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> val_20 = PGCompany.LootBoxSystem.丑丅丘丒万丘万万丐.丌丛业专丈丈丙与丛(丈丄不七三万丄丁不:  val_15, 与不丕丆丈不丙丟丛:  0).上与与专业丞丙丌下();
            val_52 = 0;
            goto label_18;
            label_28:
            if(val_20.Item[0] != null)
            {
                    if((this.丙丕下丑丟丂上丙丐.ContainsKey(key:  val_21.三东丏不丗世丅丌丄.业东丅东丌上丗丑不())) != true)
            {
                    this.丙丕下丑丟丂上丙丐.set_Item(key:  val_21.三东丏不丗世丅丌丄.业东丅东丌上丗丑不(), value:  val_21.三东丏不丗世丅丌丄.与下不与丐丈丁丈万());
            }
            
            }
            
            val_52 = 1;
            label_18:
            if(val_52 < val_20.Count)
            {
                goto label_28;
            }
            
            goto label_31;
            label_16:
            this.丙丕下丑丟丂上丙丐.set_Item(key:  val_15.业东丅东丌上丗丑不(), value:  val_15.与下不与丐丈丁丈万());
            goto label_31;
            label_12:
            var val_47 = 0;
            val_53 = val_51;
            val_47 = val_47 + 1;
            mem2[0] = 302;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_49 = val_47;
            if((val_49 == 1) || ((-272935728 + ((0 + 1)) << 2) != 302))
            {
                goto label_50;
            }
            
            var val_48 = 0;
            val_48 = val_48 ^ (val_49 >> 31);
            val_49 = val_49 + val_48;
            goto label_53;
            label_50:
            if( == 0)
            {
                goto label_53;
            }
            
            goto label_53;
            label_9:
            var val_50 = val_49;
            val_50 = val_50 + 1;
            mem2[0] = 330;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_52 = val_50;
            if((val_52 != 1) && ((-272935728 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) == 330))
            {
                    var val_51 = 0;
                val_51 = val_51 ^ (val_52 >> 31);
                val_52 = val_52 + val_51;
            }
            else
            {
                    if( != 0)
            {
                    val_51 = 0;
            }
            
            }
            
            List.Enumerator<T> val_32 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙().丆丒丗丝丂东丈丏丒().GetEnumerator();
            label_71:
            if(((-272935648) & 1) == 0)
            {
                goto label_66;
            }
            
            string val_35 = val_34.丐丏七丌丕丗业且上();
            if((val_35 == null) || ((this.丙丕下丑丟丂上丙丐.ContainsKey(key:  val_35.业东丅东丌上丗丑不())) == true))
            {
                goto label_71;
            }
            
            this.丙丕下丑丟丂上丙丐.set_Item(key:  val_35.业东丅东丌上丗丑不(), value:  val_35.与下不与丐丈丁丈万());
            goto label_71;
            label_66:
            var val_53 = val_52;
            val_53 = val_53 + 1;
            mem2[0] = 436;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_53 == 1)
            {
                goto label_79;
            }
            
            if(( == 0) || ((-272935728 + ((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) == 436))
            {
                goto label_95;
            }
            
            label_94:
            label_95:
            System.Collections.Generic.List<TSource> val_41 = System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  this.丙丕下丑丟丂上丙丐.Values);
            this.丟东丏丏丘专丝丟万 = val_41;
            val_54 = null;
            val_54 = null;
            val_56 = 七丏丛丐三丐专丌东.<>c.<>9__9_0;
            if(val_56 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_42 = null;
                val_56 = val_42;
                val_42 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  七丏丛丐三丐专丌东.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 七丏丛丐三丐专丌东.<>c::丑丘三三一丌丑丟万(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                七丏丛丐三丐专丌东.<>c.<>9__9_0 = val_56;
            }
            
            val_57 = null;
            val_57 = null;
            val_49 = 七丏丛丐三丐专丌东.<>c.<>9__9_1;
            if(val_49 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, PGCompany.三东丏不丗世丅丌丄> val_44 = null;
                val_49 = val_44;
                val_44 = new System.Func<PGCompany.三东丏不丗世丅丌丄, PGCompany.三东丏不丗世丅丌丄>(object:  七丏丛丐三丐专丌东.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.三东丏不丗世丅丌丄 七丏丛丐三丐专丌东.<>c::七万丂丛业与丕丝与(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                七丏丛丐三丐专丌东.<>c.<>9__9_1 = val_49;
            }
            
            val_48 = System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  System.Linq.Enumerable.Select<PGCompany.三东丏不丗世丅丌丄, PGCompany.三东丏不丗世丅丌丄>(source:  System.Linq.Enumerable.Where<PGCompany.三东丏不丗世丅丌丄>(source:  val_41, predicate:  val_42), selector:  val_44));
            this.丟东丏丏丘专丝丟万.AddRange(collection:  val_48);
            return;
            label_79:
            if( != 0)
            {
                goto label_94;
            }
            
            goto label_95;
        }
        internal PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState 丏上丏业丄丌丂不丁(string 丞一丁业丄一一业且)
        {
            bool val_2 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏();
            if(val_2 == false)
            {
                    return val_2.丄世丏东丟丂丁丐业(丞一丁业丄一一业且:  丞一丁业丄一一业且);
            }
            
            return val_2.丆与上世丈丌丐丕丕(丞一丁业丄一一业且:  丞一丁业丄一一业且);
        }
        private PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState 丆与上世丈丌丐丕丕(string 丞一丁业丄一一业且)
        {
            var val_11;
            System.Func<TSource, System.Boolean> val_12;
            七丏丛丐三丐专丌东.丗丛丘丑丐不丌丑丙 val_1 = new 七丏丛丐三丐专丌东.丗丛丘丑丐不丌丑丙();
            .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
            PGCompany.PixelPass.丘丏丅丆丑下业丙七 val_2 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世();
            if(val_2 == null)
            {
                    return 100;
            }
            
            PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_3 = val_2.丘丗不丂世丘三三丙();
            if(val_3 == null)
            {
                    return 100;
            }
            
            val_12 = val_3.丆丒丗丝丂东丈丏丒();
            if((val_12.Exists(match:  new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  val_1, method:  System.Boolean 七丏丛丐三丐专丌东.丗丛丘丑丐不丌丑丙::丞丘丆万丁丂且下上(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七)))) != true)
            {
                    System.Func<PGCompany.PixelPass.丆丟丈丕下下丘丅丗, System.Boolean> val_8 = null;
                val_12 = val_8;
                val_8 = new System.Func<PGCompany.PixelPass.丆丟丈丕下下丘丅丗, System.Boolean>(object:  val_1, method:  System.Boolean 七丏丛丐三丐专丌东.丗丛丘丑丐不丌丑丙::丛丞丈不万三世丄丏(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘));
                PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_9 = System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(source:  val_3.丒东丒上世丘一丗丈(), predicate:  val_8);
                if(val_9 != null)
            {
                    if(val_9.专丁丞万东丄万丄丄() == false)
            {
                goto label_7;
            }
            
            }
            
                val_11 = 0;
                return 100;
            }
            
            label_7:
            val_11 = 100;
            return 100;
        }
        internal PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState 丏上丏业丄丌丂不丁(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            bool val_2 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏();
            if(val_2 != false)
            {
                    return val_2.丆与上世丈丌丐丕丕(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            }
            
            string val_3 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
            return val_3.丄世丏东丟丂丁丐业(丞一丁业丄一一业且:  val_3);
        }
        private PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState 丆与上世丈丌丐丕丕(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            PGCompany.三东丏不丗世丅丌丄 val_19;
            var val_20;
            System.Collections.Generic.IEnumerable<TSource> val_21;
            val_19 = 丈丄不七三万丄丁不;
            七丏丛丐三丐专丌东.世东丒与丞七不不东 val_1 = new 七丏丛丐三丐专丌东.世东丒与丞七不不东();
            .丈丄不七三万丄丁不 = val_19;
            PGCompany.PixelPass.丘丏丅丆丑下业丙七 val_2 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世();
            if(val_2 == null)
            {
                    return (PlayerPaymentState)val_20;
            }
            
            val_19 = val_2.丘丗不丂世丘三三丙();
            if(val_19 == null)
            {
                    return (PlayerPaymentState)val_20;
            }
            
            val_21 = val_19.丆丒丗丝丂东丈丏丒();
            if((val_21.Exists(match:  new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  val_1, method:  System.Boolean 七丏丛丐三丐专丌东.世东丒与丞七不不东::丞丘丆万丁丂且下上(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七)))) == true)
            {
                goto label_5;
            }
            
            val_21 = val_19.丒东丒上世丘一丗丈();
            PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_9 = System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(source:  val_21, predicate:  new System.Func<PGCompany.PixelPass.丆丟丈丕下下丘丅丗, System.Boolean>(object:  val_1, method:  System.Boolean 七丏丛丐三丐专丌东.世东丒与丞七不不东::丛丞丈不万三世丄丏(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘)));
            if(val_9 == null)
            {
                goto label_6;
            }
            
            label_16:
            if(val_9.专丁丞万东丄万丄丄() == true)
            {
                goto label_15;
            }
            
            label_5:
            val_20 = 100;
            return (PlayerPaymentState)val_20;
            label_6:
            val_21 = (七丏丛丐三丐专丌东.世东丒与丞七不不东)[1152921560169335712].丈丄不七三万丄丁不;
            if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  val_21)) == false)
            {
                goto label_15;
            }
            
            七丏丛丐三丐专丌东.不丞丛丑万丗丏丄丟 val_13 = null;
            val_21 = val_13;
            val_13 = new 七丏丛丐三丐专丌东.不丞丛丑万丗丏丄丟();
            PGCompany.丗丟丄丈东丝丕丄世 val_15 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丕丟与一丝丁业且丅(丒丞丁丞下丝丆不且:  (七丏丛丐三丐专丌东.世东丒与丞七不不东)[1152921560169335712].丈丄不七三万丄丁不);
            if(val_21 == null)
            {
                goto label_12;
            }
            
            .丞丘丞丏业且丛丏丘 = val_15;
            if(val_15 != null)
            {
                goto label_13;
            }
            
            goto label_15;
            label_12:
            mem[16] = val_15;
            if(mem[16] == 0)
            {
                goto label_15;
            }
            
            label_13:
            val_19 = val_19.丒东丒上世丘一丗丈();
            if((System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(source:  val_19, predicate:  new System.Func<PGCompany.PixelPass.丆丟丈丕下下丘丅丗, System.Boolean>(object:  val_13, method:  System.Boolean 七丏丛丐三丐专丌东.不丞丛丑万丗丏丄丟::丒丕丄丞丅丘丑万世(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘)))) != null)
            {
                goto label_16;
            }
            
            label_15:
            val_20 = 0;
            return (PlayerPaymentState)val_20;
        }
        private PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState 丄世丏东丟丂丁丐业(string 丞一丁业丄一一业且)
        {
            var val_17;
            System.Predicate<T> val_18;
            var val_19;
            .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
            val_18 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_18 == null)
            {
                    return (PlayerPaymentState)val_17;
            }
            
            val_19 = 0;
            goto label_4;
            label_11:
            if((val_18.丈丏丁东上与东丙丕().Item[0].Item.Id.Equals(value:  (七丏丛丐三丐专丌东.丌丟丘丏丕丅七万丕)[1152921560169583904].丞一丁业丄一一业且)) == true)
            {
                goto label_9;
            }
            
            val_19 = 1;
            label_4:
            if(val_19 < val_18.丈丏丁东上与东丙丕().Count)
            {
                goto label_11;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_11 = PGCompany.BattlePass.万丈上下三丅丘丛丒.丌丐与丂丗丒丙三七(丞世不丒下上上丝丑:  2);
            if(val_11 == null)
            {
                goto label_14;
            }
            
            System.Predicate<Rilisoft.OfferItem> val_13 = null;
            val_18 = val_13;
            val_13 = new System.Predicate<Rilisoft.OfferItem>(object:  new 七丏丛丐三丐专丌东.丌丟丘丏丕丅七万丕(), method:  System.Boolean 七丏丛丐三丐专丌东.丌丟丘丏丕丅七万丕::丘丁七丟丙上与丆万(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
            if((val_11.丈丏丁东上与东丙丕().Exists(match:  val_13)) == false)
            {
                goto label_14;
            }
            
            val_17 = 100;
            return (PlayerPaymentState)val_17;
            label_9:
            PGCompany.BattlePass.BPReward val_16 = val_18.丈丏丁东上与东丙丕().Item[0];
            if(val_16 != null)
            {
                    return val_16.PaymentState;
            }
            
            return val_16.PaymentState;
            label_14:
            val_17 = 0;
            return (PlayerPaymentState)val_17;
        }
        internal override bool 万丑万上丕丆不丒七(string 下丅丙一丂丗丅丝七, bool 丘丄一丘丁丞丘丆且)
        {
            var val_8;
            string val_9;
            var val_10;
            val_8 = 丘丄一丘丁丞丘丆且;
            val_9 = 下丅丙一丂丗丅丝七;
            bool val_1 = val_8;
            if(((this & 1) == 0) || ((this.且下丑丂丂丌丘丛丘(下丅丙一丂丗丅丝七:  val_9)) == false))
            {
                goto label_2;
            }
            
            val_8 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世();
            if(val_8.丁下三且丛丝一一丏() == false)
            {
                goto label_4;
            }
            
            val_10 = this;
            bool val_5 = this.东丕丙上丝丛丁丘且(下丅丙一丂丗丅丝七:  val_9, 丘丄一丘丁丞丘丆且:  false);
            goto label_6;
            label_4:
            val_10 = this;
            goto label_6;
            label_2:
            val_10 = 0;
            label_6:
            val_10 = val_10 & 1;
            return (bool)val_10;
        }
        private bool 且七丄专丂且且下专(string 下丅丙一丂丗丅丝七, bool 丘丄一丘丁丞丘丆且)
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return (bool)val_2;
            }
            
            if(this.丁不丝丂丅下丁丈与 != null)
            {
                    return this.丁不丝丂丅下丁丈与.Contains(item:  下丅丙一丂丗丅丝七);
            }
            
            return this.丁不丝丂丅下丁丈与.Contains(item:  下丅丙一丂丗丅丝七);
        }
        private bool 东丕丙上丝丛丁丘且(string 下丅丙一丂丗丅丝七, bool 丘丄一丘丁丞丘丆且)
        {
            .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丈万丙东东丒丏丆丝() == false)
            {
                    return false;
            }
            
            if(this.丟东丏丏丘专丝丟万 != null)
            {
                    return this.丟东丏丏丘专丝丟万.Exists(match:  new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  new 七丏丛丐三丐专丌东.三丅丞丒丕丅专一丅(), method:  System.Boolean 七丏丛丐三丐专丌东.三丅丞丒丕丅专一丅::丛丗不且丟丁七东丒(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛)));
            }
            
            return this.丟东丏丏丘专丝丟万.Exists(match:  new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  new 七丏丛丐三丐专丌东.三丅丞丒丕丅专一丅(), method:  System.Boolean 七丏丛丐三丐专丌东.三丅丞丒丕丅专一丅::丛丗不且丟丁七东丒(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛)));
        }
        internal override string 丒丅三丕丙丏丌丕不()
        {
            var val_1;
            if((this & 1) == 0)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_1 = "basic";
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        internal override System.TimeSpan 丅世不下丑且丏丙一(string 丞一丁业丄一一业且)
        {
            bool val_2 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏();
            if(val_2 != false)
            {
                    System.TimeSpan val_3 = val_2.东万与丐丈不丕丂丕(丞一丁业丄一一业且:  0);
                return (System.TimeSpan)val_4._ticks;
            }
            
            System.TimeSpan val_4 = val_2.三丒下丐上丐上三万(丞一丁业丄一一业且:  0);
            return (System.TimeSpan)val_4._ticks;
        }
        private System.TimeSpan 三丒下丐上丐上三万(string 丞一丁业丄一一业且)
        {
            var val_5;
            System.Nullable<System.TimeSpan> val_3 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丙世丑丅丒丑业与不();
            if(( & 1) != 0)
            {
                    val_5;
                return (System.TimeSpan)val_4._ticks;
            }
            
            System.TimeSpan val_4 = System.TimeSpan.FromSeconds(value:  0);
            return (System.TimeSpan)val_4._ticks;
        }
        private System.TimeSpan 东万与丐丈不丕丂丕(string 丞一丁业丄一一业且)
        {
            double val_4;
            PGCompany.PixelPass.丘丏丅丆丑下业丙七 val_1 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    val_4 = (double)val_1.丘丗不丂世丘三三丙().丂与丐下一丟丆丌与();
                return System.TimeSpan.FromSeconds(value:  val_4 = 0);
            }
            
            return System.TimeSpan.FromSeconds(value:  val_4);
        }
    
    }

}
