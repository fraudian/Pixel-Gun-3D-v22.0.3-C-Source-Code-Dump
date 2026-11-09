using UnityEngine;

namespace PGCompany.GameplayLoop
{
    internal class 丕丌东与丘业丈丏丆 : 业丒丅丂丗丁业上且
    {
        // Fields
        private readonly System.Collections.Generic.List<string> 不丏丛丄丅且丟三丛;
        
        // Methods
        public 丕丌东与丘业丈丏丆()
        {
            this.不丏丛丄丅且丟三丛 = new System.Collections.Generic.List<System.String>();
            mem[1152921560175468080] = 5;
            this.丂且丗万丁下丞万丁();
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丐丐且下丁丄丒专丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameplayLoop.丕丌东与丘业丈丏丆::丂且丗万丁下丞万丁()));
        }
        internal override bool 丑丏丙丑且丞丈丝业(bool 丘丄一丘丁丞丘丆且)
        {
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_1 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.业七丟丕东七丕专下();
            }
            
            return val_1.业七丟丕东七丕专下();
        }
        internal override bool 万丑万上丕丆不丒七(string 下丅丙一丂丗丅丝七, bool 丘丄一丘丁丞丘丆且)
        {
            var val_26;
            string val_27;
            string val_28;
            var val_29;
            val_26 = 丘丄一丘丁丞丘丆且;
            val_27 = 下丅丙一丂丗丅丝七;
            bool val_1 = val_26;
            if((this & 1) == 0)
            {
                    return false;
            }
            
            if((this.且下丑丂丂丌丘丛丘(下丅丙一丂丗丅丝七:  val_27)) == false)
            {
                    return false;
            }
            
            三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_27);
            if(val_3 == null)
            {
                goto label_7;
            }
            
            val_28 = val_3.三与丛丑且丐丈业丌();
            if((this.不丏丛丄丅且丟三丛.Contains(item:  val_28)) == false)
            {
                goto label_7;
            }
            
            val_27 = val_3.三与丛丑且丐丈业丌();
            goto label_27;
            label_7:
            if((this.不丏丛丄丅且丟三丛.Contains(item:  val_27)) == true)
            {
                goto label_27;
            }
            
            val_29 = 0;
            goto label_11;
            label_29:
            val_28 = this.不丏丛丄丅且丟三丛.Item[0];
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_28)) != false)
            {
                    string val_11 = this.不丏丛丄丅且丟三丛.Item[0];
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_11)) != false)
            {
                    val_28 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞();
                丛且专丞丗丆丙丒万 val_14 = val_28.Item[val_11];
                if(val_14.上七不丅丈丁不丛丝 != null)
            {
                    if((val_14.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  val_27)) == true)
            {
                goto label_27;
            }
            
            }
            
            }
            
            }
            
            val_29 = 1;
            label_11:
            if(val_29 < this.不丏丛丄丅且丟三丛.Count)
            {
                goto label_29;
            }
            
            label_27:
            System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_18 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丏丛丏丁专丏丞丘业();
            val_26 = 0;
            goto label_31;
            label_42:
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_19 = val_18.Item[0];
            if((val_19.万七上丁丑丞业丑丛(下丅丙一丂丗丅丝七:  val_27)) != false)
            {
                    val_28 = System.Math.Max(val1:  1, val2:  LeaderboardEventController.丑丐丄丆丛丁丟丗丅.丁上丁专东丌东丐丞(丟丟丄专上丟丁丐丝:  val_19.业上丙丞丐丄丆丅七()));
                if((val_19.丁丂丄丅丑一东万丕(下丅丙一丂丗丅丝七:  val_27, 且丒丛与丞世丙丕丌:  val_28)) == true)
            {
                    return false;
            }
            
            }
            
            val_26 = 1;
            label_31:
            if(val_26 < val_18.Count)
            {
                goto label_42;
            }
            
            return false;
        }
        private void 丂且丗万丁下丞万丁()
        {
            var val_11;
            System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Collections.Generic.IEnumerable<System.String>> val_13;
            var val_14;
            System.Func<System.String, System.Boolean> val_16;
            var val_17;
            System.Func<System.String, System.String> val_19;
            this.不丏丛丄丅且丟三丛.Clear();
            val_11 = null;
            val_11 = null;
            val_13 = 丕丌东与丘业丈丏丆.<>c.<>9__3_0;
            if(val_13 == null)
            {
                    System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Collections.Generic.IEnumerable<System.String>> val_3 = null;
                val_13 = val_3;
                val_3 = new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Collections.Generic.IEnumerable<System.String>>(object:  丕丌东与丘业丈丏丆.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.String> 丕丌东与丘业丈丏丆.<>c::世丟一丑上业丗与业(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 三丟东丕丄丄下下丑));
                丕丌东与丘业丈丏丆.<>c.<>9__3_0 = val_13;
            }
            
            this.不丏丛丄丅且丟三丛.AddRange(collection:  System.Linq.Enumerable.Distinct<System.String>(source:  System.Linq.Enumerable.SelectMany<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.String>(source:  PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丅丒丐七丒且丂专丒(), selector:  val_3)));
            val_14 = null;
            val_14 = null;
            val_16 = 丕丌东与丘业丈丏丆.<>c.<>9__3_1;
            if(val_16 == null)
            {
                    System.Func<System.String, System.Boolean> val_6 = null;
                val_16 = val_6;
                val_6 = new System.Func<System.String, System.Boolean>(object:  丕丌东与丘业丈丏丆.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丕丌东与丘业丈丏丆.<>c::七丑万世且丞丑丌丈(string 三丟东丕丄丄下下丑));
                丕丌东与丘业丈丏丆.<>c.<>9__3_1 = val_16;
            }
            
            val_17 = null;
            val_17 = null;
            val_19 = 丕丌东与丘业丈丏丆.<>c.<>9__3_2;
            if(val_19 == null)
            {
                    System.Func<System.String, System.String> val_8 = null;
                val_19 = val_8;
                val_8 = new System.Func<System.String, System.String>(object:  丕丌东与丘业丈丏丆.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丌东与丘业丈丏丆.<>c::丞且丄丐与丘丅三万(string 三丟东丕丄丄下下丑));
                丕丌东与丘业丈丏丆.<>c.<>9__3_2 = val_19;
            }
            
            this.不丏丛丄丅且丟三丛.AddRange(collection:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.String, System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  this.不丏丛丄丅且丟三丛, predicate:  val_6), selector:  val_8)));
        }
        internal override string 丒丅三丕丙丏丌丕不()
        {
            return "basic";
        }
        internal override System.TimeSpan 丅世不下丑且丏丙一(string 丞一丁业丄一一业且)
        {
            var val_5;
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_2 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丒丈世万业丌丌丅专(下丅丙一丂丗丅丝七:  丞一丁业丄一一业且);
            if(val_2 != null)
            {
                    System.Nullable<System.TimeSpan> val_3 = val_2.丙世丑丅丒丑业与不();
                val_5;
                return (System.TimeSpan)val_4._ticks;
            }
            
            System.TimeSpan val_4 = val_2.丅世不下丑且丏丙一(丞一丁业丄一一业且:  丞一丁业丄一一业且);
            return (System.TimeSpan)val_4._ticks;
        }
    
    }

}
