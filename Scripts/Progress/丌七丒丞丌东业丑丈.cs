using UnityEngine;

namespace Progress
{
    internal class 丌七丒丞丌东业丑丈 : 丙丕丈一一丝丑七丈
    {
        // Fields
        private const int 世丛丟丑专丑万丛丝 = 10;
        private readonly System.Collections.Generic.List<Progress.丝下丛万丐丙且七丌> 丙世丁丗丏一丟丒丒;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal System.Collections.Generic.List<Progress.丝下丛万丐丙且七丌> 丌且且三丂丐下东丑()
        {
            return (System.Collections.Generic.List<Progress.丝下丛万丐丙且七丌>)this.丙世丁丗丏一丟丒丒;
        }
        internal void 且下丐万丒丐丄专丌(Progress.丝下丛万丐丙且七丌 与丛丙一丙丆丁七业)
        {
            System.Collections.Generic.List<Progress.丝下丛万丐丙且七丌> val_5;
            .与丛丙一丙丆丁七业 = 与丛丙一丙丆丁七业;
            int val_3 = this.丙世丁丗丏一丟丒丒.FindIndex(match:  new System.Predicate<Progress.丝下丛万丐丙且七丌>(object:  new 丌七丒丞丌东业丑丈.上丌专丄丘丂东且丒(), method:  System.Boolean 丌七丒丞丌东业丑丈.上丌专丄丘丂东且丒::东丈丑业丌丌上丏丄(Progress.丝下丛万丐丙且七丌 三丟东丕丄丄下下丑)));
            val_5 = this.丙世丁丗丏一丟丒丒;
            if((val_3 & 2147483648) == 0)
            {
                    val_5.set_Item(index:  val_3, value:  (丌七丒丞丌东业丑丈.上丌专丄丘丂东且丒)[1152921541302518864].与丛丙一丙丆丁七业);
                return;
            }
            
            if(val_5.Count >= 10)
            {
                    val_5 = this.丙世丁丗丏一丟丒丒;
                val_5.RemoveAt(index:  0);
            }
            
            this.丙世丁丗丏一丟丒丒.Add(item:  (丌七丒丞丌东业丑丈.上丌专丄丘丂东且丒)[1152921541302518864].与丛丙一丙丆丁七业);
        }
        internal bool 下一丐丈不丟丄世丌(string 丄丒且丙三丆丟与丏)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = 0;
            goto label_1;
            label_13:
            var val_10 = 0;
            label_10:
            val_11 = this.丙世丁丗丏一丟丒丒.Item[0].丈丟丂丐一丕七东丗();
            if(val_10 >= val_11.Count)
            {
                goto label_5;
            }
            
            val_11 = this.丙世丁丗丏一丟丒丒.Item[0].丈丟丂丐一丕七东丗().Item[0];
            val_10 = val_10 + 1;
            if((System.String.op_Equality(a:  val_11.业上丙丞丐丄丆丅七(), b:  丄丒且丙三丆丟与丏)) == false)
            {
                goto label_10;
            }
            
            goto label_11;
            label_5:
            val_10 = 1;
            label_1:
            if(val_10 < this.丙世丁丗丏一丟丒丒.Count)
            {
                goto label_13;
            }
            
            val_12 = 0;
            return (bool)val_12;
            label_11:
            val_12 = 1;
            return (bool)val_12;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 57;
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
            return "slot_match_history";
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            return "slot_match_history_key";
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.List<System.Object> val_2 = 0;
            val_9 = 0;
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "h", 丙业与丙丗丝不丈东: out  val_2)) == false)
            {
                    return;
            }
            
            val_10 = 0;
            goto label_7;
            label_14:
            val_11 = 0;
            this.丙世丁丗丏一丟丒丒.Add(item:  val_2.Item[0].下丆专丆七上万上丙(与丛丙一丙丆丁七业:  null));
            val_10 = 1;
            label_7:
            val_8 = val_2;
            if(val_10 < val_8.Count)
            {
                goto label_14;
            }
        
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "h", value:  System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Select<Progress.丝下丛万丐丙且七丌, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  this.丙世丁丗丏一丟丒丒, selector:  new System.Func<Progress.丝下丛万丐丙且七丌, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  this, method:  System.Collections.Generic.Dictionary<System.String, System.Object> Progress.丌七丒丞丌东业丑丈::丘上且东一下丁丏下(Progress.丝下丛万丐丙且七丌 与丛丙一丙丆丁七业)))));
            return (object)val_1;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丙世丁丗丏一丟丒丒.Clear();
        }
        internal override void 与世丄万丈丈上丆下()
        {
            goto typeof(Progress.丌七丒丞丌东业丑丈).__il2cppRuntimeField_228;
        }
        private System.Collections.Generic.Dictionary<string, object> 丘上且东一下丁丏下(Progress.丝下丛万丐丙且七丌 与丛丙一丙丆丁七业)
        {
            var val_34;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            System.Collections.Generic.List<System.Object> val_2 = new System.Collections.Generic.List<System.Object>();
            val_34 = 0;
            goto label_1;
            label_33:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_3.Add(key:  "i", value:  与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗().Item[0].业上丙丞丐丄丆丅七());
            val_3.Add(key:  "t", value:  与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗().Item[0].七丟丈万三下丗丁丗());
            val_3.Add(key:  "n", value:  与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗().Item[0].与与丌万丟丄丌丘三());
            val_3.Add(key:  "p", value:  与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗().Item[0].三丄丏丂丁下丐丛万());
            val_3.Add(key:  "s", value:  与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗().Item[0].丑一三丙丐丕丕三丕());
            val_3.Add(key:  "k", value:  与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗().Item[0].丏七丘丗东丈三丝万());
            val_3.Add(key:  "c", value:  与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗().Item[0].一丁丈丕丁业下不丁());
            val_2.Add(item:  val_3);
            val_34 = 1;
            label_1:
            if(val_34 < 与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗().Count)
            {
                goto label_33;
            }
            
            val_1.set_Item(key:  "p", value:  val_2);
            val_1.set_Item(key:  "m", value:  与丛丙一丙丆丁七业.业丄丄且丕丕不一万());
            val_1.set_Item(key:  "r", value:  与丛丙一丙丆丁七业.丑丄丁且丂丈万丞世());
            val_1.set_Item(key:  "c", value:  与丛丙一丙丆丁七业.丌丈丁丕丕世与上七());
            val_1.set_Item(key:  "t", value:  与丛丙一丙丆丁七业.三丂丈丅丞上丁专不());
            System.Nullable<System.Boolean> val_31 = 与丛丙一丙丆丁七业.丝专业丄丂丂丈丕与();
            if(val_31.HasValue.GetValueOrDefault() == false)
            {
                    return val_1;
            }
            
            if(((-1957396756) & 1) == 0)
            {
                    return val_1;
            }
            
            System.Nullable<System.Boolean> val_33 = 与丛丙一丙丆丁七业.丝专业丄丂丂丈丕与();
            val_1.set_Item(key:  "x", value:  val_33.HasValue);
            return val_1;
        }
        private Progress.丝下丛万丐丙且七丌 下丆专丆七上万上丙(System.Collections.Generic.Dictionary<string, object> 与丛丙一丙丆丁七业)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_31;
            var val_32;
            var val_33;
            val_31 = 与丛丙一丙丆丁七业;
            int val_22 = 0;
            int val_27 = 0;
            string val_7 = 0;
            long val_29 = 0;
            string val_11 = 0;
            int val_17 = 0;
            Progress.丝下丛万丐丙且七丌 val_1 = new Progress.丝下丛万丐丙且七丌();
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  val_31, 下上丐丆丝丟丝丒不:  "p", 丙业与丙丗丝不丈东: out  0)) == false)
            {
                goto label_3;
            }
            
            val_31 = 0;
            goto label_4;
            label_40:
            val_32 = val_2.Item[0];
            丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 val_5 = new 丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄();
            if(val_32 != null)
            {
                    val_32 = 0;
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "i", 丙业与丙丗丝不丈东: out  val_7)) != false)
            {
                    val_5.丒丞东丈丁丄丑丅且(丙业与丙丗丝不丈东:  val_7);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "t", 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_5.万三丐丏与专丞与丕(丙业与丙丗丝不丈东:  0);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "n", 丙业与丙丗丝不丈东: out  val_11)) != false)
            {
                    val_5.东业丑丗丂丅七万丁(丙业与丙丗丝不丈东:  val_11);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "p", 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_5.丁丗丗专丗与丗丗丌(丙业与丙丗丝不丈东:  0);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "s", 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_5.丗三丑丏下丕丟丙丝(丙业与丙丗丝不丈东:  0);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "k", 丙业与丙丗丝不丈东: out  val_17)) != false)
            {
                    val_5.东丂丗业东丆丌丈丌(丙业与丙丗丝不丈东:  0);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "c", 丙业与丙丗丝不丈东: out  val_17)) != false)
            {
                    val_5.丝东丑丒丒丛东七世(丙业与丙丗丝不丈东:  0);
            }
            
            val_1.丈丟丂丐一丕七东丗().Add(item:  val_5);
            val_31 = 1;
            label_4:
            if(val_31 < val_2.Count)
            {
                goto label_40;
            }
            
            label_3:
            val_33 = 1152921524472663264;
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_31, 下上丐丆丝丟丝丒不:  "m", 丙业与丙丗丝不丈东: out  val_22)) != false)
            {
                    val_31 = 0;
                val_1.丑丈丙丟丑丆丌且丛(丙业与丙丗丝不丈东:  val_31);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_31, 下上丐丆丝丟丝丒不:  "r", 丙业与丙丗丝不丈东: out  val_22)) != false)
            {
                    val_31 = 0;
                val_1.丝丛丞丛丞丌丑且世(丙业与丙丗丝不丈东:  val_31);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Boolean>(丏丂万业丙专丏丒丒:  val_31, 下上丐丆丝丟丝丒不:  "x", 丙业与丙丗丝不丈东: out  false)) != false)
            {
                    val_1.丕专丗上丝丐业不专(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_31, 下上丐丆丝丟丝丒不:  "c", 丙业与丙丗丝不丈东: out  val_27)) != false)
            {
                    val_31 = val_27;
                val_1.三丄丗丛丁丕专丕丏(丙业与丙丗丝不丈东:  0);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int64>(丏丂万业丙专丏丒丒:  val_31, 下上丐丆丝丟丝丒不:  "t", 丙业与丙丗丝不丈东: out  val_29)) == false)
            {
                    return val_1;
            }
            
            val_33 = val_29;
            val_1.万丝万丛丄丁丘一丝(丙业与丙丗丝不丈东:  0);
            return val_1;
        }
        public 丌七丒丞丌东业丑丈()
        {
            this.丙世丁丗丏一丟丒丒 = new System.Collections.Generic.List<Progress.丝下丛万丐丙且七丌>(capacity:  10);
        }
    
    }

}
