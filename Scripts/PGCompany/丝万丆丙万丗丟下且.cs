using UnityEngine;

namespace PGCompany
{
    internal class 丝万丆丙万丗丟下且 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private const string 与下丈丗与三丞七专 = "p";
        private const string 东丌业丘世三专丅上 = "r";
        private const string 东丈上丝世丁业且丆 = "c";
        private System.Collections.Generic.Dictionary<string, PGCompany.东世丄丛丆丏与世丑> 与丄三丆丛丒丆丟丅;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丗且三丈与东丅丞丈;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal PGCompany.东世丄丛丆丏与世丑 世丒东丆丞丕丟丂丆(string 上万丒丐万世业不丌)
        {
            System.Collections.Generic.Dictionary<System.String, PGCompany.东世丄丛丆丏与世丑> val_3 = this.与丄三丆丛丒丆丟丅;
            if((val_3.ContainsKey(key:  上万丒丐万世业不丌)) != true)
            {
                    val_3 = this.与丄三丆丛丒丆丟丅;
                val_3.set_Item(key:  上万丒丐万世业不丌, value:  new PGCompany.东世丄丛丆丏与世丑(丞丅上丏丂且下丅与:  上万丒丐万世业不丌));
            }
            
            if(this.与丄三丆丛丒丆丟丅 != null)
            {
                    return this.与丄三丆丛丒丆丟丅.Item[上万丒丐万世业不丌];
            }
            
            return this.与丄三丆丛丒丆丟丅.Item[上万丒丐万世业不丌];
        }
        internal System.Collections.Generic.Dictionary<string, object> 不丞丒业上丅丛丁丈()
        {
            var val_5;
            var val_11;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_13;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Object> val_15;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.丗且三丈与东丅丞丈.GetEnumerator();
            label_14:
            if(((-686814352) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            val_11 = null;
            val_11 = null;
            val_13 = 丝万丆丙万丗丟下且.<>c.<>9__8_0;
            if(val_13 == null)
            {
                    val_13 = null;
                val_13 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  丝万丆丙万丗丟下且.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丝万丆丙万丗丟下且.<>c::丁且丅与丞丄丙丗专(System.Collections.Generic.KeyValuePair<string, object> 七丏丄丅丌业与且丙));
                val_11 = null;
                丝万丆丙万丗丟下且.<>c.<>9__8_0 = val_13;
            }
            
            val_11 = null;
            val_15 = 丝万丆丙万丗丟下且.<>c.<>9__8_1;
            if(val_15 == null)
            {
                    val_15 = new 丝万丆丙万丗丟下且.<>c();
                val_15 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Object>(object:  丝万丆丙万丗丟下且.<>c.__il2cppRuntimeField_static_fields, method:  System.Object 丝万丆丙万丗丟下且.<>c::且丅丑丅丐下丌丗上(System.Collections.Generic.KeyValuePair<string, object> 七丏丄丅丌业与且丙));
                丝万丆丙万丗丟下且.<>c.<>9__8_1 = val_15;
            }
            
            val_1.Add(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, System.Object>(source:  val_6._value._obj, keySelector:  null, elementSelector:  new 丝万丆丙万丗丟下且.<>c()));
            goto label_14;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal void 丛丙丁与下丁丘丑丌()
        {
            this.丗且三丈与东丅丞丈.Clear();
        }
        internal void 丒丒丗丗下丗丞上丌(string 上万丒丐万世业不丌, string 丄丏丒专世丁丏下万, object 下下与丈世专丗丑且)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_4 = this.丗且三丈与东丅丞丈;
            if((val_4.ContainsKey(key:  上万丒丐万世业不丌)) != true)
            {
                    val_4 = this.丗且三丈与东丅丞丈;
                val_4.set_Item(key:  上万丒丐万世业不丌, value:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
            }
            
            this.丗且三丈与东丅丞丈.Item[上万丒丐万世业不丌].set_Item(key:  丄丏丒专世丁丏下万, value:  下下与丈世专丗丑且);
        }
        internal void 丒丏丝业丐丞三丏专(string 上万丒丐万世业不丌, int 丙业与丙丗丝不丈东)
        {
            PGCompany.东世丄丛丆丏与世丑 val_1 = this.世丒东丆丞丕丟丂丆(上万丒丐万世业不丌:  上万丒丐万世业不丌);
            if(val_1.丅专丙专丑丏丝丕与 != 丙业与丙丗丝不丈东)
            {
                    this.丒丒丗丗下丗丞上丌(上万丒丐万世业不丌:  上万丒丐万世业不丌, 丄丏丒专世丁丏下万:  "p", 下下与丈世专丗丑且:  丙业与丙丗丝不丈东);
            }
            
            PGCompany.东世丄丛丆丏与世丑 val_2 = this.世丒东丆丞丕丟丂丆(上万丒丐万世业不丌:  上万丒丐万世业不丌);
            int val_3 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            val_2.丅专丙专丑丏丝丕与 = 0;
            mem2[0] = 0;
        }
        internal void 专且丙丂丙丙丘丂上(string 上万丒丐万世业不丌, bool 丙业与丙丗丝不丈东)
        {
            if(((this.世丒东丆丞丕丟丂丆(上万丒丐万世业不丌:  上万丒丐万世业不丌).与丆丅丒丙丘丘丝丁()) ^ 丙业与丙丗丝不丈东) != false)
            {
                    this.丒丒丗丗下丗丞上丌(上万丒丐万世业不丌:  上万丒丐万世业不丌, 丄丏丒专世丁丏下万:  "r", 下下与丈世专丗丑且:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            }
            
            this.世丒东丆丞丕丟丂丆(上万丒丐万世业不丌:  上万丒丐万世业不丌).丄丑丁丌丄丒业世丄(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        internal void 三七万不七下不丏万(string 上万丒丐万世业不丌, bool 丙业与丙丗丝不丈东)
        {
            if(((this.世丒东丆丞丕丟丂丆(上万丒丐万世业不丌:  上万丒丐万世业不丌).一丏丅三丅丘下丝丄()) ^ 丙业与丙丗丝不丈东) != false)
            {
                    this.丒丒丗丗下丗丞上丌(上万丒丐万世业不丌:  上万丒丐万世业不丌, 丄丏丒专世丁丏下万:  "c", 下下与丈世专丗丑且:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            }
            
            this.世丒东丆丞丕丟丂丆(上万丒丐万世业不丌:  上万丒丐万世业不丌).丘丈世丘世丒丅丆丈(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        internal bool 业上下丗业丐丁丅上(string 上万丒丐万世业不丌)
        {
            if(this.与丄三丆丛丒丆丟丅 != null)
            {
                    return this.与丄三丆丛丒丆丟丅.Remove(key:  上万丒丐万世业不丌);
            }
            
            return this.与丄三丆丛丒丆丟丅.Remove(key:  上万丒丐万世业不丌);
        }
        internal void 不丕丐丌不专与万丑(PGCompany.丆一一丂世七丏且丝 丌丏与丐东丘东丕不)
        {
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            int val_2 = this.与丄三丆丛丒丆丟丅.Count;
            Dictionary.Enumerator<TKey, TValue> val_3 = this.与丄三丆丛丒丆丟丅.GetEnumerator();
            label_9:
            if(((-685776392) & 1) == 0)
            {
                goto label_6;
            }
            
            ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
            System.ValueTuple<PGCompany.丆一一丂世七丏且丝, System.Int32> val_6 = PGCompany.丅业且万与丛业丏世.丌七下丝丘丅丄世丝(丙下不丏丅丅专丂丗:  val_4._value._obj.丐丏七丌丕丗业且上());
            if(val_6.Item2 != 丌丏与丐东丘东丕不)
            {
                goto label_9;
            }
            
            val_1.Add(item:  val_4._value._obj.丐丏七丌丕丗业且上());
            goto label_9;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_1.ForEach(action:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.丝万丆丙万丗丟下且::丄丆丞丕七丌专专上(string 下上丐丆丝丟丝丒不)));
            if((PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不()) != null)
            {
                    return;
            }
        
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 33;
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
            Rilisoft.丝丑丂丛万丐丈丘且 val_5;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0.GetEnumerator();
            label_26:
            if(((-685275152) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            new PGCompany.东世丄丛丆丏与世丑() = new PGCompany.东世丄丛丆丏与世丑(丞丅上丏丂且下丅与:  val_6._value._obj.丐丏七丌丕丗业且上());
            if(val_6._value._obj == 0)
            {
                goto label_26;
            }
            
            int val_9 = 0;
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6._value._obj, 下上丐丆丝丟丝丒不:  "p", 丙业与丙丗丝不丈东: out  val_9)) != false)
            {
                    int val_11 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
                val_5 = 0;
                .丅专丙专丑丏丝丕与 = val_5;
                mem[1152921555461231744] = 0;
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6._value._obj, 下上丐丆丝丟丝丒不:  "c", 丙业与丙丗丝不丈东: out  val_9)) != false)
            {
                    new PGCompany.东世丄丛丆丏与世丑().丘丈世丘世丒丅丆丈(丙业与丙丗丝不丈东:  丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  0));
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6._value._obj, 下上丐丆丝丟丝丒不:  "r", 丙业与丙丗丝不丈东: out  val_9)) != false)
            {
                    new PGCompany.东世丄丛丆丏与世丑().丄丑丁丌丄丒业世丄(丙业与丙丗丝不丈东:  丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  0));
            }
            
            this.与丄三丆丛丒丆丟丅.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  new PGCompany.东世丄丛丆丏与世丑());
            goto label_26;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            object val_5;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.与丄三丆丛丒丆丟丅.GetEnumerator();
            label_22:
            if(((-685112976) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if((-685112968) >= 1)
            {
                    val_5 = val_5;
                null.Add(key:  "p", value:  val_5);
            }
            
            if(val_6._value._obj.一丏丅三丅丘下丝丄() != false)
            {
                    val_5 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  val_6._value._obj.一丏丅三丅丘下丝丄());
                null.Add(key:  "c", value:  val_5);
            }
            
            if(val_6._value._obj.与丆丅丒丙丘丘丝丁() != false)
            {
                    val_5 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  val_6._value._obj.与丆丅丒丙丘丘丝丁());
                null.Add(key:  "r", value:  val_5);
            }
            
            if(null.Count < 1)
            {
                goto label_22;
            }
            
            val_1.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  null);
            goto label_22;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (object)val_1;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.与丄三丆丛丒丆丟丅.Clear();
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)PGCompany.丝万丆丙万丗丟下且.东丈上丝世丁业且丆;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)PGCompany.丝万丆丙万丗丟下且.丐丌丞上世丛丐丏丛;
        }
        public 丝万丆丙万丗丟下且()
        {
            this.与丄三丆丛丒丆丟丅 = new System.Collections.Generic.Dictionary<System.String, PGCompany.东世丄丛丆丏与世丑>();
            this.丗且三丈与东丅丞丈 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>();
        }
        private static 丝万丆丙万丗丟下且()
        {
            PGCompany.丝万丆丙万丗丟下且.东丈上丝世丁业且丆 = "GameTask_Slot";
            PGCompany.丝万丆丙万丗丟下且.丐丌丞上世丛丐丏丛 = "GameTask_Slot_Key_JUN_2019";
        }
        private void 丄丆丞丕七丌专专上(string 下上丐丆丝丟丝丒不)
        {
            bool val_1 = this.与丄三丆丛丒丆丟丅.Remove(key:  下上丐丆丝丟丝丒不);
        }
    
    }

}
