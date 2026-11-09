using UnityEngine;

namespace PGCompany
{
    internal sealed class 世丂丗丆上七与丕七
    {
        // Fields
        private PGCompany.丛上丐万下丘丙丘丌 丒丄丅丟丞丅丄七丕;
        private System.Collections.Generic.List<PGCompany.与万丝丞下丒丗丏丙> 业上丞丅丁上丄业丗;
        
        // Properties
        internal int 丐丒且丝丛丁丕丟丅 { get; }
        internal int 万下丈且七丁丐专丒 { get; }
        internal int 且丑世专丐丑不下丏 { get; }
        internal bool 丒丙一专丙万东丘丞 { get; }
        internal int 丝上丆丁丅丝丞丈丆 { get; }
        private PGCompany.丞丞下业且三丕丈丂 丂且不业丂专丛丆东 { get; }
        internal int 下与专丝丒丕万丞万 { get; }
        internal int 与丐丟世丄且一东下 { get; }
        
        // Methods
        internal int 业东丅东丌上丗丑不()
        {
        
        }
        internal int 且丅丘丒丏不丞丌丙()
        {
            if(this.丒丄丅丟丞丅丄七丕 == null)
            {
                    return 0;
            }
            
            return 0;
        }
        internal int 丙丈丗丌丘三丄业且()
        {
            if(this.丒丄丅丟丞丅丄七丕 == null)
            {
                    return 0;
            }
            
            return 0;
        }
        internal bool 世丅丄丆丛世七专丟()
        {
            if(this.丒丄丅丟丞丅丄七丕 == null)
            {
                    return false;
            }
            
            return (bool)(this.丒丄丅丟丞丅丄七丕.SkipCooldownOnBuy == true) ? 1 : 0;
        }
        internal int 一丁丈专三丅不丒丒()
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3;
            var val_4;
            if(this.七三丞丛丝丞业丞丄() < 1)
            {
                goto label_0;
            }
            
            if(this.丒丄丅丟丞丅丄七丕 == null)
            {
                goto label_1;
            }
            
            val_3 = this.丒丄丅丟丞丅丄七丕.Cooldown;
            goto label_2;
            label_0:
            val_4 = 0;
            return (int)val_4;
            label_1:
            val_3 = 0;
            label_2:
            val_4 = val_3 + this.七三丞丛丝丞业丞丄();
            return (int)val_4;
        }
        private PGCompany.丞丞下业且三丕丈丂 丛丞三丒丌且丝三与()
        {
            Progress.丆且东丟一丞东一丅 val_1 = Progress.七七世万专丕丁上业.丘上上万丆丈上一丗();
            if(val_1 != null)
            {
                    return val_1.世丟丌丛不三不丐丌(丒丞且丟丆丆七三丒:  this.业东丅东丌上丗丑不());
            }
            
            return val_1.世丟丌丛不三不丐丌(丒丞且丟丆丆七三丒:  this.业东丅东丌上丗丑不());
        }
        internal int 不丑下丌丁丝丁丐世()
        {
            PGCompany.丞丞下业且三丕丈丂 val_1 = this.丛丞三丒丌且丝三与();
            if(val_1 == null)
            {
                    return (int)val_1;
            }
            
            return val_1.不丑下丌丁丝丁丐世();
        }
        internal int 七三丞丛丝丞业丞丄()
        {
            PGCompany.丞丞下业且三丕丈丂 val_1 = this.丛丞三丒丌且丝三与();
            if(val_1 == null)
            {
                    return (int)val_1;
            }
            
            return val_1.七三丞丛丝丞业丞丄();
        }
        internal 世丂丗丆上七与丕七(PGCompany.丛上丐万下丘丙丘丌 与不丕丆丈不丙丟丛, System.Collections.Generic.List<PGCompany.与万丝丞下丒丗丏丙> 丅丑业丂三丛与丒丞)
        {
            val_1 = new System.Object();
            this.丒丄丅丟丞丅丄七丕 = 与不丕丆丈不丙丟丛;
            this.业上丞丅丁上丄业丗 = val_1;
        }
        internal bool 丆下丝丟丛不三丟丟()
        {
            var val_9;
            var val_10;
            val_9 = this;
            if((this.丒丄丅丟丞丅丄七丕.PopupAmount >= 1) && (this.丒丄丅丟丞丅丄七丕.PopupCooldown >= 1))
            {
                    val_9 = this.丛丞三丒丌且丝三与().上丈丌丝丘且万与丟();
                val_10 = ((this.丒丄丅丟丞丅丄七丕.PopupAmount > this.丛丞三丒丌且丝三与().一且丞万东丂丑且丞()) ? 1 : 0) & ((PixelTime.丝丗专上三不丄丑丑() > ((val_9 + this.丒丄丅丟丞丅丄七丕.PopupCooldown) << )) ? 1 : 0);
                return (bool)val_10;
            }
            
            val_10 = 1;
            return (bool)val_10;
        }
        internal void 丐丒三下丛丟业业丑()
        {
            var val_16;
            int val_17;
            if(PixelTime.丝丗专上三不丄丑丑() <= ((this.丛丞三丒丌且丝三与().上丈丌丝丘且万与丟() + this.丒丄丅丟丞丅丄七丕.PopupCooldown) << ))
            {
                goto label_5;
            }
            
            if((this.丒丄丅丟丞丅丄七丕.PopupAmount - this.丛丞三丒丌且丝三与().一且丞万东丂丑且丞()) == 1)
            {
                goto label_10;
            }
            
            val_16 = this.丛丞三丒丌且丝三与().一且丞万东丂丑且丞() + 1;
            if(val_16 == 0)
            {
                goto label_10;
            }
            
            val_17 = 0;
            goto label_11;
            label_5:
            val_17 = this.丛丞三丒丌且丝三与().上丈丌丝丘且万与丟();
            goto label_13;
            label_10:
            val_17 = PixelTime.丝丗专上三不丄丑丑();
            label_13:
            val_16 = 0;
            label_11:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丑丟且丘丈丒东世不(丗丞七不下丗上丙丂:  this.业东丅东丌上丗丑不(), 丝丏丁丙下上三丂业:  0, 专万下丕下一丁世丕:  val_17);
        }
        internal bool 丘丒丑东丒丗丘丏业(bool 丂丄丄丗三万一丈丆 = False)
        {
            .丂丄丄丗三万一丈丆 = 丂丄丄丗三万一丈丆;
            int val_8 = this.业上丞丅丁上丄业丗.FindAll(match:  new System.Predicate<PGCompany.与万丝丞下丒丗丏丙>(object:  new 世丂丗丆上七与丕七.丈业丗丞丁七下一不(), method:  System.Boolean 世丂丗丆上七与丕七.丈业丗丞丁七下一不::丑七丙丏东且专与三(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万))).Count;
            var val_9 = (val_8 > 0) ? 1 : 0;
            val_9 = this.业丛上丕丐专下业三() & val_9;
            val_9 = this.万上丘专七下七丘丐() & val_9;
            val_8 = this.丕不丞不丁丄上丙丄() & val_9;
            return (bool)val_8;
        }
        internal bool 丒丄且丒丕且万万丙()
        {
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            System.Func<PGCompany.与万丝丞下丒丗丏丙, System.Int32> val_37;
            System.Predicate<T> val_38;
            var val_39;
            PGCompany.丛上丐万下丘丙丘丌 val_40;
            int val_41;
            val_30 = this;
            val_31 = 0;
            if((this.丘丒丑东丒丗丘丏业(丂丄丄丗三万一丈丆:  false)) == false)
            {
                    return (bool)val_31;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  157);
            if(this.丒丄丅丟丞丅丄七丕 != null)
            {
                    val_32 = this.丒丄丅丟丞丅丄七丕.StartLimit;
            }
            else
            {
                    val_32 = 0;
            }
            
            int val_3 = this.不丑下丌丁丝丁丐世();
            int val_5 = UnityEngine.Mathf.Max(a:  0, b:  val_32 - val_3);
            if(val_5 < 1)
            {
                goto label_9;
            }
            
            val_33 = 0;
            val_34 = 0;
            goto label_21;
            label_32:
            val_35 = null;
            val_35 = null;
            val_37 = 世丂丗丆上七与丕七.<>c.<>9__22_1;
            if(val_37 == null)
            {
                    System.Func<PGCompany.与万丝丞下丒丗丏丙, System.Int32> val_6 = null;
                val_37 = val_6;
                val_6 = new System.Func<PGCompany.与万丝丞下丒丗丏丙, System.Int32>(object:  世丂丗丆上七与丕七.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 世丂丗丆上七与丕七.<>c::丈丂丗丁下丕丌丛丕(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万));
                世丂丗丆上七与丕七.<>c.<>9__22_1 = val_37;
            }
            
            mem2[0] = System.Linq.Enumerable.Max<PGCompany.与万丝丞下丒丗丏丙>(source:  X22, selector:  val_6);
            System.Predicate<PGCompany.与万丝丞下丒丗丏丙> val_8 = null;
            val_38 = val_8;
            val_8 = new System.Predicate<PGCompany.与万丝丞下丒丗丏丙>(object:  val_3, method:  System.Boolean 世丂丗丆上七与丕七.丌丐丝丐下上三丛丌::丑万上丈专丆丑丝丐(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万));
            val_34 = 1;
            val_33 = (丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.与万丝丞下丒丗丏丙>(丑东与丅丐丅丂丞业:  X22.FindAll(match:  val_8)).丒丄且丒丕且万万丙())) + val_33;
            if(val_34 < val_5)
            {
                goto label_21;
            }
            
            goto label_33;
            label_29:
            System.Predicate<PGCompany.与万丝丞下丒丗丏丙> val_14 = null;
            val_38 = val_14;
            val_14 = new System.Predicate<PGCompany.与万丝丞下丒丗丏丙>(object:  世丂丗丆上七与丕七.<>c.<>9, method:  System.Boolean 世丂丗丆上七与丕七.<>c::世丞不与丝丞东丆丟(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万));
            世丂丗丆上七与丕七.<>c.<>9__22_0 = val_38;
            if(X22 != 0)
            {
                goto label_26;
            }
            
            goto label_26;
            label_21:
            世丂丗丆上七与丕七.丌丐丝丐下上三丛丌 val_15 = new 世丂丗丆上七与丕七.丌丐丝丐下上三丛丌();
            val_39 = null;
            val_39 = null;
            val_38 = 世丂丗丆上七与丕七.<>c.<>9__22_0;
            if(val_38 == null)
            {
                goto label_29;
            }
            
            label_26:
            if((this.业上丞丅丁上丄业丗.FindAll(match:  val_14).Count) != 0)
            {
                goto label_32;
            }
            
            goto label_33;
            label_9:
            val_33 = 0;
            label_33:
            val_40 = this.丒丄丅丟丞丅丄七丕;
            if(val_40 != null)
            {
                    val_40 = this.丒丄丅丟丞丅丄七丕.StartLimit;
            }
            
            if((this.不丑下丌丁丝丁丐世() + val_33) < val_40)
            {
                    val_41 = this.业东丅东丌上丗丑不();
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().上丅丛丞下一丅下一(丒丞且丟丆丆七三丒:  val_41, 一丘丏丒丛丞专七丗:  this.不丑下丌丁丝丁丐世() + val_33);
            }
            else
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().上丅丛丞下一丅下一(丒丞且丟丆丆七三丒:  this.业东丅东丌上丗丑不(), 一丘丏丒丛丞专七丗:  0);
                val_41 = PixelTime.丙丅丅业丟丁世丁丗();
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄丐七丞丕丒专丏一(丒丞且丟丆丆七三丒:  this.业东丅东丌上丗丑不(), 三丝东且三下万丅丄:  val_41);
            }
            
            val_30 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_30.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            val_31 = 1;
            return (bool)val_31;
        }
        internal bool 丕不丞不丁丄上丙丄()
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(this.一丁丈专三丅不丒丒() != 0)
            {
                    val_5 = this.一丁丈专三丅不丒丒();
                var val_4 = (PixelTime.丙丅丅业丟丁世丁丗() >= (val_5 << )) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 1;
            return (bool)val_6;
        }
        private bool 业丛上丕丐专下业三()
        {
            if(this.丒丄丅丟丞丅丄七丕 != null)
            {
                    return PGCompany.AttributeSystem.万丒万丌丘丁东丟业.丒丁丗与丏上专丞丘(丕下丂丒丌丟东丟一:  this.丒丄丅丟丞丅丄七丕.ConditionAttributeDatas);
            }
            
            return PGCompany.AttributeSystem.万丒万丌丘丁东丟业.丒丁丗与丏上专丞丘(丕下丂丒丌丟东丟一:  this.丒丄丅丟丞丅丄七丕.ConditionAttributeDatas);
        }
        private bool 万上丘专七下七丘丐()
        {
            var val_2;
            System.Func<PGCompany.下丄丄丞三且丒下业, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = 世丂丗丆上七与丕七.<>c.<>9__25_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.All<PGCompany.下丄丄丞三且丒下业>(source:  this.丒丄丅丟丞丅丄七丕.ConditionItemDatas, predicate:  System.Func<PGCompany.下丄丄丞三且丒下业, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<PGCompany.下丄丄丞三且丒下业, System.Boolean>(object:  世丂丗丆上七与丕七.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 世丂丗丆上七与丕七.<>c::丞业不专丂万丕世丟(PGCompany.下丄丄丞三且丒下业 不丂上丝丛丂丏丂丆));
            世丂丗丆上七与丕七.<>c.<>9__25_0 = val_4;
            return System.Linq.Enumerable.All<PGCompany.下丄丄丞三且丒下业>(source:  this.丒丄丅丟丞丅丄七丕.ConditionItemDatas, predicate:  val_1);
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{0}: promotions={1}", arg0:  this.业东丅东丌上丗丑不(), arg1:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.业上丞丅丁上丄业丗));
        }
    
    }

}
